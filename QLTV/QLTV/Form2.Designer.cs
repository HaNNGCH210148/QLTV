﻿namespace QLTV
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
            richTextBox1 = new RichTextBox();
            dataGridView1 = new DataGridView();
            txt_Search = new TextBox();
            btn_SaveFile = new Button();
            btn_Quit = new Button();
            btn_OpenFile = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Search = new Button();
            btn_Add = new Button();
            txt_Published = new TextBox();
            txt_Author = new TextBox();
            txt_Title = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            txt_DueDate = new TextBox();
            label4 = new Label();
            txt_Category = new TextBox();
            txt_Borrower = new TextBox();
            Borrower = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(361, 259);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(537, 124);
            richTextBox1.TabIndex = 57;
            richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(536, 193);
            dataGridView1.TabIndex = 56;
            // 
            // txt_Search
            // 
            txt_Search.BackColor = SystemColors.Info;
            txt_Search.Location = new Point(461, 17);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(428, 27);
            txt_Search.TabIndex = 55;
            // 
            // btn_SaveFile
            // 
            btn_SaveFile.BackColor = Color.Silver;
            btn_SaveFile.Location = new Point(804, 402);
            btn_SaveFile.Name = "btn_SaveFile";
            btn_SaveFile.Size = new Size(94, 29);
            btn_SaveFile.TabIndex = 54;
            btn_SaveFile.Text = "Save File";
            btn_SaveFile.UseVisualStyleBackColor = false;
            btn_SaveFile.Click += btn_SaveFile_Click;
            // 
            // btn_Quit
            // 
            btn_Quit.BackColor = Color.Red;
            btn_Quit.ForeColor = SystemColors.ButtonHighlight;
            btn_Quit.Location = new Point(136, 409);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new Size(94, 29);
            btn_Quit.TabIndex = 53;
            btn_Quit.Text = "Quit";
            btn_Quit.UseVisualStyleBackColor = false;
            btn_Quit.Click += btn_Quit_Click;
            // 
            // btn_OpenFile
            // 
            btn_OpenFile.BackColor = Color.Silver;
            btn_OpenFile.Location = new Point(359, 402);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(94, 29);
            btn_OpenFile.TabIndex = 52;
            btn_OpenFile.Text = "Open File";
            btn_OpenFile.UseVisualStyleBackColor = false;
            btn_OpenFile.Click += btn_OpenFile_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Honeydew;
            btn_Update.Location = new Point(240, 17);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 51;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Honeydew;
            btn_Delete.Location = new Point(124, 17);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 50;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Search
            // 
            btn_Search.BackColor = Color.PowderBlue;
            btn_Search.Location = new Point(361, 15);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(94, 29);
            btn_Search.TabIndex = 49;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.Honeydew;
            btn_Add.Location = new Point(2, 17);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(94, 29);
            btn_Add.TabIndex = 48;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // txt_Published
            // 
            txt_Published.BackColor = SystemColors.Info;
            txt_Published.Location = new Point(77, 250);
            txt_Published.Name = "txt_Published";
            txt_Published.Size = new Size(257, 27);
            txt_Published.TabIndex = 47;
            // 
            // txt_Author
            // 
            txt_Author.BackColor = SystemColors.Info;
            txt_Author.Location = new Point(77, 120);
            txt_Author.Name = "txt_Author";
            txt_Author.Size = new Size(257, 27);
            txt_Author.TabIndex = 46;
            // 
            // txt_Title
            // 
            txt_Title.BackColor = SystemColors.Info;
            txt_Title.Location = new Point(75, 60);
            txt_Title.Name = "txt_Title";
            txt_Title.Size = new Size(257, 27);
            txt_Title.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 253);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 44;
            label3.Text = "Published";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 43;
            label2.Text = "Author";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 60);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 42;
            label1.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 189);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 63;
            label5.Text = "Category";
            // 
            // txt_DueDate
            // 
            txt_DueDate.BackColor = SystemColors.Info;
            txt_DueDate.Location = new Point(75, 376);
            txt_DueDate.Name = "txt_DueDate";
            txt_DueDate.Size = new Size(257, 27);
            txt_DueDate.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 379);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 65;
            label4.Text = "DueDate";
            // 
            // txt_Category
            // 
            txt_Category.BackColor = SystemColors.Info;
            txt_Category.Location = new Point(77, 186);
            txt_Category.Name = "txt_Category";
            txt_Category.Size = new Size(257, 27);
            txt_Category.TabIndex = 66;
            // 
            // txt_Borrower
            // 
            txt_Borrower.BackColor = SystemColors.Info;
            txt_Borrower.Location = new Point(75, 313);
            txt_Borrower.Name = "txt_Borrower";
            txt_Borrower.Size = new Size(257, 27);
            txt_Borrower.TabIndex = 67;
            // 
            // Borrower
            // 
            Borrower.AutoSize = true;
            Borrower.Location = new Point(5, 316);
            Borrower.Name = "Borrower";
            Borrower.Size = new Size(70, 20);
            Borrower.TabIndex = 68;
            Borrower.Text = "Borrower";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(901, 450);
            Controls.Add(Borrower);
            Controls.Add(txt_Borrower);
            Controls.Add(txt_Category);
            Controls.Add(label4);
            Controls.Add(txt_DueDate);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txt_Search);
            Controls.Add(btn_SaveFile);
            Controls.Add(btn_Quit);
            Controls.Add(btn_OpenFile);
            Controls.Add(btn_Update);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Search);
            Controls.Add(btn_Add);
            Controls.Add(txt_Published);
            Controls.Add(txt_Author);
            Controls.Add(txt_Title);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private TextBox txt_Search;
        private Button btn_SaveFile;
        private Button btn_Quit;
        private Button btn_OpenFile;
        private Button btn_Update;
        private Button btn_Delete;
        private Button btn_Search;
        private Button btn_Add;
        private TextBox txt_Published;
        private TextBox txt_Author;
        private TextBox txt_Title;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txt_DueDate;
        private Label label4;
        private TextBox txt_Category;
        private TextBox txt_Borrower;
        private Label Borrower;
    }
}