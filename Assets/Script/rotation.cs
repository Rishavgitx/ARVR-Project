using System;
using System.Drawing;
using System.Windows.Forms;

namespace RotationExample
{
    public partial class MainForm : Form
    {
        private float rotationAngle = 0f;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object
            Graphics g = e.Graphics;

            // Set the rotation angle in degrees
            float angleInDegrees = rotationAngle;

            // Convert the angle to radians
            float angleInRadians = (float)(angleInDegrees * Math.PI / 180);

            // Set the rotation point (center of the form in this case)
            float centerX = ClientSize.Width / 2f;
            float centerY = ClientSize.Height / 2f;

            // Create a rotation matrix
            Matrix rotationMatrix = new Matrix();
            rotationMatrix.RotateAt(angleInDegrees, new PointF(centerX, centerY));

            // Apply the rotation to the Graphics object
            g.Transform = rotationMatrix;

            // Draw a rectangle (or any object/image) - this will be rotated
            g.DrawRectangle(Pens.Black, centerX - 50, centerY - 50, 100, 100);

            // Reset the Graphics object's transformation matrix
            g.ResetTransform();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the rotation angle and refresh the form
            rotationAngle += 5f;
            if (rotationAngle >= 360f)
            {
                rotationAngle -= 360f;
            }

            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer1.Start();
        }
    }
}