using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turima
{
    public partial class MainMenu : Form
    {
        BaseMurd BaseMurd = new BaseMurd();

        public MainMenu()
        {
            InitializeComponent();

        }

        private void BaseOfMurder_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseMurd.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void FoodInput_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraphOfFood graphOfFood = new GraphOfFood();
            graphOfFood.Show();
        }

        private void GraphOfWorker_Click(object sender, EventArgs e)
        {
            this.Hide();
            GraphWorker graphWorker = new GraphWorker();
            graphWorker.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void InformationOfOrganaiz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Организация занимается удержанием и исправлением заключенных"+"\n"+"ФИО Руководителя: Маслаков Ваномас Намазович"+"\n"+"Телефон отдела кадров: +7999565445","Об организации",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InformationOfProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Год создания: 2022" + "\n" + "Создал: Каримов Матвей", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void NameOfProekt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
