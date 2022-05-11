# langtons-ant

An ant is sitting on an infinite grid of white and black squares. Initially the grid is all white and the ant faces right. 
At each step it does the following:

•At a white square, flip the color of the square, turn 90 degrees right (clockwise), and move forward one unit.

•At a black square, flip the color of the square, turn 90 degrees left (counterclockwise), and move forward one unit.

Write a program in C# to simulate the first K moves that the ant makes and print the final board as a grid.  The only input to the method is the number of moves K.