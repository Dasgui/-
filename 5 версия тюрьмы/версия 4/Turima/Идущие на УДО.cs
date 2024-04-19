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

namespace Turima
{
    public partial class GoToUDO : Form
    {
        bool YouSaveFile = false;
        string NameFileToLoad;
        public GoToUDO()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem m in menuOfUDO.Items)
            {
                SetWhiteColor(m);
            }
            menuOfUDO.Renderer = new ToolStripProfessionalRenderer(new Cols());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseMurd baseMurd = new BaseMurd();
            baseMurd.Show();
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfUDO.Rows.Add();
        }

        private void TableOfUDO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfUDO.Rows.Remove(TableOfUDO.CurrentRow);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Посленюю строку не удалять!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void включитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfUDO.ReadOnly = false;
        }

        private void GoToUDO_Load(object sender, EventArgs e)
        {
            //TableOfUDO.RowCount = 15;
            TableOfUDO.ReadOnly = true;
            TableOfUDO.Rows.Clear();
            foreach (var line in File.ReadLines("SaveAllUDO.txt"))
            {
                var array = line.Split();
                TableOfUDO.Rows.Add(array);
            }
            try
            {
                TableOfUDO.Rows.RemoveAt(TableOfUDO.Rows.Count - 2);
            }
            catch
            {

            }
            TableOfUDO.DefaultCellStyle.BackColor = Color.CadetBlue;
            TableOfUDO.DefaultCellStyle.ForeColor = Color.LightYellow;
            TableOfUDO.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            TableOfUDO.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            TableOfUDO.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumSpringGreen;
            TableOfUDO.GridColor = Color.MediumSpringGreen;
            TableOfUDO.EnableHeadersVisualStyles = false;
        }

        private void выключитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfUDO.ReadOnly = true;
        }

        private void фильтрацияИПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void Save()
        {
            SaveFileDialog saveFileDialog6 = new SaveFileDialog();
            saveFileDialog6.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog6.ShowDialog() == DialogResult.OK)
            {
                NameFileToLoad = saveFileDialog6.FileName;
                YouSaveFile = true;
                StreamWriter file6 = new StreamWriter(saveFileDialog6.FileName);
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= TableOfUDO.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= TableOfUDO.Columns.Count - 1; c++)
                        {
                            sLine = sLine + TableOfUDO.Rows[r].Cells[c].Value;
                            if (c != TableOfUDO.Columns.Count - 1)
                            {
                                sLine = sLine + " ";
                            }
                        }
                        file6.WriteLine(sLine);
                        sLine = "";
                    }

                    file6.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            StreamWriter file2 = new StreamWriter("SaveAllUDO.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= TableOfUDO.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= TableOfUDO.Columns.Count - 1; c++)
                    {
                        if (TableOfUDO.Rows[r].Cells[c].Value != null) TableOfUDO.Rows[r].Cells[c].Value = TableOfUDO.Rows[r].Cells[c].Value.ToString().Replace(" ", "");
                        sLine = sLine + TableOfUDO.Rows[r].Cells[c].Value;
                        if (c != TableOfUDO.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file2.WriteLine(sLine);
                    sLine = "";
                }

                file2.Close();
            }
            catch (Exception)
            { }
        }
        public void Download()
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить файл",
                FileName = "Текстовый файл",
                ShowHelp = true//показать Справку
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                TableOfUDO.Rows.Clear();
                foreach (var line in File.ReadLines(openFile.FileName))
                {
                    var array = line.Split();
                    TableOfUDO.Rows.Add(array);
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void GoToUDO_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (YouSaveFile == false)
            {
                var res = MessageBox.Show("Сохраняться будим?", "А сохраниться?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes && YouSaveFile != true)
                {
                    YouSaveFile = true;
                    Save();
                }
            }
        }

        private void checkNomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Otkat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfUDO.RowCount; i++)
            {

                TableOfUDO.Rows[i].Visible = true;

            }
        }

        private void checkFIO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkStatia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (checkNomer.Checked == true)
                TableOfUDO.Columns[0].Visible = false;
            else if (checkNomer.Checked == false)
                TableOfUDO.Columns[0].Visible = true;

            if (checkFIO.Checked == true)
                TableOfUDO.Columns[1].Visible = false;
            else if (checkFIO.Checked == false)
                TableOfUDO.Columns[1].Visible = true;
            if (checkStatia.Checked == true)
                TableOfUDO.Columns[2].Visible = false;
            else if (checkStatia.Checked == false)
                TableOfUDO.Columns[2].Visible = true;
            

            //if (checkKogdaSel.Checked == true)
            //    TableOfUDO.Columns[4].Visible = false;
            //else if (checkKogdaSel.Checked == false)
            //    TableOfUDO.Columns[4].Visible = true;
            if (checkKogdaSel.Checked == true)
                TableOfUDO.Columns[3].Visible = false;
            else if (checkKogdaSel.Checked == false)
                TableOfUDO.Columns[3].Visible = true;
            if (checkKogrdaExit.Checked == true)
                TableOfUDO.Columns[4].Visible = false;
            else if (checkKogrdaExit.Checked == false)
                TableOfUDO.Columns[4].Visible = true;
        }

        private void GoToPoisk_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfUDO.ClearSelection();
                for (int i = 0; i < TableOfUDO.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < TableOfUDO.Columns.Count; j++)
                    {
                        if (TableOfUDO.Rows[i].Cells[j].Value != null && TableOfUDO.Rows[i].Cells[j].Visible == true)
                        {
                            if (TableOfUDO.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text))
                            {
                                TableOfUDO.Rows[i].Cells[j].Selected = true;
                                count++;
                            }
                        }
                    }
                    if (count == 0) TableOfUDO.Rows[i].Visible = false;
                }
            }
            catch { }
        }
        private void SetWhiteColor(ToolStripMenuItem item)
        {
            item.ForeColor = Color.White;
            foreach (ToolStripMenuItem it in item.DropDownItems)
            {
                SetWhiteColor(it);
            }
        }
        public class Cols : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                // 51, 153, 255 - устанавливаем голубой цвет выбранного элемента
                // (или задаете свой)
                get { return Color.SeaGreen; }
            }

            public override Color ToolStripDropDownBackground
            {
                get { return Color.DarkSlateGray; }
            }

            public override Color ImageMarginGradientBegin
            {
                get { return Color.DarkSlateGray; }
            }

            public override Color ImageMarginGradientEnd
            {
                get { return Color.DarkSlateGray; }
            }

            public override Color ImageMarginGradientMiddle
            {
                get { return Color.DarkSlateGray; }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.SeaGreen; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.SeaGreen; }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get { return Color.SeaGreen; }
            }

            public override Color MenuItemPressedGradientMiddle
            {
                get { return Color.SeaGreen; }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get { return Color.SeaGreen; }
            }

            public override Color MenuItemBorder
            {
                get { return Color.SeaGreen; }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkKogrdaExit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkKogdaSel_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}
