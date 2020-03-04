#ifndef  EASY_IMAGE_LIB_H
#define  EASY_IMAGE_LIB_H

#include "Core/AlgorithmSchema.h"

#ifdef  MYDLL_EXPORTS 
/*Enabled as "export" while compiling the dll project*/
#define DLLEXPORT __declspec(dllexport)  
#else
/*Enabled as "import" in the Client side for using already created dll file*/
#define DLLEXPORT __declspec(dllimport)  
#endif

/**
* This method returns a list of available algorithms
* @param This is the list of available algorithms
* @param This is the quantity of available algorithms
*/
DLLEXPORT void GetAllAlgorithms(AlgorithmSchema* &schemas, int &count);

/**
* This method transform an image by a given algorithm
* @param algorithmIndex This is the index of the algorithm
* @param inputImage  This is the image in 8bpp row format
* @param w  This is the width of the image
* @param h  This is the height of the image
* @param h  Returns an image in 8bpp row format with the transformed image
*/
DLLEXPORT void Transform(int algorithmIndex, unsigned char* inputImage, int w, int h, unsigned char* outputImage);

#endif EASY_IMAGE_LIB_H