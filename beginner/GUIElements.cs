﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace cam_aforge1
{
    class GUIElements
    {
        //Important Variables: 
        //DO NOT CHANGE UNLESS YOU KNOW WHAT YOU'RE DOING
        GUI gui;
        public Graphics g;

        public int xmax = 100;
        public int ymax = 100;
        

        //This is where you can declare variables that you will be changing as the Run()
        //method executes.

        //Step 0: To try out the sample code, uncomment all the variables from line 21-27
        int circleX1 = 50;
        int circleY1 = 50;
        int squareX1 = 0;
        int squareY1 = 0;
        int speed = 5;
        bool cirDir = true;
        bool sqrDir = true;

        int counter = 0;
        int xval = 0;
        int yval = 0;

        bool isclicked = false;
        bool isMouseDown = false;
        List<Circle> dots = new List<Circle>();

        //End Variable declaration.

        //Main constructor of this class
        public GUIElements(GUI _gui)
        {
            this.gui = _gui;
        }
        
        //This function runs every frame
        public void Run()
        {
            if (isclicked)
            {
                Circle cir2 = new Circle(Color.Blue, 1, xval, yval, 2);
                cir2.isFill = true;
                dots.Add(cir2);
                for (int i = 0; i < dots.Count; i++)
                {
                    dots[i].Draw(g);
                    //cir2.Draw(g);
                }

            }
            
            //Step 1: Let's draw a basic Square. Uncomment Lines 43-45 to draw a blue square. Then, press start.
            //Square sqr = new Square(Color.Blue, 4, squareX1, squareY1, 100);
            //sqr.Draw(g);

            //Step 2: Now let's draw a filled circle. Uncomment Lines 47-50 to draw a purple
            //circle in the centre of the square we drew in step 1
            //Circle cir = new Circle(Color.Purple, 4, circleX1, circleY1, 50);
            //cir.isFill = true;
            //cir.Draw(g);

            //Step 3: It's time to animate! The following chunk of code
            //moves the circle side-to-side within the square. Uncomment lines 55-74 and comment out
            //the cir.Draw(g) in line 45.
            
            /*
            if (cir.x1 + 25 >= sqr.size || cir.x1 - 25 <= sqr.x1)
            {
                cirDir = !cirDir;
            }
            
            if (cirDir)
            {
                circleX1 = circleX1 + speed;
                cir.x1 = circleX1;
            }
            
            else
            {
                circleX1 = circleX1 - speed;
                cir.x1 = circleX1;
            }
            */
            
            //cir.Draw(g);
            

            //Step 4: Let's animate the square this time. The following chunk of code
            //moves the square up and down the screen. Uncomment lines 79-98 and comment out
            //the sqr.Draw(g) in line 44.
            
            /*
            if (sqr.y1 >= ymax || sqr.y1 < 0)
            {
                sqrDir = !sqrDir;
            }

            if (sqrDir)
            {
                squareY1 = squareY1 + speed;
                sqr.y1 = squareY1;
            }

            else
            {
                squareY1 = squareY1 - speed;
                sqr.y1 = squareY1;
            }
            */

            //sqr.Draw(g);
            

            //Step 5: Now let's try syncing the movement of the 2 primitives we created. Uncomment
            //lines 99-102 to group the 2 primitives into a single Shape. Make sure to comment out
            //the cir.Draw(); and the sqr.Draw(); in lines 73 and 97, respectively.
            
            /*
            Shape shape = new Shape();
            shape.Add(sqr);
            shape.Add(cir);
            shape.Draw(g);
            */


            //Note that the FIRST primitive added with the shape.Add method is ALWAYS the root shape.
            //This means that the succeeding primitives are always positioned with respect to the x1 and y1
            //of the first primitive added.

            //Step 6: Now let's display text on the screen. Uncomment lines 115-116.
            //Text count = new Text(g, "Count: " + counter.ToString(), Color.Red, 300, 0, 35);
            //Text count = new Text("Count: " + counter.ToString(), Color.Red, 50, 0, 10);
            //count.Draw(g);

            //Text x = new Text("x: " + xval.ToString(), Color.Red, 50, 0, 10);
            //Text y = new Text("y: " + yval.ToString(), Color.Green, 50, 15, 10);
            //x.Draw(g);
            //y.Draw(g);

            //It's time to add user interactivity. Go to the GUI.cs form designer by double clicking beginner>GUI.cs
            //on the Solution Explorer to the right of your Visual Studio window. On the Form Designer, double click the
            //Tick button to proceed to step 7

        }

        //Below is Sample Code on how to implement a button
        public void ButtonWasClicked()
        {
            //Step 8 on GUI.cs will enable this code
            //counter++;
            dots = new List<Circle>();
            isclicked = false;
        }

        public void UpdatePosition(int x, int y)
        {
            if (x <= 30)
                xval = 0;
            else if (x >= 660)
                xval = 160;
            else
                xval = (160 * (x - 30)) / (630);
            //xval = x;
            yval = (120 * y) / (470);
            //yval = y;
            isclicked = true;
            isMouseDown = true;
        }
        public void MouseIsMoving(int x, int y)
        {
            if (isMouseDown)
            {
                if (x <= 30)
                    xval = 0;
                else if (x >= 660)
                    xval = 160;
                else
                    xval = (160 * (x - 30)) / (630);
                yval = (120 * y) / (470);
            }
        }
        public void MouseReleased(int x, int y)
        {
            if (x <= 30)
                xval = 0;
            else if (x >= 660)
                xval = 160;
            else
                xval = (160 * (x - 30)) / (630);
            yval = (120 * y) / (470);
            isMouseDown = false;
        }
    }
}
