namespace EmguOpenCVExample
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtWidthX0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidthX1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeightY1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHeightY0 = new System.Windows.Forms.TextBox();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.lblPixelInt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblOCRRecon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(734, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 647);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(721, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 368);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(983, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save Frame";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtWidthX0
            // 
            this.txtWidthX0.Location = new System.Drawing.Point(1145, 54);
            this.txtWidthX0.Name = "txtWidthX0";
            this.txtWidthX0.Size = new System.Drawing.Size(245, 26);
            this.txtWidthX0.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1145, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1145, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width X1";
            // 
            // txtWidthX1
            // 
            this.txtWidthX1.Location = new System.Drawing.Point(1145, 121);
            this.txtWidthX1.Name = "txtWidthX1";
            this.txtWidthX1.Size = new System.Drawing.Size(245, 26);
            this.txtWidthX1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height Y1";
            // 
            // txtHeightY1
            // 
            this.txtHeightY1.Location = new System.Drawing.Point(1141, 308);
            this.txtHeightY1.Name = "txtHeightY1";
            this.txtHeightY1.Size = new System.Drawing.Size(245, 26);
            this.txtHeightY1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1141, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Height Y0";
            // 
            // txtHeightY0
            // 
            this.txtHeightY0.Location = new System.Drawing.Point(1141, 241);
            this.txtHeightY0.Name = "txtHeightY0";
            this.txtHeightY0.Size = new System.Drawing.Size(245, 26);
            this.txtHeightY0.TabIndex = 8;
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Location = new System.Drawing.Point(1145, 376);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(88, 20);
            this.lblPixelCount.TabIndex = 12;
            this.lblPixelCount.Text = "PixelCount:";
            // 
            // lblPixelInt
            // 
            this.lblPixelInt.AutoSize = true;
            this.lblPixelInt.Location = new System.Drawing.Point(826, 515);
            this.lblPixelInt.Name = "lblPixelInt";
            this.lblPixelInt.Size = new System.Drawing.Size(45, 20);
            this.lblPixelInt.TabIndex = 13;
            this.lblPixelInt.Text = "0000";
            this.lblPixelInt.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "SERIAL NUMBER:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(880, 418);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(0, 20);
            this.lblSerialNumber.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "OCR Recognize:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(728, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pixel Count:";
            this.label7.Visible = false;
            // 
            // lblOCRRecon
            // 
            this.lblOCRRecon.AutoSize = true;
            this.lblOCRRecon.Location = new System.Drawing.Point(864, 468);
            this.lblOCRRecon.Name = "lblOCRRecon";
            this.lblOCRRecon.Size = new System.Drawing.Size(0, 20);
            this.lblOCRRecon.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 684);
            this.Controls.Add(this.lblOCRRecon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPixelInt);
            this.Controls.Add(this.lblPixelCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeightY1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeightY0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWidthX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidthX0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Nameplate verification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtWidthX0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidthX1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeightY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHeightY0;
        private System.Windows.Forms.Label lblPixelCount;
        private System.Windows.Forms.Label lblPixelInt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblOCRRecon;
    }
}

