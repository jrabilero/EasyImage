#include "AlgorithmsProvider.h"
#include "..\Algorithms\Sobel.h"
#include "..\Algorithms\SobelWithThreads.h"

AlgorithmsProvider* AlgorithmsProvider::instance = NULL;

/**
* This method return the singleton internal instance
* @return Returns the internal instance
*/
AlgorithmsProvider* AlgorithmsProvider::GetInstance()
{
	if (instance == NULL)
	{
		instance = new AlgorithmsProvider();
	}

	return instance;
}

/**
* This method return all the available algorithms
* @return Returns a list containing all available algorithms
*/
vector<AlgorithmBase*> AlgorithmsProvider::GetAllAlgorithms()
{
	vector<AlgorithmBase*> result;
	
	result.push_back(new Sobel());
	result.push_back(new SobelWithThreads());
		
	return result;
}