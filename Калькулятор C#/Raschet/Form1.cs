using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raschet
{
    public partial class Form1 : Form
    {
        public double tg /*ф жезл*/ = 0.328;
        public double Кав = 1.4;
        public double jэ = 1.4;
        double[] x0 = new double[5]; //0,258  0,081
        double[] r0 = new double[5];
        string[] Base_Znachen = new string[] { "10", "3", "1,2", "3000", "0,8", "3,3" };
        string[] Base_Znachen_2 = new string[] { "10", "2", "0,9", "3000", "0,85", "3,3" };
        string[] Base_Znachen_3 = new string[] { "10", "2", "0,397", "3000", "0,85", "3,3" };
        double[] Base_Qc = new double[] {150,37.5,37.5 };

        public double [] Qc_Mass = new double[5];
        public double [] Uн_Mass = new double[5];
        public double[] n_Mass = new double[5];
        public double[] Pmax_Mass = new double[5];
        public double[] Tmax_Mass = new double[5];
        public double[] cosф_Mass = new double[5];
        public double[] Lк_Mass = new double[5];
        public DataGridView[] Base_datagrid = new DataGridView[3]; 
        public Form1()
        {
            InitializeComponent();
        }
        public void Raschet_Pкл(System.Windows.Forms.Label label, double Pmax, double n)
        {
            label.Text = Convert.ToString(Pmax * n); //Pкл
        }

        public void Raschet_Sкл(System.Windows.Forms.Label label, System.Windows.Forms.Label Pкл, double cosф)
        {
            label.Text = Convert.ToString(Convert.ToDouble(Pкл.Text) / cosф); //Sкл
        }

        public void Raschet_Qmax(System.Windows.Forms.Label label, System.Windows.Forms.Label Sкл, System.Windows.Forms.Label Pкл)
        {
            label.Text = Convert.ToString(Math.Sqrt(Math.Pow((Convert.ToDouble(Sкл.Text)), 2) - Math.Pow((Convert.ToDouble(Pкл.Text)), 2))); //Qmax
        }

        public void Raschet_tgф(System.Windows.Forms.Label label, System.Windows.Forms.Label Qmax, System.Windows.Forms.Label Pкл)
        {
            label.Text = Convert.ToString(Convert.ToDouble(Qmax.Text) / Convert.ToDouble(Pкл.Text)); // 2,7 / 3,6 tgф
        }

        public void Raschet_Qc(System.Windows.Forms.Label label, System.Windows.Forms.Label Pкл, System.Windows.Forms.Label tgф)
        {
            label.Text = Convert.ToString(Math.Round(Convert.ToDouble(Pкл.Text) * (Convert.ToDouble(tgф.Text) - tg), 1)); //Qc
        }

        public void Raschet_nБСК(System.Windows.Forms.Label label, System.Windows.Forms.Label Qc, double Qc1)
        {
            label.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) / Qc1 / 10) * 10000)); // nБСК
        }

        public void Raschet_Qбск(System.Windows.Forms.Label label, System.Windows.Forms.Label Qc, System.Windows.Forms.Label nБСК)
        {
            label.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) * Convert.ToDouble(nБСК.Text)) / 10, 2)); // Qбск
        }

        public void Raschet_Q(System.Windows.Forms.Label label, System.Windows.Forms.Label Qmax, System.Windows.Forms.Label Qбск)
        {
            label.Text = Convert.ToString(Math.Round(Convert.ToDouble(Qmax.Text) - Convert.ToDouble(Qбск.Text), 2)); //Q
        }

        public void Raschet_Iном(System.Windows.Forms.Label label, System.Windows.Forms.Label Pкл, System.Windows.Forms.Label Q, double Uн)
        {
            label.Text = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow(Convert.ToDouble(Pкл.Text), 2) + Math.Pow(Convert.ToDouble(Q.Text), 2)) / (Math.Round(Math.Sqrt(3), 2) * Uн) * 1000));
        }

        public void Raschet_Fэ(System.Windows.Forms.Label label, System.Windows.Forms.Label Iном, double n, double jэ)
        {
            label.Text = Convert.ToString(Math.Round(Convert.ToDouble(Iном.Text) / (n * jэ), 2));
        }

        public void Raschet_R_delen_n(System.Windows.Forms.Label label, double r0, double Lк, double n)
        {
            label.Text = Convert.ToString(Math.Round((r0 * Lк) / n, 3));
        }

        public void Raschet_X_delen_n(System.Windows.Forms.Label label, double x0, double Lк, double n)
        {
            label.Text = Convert.ToString(Math.Round((x0 * Lк) / n, 3));
        }

        public void Raschet_Uк(System.Windows.Forms.Label label, System.Windows.Forms.Label Pкл, System.Windows.Forms.Label R_delen_n, System.Windows.Forms.Label Q, System.Windows.Forms.Label X_delen_n, double Uн)
        {
            label.Text = Convert.ToString(Math.Round((Convert.ToDouble(Pкл.Text) * Convert.ToDouble(R_delen_n.Text) + Convert.ToDouble(Q.Text) * Convert.ToDouble(X_delen_n.Text)) / Uн, 2));
        }

        public void Raschet_Uкл(System.Windows.Forms.Label label, System.Windows.Forms.Label Uк, double Uн)
        {
            label.Text = Convert.ToString(Math.Round(Convert.ToDouble(Uк.Text) / Uн, 2)) /*+ "%"*/;
        }

        public void Proverka_Iдоп(System.Windows.Forms.Label Iном, System.Windows.Forms.Label Iном_2, System.Windows.Forms.Label Iдоп, System.Windows.Forms.Label Ravenstvo)
        {
            Iном_2.Text = Iном.Text;
            if (Iдоп.Text == "...")
            {
                Otvet_Iдоп.Text = "К сожалению данные для этого провода отсутствуют";
                Otvet_Iдоп.Visible = true;
            }
            else
            {
                if (Convert.ToDouble(Iном_2.Text) >= Convert.ToDouble(Iдоп.Text))
                {
                    Ravenstvo.Text = ">=";
                }
                else if (Convert.ToDouble(Iном_2.Text) <= Convert.ToDouble(Iдоп.Text))
                {
                    Ravenstvo.Text = "=<";
                }
                else if (Convert.ToDouble(Iном_2.Text) == Convert.ToDouble(Iдоп.Text))
                {
                    Ravenstvo.Text = "=";
                }
            }
        }

        public void Reborn(DataGridView dataGrid, NumericUpDown numeric, ComboBox box, string[] Baze_Znachen, double[] Qc ) //Сброс
        {
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid[i, 0].Value = Baze_Znachen[i];
            }
            if(numeric == Qc1)
            {
                numeric.Value = Convert.ToDecimal(Qc[0]);
                box.SelectedIndex = 6;
            }
            else if (numeric == Qc2)
            {
                numeric.Value = Convert.ToDecimal(Qc[1]);
                box.SelectedIndex = 2;
            }
            else if(numeric == Qc3)
            {
                numeric.Value = Convert.ToDecimal(Qc[2]);
                box.SelectedIndex = 0;
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if(Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value) <= 1 && Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value ) != 0.00 && Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value) != 0.00 && (Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value) <= 5 && Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value) != 0) && (Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value) <= 8750 && Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value) != 0) && (Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value) <= 10 && Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value) != 0) && Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value) != 0)
                {
                    if (АСБ_Box.SelectedItem != null)
                    {
                        Qc_Mass[0] = Convert.ToDouble(this.Qc1.Value);
                        Uн_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[0].Value);
                        n_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);
                        Pmax_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
                        Tmax_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[3].Value);
                        cosф_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value);

                        Lк_Mass[0] = Convert.ToDouble(dataGridView1.Rows[0].Cells[5].Value);
                        /*            double x0 = 0.081; //0,258  0,081
                                    double r0 = 0.258;*/
                        Raschet_Pкл(Pкл, Pmax_Mass[0], n_Mass[0]);
                        // Pкл.Text = Convert.ToString(Pmax * n); //Pкл

                        Raschet_Sкл(Sкл, Pкл, cosф_Mass[0]);
                        //Sкл.Text = Convert.ToString(Convert.ToDouble(Pкл.Text) / cosф); //Sкл

                        Raschet_Qmax(Qmax, Sкл, Pкл);
                        //Qmax.Text = Convert.ToString(Math.Sqrt(Math.Pow((Convert.ToDouble(Sкл.Text)), 2) - Math.Pow((Convert.ToDouble(Pкл.Text)), 2))); //Qmax

                        Otvet2_1.Text = Pкл.Text; //S1
                        Otvet2_2.Text = Qmax.Text; //S1

                        Raschet_tgф(tgф, Qmax, Pкл);
                        //tgф.Text = Convert.ToString(Convert.ToDouble(Qmax.Text) / Convert.ToDouble(Pкл.Text)); // 2,7 / 3,6 tgф

                        Raschet_Qc(Qc, Pкл, tgф);
                        //Qc.Text = Convert.ToString(Math.Round(Convert.ToDouble(Pкл.Text) * (Convert.ToDouble(tgф.Text) - tg), 1)); //Qc

                        Raschet_nБСК(nБСК, Qc, Qc_Mass[0]);
                        //nБСК.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) / Qc1 / 10) * 10000)); // nБСК

                        Raschet_Qбск(Qбск, Qc, nБСК);
                        //Qбск.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) * Convert.ToDouble(nБСК.Text)) / 10, 2)); // Qбск

                        Raschet_Q(Q, Qmax, Qбск);
                        //Q.Text = Convert.ToString(Math.Round(Convert.ToDouble(Qmax.Text) - Convert.ToDouble(Qбск.Text), 2)); //Q

                        Raschet_Iном(Iном, Pкл, Q, Uн_Mass[0]);
                        //Iном.Text = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow(Convert.ToDouble(Pкл.Text), 2) + Math.Pow(Convert.ToDouble(Q.Text), 2)) / (Math.Round(Math.Sqrt(3), 2) * Uн) * 1000));

                        Raschet_Fэ(Fэ, Iном, n_Mass[0], jэ);
                        //Fэ.Text = Convert.ToString(Math.Round(Convert.ToDouble(Iном.Text) / (n * jэ), 2));

                        Proverka_Iдоп(Iном, Iном_2_1, Iдоп, Ravenstvo);
                        /*                    Iном_2.Text = Iном.Text;
                                            if (Iдоп.Text == "...")
                                            {
                                                Otvet_Iдоп.Text = "К сожалению данные для этого провода отсутствуют";
                                                Otvet_Iдоп.Visible = true;
                                            }
                                            else
                                            {
                                                if (Convert.ToDouble(Iном_2.Text) >= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = ">=";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) <= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=<";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) == Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=";
                                                }
                                            }*/

                        Raschet_R_delen_n(R_delen_n, r0[0], Lк_Mass[0], n_Mass[0]);
                        //R_delen_n.Text = Convert.ToString(Math.Round((r0 * Lк) / n, 3));

                        Raschet_X_delen_n(X_delen_n, x0[0], Lк_Mass[0], n_Mass[0]);
                        //X_delen_n.Text = Convert.ToString(Math.Round((x0 * Lк) / n, 3));

                        Raschet_Uк(Uк, Pкл, R_delen_n, Q, X_delen_n, Uн_Mass[0]);
                        //Uк.Text = Convert.ToString(Math.Round((Convert.ToDouble(Pкл.Text) * Convert.ToDouble(R_delen_n.Text) + Convert.ToDouble(Q.Text) * Convert.ToDouble(X_delen_n.Text)) / Uн, 2));

                        Raschet_Uкл(Uкл, Uк, Uн_Mass[0]);
                        //Uкл.Text = Convert.ToString(Math.Round(Convert.ToDouble(Uк.Text) / Uн, 2)) + "%";
                        if (Convert.ToDouble(Uкл.Text) <= 0)
                        {
                            MessageBox.Show("Вы точно уверенны в значениях? Может стоит перепроверить? Значения Uкл какие-то странные");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите тип провода АСБ");

                    }
                }
               else
                {
                    MessageBox.Show("Максимальное доступное число в Uн = 10" + Environment.NewLine+"Максимальное доступное число в n = 5" +Environment.NewLine +
                        "Максимальное доступное число в Tmax = 8750" + Environment.NewLine + "Максимальное доступное число в cosф = 1" + Environment.NewLine + "НЕ ДОЛЖНО БЫТЬ НУЛЕВЫХ ЗНАЧЕНИЙ!!!"); 
                }    
            }
            catch
            {
                MessageBox.Show("Проверьте значения в таблице!");
            }


        }
/*        public void Raschet_Iдоп(ComboBox box, Label label)
        {
            for (int i = 1; i < box.MaxLength; i++)
            {
                switch (box.Items[i])
                {
                    case "16":
                        label.Text = "75";
                        break;
                }
            }
        }*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("10", "3", "1,2", "3000", "0,8", "3,3");
            dataGridView2.Rows.Add("10", "2", "0,9", "3000", "0,85", "3,3");
            dataGridView3.Rows.Add("10", "2", "0,397", "3000", "0,85", "3,3");

            АСБ_Box.SelectedValue = 120;
            АСБ_Box2.SelectedValue = 35;
            АСБ_Box3.SelectedValue = 16;

            Qc1.Value = 150;
            Qc2.Value = Convert.ToDecimal("37,5");
            Qc3.Value = Convert.ToDecimal("37,5");

            АСБ_Box.SelectedIndex = 6;
            АСБ_Box2.SelectedIndex = 2;
            АСБ_Box3.SelectedIndex = 0;
            Base_datagrid[0] = dataGridView1;
            Base_datagrid[1] = dataGridView2;
            Base_datagrid[2] = dataGridView3;
            /*dataGridView1.Columns[0].DefaultCellStyle.Format = ",,";*/
        }
        public void Proverka_ComboBox(System.Windows.Forms.Label label, ComboBox box, int i)
        {
            switch (box.SelectedItem.ToString())
            {
                case "16":
                    label.Text = "70";
                    r0[i] = 1.94;
                    x0[i] = 0.113;
                    break;
                case "25":
                    label.Text = "90";
                    r0[i] = 1.24;
                    x0[i] = 0.099;
                    break;
                case "35":
                    label.Text = "110";
                    r0[i] = 0.89;
                    x0[i] = 0.095;
                    break;
                case "50":
                    label.Text = "140";
                    r0[i] = 0.62;
                    x0[i] = 0.09;
                    break;
                case "70":
                    label.Text = "170";
                    r0[i] = 0.443;
                    x0[i] = 0.086;
                    break;
                case "95":
                    label.Text = "205";
                    r0[i] = 0.326;
                    x0[i] = 0.083;
                    break;
                case "120":
                    label.Text = "240";
                    r0[i] = 0.258;
                    x0[i] = 0.081;
                    break;
                case "150":
                    label.Text = "275";
                    r0[i] = 0.206;
                    x0[i] = 0.079;
                    break;
            }
        }
        private void АСБ_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proverka_ComboBox(Iдоп, АСБ_Box,0);
/*            switch (АСБ_Box.SelectedItem.ToString())
            {
                case "16":
                    Iдоп.Text = "70";
                    r0 = 1.94;
                    x0 = 0.113;
                    break;
                case "25":
                    Iдоп.Text = "90";
                    r0 = 1.24;
                    x0 = 0.099;
                    break;
                case "35":
                    Iдоп.Text = "110";
                    r0 = 0.89;
                    x0 = 0.095;
                    break;
                case "50":
                    Iдоп.Text = "140";
                    r0 = 0.62;
                    x0 = 0.09;
                    break;
                case "70":
                    Iдоп.Text = "170";
                    r0 = 0.443;
                    x0 = 0.086;
                    break;
                case "95":
                    Iдоп.Text = "205";
                    r0 = 0.326;
                    x0 = 0.083;
                    break;
                case "120":
                    Iдоп.Text = "240";
                    r0 = 0.258;
                    x0 = 0.081;
                    break;
                case "150":
                    Iдоп.Text = "275";
                    r0 = 0.206;
                    x0 = 0.079;
                    break;
*//*                case "185":
                    Iдоп.Text = "410";
                    break;
                case "240":
                    Iдоп.Text = "490";
                    break;
                case "300":
                    Iдоп.Text = "570";
                    break;
                case "350":
                    Iдоп.Text = "...";
                    break;
                case "400":
                    Iдоп.Text = "690";
                    break;
                case "450":
                    Iдоп.Text = "...";
                    break;
                case "500":
                    Iдоп.Text = "820";
                    break;
                case "550":
                    Iдоп.Text = "...";
                    break;
                case "600":
                    Iдоп.Text = "955";
                    break;
                case "650":
                    Iдоп.Text = "...";
                    break;
                case "700":
                    Iдоп.Text = "...";
                    break;
                case "750":
                    Iдоп.Text = "...";
                    break;
                case "800":
                    Iдоп.Text = "...";
                    break;*//*
            }*/
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            TextBox tb1 = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
/*            if (dataGridView1.Rows[0].Cells[1].Selected)
            {
                tb1.KeyPress += new KeyPressEventHandler(CheckKey);
            }*/


        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[3].Selected)
            {
                if (!(Char.IsDigit(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            /*            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) *//*&& !((e.KeyChar == '-')) && !((e.KeyChar == ','))*//*)
                        {
                            if (e.KeyChar != (char)Keys.Back)
                            {
                                e.Handled = true;
                            }
                        }*/

        }
        void tb_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[3].Selected)
            {
                if (!(Char.IsDigit(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            /*            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) *//*&& !((e.KeyChar == '-')) && !((e.KeyChar == ','))*//*)
                        {
                            if (e.KeyChar != (char)Keys.Back)
                            {
                                e.Handled = true;
                            }
                        }*/

        }
        void tb_KeyPress_3(object sender, KeyPressEventArgs e)
        {
            if (dataGridView3.Rows[0].Cells[3].Selected)
            {
                if (!(Char.IsDigit(e.KeyChar)))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            else
            {
                if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) && !((e.KeyChar == '-')) && !((e.KeyChar == ',')))
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                    }
                }
            }
            /*            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')) *//*&& !((e.KeyChar == '-')) && !((e.KeyChar == ','))*//*)
                        {
                            if (e.KeyChar != (char)Keys.Back)
                            {
                                e.Handled = true;
                            }
                        }*/

        }
        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar)))
            {
                if(e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if(string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reborn(dataGridView1, Qc1, АСБ_Box, Base_Znachen, Base_Qc);
/*            for(int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                    dataGridView1[i,0].Value = Base_Znachen[i];
            }
            Qc1.Value = 150;
            АСБ_Box.SelectedIndex = 6;*/
        }


        //Второй
        private void button3_Click(object sender, EventArgs e) //Рассчёт для второго
        {
            try
            {
                if(Convert.ToDouble(dataGridView2.Rows[0].Cells[4].Value) <= 1 && Convert.ToDouble(dataGridView2.Rows[0].Cells[4].Value) != 0.00 && Convert.ToDouble(dataGridView2.Rows[0].Cells[5].Value) != 0.00 && (Convert.ToDouble(dataGridView2.Rows[0].Cells[1].Value) <= 5 && Convert.ToDouble(dataGridView2.Rows[0].Cells[1].Value) != 0) && (Convert.ToDouble(dataGridView2.Rows[0].Cells[3].Value) <= 8750 && Convert.ToDouble(dataGridView2.Rows[0].Cells[3].Value) != 0) && (Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value) <= 10 && Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value) != 0) && Convert.ToDouble(dataGridView2.Rows[0].Cells[2].Value) != 0)
                {
                    if (АСБ_Box2.SelectedItem != null)
                    {
                        Qc_Mass[1] = Convert.ToDouble(this.Qc2.Value);
                        Uн_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[0].Value);
                        n_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[1].Value);
                        Pmax_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[2].Value);
                        Tmax_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[3].Value);
                        cosф_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[4].Value);

                        Lк_Mass[1] = Convert.ToDouble(dataGridView2.Rows[0].Cells[5].Value);
                        /*            double x0 = 0.081; //0,258  0,081
                                    double r0 = 0.258;*/
                        Raschet_Pкл(Pкл_2, Pmax_Mass[1], n_Mass[1]);
                        // Pкл.Text = Convert.ToString(Pmax * n); //Pкл

                        Raschet_Sкл(Sкл_2, Pкл_2, cosф_Mass[1]);
                        //Sкл.Text = Convert.ToString(Convert.ToDouble(Pкл.Text) / cosф); //Sкл

                        Raschet_Qmax(Qmax_2, Sкл_2, Pкл_2);
                        //Qmax.Text = Convert.ToString(Math.Sqrt(Math.Pow((Convert.ToDouble(Sкл.Text)), 2) - Math.Pow((Convert.ToDouble(Pкл.Text)), 2))); //Qmax

                        Otvet2_1_2.Text = Pкл_2.Text; //S1
                        Otvet2_2_2.Text = Qmax_2.Text; //S1

                        Raschet_tgф(tgф_2, Qmax_2, Pкл_2);
                        //tgф.Text = Convert.ToString(Convert.ToDouble(Qmax.Text) / Convert.ToDouble(Pкл.Text)); // 2,7 / 3,6 tgф

                        Raschet_Qc(Qc_2, Pкл_2, tgф_2);
                        //Qc.Text = Convert.ToString(Math.Round(Convert.ToDouble(Pкл.Text) * (Convert.ToDouble(tgф.Text) - tg), 1)); //Qc

                        Raschet_nБСК(nБСК_2, Qc_2, Qc_Mass[1]);
                        //nБСК.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) / Qc1 / 10) * 10000)); // nБСК

                        Raschet_Qбск(Qбск_2, Qc_2, nБСК_2);
                        //Qбск.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) * Convert.ToDouble(nБСК.Text)) / 10, 2)); // Qбск

                        Raschet_Q(Q_2, Qmax_2, Qбск_2);
                        //Q.Text = Convert.ToString(Math.Round(Convert.ToDouble(Qmax.Text) - Convert.ToDouble(Qбск.Text), 2)); //Q

                        Raschet_Iном(Iном_2, Pкл_2, Q_2, Uн_Mass[1]);
                        //Iном.Text = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow(Convert.ToDouble(Pкл.Text), 2) + Math.Pow(Convert.ToDouble(Q.Text), 2)) / (Math.Round(Math.Sqrt(3), 2) * Uн) * 1000));

                        Raschet_Fэ(Fэ_2, Iном_2, n_Mass[1], jэ);
                        //Fэ.Text = Convert.ToString(Math.Round(Convert.ToDouble(Iном.Text) / (n * jэ), 2));

                        Proverka_Iдоп(Iном_2, Iном_2_2, Iдоп_2, Ravenstvo_2);
                        /*                    Iном_2.Text = Iном.Text;
                                            if (Iдоп.Text == "...")
                                            {
                                                Otvet_Iдоп.Text = "К сожалению данные для этого провода отсутствуют";
                                                Otvet_Iдоп.Visible = true;
                                            }
                                            else
                                            {
                                                if (Convert.ToDouble(Iном_2.Text) >= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = ">=";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) <= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=<";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) == Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=";
                                                }
                                            }*/

                        Raschet_R_delen_n(R_delen_n_2, r0[1], Lк_Mass[1], n_Mass[1]);
                        //R_delen_n.Text = Convert.ToString(Math.Round((r0 * Lк) / n, 3));

                        Raschet_X_delen_n(X_delen_n_2, x0[1], Lк_Mass[1], n_Mass[1]);
                        //X_delen_n.Text = Convert.ToString(Math.Round((x0 * Lк) / n, 3));

                        Raschet_Uк(Uк_2, Pкл_2, R_delen_n_2, Q_2, X_delen_n_2, Uн_Mass[1]);
                        //Uк.Text = Convert.ToString(Math.Round((Convert.ToDouble(Pкл.Text) * Convert.ToDouble(R_delen_n.Text) + Convert.ToDouble(Q.Text) * Convert.ToDouble(X_delen_n.Text)) / Uн, 2));

                        Raschet_Uкл(Uкл_2, Uк_2, Uн_Mass[1]);
                        if (Convert.ToDouble(Uкл_2.Text) <= 0)
                        {
                            MessageBox.Show("Вы точно уверенны в значениях? Может стоит перепроверить? Значения Uкл какие-то странные");
                        }
                        //Uкл.Text = Convert.ToString(Math.Round(Convert.ToDouble(Uк.Text) / Uн, 2)) + "%";
                    }
                    else
                    {
                        MessageBox.Show("Выберите тип провода АСБ");
                    }
                }
                else
                {
                    MessageBox.Show("Максимальное доступное число в Uн = 10" + Environment.NewLine + "Максимальное доступное число в n = 5" + Environment.NewLine +
                        "Максимальное доступное число в Tmax = 8750" + Environment.NewLine + "Максимальное доступное число в cosф = 1" + Environment.NewLine + "НЕ ДОЛЖНО БЫТЬ НУЛЕВЫХ ЗНАЧЕНИЙ!!!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте значения в таблице!");
            }

        }

        private void button4_Click(object sender, EventArgs e) //Сьрос для второго
        {
            Reborn(dataGridView2, Qc2, АСБ_Box2, Base_Znachen_2, Base_Qc);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)//datagrid для второго
        {

        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            //TextBox tb1 = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress_2);
/*            if (dataGridView2.Rows[0].Cells[1].Selected)
            {
                tb1.KeyPress += new KeyPressEventHandler(CheckKey);
            }*/

        }

        private void Qc2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void АСБ_Box2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proverka_ComboBox(Iдоп_2, АСБ_Box2,1);
        }
        //Третья
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToDouble(dataGridView3.Rows[0].Cells[4].Value) <= 1 && Convert.ToDouble(dataGridView3.Rows[0].Cells[4].Value) != 0.00 && Convert.ToDouble(dataGridView3.Rows[0].Cells[5].Value) != 0.00 && (Convert.ToDouble(dataGridView3.Rows[0].Cells[1].Value) <= 5 && Convert.ToDouble(dataGridView3.Rows[0].Cells[1].Value) != 0) && (Convert.ToDouble(dataGridView3.Rows[0].Cells[3].Value) <= 8750 && Convert.ToDouble(dataGridView3.Rows[0].Cells[3].Value) != 0) && (Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) <= 10 && Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value) != 0) && Convert.ToDouble(dataGridView3.Rows[0].Cells[2].Value) != 0)
                {
                    if (АСБ_Box3.SelectedItem != null)
                    {
                        Qc_Mass[2] = Convert.ToDouble(this.Qc3.Value);
                        Uн_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[0].Value);
                        n_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[1].Value);
                        Pmax_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[2].Value);
                        Tmax_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[3].Value);
                        cosф_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[4].Value);

                        Lк_Mass[2] = Convert.ToDouble(dataGridView3.Rows[0].Cells[5].Value);
                        /*            double x0 = 0.081; //0,258  0,081
                                    double r0 = 0.258;*/
                        Raschet_Pкл(Pкл_3, Pmax_Mass[2], n_Mass[2]);
                        // Pкл.Text = Convert.ToString(Pmax * n); //Pкл

                        Raschet_Sкл(Sкл_3, Pкл_3, cosф_Mass[2]);
                        //Sкл.Text = Convert.ToString(Convert.ToDouble(Pкл.Text) / cosф); //Sкл

                        Raschet_Qmax(Qmax_3, Sкл_3, Pкл_3);
                        //Qmax.Text = Convert.ToString(Math.Sqrt(Math.Pow((Convert.ToDouble(Sкл.Text)), 2) - Math.Pow((Convert.ToDouble(Pкл.Text)), 2))); //Qmax

                        Otvet2_1_3.Text = Pкл_3.Text; //S1
                        Otvet2_2_3.Text = Qmax_3.Text; //S1

                        Raschet_tgф(tgф_3, Qmax_3, Pкл_3);
                        //tgф.Text = Convert.ToString(Convert.ToDouble(Qmax.Text) / Convert.ToDouble(Pкл.Text)); // 2,7 / 3,6 tgф

                        Raschet_Qc(Qc_3, Pкл_3, tgф_3);
                        //Qc.Text = Convert.ToString(Math.Round(Convert.ToDouble(Pкл.Text) * (Convert.ToDouble(tgф.Text) - tg), 1)); //Qc

                        Raschet_nБСК(nБСК_3, Qc_3, Qc_Mass[2]);
                        //nБСК.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) / Qc1 / 10) * 10000)); // nБСК

                        Raschet_Qбск(Qбск_3, Qc_3, nБСК_3);
                        //Qбск.Text = Convert.ToString(Math.Round((Convert.ToDouble(Qc.Text) * Convert.ToDouble(nБСК.Text)) / 10, 2)); // Qбск

                        Raschet_Q(Q_3, Qmax_3, Qбск_3);
                        //Q.Text = Convert.ToString(Math.Round(Convert.ToDouble(Qmax.Text) - Convert.ToDouble(Qбск.Text), 2)); //Q

                        Raschet_Iном(Iном_3, Pкл_3, Q_3, Uн_Mass[2]);
                        //Iном.Text = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow(Convert.ToDouble(Pкл.Text), 2) + Math.Pow(Convert.ToDouble(Q.Text), 2)) / (Math.Round(Math.Sqrt(3), 2) * Uн) * 1000));

                        Raschet_Fэ(Fэ_3, Iном_3, n_Mass[2], jэ);
                        //Fэ.Text = Convert.ToString(Math.Round(Convert.ToDouble(Iном.Text) / (n * jэ), 2));

                        Proverka_Iдоп(Iном_3, Iном_2_3, Iдоп_3, Ravenstvo_3);
                        /*                    Iном_2.Text = Iном.Text;
                                            if (Iдоп.Text == "...")
                                            {
                                                Otvet_Iдоп.Text = "К сожалению данные для этого провода отсутствуют";
                                                Otvet_Iдоп.Visible = true;
                                            }
                                            else
                                            {
                                                if (Convert.ToDouble(Iном_2.Text) >= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = ">=";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) <= Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=<";
                                                }
                                                else if (Convert.ToDouble(Iном_2.Text) == Convert.ToDouble(Iдоп.Text))
                                                {
                                                    Ravenstvo.Text = "=";
                                                }
                                            }*/

                        Raschet_R_delen_n(R_delen_n_3, r0[2], Lк_Mass[2], n_Mass[2]);
                        //R_delen_n.Text = Convert.ToString(Math.Round((r0 * Lк) / n, 3));

                        Raschet_X_delen_n(X_delen_n_3, x0[2], Lк_Mass[2], n_Mass[2]);
                        //X_delen_n.Text = Convert.ToString(Math.Round((x0 * Lк) / n, 3));

                        Raschet_Uк(Uк_3, Pкл_3, R_delen_n_3, Q_3, X_delen_n_3, Uн_Mass[2]);
                        //Uк.Text = Convert.ToString(Math.Round((Convert.ToDouble(Pкл.Text) * Convert.ToDouble(R_delen_n.Text) + Convert.ToDouble(Q.Text) * Convert.ToDouble(X_delen_n.Text)) / Uн, 2));

                        Raschet_Uкл(Uкл_3, Uк_3, Uн_Mass[2]);
                        if (Convert.ToDouble(Uкл_3.Text) <= 0)
                        {
                            MessageBox.Show("Вы точно уверенны в значениях? Может стоит перепроверить? Значения Uкл какие-то странные");
                        }
                        //Uкл.Text = Convert.ToString(Math.Round(Convert.ToDouble(Uк.Text) / Uн, 2)) + "%";
                    }
                    else
                    {
                        MessageBox.Show("Выберите тип провода АСБ");
                    }
                }
                else
                {
                    MessageBox.Show("Максимальное доступное число в Uн = 10" + Environment.NewLine + "Максимальное доступное число в n = 5" + Environment.NewLine +
                        "Максимальное доступное число в Tmax = 8750" + Environment.NewLine + "Максимальное доступное число в cosф = 1" + Environment.NewLine + "НЕ ДОЛЖНО БЫТЬ НУЛЕВЫХ ЗНАЧЕНИЙ!!!");
                }
            }
            catch
            {
                MessageBox.Show("Проверьте значения в таблице!");
            }

        }

        private void АСБ_Box3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proverka_ComboBox(Iдоп_3, АСБ_Box3,2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reborn(dataGridView3, Qc3, АСБ_Box3, Base_Znachen_3, Base_Qc);
        }

        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                ((DataGridView)sender).CancelEdit();
            }
        }

        private void dataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            //TextBox tb1 = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress_3);
/*            if (dataGridView3.Rows[0].Cells[1].Selected)
            {
                tb1.KeyPress += new KeyPressEventHandler(CheckKey);
            }*/
        }
        //Выборка
        private void Vebor_Click(object sender, EventArgs e)
        {

            
        }
        public void Raschet_Sн(System.Windows.Forms.Label Sн, System.Windows.Forms.Label Pкл, System.Windows.Forms.Label Q, double Kав, double[] n, int i)
        {
            Sн.Text = Convert.ToString(Math.Round(Math.Sqrt(Math.Pow( Convert.ToDouble(Pкл.Text) ,2) + Math.Pow(Convert.ToDouble(Q.Text), 2) ) / (Кав* (n[i] -1)), 1 ));
        }
        public void Raschet_mав(System.Windows.Forms.Label mав, System.Windows.Forms.Label Pкл, System.Windows.Forms.Label Q, double Kав, double[] n, int i, ComboBox Sнт)
        {
            string po = Convert.ToString(Math.Sqrt(Math.Pow(Convert.ToDouble(Pкл.Text), 2) + Math.Pow(Convert.ToDouble(Q.Text), 2)) / (Convert.ToDouble(Sнт.SelectedItem.ToString()) / 1000));
            mав.Text = Convert.ToString( Math.Round(Convert.ToDouble(po) *100));
            /*Convert.ToDouble(Sнт.SelectedItem) / 1000*/
        }

        private void TM_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void Proverka_mав(System.Windows.Forms.Label M, System.Windows.Forms.Label I, System.Windows.Forms.Label Raven)
        {
            if (Convert.ToDouble(M.Text) >= Convert.ToDouble(I.Text))
            {
                Raven.Text = ">=";
            }
            else if (Convert.ToDouble(M.Text) <= Convert.ToDouble(I.Text))
            {
                Raven.Text = "=<";
            }
            else if (Convert.ToDouble(M.Text) == Convert.ToDouble(I.Text))
            {
                Raven.Text = "=";
            }
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            if(Pкл.Text != "0" && Q.Text != "0")
            {
                
                
                if(TM_ComboBox.SelectedItem != null)
                {
                    Raschet_Sн(Sн, Pкл, Q, Кав, n_Mass, 0);
                    Raschet_mав(mав, Pкл, Q, Кав, n_Mass, 0, TM_ComboBox);
                    Proverka_mав(mав, BaseZnach_TM, Ravenstvo_mав);
                }
                else
                {
                    MessageBox.Show("Выберите тип трансформатора");
                }
            }
            else
            {
                MessageBox.Show("Выполните сначала рассчеты для первого трансформатора");
            }

        }

        private void Raschet_2_Click(object sender, EventArgs e)
        {
            if (Pкл_2.Text != "0" && Q_2.Text != "0")
            {


                if (TM_ComboBox_2.SelectedItem != null)
                {
                    Raschet_Sн(Sн_2, Pкл_2, Q_2, Кав, n_Mass, 1);
                    Raschet_mав(mав_2, Pкл_2, Q_2, Кав, n_Mass, 1, TM_ComboBox_2);
                    Proverka_mав(mав_2, BaseZnach_TM_2, Ravenstvo_mав_2);
                }
                else
                {
                    MessageBox.Show("Выберите тип трансформатора");
                }
            }
            else
            {
                MessageBox.Show("Выполните сначала рассчеты для второго трансформатора");
            }
        }

        private void Raschet_3_Click(object sender, EventArgs e)
        {
            if (Pкл_3.Text != "0" && Q_3.Text != "0")
            {


                if (TM_ComboBox_3.SelectedItem != null)
                {
                    Raschet_Sн(Sн_3, Pкл_3, Q, Кав, n_Mass, 2);
                    Raschet_mав(mав_3, Pкл_3, Q, Кав, n_Mass, 2, TM_ComboBox_3);
                    Proverka_mав(mав_3, BaseZnach_TM_3, Ravenstvo_mав_3);
                }
                else
                {
                    MessageBox.Show("Выберите тип трансформатора");
                }
            }
            else
            {
                MessageBox.Show("Выполните сначала рассчеты для третьего трансформатора");
            }
        }

        private void Vibur_Click(object sender, EventArgs e)
        {
            if(mав.Text != "0" && mав_2.Text != "0" && mав_3.Text != "0")
            {
                string[] GoodOtvet = new string[4];
                if (Convert.ToDouble(mав.Text) > Convert.ToDouble(mав_2.Text) && Convert.ToDouble(mав.Text) > Convert.ToDouble(mав_3.Text))
                {
                    GoodOtvet[0] = mав.Text;
                    Vibrun_Transformator.Text = "Перый трансформатор";
                    /*                if (Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав.Text))
                                    {
                                        GoodOtvet[1] = mав_2.Text;
                                    }*/
                }
                if (Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав.Text) && Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав_3.Text))
                {
                    GoodOtvet[1] = mав_2.Text;
                    Vibrun_Transformator.Text = "Второй трансформатор";
                }
                if (Convert.ToDouble(mав_3.Text) > Convert.ToDouble(mав.Text) && Convert.ToDouble(mав_3.Text) > Convert.ToDouble(mав_2.Text))
                {
                    GoodOtvet[2] = mав_3.Text;
                    Vibrun_Transformator.Text = "Третий трансформатор";
                }
                /*            if (Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав.Text) && Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав_3.Text))
                            {
                                GoodOtvet[0] = mав_2.Text;
                                if (Convert.ToDouble(mав.Text) > Convert.ToDouble(mав_2.Text))
                                {
                                    GoodOtvet[1] = mав.Text;
                                }
                                if (Convert.ToDouble(mав_3.Text) > Convert.ToDouble(mав_2.Text))
                                {
                                    GoodOtvet[2] = mав_3.Text;
                                }
                            }
                            if (Convert.ToDouble(mав_3.Text) > Convert.ToDouble(mав.Text) && Convert.ToDouble(mав_3.Text) > Convert.ToDouble(mав_2.Text))
                            {
                                GoodOtvet[0] = mав_3.Text;
                                if (Convert.ToDouble(mав.Text) > Convert.ToDouble(mав_3.Text))
                                {
                                    GoodOtvet[1] = mав.Text;
                                }
                                if (Convert.ToDouble(mав_2.Text) > Convert.ToDouble(mав_3.Text))
                                {
                                    GoodOtvet[2] = mав_2.Text;
                                }
                            }*/

                Vebor_Otvet.Text = null;
                for (int i = 0; i < GoodOtvet.Length; i++)
                {
                    Vebor_Otvet.Text += $" {GoodOtvet[i]}";
                }
            }
            else
            {
                MessageBox.Show("Сначала подсчитайте трансформаторы");
            }

        }

        private void Vebor_Otvet_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void Podscazka_MaxZnachen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Максимальное доступное число в Uн = 10" + Environment.NewLine + "Максимальное доступное число в n = 5" + Environment.NewLine +
    "Максимальное доступное число в Tmax = 8750" + Environment.NewLine + "Максимальное доступное число в cosф = 1" + Environment.NewLine + "НЕ ДОЛЖНО БЫТЬ НУЛЕВЫХ ЗНАЧЕНИЙ!!!");
        }
    }
}
