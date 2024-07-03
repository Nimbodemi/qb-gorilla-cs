namespace gorilla
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            GameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player1 = new PictureBox();
            player2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            gameOver = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2).BeginInit();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Location = new Point(310, 370);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // player1
            // 
            player1.BackColor = Color.Orange;
            player1.Location = new Point(280, 400);
            player1.Name = "player1";
            player1.Size = new Size(100, 100);
            player1.TabIndex = 3;
            player1.TabStop = false;
            // 
            // player2
            // 
            player2.BackColor = Color.Orange;
            player2.Location = new Point(1580, 400);
            player2.Name = "player2";
            player2.Size = new Size(100, 100);
            player2.TabIndex = 3;
            player2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 41);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(92, 81);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // gameOver
            // 
            gameOver.Font = new Font("Consolas", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameOver.Location = new Point(580, 480);
            gameOver.Name = "gameOver";
            gameOver.Size = new Size(740, 120);
            gameOver.TabIndex = 6;
            gameOver.Text = "GAME OVER";
            gameOver.TextAlign = HorizontalAlignment.Center;
            gameOver.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1904, 1041);
            Controls.Add(gameOver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(player2);
            Controls.Add(player1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player1;
        private PictureBox player2;
        private Label label1;
        private Label label2;
        private TextBox gameOver;
    }
}
