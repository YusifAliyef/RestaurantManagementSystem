namespace RestaurantManagementSystem
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            dataGridView_main = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txt_firstName_cust = new TextBox();
            txt_latname_cust = new TextBox();
            btn_add_c = new Button();
            btn_update_c = new Button();
            btn_remove_c = new Button();
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_main
            // 
            dataGridView_main.BackgroundColor = Color.White;
            dataGridView_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_main.Location = new Point(330, 308);
            dataGridView_main.Name = "dataGridView_main";
            dataGridView_main.RowHeadersWidth = 62;
            dataGridView_main.Size = new Size(631, 225);
            dataGridView_main.TabIndex = 1;
            dataGridView_main.CellContentClick += dataGridView_main_CellContentClick;
            dataGridView_main.CellDoubleClick += dataGridView_main_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 153);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 2;
            label1.Text = "Firstname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(792, 155);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 3;
            label2.Text = "Lastname";
            // 
            // txt_firstName_cust
            // 
            txt_firstName_cust.Location = new Point(330, 188);
            txt_firstName_cust.Name = "txt_firstName_cust";
            txt_firstName_cust.Size = new Size(169, 31);
            txt_firstName_cust.TabIndex = 4;
            // 
            // txt_latname_cust
            // 
            txt_latname_cust.Location = new Point(792, 190);
            txt_latname_cust.Name = "txt_latname_cust";
            txt_latname_cust.Size = new Size(169, 31);
            txt_latname_cust.TabIndex = 5;
            // 
            // btn_add_c
            // 
            btn_add_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_c.Location = new Point(330, 260);
            btn_add_c.Name = "btn_add_c";
            btn_add_c.Size = new Size(140, 42);
            btn_add_c.TabIndex = 6;
            btn_add_c.Text = "Add";
            btn_add_c.UseVisualStyleBackColor = true;
            btn_add_c.Click += btn_add_c_Click;
            // 
            // btn_update_c
            // 
            btn_update_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_c.Location = new Point(816, 260);
            btn_update_c.Name = "btn_update_c";
            btn_update_c.Size = new Size(140, 42);
            btn_update_c.TabIndex = 7;
            btn_update_c.Text = "Update";
            btn_update_c.UseVisualStyleBackColor = true;
            btn_update_c.Click += btn_update_c_Click;
            // 
            // btn_remove_c
            // 
            btn_remove_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove_c.Location = new Point(577, 260);
            btn_remove_c.Name = "btn_remove_c";
            btn_remove_c.Size = new Size(140, 42);
            btn_remove_c.TabIndex = 8;
            btn_remove_c.Text = "Delete";
            btn_remove_c.UseVisualStyleBackColor = true;
            btn_remove_c.Click += btn_remove_c_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(577, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(565, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 33);
            comboBox1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 561);
            panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 516);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Gray;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(43, 512);
            button6.Name = "button6";
            button6.Size = new Size(182, 49);
            button6.TabIndex = 7;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Gray;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(43, 443);
            button5.Name = "button5";
            button5.Size = new Size(182, 49);
            button5.TabIndex = 6;
            button5.Text = "Resevation";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(43, 377);
            button4.Name = "button4";
            button4.Size = new Size(182, 49);
            button4.TabIndex = 5;
            button4.Text = "Order";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(43, 312);
            button3.Name = "button3";
            button3.Size = new Size(182, 49);
            button3.TabIndex = 4;
            button3.Text = "Employee";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(43, 247);
            button2.Name = "button2";
            button2.Size = new Size(182, 49);
            button2.TabIndex = 3;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(43, 183);
            button1.Name = "button1";
            button1.Size = new Size(182, 49);
            button1.TabIndex = 2;
            button1.Text = "Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(565, 153);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 12;
            label3.Text = "Reservation";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1015, 556);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox3);
            Controls.Add(btn_remove_c);
            Controls.Add(btn_update_c);
            Controls.Add(btn_add_c);
            Controls.Add(txt_latname_cust);
            Controls.Add(txt_firstName_cust);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_main).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView_main;
        private Label label1;
        private Label label2;
        private TextBox txt_firstName_cust;
        private TextBox txt_latname_cust;
        private Button btn_add_c;
        private Button btn_update_c;
        private Button btn_remove_c;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox2;
    }
}