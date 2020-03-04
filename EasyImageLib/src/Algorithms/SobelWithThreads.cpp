#include "SobelWithThreads.h"
#include <string.h>
#include "..\Core\Image.h"
#include <vector>
#include <thread>

using namespace std;

#define THREAD_COUNT 5

/**
* This method returns the schema of the sobel algorithm
* @return Returns the name of an algorithm
*/
AlgorithmSchema SobelWithThreads::GetSchema()
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
* Thread Function
* @param begin  This is the initial column
* @param end  This is the final column
* @param inputImage  This is the image
* @param inputImage  This is the result image
*/
void ThreadFunc(int begin, int end, Image image, Image resultImage)
{
	for (auto i = begin; i < end; i++)
	{
		for (auto j = 1; j < image.W - 1; j++)
		{
			resultImage.SetAt(i, j, (unsigned char)abs(image.Xgrad(j, i)) + abs(image.Ygrad(j, i)));
		}
	}
}

/**
* This method transform an image using the sobel algorithm
* @param inputImage  This is the image in 8bpp row format
* @param w  This is the width of the image
* @param h  This is the height of the image
* @return Returns an image in 8bpp row format with the transformed image
*/
unsigned char* SobelWithThreads::Transform(unsigned char* inputImage, int w, int h)
{
	Image image(inputImage, w, h);
	auto buffer = new unsigned char[w * h];
	memset(buffer, NULL, w * h);
	Image resultImage(buffer, w, h);
	vector<thread*> threadPool;
	auto partitionSize = w / THREAD_COUNT;
	auto begin = 1;
	auto stop = false;

	while (!stop)
	{
		auto end = begin + partitionSize;
	
		if (end > w) 
		{
			end = w;
			stop = true;
		}
		
		auto t = new thread(ThreadFunc, begin, end, image, resultImage);
		threadPool.push_back(t);

		begin = end;
	}

	for (auto it = threadPool.begin(); it != threadPool.end(); ++it)
	{
		(*it)->join();
	}

	return resultImage.Data;
}
