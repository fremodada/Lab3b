using System;

class MainClass {
  public static void Main (string[] args) {
  /*
Calculate Speed cars, based on user input

Speed is calculated by dividing distance traveled(miles) by time (hr) taken.
Speed = Distance/Time
Your program should
a) Inputs for each car:
•	distance traveled (in miles)
•	time taken (in hours)
b) Logic: calculate the speed for each car
c) Result: display the speed for each car.
4 Calculate the average speed of the number of cars entered

*/

//Define car # variable
int carNumber = 1;

//Define number of cars
int totalCars;

//Define car speed
double carSpeed = 0.00;

//Define total speed of all cars
double totalSpeed = 0.00;

//Define average speed of all 7 cars
double averageSpeed = 0.00;

//Inputs
double distanceTraveled;
double timeTaken;


//Get number of cars
Console.WriteLine ("Enter number of cars for the race!");
totalCars = Convert.ToInt32(Console.ReadLine()); 

//Begin loop
while (carNumber <= totalCars)
{
//Get input

Console.WriteLine ("Enter distance covered for Car#" + carNumber);
distanceTraveled = Convert.ToDouble(Console.ReadLine());  
Console.WriteLine ("Enter time taken in hour(s) for Car#" + carNumber);
timeTaken = Convert.ToDouble(Console.ReadLine()); 
//Calculate sand display peed
carSpeed = distanceTraveled / timeTaken;
Console.WriteLine ("Car#" + carNumber + " speed is " + carSpeed + " miles per hour.");
//Add to Total Speed
totalSpeed = totalSpeed + carSpeed;
//Move on to the next car
carNumber++;
}

//Calculate the Average Speed and display
averageSpeed = totalSpeed / totalCars;
Console.WriteLine ("The average speed of the cars is " + averageSpeed + " miles per hour.");
  }
}