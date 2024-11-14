using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        private void записатиУФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("music_library.txt"))
            {
                foreach (var track in musicArray)
                {
                    writer.WriteLine($"{track.Title},{track.Author},{track.Genre},{track.Year}");
                }
            }
            MessageBox.Show("Дані збережено у файл");
        }

        private void прочитатиЗФайлуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            musicArray.Clear();

            if (File.Exists("music_library.txt"))
            {
                using (StreamReader reader = new StreamReader("music_library.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 4 && int.TryParse(parts[3], out int year))
                        {
                            string title = parts[0];
                            string author = parts[1];
                            string genre = parts[2];
                            dataGridView1.Rows.Add(title, author, genre, year);
                            musicArray.Add((title, author, genre, year));
                        }
                    }
                }
                MessageBox.Show("Дані загружені");
            }
            else
            {
                MessageBox.Show("Файл не знайдено");
            }
        }

        private void прочитатиЗМасивууToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (musicArray.Count == 0)
            {
                MessageBox.Show("Масив пустий");
                return;
            }

            foreach (var item in musicArray)
            {
                dataGridView1.Rows.Add(item.Title, item.Author, item.Genre, item.Year);
            }
        }
        private void очиститиМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicArray.Clear();
            MessageBox.Show("Масив очищено");
        }

    }
}
