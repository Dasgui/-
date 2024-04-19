
namespace Turima
{
    partial class GraphOfFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphOfFood));
            this.menuOfFood = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableOfFood = new System.Windows.Forms.DataGridView();
            this.Продукт = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СрокХранения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ДатаПривозки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkat = new System.Windows.Forms.Button();
            this.GoToPoisk = new System.Windows.Forms.Button();
            this.Filter = new System.Windows.Forms.Button();
            this.checkSrok = new System.Windows.Forms.CheckBox();
            this.checkKolvo = new System.Windows.Forms.CheckBox();
            this.checkData = new System.Windows.Forms.CheckBox();
            this.checkProducts = new System.Windows.Forms.CheckBox();
            this.WhatIchem = new System.Windows.Forms.TextBox();
            this.ZadniiFon = new System.Windows.Forms.PictureBox();
            this.menuOfFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOfFood
            // 
            this.menuOfFood.BackColor = System.Drawing.Color.DarkCyan;
            this.menuOfFood.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuOfFood.Location = new System.Drawing.Point(0, 0);
            this.menuOfFood.Name = "menuOfFood";
            this.menuOfFood.Size = new System.Drawing.Size(800, 24);
            this.menuOfFood.TabIndex = 0;
            this.menuOfFood.Text = "menuStrip1";
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
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.BackColor = System.Drawing.Color.DarkCyan;
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
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
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
            // TableOfFood
            // 
            this.TableOfFood.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.TableOfFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Продукт,
            this.Количество,
            this.СрокХранения,
            this.ДатаПривозки});
            this.TableOfFood.Location = new System.Drawing.Point(0, 24);
            this.TableOfFood.Name = "TableOfFood";
            this.TableOfFood.RowHeadersVisible = false;
            this.TableOfFood.Size = new System.Drawing.Size(800, 240);
            this.TableOfFood.TabIndex = 1;
            // 
            // Продукт
            // 
            this.Продукт.HeaderText = "Продукты";
            this.Продукт.Name = "Продукт";
            // 
            // Количество
            // 
            this.Количество.HeaderText = "Количество";
            this.Количество.Name = "Количество";
            // 
            // СрокХранения
            // 
            this.СрокХранения.HeaderText = "Срок хранения";
            this.СрокХранения.Name = "СрокХранения";
            // 
            // ДатаПривозки
            // 
            this.ДатаПривозки.HeaderText = "Дата Привозки";
            this.ДатаПривозки.Name = "ДатаПривозки";
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
            this.checkSrok.TabIndex = 20;
            this.checkSrok.Text = "Срок";
            this.checkSrok.UseVisualStyleBackColor = false;
            // 
            // checkKolvo
            // 
            this.checkKolvo.AutoSize = true;
            this.checkKolvo.BackColor = System.Drawing.Color.CadetBlue;
            this.checkKolvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkKolvo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkKolvo.ForeColor = System.Drawing.Color.LightYellow;
            this.checkKolvo.Location = new System.Drawing.Point(263, 306);
            this.checkKolvo.Name = "checkKolvo";
            this.checkKolvo.Size = new System.Drawing.Size(111, 23);
            this.checkKolvo.TabIndex = 19;
            this.checkKolvo.Text = "Количество";
            this.checkKolvo.UseVisualStyleBackColor = false;
            this.checkKolvo.CheckedChanged += new System.EventHandler(this.checkDateOfBern_CheckedChanged);
            // 
            // checkData
            // 
            this.checkData.AutoSize = true;
            this.checkData.BackColor = System.Drawing.Color.CadetBlue;
            this.checkData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkData.ForeColor = System.Drawing.Color.LightYellow;
            this.checkData.Location = new System.Drawing.Point(335, 335);
            this.checkData.Name = "checkData";
            this.checkData.Size = new System.Drawing.Size(60, 23);
            this.checkData.TabIndex = 18;
            this.checkData.Text = "Дата";
            this.checkData.UseVisualStyleBackColor = false;
            // 
            // checkProducts
            // 
            this.checkProducts.AutoSize = true;
            this.checkProducts.BackColor = System.Drawing.Color.CadetBlue;
            this.checkProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkProducts.ForeColor = System.Drawing.Color.LightYellow;
            this.checkProducts.Location = new System.Drawing.Point(263, 277);
            this.checkProducts.Name = "checkProducts";
            this.checkProducts.Size = new System.Drawing.Size(99, 23);
            this.checkProducts.TabIndex = 17;
            this.checkProducts.Text = "Продукты";
            this.checkProducts.UseVisualStyleBackColor = false;
            this.checkProducts.CheckedChanged += new System.EventHandler(this.checkProducts_CheckedChanged);
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
            this.WhatIchem.TextChanged += new System.EventHandler(this.WhatIchem_TextChanged);
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
            // GraphOfFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Otkat);
            this.Controls.Add(this.GoToPoisk);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.checkSrok);
            this.Controls.Add(this.checkKolvo);
            this.Controls.Add(this.checkData);
            this.Controls.Add(this.checkProducts);
            this.Controls.Add(this.WhatIchem);
            this.Controls.Add(this.TableOfFood);
            this.Controls.Add(this.menuOfFood);
            this.Controls.Add(this.ZadniiFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOfFood;
            this.Name = "GraphOfFood";
            this.Text = "График поставки еды";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphOfFood_FormClosing);
            this.Load += new System.EventHandler(this.GraphOfFood_Load);
            this.menuOfFood.ResumeLayout(false);
            this.menuOfFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOfFood;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableOfFood;
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
        private System.Windows.Forms.CheckBox checkSrok;
        private System.Windows.Forms.CheckBox checkKolvo;
        private System.Windows.Forms.CheckBox checkData;
        private System.Windows.Forms.CheckBox checkProducts;
        private System.Windows.Forms.TextBox WhatIchem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Продукт;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество;
        private System.Windows.Forms.DataGridViewTextBoxColumn СрокХранения;
        private System.Windows.Forms.DataGridViewTextBoxColumn ДатаПривозки;
        private System.Windows.Forms.PictureBox ZadniiFon;
    }
}