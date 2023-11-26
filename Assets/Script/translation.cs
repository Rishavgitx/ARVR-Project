using System;
using System.Drawing;
using System.Windows.Forms;

namespace TranslationExample
{
    public partial class MainForm : Form
    {
        private int translationX = 0;
        private int translationY = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Create a Graphics object
            Graphics g = e.Graphics;

            // Set the translation values
            int translateX = translationX;
            int translateY = translationY;

            // Create a translation matrix
            Matrix translationMatrix = new Matrix();
            translationMatrix.Translate(translateX, translateY);

            // Apply the translation to the Graphics object
            g.Transform = translationMatrix;

            // Draw a rectangle (or any object/image) - this will be translated
            g.DrawRectangle(Pens.Black, 50, 50, 100, 100);

            // Reset the Graphics object's transformation matrix
            g.ResetTransform();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the translation values and refresh the form
            translationX += 5;
            translationY += 5;

            Invalidate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer1.Start();
        }
    }
}