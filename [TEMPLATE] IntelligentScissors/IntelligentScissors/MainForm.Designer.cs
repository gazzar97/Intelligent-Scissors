namespace IntelligentScissors
{
    partial class MainForm
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
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.btnOpen = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.btnGaussSmooth = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.txtHeight = new System.Windows.Forms.TextBox();
               this.nudMaskSize = new System.Windows.Forms.NumericUpDown();
               this.txtWidth = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.txtGaussSigma = new System.Windows.Forms.TextBox();
               this.panel1 = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.label7 = new System.Windows.Forms.Label();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.label8 = new System.Windows.Forms.Label();
               this.rest = new System.Windows.Forms.Button();
               this.closeShape = new System.Windows.Forms.Button();
               this.Crop = new System.Windows.Forms.Button();
               this.save = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.nudMaskSize)).BeginInit();
               this.panel1.SuspendLayout();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(3, 3);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(427, 360);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
               this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
               this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
               this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
               // 
               // pictureBox2
               // 
               this.pictureBox2.Location = new System.Drawing.Point(2, 3);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(412, 360);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
               this.pictureBox2.TabIndex = 1;
               this.pictureBox2.TabStop = false;
               // 
               // btnOpen
               // 
               this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnOpen.Location = new System.Drawing.Point(360, 427);
               this.btnOpen.Name = "btnOpen";
               this.btnOpen.Size = new System.Drawing.Size(82, 62);
               this.btnOpen.TabIndex = 2;
               this.btnOpen.Text = "Open Image";
               this.btnOpen.UseVisualStyleBackColor = true;
               this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(163, 393);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(130, 19);
               this.label1.TabIndex = 3;
               this.label1.Text = "Original Image";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(605, 393);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(148, 19);
               this.label2.TabIndex = 4;
               this.label2.Text = "Smoothed Image";
               // 
               // btnGaussSmooth
               // 
               this.btnGaussSmooth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnGaussSmooth.Location = new System.Drawing.Point(471, 427);
               this.btnGaussSmooth.Name = "btnGaussSmooth";
               this.btnGaussSmooth.Size = new System.Drawing.Size(82, 62);
               this.btnGaussSmooth.TabIndex = 5;
               this.btnGaussSmooth.Text = "Gauss Smooth";
               this.btnGaussSmooth.UseVisualStyleBackColor = true;
               this.btnGaussSmooth.Click += new System.EventHandler(this.btnGaussSmooth_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(591, 430);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(71, 16);
               this.label3.TabIndex = 7;
               this.label3.Text = "Mask Size";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(591, 469);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(88, 16);
               this.label4.TabIndex = 9;
               this.label4.Text = "Gauss Sigma";
               // 
               // txtHeight
               // 
               this.txtHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtHeight.Location = new System.Drawing.Point(281, 466);
               this.txtHeight.Name = "txtHeight";
               this.txtHeight.ReadOnly = true;
               this.txtHeight.Size = new System.Drawing.Size(57, 23);
               this.txtHeight.TabIndex = 8;
               // 
               // nudMaskSize
               // 
               this.nudMaskSize.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.nudMaskSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
               this.nudMaskSize.Location = new System.Drawing.Point(685, 428);
               this.nudMaskSize.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
               this.nudMaskSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
               this.nudMaskSize.Name = "nudMaskSize";
               this.nudMaskSize.Size = new System.Drawing.Size(57, 23);
               this.nudMaskSize.TabIndex = 10;
               this.nudMaskSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
               // 
               // txtWidth
               // 
               this.txtWidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtWidth.Location = new System.Drawing.Point(281, 428);
               this.txtWidth.Name = "txtWidth";
               this.txtWidth.ReadOnly = true;
               this.txtWidth.Size = new System.Drawing.Size(57, 23);
               this.txtWidth.TabIndex = 11;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(226, 431);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(46, 16);
               this.label5.TabIndex = 12;
               this.label5.Text = "Width";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(226, 469);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(50, 16);
               this.label6.TabIndex = 13;
               this.label6.Text = "Height";
               // 
               // txtGaussSigma
               // 
               this.txtGaussSigma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtGaussSigma.Location = new System.Drawing.Point(685, 466);
               this.txtGaussSigma.Name = "txtGaussSigma";
               this.txtGaussSigma.Size = new System.Drawing.Size(57, 23);
               this.txtGaussSigma.TabIndex = 14;
               this.txtGaussSigma.Text = "1";
               // 
               // panel1
               // 
               this.panel1.AutoScroll = true;
               this.panel1.AutoScrollMinSize = new System.Drawing.Size(1, 1);
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel1.Controls.Add(this.pictureBox1);
               this.panel1.Location = new System.Drawing.Point(12, 12);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(438, 371);
               this.panel1.TabIndex = 15;
               // 
               // panel2
               // 
               this.panel2.AutoScroll = true;
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
               this.panel2.Controls.Add(this.pictureBox2);
               this.panel2.Location = new System.Drawing.Point(526, 12);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(421, 371);
               this.panel2.TabIndex = 16;
               // 
               // textBox1
               // 
               this.textBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(456, 64);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(64, 23);
               this.textBox1.TabIndex = 17;
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(455, 30);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(69, 16);
               this.label7.TabIndex = 18;
               this.label7.Text = "Original X";
               // 
               // textBox2
               // 
               this.textBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox2.Location = new System.Drawing.Point(456, 161);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(64, 23);
               this.textBox2.TabIndex = 19;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(451, 123);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(69, 16);
               this.label8.TabIndex = 20;
               this.label8.Text = "Original Y";
               // 
               // rest
               // 
               this.rest.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.rest.Location = new System.Drawing.Point(452, 331);
               this.rest.Name = "rest";
               this.rest.Size = new System.Drawing.Size(69, 34);
               this.rest.TabIndex = 21;
               this.rest.Text = "Reset";
               this.rest.UseVisualStyleBackColor = true;
               this.rest.Click += new System.EventHandler(this.rest_Click);
               // 
               // closeShape
               // 
               this.closeShape.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.closeShape.Location = new System.Drawing.Point(67, 428);
               this.closeShape.Name = "closeShape";
               this.closeShape.Size = new System.Drawing.Size(124, 61);
               this.closeShape.TabIndex = 22;
               this.closeShape.Text = "Close Shape";
               this.closeShape.UseVisualStyleBackColor = true;
               this.closeShape.Click += new System.EventHandler(this.closeShape_Click);
               // 
               // Crop
               // 
               this.Crop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Crop.Location = new System.Drawing.Point(451, 217);
               this.Crop.Name = "Crop";
               this.Crop.Size = new System.Drawing.Size(69, 34);
               this.Crop.TabIndex = 23;
               this.Crop.Text = "Crop";
               this.Crop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
               this.Crop.UseVisualStyleBackColor = true;
               this.Crop.Click += new System.EventHandler(this.Crop_Click);
               // 
               // save
               // 
               this.save.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.save.Location = new System.Drawing.Point(452, 276);
               this.save.Name = "save";
               this.save.Size = new System.Drawing.Size(69, 34);
               this.save.TabIndex = 24;
               this.save.Text = "Save";
               this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
               this.save.UseVisualStyleBackColor = true;
               this.save.Click += new System.EventHandler(this.save_Click);
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(957, 500);
               this.Controls.Add(this.save);
               this.Controls.Add(this.Crop);
               this.Controls.Add(this.closeShape);
               this.Controls.Add(this.rest);
               this.Controls.Add(this.label8);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.label7);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.txtGaussSigma);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.txtWidth);
               this.Controls.Add(this.nudMaskSize);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.txtHeight);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnGaussSmooth);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btnOpen);
               this.Name = "MainForm";
               this.Text = "Intelligent Scissors...";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.nudMaskSize)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGaussSmooth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.NumericUpDown nudMaskSize;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGaussSigma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.Button closeShape;
        private System.Windows.Forms.Button Crop;
        private System.Windows.Forms.Button save;
    }
}

