using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyImageDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                LeftPbx.Image = new Bitmap(OpenFileDlg.FileName);
                RigthPbx.Image = null;
            }
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            AlgorithmCbx.Items.Clear();

            var algorithms = GetAllAlgorithms();

            foreach (var algorithm in algorithms)
            {
                AlgorithmCbx.Items.Add(algorithm);
            }

            AlgorithmCbx.SelectedIndex = 0;
        }

        private AlgorithmSchema[] GetAllAlgorithms()
        {
            IntPtr ptr;
            int count = 0;
            GetAllAlgorithms(out ptr, out count);
            var result = new AlgorithmSchema[count];

            for (var i = 0; i < count; i++)
            {
                result[i] = (AlgorithmSchema)Marshal.PtrToStructure((IntPtr)((int)ptr + (i * Marshal.SizeOf(typeof(AlgorithmSchema)))), typeof(AlgorithmSchema));
            }

            return result;
        }

        private void TransformBtn_Click(object sender, EventArgs e)
        {
            if (AlgorithmCbx.SelectedIndex < 0)
            {
                MessageBox.Show("You must select an algorithm");
                return;
            }

            var src = new Bitmap(LeftPbx.Image);
            var rawImage = BitmapToRaw(src);
            var resultRawImage = new byte[src.Width * src.Height];

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Transform(AlgorithmCbx.SelectedIndex, rawImage, src.Width, src.Height, resultRawImage);
            watch.Stop();
            TimeExLbl.Text = watch.ElapsedMilliseconds.ToString();
            RigthPbx.Image = RawToBitmap(resultRawImage, src.Width, src.Height);
        }

        [DllImport(@"EasyImageLib.dll", EntryPoint = "#3", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void GetAllAlgorithms(out IntPtr BspSchemaArray, out int NumberOfElements);

        [DllImport(@"EasyImageLib.dll", EntryPoint = "#4", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        public static extern void Transform(int algorithmIndex, byte[] inputImage, int w, int h, byte[] outputImage);

        [DllImport(@"EasyImageLib.dll", EntryPoint = "#1", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void FastBitmapToRaw(PixelFormat pixelformat, int width, int height, int stride, IntPtr scan, byte[] barray);

        [DllImport(@"EasyImageLib.dll", EntryPoint = "#2", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
        private static extern void FastRawToBitmap(int width, int height, int stride, IntPtr scan, byte[] barray);

        public static byte[] BitmapToRaw(Bitmap bmp)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                              ImageLockMode.ReadWrite, bmp.PixelFormat);

            var bt = new byte[((bmp.Width) * (bmp.Height))];
            FastBitmapToRaw(bmp.PixelFormat, bmp.Width, bmp.Height, bmData.Stride, bmData.Scan0, bt);
            bmp.UnlockBits(bmData);
            return bt;
        }

        public static Bitmap RawToBitmap(byte[] raw, int width, int height)
        {
            var bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            var cp = bmp.Palette;
            for (var i = 0; i < 256; i++) cp.Entries[i] = Color.FromArgb(i, i, i);
            bmp.Palette = cp;
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                                              ImageLockMode.ReadWrite, bmp.PixelFormat);
            FastRawToBitmap(width, height, bmData.Stride, bmData.Scan0, raw);
            bmp.UnlockBits(bmData);
            return bmp;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct AlgorithmSchema
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string Category;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string Description;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string Version;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
            public string Vendor;

            public override string ToString()
            {
                return Description + " " + Version;
            }
        }
    }
}
