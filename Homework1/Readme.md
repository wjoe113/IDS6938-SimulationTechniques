#Homework 1 : The Jello Cube (Continuous Simulation Assignment)
## IDS6938-Simulation Techniques - [University of Central Florida](http://www.ist.ucf.edu/grad/)
### By [Joe Wileman](http://josephmwileman.weebly.com/), Spring 2017

This is the framework for homework #1. Please first read the [homework writeup](HomeWork%231.pdf).

The assignment is due: Wednesday, March 01 at 8:59PM (PST)

| undeformed jello  | deformed jello |
| ------------- | ------------- |
| ![](images/undeformed3.png?raw=true)  | ![](images/deformed3.png?raw=true) |

## Part 1 - Numerical Analysis of Integration Functions (25pts)

a.) The exact symbolic solution for df is as follows (df included):

	exact = exp(x / 2.0) * sin(5.0 * x)

	df = y - (1.0 / 2.0) * exp(x / 2.0) * sin(5.0 * x) + 5.0 * exp(x / 2.0) * cos(5.0 * x)

b.) The code below shows the exact and df functions used in this part:

    double df(double x, double y)            //function for defining dy/dx
    {
        return y - (1.0 / 2.0) * exp(x / 2.0) * sin(5.0 * x) + 5.0 * exp(x / 2.0) * cos(5.0 * x);
    }

    double exact(double x)            //function for defining dy/dx
    {
	    return exp(x / 2.0) * sin(5.0 * x);
    }

c.) The numerical integrations for RK1, RK2, RK4, and exact, where h = 0.1 for x = < 0.0, 10.0 >

| x  | RK1 | RK2 | RK4 | Exact |
| ------------- | ------------- | ------------- | ------------- | ------------- |
| 0.0 | 0.0| 0.0| 0.0| 0.0 |
| 0.1 | 0.5 | 0.5090369272 | 0.5040147599 | 0.5040062116 |
| 0.2 | 0.9860882804 | 0.9418917554 | 0.9299833736 | 0.9299692608 |
| 0.3 | 1.336761843 | 1.178280127 | 1.158938591 | 1.158923832 |
| 0.4 | 1.453584287 | 1.136380907 | 1.110627992 | 1.110618385 |
| 0.5 | 1.28927035 | 0.7981592984 | 0.7684526188 | 0.7684534442 |
| 0.6 | 0.8654303303 | 0.2207680347 | 0.1904774691 | 0.1904920858 |
| 0.7 | 0.2742737135 | -0.470402004 | -0.4978138899 | -0.497785095 |
| 0.8 | -0.3378573082 | -1.107144704 | -1.129056656 | -1.129016654 |
| 0.9 | -0.8027530548 | -1.517667616 | -1.533117725 | -1.533072395 |
| 1.0 | -0.971671551 | -1.570878628 | -1.581041974 | -1.580998849 |
| 1.1 | -0.7559488242 | -1.214747006 | -1.222913458 | -1.222879899 |
| 1.2 | -0.1562476992 | -0.4981410611 | -0.5091470062 | -0.5091282324 |
| 1.3 | 0.7283561079 | 0.4312735709 | 0.4120685813 | 0.4120711203 |
| 1.4 | 1.715934898 | 1.355046339 | 1.323019094 | 1.323008542 |
| 1.5 | 2.580464313 | 2.033306318 | 1.985762151 | 1.985745966 |
| 1.6 | 3.106136933 | 2.264888984 | 2.20186874 | 2.201857271 |
| 1.7 | 3.144749623 | 1.943723238 | 1.868173695 | 1.868177859 |
| 1.8 | 2.661568066 | 1.0964239 | 1.013619327 | 1.013647908 |
| 1.9 | 1.756533063 | -0.1106615176 | -0.1943761998 | -0.1943189781 |
| 2.0 | 0.6527034805 | -1.399996434 | -1.478886739 | -1.4788027 |
| 2.1 | -0.3485024816 | -2.443310353 | -2.513966496 | -2.513863572 |
| 2.2 | -0.9371188681 | -2.941602204 | -3.004245902 | -3.004136603 |
| 2.3 | -0.873976159 | -2.70594543 | -2.764948334 | -2.764846851 |
| 2.4 | -0.05994660124 | -1.71816828 | -1.781566264 | -1.781484825 |
| 2.5 | 1.423979884 | -0.1535146925 | -0.2315408363 | -0.2314861673 |
| 2.6 | 3.319281279 | 1.644605198 | 1.54168834 | 1.541717508 |
| 2.7 | 5.238969258 | 3.236248676 | 3.100524943 | 3.100538568 |
| 2.8 | 6.755270333 | 4.189210793 | 4.01709566 | 4.017110916 |
| 2.9 | 7.507190201 | 4.192252154 | 3.985526889 | 3.985564681 |
| 3.0 | 7.302089591 | 3.148785464 | 2.914307734 | 2.914387906 |
| 3.1 | 6.184236647 | 1.224605964 | 0.972629052 | 0.9727653848 |
| 3.2 | 4.449044884 | -1.167577779 | -1.426190757 | -1.425994463 |
| 3.3 | 2.593589867 | -3.449436793 | -3.706500293 | -3.706251919 |
| 3.4 | 1.209577795 | -5.009923054 | -5.262921367 | -5.262639293 |
| 3.5 | 0.8405527212 | -5.360649903 | -5.614631006 | -5.614340022 |
| 3.6 | 1.836719894 | -4.275713547 | -4.543483006 | -4.543208093 |
| 3.7 | 4.244893938 | -1.877962749 | -2.178355567 | -2.178114923 |
| 3.8 | 7.765893459 | 1.356347703 | 1.001862248 | 1.002063203 |
| 3.9 | 11.797567 | 4.68431418 | 4.255978576 | 4.256150562 |
| 4.0 | 15.56128357 | 7.261608412 | 6.745634215 | 6.745803673 |
| 4.1 | 18.28779237 | 8.351461123 | 7.743070647 | 7.743275262 |
| 4.2 | 19.42038688 | 7.527669226 | 6.8319912 | 6.832272103 |
| 4.3 | 18.78438686 | 4.818214028 | 4.048561713 | 4.048954056 |
| 4.4 | 16.67534928 | 0.745902688 | -0.0804073784 | -0.07988318583 |
| 4.5 | 13.83454839 | -3.755363171 | -4.622839038 | -4.62218308 |
| 4.6 | 11.30627052 | -7.53999892 | -8.441122943 | -8.440356708 |
| 4.7 | 10.20162853 | -9.526142511 | -10.46629701 | -10.4654587 |
| 4.8 | 11.42050818 | -8.98343453 | -9.983215155 | -9.982350011 |
| 4.9 | 15.3995765 | -5.75964435 | -6.853708459 | -6.852856091 |
| 5.0 | 21.95465336 | -0.3807817504 | -1.613192731 | -1.612374396 |
| 5.1 | 30.26839856 | 6.014645055 | 4.597706732 | 4.598497604 |
| 5.2 | 39.04184528 | 11.90757696 | 10.26608596 | 10.26688721 |
| 5.3 | 46.78766159 | 15.75373022 | 13.86098924 | 13.86186593 |
| 5.4 | 52.20384861 | 16.38289019 | 14.22958423 | 14.23061724 |
| 5.5 | 54.53922906 | 13.34297777 | 10.93668465 | 10.93795441 |
| 5.6 | 53.8548974 | 7.093621803 | 4.453381201 | 4.454949997 |
| 5.7 | 51.10278291 | -1.016917323 | -3.870136268 | -3.868238693 |
| 5.8 | 47.98174569 | -9.00825224 | -12.06319514 | -12.06097868 |
| 5.9 | 46.58531604 | -14.71564969 | -17.98179125 | -17.97930254 |
| 6.0 | 48.91085718 | -16.33276767 | -19.84783646 | -19.84514567 |
| 6.1 | 56.34331178 | -12.91820728 | -16.74997531 | -16.74715483 |
| 6.2 | 69.24521405 | -4.730353493 | -8.971708122 | -8.968807967 |
| 6.3 | 86.770879 | 6.71462731 | 1.956659048 | 1.959633321 |
| 6.4 | 106.976805 | 18.90583913 | 13.52479088 | 13.52789171 |
| 6.5 | 127.2308958 | 28.88713582 | 22.79198022 | 22.79531867 |
| 6.6 | 144.845701 | 33.9802905 | 27.1065171 | 27.11024922 |
| 6.7 | 157.7947748 | 32.51209943 | 24.82557044 | 24.82987139 |
| 6.8 | 165.3348427 | 24.35679009 | 15.84845493 | 15.85348654 |
| 6.9 | 168.3623304 | 11.13329012 | 1.804998656 | 1.810878113 |
| 7.0 | 169.3838706 | -4.030216515 | -14.18624083 | -14.17946262 |
| 7.1 | 172.0681429 | -17.14871549 | -28.17228344 | -28.16462716 |
| 7.2 | 180.4518537 | -24.32396089 | -36.30581142 | -36.29735499 |
| 7.3 | 197.9702842 | -22.76449392 | -35.85664997 | -35.84749611 |
| 7.4 | 226.5464061 | -11.62486987 | -26.03915079 | -26.02938275 |
| 7.5 | 265.9819834 | 7.573163658 | -8.420983343 | -8.410618979 |
| 7.6 | 313.8412016 | 31.09105003 | 13.23698217 | 13.24802651 |
| 7.7 | 365.909382 | 53.7164146 | 33.72789984 | 33.73982544 |
| 7.8 | 417.1685434 | 69.96783884 | 47.60073669 | 47.61385252 |
| 7.9 | 463.0911121 | 75.49676734 | 50.551947 | 50.56663391 |
| 8.0 | 500.9495217 | 68.3428104 | 40.66514418 | 40.68180013 |
| 8.1 | 530.8035916 | 49.70067888 | 19.16044889 | 19.17942782 |
| 8.2 | 555.8758684 | 23.94803368 | -9.592897427 | -9.571337455 |
| 8.3 | 582.1538542 | -2.150655369 | -38.88141649 | -38.85714093 |
| 8.4 | 617.2422193 | -20.94381739 | -61.14646828 | -61.11945935 |
| 8.5 | 668.6856376 | -25.78002003 | -69.86074193 | -69.83105503 |
| 8.6 | 742.143842 | -12.83269433 | -61.33393679 | -61.30162694 |
| 8.7 | 839.8791755 | 17.61878775 | -35.97067969 | -35.93571326 |
| 8.8 | 959.984196 | 60.84206991 | 1.404009713 | 1.441837177 |
| 8.9 | 1096.629577 | 108.4273937 | 42.33439851 | 42.37551737 |
| 9.0 | 1241.37688 | 150.1023432 | 76.55081616 | 76.59589429 |
| 9.1 | 1385.328763 | 176.2233273 | 94.44915487 | 94.49905918 |
| 9.2 | 1521.647688 | 180.3673069 | 89.65808285 | 89.71379662 |
| 9.3 | 1647.829303 | 161.3606021 | 61.03567726 | 61.09819136 |
| 9.4 | 1767.116099 | 124.1582495 | 13.51631062 | 13.58651544 |
| 9.5 | 1888.596144 | 79.22459545 | -42.53333378 | -42.45472598 |
| 9.6 | 2025.825999 | 40.4187988 | -93.43846738 | -93.35094466 |
| 9.7 | 2194.184043 | 21.77807556 | -125.4239703 | -125.3271744 |
| 9.8 | 2407.512568 | 33.91946812 | -128.1856199 | -128.0792336 |
| 9.9 | 2674.851039 | 80.95594681 | -97.93441991 | -97.81800842 |
| 10.0 | 2998.124017 | 158.7831645 | -39.0670402 | -38.93988091 |

| Numerical Integration Solutions  |
| ------------- |
| ![](images/numericalIntegrationSolutionsChart.png?raw=true)  |

To produce the chart above, the following code was used in the toString() function:

	std::ostringstream out;
	out << "| " << std::setprecision(2) << x;
	out << " | " << std::setprecision(presision) << y_euler;
	out << " | " << std::setprecision(presision) << y_midpoint;
	out << " | " << std::setprecision(presision) << y_RK4;
	out << " | " << std::setprecision(presision) << y_exact << " |";

And the following code in the main() function:

	// Header for output file
	outputFile << "x" << "\t" << "y (Euler)" << "\t" << "y (midpoint)" << "\t" << "y (RK44)" << "\t"
		<< "EXACT" << std::endl;
	outputFile << "----" << "\t" << "----------" << "\t" << "----------" << "\t" << "----------"
		<< "\t" << "----------" << std::endl;
	outputFile << "| 0.0 | 0.0 | 0.0 | 0.0 | 0.0 |" << std::endl;

d.) The error percentages for RK1, RK2, and RK4:

| x | %Err(E) | %Err(M) | %Err(RK4) |
| ------------- | ------------- | ------------- | ------------- | ------------- |
| 0.0 | 0.0 | 0.0 | 0.0 |
| 0.1 | 0.0079487 | 0.0099815 | 1.6961e-05 |
| 0.2 | 0.060345 | 0.01282 | 1.5176e-05 |
| 0.3 | 0.15345 | 0.016702 | 1.2735e-05 |
| 0.4 | 0.30881 | 0.023197 | 8.6499e-06 |
| 0.5 | 0.67775 | 0.038657 | 1.0742e-06 |
| 0.6 | 3.5431 | 0.15894 | 7.6731e-05 |
| 0.7 | -1.551 | -0.05501 | -5.7846e-05 |
| 0.8 | -0.70075 | -0.019373 | -3.5431e-05 |
| 0.9 | -0.47638 | -0.010048 | -2.9568e-05 |
| 1.0 | -0.38541 | -0.0064012 | -2.7277e-05 |
| 1.1 | -0.38183 | -0.0066506 | -2.7443e-05 |
| 1.2 | -0.69311 | -0.02158 | -3.6874e-05 |
| 1.3 | 0.76755 | 0.0466 | 6.1615e-06 |
| 1.4 | 0.29699 | 0.024216 | 7.9756e-06 |
| 1.5 | 0.29949 | 0.023951 | 8.1503e-06 |
| 1.6 | 0.41069 | 0.028627 | 5.2089e-06 |
| 1.7 | 0.68332 | 0.040438 | 2.2289e-06 |
| 1.8 | 1.6257 | 0.081661 | 2.8196e-05 |
| 1.9 | -10.039 | -0.43052 | -0.00029447 |
| 2.0 | -1.4414 | -0.053291 | -5.6829e-05 |
| 2.1 | -0.86137 | -0.028066 | -4.0943e-05 |
| 2.2 | -0.68806 | -0.020816 | -3.6383e-05 |
| 2.3 | -0.6839 | -0.021304 | -3.6705e-05 |
| 2.4 | -0.96635 | -0.035541 | -4.5714e-05 |
| 2.5 | -7.1515 | -0.33683 | -0.00023617 |
| 2.6 | 1.153 | 0.066736 | 1.8919e-05 |
| 2.7 | 0.6897 | 0.04377 | 4.3946e-06 |
| 2.8 | 0.68162 | 0.042842 | 3.7977e-06 |
| 2.9 | 0.8836 | 0.051859 | 9.4824e-06 |
| 3.0 | 1.5055 | 0.080428 | 2.7509e-05 |
| 3.1 | 5.3574 | 0.25889 | 0.00014015 |
| 3.2 | -4.12 | -0.18122 | -0.00013765 |
| 3.3 | -1.6998 | -0.069292 | -6.7015e-05 |
| 3.4 | -1.2298 | -0.048021 | -5.3599e-05 |
| 3.5 | -1.1497 | -0.045186 | -5.1829e-05 |
| 3.6 | -1.4043 | -0.058878 | -6.0511e-05 |
| 3.7 | -2.9489 | -0.1378 | -0.00011048 |
| 3.8 | 6.7499 | 0.35356 | 0.00020054 |
| 3.9 | 1.7719 | 0.1006 | 4.0409e-05 |
| 4.0 | 1.3068 | 0.076463 | 2.5121e-05 |
| 4.1 | 1.3618 | 0.078544 | 2.6425e-05 |
| 4.2 | 1.8424 | 0.10178 | 4.1114e-05 |
| 4.3 | 3.6393 | 0.18999 | 9.69e-05 |
| 4.4 | -209.75 | -10.337 | -0.006562 |
| 4.5 | -3.9931 | -0.18753 | -0.00014192 |
| 4.6 | -2.3395 | -0.10667 | -9.0782e-05 |
| 4.7 | -1.9748 | -0.089754 | -8.0103e-05 |
| 4.8 | -2.1441 | -0.10007 | -8.6667e-05 |
| 4.9 | -3.2472 | -0.15953 | -0.00012438 |
| 5.0 | -14.616 | -0.76384 | -0.00050753 |
| 5.1 | 5.5822 | 0.30796 | 0.00017198 |
| 5.2 | 2.8027 | 0.1598 | 7.8043e-05 |
| 5.3 | 2.3753 | 0.13648 | 6.3244e-05 |
| 5.4 | 2.6684 | 0.15124 | 7.2591e-05 |
| 5.5 | 3.9862 | 0.21988 | 0.00011609 |
| 5.6 | 11.089 | 0.5923 | 0.00035215 |
| 5.7 | -14.211 | -0.73711 | -0.00049055 |
| 5.8 | -4.9783 | -0.25311 | -0.00018377 |
| 5.9 | -3.5911 | -0.18152 | -0.00013842 |
| 6.0 | -3.4646 | -0.17699 | -0.00013559 |
| 6.1 | -4.3644 | -0.22863 | -0.00016842 |
| 6.2 | -8.7207 | -0.47258 | -0.00032336 |
| 6.3 | 43.279 | 2.4265 | 0.0015178 |
| 6.4 | 6.9079 | 0.39755 | 0.00022922 |
| 6.5 | 4.5814 | 0.26724 | 0.00014645 |
| 6.6 | 4.3428 | 0.25341 | 0.00013766 |
| 6.7 | 5.355 | 0.30939 | 0.00017322 |
| 6.8 | 9.4289 | 0.53637 | 0.00031738 |
| 6.9 | 91.973 | 5.148 | 0.0032467 |
| 7.0 | -12.946 | -0.71577 | -0.00047803 |
| 7.1 | -7.1094 | -0.39113 | -0.00027184 |
| 7.2 | -5.9715 | -0.32987 | -0.00023298 |
| 7.3 | -6.5226 | -0.36496 | -0.00025536 |
| 7.4 | -9.7035 | -0.55339 | -0.00037527 |
| 7.5 | -32.625 | -1.9004 | -0.0012323 |
| 7.6 | 22.69 | 1.3468 | 0.00083366 |
| 7.7 | 9.845 | 0.59208 | 0.00035346 |
| 7.8 | 7.7615 | 0.46948 | 0.00027546 |
| 7.9 | 8.158 | 0.49302 | 0.00029045 |
| 8.0 | 11.314 | 0.67994 | 0.00040942 |
| 8.1 | 26.676 | 1.5914 | 0.00098955 |
| 8.2 | -59.077 | -3.5021 | -0.0022526 |
| 8.3 | -15.982 | -0.94465 | -0.00062474 |
| 8.4 | -11.099 | -0.65733 | -0.0004419 |
| 8.5 | -10.576 | -0.63082 | -0.00042512 |
| 8.6 | -13.106 | -0.79066 | -0.00052706 |
| 8.7 | -24.372 | -1.4903 | -0.00097303 |
| 8.8 | 664.81 | 41.198 | 0.026236 |
| 8.9 | 24.879 | 1.5587 | 0.00097034 |
| 9.0 | 15.207 | 0.95967 | 0.00058852 |
| 9.1 | 13.66 | 0.86482 | 0.00052809 |
| 9.2 | 15.961 | 1.0105 | 0.00062102 |
| 9.3 | 25.97 | 1.641 | 0.0010232 |
| 9.4 | 129.06 | 8.1383 | 0.0051672 |
| 9.5 | -45.485 | -2.8661 | -0.0018516 |
| 9.6 | -22.701 | -1.433 | -0.00093757 |
| 9.7 | -18.508 | -1.1738 | -0.00077235 |
| 9.8 | -19.797 | -1.2648 | -0.00083063 |
| 9.9 | -28.345 | -1.8276 | -0.0011901 |
| 10.0 | -77.994 | -5.0776 | -0.0032655 |

| Error Percentages  |
| ------------- |
| ![](images/errorsChart.png?raw=true)  |

To produce the chart above, the following code was used in the toString() function:

	std::ostringstream out;
	out << "| " << std::setprecision(2) << x;
	out << " | " << std::setprecision(5) << error(exact(x), y_euler);
	out << " | " << std::setprecision(5) << error(exact(x), y_midpoint);
	out << " | " << std::setprecision(5) << error(exact(x), y_RK4) << " |";
	return   out.str();

And the following code in the main() function:

	outputFile << "x" << "\t" << "%Err(E)" << "\t\t" << "%Err(M)" << "\t\t" << "%Err(RK4)" << std::endl;
	outputFile << "----" << "\t" << "----------" << "\t" << "----------" << "\t" << "----------" << std::endl;
	outputFile << "| 0.0 | 0.0 | 0.0 | 0.0 |" << std::endl;
	
e.) Varying h's:

h = 0.5 for x = < 0.0, 10.0 >

| x | y (RK44) | EXACT | %Err(RK4) |
| ------------- | ------------- | ------------- | ------------- |
| 0.0 | 0.0 | 0.0 | 0.0 |
| 0.5	 | 0.7628343855	 | 0.7684534442	 | 0.0073122% |
| 1	 | -1.616611002	 | -1.580998849	 | -0.022525% |
| 1.5	 | 1.99051666	 | 1.985745966	 | 0.0024025% |
| 2	 | -1.558087801	 | -1.4788027	 | -0.053614% |
| 2.5	 | -0.2875364592	 | -0.2314861673	 | -0.24213% |
| 3	 | 2.812101892	 | 2.914387906	 | 0.035097% |
| 3.5	 | -5.885674248	 | -5.614340022	 | -0.048329% |
| 4	 | 6.526171213	 | 6.745803673	 | 0.032558% |
| 4.5	 | -5.283225128	 | -4.62218308	 | -0.14302% |
| 5	 | -2.462245408	 | -1.612374396	 | -0.52709% |
| 5.5	 | 9.536558087	 | 10.93795441	 | 0.12812% |
| 6	 | -22.54974958	 | -19.84514567	 | -0.13629% |
| 6.5	 | 19.14928293	 | 22.79531867	 | 0.15995% |
| 7	 | -21.21060049	 | -14.17946262	 | -0.49587% |
| 7.5	 | -19.23999693	 | -8.410618979	 | -1.2876% |
| 8	 | 22.9476953	 | 40.68180013	 | 0.43592% |
| 8.5	 | -100.560952	 | -69.83105503	 | -0.44006% |
| 9	 | 28.82446395	 | 76.59589429	 | 0.62368% |
| 9.5	 | -124.6712022	 | -42.45472598	 | -1.9366% |
| 10	 | -172.0894553	 | -38.93988091	 | -3.4194% |

| h = 0.5  |
| ------------- |
| ![](images/h1Chart.png?raw=true)  |

h = 1.0 for x = < 0.0, 10.0 >

| x | y (RK44) | EXACT | %Err(RK4) |
| ------------- | ------------- | ------------- | ------------- |
| 0.0 | 0.0 | 0.0 | 0.0 |
| 1	 | -3.175159955	 | -1.580998849	 | -1.0083% |
| 2	 | -6.043489728	 | -1.4788027	 | -3.0867% |
| 3	 | -5.346117367	 | 2.914387906	 | 2.8344% |
| 4	 | -11.11750527	 | 6.745803673	 | 2.6481% |
| 5	 | -56.92563769	 | -1.612374396	 | -34.305% |
| 6	 | -188.3936291	 | -19.84514567	 | -8.4932% |
| 7	 | -469.3480766	 | -14.17946262	 | -32.101% |
| 8	 | -1139.889489	 | 40.68180013	 | 29.02% |
| 9	 | -3075.559979	 | 76.59589429	 | 41.153% |
| 10	 | -8675.559239	 | -38.93988091	 | -221.79% |

| h = 1.0  |
| ------------- |
| ![](images/h2Chart.png?raw=true)  |

h = 2.0 for x = < 0.0, 10.0 >

| x | y (RK44) | EXACT | %Err(RK4) |
| ------------- | ------------- | ------------- | ------------- |
| 0.0 | 0.0 | 0.0 | 0.0 |
| 2	 | 18.54140836	 | -1.4788027	 | -13.538% |
| 4	 | 47.20461599	 | 6.745803673	 | 5.9976% |
| 6	 | 570.1550803	 | -19.84514567	 | -29.73% |
| 8	 | 3507.777403	 | 40.68180013	 | 85.225% |
| 10	 | 24987.80713	 | -38.93988091	 | -642.7% |

| h = 2.0  |
| ------------- |
| ![](images/h3Chart.png?raw=true)  |

Errors for all the steps(h = 0.5, 1.0, 2.0)

| h Percent Errors  |
| ------------- |
| ![](images/hErrorChart.png?raw=true)  |

To produce the chart above, the following code was used in the toString() function:

	std::ostringstream out;
	out << std::setprecision(2) << x << "\t";
	out << std::setprecision(presision) << y_RK4 << "\t";
	out << std::setprecision(presision) << y_exact << "\t";
	out << std::setprecision(5) << error(exact(x), y_RK4) << "%";

	out << "| " << std::setprecision(2) << x << "\t";
	out << " | " << std::setprecision(presision) << y_RK4 << "\t";
	out << " | " << std::setprecision(presision) << y_exact << "\t";
	out << " | " << std::setprecision(5) << error(exact(x), y_RK4) << "% |";
	return   out.str();

And the following code in the main() function:

	double h = 0.1;
	double h1 = 0.5;
	double h2 = 1.0;
	double h3 = 2.0;
	
	double range = 10.0 / h3;
    	for (int i = 0; i < range; i++)
    	{
		y_euler = rk1(y_euler,h3,x);  //caculate y_{i+1}
		y_midpoint = rk2(y_midpoint, h3, x);  //caculate y_{i+1}
		y_RK4 = rk4(y_RK4, h3, x);  //caculate y_{i+1}
        	x = x + h3;       //increment x

		std::cout << toString(x, y_euler, y_midpoint, y_RK4, exact(x), 10) << std::endl;
		outputFile << toString(x, y_euler, y_midpoint, y_RK4, exact(x), 10) << std::endl;
	}

f.) Analyze your results:

(1) From the Error Percentages chart and the code we used in this assignment, we can see that the accuracy was 
greatest at RK4 and least at RK1.

(2) As x increases, the less accurate Rk1, RK2, and RK4 become.

(3) By varying the step size (h), the larger steps decrease the accuracy.

(4) Therefore from part e of this assignment, the most accurate integration method is Rk4 with h = 0.5 
(from the three choices 0.5, 1.0, 2.0) for x = < 0.0, 10.0 >. RK4 uses the forth integration from the exact function,
making it easily the closest representation. Therefore, the higher the order of integration the higher the accuracy to
the exact function.

## Part 2 - The Jello Cube (60pts)

| The Jello Cube Video |
| ------------- |
| [![IMAGE ALT TEXT](images/jelloCubeThumbnail.png?raw=true)](images/OrdinaryJelloCube.mp4)  |

## Part 3 - Written Questions (10pts)

(1) The jello's Ks (stiffness) is what helps the cube retain its shape. The higher the stiffness the more rigid the cube.
The jello's Kd (dampening force) determines how quickly the spring forces react on the springs. The higher the dampening
forces the quicker the springs return to their original shape.

(2) A benefit to our collision system is that we have our cubes colliding with solid objects (the floor, cylinders, etc). Our
cubes do not have to worry about colliding with dynamic shapes such as other cubes. This makes it easy to test the springs
to gravity, other springs in the cube, etc. Similarly, a drawback could be that we, those of us that didn't add additional
cubes, cannot have an accurate simulation of the cube colliding with different objects.

(3) Buildings (particularly tall buildings), bridges, and other giant structures could benefit from mass-spring simulations.
The steel beams could be observed as the springs, as well as how they work with other beams in the structure to keep
the structure upright, straight, and strong.

(4) Yes and no. As stated in class, realistic physics can be very difficult to simulate. My jello cube appears to be behaving
realistically (when working), but that is my opinion. Someone with a much better understanding of physics (such as our fearless leader)
would have a keener eye to judge if my jello cube is behaving similarly to a realistic jello cube. According to my calculations in
part 1 f.4 (because my jello cube isn't operating at max potential), I would use RK4 to get the jello cube stable as it is the most
accurate integration method.

(5) To simulate water I would use a tool developed by Blizzard Entertainment's Overwatch cinetatic team called volume fill. It allows you to take a geometric surface, turn it in to a volume, and control it to look like smoke, water, etc. It is less computationally expensive as other fluid dynamic particle systems, and can be applied to curves and geometry. I was lucky enough to attend the Overwatch cinematic panel at BlizzCon 2016 which goes in to more detail (https://www.youtube.com/watch?v=dyiHr06Einw#t=30m03s).
