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
    public partial class BaseMurd : Form
    {
      bool YouSaveFile = false;
        string NameFileToLoad;
        public BaseMurd()
        {
            InitializeComponent();
            ////MenuOfMainInformation
            foreach (ToolStripMenuItem m in MenuOfMainInformation.Items)
            {
                SetWhiteColor(m);
            }
            MenuOfMainInformation.Renderer = new ToolStripProfessionalRenderer(new Cols());

        }

        private void BaseMurd_Load(object sender, EventArgs e)
        {
            //if (YouSaveFile == true)
            //{
            //    OpenFileDialog openFile = new OpenFileDialog();
            //    openFile.FileName = NameFileToLoad;
            //    //TableInformationMurders.RowCount = 15;
            //    foreach (var line in File.ReadLines(openFile.FileName))
            //    {
            //        var array = line.Split();
            //        TableInformationMurders.Rows.Add(array);
            //    }
            //}
            //TableInformationMurders.ReadOnly = true;
            TableInformationMurders.ReadOnly = true;
            TableInformationMurders.Rows.Clear();
           
                foreach (var line in File.ReadLines("SaveAllMurder.txt"))
                {
                    var array = line.Split();
                    TableInformationMurders.Rows.Add(array);
                }
                try
                {
                    TableInformationMurders.Rows.RemoveAt(TableInformationMurders.Rows.Count - 2);
                }
                catch
                {

                }
 
            TableInformationMurders.DefaultCellStyle.BackColor = Color.CadetBlue;
            TableInformationMurders.DefaultCellStyle.ForeColor = Color.LightYellow;
            TableInformationMurders.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            TableInformationMurders.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
            TableInformationMurders.ColumnHeadersDefaultCellStyle.ForeColor = Color.MediumSpringGreen;
            TableInformationMurders.GridColor = Color.MediumSpringGreen;
            TableInformationMurders.EnableHeadersVisualStyles = false;
            //this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath(Nadz.ico));





            //StreamWriter file = new StreamWriter("SaveAllMurder.txt");
            //try
            //{
            //    string sLine = "";

            //    //This for loop loops through each row in the table
            //    for (int r = 0; r <= TableInformationMurders.Rows.Count - 1; r++)
            //    {
            //        //This for loop loops through each column, and the row number
            //        //is passed from the for loop above.
            //        for (int c = 0; c <= TableInformationMurders.Columns.Count - 1; c++)
            //        {
            //            if (TableInformationMurders.Rows[r].Cells[c].Value != null) TableInformationMurders.Rows[r].Cells[c].Value = TableInformationMurders.Rows[r].Cells[c].Value.ToString().Replace(" ", "");
            //            sLine = sLine + TableInformationMurders.Rows[r].Cells[c].Value;
            //            if (c != TableInformationMurders.Columns.Count - 1)
            //            {
            //                //A comma is added as a text delimiter in order
            //                //to separate each field in the text file.
            //                //You can choose another character as a delimiter.
            //                sLine = sLine + " ";
            //            }
            //        }
            //        //The exported text is written to the text file, one line at a time.
            //        file.WriteLine(sLine);
            //        sLine = "";
            //    }

            //    file.Close();
            //}
            //catch (Exception)
            //{ }

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (YouSaveFile == true)
            //{
            this.Close();
            MainMenu main = new MainMenu();
            main.Show();

            //}
            //else if (YouSaveFile == false)
            //{
            //var res = MessageBox.Show("Сохраняться будим?", "А сохраниться?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //if (res == DialogResult.Yes && YouSaveFile != true)
            //{
            //    YouSaveFile = true;
            //    Save();
            //}
            //else
            //{
            //    this.Close();
            //    MainMenu main = new MainMenu();
            //    main.Show();
            //}
            //}
        }

        private void InformationMurders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void таблицаИдущихНаУДОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoToUDO gotoUDO = new GoToUDO();
            gotoUDO.Show();
        }

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableInformationMurders.Rows.Add();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TableInformationMurders.Rows.Remove(TableInformationMurders.CurrentRow);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Посленюю строку не удалять!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            

        }

        private void включитьсредактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableInformationMurders.ReadOnly = false;
        }

        private void выключитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableInformationMurders.ReadOnly = true;
        }

        private void фильтрацияИПоискToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    YouSaveFile = true;
            //    StreamWriter file = new StreamWriter(saveFileDialog.FileName);
            //    try
            //    {
            //        string sLine = "";
            //        for (int r = 0; r <= TableInformationMurders.Rows.Count - 1; r++)
            //        {
            //            for (int c = 0; c <= TableInformationMurders.Columns.Count - 1; c++)
            //            {
            //                sLine = sLine + TableInformationMurders.Rows[r].Cells[c].Value;
            //                if (c != TableInformationMurders.Columns.Count - 1)
            //                {
            //                    sLine = sLine + " ";
            //                }
            //            }
            //            file.WriteLine(sLine);
            //            sLine = "";
            //        }

            //        file.Close();

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}
            Save();

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Download();
            //OpenFileDialog openFile = new OpenFileDialog
            //{
            //    Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*",
            //    Title = "Загрузить файл",
            //    FileName = "Текстовый файл",
            //    ShowHelp = true//показать Справку
            //};
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
            //    TableInformationMurders.Rows.Clear();
            //    foreach (var line in File.ReadLines(openFile.FileName))
            //    {
            //        var array = line.Split();
            //        TableInformationMurders.Rows.Add(array);
            //    }
            //}

        }

        private void BaseMurd_FormClosing(object sender, FormClosingEventArgs e)
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
            //e.Cancel = !(res == DialogResult.Yes);
            
        }
        public void Save()
        {
            SaveFileDialog saveFileDialog3 = new SaveFileDialog();
            saveFileDialog3.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog3.ShowDialog() == DialogResult.OK)
            {
                NameFileToLoad = saveFileDialog3.FileName;
                YouSaveFile = true;
                StreamWriter file = new StreamWriter(saveFileDialog3.FileName);
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= TableInformationMurders.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= TableInformationMurders.Columns.Count - 1; c++)
                        {
                            sLine = sLine + TableInformationMurders.Rows[r].Cells[c].Value;
                            if (c != TableInformationMurders.Columns.Count - 1)
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
            StreamWriter file3 = new StreamWriter("SaveAllMurder.txt");
            try
            {
                string sLine = "";

                //This for loop loops through each row in the table
                for (int r = 0; r <= TableInformationMurders.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= TableInformationMurders.Columns.Count - 1; c++)
                    {
                        if (TableInformationMurders.Rows[r].Cells[c].Value != null) TableInformationMurders.Rows[r].Cells[c].Value = TableInformationMurders.Rows[r].Cells[c].Value.ToString().Replace(" ", "");
                        sLine = sLine + TableInformationMurders.Rows[r].Cells[c].Value;
                        if (c != TableInformationMurders.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + " ";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file3.WriteLine(sLine);
                    sLine = "";
                }

                file3.Close();
            }
            catch (Exception)
            { }
        }
        public void Download()
        {
            OpenFileDialog openFile3 = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*",
                Title = "Загрузить файл",
                FileName = "Текстовый файл",
                ShowHelp = true//показать Справку
            };
            if (openFile3.ShowDialog() == DialogResult.OK)
            {
                TableInformationMurders.Rows.Clear();
                foreach (var line in File.ReadLines(openFile3.FileName))
                {
                    var array = line.Split();
                    TableInformationMurders.Rows.Add(array);
                }
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void GoPoisk_Click(object sender, EventArgs e)
        {

        }

        private void WhatIchem_TextChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < TableInformationMurders.RowCount; i++)
            //{
            //    TableInformationMurders.Rows[i].Selected = false;
            //    for (int j = 0; j < TableInformationMurders.ColumnCount; j++)
            //        if (TableInformationMurders.Rows[i].Cells[j].Value != null)
            //            if (TableInformationMurders.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text)&& TableInformationMurders.Rows[i].Visible == true)
            //            {
            //                TableInformationMurders.Rows[i].Cells[j].Selected = true;

            //            }
            //    //else
            //    //    TableInformationMurders.Rows[i].Visible = false;
            //}
        }



        private void checkNomer_CheckedChanged(object sender, EventArgs e)
        {
            //TableInformationMurders.Columns[0].Visible = false;
            //if (checkNomer.Checked == false)
            //{
            //    TableInformationMurders.Columns[0].Visible = true;
            //}
        }

        private void checkFIO_CheckedChanged(object sender, EventArgs e)
        {
            //TableInformationMurders.Columns[2].Visible = false;
            //if (checkNomer.Checked == false)
            //{
            //    TableInformationMurders.Columns[2].Visible = true;
            //}
        }

        private void checkDateOfBern_CheckedChanged(object sender, EventArgs e)
        {
            //TableInformationMurders.Columns[2].Visible = false;
            //if (checkNomer.Checked == false)
            //{
            //    TableInformationMurders.Columns[2].Visible = true;
            //}
        }

        private void checkSrok_CheckedChanged(object sender, EventArgs e)
        {
            //TableInformationMurders.Columns[3].Visible = false;
            //if (checkNomer.Checked == false)
            //{
            //    TableInformationMurders.Columns[3].Visible = true;
            //}
        }

        private void checkNomerStatii_CheckedChanged(object sender, EventArgs e)
        {
            //TableInformationMurders.Columns[4].Visible = false;
            //if (checkNomer.Checked == false)
            //{
            //    TableInformationMurders.Columns[4].Visible = true;
            //}
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (checkNomer.Checked == true)
                TableInformationMurders.Columns[0].Visible = false;
            else if (checkNomer.Checked == false)
                TableInformationMurders.Columns[0].Visible = true;

            if (checkFIO.Checked == true)
                TableInformationMurders.Columns[1].Visible = false;
            else if (checkFIO.Checked == false)
                TableInformationMurders.Columns[1].Visible = true;

            if (checkDateOfBern.Checked == true)
                TableInformationMurders.Columns[2].Visible = false;
            else if (checkDateOfBern.Checked == false)
                TableInformationMurders.Columns[2].Visible = true;

            if (checkSrok.Checked == true)
                TableInformationMurders.Columns[3].Visible = false;
            else if (checkSrok.Checked == false)
                TableInformationMurders.Columns[3].Visible = true;

            if (checkNomerStatii.Checked == true)
                TableInformationMurders.Columns[4].Visible = false;
            else if (checkNomerStatii.Checked == false)
                TableInformationMurders.Columns[4].Visible = true;
        }

        private void GoToPoisk_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < TableInformationMurders.RowCount; i++)
            //{
            //    TableInformationMurders.Rows[i].Selected = false;
            //    for (int j = 0; j < TableInformationMurders.ColumnCount; j++)
            //        if (TableInformationMurders.Rows[i].Cells[j].Value != null)
            //            if (TableInformationMurders.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text) && TableInformationMurders.Rows[i].Visible == true)
            //            {
            //                TableInformationMurders.Rows[i].Cells[j].Selected = true;

            //            }
            //    //else
            //    //    TableInformationMurders.Rows[i].Visible = false;

            //}
            try
            {
                TableInformationMurders.ClearSelection();
                for (int i = 0; i < TableInformationMurders.Rows.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < TableInformationMurders.Columns.Count; j++)
                    {
                        if (TableInformationMurders.Rows[i].Cells[j].Value != null && TableInformationMurders.Rows[i].Cells[j].Visible == true)
                        {
                            if (TableInformationMurders.Rows[i].Cells[j].Value.ToString().Contains(WhatIchem.Text))
                            {
                                TableInformationMurders.Rows[i].Cells[j].Selected = true;
                                count++;
                            }
                        }
                    }
                    if (count == 0) TableInformationMurders.Rows[i].Visible = false;
                }
            }
            catch { }
        }

        private void Otkat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableInformationMurders.RowCount; i++)
            {
          
                    TableInformationMurders.Rows[i].Visible = true;

            }
        }

        private void MenuOfMainInformation_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
}
