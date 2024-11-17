using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapeForm
{
    public partial class Form1 : Form
    {
        private Shape[] shapes = new Shape[100]; // Initial array size

        public Form1()
        {
            InitializeComponent();

            // Randomly generate initial shapes (if needed)
            Random random = new Random();
            for (int i = 0; i < shapes.Length; i++)
            {
                if (random.Next(2) == 0)
                {
                    shapes[i] = new Circle(random.Next(20, 320), random.Next(20, 320), random.Next(10, 50));
                }
                else
                {
                    shapes[i] = new Rectangle(random.Next(20, 320), random.Next(20, 320), random.Next(20, 100), random.Next(20, 100));
                }
            }

            // Attach paint event
            this.Paint += Form1_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional load logic
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var shape in shapes)
            {
                shape?.Draw(g);
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Parse the number of shapes from the textbox
            int numberOfShapes;
            if (int.TryParse(textBox.Text, out numberOfShapes) && numberOfShapes > 0 && numberOfShapes <= 100)
            {
                Random random = new Random();
                shapes = new Shape[numberOfShapes]; // Adjust the array size

                // Populate the shapes array
                for (int i = 0; i < numberOfShapes; i++)
                {
                    if (random.Next(2) == 0)
                    {
                        shapes[i] = new Circle(random.Next(20, 300), random.Next(20, 300), random.Next(20, 50));
                    }
                    else
                    {
                        shapes[i] = new Rectangle(random.Next(20, 300), random.Next(20, 300), random.Next(40, 100), random.Next(40, 100));
                    }
                }

                // Trigger a repaint to draw the new shapes
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a number between 1 and 100.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // Example logic for handling text change (you can customize this)
            int numberOfShapes;
            Submit.Enabled = int.TryParse(textBox.Text, out numberOfShapes) && numberOfShapes > 0 && numberOfShapes <= 100;
        }
    }

    // Define the Shape interface
    public interface Shape
    {
        void Draw(Graphics g);
    }

    // Circle class implementing the Shape interface
    public class Circle : Shape
    {
        private int X, Y, Radius;

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Black, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }
    }

    // Rectangle class implementing the Shape interface
    public class Rectangle : Shape
    {
        private int X, Y, Width, Height;

        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }
    }
}
