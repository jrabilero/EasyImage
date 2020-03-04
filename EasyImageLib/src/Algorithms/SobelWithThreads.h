
#ifndef SOBEL_WITH_THREADS_H
#define SOBEL_WITH_THREADS_H

#include "..\Core\AlgorithmBase.h"

/**
* Sobel algorithm with treads
*
* @author  Juan José Rabilero Luna
* @version 1.0
* @since   2020-03-03
*/
class SobelWithThreads : public  AlgorithmBase
{
private:
	const char* description = "Sobel with treads";
	const char* category = "Border detection";
	const char* version = "1.0.0";
	const char* vendor = "Rabilero's productions";

public:
	/**
	* This method returns the name of the sobel algorithm
	* @return Returns the name of an algorithm
	*/
	virtual AlgorithmSchema GetSchema();

	/**
	* This method transform an image using the sobel algorithm 
	* @param inputImage  This is the image in 8bpp row format
	* @param w  This is the width of the image
	* @param h  This is the height of the image
	* @return Returns an image in 8bpp row format with the transformed image
	*/
	virtual unsigned char* Transform(unsigned char* inputImage, int w, int h);
};

#endif SOBEL_WITH_THREADS_H

