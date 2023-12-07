namespace BilgiYarismasi1
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
            btnA = new Button();
            richTextBox1 = new RichTextBox();
            btnB = new Button();
            btnD = new Button();
            btnC = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblYanlis = new Label();
            lblDogru = new Label();
            lblSoru = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnA
            // 
            btnA.Location = new Point(18, 377);
            btnA.Margin = new Padding(4);
            btnA.Name = "btnA";
            btnA.Size = new Size(392, 63);
            btnA.TabIndex = 0;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 17);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(772, 337);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnB
            // 
            btnB.Location = new Point(418, 377);
            btnB.Margin = new Padding(4);
            btnB.Name = "btnB";
            btnB.Size = new Size(372, 63);
            btnB.TabIndex = 2;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(418, 448);
            btnD.Margin = new Padding(4);
            btnD.Name = "btnD";
            btnD.Size = new Size(372, 63);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(18, 448);
            btnC.Margin = new Padding(4);
            btnC.Name = "btnC";
            btnC.Size = new Size(392, 63);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(797, 87);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(816, 138);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(821, 191);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(919, 191);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(24, 28);
            lblYanlis.TabIndex = 10;
            lblYanlis.Text = "0";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(917, 138);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(24, 28);
            lblDogru.TabIndex = 9;
            lblDogru.Text = "0";
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(917, 87);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(24, 28);
            lblSoru.TabIndex = 8;
            lblSoru.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(797, 241);
            btnSonraki.Margin = new Padding(4);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(215, 39);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += bntSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(816, 377);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1009, 377);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(658, 532);
            label4.Name = "label4";
            label4.Size = new Size(68, 28);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(748, 532);
            label5.Name = "label5";
            label5.Size = new Size(67, 28);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(1197, 576);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblYanlis);
            Controls.Add(lblDogru);
            Controls.Add(lblSoru);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnC);
            Controls.Add(btnB);
            Controls.Add(richTextBox1);
            Controls.Add(btnA);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnA;
        private RichTextBox richTextBox1;
        private Button btnB;
        private Button btnD;
        private Button btnC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblYanlis;
        private Label lblDogru;
        private Label lblSoru;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}