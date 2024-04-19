
namespace Turima
{
    partial class BaseMurd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMurd));
            this.TableInformationMurders = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаРождения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Срок = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.НомерСтатьи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuOfMainInformation = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаИдущихНаУДОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьсредактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WhatIchem = new System.Windows.Forms.TextBox();
            this.checkNomer = new System.Windows.Forms.CheckBox();
            this.checkFIO = new System.Windows.Forms.CheckBox();
            this.checkDateOfBern = new System.Windows.Forms.CheckBox();
            this.checkSrok = new System.Windows.Forms.CheckBox();
            this.checkNomerStatii = new System.Windows.Forms.CheckBox();
            this.Filter = new System.Windows.Forms.Button();
            this.GoToPoisk = new System.Windows.Forms.Button();
            this.Otkat = new System.Windows.Forms.Button();
            this.ZadniiFon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableInformationMurders)).BeginInit();
            this.MenuOfMainInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).BeginInit();
            this.SuspendLayout();
            // 
            // TableInformationMurders
            // 
            this.TableInformationMurders.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableInformationMurders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableInformationMurders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableInformationMurders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.ФИО,
            this.ДатаРождения,
            this.Срок,
            this.НомерСтатьи});
            this.TableInformationMurders.Location = new System.Drawing.Point(0, 24);
            this.TableInformationMurders.Name = "TableInformationMurders";
            this.TableInformationMurders.RowHeadersVisible = false;
            this.TableInformationMurders.Size = new System.Drawing.Size(800, 240);
            this.TableInformationMurders.TabIndex = 0;
            this.TableInformationMurders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InformationMurders_CellContentClick);
            // 
            // Номер
            // 
            this.Номер.HeaderText = "№";
            this.Номер.Name = "Номер";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // ДатаРождения
            // 
            this.ДатаРождения.HeaderText = "Дата рождения";
            this.ДатаРождения.Name = "ДатаРождения";
            // 
            // Срок
            // 
            this.Срок.HeaderText = "Срок";
            this.Срок.Name = "Срок";
            // 
            // НомерСтатьи
            // 
            this.НомерСтатьи.HeaderText = "№ статьи";
            this.НомерСтатьи.Name = "НомерСтатьи";
            // 
            // MenuOfMainInformation
            // 
            this.MenuOfMainInformation.BackColor = System.Drawing.Color.DarkCyan;
            this.MenuOfMainInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.таблицаИдущихНаУДОToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.MenuOfMainInformation.Location = new System.Drawing.Point(0, 0);
            this.MenuOfMainInformation.Name = "MenuOfMainInformation";
            this.MenuOfMainInformation.Size = new System.Drawing.Size(800, 24);
            this.MenuOfMainInformation.TabIndex = 1;
            this.MenuOfMainInformation.Text = "menuStrip1";
            this.MenuOfMainInformation.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuOfMainInformation_ItemClicked);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
            this.выходToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицаИдущихНаУДОToolStripMenuItem
            // 
            this.таблицаИдущихНаУДОToolStripMenuItem.ForeColor = System.Drawing.Color.Azure;
            this.таблицаИдущихНаУДОToolStripMenuItem.Name = "таблицаИдущихНаУДОToolStripMenuItem";
            this.таблицаИдущихНаУДОToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.таблицаИдущихНаУДОToolStripMenuItem.Text = "Таблица идущих на УДО";
            this.таблицаИдущихНаУДОToolStripMenuItem.Click += new System.EventHandler(this.таблицаИдущихНаУДОToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСтрокуToolStripMenuItem,
            this.удалитьСтрокуToolStripMenuItem,
            this.включитьсредактированиеToolStripMenuItem,
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
            // включитьсредактированиеToolStripMenuItem
            // 
            this.включитьсредактированиеToolStripMenuItem.Name = "включитьсредактированиеToolStripMenuItem";
            this.включитьсредактированиеToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.включитьсредактированиеToolStripMenuItem.Text = "Включить редактирование";
            this.включитьсредактированиеToolStripMenuItem.Click += new System.EventHandler(this.включитьсредактированиеToolStripMenuItem_Click);
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
            // WhatIchem
            // 
            this.WhatIchem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WhatIchem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhatIchem.ForeColor = System.Drawing.Color.LightYellow;
            this.WhatIchem.Location = new System.Drawing.Point(12, 305);
            this.WhatIchem.Name = "WhatIchem";
            this.WhatIchem.Size = new System.Drawing.Size(190, 20);
            this.WhatIchem.TabIndex = 2;
            this.WhatIchem.TextChanged += new System.EventHandler(this.WhatIchem_TextChanged);
            // 
            // checkNomer
            // 
            this.checkNomer.AutoSize = true;
            this.checkNomer.BackColor = System.Drawing.Color.CadetBlue;
            this.checkNomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNomer.ForeColor = System.Drawing.Color.LightYellow;
            this.checkNomer.Location = new System.Drawing.Point(263, 277);
            this.checkNomer.Name = "checkNomer";
            this.checkNomer.Size = new System.Drawing.Size(72, 23);
            this.checkNomer.TabIndex = 8;
            this.checkNomer.Text = "Номер";
            this.checkNomer.UseVisualStyleBackColor = false;
            this.checkNomer.CheckedChanged += new System.EventHandler(this.checkNomer_CheckedChanged);
            // 
            // checkFIO
            // 
            this.checkFIO.AutoSize = true;
            this.checkFIO.BackColor = System.Drawing.Color.CadetBlue;
            this.checkFIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFIO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFIO.ForeColor = System.Drawing.Color.LightYellow;
            this.checkFIO.Location = new System.Drawing.Point(335, 335);
            this.checkFIO.Name = "checkFIO";
            this.checkFIO.Size = new System.Drawing.Size(63, 23);
            this.checkFIO.TabIndex = 9;
            this.checkFIO.Text = "ФИО";
            this.checkFIO.UseVisualStyleBackColor = false;
            this.checkFIO.CheckedChanged += new System.EventHandler(this.checkFIO_CheckedChanged);
            // 
            // checkDateOfBern
            // 
            this.checkDateOfBern.AutoSize = true;
            this.checkDateOfBern.BackColor = System.Drawing.Color.CadetBlue;
            this.checkDateOfBern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkDateOfBern.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDateOfBern.ForeColor = System.Drawing.Color.LightYellow;
            this.checkDateOfBern.Location = new System.Drawing.Point(263, 306);
            this.checkDateOfBern.Name = "checkDateOfBern";
            this.checkDateOfBern.Size = new System.Drawing.Size(135, 23);
            this.checkDateOfBern.TabIndex = 10;
            this.checkDateOfBern.Text = "Дата рождения";
            this.checkDateOfBern.UseVisualStyleBackColor = false;
            this.checkDateOfBern.CheckedChanged += new System.EventHandler(this.checkDateOfBern_CheckedChanged);
            // 
            // checkSrok
            // 
            this.checkSrok.AutoSize = true;
            this.checkSrok.BackColor = System.Drawing.Color.CadetBlue;
            this.checkSrok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSrok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSrok.ForeColor = System.Drawing.Color.LightYellow;
            this.checkSrok.Location = new System.Drawing.Point(263, 335);
            this.checkSrok.Name = "checkSrok";
            this.checkSrok.Size = new System.Drawing.Size(61, 23);
            this.checkSrok.TabIndex = 11;
            this.checkSrok.Text = "Срок";
            this.checkSrok.UseVisualStyleBackColor = false;
            this.checkSrok.CheckedChanged += new System.EventHandler(this.checkSrok_CheckedChanged);
            // 
            // checkNomerStatii
            // 
            this.checkNomerStatii.AutoSize = true;
            this.checkNomerStatii.BackColor = System.Drawing.Color.CadetBlue;
            this.checkNomerStatii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkNomerStatii.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkNomerStatii.ForeColor = System.Drawing.Color.LightYellow;
            this.checkNomerStatii.Location = new System.Drawing.Point(263, 364);
            this.checkNomerStatii.Name = "checkNomerStatii";
            this.checkNomerStatii.Size = new System.Drawing.Size(124, 23);
            this.checkNomerStatii.TabIndex = 12;
            this.checkNomerStatii.Text = "Номер статьи";
            this.checkNomerStatii.UseVisualStyleBackColor = false;
            this.checkNomerStatii.CheckedChanged += new System.EventHandler(this.checkNomerStatii_CheckedChanged);
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
            this.Filter.TabIndex = 13;
            this.Filter.Text = "От фильтровать";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
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
            this.GoToPoisk.TabIndex = 14;
            this.GoToPoisk.Text = "Поиск";
            this.GoToPoisk.UseVisualStyleBackColor = false;
            this.GoToPoisk.Click += new System.EventHandler(this.GoToPoisk_Click);
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
            this.Otkat.TabIndex = 15;
            this.Otkat.Text = "Откат";
            this.Otkat.UseVisualStyleBackColor = false;
            this.Otkat.Click += new System.EventHandler(this.Otkat_Click);
            // 
            // ZadniiFon
            // 
            this.ZadniiFon.Image = global::Turima.Properties.Resources._1505736488_00020;
            this.ZadniiFon.Location = new System.Drawing.Point(0, 0);
            this.ZadniiFon.Name = "ZadniiFon";
            this.ZadniiFon.Size = new System.Drawing.Size(800, 450);
            this.ZadniiFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ZadniiFon.TabIndex = 16;
            this.ZadniiFon.TabStop = false;
            // 
            // BaseMurd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Otkat);
            this.Controls.Add(this.GoToPoisk);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.checkNomerStatii);
            this.Controls.Add(this.checkSrok);
            this.Controls.Add(this.checkDateOfBern);
            this.Controls.Add(this.checkFIO);
            this.Controls.Add(this.checkNomer);
            this.Controls.Add(this.WhatIchem);
            this.Controls.Add(this.TableInformationMurders);
            this.Controls.Add(this.MenuOfMainInformation);
            this.Controls.Add(this.ZadniiFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuOfMainInformation;
            this.Name = "BaseMurd";
            this.Text = "Основная информация о заключенных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseMurd_FormClosing);
            this.Load += new System.EventHandler(this.BaseMurd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableInformationMurders)).EndInit();
            this.MenuOfMainInformation.ResumeLayout(false);
            this.MenuOfMainInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableInformationMurders;
        private System.Windows.Forms.MenuStrip MenuOfMainInformation;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаИдущихНаУДОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьсредактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.TextBox WhatIchem;
        private System.Windows.Forms.CheckBox checkNomer;
        private System.Windows.Forms.CheckBox checkFIO;
        private System.Windows.Forms.CheckBox checkDateOfBern;
        private System.Windows.Forms.CheckBox checkSrok;
        private System.Windows.Forms.CheckBox checkNomerStatii;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button GoToPoisk;
        private System.Windows.Forms.Button Otkat;
        private System.Windows.Forms.PictureBox ZadniiFon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаРождения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Срок;
        private System.Windows.Forms.DataGridViewTextBoxColumn НомерСтатьи;
    }
}