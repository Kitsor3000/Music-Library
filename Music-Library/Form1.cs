using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Library
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            txtTitle.KeyPress += TxtTextBoxes_KeyPress;
            txtAuthor.KeyPress += TxtTextBoxes_KeyPress;
            txtGenre.KeyPress += TxtTextBoxes_KeyPress;
            txtYear.KeyPress += TxtYear_KeyPress;
        }



        // Обробник для поля "Рік" (тільки цифри, без спеціальних символів)
        private void TxtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Забороняє введення символів, крім цифр
            }
        }

        // Обробник для полів "Назва", "Автор", "Жанр" (тільки літери)
        private void TxtTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Забороняє введення символів, крім букв і пробілів
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string yearText = txtYear.Text.Trim();

            // Перевірка, що всі поля заповнені
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) ||
                string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(yearText))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля: Назва, Виконавець, Жанр, Рік.");
                return;
            }

            // Перевірка року: має бути числом, не від'ємним і з 4 цифр
            if (!int.TryParse(yearText, out int year) || year < 1000 || year > 9999)
            {
                MessageBox.Show("Будь ласка, введіть коректний рік (4 цифри, не від'ємне число).");
                return;
            }

            // Додаємо рядок до DataGridView та масиву
            dataGridView1.Rows.Add(title, author, genre, year);


            // Очищення текстбоксів після додавання
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtYear.Clear();
        }

        private void AddDefaultTracks()
        {
            // Список треків за замовчуванням
            var defaultTracks = new[]
            {
                ("Track 1", "Artist A", "Rock", 2001),
                ("Track 2", "Artist B", "Pop", 2003),
                ("Track 3", "Artist C", "Jazz", 1999),
                ("Track 4", "Artist D", "Classical", 2010),
                ("Track 5", "Artist E", "Hip-hop", 2015)
            };

            foreach (var track in defaultTracks)
            {
                dataGridView1.Rows.Add(track.Item1, track.Item2, track.Item3, track.Item4);

            }
        }







        private void очиститиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void аЯToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сортування за назвою від А до Я
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void яАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сортування за назвою від Я до А
            dataGridView1.Sort(dataGridView1.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        private void рікToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Сортування за роком зростанням
            dataGridView1.Sort(dataGridView1.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void вивестиЗаЗамовчуваннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDefaultTracks();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
