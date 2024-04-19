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
    public partial class GraphOfFood : Form
    {
        bool YouSaveFile = false;
        string NameFileToLoad;
        public GraphOfFood()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem m in menuOfFood.Items)
            {
                SetWhiteColor(m);
            }
            menuOfFood.Renderer = new ToolStripProfessionalRenderer(new Cols());
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu main = new MainMenu();
            main.Show();
        }

        private void GraphOfFood_Load(object sender, EventArgs e)
        {
            TableOfFood.ReadOnly = true;
            TableOfFood.Rows.Clear();
            foreach (var line in File.ReadLines("SaveAllFood.txt"))
            {
                var array = line.Split();
                TableOfFood.Rows.Add(array);
            }
            try
            {
                TableOfFood.Rows.RemoveAt(TableOfFood.Rows.Count - 2);
            }
            catch
            {

            }
            TableOfFood.DefaultCellStyle.BackColor = Color.CadetBlue;
            TableOfFood.DefaultCellStyle.ForeColor = Color.LightYellow;
            TableOfFood.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            TableOfFood.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            TableOfFood.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumSpringGreen;
            TableOfFood.GridColor = Color.MediumSpringGreen;
            TableOfFood.EnableHeadersVisualStyles = false;

        }

        private void выключитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfFood.ReadOnly = true;
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfFood.Rows.Add();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfFood.Rows.Remove(TableOfFood.CurrentRow);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Посленюю строку не удалять!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void включитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOfFood.ReadOnly = false;
        }
        public void Save()
        {
            SaveFileDialog saveFileDialog5 = new SaveFileDialog();
            saveFileDialog5.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog5.ShowDialog() == DialogResult.OK)
            {
                NameFileToLoad = saveFileDialog5.FileName;
                YouSaveFile = true;
                StreamWriter file = new StreamWriter(saveFileDialog5.FileName);
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= TableOfFood.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= TableOfFood.Columns.Count - 1; c++)
                        {
                            sLine = sLine + TableOfFood.Rows[r].Cells[c].Value;
                            if (c != TableOfFood.Columns.Count - 1)
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
            StreamWriter file5 = new StreamWriter("SaveAllFood.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= TableOfFood.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= TableOfFood.Columns.Count - 1; c++)
                    {
                        if (TableOfFood.Rows[r].Cells[c].Value != null) TableOfFood.Rows[r].Cells[c].Value = TableOfFood.Rows[r].Cells[c].Value.ToString().Replace(" ", "");
                        sLine = sLine + TableOfFood.Rows[r].Cells[c].Value;
                        if (c != TableOfFood.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file5.WriteLine(sLine);
                    sLine = "";
                }

                file5.Close();
            }
            catch (Exception)
            { }
        }
        public void Download()
        {
            OpenFileDialog openFile5 = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить файл",
                FileName = "Текстовый файл",
                ShowHelp = true//показать Справку
            };
            if (openFile5.ShowDialog() == DialogResult.OK)
            {
                TableOfFood.Rows.Clear();
                foreach (var line in File.ReadLines(openFile5.FileName))
                {
                    var array = line.Split();
                    TableOfFood.Rows.Add(array);
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

        private void GraphOfFood_FormClosing(object sender, FormClosingEventArgs e)
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

        private void checkDateOfBern_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WhatIchem_TextChanged(object sender, EventArgs e)
        {

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

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GoToPoisk_Click(object sender, EventArgs e)
        {
            try
            {
                TableOfFood.ClearSelection();
                for (int i = 0; i < TableOfFood.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < TableOfFood.Columns.Count; j++)
                    {
                        if (TableOfFood.Rows[i].Cells[j].Value != null && TableOfFood.Rows[i].Cells[j].Visible == true)
                        {
                            if (TableOfFood.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text))
                            {
                                TableOfFood.Rows[i].Cells[j].Selected = true;
                                count++;
                            }
                        }
                    }
                    if (count == 0) TableOfFood.Rows[i].Visible = false;
                }
            }
            catch { }
        }

        private void Otkat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableOfFood.RowCount; i++)
            {

                TableOfFood.Rows[i].Visible = true;

            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (checkProducts.Checked == true)
                TableOfFood.Columns[0].Visible = false;
            else if (checkProducts.Checked == false)
                TableOfFood.Columns[0].Visible = true;

            if (checkData.Checked == true)
                TableOfFood.Columns[3].Visible = false;
            else if (checkData.Checked == false)
                TableOfFood.Columns[3].Visible = true;

            if (checkKolvo.Checked == true)
                TableOfFood.Columns[1].Visible = false;
            else if (checkKolvo.Checked == false)
                TableOfFood.Columns[1].Visible = true;

            if (checkSrok.Checked == true)
                TableOfFood.Columns[2].Visible = false;
            else if (checkSrok.Checked == false)
                TableOfFood.Columns[2].Visible = true;

            //if (checkNomerStatii.Checked == true)
            //    TableOfFood.Columns[4].Visible = false;
            //else if (checkNomerStatii.Checked == false)
            //    TableOfFood.Columns[4].Visible = true;
        }

        private void checkProducts_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


