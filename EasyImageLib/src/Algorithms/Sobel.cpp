#include "Sobel.h"
#include <string.h>
#include "..\Core\Image.h"

/**
* This method returns the schema of the sobel algorithm
* @return Returns the name of an algorithm
*/
AlgorithmSchema Sobel::GetSchema()
{
	AlgorithmSchema schema;

	memset(&schema.Category, 0, STRING_SIZE);
	memset(&schema.Description, 0, STRING_SIZE);
	memset(&schema.Version, 0, STRING_SIZE);
	memset(&schema.Vendor, 0, STRING_SIZE);

	memcpy(&(schema.Description), description, strlen(description));
	memcpy(&(schema.Category), category, strlen(category));
	memcpy(&(schema.Version), version, strlen(version));
	memcpy(&(schema.Vendor), vendor, strlen(vendor));

	return schema;
}

/**
* This method transform an image using the sobel algorithm
* @param inputImage  This is the image in 8bpp row format
* @param w  This is the width of the image
* @param h  This is the height of the image
* @return Returns an image in 8bpp row format with the transformed image
*/
unsigned char* Sobel::Transform(unsigned char* inputImage, int w, int h)
{
	Image image(inputImage, w, h);
	auto buffer = new unsigned char[w * h];
	memset(buffer, NULL, w * h);
	Image resultImage(buffer, w, h);

#pragma omp for
	for (auto i = 1; i < h - 1; i++)
	{
		for (auto j = 1; j < w - 1; j++)
		{
			resultImage.SetAt(i, j, (unsigned char)abs(image.Xgrad(j, i)) + abs(image.Ygrad(j, i)));
		}
	}

	return resultImage.Data;
}
