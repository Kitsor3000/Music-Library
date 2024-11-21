namespace Music_Library
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиЗФайлуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записатиУФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортуваннняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЯToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочитатиЗМасивууToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вивестиЗаЗамовчуваннямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(655, 437);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(211, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Author";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(0, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 238);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Author";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Year";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 450);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(132, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(175, 450);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(145, 22);
            this.txtAuthor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(345, 450);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(132, 22);
            this.txtGenre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(376, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(530, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(505, 450);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(105, 22);
            this.txtYear.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститиToolStripMenuItem,
            this.вивестиЗаЗамовчуваннямToolStripMenuItem,
            this.сортуваннняToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.масивToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(827, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатиЗФайлуToolStripMenuItem,
            this.записатиУФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // прочитатиЗФайлуToolStripMenuItem
            // 
            this.прочитатиЗФайлуToolStripMenuItem.Name = "прочитатиЗФайлуToolStripMenuItem";
            this.прочитатиЗФайлуToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.прочитатиЗФайлуToolStripMenuItem.Text = "Прочитати з файлу.";
            this.прочитатиЗФайлуToolStripMenuItem.Click += new System.EventHandler(this.прочитатиЗФайлуToolStripMenuItem_Click);
            // 
            // записатиУФайлToolStripMenuItem
            // 
            this.записатиУФайлToolStripMenuItem.Name = "записатиУФайлToolStripMenuItem";
            this.записатиУФайлToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.записатиУФайлToolStripMenuItem.Text = "Записати у файл.";
            this.записатиУФайлToolStripMenuItem.Click += new System.EventHandler(this.записатиУФайлToolStripMenuItem_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // сортуваннняToolStripMenuItem
            // 
            this.сортуваннняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аЯToolStripMenuItem,
            this.яАToolStripMenuItem,
            this.рікToolStripMenuItem});
            this.сортуваннняToolStripMenuItem.Name = "сортуваннняToolStripMenuItem";
            this.сортуваннняToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.сортуваннняToolStripMenuItem.Text = "Сортуванння";
            // 
            // аЯToolStripMenuItem
            // 
            this.аЯToolStripMenuItem.Name = "аЯToolStripMenuItem";
            this.аЯToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.аЯToolStripMenuItem.Text = "А-Я";
            this.аЯToolStripMenuItem.Click += new System.EventHandler(this.аЯToolStripMenuItem_Click);
            // 
            // яАToolStripMenuItem
            // 
            this.яАToolStripMenuItem.Name = "яАToolStripMenuItem";
            this.яАToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.яАToolStripMenuItem.Text = "Я-А";
            this.яАToolStripMenuItem.Click += new System.EventHandler(this.яАToolStripMenuItem_Click);
            // 
            // рікToolStripMenuItem
            // 
            this.рікToolStripMenuItem.Name = "рікToolStripMenuItem";
            this.рікToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.рікToolStripMenuItem.Text = "Рік";
            this.рікToolStripMenuItem.Click += new System.EventHandler(this.рікToolStripMenuItem_Click);
            // 
            // масивToolStripMenuItem
            // 
            this.масивToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочитатиЗМасивууToolStripMenuItem,
            this.очиститиМасивToolStripMenuItem});
            this.масивToolStripMenuItem.Name = "масивToolStripMenuItem";
            this.масивToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.масивToolStripMenuItem.Text = "Масив";
            // 
            // прочитатиЗМасивууToolStripMenuItem
            // 
            this.прочитатиЗМасивууToolStripMenuItem.Name = "прочитатиЗМасивууToolStripMenuItem";
            this.прочитатиЗМасивууToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.прочитатиЗМасивууToolStripMenuItem.Text = "Прочитати з масивуу";
            this.прочитатиЗМасивууToolStripMenuItem.Click += new System.EventHandler(this.прочитатиЗМасивууToolStripMenuItem_Click);
            // 
            // очиститиМасивToolStripMenuItem
            // 
            this.очиститиМасивToolStripMenuItem.Name = "очиститиМасивToolStripMenuItem";
            this.очиститиМасивToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.очиститиМасивToolStripMenuItem.Text = "Очистити масив";
            this.очиститиМасивToolStripMenuItem.Click += new System.EventHandler(this.очиститиМасивToolStripMenuItem_Click);
            // 
            // вивестиЗаЗамовчуваннямToolStripMenuItem
            // 
            this.вивестиЗаЗамовчуваннямToolStripMenuItem.Name = "вивестиЗаЗамовчуваннямToolStripMenuItem";
            this.вивестиЗаЗамовчуваннямToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.вивестиЗаЗамовчуваннямToolStripMenuItem.Text = "Вивести за замовчуванням";
            this.вивестиЗаЗамовчуваннямToolStripMenuItem.Click += new System.EventHandler(this.вивестиЗаЗамовчуваннямToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(827, 498);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Music-Library";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатиЗФайлуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записатиУФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортуваннняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЯToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рікToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem масивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочитатиЗМасивууToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиМасивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вивестиЗаЗамовчуваннямToolStripMenuItem;
    }
}

