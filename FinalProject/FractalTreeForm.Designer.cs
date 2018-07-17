namespace FinalProject
{
    partial class FractalTreeForm
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
            this.treePictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.angleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.iterationsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // treePictureBox
            // 
            this.treePictureBox.Location = new System.Drawing.Point(2, 4);
            this.treePictureBox.Name = "treePictureBox";
            this.treePictureBox.Size = new System.Drawing.Size(1300, 650);
            this.treePictureBox.TabIndex = 0;
            this.treePictureBox.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawButton.Location = new System.Drawing.Point(12, 665);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(389, 38);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw Tree";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // angleNumericUpDown
            // 
            this.angleNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleNumericUpDown.Location = new System.Drawing.Point(789, 672);
            this.angleNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.angleNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.angleNumericUpDown.Name = "angleNumericUpDown";
            this.angleNumericUpDown.Size = new System.Drawing.Size(37, 26);
            this.angleNumericUpDown.TabIndex = 2;
            this.angleNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // iterationsNumericUpDown
            // 
            this.iterationsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsNumericUpDown.Location = new System.Drawing.Point(1147, 672);
            this.iterationsNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.iterationsNumericUpDown.Name = "iterationsNumericUpDown";
            this.iterationsNumericUpDown.Size = new System.Drawing.Size(42, 26);
            this.iterationsNumericUpDown.TabIndex = 3;
            this.iterationsNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 674);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Angle of branching (degrees):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(985, 674);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of iterations:";
            // 
            // FractalTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iterationsNumericUpDown);
            this.Controls.Add(this.angleNumericUpDown);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.treePictureBox);
            this.Name = "FractalTreeForm";
            this.Text = "Fractal Tree Generator";
            ((System.ComponentModel.ISupportInitialize)(this.treePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox treePictureBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.NumericUpDown angleNumericUpDown;
        private System.Windows.Forms.NumericUpDown iterationsNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

