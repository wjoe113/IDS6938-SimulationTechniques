int size = 10;  //TODO
Eigen::MatrixXf TransitionMatrix(size, size);
Eigen::VectorXf v(size);

unsigned int ROLLS = 10; //TODO

double prob = (1.0/6.0);  //TODO

void SetTransitionMatrix()
{
	TransitionMatrix.setZero();
	//TransitionMatrix(0, 1) = prob;
	for (int i = 0; i < TransitionMatrix.rows(); i++)
	{
		if (i < TransitionMatrix.rows() - 6)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i == TransitionMatrix.rows() - 6)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob * 2;
		}
		else if (i == TransitionMatrix.rows() - 5)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob * 3;
		}
		else if (i == TransitionMatrix.rows() - 4)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob * 4;
		}
		else if (i == TransitionMatrix.rows() - 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob * 5;
		}
		else if (i == TransitionMatrix.rows() - 2)
		{
			TransitionMatrix(i, i + 1) = prob * 6;
		}
		else if (i == TransitionMatrix.rows() - 1)
		{
			//YOU WIN!!!
		}
	}

	//TODO
	std::cout << TransitionMatrix << std::endl;
	exit(1);
}