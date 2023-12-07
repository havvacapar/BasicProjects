namespace SwitchCase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnB = new Button();
            btnC = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoru = new Label();
            lblDogru = new Label();
            lblYanlis = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 17);
            richTextBox1.Margin = new Padding(4, 4, 4, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(576, 283);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(18, 323);
            btnA.Name = "btnA";
            btnA.Size = new Size(286, 70);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += button1_Click_1;
            // 
            // btnB
            // 
            btnB.Location = new Point(319, 323);
            btnB.Name = "btnB";
            btnB.Size = new Size(275, 70);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(18, 399);
            btnC.Name = "btnC";
            btnC.Size = new Size(286, 66);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += button3_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(319, 399);
            btnD.Name = "btnD";
            btnD.Size = new Size(275, 66);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 96);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(629, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(707, 40);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(24, 28);
            lblSoru.TabIndex = 10;
            lblSoru.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(707, 96);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(24, 28);
            lblDogru.TabIndex = 9;
            lblDogru.Text = "0";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(707, 153);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(24, 28);
            lblYanlis.TabIndex = 8;
            lblYanlis.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(605, 203);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(178, 38);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(606, 323);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(770, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(957, 574);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblSoru);
            Controls.Add(lblDogru);
            Controls.Add(lblYanlis);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnB;
        private Button btnC;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoru;
        private Label lblDogru;
        private Label lblYanlis;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}