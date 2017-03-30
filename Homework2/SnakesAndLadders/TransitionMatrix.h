int size = 101;  //TODO - 101
Eigen::MatrixXf TransitionMatrix(size, size);
Eigen::VectorXf v(size);

unsigned int ROLLS = 1000; //TODO - "They see me rolling!"

double prob = (1.0/6.0);  //TODO - 1/6

void SetTransitionMatrix()
{
	TransitionMatrix.setZero();

	for (int i = 0; i < TransitionMatrix.rows() - 6; i++)
	{
		TransitionMatrix(i, i + 1) = prob;
		TransitionMatrix(i, i + 2) = prob;
		TransitionMatrix(i, i + 3) = prob;
		TransitionMatrix(i, i + 4) = prob;
		TransitionMatrix(i, i + 5) = prob;
		TransitionMatrix(i, i + 6) = prob;
	}

	TransitionMatrix(95, 96) = prob;
	TransitionMatrix(95, 97) = prob;
	TransitionMatrix(95, 98) = prob;
	TransitionMatrix(95, 99) = prob;
	TransitionMatrix(95, 100) = prob * 2;

	TransitionMatrix(96, 97) = prob;
	TransitionMatrix(96, 98) = prob;
	TransitionMatrix(96, 99) = prob;
	TransitionMatrix(96, 100) = prob * 3;

	TransitionMatrix(97, 98) = prob;
	TransitionMatrix(97, 99) = prob;
	TransitionMatrix(97, 100) = prob * 4;

	TransitionMatrix(98, 99) = prob;
	TransitionMatrix(98, 100) = prob * 5;

	TransitionMatrix(99, 100) = 1; // You're about to win, assuming the world doesn't end before your next turn...

	TransitionMatrix(100, 100) = 1; //YOU WIN!!! And the world didn't end!

	std::cout << TransitionMatrix << std::endl;
}

//Part c - comment out for null matrix
void ModifyTransformationMatrix() {

	//Ladder from 3 to 19
	TransitionMatrix(0, 19) = prob;
	TransitionMatrix(1, 19) = prob;
	TransitionMatrix(2, 19) = prob;

	//Ladder from 15 to 37
	TransitionMatrix(9, 37) = prob;
	TransitionMatrix(10, 37) = prob;
	TransitionMatrix(11, 37) = prob;
	TransitionMatrix(12, 37) = prob;
	TransitionMatrix(13, 37) = prob;
	TransitionMatrix(14, 37) = prob;

	//Ladder from 22 to 42
	TransitionMatrix(16, 42) = prob;
	TransitionMatrix(17, 42) = prob;
	TransitionMatrix(18, 42) = prob;
	TransitionMatrix(19, 42) = prob;
	TransitionMatrix(20, 42) = prob;
	TransitionMatrix(21, 42) = prob;

	//Ladder from 25 to 64
	TransitionMatrix(19, 64) = prob;
	TransitionMatrix(20, 64) = prob;
	TransitionMatrix(21, 64) = prob;
	TransitionMatrix(22, 64) = prob;
	TransitionMatrix(23, 64) = prob;
	TransitionMatrix(24, 64) = prob;

	//Ladder from 53 to 74
	TransitionMatrix(36, 74) = prob;
	TransitionMatrix(37, 74) = prob;
	TransitionMatrix(38, 74) = prob;
	TransitionMatrix(39, 74) = prob;
	TransitionMatrix(40, 74) = prob;
	TransitionMatrix(41, 74) = prob;

	//Ladder from 53 to 74
	TransitionMatrix(47, 74) = prob;
	TransitionMatrix(48, 74) = prob;
	TransitionMatrix(49, 74) = prob;
	TransitionMatrix(50, 74) = prob;
	TransitionMatrix(51, 74) = prob;
	TransitionMatrix(52, 74) = prob;

	//Ladder from 63 to 86
	TransitionMatrix(58, 86) = prob;
	TransitionMatrix(59, 86) = prob;
	TransitionMatrix(60, 86) = prob;
	TransitionMatrix(61, 86) = prob;
	TransitionMatrix(62, 86) = prob;
	TransitionMatrix(63, 86) = prob;

	//Ladder from 76 to 91
	TransitionMatrix(70, 91) = prob;
	TransitionMatrix(71, 91) = prob;
	TransitionMatrix(72, 91) = prob;
	TransitionMatrix(73, 91) = prob;
	TransitionMatrix(74, 91) = prob;
	TransitionMatrix(75, 91) = prob;

	//Ladder from 84 to 98
	TransitionMatrix(78, 98) = prob;
	TransitionMatrix(79, 98) = prob;
	TransitionMatrix(80, 98) = prob;
	TransitionMatrix(81, 98) = prob;
	TransitionMatrix(82, 98) = prob;
	TransitionMatrix(83, 98) = prob;

	//Snake from 11 to 7
	TransitionMatrix(5, 7) = prob * 2;
	TransitionMatrix(6, 7) = prob * 2;
	TransitionMatrix(7, 7) = prob;
	TransitionMatrix(8, 7) = prob;
	TransitionMatrix(9, 7) = prob;
	TransitionMatrix(10, 7) = prob;

	//Snake from 18 to 13
	TransitionMatrix(12, 13) = prob * 2;
	TransitionMatrix(13, 13) = prob;
	TransitionMatrix(14, 13) = prob;
	TransitionMatrix(15, 13) = prob;
	TransitionMatrix(16, 13) = prob;
	TransitionMatrix(17, 13) = prob;

	//Snake from 28 to 12
	TransitionMatrix(22, 12) = prob;
	TransitionMatrix(23, 12) = prob;
	TransitionMatrix(24, 12) = prob;
	TransitionMatrix(25, 12) = prob;
	TransitionMatrix(26, 12) = prob;
	TransitionMatrix(27, 12) = prob;

	//Snake from 36 to 34
	TransitionMatrix(30, 34) = prob * 2;
	TransitionMatrix(31, 34) = prob * 2;
	TransitionMatrix(32, 34) = prob * 2;
	TransitionMatrix(33, 34) = prob * 2;
	TransitionMatrix(34, 34) = prob;
	TransitionMatrix(35, 34) = prob;

	//Snake from 77 to 16 - Dang that sucks!
	TransitionMatrix(71, 16) = prob;
	TransitionMatrix(72, 16) = prob;
	TransitionMatrix(73, 16) = prob;
	TransitionMatrix(74, 16) = prob;
	TransitionMatrix(75, 16) = prob;
	TransitionMatrix(76, 16) = prob;

	//Snake from 47 to 26
	TransitionMatrix(41, 26) = prob;
	TransitionMatrix(42, 26) = prob;
	TransitionMatrix(43, 26) = prob;
	TransitionMatrix(44, 26) = prob;
	TransitionMatrix(45, 26) = prob;
	TransitionMatrix(46, 26) = prob;

	//Snake from 83 to 39
	TransitionMatrix(77, 39) = prob;
	TransitionMatrix(78, 39) = prob;
	TransitionMatrix(79, 39) = prob;
	TransitionMatrix(80, 39) = prob;
	TransitionMatrix(81, 39) = prob;
	TransitionMatrix(82, 39) = prob;

	//Snake from 92 to 75
	TransitionMatrix(86, 75) = prob;
	TransitionMatrix(87, 75) = prob;
	TransitionMatrix(88, 75) = prob;
	TransitionMatrix(89, 75) = prob;
	TransitionMatrix(90, 75) = prob;
	TransitionMatrix(91, 75) = prob;

	//Snake from 99 to 70
	TransitionMatrix(93, 70) = prob;
	TransitionMatrix(94, 70) = prob;
	TransitionMatrix(95, 70) = prob;
	TransitionMatrix(96, 70) = prob;
	TransitionMatrix(97, 70) = prob;
	TransitionMatrix(98, 70) = prob;

	for (int i = 0; i < TransitionMatrix.rows(); i++) //There is a zero probability you'll stand on a snake or ladder
	{
		//Ladders
		TransitionMatrix(i, 3) = 0.0;
		TransitionMatrix(i, 15) = 0.0;
		TransitionMatrix(i, 22) = 0.0;
		TransitionMatrix(i, 25) = 0.0;
		TransitionMatrix(i, 41) = 0.0;
		TransitionMatrix(i, 53) = 0.0;
		TransitionMatrix(i, 63) = 0.0;
		TransitionMatrix(i, 76) = 0.0;
		TransitionMatrix(i, 84) = 0.0;
		//Snakes
		TransitionMatrix(i, 11) = 0.0;
		TransitionMatrix(i, 18) = 0.0;
		TransitionMatrix(i, 28) = 0.0;
		TransitionMatrix(i, 36) = 0.0;
		TransitionMatrix(i, 77) = 0.0;
		TransitionMatrix(i, 47) = 0.0;
		TransitionMatrix(i, 83) = 0.0;
		TransitionMatrix(i, 92) = 0.0;
		TransitionMatrix(i, 99) = 0.0;
	}

	//std::cout << TransitionMatrix << std::endl;
}

    /*//part c - old
	for (int i = 0; i < TransitionMatrix.rows() - 6; i++)
	{
		if (i == 3)
		{
			TransitionMatrix(i, 19) = 1;
		}
		else if (i + 1 == 3)
		{
			TransitionMatrix(i, 19) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i + 2 == 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, 19) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i + 3 == 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, 19) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i + 4 == 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, 19) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i + 5 == 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, 19) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
		else if (i + 6 == 3)
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, 19) = prob;
		}
		else
		{
			TransitionMatrix(i, i + 1) = prob;
			TransitionMatrix(i, i + 2) = prob;
			TransitionMatrix(i, i + 3) = prob;
			TransitionMatrix(i, i + 4) = prob;
			TransitionMatrix(i, i + 5) = prob;
			TransitionMatrix(i, i + 6) = prob;
		}
	}*/