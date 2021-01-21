using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5a
{
    /**
    * Name: Zhiping Yu   student number: 000822513
    * File date: 2020.12.10
    * Purpose: This class uses the Graphics objects to graphically display a liquid filling a bucket. A Trackbar control
    *          is used to adjust the flow-rate of the liquid by setting the Interval of the Timer control. The Timer control is to
    *          display the fluid filling. User can pick any color they prefer to set the color of the liquid by ColorDialog
    *        
    * I, Zhiping Yu, 000822513 certify that this material is my original work.  No other person's work has been used 
    * without due acknowledgement.
    */
    public partial class Form1 : Form
    {
        private Graphics g; // encapsulate a GUI + drawing surface
        private Pen p; // Pens are used to draw objects
        private Brush b; // Brushes are used to fill graphics shapes
        private Color c = Color.White; // represents a color initially set to white

        private int count; // the number of timer ticks
        private List<int> pointers = new List<int>(); // list is used to store all the track bar values which scrolled to

        /// <summary>
        /// The constructor  for the form registers the event handler that automatically repaints the screen
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint); // register the Paint event handler
            pointers.Add(0); // add default track bar value 0 to the list
        }
        /// <summary>
        /// Click the Color button opens the Color Dialog box that user can use to pick a new color to draw with
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorBtn_Click(object sender, EventArgs e)
        {
            
            cdlColorChooser.Color = c;    // display with the previous color
            cdlColorChooser.ShowDialog(); // user can choose new color
            c = cdlColorChooser.Color;    // new color picked
            
        }

        /// <summary>
        /// Initialize the Graphics, Pen, Brush and use these objects to draw a fluid bucket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics; // Get the Graphics object from the PaintEventArgs
            p = new Pen(c); // create a new Pen using the current color
            b = new SolidBrush(c); // create a new brush using the current color

            // draw the bucket
            g.DrawLine(p, 110, 300, 110, 450);
            g.DrawLine(p, 110, 450, 350, 450);
            g.DrawLine(p, 350, 450, 350,300);

        }

        // Click the Close button to xit the program
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///  Each time the timer ticks, a new rectangle is drawn which means fluid is filled in the bucket. After the fluid reachs a
        ///  fixed point, the fluid stops running and everything is reset. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {

            count++;
            g = this.CreateGraphics();

            // draw the fluid in the bucket, the position is based on the number of timer ticks. The fulid is drawn from bottom to the top and the height
            // of each rectange which means fluid lever is 3. 
            
            g.FillRectangle(b, 111, 450 - count * 3, 239, 3);

            // when the timer ticks 45 times, the fluid stops running and timer stops ticking, everything reset.
            if (count == 45)
            {
                timer.Enabled = false;
                trackBar.Value = 0;
                Brush b1 = new SolidBrush(Color.Black); 
                // fluid stops running
                g.FillRectangle(b1, 125, 245, 16, (315-245));
                // count is set to 0 
                count = 0;
                //clear the existing elements, and add the 0 to the list
                pointers.Clear();
                pointers.Add(trackBar.Value);

            }

        }

        /// <summary>
        /// when user adjusts the track bar, the value will change and the speed of fluid running will change too. Every time,
        /// when the bucket has filled with fluid to some extent, the fluid will stop running. If the user wants to add more fluid
        /// ,the bucket must be clear first then add fluid. Certainly, user can adjust the speed of fluid running at any point
        /// as long as the bucket has not reached the fixed point. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            g = this.CreateGraphics(); // create a graphics object

            pointers.Add(trackBar.Value); // add the value user scrolled to the list

            // when the previous value in the list is 0 and the bucket is empty or reach the final point
            if (pointers[pointers.Count - 2] == 0 && count == 0) 
            {
                // when the current value is 0, stop the timer and fluid stops running
                if (trackBar.Value == 0)
                {
                    timer.Enabled = false;
                }
                else  // when the current value is not 0, empty the bucket first and then start to fill in again
                {

                    g.FillRectangle(new SolidBrush(Color.Black), 111, 315, 239, 135); // empty the bucket
                    SetAllInterval(g); // refill the bucket
                }

            }

            // when the previous value in the list is not 0 or the bucket is not empty or reach the final point
            else
            {
                // when the current value is 0, stop the timer and fluid stops running
                if (trackBar.Value == 0) 
                {
                    timer.Enabled = false;
                }
                else
                { // if the current value is not 0, start the timer again and fill the bucket on the previous level
                    SetAllInterval(g); // continue filling the bucket

                }

            }
        }
        
        /// <summary>
        /// Set up the fluid running speed based on the value in the track bar. The value is in ascending order from
        /// 0 to 10 and it goes from left to right. When the value is bigger, the speed increases. 
        /// </summary>
        /// <param name="g"></param>
        private void SetAllInterval(Graphics g)
        {
            timer.Enabled = true;

            // the distance between faucet and fluid surface will decrease following the fluid increasing
            g.FillRectangle(b, 125, 245, 16, (450-count*3)-245);  

            if (trackBar.Value == 10)
            {
                timer.Interval = 50;
            }
            else if (trackBar.Value == 9)
            {
                timer.Interval = 100;
            }
            else if (trackBar.Value == 8)
            {
                timer.Interval = 200;
            }
            else if (trackBar.Value == 7)
            {
                timer.Interval = 300;
            }
            else if (trackBar.Value == 6)
            {
                timer.Interval = 400;
            }
            else if (trackBar.Value == 5)
            {
                timer.Interval = 500;
            }
            else if (trackBar.Value == 4)
            {
                timer.Interval = 600;
            }
            else if (trackBar.Value == 3)
            {
                timer.Interval = 700;
            }
            else if (trackBar.Value == 2)
            {
                timer.Interval = 800;
            }
            else
            {
                timer.Interval = 1000;
            }
        }
    }
}
