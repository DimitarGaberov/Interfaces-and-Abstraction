# Interfaces-and-Abstraction

1. Shapes
Build hierarchy of interfaces and classes:
&lt;&lt;inteface&gt;
&gt;
&lt;&lt;Drawable&gt;
&gt;
+Draw()
Circle
-radius: Integer
Rectangle
-width: Integer
-height: Integer

2. Cars
Build hierarchy of interfaces and classes:
&lt;&lt;ICar&gt;&gt;
+Model: string
+Color: string
+Start(): string
+Stop(): string
&lt;&lt;IElectricCar&gt;
&gt;
+Battery: int
Seat
+ToString(): string
Tesla
+ToString(): string

Define an Interface IPerson
Define an interface IPerson with properties for Name and Age. Define a class Citizen which implements IPerson and has a constructor which takes a string name and an int age.

Multiple Implementation
Using the code from the previous task, define an interface IIdentifiable with a string property Id and an interface IBirthable with a string property Birthdate and implement them in the Citizen class. Rewrite the Citizen constructor to accept the new parameters.

Ferrari
Model an application which contains a class Ferrari and an interface. Your task is simple, you have a car - Ferrari, its model is "488-Spider" and it has a driver. Your Ferrari should have functionality to use brakes and push the gas pedal. When the brakes are pushed down print "Brakes!", and when the gas pedal is pushed down - "Zadu6avam sA!". As you may have guessed this functionality is typical for all cars, so you should implement an interface to describe it. 
Your task is to create a Ferrari and set the driver's name to the passed one in the input. After that, print the info. Take a look at the Examples to understand the task better.
Input
On the single input line, you will be given the driver's name.
Output
On the single output line, print the model, the messages from the brakes and gas pedal methods and the driver's name. In the following format:
<model>/<brakes>/<gas pedal>/<driver's name>
Constraints
The input will always be valid, no need to check it explicitly! The Driver's name may contain any ASCII characters.

Telephony
You have a business - manufacturing cell phones. But you have no software developers, so you call some friends of yours and ask them to help you create a cell phone software. They have already agreed and you started working on the project. The project consists of one main model – a Smartphone. Each of your smartphones should have functionalities of calling other phones and browsing in the world wide web.
These friends of yours though are very busy, so you decide to write the code on your own. Here is the mandatory assignment:
You should have a model - Smartphone and two separate functionalities which your smartphone has - to call other phones and to browse in the world wide web. You should end up with one class and two interfaces.
Input
The input comes from the console. It will hold two lines:
First line: phone numbers to call (String), separated by spaces.
Second line: sites to visit (String), separated by spaces.
Output
First call all numbers in the order of input then browse all sites in order of input
The functionality of calling phones is printing on the console the number which are being called in the format:
Calling... <number>
The functionality of the browser should print on the console the site in format:
Browsing: <site>!
If there is a number in the input of the URLs, print: "Invalid URL!" and continue printing the rest of the URLs.
If there is a character different from a digit in a number, print: "Invalid number!" and continue to the next number.
Constraints
Each site's URL should consist only of letters and symbols (No digits are allowed in the URL address).

Border Control
It’s the future, you’re the ruler of a totalitarian dystopian society inhabited by citizens and robots, since you’re afraid of rebellions you decide to implement strict control of who enters your city. Your soldiers check the Ids of everyone who enters and leaves.
You will receive an unknown amount of lines from the console until the command “End” is received, on each line there will be a piece of information for either a citizen or a robot who tries to enter your city in the format “<name> <age> <id>” for citizens and “<model> <id>” for robots. After the end command on the next line you will receive a single number representing the last digits of fake ids, all citizens or robots whose Id ends with the specified digits must be detained.
The output of your program should consists of all detained Ids each on a separate line (the order of printing doesn’t matter).
Input
The input comes from the console. Every commands’ parameters before the command “End” will be separated by a single space.

Birthday Celebrations
It is a well known fact that people celebrate birthdays, it is also known that some people also celebrate their pets birthdays. Extend the program from your last task to add birthdates to citizens and include a class Pet, pets have a name and a birthdate. Encompass repeated functionality into interfaces and implement them in your classes. 
You will receive from the console an unknown amount of lines. Until the command “End” is received, each line will contain information in one of the following formats “Citizen <name> <age> <id> <birthdate>” for citizens, “Robot <model> <id>” for robots or “Pet <name> <birthdate>” for pets. After the “End” command on the next line you will receive a single number representing a specific year, your task is to print all birthdates (of both citizens and pets) in that year in the format day/month/year (the order of printing doesn’t matter).

Food Shortage
Your totalitarian dystopian society suffers a shortage of food, so many rebels appear. Extend the code from your previous task with new functionality to solve this task.
Define a class Rebel which has a name, age and group (string), names are unique - there will never be 2 Rebels/Citizens or a Rebel and Citizen with the same name. Define an interface IBuyer which defines a method BuyFood() and a integer property Food. Implement the IBuyer interface in the Citizen and Rebel class, both Rebels and Citizens start with 0 food, when a Rebel buys food his Food increases by 5, when a Citizen buys food his Food increases by 10.
On the first line of the input you will receive an integer N - the number of people, on each of the next N lines you will receive information in one of the following formats “<name> <age> <id> <birthdate>” for a Citizen or “<name> <age><group>” for a Rebel. After the N lines until the command “End” is received, you will receive names of people who bought food, each on a new line. Note that not all names may be valid, in case of an incorrect name - nothing should happen.

Military Elite
Create the following class hierarchy:
Soldier – general class for soldiers, holding id, first name and last name.
Private – lowest base soldier type, holding the field salary(double). 
LeutenantGeneral – holds a set of Privates under his command.
SpecialisedSoldier – general class for all specialised soldiers – holds the corps of the soldier. The corps can only be one of the following: Airforces or Marines.
Engineer – holds a set of repairs. A repair holds a part name and hours worked(int).
Commando – holds a set of missions. A mission holds code name and a state (inProgress or Finished). A mission can be finished through the method CompleteMission().
Spy – holds the code number of the spy (int).
Extract interfaces for each class. (e.g. ISoldier, IPrivate, ILeutenantGeneral, etc.) The interfaces should hold their public properties and methods (e.g. Isoldier should hold id, first name and last name). Each class should implement its respective interface. Validate the input where necessary (corps, mission state) - input should match exactly one of the required values, otherwise it should be treated as invalid. In case of invalid corps the entire line should be skipped, in case of an invalid mission state only the mission should be skipped. 
You will receive from the console an unknown amount of lines containing information about soldiers until the command “End” is received. The information will be in one of the following formats:
Private: “Private <id> <firstName> <lastName> <salary>”
LeutenantGeneral: “LeutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>” where privateXId will always be an Id of a private already received through the input.
Engineer: “Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>” where repairXPart is the name of a repaired part and repairXHours the hours it took to repair it (the two parameters will always come paired). 
Commando: “Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>” a missions code name, description and state will always come together.
Spy: “Spy <id> <firstName> <lastName> <codeNumber>”
Define proper constructors. Avoid code duplication through abstraction. Override ToString() in all classes to print detailed information about the object.
Privates:
Name: <firstName> <lastName> Id: <id> Salary: <salary>
Spy:
Name: <firstName> <lastName> Id: <id>
Code Number: <codeNumber>
LeutenantGeneral:
Name: <firstName> <lastName> Id: <id> Salary: <salary>
Privates:
  <private1 ToString()>
  <private2 ToString()>
  …
  <privateN ToString()>
Engineer:
Name: <firstName> <lastName> Id: <id> Salary: <salary>
Corps: <corps>
Repairs:
  <repair1 ToString()>
  <repair2 ToString()>
  …
  <repairN ToString()>
Commando:
Name: <firstName> <lastName> Id: <id> Salary: <salary>
Corps: <corps>
Missions:
  <mission1 ToString()>
  <mission2 ToString()>
  …
  <missionN ToString()>
Repair:
Part Name: <partName> Hours Worked: <hoursWorked>
Mission:
Code Name: <codeName> State: <state>
NOTE: Salary should be printed rounded to two decimal places after the separator.

