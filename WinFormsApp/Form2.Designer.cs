namespace WinFormsApp
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            idTextBox = new TextBox();
            brandNameTextBox = new TextBox();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            searchBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 1;
            label1.Text = "Brands";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(277, 63);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.Size = new Size(403, 405);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(24, 95);
            label2.Name = "label2";
            label2.Size = new Size(49, 37);
            label2.TabIndex = 5;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(24, 195);
            label3.Name = "label3";
            label3.Size = new Size(170, 37);
            label3.TabIndex = 6;
            label3.Text = "Brand Name:";
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Segoe UI", 14F);
            idTextBox.Location = new Point(24, 135);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(90, 32);
            idTextBox.TabIndex = 7;
            // 
            // brandNameTextBox
            // 
            brandNameTextBox.Font = new Font("Segoe UI", 14F);
            brandNameTextBox.Location = new Point(24, 235);
            brandNameTextBox.Name = "brandNameTextBox";
            brandNameTextBox.Size = new Size(170, 32);
            brandNameTextBox.TabIndex = 8;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(128, 128, 255);
            insertBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            insertBtn.Location = new Point(285, 288);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(90, 36);
            insertBtn.TabIndex = 9;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(255, 224, 192);
            updateBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            updateBtn.Location = new Point(156, 318);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(90, 36);
            updateBtn.TabIndex = 10;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.IndianRed;
            deleteBtn.BackgroundImageLayout = ImageLayout.None;
            deleteBtn.FlatAppearance.BorderColor = Color.Black;
            deleteBtn.FlatAppearance.BorderSize = 10;
            deleteBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            deleteBtn.Location = new Point(285, 354);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(90, 36);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(192, 255, 192);
            searchBtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchBtn.Location = new Point(24, 318);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(90, 36);
            searchBtn.TabIndex = 12;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(searchBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(button1);
            Controls.Add(brandNameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox idTextBox;
        private TextBox brandNameTextBox;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button searchBtn;
    }
}