# Homework 3 : Agent based Simulation Assignment 

## IDS6938-Simulation Techniques - [University of Central Florida](http://www.ist.ucf.edu/grad/)

[University of Central Florida](http://www.ist.ucf.edu/grad/)
This is the framework for homework #3. 

The assignment is due: **Monday, April  24 at 11:59PM (EST)**

I will be using **two late days** (my last late day and the one additional late day from Joe)

# Introduction
The goal of this assignment is to enable the behavioral animation of vehicle-like walking agents. 

You will be expected to compose a *final report* which demonstrates your understanding on the material in each section of the assignment. Be visual! - Pictures say a thousand words so you do not have to. Show off your different configurations and really explore the assignment.


### Part 1: Behaviors

The goal of this assignment is to enable the steering behavioral animation of agents.

We represent an agent as a two-dimensional disk with mass (**m**) and moment-of-inertia (**I**) that is capable of generating a force **F** along body x-axis with a torque about the z-axis. For this assignment assume that the agent only translates in the world x-y plane and rotates about the body z-axis.

![](images/behavior.png?raw=true)

**(a) - 10 points** : Compute derivative vector given input and state vectors. Implement the function *SIMAgent::FindDeriv()*. This function sets derive vector to appropriate values after being called.

Description of agent state vector and input vector:  
* state[0] is the position of the agent in local body coordinates (almost useless in this project);  
* state[1] is the orientation angle of the agent with respect to world (i.e. global) coordinates;  
* state[2] is the velocity of the agent  in local body coordinates.  
* state[3] is the angular velocity of the agent in world coordinates. 
* input[0] is the force in local body coordinates;  
* input[1] is the torque in local body coordinates

You will need to set deriv[0], deriv[1], deriv[2], deriv[3]. Compute derivative vector given input and state vectors. This function sets derive vector to appropriate values after being called. 
* deriv[0] is the velocity of the agent  in local body coordinates
* deriv[1] is the angular velocity of the agent in world coordinates
* deriv[2] is the force in local body coordinates divided by the mass.
* deriv[3] is the torque in local body coordinates divided by the inertia.

You also must implement *SIMAgent::InitValues()*: Try to figure out appropriate values for control and behavior settings. You need to find out appropriate values for: *SIMAgent::Kv0, SIMAgent::Kp1, SIMAgent::Kv1, SIMAgent::KArrival, SIMAgent::KDeparture,
SIMAgent::KNoise,	SIMAgent::KWander, SIMAgent::KAvoid, SIMAgent::TAvoid, SIMAgent::RNeighborhood, SIMAgent::KSeparate, SIMAgent::KAlign, SIMAgent::KCohesion.*


**(b) - 20 points**: In this part of the assignment you will need to implement 6 types of individual behaviors and 5 types of group behaviors. Create the following behaviors through appropriate computation of V<sub> d</sub>  and θ<sub>d</sub>  commands:
* Seek
* Flee
* Arrival
* Departure
* Wander
* Obstacle Avoidance

**(c) - 20 points**: Implement the functions for the following group behaviors: 
* Seperation
* Cohesion 
* Alignment 
* Flocking
* Leader Following

# Part 2 - Simulating a simple pedestrian flow

The goal of this part of the assigment is to simulate the pedestrain flow for various configurations. Pedestrian traffic simulation is an important, sometimes required, stage for certain construction projects such as shopping centers, airports, railway stations, or stadiums. hese analyses can be used by architects in the design stage, by facilities owners contemplating changes, by city planners to evaluate rush hours, or even by civil authorities to simulate evacuations or other emergencies. 

**(a) - 0 points**: Follow the Anylogic example for the [Subway Entrance example](https://help.anylogic.com/index.jsp?topic=/com.xj.anylogic.help/html/_PL/tutorial/Subway_Entrance.html). Create the appropriate [boundaries and walls](https://help.anylogic.com/index.jsp?topic=/com.xj.anylogic.help/html/markup/Wall.html), and the display ther pedestrian density map, [statistics](https://help.anylogic.com/index.jsp?nav=/4_1_5), [2D and 3D animations](https://help.anylogic.com/index.jsp?topic=/com.xj.anylogic.help/html/_PL/reference/Animation.html).

![](images/subwayPic1.png?raw=true)

* ANSWER: Above is my subway entrance example. I found the tutorial very helpful in learning the fundamentals of Anylogic (hopefully seen below as well). The pedestrians enter the subway and line up in one of six lines. Once they've reached a line, one pedestrian will be allowed to enter the train per line per second. The rate at which people enter the subway and board the train are parallel, with a slight offset on the boarding lines due to the pedestrians having to stop and wait in line.

**(b) - 20 points**: Create a maze. Generate the pdm, stats, and animations like before. Vary [parameters in your agents](https://help.anylogic.com/index.jsp?topic=/com.xj.anylogic.help/html/_PL/reference/Attributes.html) to give them different behaviors and show the pedestrians change how they navigate the maze.

| Pedestrian logic | Paths (Click on image to enlarge) |
| ------------- | ------------- |
| ![](images/MazeImages/mazeLogicOverlay.png?raw=true) | ![](images/MazeImages/mazePaths.png?raw=true) |

| My Maze |
| ------------- |
| ![](images/MazeImages/mazePart2b.png?raw=true) |

* ANSWER: Above is my maze along with its pdm, stats, and 3D animation. There are five paths, four dead ends, and one fork in the maze. The first image shows the pedestrian logic(not just any logic ;D) over its location in the maze. The second image shows the five paths in the maze(also placed in third image). The third image shows my maze, its pdm, logic, graph for each path/deadend, the maze paths, and the 3D view. Each color on the graph corresponds to that colored path.

* The results from my maze are as I expected with the most traveled path being the shortest path (southern-most, dark blue). When each pedestrian reaches an intersection in the maze they have a 50% probability of choosing either path. So how could more pedestrians travel south than north? The southern path is the shortest path and it receives all the pedestrians who travel through the fork. I made the fork in the road to see how pedestrians would handle switching from one major path to the other (dark green to dark blue). Thus, it must be because it receives pedestrians from the fork. However, as seen by the light blue and yellow lines on the graph, slightly more pedestrians passed through the fork from the bottom path (light blue) than from the top path (yellow). This proves more pedestrians used the southern path regardless of the 50% probability. Therefore, my theory that pedestrians will take the quickest path the majority of the time is correct. []

| Group Logic | Group Settings |
| ------------- | ------------- |
| ![](images/MazeImages/groupLogic.png?raw=true) | ![](images/MazeImages/groupSettings.png?raw=true) |

| My Maze... When people follow each other around |
| ------------- |
| ![](images/MazeImages/mazeGroupEffort.png?raw=true) |

* ANSWER: I varied my maze runners (agents) by telling them to group up and solve the maze as a team. When I told them to swarm I noticed maze runners coming out of dead ends would follow other runners back into them. This was the exact opposite of what I wanted, because who really follows someone back in to a dead end?! So I switched them to chain (image two) and edited my logic (image one) to instruct past dead-enders to head out. This solved the issue and provided the results above (image three). What I found was when runners were chained together they got stuck in the fork. This was natural as people are pushy and we can't walk through each other. For future development, I would recommend making lanes in the fork to neatly allow people to pass.

* Compared to our first maze we achieved slightly different results. First, the number of maze runners to hit a dead end was greatly reduced. This is potentially because when the first person in a chain hits a dead end, he/she immediately turns around leading the others away. Second, we can see the amount of runners going through the fork was the most out of all the paths. As obvious as the large amount of people stuck in the center of the maze, we can see that too many people passing through a narrow spot causes a lot of traffic (I'm referring to you 95 corridors!). Third, we can see that the green and light green paths (top two paths) have similar patterns as the first maze. This is due to the two paths not being blocked by the traffic at the fork. Lastly, we can see an overall increase in the density of pedestrians in all paths. This is due to people traveling in groups rather than individually. While the first maze saw around 1000 maze runners per hour complete the maze, the second maze saw around 5000 runners per hour complete the maze. In conclusion, I'd be content if my CPU water block had the same traffic as the second maze. []

**(c) - 30 points**: Model and analyze a building (or floor/outdoor space/stadium) on campus. (There is help on piazza how to find rough building plans - we expect something plausible). Create a senario: evacuation, daily office routine, special event, normal egress.... etc., and model and design your own experiment to determine if the building design suits the needs of its users. Start with photographs of your site, describe your site, describe your senario and hypothesis. Then use an agent-based pedestrian simulation to visualize your experiment's results.

| UCF R&W Center Sim | UCF R&W Center Map |
| ------------- | ------------- |
| ![](images/RaWCenter/RaWCenterSim.png?raw=true) | ![](images/RaWCenter/RaWCenterMap.png?raw=true) |

| Logic | Logic Breakdown |
| ------------- | ------------- |
| ![](images/RaWCenter/RaWCenterLogic.png?raw=true) | ![](images/RaWCenter/RaWCenterLogicLegend.png?raw=true) |

| Fire Alarm Logic | 3D Model |
| ------------- | ------------- |
| ![](images/RaWCenter/RaWCenterFireLogic.png?raw=true) | ![](images/RaWCenter/RaW3D.png?raw=true) |

* ANSWER: Above is my setup for simulating people going to the Recreation and Wellness Center (RWC) on campus. The RWC is located on the south side of campus and is UCF's largest gym. The simulation depicts simple gym activities such as working out, running laps, going to a group exercise class, going to the bathroom (and showering), and going to the gym's Subway. Each activity is color-coded and can be seen on the map legend above. Also seen above is the logic for each of the activities. When a person enters the gym, they have many activities to choose from. Certain activities such as working out and attending group classes are weighed more than other activities. After each activity, a gym goer can choose to participate in another activity or leave the gym. Each probability of each activity and its relationship to other activities can be found in the logic of my simulation included in this project folder.

* The stats below show the traffic for each activity as well as people entering and leaving the gym (color coded to match map). As stated above, working out has the most traffic. People eating subs and showering tied for the least amount of traffic, which means most people don't shower and leave the gym smelling like sweat and (maybe) subs (yuck!). People attending group classes saw a steady traffic rate, while people taking laps around the indoor track saw a steady increase in laps over the course of the day (way to go runners!). A run-through of the simulation as well as a fire drill simulation can be seen below.


| Regular Gym Day | Fire Alarm |
| ------------- | ------------- |
| ![](images/RaWCenter/RegularGymDay.png?raw=true) | ![](images/RaWCenter/GymFireAlarm.png?raw=true) |

* ANSWER: Above you can see a side-by-side comparison of a typical day at the gym and when there is a fire/fire alarm. For both, the traffic patterns seen by the pdm are what they're expected to be for the RWC. Most people congregate toward the entrance where the Subway is located, in the hallway with the group exercise classrooms, and around the indoor track. The front entrance also showed heavy traffic because it is the primary way to enter and exit the gym. In the fire simulation, we can see a slight increase in exit traffic for the other two exits because depending on which activity people are performing when the fire alarm goes off determines which exit they take (they go to the nearest exit, smart cookies!).

* The stats also show this flux in traffic as when the fire alarm goes off all the activities have lower traffic rates than the exits, until there is no one left in the gym. Even people who just entered the gym turn around and leave. this proves our simulation correctly displays what happens in a typical day at the gym as well as in a fire/fire alarm scenario. A video on the typical day at the gym until the fire alarm goes off can be seen here:

