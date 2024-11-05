namespace DIP_Activity
{
    partial class Form2
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
            label1 = new Label();
            Load_Image = new Button();
            Load_Background = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            Substract = new Button();
            Save = new Button();
            saveFileDialog1 = new SaveFileDialog();
            On_Webcam = new Button();
            Off_Webcam = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 148);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // Load_Image
            // 
            Load_Image.BackColor = SystemColors.GradientInactiveCaption;
            Load_Image.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Load_Image.Location = new Point(79, 45);
            Load_Image.Name = "Load_Image";
            Load_Image.Size = new Size(153, 35);
            Load_Image.TabIndex = 1;
            Load_Image.Text = "Load Image";
            Load_Image.UseVisualStyleBackColor = false;
            Load_Image.Click += Open_Click;
            // 
            // Load_Background
            // 
            Load_Background.BackColor = SystemColors.GradientInactiveCaption;
            Load_Background.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Load_Background.Location = new Point(365, 45);
            Load_Background.Name = "Load_Background";
            Load_Background.Size = new Size(200, 35);
            Load_Background.TabIndex = 2;
            Load_Background.Text = "Load Background";
            Load_Background.UseVisualStyleBackColor = false;
            Load_Background.Click += Load_Background_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(321, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 250);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(738, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(289, 250);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // Substract
            // 
            Substract.BackColor = SystemColors.Info;
            Substract.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Substract.Location = new Point(615, 184);
            Substract.Name = "Substract";
            Substract.Size = new Size(118, 51);
            Substract.TabIndex = 6;
            Substract.Text = "Substract";
            Substract.UseVisualStyleBackColor = false;
            Substract.Click += Substract_Click;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.GradientInactiveCaption;
            Save.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.Location = new Point(926, 12);
            Save.Name = "Save";
            Save.Size = new Size(101, 35);
            Save.TabIndex = 7;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // On_Webcam
            // 
            On_Webcam.BackColor = SystemColors.GradientInactiveCaption;
            On_Webcam.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            On_Webcam.Location = new Point(737, 388);
            On_Webcam.Name = "On_Webcam";
            On_Webcam.Size = new Size(139, 35);
            On_Webcam.TabIndex = 8;
            On_Webcam.Text = "On WebCam";
            On_Webcam.UseVisualStyleBackColor = false;
            On_Webcam.Click += On_Webcam_Click;
            // 
            // Off_Webcam
            // 
            Off_Webcam.BackColor = SystemColors.GradientInactiveCaption;
            Off_Webcam.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Off_Webcam.Location = new Point(882, 388);
            Off_Webcam.Name = "Off_Webcam";
            Off_Webcam.Size = new Size(146, 35);
            Off_Webcam.TabIndex = 9;
            Off_Webcam.Text = "Off WebCam";
            Off_Webcam.UseVisualStyleBackColor = false;
            Off_Webcam.Click += Off_Webcam_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 450);
            Controls.Add(Off_Webcam);
            Controls.Add(On_Webcam);
            Controls.Add(Save);
            Controls.Add(Substract);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Load_Background);
            Controls.Add(Load_Image);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Load_Image;
        private Button Load_Background;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button Substract;
        private Button Save;
        private SaveFileDialog saveFileDialog1;
        private Button On_Webcam;
        private Button Off_Webcam;
    }
}