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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hueLabel = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.rotationsLabel = new System.Windows.Forms.Label();
            this.startColorLabel = new System.Windows.Forms.Label();
            this.hueNUD = new System.Windows.Forms.NumericUpDown();
            this.gammaNUD = new System.Windows.Forms.NumericUpDown();
            this.startingColorNUD = new System.Windows.Forms.NumericUpDown();
            this.rotationsNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingColorNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 483);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(13, 502);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(87, 17);
            this.hueLabel.TabIndex = 1;
            this.hueLabel.Text = "Starting Hue";
            // 
            // gammaLabel
            // 
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Location = new System.Drawing.Point(13, 530);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(57, 17);
            this.gammaLabel.TabIndex = 3;
            this.gammaLabel.Text = "Gamma";
            // 
            // rotationsLabel
            // 
            this.rotationsLabel.AutoSize = true;
            this.rotationsLabel.Location = new System.Drawing.Point(211, 502);
            this.rotationsLabel.Name = "rotationsLabel";
            this.rotationsLabel.Size = new System.Drawing.Size(68, 17);
            this.rotationsLabel.TabIndex = 5;
            this.rotationsLabel.Text = "Rotations";
            // 
            // startColorLabel
            // 
            this.startColorLabel.AutoSize = true;
            this.startColorLabel.Location = new System.Drawing.Point(211, 530);
            this.startColorLabel.Name = "startColorLabel";
            this.startColorLabel.Size = new System.Drawing.Size(94, 17);
            this.startColorLabel.TabIndex = 7;
            this.startColorLabel.Text = "Starting Color";
            // 
            // hueNUD
            // 
            this.hueNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.hueNUD.Location = new System.Drawing.Point(106, 502);
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
            this.gammaNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNUD.Location = new System.Drawing.Point(106, 530);
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
            this.startingColorNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.startingColorNUD.Location = new System.Drawing.Point(311, 530);
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
            this.rotationsNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.rotationsNUD.Location = new System.Drawing.Point(311, 500);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 559);
            this.Controls.Add(this.rotationsNUD);
            this.Controls.Add(this.startingColorNUD);
            this.Controls.Add(this.gammaNUD);
            this.Controls.Add(this.hueNUD);
            this.Controls.Add(this.startColorLabel);
            this.Controls.Add(this.rotationsLabel);
            this.Controls.Add(this.gammaLabel);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingColorNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label rotationsLabel;
        private System.Windows.Forms.Label startColorLabel;
        private System.Windows.Forms.NumericUpDown hueNUD;
        private System.Windows.Forms.NumericUpDown gammaNUD;
        private System.Windows.Forms.NumericUpDown startingColorNUD;
        private System.Windows.Forms.NumericUpDown rotationsNUD;
    }
}

