# Homework 2 :  Discrete-Event Simulation Assignment

## IDS6938-Simulation Techniques - [University of Central Florida](http://www.ist.ucf.edu/grad/)

[University of Central Florida](http://www.ist.ucf.edu/grad/)
This is the framework for homework #2. 

2 Extra Days Used - 1 Remaining
Extra Credit:
* (10 Points) - Add a 2D visualization to AnyLogic for Part 3.
* (10 Points) - Add a 3D visualization to AnyLogic for Part 3.
* (20 Points) - Complete Part 2 with a 3D version of Snakes and Ladders. Construct the game's transition matrix, simulate the game, and analyze the results.

The assignment is due: **Tuesday, March 28 at 11:59PM (EST)**


# Introduction
A Discrete-event Model simulates a complex system as an ordered sequence of well-defined events. Mathematically Discrete-event models use Markov Processes, Queuing systems, events, probability / statistics, and random variables. The purpose of this assignment is to learn the mathematical foundations, how to program these models, and how to simulate them. The assignment is due Tuesday, March 28, 2017 at 11:59 P.M.

Major parts for the Assignment
You can think of the assignment broken up to 4 major parts:
* Empirical Tests of Randomness
* Snakes and Ladders (Discrete Event Markov Chains and Monte Carlo Simulations)
* Discrete Event Simulation - Queue Simulation
* Composing a final report

The goal of this assignment is to become familiar with the concepts in the second third of the class. You will be expected to compose a *final report* which demonstrates your understanding on the material in each section of the assignment. Be visual! - Pictures say a thousand words so you do not have to. Show off your different configurations and really explore the assignment.

# Assignment
## Part 1: Empirical Tests of Randomness (20 pts).
**(a) - 3pts:** Output the results of five different random number engines, using a uniform distribution for values between [0-100]. Generate useful charts and statistics from the output to analyze how uniform these values truly are. You are expected to look at some advanced statistics and test, for example: tests like the Kolmogorov-Smirnov test, Chi-square test, Autocorrelation test, and Spearman’s Rank Correlation Coefficient are a few examples of ones your could use.)

| N = 100000 | N = 100000 |
| ------------- | ------------- |
| ![](images/part1a/MT100000.png?raw=true) | ![](images/part1a/Knuth100000.png?raw=true) |
| ![](images/part1a/MS100000.png?raw=true) | ![](images/part1a/Ranlux100000.png?raw=true) |
| ![](images/part1a/Sobol100000.png?raw=true) | ![](images/part1a/p1ausefulstats.png?raw=true) |

**(b) - 2pts:**  Vary *N* (amount of samples). How do things change.

| N = 500 | N = 500 |
| ------------- | ------------- |
| ![](images/part1b/MT500.png?raw=true) | ![](images/part1b/Knuth500.png?raw=true) |
| ![](images/part1b/MS500.png?raw=true) | ![](images/part1b/Ranlux500.png?raw=true) |
| ![](images/part1b/Sobol500.png?raw=true) | ![](images/part1b/p1busefulstats.png?raw=true) |

**(c) - 3pts:** Fix a random engine of your choice from part (a), and now vary five different [distributions](http://www.cplusplus.com/reference/random/) for just the psedo-random numbers. Again, analyze your results with graphs and statistics of choice.

| N = 100000 | Engine: Knuth |
| ------------- | ------------- |
| ![](images/part1c/UniformReal100000.png?raw=true) | ![](images/part1c/Normal100000.png?raw=true) |
| ![](images/part1c/Geometric100000.png?raw=true) | ![](images/part1c/Bernoulli100000.png?raw=true) |
| ![](images/part1c/Poisson100000.png?raw=true) | ![](images/part1c/p1cusefulstats.png?raw=true) |

**(d)- 4pts:** Generate random numbers in two-dimensions for a unit square. Plot the results for the different random number engines. The vertical axis should vary N in increasing order. The horizontal axis should show of the random number engines.

| Unit Square - Engines, N = 500, 1000, 2000 |
| ------------- |
| ![](images/part1de/p1dplots.png?raw=true) |

**(e)- 4pts:** Generate random numbers in two-dimensions for a unit square. Plot the results for the different distributions. The vertical axis should vary N in increasing order. The horizontal axis should show of the random number engines. (See [Random Numbers Webcourse page](https://webcourses.ucf.edu/courses/1246518/pages/random-numbers?module_item_id=10541423) for a rough idea what you should produce.)

| Unit Square - Distributions, N = 500, 1000, 2000 |
| ------------- |
| ![](images/part1de/p1cplots.png?raw=true) |

**(f)- 4pts:** Repeat parts (d) and (e) with a unit circle.

| Unit Circle - Engines, N = 1000 |
| ------------- |
| ![](images/part1de/p1fcircle1000.png?raw=true) |

| Unit Circles - Distributions, N = 1000 |
| ------------- |
| ![](images/part1de/p1fdiscircle1000.png?raw=true) |

* ANSWER: If you run each engine twice (for sin and cos unit calculations), run each distribution with one random engine twice, then calculate their new x and y for the circle, all tripled to account for varying N's, you'd run: 20 simulations, have 60 lines of data, and 30 unit circles and squares. Not including previous parts (although this builds on them). I had already made all 30 unit squares, but for the sake of time I did one unit circle for each engine and distribution with N = 1000 to show it can be done. Are you sure this part isn't worth 40pts? No matter, full excel sheets with all 20+ simulations, 60+ lines of data, and 30+ unit circles and squares for each part are in their corresponding image folder.

## Part 2 - Snakes and Ladders (Discrete Event Markov Chains and Monte Carlo Simulations) (30 pts)
**(a) Null State Game transition matrix - 10pts:** The *null state game* is defined by a game with no snakes and no ladders. This simplifies the game to just the moves of the two dice rolls. Create the transition matrix for the null state game. The Transition Matrix would be decided by the roll of a fair, six-sided die, so it would start to look like: From state 0 it is equally probable of landing on squares 1-6. From state 1 t is equally probable of landing on squares 2-7, and so on. Create this transition matrix. The end is trickier, we will consider any roll past 100 a win case. (Opposed to rolling exactly onto square 100.) Confirm you have a well formed stochastic matrix (Write checks for confirming each row of T sums to one and all elements are non-negative). The Transition Matrix methods can be found in the TransitionMatrix.h file.

* ANSWER: Everything works!

| Null State Game |
| ------------- |
| ![](images/part2b/p2aproof.png?raw=true) |

**(b) Simulate and analyze the results of Null State Game - 10pts:** What is the modal number of moves required by a single player to finish the game? We will be simulating the game two different ways. **(1) Markov Chain**: The game can be analyzed with a row vector, *v* with 101 components, representing the probabilities that the player is on each of the positions. V(0) is (1,0,0,...,0) since we know we start at square 0. v evolves by: For this part (1) use the *Markov project* in the Snake and Ladders starter code.<BR>

* ANSWER: The modal number of moves required by a single player to finish the game is 42. Just kidding, but no not really... Using the Markov Chain we can expect to see our first likelihood of winning at 18 rolls. However, by likelihood I mean you'd have a 1.01024e-11 likelihood of winning. But no worries, by roll 44 you'd be guaranteed a win. See graphs and output below.

**(2) Monte Carlo:** he will will use a monte carlo process to solve our Discrete Time Markov Chains. Here (2) use the DTMC project, and utilize the DTMC method similar to what we did in class. <BR><BR>Produce graphs to analyze the results and show how the game evolves over time for both methods. Plot useful statistics of the results such as percentage chance of finishing the game in n-moves, cumulative probability of finishing the game in n-moves, and other ways to convey useful information of the results.

* ANSWER: Using the DTMC method we can expect to see our first win around 25 rolls and win in ever game after around 32 rolls. The DTMC null state graph below shows where each game ended after 25 rolls. You can see one game made it to the finish. Similarly, you can see the results of part b1 below in the Markov graph.

| DTMC First Win After 25 Rolls |
| ------------- |
| ![](images/part2b/p2b2dtmc1w.png?raw=true) |

| DTMC All Wins After 32 Rolls |
| ------------- |
| ![](images/part2b/p2b2dtmcAw.png?raw=true) |

| Useful Stats (full excel chart in images folder) |
| ------------- |
| ![](images/part2b/p2busefulstats.png?raw=true) |

| Markov Null State Graph |
| ------------- |
| ![](images/part2b/MarkovNullState.png?raw=true) |

| DTMC Null State Graph after 25 rolls |
| ------------- |
| ![](images/part2b/DTMCNullState.png?raw=true) |


**(c) Simulate and analyze the results of Snakes and Ladders -10pts:**  Construct a new transition matrix based on the table:

Ladders From  | Ladders To | |  Snakes From  | Snakes To 
-------- | -------- | ------------- | -------- | -------- 
3|19| |11|7
15|37| |18|13
22|42| |28|12
25|64| |36|34
41|73| |77|16
53|74| |47|26
63|86| |83|39
76|91| |92|75
84|98| |99|70

Run the same simulation and analyze your results similar to part (b) for the proper game of *Snakes and Ladders* for both methods. How often are the snakes and ladders used, how do the probability of finishing change, etc? What is the maximum and expected amount of moves for the game? Use charts and graphs to illustrate these points.

* ANSWER: Everything Works! As seen below, because of the snakes and ladders, there is no definite possibilty of finishing. The Markov graph shows that even after 100 rolls the probability of finishing is still not 100%. The DTMC graph shows where players ended after 100 rolls, with only two players making it to the end. For Markov, as you increase the amount of rolls you approach a 92% probability of reaching the end. With DTMC you can expect to hit the end eventually, but there is no definite amount of rolls where you can expect to reach the end.

| Markov |
| ------------- |
| ![](images/part2c/p2cmarkov.png?raw=true) |

| Markov Graph |
| ------------- |
| ![](images/part2c/p2cmarkovgraph.png?raw=true) |

| DTMC |
| ------------- |
| ![](images/part2c/p2cdtmc.png?raw=true) |

| DTMC Graph |
| ------------- |
| ![](images/part2c/p2cdtmcgraph.png?raw=true) |

**(d) Think - 10pts:** If these games are built entirely on chance, do they require any strategy? Is it really a *game*, would you rather play games of chance or games of strategy?

* ANSWER: Even if strategy (blowing on dice, shaking hand, etc.) is introduced in to Snakes and Ladders, it will not alter the outcome. For example, blowing on dice does not increase the probability of it landing on a particular side (unless you want to account for the wind resistance and weight of your spit). Therefore if a game is only a game if strategy is involved, then games like Snakes and Ladders and I Declare War are not games. They are entertaining exercise of chance (and very long homework assignments - I'm not bitter). See the markov_results.txt, markov_results_wins.txt, dtmc_results.txt, and excel sheets (image folder) for more information.

## Part 3 - Discrete Event Simulation - Queue Simulation (30 pts)

**(a) - 4pts:** To start create the senario in the figure above in *main.cpp*. Checkin will have a *mu* of 53 and accept new arrivals, the security gates will have a *mu* of 20, and will not accept new arrivials, boarding will have a *mu* of 80. You will have to set up  the appropriate *MM1_Queue* objects to capture the functionality above.

| main.cpp |
| ------------- |
| ![](images/part3/p3acode.png?raw=true) |

**(b) - 4pts:** You want to add a check that your process is within an error range *is_within_error_range(float)* where the error range will be 0.002. You also want to process the next event, and add an external arrival where marked.

| main.cpp, is_within_error_range(0.002) |
| ------------- |
| ![](images/part3/p3bcode.png?raw=true) |

**(c) - 3pts:** in *mm1_queue.cpp* : add code to caculate the expected results for: 
  *  expected_server_utilization 
  *    expected idle prob
  *   expected queue length 
  *  expected number customers 
  * expected waiting time
  * expected response time 

| mm1_queue.cpp |
| ------------- |
| ![](images/part3/p3ccode.png?raw=true) |

**(d) - 4pts:** Write code to call the functions to output and generate data from the airport senario. Plot and analyze the useful statistics/results in the program of your choice.  (Hint -  basically call  *.output();* on the MM1_Queue objects you create. Hint2 - two other use functions are *get_current_time()* and  *plot_results_output()* call intially on your intial MM1_Queue object.)  

* ANSWER: From the graphs below we can see how the simulation performed each task compared to the expected performance of that task. For example, the number of customers was higher than expected a majority of the time, and the wait time was around average (for once). 

| main.cpp, output code |
| ------------- |
| ![](images/part3/p3output.png?raw=true) |

| Airport Useful Stats Graphs (full chart in image folder) |
| ------------- |
| ![](images/part3/p3dcharts.png?raw=true) |

**(e) - 15pts:** Download the personal edition of **[Anylogic](http://www.anylogic.com/)**, read through the [documentation](http://www.anylogic.com/learn-simulation) as needed, and set up the same type of simulation discussed above.

| AnyLogic Airport Simulation |
| ------------- |
| ![](images/part3/p3eanylogicchart.png?raw=true) |

| AnyLogic Airport 2D |
| ------------- |
| ![](images/part3/p3eanylogic2D.png?raw=true) |

| AnyLogic Airport 3D |
| ------------- |
| ![](images/part3/p3eanylogic3D1.png?raw=true) |
| ![](images/part3/p3eanylogic3D2.png?raw=true) |


## Part 4 - Implementing Extra Features (10 pts)
Implementing 2 features on the extra features list. Pick any feature on the "*extra features*" list below to customize your assignment to fit your interests. Please document this in your writeup. (*Note: These should total 10pts. You could successfully implement a feature worth 10pts or greater. This also fulfills this requirement. The features are assigned points based on difficulty. The 5pt features are more straightforward.*)

## Part 5 - Final Report (10 pts)
Write up the results to the previous sections in the main *readme.md* in your forked repository. Turn in the URL for your fork in webcourses. Be visual. The report should contain the graphs and analysis requested. I have high expectations for the documentation here and you should allot the proper time to compose the writeup.


## Extra Features (Extra Credit - 25pts)
You have to implement two features from this list for Part 4. You may choose any two features you wish from this list. (Please explicitly note them in your *Readme.md*)

If you feel like going beyond the scope of the assignment, you should consider implementing more of the following extra features. *Get the assignment working without them first.* You can get a maximum of 25 points in extra credit. Simply implementing these things doesn't guarantee you a 25; you really need to go above and beyond to get the full amount. (*The instructor reserves the right to hand out extra credit as his he sees fit.*)

* **(5 Points)** - Implement and compare Halton, Hammersley, (Or another quasi method) Quasi sequences and add them to your analysis for appropriate subparts of Part 1.
* **(5 Points)** - Implement different distributions inside the Quasi random sequences and add them to your analysis for appropriate subparts of Part 1.
* **(5 Points)** - Implement and compare another (advanced) psedo random sequences and add them to your analysis for all subparts of Part 1 (Examples include: [PCG](http://www.pcg-random.org/), or [Random123](https://github.com/DEShawResearch/Random123-Boost)).
* **(20 Points)** - Complete Part 2 with a different board game. Construct the game's transition matrix, simulate the game, and analyze the results (Run the game past the instructor).
* **(20 Points)** - Complete Part 2 with a 3D version of Snakes and Ladders. Construct the game's transition matrix, simulate the game, and analyze the results.
* **(10 Points)** - Provide code in (Python, R, Matlab...) that demonstrates an animation of the board itself evolving overtime for Snakes in Ladder for part 2. 
* **(10 Points)** - Add a 2D visualization to AnyLogic for Part 3.
* **(10 Points)** - Add a 3D visualization to AnyLogic for Part 3.
* **(5 Points)** - Pick a research problem (from your dissertation, Energy Microgrids, Missle Defence...). Compare and contrast different software packages (AnyLogic, Simio, Simulu8, Arena etc). Convince me as your "manager/advisor" what advantages, weaknesses, and costs each program has. Come to a conclusion. Roughly sketch out how you would formulate the problem in the framework.
* **(10 Points)** - Create an Anylogic simulation for Part 2 - Snakes and Ladders.
* **(10 Points)** - Setup another resource allocation / queueing problem related to your research in Anylogic with a basic visualization
* **(10 Points)** - Setup up SmartGrid or a Microgrid System that creates resources of power from wind, solar, and electric grid. Set up various devices in your house to draw power. [Reference 1](http://www.sciencedirect.com/science/article/pii/S1877050916301740),   [Reference 2](http://www.tandfonline.com/doi/full/10.1080/19401493.2013.866695?src=recsys&).
* **(25 Points)** - Set up a discrete simulation of your choice that uses an approved real-time data source and visualizes the results. (See instructor for approval).
* **(N Points)** - You are welcome to make suggestions for a feature of your own choosing, but they must be approved by instructor before implementing.
