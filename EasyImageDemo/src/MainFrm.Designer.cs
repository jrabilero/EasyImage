namespace EasyImageDemo
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.MainTsp = new System.Windows.Forms.ToolStrip();
            this.LoadBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TransformBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AlgorithmLbl = new System.Windows.Forms.ToolStripLabel();
            this.AlgorithmCbx = new System.Windows.Forms.ToolStripComboBox();
            this.LeftPbx = new System.Windows.Forms.PictureBox();
            this.RigthPbx = new System.Windows.Forms.PictureBox();
            this.MainScr = new System.Windows.Forms.SplitContainer();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TimeExLbl = new System.Windows.Forms.ToolStripLabel();
            this.TimeLbl = new System.Windows.Forms.ToolStripLabel();
            this.MainTsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigthPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainScr)).BeginInit();
            this.MainScr.Panel1.SuspendLayout();
            this.MainScr.Panel2.SuspendLayout();
            this.MainScr.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTsp
            // 
            this.MainTsp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadBtn,
            this.toolStripSeparator1,
            this.TransformBtn,
            this.toolStripSeparator2,
            this.AlgorithmLbl,
            this.AlgorithmCbx,
            this.toolStripSeparator3,
            this.TimeExLbl,
            this.TimeLbl});
            this.MainTsp.Location = new System.Drawing.Point(0, 0);
            this.MainTsp.Name = "MainTsp";
            this.MainTsp.Size = new System.Drawing.Size(927, 25);
            this.MainTsp.TabIndex = 0;
            this.MainTsp.Text = "toolStrip1";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Image = ((System.Drawing.Image)(resources.GetObject("LoadBtn.Image")));
            this.LoadBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(53, 22);
            this.LoadBtn.Text = "Load";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TransformBtn
            // 
            this.TransformBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransformBtn.Image")));
            this.TransformBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TransformBtn.Name = "TransformBtn";
            this.TransformBtn.Size = new System.Drawing.Size(81, 22);
            this.TransformBtn.Text = "Transform";
            this.TransformBtn.Click += new System.EventHandler(this.TransformBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AlgorithmLbl
            // 
            this.AlgorithmLbl.Name = "AlgorithmLbl";
            this.AlgorithmLbl.Size = new System.Drawing.Size(64, 22);
            this.AlgorithmLbl.Text = "Algorithm:";
            // 
            // AlgorithmCbx
            // 
            this.AlgorithmCbx.Name = "AlgorithmCbx";
            this.AlgorithmCbx.Size = new System.Drawing.Size(121, 25);
            // 
            // LeftPbx
            // 
            this.LeftPbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftPbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPbx.Image = ((System.Drawing.Image)(resources.GetObject("LeftPbx.Image")));
            this.LeftPbx.Location = new System.Drawing.Point(0, 0);
            this.LeftPbx.Name = "LeftPbx";
            this.LeftPbx.Size = new System.Drawing.Size(442, 411);
            this.LeftPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LeftPbx.TabIndex = 1;
            this.LeftPbx.TabStop = false;
            // 
            // RigthPbx
            // 
            this.RigthPbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RigthPbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RigthPbx.Location = new System.Drawing.Point(0, 0);
            this.RigthPbx.Name = "RigthPbx";
            this.RigthPbx.Size = new System.Drawing.Size(481, 411);
            this.RigthPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RigthPbx.TabIndex = 2;
            this.RigthPbx.TabStop = false;
            // 
            // MainScr
            // 
            this.MainScr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainScr.Location = new System.Drawing.Point(0, 25);
            this.MainScr.Name = "MainScr";
            // 
            // MainScr.Panel1
            // 
            this.MainScr.Panel1.Controls.Add(this.LeftPbx);
            // 
            // MainScr.Panel2
            // 
            this.MainScr.Panel2.Controls.Add(this.RigthPbx);
            this.MainScr.Size = new System.Drawing.Size(927, 411);
            this.MainScr.SplitterDistance = 442;
            this.MainScr.TabIndex = 3;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TimeExLbl
            // 
            this.TimeExLbl.Name = "TimeExLbl";
            this.TimeExLbl.Size = new System.Drawing.Size(61, 22);
            this.TimeExLbl.Text = "Time(ms):";
            // 
            // TimeLbl
            // 
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(13, 22);
            this.TimeLbl.Text = "0";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 436);
            this.Controls.Add(this.MainScr);
            this.Controls.Add(this.MainTsp);
            this.Name = "MainFrm";
            this.Text = "EasyImageDemo";
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.MainTsp.ResumeLayout(false);
            this.MainTsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RigthPbx)).EndInit();
            this.MainScr.Panel1.ResumeLayout(false);
            this.MainScr.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainScr)).EndInit();
            this.MainScr.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip MainTsp;
        private System.Windows.Forms.ToolStripButton LoadBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TransformBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel AlgorithmLbl;
        private System.Windows.Forms.ToolStripComboBox AlgorithmCbx;
        private System.Windows.Forms.PictureBox LeftPbx;
        private System.Windows.Forms.PictureBox RigthPbx;
        private System.Windows.Forms.SplitContainer MainScr;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel TimeExLbl;
        private System.Windows.Forms.ToolStripLabel TimeLbl;
    }
}

