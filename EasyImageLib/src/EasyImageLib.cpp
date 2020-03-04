#include "EasyImageLib.h"
#include "Core/AlgorithmsProvider.h"

/**
* This method returns a list of available algorithms
* @param This is the list of available algorithms
* @param This is the quantity of available algorithms
*/
DLLEXPORT void GetAllAlgorithms(AlgorithmSchema* &schemas, int &count)
{
	auto allAlgoriths = AlgorithmsProvider::GetInstance()->GetAllAlgorithms();
	count = allAlgoriths.size();
	schemas = new AlgorithmSchema[count];

	for (int i = 0; i < count; i++)
	{
		schemas[i] = allAlgoriths[i]->GetSchema();
	}
}

/**
* This method transform an image by a given algorithm
* @param algorithmIndex This is the index of the algorithm
* @param inputImage  This is the image in 8bpp row format
* @param w  This is the width of the image
* @param h  This is the height of the image
* @param h  Returns an image in 8bpp row format with the transformed image
*/
DLLEXPORT void Transform(int algorithmIndex, unsigned char* inputImage, int w, int h, unsigned char* outputImage)
{
	auto allAlgoriths = AlgorithmsProvider::GetInstance()->GetAllAlgorithms();
	
	if (algorithmIndex < 0 || algorithmIndex > allAlgoriths.size() - 1)
	{
		throw  std::overflow_error("Wrong algorithm index");
	}

	auto result = allAlgoriths[algorithmIndex]->Transform(inputImage, w, h);

	memcpy(outputImage, result, w * h);

	delete result;
}