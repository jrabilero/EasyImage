#ifndef  IMAGE_H
#define  IMAGE_H


/**
* Class that models an Image
*
* @author  Juan José Rabilero Luna
* @version 1.0
* @since   2020-03-03
*/
class Image
{
public:
	/**
	* Image raw data
	*/
	unsigned char* Data;

	/**
	* Image width
	*/
	int W;

	/**
	* Image height
	*/
	int H;

	/**
	* Image constructor
	*/
	Image(unsigned char* data, int w, int h);

	/**
	* This method return the pixel value at x, y
	*/
	unsigned char At(int x, int y);

	/**
	* This method set the pixel value at x, y
	*/
	void SetAt(int x, int y, unsigned char value);

	/**
	* This method Computes the x component of the gradient vector
	* @param image  This is the image
	* @param x  This is the x coordinate
	* @param y  This is the Y coordinate
	* @return Returns the gradient in the x direction
	*/
	int Xgrad(int x, int y);

	/**
	* This method Computes the y component of the gradient vector
	* @param image  This is the image
	* @param x  This is the x coordinate
	* @param y  This is the Y coordinate
	* @return Returns the gradient in the y direction
	*/
	int Ygrad(int x, int y);
};


#endif IMAGE_H

