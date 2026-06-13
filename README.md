# TheGameOfLife -- This is not the Milton Bradly game.  It is a simulation that creates a pattern.

Creating this was really fun!

checkerboard-style grid control and app that uses it to do the life-simulation game

GraphPaperGrid is the user control that creates the checkerboard-style graphic area where squares are filled or emptied using method calls from Life2

Life2 applies GraphPaperGrid and modifies it's properties to display generations of "life" based on the following rules:

                //1.  Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                //2.  Any live cell with two or three live neighbours lives on to the next generation.
                //3.  Any live cell with more than three live neighbours dies, as if by over - population.
                //4.  Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

Conway's "Game of Life," invented by mathematician John Conway in 1970, is a "zero-player game" played on an infinite 2D grid of square cells. Its evolution is driven entirely by its initial setup, following just a few mathematical rules. 

The game was famously popularized by Martin Gardner's "Mathematical Games" column in the October 1970 issue of Scientific American. It was originally played using physical tokens (like checkers or Go counters) on graph paper, though it rapidly became a staple of early computer science once digital displays became accessible. 

The original Life universe functions on an infinite grid of square cells that can either be "alive" or "dead". Every cell interacts with its eight horizontal, vertical, and diagonal neighbors. At each time step (or generation), the following rules apply simultaneously to every cell: 

Underpopulation: Any live cell with fewer than two live neighbors dies.
Overpopulation: Any live cell with more than three live neighbors dies.
Survival: Any live cell with exactly two or three live neighbors lives on to the next generation.
Birth: Any dead cell with exactly three live neighbors comes to life. 

ConwayLife.com
Depending on the chosen starting arrangement, the grid might completely die out, settle into a stationary or oscillating pattern, or create mobile patterns (like "gliders") that travel across the board. 
For a closer look at the stunning, emergent visual patterns that these simple rules can generate:

https://www.youtube.com/shorts/OTWSgHc-2Ho
