using System;

namespace Cubehelix
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.hueLabel = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.rotationsLabel = new System.Windows.Forms.Label();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.hueNUD = new System.Windows.Forms.NumericUpDown();
            this.gammaNUD = new System.Windows.Forms.NumericUpDown();
            this.startingColorNUD = new System.Windows.Forms.NumericUpDown();
            this.rotationsNUD = new System.Windows.Forms.NumericUpDown();
            this.numberPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingColorNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsNUD)).BeginInit();
            this.numberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(755, 483);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(13, 8);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(87, 17);
            this.hueLabel.TabIndex = 1;
            this.hueLabel.Text = "Starting Hue";
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(13, 36);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(57, 17);
            this.gammaLabel.TabIndex = 3;
            this.gammaLabel.Text = "Gamma";
            // 
            // rotationsLabel
            // 
            this.rotationsLabel.AutoSize = true;
            this.rotationsLabel.Location = new System.Drawing.Point(211, 8);
            this.rotationsLabel.Name = "rotationsLabel";
            this.rotationsLabel.Size = new System.Drawing.Size(68, 17);
            this.rotationsLabel.TabIndex = 5;
            this.rotationsLabel.Text = "Rotations";
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Location = new System.Drawing.Point(211, 36);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(94, 17);
            this.startColorLabel.TabIndex = 7;
            this.startColorLabel.Text = "Starting Color";
            // 
            // hueNUD
            // 
            this.hueNUD.DecimalPlaces = 2;
            this.hueNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hueNUD.Location = new System.Drawing.Point(106, 8);
            this.hueNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.hueNUD.Name = "hueNUD";
            this.hueNUD.Size = new System.Drawing.Size(99, 22);
            this.hueNUD.TabIndex = 8;
            this.hueNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hueNUD.ValueChanged += new System.EventHandler(this.hueNUD_ValueChanged);
            // 
            // gammaNUD
            // 
            this.gammaNUD.DecimalPlaces = 2;
            this.gammaNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNUD.Location = new System.Drawing.Point(106, 36);
            this.gammaNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.gammaNUD.Name = "gammaNUD";
            this.gammaNUD.Size = new System.Drawing.Size(99, 22);
            this.gammaNUD.TabIndex = 9;
            this.gammaNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gammaNUD.ValueChanged += new System.EventHandler(this.gammaNUD_ValueChanged);
            // 
            // startingColorNUD
            // 
            this.startingColorNUD.DecimalPlaces = 2;
            this.startingColorNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startingColorNUD.Location = new System.Drawing.Point(311, 36);
            this.startingColorNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.startingColorNUD.Name = "startingColorNUD";
            this.startingColorNUD.Size = new System.Drawing.Size(99, 22);
            this.startingColorNUD.TabIndex = 10;
            this.startingColorNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.startingColorNUD.ValueChanged += new System.EventHandler(this.startingColorNUD_ValueChanged);
            // 
            // rotationsNUD
            // 
            this.rotationsNUD.DecimalPlaces = 2;
            this.rotationsNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rotationsNUD.Location = new System.Drawing.Point(311, 6);
            this.rotationsNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.rotationsNUD.Name = "rotationsNUD";
            this.rotationsNUD.Size = new System.Drawing.Size(99, 22);
            this.rotationsNUD.TabIndex = 11;
            this.rotationsNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rotationsNUD.ValueChanged += new System.EventHandler(this.rotationsNUD_ValueChanged);
            // 
            // numberPanel
            // 
            this.numberPanel.Controls.Add(this.rotationsNUD);
            this.numberPanel.Controls.Add(this.startingColorNUD);
            this.numberPanel.Controls.Add(this.gammaNUD);
            this.numberPanel.Controls.Add(this.hueNUD);
            this.numberPanel.Controls.Add(this.startColorLabel);
            this.numberPanel.Controls.Add(this.rotationsLabel);
            this.numberPanel.Controls.Add(this.gammaLabel);
            this.numberPanel.Controls.Add(this.hueLabel);
            this.numberPanel.Location = new System.Drawing.Point(1, 501);
            this.numberPanel.Name = "numberPanel";
            this.numberPanel.Size = new System.Drawing.Size(588, 62);
            this.numberPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 571);
            this.Controls.Add(this.numberPanel);
            this.Controls.Add(this.pictureBox);
            this.MinimumSize = new System.Drawing.Size(797, 618);
            this.Name = "Form1";
            this.Text = "+";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingColorNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsNUD)).EndInit();
            this.numberPanel.ResumeLayout(false);
            this.numberPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label rotationsLabel;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.NumericUpDown hueNUD;
        private System.Windows.Forms.NumericUpDown gammaNUD;
        private System.Windows.Forms.NumericUpDown startingColorNUD;
        private System.Windows.Forms.NumericUpDown rotationsNUD;
        private System.Windows.Forms.Panel numberPanel;
    }
}

