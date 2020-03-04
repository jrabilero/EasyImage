#include "..\EasyImageLib.h"

typedef enum _PixelFormatType
{
	Format32bppArgb = 0x26200a,
	Format32bppRgb = 0x22009,
	Format24bppRgb = 0x21808
} PixelFormatType;

DLLEXPORT void FastBitmapToRaw(PixelFormatType pixelformat, int width, int height, int stride, unsigned char *scan, unsigned char *barray)
{
	int step, offset, x, y;
	step = ((pixelformat == Format32bppArgb) ||
		(pixelformat == Format32bppRgb) ? 4 :
		(pixelformat == Format24bppRgb) ? 3 : 1);
	offset = stride - width * step;
	for (y = 0; y < height; y++)
	{
		for (x = 0; x < width; x++)
		{
			*(barray++) = *scan;
			scan += step;
		}
		scan += offset;
	}
}

#define CopyMem(dst, src, count) memcpy(dst, src, count)
#define CopyRow(type, dstRow, srcRow, length) CopyMem(dstRow, srcRow, (length) * sizeof(type))
#define CopyByteRow(dstRow, srcRow, length) CopyRow(unsigned char, dstRow, srcRow, length)

DLLEXPORT void FastRawToBitmap(int width, int height, int stride, unsigned char *scan, unsigned char *barray)
{
	int offset, y;
	offset = stride - width;
	for (y = 0; y < height; y++)
	{
		CopyByteRow(scan, barray, width);
		scan += width + offset;
		barray += width;
	}
}