namespace DIP_Activity
{
    partial class Form3
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            trackBar1 = new TrackBar();
            pictureBox2 = new PictureBox();
            resetBtn = new Button();
            saveBtn = new Button();
            menuStrip2 = new MenuStrip();
            imageProcessingToolStripMenuItem1 = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            boxBlurToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            edgeEnhanceToolStripMenuItem = new ToolStripMenuItem();
            embossToolStripMenuItem = new ToolStripMenuItem();
            laplaToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalToolStripMenuItem = new ToolStripMenuItem();
            verticalToolStripMenuItem = new ToolStripMenuItem();
            auxBtn = new Button();
            openBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            filterBtn = new Button();
            tempLbl = new Label();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(345, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 447);
            label1.Name = "label1";
            label1.Size = new Size(125, 18);
            label1.TabIndex = 2;
            label1.Text = "Original Image";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(655, 447);
            label2.Name = "label2";
            label2.Size = new Size(126, 18);
            label2.TabIndex = 3;
            label2.Text = "Filtered Image";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(245, 68);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(413, 56);
            trackBar1.TabIndex = 4;
            trackBar1.Visible = false;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(545, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(345, 298);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = SystemColors.GradientActiveCaption;
            resetBtn.Enabled = false;
            resetBtn.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetBtn.Location = new Point(696, 32);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 36);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlLight;
            saveBtn.Enabled = false;
            saveBtn.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.Location = new Point(796, 31);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 37);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { imageProcessingToolStripMenuItem1 });
            menuStrip2.Location = new Point(0, 24);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(912, 28);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // imageProcessingToolStripMenuItem1
            // 
            imageProcessingToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sharpenToolStripMenuItem, boxBlurToolStripMenuItem, gaussianBlurToolStripMenuItem, edgeEnhanceToolStripMenuItem, embossToolStripMenuItem });
            imageProcessingToolStripMenuItem1.Name = "imageProcessingToolStripMenuItem1";
            imageProcessingToolStripMenuItem1.Size = new Size(139, 24);
            imageProcessingToolStripMenuItem1.Text = "Image Processing";
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(224, 26);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // boxBlurToolStripMenuItem
            // 
            boxBlurToolStripMenuItem.Name = "boxBlurToolStripMenuItem";
            boxBlurToolStripMenuItem.Size = new Size(224, 26);
            boxBlurToolStripMenuItem.Text = "Box Blur";
            boxBlurToolStripMenuItem.Click += boxBlurToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(224, 26);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // edgeEnhanceToolStripMenuItem
            // 
            edgeEnhanceToolStripMenuItem.Name = "edgeEnhanceToolStripMenuItem";
            edgeEnhanceToolStripMenuItem.Size = new Size(224, 26);
            edgeEnhanceToolStripMenuItem.Text = "Edge Enhance";
            edgeEnhanceToolStripMenuItem.Click += edgeEnhanceToolStripMenuItem_Click;
            // 
            // embossToolStripMenuItem
            // 
            embossToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplaToolStripMenuItem, lossyToolStripMenuItem, horizontalToolStripMenuItem, verticalToolStripMenuItem });
            embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            embossToolStripMenuItem.Size = new Size(224, 26);
            embossToolStripMenuItem.Text = "Emboss";
            // 
            // laplaToolStripMenuItem
            // 
            laplaToolStripMenuItem.Name = "laplaToolStripMenuItem";
            laplaToolStripMenuItem.Size = new Size(224, 26);
            laplaToolStripMenuItem.Text = "Laplascian";
            laplaToolStripMenuItem.Click += laplaToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(224, 26);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horizontalToolStripMenuItem
            // 
            horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            horizontalToolStripMenuItem.Size = new Size(224, 26);
            horizontalToolStripMenuItem.Text = "Horizontal";
            horizontalToolStripMenuItem.Click += horizontalToolStripMenuItem_Click;
            // 
            // verticalToolStripMenuItem
            // 
            verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            verticalToolStripMenuItem.Size = new Size(224, 26);
            verticalToolStripMenuItem.Text = "Vertical";
            verticalToolStripMenuItem.Click += verticalToolStripMenuItem_Click;
            // 
            // auxBtn
            // 
            auxBtn.BackColor = SystemColors.ControlLightLight;
            auxBtn.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            auxBtn.Location = new Point(382, 231);
            auxBtn.Name = "auxBtn";
            auxBtn.Size = new Size(147, 107);
            auxBtn.TabIndex = 10;
            auxBtn.Text = "Select Image Prcoessing Filter in the Menu Strip";
            auxBtn.UseVisualStyleBackColor = false;
            // 
            // openBtn
            // 
            openBtn.BackColor = SystemColors.ControlLight;
            openBtn.Enabled = false;
            openBtn.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            openBtn.Location = new Point(21, 55);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(94, 37);
            openBtn.TabIndex = 11;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = false;
            openBtn.Click += openBtn_Click;
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
            // filterBtn
            // 
            filterBtn.BackColor = SystemColors.GradientInactiveCaption;
            filterBtn.Font = new Font("Sigmar One", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filterBtn.Location = new Point(382, 230);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(147, 107);
            filterBtn.TabIndex = 12;
            filterBtn.Text = "button1";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Visible = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // tempLbl
            // 
            tempLbl.AutoSize = true;
            tempLbl.Location = new Point(27, 83);
            tempLbl.Name = "tempLbl";
            tempLbl.Size = new Size(50, 20);
            tempLbl.TabIndex = 13;
            tempLbl.Text = "label3";
            tempLbl.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(912, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 495);
            Controls.Add(tempLbl);
            Controls.Add(filterBtn);
            Controls.Add(openBtn);
            Controls.Add(auxBtn);
            Controls.Add(saveBtn);
            Controls.Add(resetBtn);
            Controls.Add(pictureBox2);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TrackBar trackBar1;
        private PictureBox pictureBox2;
        private Button resetBtn;
        private Button saveBtn;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem imageProcessingToolStripMenuItem1;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem boxBlurToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem edgeEnhanceToolStripMenuItem;
        private ToolStripMenuItem embossToolStripMenuItem;
        private Button auxBtn;
        private Button openBtn;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button filterBtn;
        private Label tempLbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem laplaToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalToolStripMenuItem;
        private ToolStripMenuItem verticalToolStripMenuItem;
    }
}