using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cubehelix
{
    public partial class Form1 : Form
    {
        Cubehelix helix = new Cubehelix();
        int innerPicBoxPadding = 10;
        int oldFormWidth, oldFormHeight, spectrumHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setNUDValues();
            setFormVariables();
        }

        private void setNUDValues()
        {
            hueNUD.Value = (decimal)helix.Hue;
            gammaNUD.Value = (decimal)helix.Gamma;
            rotationsNUD.Value = (decimal)helix.Rotations;
            startingColorNUD.Value = (decimal)helix.Start;
        }

        private void setFormVariables()
        {
            oldFormWidth = this.ClientSize.Width;
            oldFormHeight = this.ClientSize.Height;
            spectrumHeight = (pictureBox.Height - 3 * innerPicBoxPadding) / 5;
        }

        private void hueNUD_ValueChanged(object sender, EventArgs e)
        {
            helix.Hue = (double)hueNUD.Value;
            Refresh();
        }

        private void gammaNUD_ValueChanged(object sender, EventArgs e)
        {
            helix.Gamma = (double)gammaNUD.Value;
            Refresh();
        }

        private void rotationsNUD_ValueChanged(object sender, EventArgs e)
        {
            helix.Rotations = (double)rotationsNUD.Value;
            Refresh();
        }

        private void startingColorNUD_ValueChanged(object sender, EventArgs e)
        {
            helix.Start = (double)startingColorNUD.Value;
            Refresh();
        }


        /// <summary>
        /// Does linear interpolation between two ranges
        /// </summary>
        /// <param name="x">The value in the first range</param>
        /// <param name="x0">The lowest value in the first range</param>
        /// <param name="x1">The highest value in the second range</param>
        /// <param name="y0">The lowest value in the second range</param>
        /// <param name="y1">The highest value in the second range</param>
        /// <returns>The value adjusted to the second range</returns>
        private static double interpolate(double x, double x0, double x1, double y0, double y1)
        {
            if ((x1 - x0) == 0)
            {
                return (y0 + y1) / 2;
            }
            return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;

            drawSpectrum(graphicsObj);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.ClientSize.Width != 0 && this.ClientSize.Height != 0 && this.IsHandleCreated)
            {
                int dx = this.ClientSize.Width - oldFormWidth;
                int dy = this.ClientSize.Height - oldFormHeight;
                oldFormHeight = this.ClientSize.Height;
                oldFormWidth = this.ClientSize.Width;
                numberPanel.Location =
                    new Point(numberPanel.Location.X, numberPanel.Location.Y + dy);
                pictureBox.Width += dx;
                pictureBox.Height += dy;
                Refresh();
            }
        }

        private void drawSpectrum(Graphics graphicsObj)
        {
            graphicsObj.Clear(Color.White);
            graphicsObj.DrawRectangle(Pens.Brown, innerPicBoxPadding, innerPicBoxPadding,
                pictureBox.Width - 2 * innerPicBoxPadding, spectrumHeight);
            //int spectrumWidth = pictureBox.Width - 2 * innerPicBoxPadding;
            //for (int i = 0; i < pictureBox.Width - 2 * innerPicBoxPadding; i++)
            //{
            //    graphicsObj.DrawLine(
            //        new Pen(
            //            new SolidBrush(helix.getAtPoint(interpolate(i, 0, spectrumWidth, 0, 1))), 1),
            //            innerPicBoxPadding + i, innerPicBoxPadding, innerPicBoxPadding + i, innerPicBoxPadding + spectrumHeight);
            //}

        }

        private void drawPlot(Graphics graphicsObj)
        {

        }
    }
}
