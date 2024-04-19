
namespace Turima
{
    partial class GoToUDO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoToUDO));
            this.menuOfUDO = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСтрокуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРедактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableOfUDO = new System.Windows.Forms.DataGridView();
            this.Номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Статья = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.СелКогда = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ВыйдетПоУдо = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.Button();
            this.checkKogdaSel = new System.Windows.Forms.CheckBox();
            this.checkStatia = new System.Windows.Forms.CheckBox();
            this.checkFIO = new System.Windows.Forms.CheckBox();
            this.checkNomer = new System.Windows.Forms.CheckBox();
            this.Otkat = new System.Windows.Forms.Button();
            this.GoToPoisk = new System.Windows.Forms.Button();
            this.WhatIchem = new System.Windows.Forms.TextBox();
            this.ZadniiFon = new System.Windows.Forms.PictureBox();
            this.checkKogrdaExit = new System.Windows.Forms.CheckBox();
            this.menuOfUDO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfUDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuOfUDO
            // 
            this.menuOfUDO.BackColor = System.Drawing.Color.DarkCyan;
            this.menuOfUDO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuOfUDO.Location = new System.Drawing.Point(0, 0);
            this.menuOfUDO.Name = "menuOfUDO";
            this.menuOfUDO.Size = new System.Drawing.Size(800, 24);
            this.menuOfUDO.TabIndex = 0;
            this.menuOfUDO.Text = "menuStrip1";
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
            this.редактированиеToolStripMenuItem.Click += new System.EventHandler(this.редактированиеToolStripMenuItem_Click);
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
            // TableOfUDO
            // 
            this.TableOfUDO.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.TableOfUDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfUDO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер,
            this.ФИО,
            this.Статья,
            this.СелКогда,
            this.ВыйдетПоУдо});
            this.TableOfUDO.Location = new System.Drawing.Point(0, 24);
            this.TableOfUDO.Name = "TableOfUDO";
            this.TableOfUDO.RowHeadersVisible = false;
            this.TableOfUDO.Size = new System.Drawing.Size(800, 240);
            this.TableOfUDO.TabIndex = 1;
            this.TableOfUDO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableOfUDO_CellContentClick);
            // 
            // Номер
            // 
            this.Номер.HeaderText = "N";
            this.Номер.Name = "Номер";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "ФИО";
            this.ФИО.Name = "ФИО";
            // 
            // Статья
            // 
            this.Статья.HeaderText = "Статья";
            this.Статья.Name = "Статья";
            // 
            // СелКогда
            // 
            this.СелКогда.HeaderText = "Когда сел";
            this.СелКогда.Name = "СелКогда";
            // 
            // ВыйдетПоУдо
            // 
            this.ВыйдетПоУдо.HeaderText = "Когда выйдет";
            this.ВыйдетПоУдо.Name = "ВыйдетПоУдо";
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
            // checkKogdaSel
            // 
            this.checkKogdaSel.AutoSize = true;
            this.checkKogdaSel.BackColor = System.Drawing.Color.CadetBlue;
            this.checkKogdaSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkKogdaSel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkKogdaSel.ForeColor = System.Drawing.Color.LightYellow;
            this.checkKogdaSel.Location = new System.Drawing.Point(263, 338);
            this.checkKogdaSel.Name = "checkKogdaSel";
            this.checkKogdaSel.Size = new System.Drawing.Size(94, 23);
            this.checkKogdaSel.TabIndex = 21;
            this.checkKogdaSel.Text = "Когда сел";
            this.checkKogdaSel.UseVisualStyleBackColor = false;
            this.checkKogdaSel.CheckedChanged += new System.EventHandler(this.checkKogdaSel_CheckedChanged);
            // 
            // checkStatia
            // 
            this.checkStatia.AutoSize = true;
            this.checkStatia.BackColor = System.Drawing.Color.CadetBlue;
            this.checkStatia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStatia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkStatia.ForeColor = System.Drawing.Color.LightYellow;
            this.checkStatia.Location = new System.Drawing.Point(263, 306);
            this.checkStatia.Name = "checkStatia";
            this.checkStatia.Size = new System.Drawing.Size(77, 23);
            this.checkStatia.TabIndex = 20;
            this.checkStatia.Text = "Статья";
            this.checkStatia.UseVisualStyleBackColor = false;
            this.checkStatia.CheckedChanged += new System.EventHandler(this.checkStatia_CheckedChanged);
            // 
            // checkFIO
            // 
            this.checkFIO.AutoSize = true;
            this.checkFIO.BackColor = System.Drawing.Color.CadetBlue;
            this.checkFIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkFIO.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFIO.ForeColor = System.Drawing.Color.LightYellow;
            this.checkFIO.Location = new System.Drawing.Point(346, 306);
            this.checkFIO.Name = "checkFIO";
            this.checkFIO.Size = new System.Drawing.Size(63, 23);
            this.checkFIO.TabIndex = 18;
            this.checkFIO.Text = "ФИО";
            this.checkFIO.UseVisualStyleBackColor = false;
            this.checkFIO.CheckedChanged += new System.EventHandler(this.checkFIO_CheckedChanged);
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
            this.checkNomer.TabIndex = 17;
            this.checkNomer.Text = "Номер";
            this.checkNomer.UseVisualStyleBackColor = false;
            this.checkNomer.CheckedChanged += new System.EventHandler(this.checkNomer_CheckedChanged);
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
            this.Otkat.TabIndex = 27;
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
            this.GoToPoisk.TabIndex = 26;
            this.GoToPoisk.Text = "Поиск";
            this.GoToPoisk.UseVisualStyleBackColor = false;
            this.GoToPoisk.Click += new System.EventHandler(this.GoToPoisk_Click);
            // 
            // WhatIchem
            // 
            this.WhatIchem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WhatIchem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WhatIchem.ForeColor = System.Drawing.Color.LightYellow;
            this.WhatIchem.Location = new System.Drawing.Point(12, 305);
            this.WhatIchem.Name = "WhatIchem";
            this.WhatIchem.Size = new System.Drawing.Size(190, 20);
            this.WhatIchem.TabIndex = 25;
            // 
            // ZadniiFon
            // 
            this.ZadniiFon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZadniiFon.Image = global::Turima.Properties.Resources._1505736488_00020;
            this.ZadniiFon.Location = new System.Drawing.Point(0, 0);
            this.ZadniiFon.Name = "ZadniiFon";
            this.ZadniiFon.Size = new System.Drawing.Size(800, 450);
            this.ZadniiFon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ZadniiFon.TabIndex = 28;
            this.ZadniiFon.TabStop = false;
            this.ZadniiFon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkKogrdaExit
            // 
            this.checkKogrdaExit.AutoSize = true;
            this.checkKogrdaExit.BackColor = System.Drawing.Color.CadetBlue;
            this.checkKogrdaExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkKogrdaExit.ForeColor = System.Drawing.Color.LightYellow;
            this.checkKogrdaExit.Location = new System.Drawing.Point(263, 367);
            this.checkKogrdaExit.Name = "checkKogrdaExit";
            this.checkKogrdaExit.Size = new System.Drawing.Size(128, 23);
            this.checkKogrdaExit.TabIndex = 29;
            this.checkKogrdaExit.Text = "Когда выйдет";
            this.checkKogrdaExit.UseVisualStyleBackColor = false;
            this.checkKogrdaExit.CheckedChanged += new System.EventHandler(this.checkKogrdaExit_CheckedChanged);
            // 
            // GoToUDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkKogrdaExit);
            this.Controls.Add(this.Otkat);
            this.Controls.Add(this.GoToPoisk);
            this.Controls.Add(this.WhatIchem);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.checkKogdaSel);
            this.Controls.Add(this.checkStatia);
            this.Controls.Add(this.checkFIO);
            this.Controls.Add(this.checkNomer);
            this.Controls.Add(this.TableOfUDO);
            this.Controls.Add(this.menuOfUDO);
            this.Controls.Add(this.ZadniiFon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuOfUDO;
            this.Name = "GoToUDO";
            this.Text = "Идущие на УДО";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoToUDO_FormClosing);
            this.Load += new System.EventHandler(this.GoToUDO_Load);
            this.menuOfUDO.ResumeLayout(false);
            this.menuOfUDO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfUDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZadniiFon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOfUDO;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridView TableOfUDO;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСтрокуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьРедактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.CheckBox checkKogdaSel;
        private System.Windows.Forms.CheckBox checkStatia;
        private System.Windows.Forms.CheckBox checkFIO;
        private System.Windows.Forms.CheckBox checkNomer;
        private System.Windows.Forms.Button Otkat;
        private System.Windows.Forms.Button GoToPoisk;
        private System.Windows.Forms.TextBox WhatIchem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Статья;
        private System.Windows.Forms.DataGridViewTextBoxColumn СелКогда;
        private System.Windows.Forms.DataGridViewTextBoxColumn ВыйдетПоУдо;
        private System.Windows.Forms.PictureBox ZadniiFon;
        private System.Windows.Forms.CheckBox checkKogrdaExit;
    }
}