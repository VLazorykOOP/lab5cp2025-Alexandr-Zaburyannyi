using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace KochFractal
{
    public partial class MainForm : Form
    {
        private int squareSide = 300;
        private int fractalOrder = 3;
        private Bitmap canvas;
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
            
            this.Size = new Size(800, 700);
            canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(canvas);
            
            DrawFractal();
        }

        private void DrawFractal()
        {
            graphics.Clear(Color.White);

            int centerX = pictureBox.Width / 2;
            int centerY = pictureBox.Height / 2;
            int startX = centerX - squareSide / 2;
            int startY = centerY - squareSide / 2;

            Point p1 = new Point(startX, startY);
            Point p2 = new Point(startX + squareSide, startY);
            Point p3 = new Point(startX + squareSide, startY + squareSide);
            Point p4 = new Point(startX, startY + squareSide);

            DrawKochLine(p1, p2, fractalOrder);
            DrawKochLine(p2, p3, fractalOrder);
            DrawKochLine(p3, p4, fractalOrder);
            DrawKochLine(p4, p1, fractalOrder);

            pictureBox.Image = canvas;
        }

        private void DrawKochLine(Point start, Point end, int depth)
        {
            if (depth == 0)
            {
                graphics.DrawLine(Pens.Blue, start, end);
            }
            else
            {
                List<Point> points = CalculateKochPoints(start, end);
                
                DrawKochLine(points[0], points[1], depth - 1);
                DrawKochLine(points[1], points[2], depth - 1);
                DrawKochLine(points[2], points[3], depth - 1);
                DrawKochLine(points[3], points[4], depth - 1);
            }
        }

        private List<Point> CalculateKochPoints(Point start, Point end)
        {
            List<Point> points = new List<Point>();
            
            points.Add(start);
            
            double deltaX = end.X - start.X;
            double deltaY = end.Y - start.Y;
            
            Point oneThird = new Point(
                start.X + (int)(deltaX / 3),
                start.Y + (int)(deltaY / 3)
            );
            
            Point twoThird = new Point(
                start.X + (int)(2 * deltaX / 3),
                start.Y + (int)(2 * deltaY / 3)
            );
            
            double perpX = -deltaY / Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            double perpY = deltaX / Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            
            double height = Math.Sqrt(3) / 6 * Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            
            Point peak = new Point(
                (int)((oneThird.X + twoThird.X) / 2 + perpX * height),
                (int)((oneThird.Y + twoThird.Y) / 2 + perpY * height)
            );
            
            points.Add(oneThird);
            points.Add(peak);
            points.Add(twoThird);
            points.Add(end);
            
            return points;
        }

        private void btnGenerateFractal_Click(object sender, EventArgs e)
        {
            try
            {
                squareSide = int.Parse(txtSideLength.Text);
                fractalOrder = int.Parse(txtFractalOrder.Text);
                
                if (squareSide <= 0)
                {
                    MessageBox.Show("Side length must be positive.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (fractalOrder < 0)
                {
                    MessageBox.Show("Fractal order must be non-negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                DrawFractal();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
