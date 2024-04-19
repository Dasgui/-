using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Paint_на_минималках
{

    public partial class Form1 : Form
    {
        int x1, x2, y1, y2; // координаты начала и конца рисунка
        bool f;    // логическая переменная, фиксирующая начало рисования
        Color c1 = Color.Black; //цвет контура
        Color c2 = Color.White; //цвет заливки
        Graphics g; //полотно-слой для рисования
        Image B = new Bitmap(200, 200);
        Bitmap bitmap; //растр для хранения гтового изображения
        Font titleFont;  //шрифт для выводимого текста

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            // растр по размеру pictureBox
            g = Graphics.FromImage(bitmap);
            // слой рисования связан с растром. Меняем g и меняется растр bitmap 
            toolStripButton5.BackColor = c1;
            toolStripButton6.BackColor = c2;
            titleFont = toolStripLabel1.Font;
            //начальный шрифт как у метки

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as ToolStripLabel).Font = fontDialog1.Font;
                titleFont = fontDialog1.Font;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (object item in toolStrip1.Items)
                //перебираем все элементы toolStrip
                if (item is ToolStripButton)
                // если встретили кнопку (у нас есть и метка и разделители…)
                {
                    if (item == sender) (item as ToolStripButton).Checked = true;
                    //текущую отмечаем
                    if ((item != null) && (item != sender))
                    {  // с других снимаем
                        (item as ToolStripButton).Checked = false;
                    }
                }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as ToolStripButton).BackColor = colorDialog1.Color;
                c2 = colorDialog1.Color;
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                (sender as ToolStripButton).BackColor = colorDialog1.Color;
                c1 = colorDialog1.Color;
            }

        }

        private void цветПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton5_Click(toolStripButton5, e);
            //та же что и по кнопке 5

        }

        private void цветЗаливкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButton6_Click(toolStripButton6, e);
            //та же что и по кнопке 6

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            //заливаем всё полотно белым цветом
            pictureBox1.Image = bitmap;
            //дублируем очищенное поле в pictureBox1 из растра.

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                bitmap.Save(saveFileDialog1.FileName);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X; // координаты мыши по х (начало)
            y1 = e.Y; // координаты мыши по у(начало)
            f = true; // началось рисование

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(c1); //генерируем перо
                                 //если выбран карандаш и идёт рисование
            if (toolStripButton1.Checked && f)
            {
                x2 = e.X; // координаты конца отрезка
                y2 = e.Y;
                g.DrawLine(p, x1, y1, x2, y2); // линия от начало до конца 
                x1 = x2; // новое начало отрезка- это конец предыдущего
                y1 = y2; //
                pictureBox1.Image = bitmap;
                //записываем что получилось из  растра в pictureBox
            }
            if (toolStripButton2.Checked && f)
            {
                Graphics g1 = pictureBox1.CreateGraphics();
                //создаём временный слой g1. В итог он не запишется, но даст возможность 
                //посмотреть что получается
                x2 = e.X; //вычисляем конец временного отрезка
                y2 = e.Y;
                g1.DrawLine(p, x1, y1, x2, y2);  //рисуем линию
                pictureBox1.Invalidate();
                //обновляем, чтобы не было фантомного следа
                //попробуйте потом закомментировать эту строчку с обновлением
                g1.Dispose(); //удаляем временный слой
            }
            if (toolStripButton3.Checked && f)
            {
                Graphics g1 = pictureBox1.CreateGraphics();
                x2 = e.X;
                y2 = e.Y;
                //надо вычислить верхний левый и нижний правый
                //т.к. пользователь может вести мышку в любом направлении,
                //а рисовать мы можем только из верхнего левого угла
                int xx1, yy1, xx2, yy2;
                xx1 = Math.Min(x1, x2); //минимум по х
                yy1 = Math.Min(y1, y2); //минимум по у
                xx2 = Math.Max(x1, x2); //максимум по х
                yy2 = Math.Max(y1, y2); // максимум по у
                g1.DrawRectangle(p, xx1, yy1, xx2 - xx1, yy2 - yy1);
                //рисуем прямоугольник
                pictureBox1.Invalidate();
                g1.Dispose();
                //удаляем временный слой     
            }
    }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen p = new Pen(c1);
            SolidBrush b = new SolidBrush(c2);
            // если выбран прямоугольник и идёт рисование
            if (toolStripButton3.Checked && f)
            {
                x2 = e.X;
                y2 = e.Y;
                int xx1, yy1, xx2, yy2;
                xx1 = Math.Min(x1, x2);
                yy1 = Math.Min(y1, y2);
                xx2 = Math.Max(x1, x2);
                yy2 = Math.Max(y1, y2);
                if (e.Button == MouseButtons.Left)  //если нажата левая кнопка
                                                    //рисуем заливку 
                    g.FillRectangle(b, xx1, yy1, xx2 - xx1, yy2 - yy1);
                // в любом случае прорисовываем контур
                g.DrawRectangle(p, xx1, yy1, xx2 - xx1, yy2 - yy1);
                //дублируем полученное изиображение  в pictureBox1 из растра.
                pictureBox1.Image = bitmap;
            }
            //если выбрана линия и идёт рисование
            if (toolStripButton2.Checked && f)
            {
                Graphics g1 = pictureBox1.CreateGraphics();
                x2 = e.X;
                y2 = e.Y;
                g.DrawLine(p, x1, y1, x2, y2);
                pictureBox1.Image = bitmap;

            }

            //если выбран текст
            if (toolStripButton4.Checked)
            {
                //выводим текст, который введён toolStripTextBox1 шрифтом titleFont и цветом с1 (цвет контура) в точку с координатами (x1,y1)
                g.DrawString(toolStripTextBox1.Text, titleFont, Brushes.Aquamarine, x1, y1);
                pictureBox1.Image = bitmap;
            }
            //в любом случае заканчиваем рисование
            f = false;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
