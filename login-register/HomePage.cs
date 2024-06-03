using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class HomePage : Form
    {
        private List<Book> Books;
        public HomePage()
        {
            InitializeComponent();
            Books = new List<Book>();
        }


        private void AddBookToUI(Book book)
        {
            //Create panel
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("BookPanel{0}", book.isbn);
            panel.BackColor = Color.PapayaWhip;
            panel.Size = new Size(125, 205);
            panel.Margin = new Padding(10);
            panel.Tag = book.isbn;

            //Add panel to flowlayoutpanel
            flowLayoutPanel.Controls.Add(panel);

            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("BookPanel{0}", book.isbn);
            picBox.Size = new Size(100, 148);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Load(book.cover);
            picBox.Tag = book.isbn;

            //Create title label
            Label titleLabel;
            titleLabel = new Label();
            titleLabel.Name = String.Format("bookTitleLabel{0}", book.isbn);
            titleLabel.Text = book.title;
            titleLabel.Location = new Point(12, 165);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font("Candara", 12f, FontStyle.Bold);
            titleLabel.AutoSize = true;
            titleLabel.Tag = book.isbn;

            //Create author label
            Label authorLabel;
            authorLabel = new Label();
            authorLabel.Name = String.Format("bookAuthorLabel{0}", book.isbn);
            authorLabel.Text = book.author;
            authorLabel.Location = new Point(12, 185);
            authorLabel.ForeColor = Color.Black;
            authorLabel.Font = new Font("Candara", 10f, FontStyle.Regular);
            authorLabel.Tag = book.isbn;

            //Add controls to panel
            panel.Controls.Add(picBox);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(authorLabel);

        }

        
        private void SearchLabel_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            if (String.IsNullOrWhiteSpace(searchBar.Text))
            {
                MessageBox.Show("The search bar is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NpgsqlConnection connection = DBHandler.OpenConnection();
                NpgsqlCommand command = DBHandler.GetCommand(connection);
                command.CommandText = "SELECT * FROM books WHERE (title = '" + searchBar.Text + "');";
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Book book = new Book(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5), reader.GetString(6));
                        Books.Add(book);
                    }

                    while (Books.Count > 0)
                    {
                        AddBookToUI(Books[0]);
                        Books.RemoveAt(0);
                    }
                }
                else
                {
                    //No books were found
                }
                reader.Close();
                DBHandler.CloseConnection(connection,command);
            }
        }
    }
}
