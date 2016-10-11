# TheGameOfLife
checkerboard-style grid control and app that uses it to do the life-simulation game

GraphPaperGrid is the user control that creates the checkerboard-style graphic area where squares are filled or emptied using method calls from Life2

Life2 applies GraphPaperGrid and modifies it's properties to display generations of "life" based on the following rules:

                //1.  Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                //2.  Any live cell with two or three live neighbours lives on to the next generation.
                //3.  Any live cell with more than three live neighbours dies, as if by over - population.
                //4.  Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

