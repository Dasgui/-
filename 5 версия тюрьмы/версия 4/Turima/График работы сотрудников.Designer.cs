
namespace Turima
{
    partial class GraphWorker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphWorker));
            this.menuOfRabotnik = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableOfWorker = new System.Windows.Forms.DataGridView();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Приходит = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Уходит = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СрокСлужбы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkat = new System.Windows.Forms.Button();
            this.GoToPoisk = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.checkSkolkSlugit = new System.Windows.Forms.CheckBox();
            this.checkUhod = new System.Windows.Forms.CheckBox();
            this.checkKogrdaRabotat = new System.Windows.Forms.CheckBox();
            this.checkFIO = new System.Windows.Forms.CheckBox();
            this.checkNomer = new System.Windows.Forms.CheckBox();
            this.WhatIchem = new System.Windows.Forms.TextBox();
            this.ZadniiFon = new System.Windows.Forms.PictureBox();
            this.menuOfRabotnik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOfRabotnik
            // 
            this.menuOfRabotnik.BackColor = System.Drawing.Color.DarkCyan;
            this.menuOfRabotnik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuOfRabotnik.Location = new System.Drawing.Point(0, 0);
            this.menuOfRabotnik.Name = "menuOfRabotnik";
            this.menuOfRabotnik.Size = new System.Drawing.Size(800, 24);
            this.menuOfRabotnik.TabIndex = 0;
            this.menuOfRabotnik.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтрокуToolStripMenuItem,
            this.удалитьСтрокуToolStripMenuItem,
            this.включитьРедактированиеToolStripMenuItem,
            this.выключитьРедактированиеToolStripMenuItem});
            this.редактированиеToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // добавитьСтрокуToolStripMenuItem
            // 
            this.добавитьСтрокуToolStripMenuItem.Name = "добавитьСтрокуToolStripMenuItem";
            this.добавитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.добавитьСтрокуToolStripMenuItem.Text = "Добавить строку";
            this.добавитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.добавитьСтрокуToolStripMenuItem_Click);
            // 
            // удалитьСтрокуToolStripMenuItem
            // 
            this.удалитьСтрокуToolStripMenuItem.Name = "удалитьСтрокуToolStripMenuItem";
            this.удалитьСтрокуToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.удалитьСтрокуToolStripMenuItem.Text = "Удалить строку";
            this.удалитьСтрокуToolStripMenuItem.Click += new System.EventHandler(this.удалитьСтрокуToolStripMenuItem_Click);
            // 
            // включитьРедактированиеToolStripMenuItem
            // 
            this.включитьРедактированиеToolStripMenuItem.Name = "включитьРедактированиеToolStripMenuItem";
            this.включитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.включитьРедактированиеToolStripMenuItem.Text = "Включить редактирование";
            this.включитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.включитьРедактированиеToolStripMenuItem_Click);
            // 
            // выключитьРедактированиеToolStripMenuItem
            // 
            this.выключитьРедактированиеToolStripMenuItem.Name = "выключитьРедактированиеToolStripMenuItem";
            this.выключитьРедактированиеToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.выключитьРедактированиеToolStripMenuItem.Text = "Выключить редактирование";
            this.выключитьРедактированиеToolStripMenuItem.Click += new System.EventHandler(this.выключитьРедактированиеToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // TableOfWorker
            // 
            this.TableOfWorker.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.TableOfWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.ФИО,
            this.Приходит,
            this.Уходит,
            this.СрокСлужбы});
            this.TableOfWorker.Location = new System.Drawing.Point(0, 24);
            this.TableOfWorker.Name = "TableOfWorker";
            this.TableOfWorker.RowHeadersVisible = false;
            this.TableOfWorker.Size = new System.Drawing.Size(800, 240);
            this.TableOfWorker.TabIndex = 1;
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.Name = "N";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Приходит
            // 
            this.Приходит.HeaderText = "Приходит на работу";
            this.Приходит.Name = "Приходит";
            // 
            // Уходит
            // 
            this.Уходит.HeaderText = "Уходит";
            this.Уходит.Name = "Уходит";
            // 
            // СрокСлужбы
            // 
            this.СрокСлужбы.HeaderText = "Служит";
            this.СрокСлужбы.Name = "СрокСлужбы";
            // 
            // Otkat
            // 
            this.Otkat.BackColor = System.Drawing.Color.CadetBlue;
            this.Otkat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Otkat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otkat.ForeColor = System.Drawing.Color.LightYellow;
            this.Otkat.Location = new System.Drawing.Point(12, 367);
            this.Otkat.Name = "Otkat";
            this.Otkat.Size = new System.Drawing.Size(75, 30);
            this.Otkat.TabIndex = 24;
            this.Otkat.Text = "Откат";
            this.Otkat.UseVisualStyleBackColor = false;
            this.Otkat.Click += new System.EventHandler(this.Otkat_Click);
            // 
            // GoToPoisk
            // 
            this.GoToPoisk.BackColor = System.Drawing.Color.CadetBlue;
            this.GoToPoisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPoisk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToPoisk.ForeColor = System.Drawing.Color.LightYellow;
            this.GoToPoisk.Location = new System.Drawing.Point(12, 331);
            this.GoToPoisk.Name = "GoToPoisk";
            this.GoToPoisk.Size = new System.Drawing.Size(75, 30);
            this.GoToPoisk.TabIndex = 23;
            this.GoToPoisk.Text = "Поиск";
            this.GoToPoisk.UseVisualStyleBackColor = false;
            this.GoToPoisk.Click += new System.EventHandler(this.GoToPoisk_Click);
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.CadetBlue;
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.ForeColor = System.Drawing.Color.LightYellow;
            this.Filter.Location = new System.Drawing.Point(263, 395);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(141, 31);
            this.Filter.TabIndex = 22;
            this.Filter.Text = "От фильтровать";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // checkSkolkSlugit
            // 
            this.checkSkolkSlugit.AutoSize = true;
            this.checkSkolkSlugit.BackColor = System.Drawing.Color.CadetBlue;
            this.checkSkolkSlugit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSkolkSlugit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.checkSkolkSlugit.ForeColor = System.Drawing.Color.LightYellow;
            this.checkSkolkSlugit.Location = new System.Drawing.Point(263, 364);
            this.checkSkolkSlugit.Name = "checkSkolkSlugit";
            this.checkSkolkSlugit.Size = new System.Drawing.Size(82, 23);
            this.checkSkolkSlugit.TabIndex = 21;
            this.checkSkolkSlugit.Text = "Служит";
            this.checkSkolkSlugit.UseVisualStyleBackColor = false;
            this.checkSkolkSlugit.CheckedChanged += new System.EventHandler(this.checkSkolkSlugit_CheckedChanged);
            // 
            // checkUhod
            // 
            this.checkUhod.AutoSize = true;
            this.checkUhod.BackColor = System.Drawing.Color.CadetBlue;
            this.checkUhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkUhod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.checkUhod.ForeColor = System.Drawing.Color.LightYellow;
            this.checkUhod.Location = new System.Drawing.Point(263, 335);
            this.checkUhod.Name = "checkUhod";
            this.checkUhod.Size = new System.Drawing.Size(76, 23);
            this.checkUhod.TabIndex = 20;
            this.checkUhod.Text = "Уходит";
            this.checkUhod.UseVisualStyleBackColor = false;
            // 
            // checkKogrdaRabotat
            // 
            this.checkKogrdaRabotat.AutoSize = true;
            this.checkKogrdaRabotat.BackColor = System.Drawing.Color.CadetBlue;
            this.checkKogrdaRabotat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkKogrdaRabotat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.checkKogrdaRabotat.ForeColor = System.Drawing.Color.LightYellow;
            this.checkKogrdaRabotat.Location = new System.Drawing.Point(263, 306);
            this.checkKogrdaRabotat.Name = "checkKogrdaRabotat";
            this.checkKogrdaRabotat.Size = new System.Drawing.Size(167, 23);
            this.checkKogrdaRabotat.TabIndex = 19;
            this.checkKogrdaRabotat.Text = "Приходит на работу";
            this.checkKogrdaRabotat.UseVisualStyleBackColor = false;
            // 
            // checkFIO
            // 
            this.checkFIO.AutoSize = true;
            this.checkFIO.BackColor = System.Drawing.Color.CadetBlue;
            this.checkFIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFIO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.checkFIO.ForeColor = System.Drawing.Color.LightYellow;
            this.checkFIO.Location = new System.Drawing.Point(345, 335);
            this.checkFIO.Name = "checkFIO";
            this.checkFIO.Size = new System.Drawing.Size(63, 23);
            this.checkFIO.TabIndex = 18;
            this.checkFIO.Text = "ФИО";
            this.checkFIO.UseVisualStyleBackColor = false;
            // 
            // checkNomer
            // 
            this.checkNomer.AutoSize = true;
            this.checkNomer.BackColor = System.Drawing.Color.CadetBlue;
            this.checkNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.checkNomer.ForeColor = System.Drawing.Color.LightYellow;
            this.checkNomer.Location = new System.Drawing.Point(263, 277);
            this.checkNomer.Name = "checkNomer";
            this.checkNomer.Size = new System.Drawing.Size(72, 23);
            this.checkNomer.TabIndex = 17;
            this.checkNomer.Text = "Номер";
            this.checkNomer.UseVisualStyleBackColor = false;
            // 
            // WhatIchem
            // 
            this.WhatIchem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WhatIchem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhatIchem.ForeColor = System.Drawing.Color.LightYellow;
            this.WhatIchem.Location = new System.Drawing.Point(12, 305);
            this.WhatIchem.Name = "WhatIchem";
            this.WhatIchem.Size = new System.Drawing.Size(190, 20);
            this.WhatIchem.TabIndex = 16;
            // 
            // ZadniiFon
            // 
            this.ZadniiFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZadniiFon.Image = global::Turima.Properties.Resources._1505736488_00020;
            this.ZadniiFon.Location = new System.Drawing.Point(0, 0);
            this.ZadniiFon.Name = "ZadniiFon";
            this.ZadniiFon.Size = new System.Drawing.Size(800, 450);
            this.ZadniiFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ZadniiFon.TabIndex = 25;
            this.ZadniiFon.TabStop = false;
            // 
            // GraphWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Otkat);
            this.Controls.Add(this.GoToPoisk);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.checkSkolkSlugit);
            this.Controls.Add(this.checkUhod);
            this.Controls.Add(this.checkKogrdaRabotat);
            this.Controls.Add(this.checkFIO);
            this.Controls.Add(this.checkNomer);
            this.Controls.Add(this.WhatIchem);
            this.Controls.Add(this.TableOfWorker);
            this.Controls.Add(this.menuOfRabotnik);
            this.Controls.Add(this.ZadniiFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOfRabotnik;
            this.Name = "GraphWorker";
            this.Text = "График работы сотрудников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphWorker_FormClosing);
            this.Load += new System.EventHandler(this.GraphWorker_Load);
            this.menuOfRabotnik.ResumeLayout(false);
            this.menuOfRabotnik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOfRabotnik;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableOfWorker;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button Otkat;
        private System.Windows.Forms.Button GoToPoisk;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.CheckBox checkSkolkSlugit;
        private System.Windows.Forms.CheckBox checkUhod;
        private System.Windows.Forms.CheckBox checkKogrdaRabotat;
        private System.Windows.Forms.CheckBox checkFIO;
        private System.Windows.Forms.CheckBox checkNomer;
        private System.Windows.Forms.TextBox WhatIchem;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Приходит;
        private System.Windows.Forms.DataGridViewTextBoxColumn Уходит;
        private System.Windows.Forms.DataGridViewTextBoxColumn СрокСлужбы;
        private System.Windows.Forms.PictureBox ZadniiFon;
    }
}