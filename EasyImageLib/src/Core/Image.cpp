#include "Image.h"

/**
* Image constructor
*/
Image::Image(unsigned char* data, int w, int h)
{
	Data = data;
	W = w;
	H = h;
}

/**
* This method return the pixel value at x, y
*/
unsigned char Image::At(int x, int y)
{
	return Data[y * W + x];
}

/**
* This method set the pixel value at x, y
*/
void Image::SetAt(int x, int y, unsigned char value)
{
	Data[y * W + x] = value;
}

/**
* This method Computes the x component of the gradient vector
* @param image  This is the image
* @param x  This is the x coordinate
* @param y  This is the Y coordinate
* @return Returns the gradient in the x direction
*/
int Image::Xgrad(int x, int y)
{
	return At(y - 1, x - 1) +
		2 * At(y, x - 1) +
		At(y + 1, x - 1) -
		At(y - 1, x + 1) -
		2 * At(y, x + 1) -
		At(y + 1, x + 1);
}

/**
* This method Computes the y component of the gradient vector
* @param image  This is the image
* @param x  This is the x coordinate
* @param y  This is the Y coordinate
* @return Returns the gradient in the y direction
*/
int Image::Ygrad(int x, int y)
{
	return At(y - 1, x - 1) +
		2 * At(y - 1, x) +
		At(y - 1, x + 1) -
		At(y + 1, x - 1) -
		2 * At(y + 1, x) -
		At(y + 1, x + 1);
}