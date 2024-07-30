namespace RestaurantManagementSystem
{
    partial class Emp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emp));
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            txt_age = new TextBox();
            txt_salary = new TextBox();
            txt_experience = new TextBox();
            btn_add_c = new Button();
            btn_remove_c = new Button();
            btn_update_c = new Button();
            dataGridView_emp = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_emp).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(564, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 119);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(280, 133);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 12;
            label2.Text = "Firstname";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(593, 133);
            label3.Name = "label3";
            label3.Size = new Size(49, 28);
            label3.TabIndex = 13;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 133);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 14;
            label4.Text = "Lastname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(732, 133);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 15;
            label5.Text = "Salary";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(864, 131);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 16;
            label1.Text = "Experience";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(280, 164);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(135, 31);
            txt_firstname.TabIndex = 17;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(443, 164);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(128, 31);
            txt_lastname.TabIndex = 18;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(593, 164);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(115, 31);
            txt_age.TabIndex = 19;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(732, 164);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(114, 31);
            txt_salary.TabIndex = 20;
            // 
            // txt_experience
            // 
            txt_experience.Location = new Point(864, 164);
            txt_experience.Name = "txt_experience";
            txt_experience.Size = new Size(125, 31);
            txt_experience.TabIndex = 21;
            // 
            // btn_add_c
            // 
            btn_add_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_c.Location = new Point(330, 260);
            btn_add_c.Name = "btn_add_c";
            btn_add_c.Size = new Size(140, 42);
            btn_add_c.TabIndex = 22;
            btn_add_c.Text = "Add";
            btn_add_c.UseVisualStyleBackColor = true;
            btn_add_c.Click += btn_add_c_Click;
            // 
            // btn_remove_c
            // 
            btn_remove_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove_c.Location = new Point(581, 260);
            btn_remove_c.Name = "btn_remove_c";
            btn_remove_c.Size = new Size(140, 42);
            btn_remove_c.TabIndex = 23;
            btn_remove_c.Text = "Delete";
            btn_remove_c.UseVisualStyleBackColor = true;
            btn_remove_c.Click += btn_remove_c_Click;
            // 
            // btn_update_c
            // 
            btn_update_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_c.Location = new Point(821, 260);
            btn_update_c.Name = "btn_update_c";
            btn_update_c.Size = new Size(140, 42);
            btn_update_c.TabIndex = 24;
            btn_update_c.Text = "Update";
            btn_update_c.UseVisualStyleBackColor = true;
            btn_update_c.Click += btn_update_c_Click;
            // 
            // dataGridView_emp
            // 
            dataGridView_emp.BackgroundColor = Color.White;
            dataGridView_emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_emp.Location = new Point(330, 308);
            dataGridView_emp.Name = "dataGridView_emp";
            dataGridView_emp.RowHeadersWidth = 62;
            dataGridView_emp.Size = new Size(631, 225);
            dataGridView_emp.TabIndex = 25;
            dataGridView_emp.CellContentClick += dataGridView_emp_CellContentClick_1;
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
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 561);
            panel1.TabIndex = 26;
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
            // Emp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1015, 556);
            Controls.Add(panel1);
            Controls.Add(dataGridView_emp);
            Controls.Add(btn_update_c);
            Controls.Add(btn_remove_c);
            Controls.Add(btn_add_c);
            Controls.Add(txt_experience);
            Controls.Add(txt_salary);
            Controls.Add(txt_age);
            Controls.Add(txt_lastname);
            Controls.Add(txt_firstname);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustForm";
            Load += Emp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_emp).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private TextBox txt_age;
        private TextBox txt_salary;
        private TextBox txt_experience;
        private Button btn_add_c;
        private Button btn_remove_c;
        private Button btn_update_c;
        private DataGridView dataGridView_emp;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}