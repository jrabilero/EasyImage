#ifndef  ALGORITHM_BASE_H
#define  ALGORITHM_BASE_H

#include <stdio.h>
#include "AlgorithmSchema.h"

/**
* Abstract class that models an algorithm
*
* @author  Juan José Rabilero Luna
* @version 1.0
* @since   2020-03-03
*/
class AlgorithmBase
{
public:

	/**
	* This method returns the name of an algorithm
	* @return Returns the name of an algorithm
	*/
	virtual AlgorithmSchema GetSchema() = 0;

	/**
	* This method transform an image
	* @param inputImage  This is the image in 8bpp row format
	* @param w  This is the width of the image
	* @param h  This is the height of the image
	* @return Returns an image in 8bpp row format with the transformed image
	*/
	virtual unsigned char* Transform(unsigned char* inputImage, int w, int h) = 0;
};

#endif ALGORITHM_BASE_H

