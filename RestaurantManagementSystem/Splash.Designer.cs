namespace RestaurantManagementSystem
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            progres = new ProgressBar();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            percent = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 561);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 143);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 240);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vivaldi", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(292, 57);
            label1.Name = "label1";
            label1.Size = new Size(711, 67);
            label1.TabIndex = 1;
            label1.Text = "Restaurant Management System";
            label1.Click += label1_Click;
            // 
            // progres
            // 
            progres.BackColor = Color.White;
            progres.ForeColor = Color.Gold;
            progres.Location = new Point(381, 483);
            progres.Name = "progres";
            progres.Size = new Size(544, 40);
            progres.TabIndex = 3;
            progres.Click += progres_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(381, 442);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 4;
            label2.Text = "Loading...";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // percent
            // 
            percent.AutoSize = true;
            percent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percent.Location = new Point(877, 448);
            percent.Name = "percent";
            percent.Size = new Size(35, 32);
            percent.TabIndex = 5;
            percent.Text = "...";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(459, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1015, 556);
            Controls.Add(pictureBox3);
            Controls.Add(percent);
            Controls.Add(label2);
            Controls.Add(progres);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            Load += Splash_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ProgressBar progres;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label percent;
        private PictureBox pictureBox3;
    }
}