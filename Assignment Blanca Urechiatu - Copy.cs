// I deleted all the "using" something that were not used in this program
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AssignmentBlanca
{
    public partial class Form1 : Form
    {   // Declaring 6 questions that will be used  
        Random sentence = new Random(); 
        string[] a = {"It is very cold today. You should dress accordingly!", // a[0]
             "It is rather cold today. Take a warm jacket!", // a[1]
             "It is a bit cold today. Don't forget your scarf!", // a[2]
             "It is going to be warm today.", // a[3]
             "Is is going to be rather warm today.", // a[4]
             "It is very warm today. Take your water with you!" }; /* Initialization in the declaration
                                                                  and this is a[5] */
        // End of declaring the questions
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Clicking button 1
        {
            //Drawing graphics
            Graphics paper;
            paper = pictureBox1.CreateGraphics(); /* The paper on which the drawing will appear
                                                     is pictureBox1 from the form */
            Pen pen = new Pen(Color.DarkBlue); // Use a pen to draw and choose the colour as being dark blue
            paper.DrawRectangle(pen, 10, 140, 100, 20); // Draw the Rectangle on the paper
            SolidBrush brush = new SolidBrush(Color.DarkBlue); // Add an object to a class
            paper.FillRectangle(brush, 10, 140, 100, 20); // Give a colour inside the rectangle
            pen = new Pen(Color.Blue);
            paper.DrawRectangle(pen, 10, 120, 100, 20);
            brush = new SolidBrush(Color.Blue);
            paper.FillRectangle(brush, 10, 120, 100, 20);
            pen = new Pen(Color.LightBlue);
            paper.DrawRectangle(pen, 10, 100, 100, 20);
            brush = new SolidBrush(Color.LightBlue);
            paper.FillRectangle(brush, 10, 100, 100, 20);
            pen = new Pen(Color.Yellow);
            paper.DrawRectangle(pen, 10, 80, 100, 20);
            brush = new SolidBrush(Color.Yellow);
            paper.FillRectangle(brush, 10, 80, 100, 20);
            pen = new Pen(Color.Orange);
            paper.DrawRectangle(pen, 10, 60, 100, 20);
            brush = new SolidBrush(Color.Orange);
            paper.FillRectangle(brush, 10, 60, 100, 20);
            pen = new Pen(Color.Red);
            paper.DrawRectangle(pen, 10, 40, 100, 20);
            brush = new SolidBrush(Color.Red);
            paper.FillRectangle(brush, 10, 40, 100, 20);
            // End drawing graphics
            // Showing the temperature on the thermometer
            double temp; // Initialization of temp as a double
            temp = Convert.ToDouble(textBox1.Text); // Converting the text into a double value
            if (temp % 1 != 0) // Verify if the number is an integer
            {
                MessageBox.Show("The temperature you introduced is not valid because it is not an integer");
            }
            else /* So the first "if" condition: temp%1!=0 will apply to all the other "if" conditions
                    between the brackets */
            {
                if (temp >= -20 && temp <= -10) /* Considering only the temperatures between -20 and -10, 
                                                   inclusing these values */
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 140, 100, 20); /* Show a white line of the rectangle
                                                                 where the temperature is */
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 150, 100, 2); /* A rectangle will be shown in the middle of 
                                                                  the rectangle where the temperature is */
                    MessageBox.Show(a[sentence.Next(0, 3)]); // Gets random string from array between 0 and 2
                }
                else if (temp > -10 && temp <= 0) /* Use "else if" so the checking will stop when
                                                     it'll find the right value */
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 120, 100, 20);
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 130, 100, 2);
                    MessageBox.Show(a[sentence.Next(0, 3)]);
                }
                else if (temp > 0 && temp <= 10)
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 100, 100, 20);
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 110, 100, 2);
                    MessageBox.Show(a[sentence.Next(0, 3)]);
                }
                else if (temp > 10 && temp <= 20)
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 80, 100, 20);
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 90, 100, 2);
                    MessageBox.Show(a[sentence.Next(3, 6)]); // Gets random string from array between 3 and 5
                }
                else if (temp > 20 && temp <= 30)
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 60, 100, 20);
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 70, 100, 2);
                    MessageBox.Show(a[sentence.Next(3, 6)]);
                }
                else if (temp > 30 && temp <= 40)
                {
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 40, 100, 20);
                    pen = new Pen(Color.White);
                    paper.DrawRectangle(pen, 10, 50, 100, 2);
                    MessageBox.Show(a[sentence.Next(3, 6)]);
                }
                else if (temp < -20 || temp > 40) /*Check if the temperature is smaller than -20 OR it is bigger
                                                    than 40 because if it is, the value is not valid*/
                {
                    MessageBox.Show("The temperature you introduced is not valid");
                }
            }
            // End showing the temperature on the thermometer
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            int temp;
            double tempf = 0.00; /* Initialization tempf as a double because in the formula we use real numbers,
                                    not only integer */
            temp = Convert.ToInt32(textBox1.Text); // Convert the text into a number
            tempf = temp * 1.8 + 32; // Formula to convert the temperature from Celsius to Fahrenheit
            MessageBox.Show("The temperature in Fahreinheit is " + tempf); // A messagebox will show this message
        }
    }
}
