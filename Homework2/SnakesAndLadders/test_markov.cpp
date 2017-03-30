#include <iostream>
#include <functional>   
#include <numeric> 
#include <iostream>
#include <iomanip>
#include <fstream>
#include <map>
#include <Eigen\dense>

#include "markov.h"
#include "TransitionMatrix.h"

int main(){

	SetTransitionMatrix();
	ModifyTransformationMatrix();

	//Output Vector
	v.setZero();
	v(0) = 1.0;

	// Print Results to File
	std::ofstream myfile;
	myfile.open("markov_results.txt");
	std::ofstream myfile2;
	myfile2.open("markov_results_wins.txt");

	for (int j = 0; j < ROLLS; j++)
	{
		// TODO add Markov vector - Matrix multiplication
		v = v.transpose() * TransitionMatrix;

		for (int i = 0; i < size; i++)
		{
			std::cout << v(i) << ", ";
			myfile << v(i) << ", ";
			if (i == size - 1) {
				myfile2 << v(i) << std::endl;
			}
		}
		std::cout << std::endl;
		myfile << std::endl;
	}

	myfile << v << std::endl;  //this is just a sample, becareful how you print to file so you can mine useful stats
	myfile.close();
	myfile2.close();

	return 1;
}