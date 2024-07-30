namespace RestaurantManagementSystem
{
    partial class Ord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ord));
            pictureBox4 = new PictureBox();
            dataGridView_ord = new DataGridView();
            btn_add_c = new Button();
            txt_ordername = new TextBox();
            txt_ordernumber = new TextBox();
            txt_orderprice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_remove_c = new Button();
            btn_update_c = new Button();
            cmb_cust = new ComboBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ord).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(542, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(134, 119);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // dataGridView_ord
            // 
            dataGridView_ord.BackgroundColor = Color.White;
            dataGridView_ord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ord.Location = new Point(330, 308);
            dataGridView_ord.Name = "dataGridView_ord";
            dataGridView_ord.RowHeadersWidth = 62;
            dataGridView_ord.Size = new Size(631, 225);
            dataGridView_ord.TabIndex = 9;
            // 
            // btn_add_c
            // 
            btn_add_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_c.Location = new Point(330, 260);
            btn_add_c.Name = "btn_add_c";
            btn_add_c.Size = new Size(140, 42);
            btn_add_c.TabIndex = 10;
            btn_add_c.Text = "Add";
            btn_add_c.UseVisualStyleBackColor = true;
            btn_add_c.Click += btn_add_c_Click;
            // 
            // txt_ordername
            // 
            txt_ordername.Location = new Point(292, 190);
            txt_ordername.Name = "txt_ordername";
            txt_ordername.Size = new Size(150, 31);
            txt_ordername.TabIndex = 11;
            txt_ordername.TextChanged += txt_ordername_TextChanged;
            // 
            // txt_ordernumber
            // 
            txt_ordernumber.Location = new Point(472, 192);
            txt_ordernumber.Name = "txt_ordernumber";
            txt_ordernumber.Size = new Size(150, 31);
            txt_ordernumber.TabIndex = 12;
            // 
            // txt_orderprice
            // 
            txt_orderprice.Location = new Point(656, 192);
            txt_orderprice.Name = "txt_orderprice";
            txt_orderprice.Size = new Size(150, 31);
            txt_orderprice.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 159);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 14;
            label1.Text = "Order name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(656, 159);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 15;
            label2.Text = "Order price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(472, 161);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 16;
            label3.Text = "Order number";
            // 
            // btn_remove_c
            // 
            btn_remove_c.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove_c.Location = new Point(577, 260);
            btn_remove_c.Name = "btn_remove_c";
            btn_remove_c.Size = new Size(140, 42);
            btn_remove_c.TabIndex = 17;
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
            btn_update_c.TabIndex = 18;
            btn_update_c.Text = "Update";
            btn_update_c.UseVisualStyleBackColor = true;
            btn_update_c.Click += btn_update_c_Click;
            // 
            // cmb_cust
            // 
            cmb_cust.FormattingEnabled = true;
            cmb_cust.Location = new Point(839, 190);
            cmb_cust.Name = "cmb_cust";
            cmb_cust.Size = new Size(150, 33);
            cmb_cust.TabIndex = 19;
            cmb_cust.SelectedIndexChanged += cmb_cust_SelectedIndexChanged;
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
            panel1.TabIndex = 20;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(839, 159);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 21;
            label4.Text = "Customer";
            // 
            // Ord
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1015, 556);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(cmb_cust);
            Controls.Add(btn_update_c);
            Controls.Add(btn_remove_c);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_orderprice);
            Controls.Add(txt_ordernumber);
            Controls.Add(txt_ordername);
            Controls.Add(btn_add_c);
            Controls.Add(dataGridView_ord);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ord";
            Load += Ord_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ord).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox4;
        private DataGridView dataGridView_ord;
        private Button btn_add_c;
        private TextBox txt_ordername;
        private TextBox txt_ordernumber;
        private TextBox txt_orderprice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_remove_c;
        private Button btn_update_c;
        private ComboBox cmb_cust;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
    }
}