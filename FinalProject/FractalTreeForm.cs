using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FractalTreeForm : Form
    {
        private static Bitmap treeBitmap = new Bitmap(1300, 650);
        private Pen pen = new Pen(Color.Black, 10F);
        private Graphics g = Graphics.FromImage(treeBitmap);

        private int changeInAngle = 0;

        public FractalTreeForm()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.Transparent);
            changeInAngle = (int)angleNumericUpDown.Value; //This value is constant throughout the process
            drawTree((int)iterationsNumericUpDown.Value, 90, 75F, 650, 575); //Initial length of 75, angle of 90 degrees, draws the tree trunk in the middle of the bitmap
            treePictureBox.Image = treeBitmap;
        }

        private void drawTree(int Iterations, int angleToHorizontal, float length, int x2, int y2)
        {
            if (Iterations == 0) //Ends the recursion
                return;

            Point point1 = new Point(x2, y2); //The second point in the last recursion becomes the starting point in this one
            x2 += (int) (length * Math.Cos(angleToHorizontal * Math.PI / 180)); //This finds the coordinates of the next point
            y2 -= (int) (length * Math.Sin(angleToHorizontal * Math.PI / 180));

            pen.Width = length / 15F; //Reduces branch thickness in deeper layers of the tree. 15 is an arbitrary number
            g.DrawLine(pen, point1.X, point1.Y, x2, y2);
            drawTree(Iterations - 1, angleToHorizontal - changeInAngle, length * 0.9F, x2, y2); //Creates right branch and reduces the length of the next branch
            drawTree(Iterations - 1, angleToHorizontal + changeInAngle, length * 0.9F, x2, y2); //Creates left branch and reduces the length of the next branch
        }
    }
}