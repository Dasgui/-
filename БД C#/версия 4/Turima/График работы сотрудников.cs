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
    public partial class GraphWorker : Form
    {
        bool YouSaveFile = false;
        string NameFileToLoad;
        public GraphWorker()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem m in menuOfRabotnik.Items)
            {
                SetWhiteColor(m);
            }
            menuOfRabotnik.Renderer = new ToolStripProfessionalRenderer(new Cols());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void GraphWorker_Load(object sender, EventArgs e)
        {
            TableOfWorker.ReadOnly = true;
            TableOfWorker.Rows.Clear();
            foreach (var line in File.ReadLines("SaveAllRabotnike.txt"))
            {
                var array = line.Split();
                TableOfWorker.Rows.Add(array);
            }
            try
            {
                TableOfWorker.Rows.RemoveAt(TableOfWorker.Rows.Count - 2);
            }
            catch
            {

            }
            TableOfWorker.DefaultCellStyle.BackColor = Color.CadetBlue;
            TableOfWorker.DefaultCellStyle.ForeColor = Color.LightYellow;
            TableOfWorker.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            TableOfWorker.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            TableOfWorker.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumSpringGreen;
            TableOfWorker.GridColor = Color.MediumSpringGreen;
            TableOfWorker.EnableHeadersVisualStyles = false;
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfWorker.Rows.Add();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfWorker.Rows.Remove(TableOfWorker.CurrentRow);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Посленюю строку не удалять!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void включитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfWorker.ReadOnly = false;
        }

        private void выключитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfWorker.ReadOnly = true;
        }

        private void GraphWorker_FormClosing(object sender, FormClosingEventArgs e)
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
        public void Save()
        {
            SaveFileDialog saveFileDialog4 = new SaveFileDialog();
            saveFileDialog4.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog4.ShowDialog() == DialogResult.OK)
            {
                NameFileToLoad = saveFileDialog4.FileName;
                YouSaveFile = true;
                StreamWriter file = new StreamWriter(saveFileDialog4.FileName);
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= TableOfWorker.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= TableOfWorker.Columns.Count - 1; c++)
                        {
                            sLine = sLine + TableOfWorker.Rows[r].Cells[c].Value;
                            if (c != TableOfWorker.Columns.Count - 1)
                            {
                                sLine = sLine + " ";
                            }
                        }
                        file.WriteLine(sLine);
                        sLine = "";
                    }

                    file.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            StreamWriter file4 = new StreamWriter("SaveAllRabotnike.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= TableOfWorker.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= TableOfWorker.Columns.Count - 1; c++)
                    {
                        if (TableOfWorker.Rows[r].Cells[c].Value != null) TableOfWorker.Rows[r].Cells[c].Value = TableOfWorker.Rows[r].Cells[c].Value.ToString().Replace(" ", "");
                        sLine = sLine + TableOfWorker.Rows[r].Cells[c].Value;
                        if (c != TableOfWorker.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file4.WriteLine(sLine);
                    sLine = "";
                }

                file4.Close();
            }
            catch (Exception)
            { }
        }
        public void Download()
        {
            OpenFileDialog openFile4 = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить файл",
                FileName = "Текстовый файл",
                ShowHelp = true//показать Справку
            };
            if (openFile4.ShowDialog() == DialogResult.OK)
            {
                TableOfWorker.Rows.Clear();
                foreach (var line in File.ReadLines(openFile4.FileName))
                {
                    var array = line.Split();
                    TableOfWorker.Rows.Add(array);
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

        private void GoToPoisk_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfWorker.ClearSelection();
                for (int i = 0; i < TableOfWorker.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < TableOfWorker.Columns.Count; j++)
                    {
                        if (TableOfWorker.Rows[i].Cells[j].Value != null && TableOfWorker.Rows[i].Cells[j].Visible == true)
                        {
                            if (TableOfWorker.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text))
                            {
                                TableOfWorker.Rows[i].Cells[j].Selected = true;
                                count++;
                            }
                        }
                    }
                    if (count == 0) TableOfWorker.Rows[i].Visible = false;
                }
            }
            catch { }
        }

        private void Otkat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfWorker.RowCount; i++)
            {

                TableOfWorker.Rows[i].Visible = true;

            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (checkNomer.Checked == true)
                TableOfWorker.Columns[0].Visible = false;
            else if (checkNomer.Checked == false)
                TableOfWorker.Columns[0].Visible = true;

            if (checkFIO.Checked == true)
                TableOfWorker.Columns[1].Visible = false;
            else if (checkFIO.Checked == false)
                TableOfWorker.Columns[1].Visible = true;

            if (checkKogrdaRabotat.Checked == true)
                TableOfWorker.Columns[2].Visible = false;
            else if (checkKogrdaRabotat.Checked == false)
                TableOfWorker.Columns[2].Visible = true;

            if (checkUhod.Checked == true)
                TableOfWorker.Columns[3].Visible = false;
            else if (checkUhod.Checked == false)
                TableOfWorker.Columns[3].Visible = true;

            if (checkSkolkSlugit.Checked == true)
                TableOfWorker.Columns[4].Visible = false;
            else if (checkSkolkSlugit.Checked == false)
                TableOfWorker.Columns[4].Visible = true;
        }

        private void checkSkolkSlugit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
