namespace DIP_Activity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Open = new Button();
            Save = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Picture_Copy = new Button();
            Greyscaling = new Button();
            Inversion = new Button();
            Histogram = new Button();
            Sepia = new Button();
            Image_Substraction = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Open
            // 
            Open.BackColor = SystemColors.GradientInactiveCaption;
            Open.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Open.Location = new Point(24, 17);
            Open.Name = "Open";
            Open.Size = new Size(101, 35);
            Open.TabIndex = 0;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = false;
            Open.Click += Open_Click;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.GradientInactiveCaption;
            Save.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.Location = new Point(131, 17);
            Save.Name = "Save";
            Save.Size = new Size(101, 35);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(24, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(558, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(368, 344);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Picture_Copy
            // 
            Picture_Copy.BackColor = SystemColors.ScrollBar;
            Picture_Copy.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Picture_Copy.Location = new Point(402, 111);
            Picture_Copy.Name = "Picture_Copy";
            Picture_Copy.Size = new Size(146, 35);
            Picture_Copy.TabIndex = 4;
            Picture_Copy.Text = "Picture Copy";
            Picture_Copy.UseVisualStyleBackColor = false;
            Picture_Copy.Click += Picture_Copy_Click;
            // 
            // Greyscaling
            // 
            Greyscaling.BackColor = SystemColors.ScrollBar;
            Greyscaling.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Greyscaling.Location = new Point(402, 152);
            Greyscaling.Name = "Greyscaling";
            Greyscaling.Size = new Size(146, 35);
            Greyscaling.TabIndex = 5;
            Greyscaling.Text = "Greyscaling";
            Greyscaling.UseVisualStyleBackColor = false;
            Greyscaling.Click += Greyscaling_Click;
            // 
            // Inversion
            // 
            Inversion.BackColor = SystemColors.ScrollBar;
            Inversion.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Inversion.Location = new Point(402, 193);
            Inversion.Name = "Inversion";
            Inversion.Size = new Size(146, 35);
            Inversion.TabIndex = 6;
            Inversion.Text = "Inversion";
            Inversion.UseVisualStyleBackColor = false;
            Inversion.Click += Inversion_Click;
            // 
            // Histogram
            // 
            Histogram.BackColor = SystemColors.ScrollBar;
            Histogram.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Histogram.Location = new Point(402, 234);
            Histogram.Name = "Histogram";
            Histogram.Size = new Size(146, 35);
            Histogram.TabIndex = 7;
            Histogram.Text = "Histogram";
            Histogram.UseVisualStyleBackColor = false;
            Histogram.Click += Histogram_Click;
            // 
            // Sepia
            // 
            Sepia.BackColor = SystemColors.ScrollBar;
            Sepia.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sepia.Location = new Point(402, 275);
            Sepia.Name = "Sepia";
            Sepia.Size = new Size(146, 35);
            Sepia.TabIndex = 8;
            Sepia.Text = "Sepia";
            Sepia.UseVisualStyleBackColor = false;
            Sepia.Click += Sepia_Click;
            // 
            // Image_Substraction
            // 
            Image_Substraction.BackColor = SystemColors.GradientInactiveCaption;
            Image_Substraction.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Image_Substraction.Location = new Point(707, 17);
            Image_Substraction.Name = "Image_Substraction";
            Image_Substraction.Size = new Size(219, 35);
            Image_Substraction.TabIndex = 9;
            Image_Substraction.Text = "Image Substraction";
            Image_Substraction.UseVisualStyleBackColor = false;
            Image_Substraction.Click += Image_Substraction_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 428);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 10;
            label1.Text = "Loaded Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(666, 428);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 11;
            label2.Text = "Processed Image";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Image_Substraction);
            Controls.Add(Sepia);
            Controls.Add(Histogram);
            Controls.Add(Inversion);
            Controls.Add(Greyscaling);
            Controls.Add(Picture_Copy);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Save);
            Controls.Add(Open);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Open;
        private Button Save;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button Picture_Copy;
        private Button Greyscaling;
        private Button Inversion;
        private Button Histogram;
        private Button Sepia;
        private Button Image_Substraction;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
