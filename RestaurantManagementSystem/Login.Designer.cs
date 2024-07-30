namespace RestaurantManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btn_login = new Button();
            txt_password = new TextBox();
            pictureBox2 = new PictureBox();
            txt_userName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(txt_userName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(466, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 457);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Gray;
            btn_login.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Black;
            btn_login.Location = new Point(149, 352);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(231, 63);
            btn_login.TabIndex = 7;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Cursor = Cursors.IBeam;
            txt_password.Location = new Point(255, 251);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(215, 31);
            txt_password.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(326, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txt_userName
            // 
            txt_userName.BorderStyle = BorderStyle.FixedSingle;
            txt_userName.Cursor = Cursors.IBeam;
            txt_userName.Location = new Point(255, 170);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(215, 31);
            txt_userName.TabIndex = 3;
            txt_userName.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 66);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(173, 59);
            label3.TabIndex = 2;
            label3.Text = "Login";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 251);
            label2.Name = "label2";
            label2.Size = new Size(138, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 170);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(59, 145);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 224);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1015, 556);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_userName;
        private PictureBox pictureBox2;
        private TextBox txt_password;
        private Button btn_login;
        private PictureBox pictureBox3;
    }
}