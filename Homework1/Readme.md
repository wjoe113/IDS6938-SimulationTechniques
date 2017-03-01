#Homework 1 : The Jello Cube (Continuous Simulation Assignment)
## IDS6938-Simulation Techniques - [University of Central Florida](http://www.ist.ucf.edu/grad/)


This is the framework for homework #1. Please first read the [homework writeup](HomeWork%231.pdf).

The assignment is due: Monday, February 27 at 11:59PM (EST)

| undeformed jello  | deformed jello |
| ------------- | ------------- |
| ![](images/undeformed3.png?raw=true)  | ![](images/deformed3.png?raw=true) |

## Part 1 - Numerical Analysis of Integration Functions (25pts)

a.) exact = exp(x / 2.0) * sin(5.0 * x)

b.) df = y - (1.0 / 2.0) * exp(x / 2.0) * sin(5.0 * x) + 5.0 * exp(x / 2.0) * cos(5.0 * x)

The code below shows the exact and df functions used in this part:

    double df(double x, double y)            //function for defining dy/dx
    {
        return y - (1.0 / 2.0) * exp(x / 2.0) * sin(5.0 * x) + 5.0 * exp(x / 2.0) * cos(5.0 * x);
    }

    double exact(double x)            //function for defining dy/dx
    {
	    return exp(x / 2.0) * sin(5.0 * x);
    }


c.) The numerical integrations for RK1, RK2, and RK4, h = 0.1 for x = < 0.0, 10.0 >


Something

| RK1  | RK2 | RK4 | Exact |
| ------------- | ------------- | ------------- | ------------- |
| 0.1  | 0.2 | 0.3 | 0.4 |
| 0.1  | 0.2 | 0.3 | 0.4 | 
| 0.1  | 0.2 | 0.3 | 0.4 | 
| 0.1  | 0.2 | 0.3 | 0.4 | 
