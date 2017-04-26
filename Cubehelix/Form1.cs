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
        int oldFormWidth;
        int oldFormHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hueNUD.Value = (decimal)helix.Hue;
            gammaNUD.Value = (decimal)helix.Gamma;
            rotationsNUD.Value = (decimal)helix.Rotations;
            startingColorNUD.Value = (decimal)helix.Start;
            oldFormWidth = this.ClientSize.Width;
            oldFormHeight = this.ClientSize.Height;
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
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.IsHandleCreated)
            {
                int dx = this.ClientSize.Width - oldFormWidth;
                int dy = this.ClientSize.Height - oldFormHeight;
                oldFormHeight = this.ClientSize.Height;
                oldFormWidth = this.ClientSize.Width;
                numberPanel.Location = 
                    new Point(numberPanel.Location.X, numberPanel.Location.Y + dy);
                pictureBox1.Width += dx;
                pictureBox1.Height += dy;
            }
        }
    }
}
