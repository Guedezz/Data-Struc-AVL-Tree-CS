# Data-Structures-CS - Can be donwloaded and runned in visual studio - all files are working
 This is a C# Application that makes use of various data structures to read and sort countries, and trade partners
 
 The aim of this project was to demonstrate the use and understanding of algorithms and data structures.
 All of the data structures have been hard coded and no generic methods were used in this project. 
 
 This projects implements: 
 1. AVL Tree
 2. Binary Tree
 3. Binary Search Tree
 4. Linked Lists
 5. Arrays
 
 
 Program main functionality:
 The goal is to be able to perform a series of interactions with the data in memory which would reduce the overhead of reading and writing in real time to a persistence source (CSV in this case) and make the process more efficient.
 
This program loads a CSV file containing information (such as Name, GDP growth,Inflation,Trade Partners and more) about countries. The program uses this file to give details about each country. More functionalities include creating a new county and adding it into the program memory and editing details. The changes can then be saved into a new csv file.
 
 Technical explanation:
 1. The program loads all the CSV  and immediately separates each piece of information on the comma delimiter and puts it into a  LinkedList.
 
 2. For each country a new Country object is created (from a Country Class) and the information is passed on from the LinkedList
 
 3. The Country object is inserted into an AVL Tree. This process repeats until all the info on the CSV has been read.
 
 4. A variety of different methods are used to interact with the information. Examples: Search function, Adding and deleting information. All of this is done by updating the info on the AVL Tree which means that it's all happening in memory. This can then be saved into a CSV once finished.
