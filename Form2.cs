using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace QLTV
{
    public partial class Form2 : Form
    {
        DataTable table = new DataTable("table");
        List<Book> books = new List<Book>();
        List<Borrower> borrowers = new List<Borrower>();
        BindingSource bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Published", typeof(int));
            table.Columns.Add("DueDate", typeof(DateTime));


            bindingSource.DataSource = table;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns["DueDate"].DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng hiển thị của cột DueDate
            dataGridView1.Columns["DueDate"].HeaderText = "Due Date";

            

            // Thiết lập lại BindingSource để cập nhật dữ liệu
            bindingSource.ResetBindings(false);


            this.cb_Search.Items.Add("Title");
            this.cb_Search.Items.Add("Author");
            this.cb_Search.Items.Add("Category");

            this.cb_Category.Items.Add("Horror");
            this.cb_Category.Items.Add("Detective");
            this.cb_Category.Items.Add("Discover");
            this.cb_Category.Items.Add("Comedy");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string title = txt_Title.Text;
            string author = txt_Author.Text;
            string category = cb_Category.SelectedItem.ToString();
            if (int.TryParse(txt_Published.Text, out int published) && DateTime.TryParse(txt_DueDate.Text, out DateTime dueDate))
            {
                if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(category))
                {
                    MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Book newBook = new Book(title, author, category, published, dueDate);
                books.Add(newBook);

                DataRow newRow = table.NewRow();
                newRow["Title"] = title;
                newRow["Author"] = author;
                newRow["Category"] = category;
                newRow["Published"] = published;
                newRow["DueDate"] = dueDate;

                table.Rows.Add(newRow);
                MessageBox.Show("Added Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Published year or Due Date is incorrect!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text.ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter the keyword to search for!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string searchBy = cb_Search.SelectedItem.ToString(); // Lấy tiêu chí tìm kiếm từ ComboBox

            DataTable searchResult = table.Clone();

            foreach (Book book in books)
            {
                // Tìm kiếm dựa trên tiêu chí được chọn
                switch (searchBy)
                {
                    case "Title":
                        if (book.Title.ToLower().Contains(keyword))
                        {
                            DataRow newRow1 = searchResult.NewRow();
                            newRow1["Title"] = book.Title;
                            newRow1["Author"] = book.Author;
                            newRow1["Category"] = book.Category;
                            newRow1["Published"] = book.Published;
                            newRow1["DueDate"] = book.DueDate;
                            searchResult.Rows.Add(newRow1);
                        }
                        break;
                    case "Category":
                        if (book.Category.ToLower().Contains(keyword))
                        {
                            DataRow newRow2 = searchResult.NewRow();
                            newRow2["Title"] = book.Title;
                            newRow2["Author"] = book.Author;
                            newRow2["Category"] = book.Category;
                            newRow2["Published"] = book.Published;
                            newRow2["DueDate"] = book.DueDate;
                            searchResult.Rows.Add(newRow2);
                        }
                        break;
                    case "Published":
                        if (book.Published.ToString().Contains(keyword))
                        {
                            DataRow newRow3 = searchResult.NewRow();
                            newRow3["Title"] = book.Title;
                            newRow3["Author"] = book.Author;
                            newRow3["Category"] = book.Category;
                            newRow3["Published"] = book.Published;
                            newRow3["DueDate"] = book.DueDate;
                            searchResult.Rows.Add(newRow3);
                        }
                        break;
                    default:
                        break;
                }
            }

            dataGridView1.DataSource = searchResult;

            if (searchResult.Rows.Count == 0)
            {
                MessageBox.Show("No results found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = table;
            }

            /*string keyword = txt_Search.Text.ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter the title or author of the book you want to find!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable searchResult = table.Clone();

            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(keyword) || book.Author.ToLower().Contains(keyword))
                {
                    DataRow newRow = searchResult.NewRow();
                    newRow["Title"] = book.Title;
                    newRow["Author"] = book.Author;
                    newRow["Category"] = book.Category;
                    newRow["Published"] = book.Published;
                    newRow["DueDate"] = book.DueDate;

                    searchResult.Rows.Add(newRow);
                }
            }
            dataGridView1.DataSource = searchResult;

            if (searchResult.Rows.Count == 0)
            {
                MessageBox.Show("No results found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = table;
            }*/
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text.ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter the title or author of the book you want to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool item = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.ToLower().Contains(keyword) || books[i].Author.ToLower().Contains(keyword))
                {
                    books.RemoveAt(i);
                    table.Rows.RemoveAt(i);

                    item = true;
                    MessageBox.Show("Deleted Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
            if (!item)
            {
                MessageBox.Show("Book not found! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.DataSource = table;
            bindingSource.ResetBindings(false);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            if (rowIndex >= 0)
            {
                string title = txt_Title.Text;
                string author = txt_Author.Text;
                string category = cb_Category.SelectedItem.ToString();
                if (int.TryParse(txt_Published.Text, out int published) && DateTime.TryParse(txt_DueDate.Text, out DateTime dueDate))
                {
                    if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author) || string.IsNullOrWhiteSpace(category))
                    {
                        MessageBox.Show("All fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    books[rowIndex].Title = title;
                    books[rowIndex].Author = author;
                    books[rowIndex].Category = category;
                    books[rowIndex].Published = published;
                    books[rowIndex].DueDate = dueDate;

                    DataRow row = table.Rows[rowIndex];
                    row["Title"] = title;
                    row["Author"] = author;
                    row["Category"] = category;
                    row["Published"] = published;
                    row["DueDate"] = dueDate;

                    MessageBox.Show("Updated Successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSource.ResetBindings(false);
                }
                else
                {
                    MessageBox.Show("Published year or Due Date is incorrect!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            books.Clear();
            table.Rows.Clear();
            richTextBox1.Clear();

            using (StreamReader readtext = new StreamReader("books.txt"))
            {
                string line;
                while ((line = readtext.ReadLine()) != null)
                {
                    richTextBox1.Text += line + "\n";
                    string[] info = line.Split(" | ");

                    if (info.Length >= 5)
                    {
                        string title = info[0];
                        string author = info[1];
                        string category = info[2];
                        if (int.TryParse(info[3], out int published) && DateTime.TryParse(info[4], out DateTime dueDate))
                        {
                            Book newBook = new Book(title, author, category, published, dueDate);
                            books.Add(newBook);

                            DataRow newRow = table.NewRow();
                            newRow["Title"] = title;
                            newRow["Author"] = author;
                            newRow["Category"] = category;
                            newRow["Published"] = published;
                            newRow["DueDate"] = dueDate;

                            table.Rows.Add(newRow);
                        }
                    }
                }
            }
            bindingSource.ResetBindings(false);
            /*OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files|*.txt";
            openFileDialog.Title = "Open books file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                books.Clear();
                table.Rows.Clear();
                richTextBox1.Clear();

                using (StreamReader readtext = new StreamReader(fileName))
                {
                    string line;
                    while ((line = readtext.ReadLine()) != null)
                    {
                        richTextBox1.Text += line + "\n";
                        string[] info = line.Split(" | ");

                        if (info.Length >= 5)
                        {
                            string title = info[0];
                            string author = info[1];
                            string category = info[2];
                            if (int.TryParse(info[3], out int published) && DateTime.TryParse(info[4], out DateTime dueDate))
                            {
                                Book newBook = new Book(title, author, category, published, dueDate);
                                books.Add(newBook);

                                DataRow newRow = table.NewRow();
                                newRow["Title"] = title;
                                newRow["Author"] = author;
                                newRow["Category"] = category;
                                newRow["Published"] = published;
                                newRow["DueDate"] = dueDate;

                                table.Rows.Add(newRow);
                            }
                        }
                    }
                }
                bindingSource.ResetBindings(false);
            }*/
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("books.txt"))
            {
                foreach (Book book in books)
                {
                    string bookInfo = $"{book.Title} | {book.Author} | {book.Category} | {book.Published} | {book.DueDate}";
                    writetext.WriteLine(bookInfo);
                }
            }
        }

        

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Do you want to exit?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
