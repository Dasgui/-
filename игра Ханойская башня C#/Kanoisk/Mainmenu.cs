using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanoisk
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();

        }

        private void AboutMaider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "Создал: Каримов Матвей",
           "Об авторе",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void InformationAboutGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
           "Цель головоломки - переместить всю стопку до последнего стержня, соблюдая следующие правила:" +
           "\r1. Одновременно можно перемещать только один диск." +
           "\r2. Каждый ход состоит в том, чтобы взять верхний диск из одной из стопок и поместить его поверх другой стопки или на пустой стержень." +
           "\r3. Ни один диск не может быть помещен поверх диска, который меньше его.",
           "О самой игре",
           MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void mainGame_Click(object sender, EventArgs e)
        {
            MainGame game = new MainGame();
            this.Hide();
            game.Show();
        }

        private void ExitButten_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void Mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
