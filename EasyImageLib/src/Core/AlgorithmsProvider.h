#ifndef  ALGORITHMS_PROVIDER_H
#define  ALGORITHMS_PROVIDER_H

#include "AlgorithmBase.h"
#include <vector>

using namespace std;

/**
* Class that models an algorithms provider (Singleton Design Pattern)
*
* @author  Juan José Rabilero Luna
* @version 1.0
* @since   2020-03-03
*/
class AlgorithmsProvider
{
public:

	/**
	* This method return the singleton internal instance
	* @return Returns the internal instance
	*/
	static AlgorithmsProvider* GetInstance();

	/**
	* This method return all the available algorithms
	* @return Returns a list containing all available algorithms
	*/
	vector<AlgorithmBase*> GetAllAlgorithms();

private:
	static AlgorithmsProvider *instance;
};

#endif ALGORITHMS_PROVIDER_H

