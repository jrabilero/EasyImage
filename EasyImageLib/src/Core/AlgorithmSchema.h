#ifndef  ALGORITHM_SCHEMA_H
#define  ALGORITHM_SCHEMA_H

#include <string>

#define STRING_SIZE 255

/**
* Enum that defines the algorithm properties
*
* @author  Juan José Rabilero Luna
* @version 1.0
* @since   2020-03-03
*/
typedef struct algorithmSchema
{
	unsigned char Category[STRING_SIZE];
	unsigned char Description[STRING_SIZE];
	unsigned char Version[STRING_SIZE];
	unsigned char Vendor[STRING_SIZE];
}AlgorithmSchema;

#endif ALGORITHM_SCHEMA_H
