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
    public partial class MainGame : Form
    {
        Point mousePos;
        Point mousePos2;
        Point mousePos3;
        bool Down;
        bool Down2;
        bool Down3;
        bool Down4;
        bool Down5;
        bool Down6;

        bool isIntersects;
        bool isIntersects2;
        bool isIntersects3;
        int BaseChet;
        bool OK;

        public MainGame()
        {
            InitializeComponent();
            Invalidate();

            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new Cols());
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = CreateGraphics();
            //SolidBrush colorBase = new SolidBrush(Color.Blue);
            //g.FillRectangle(colorBase, 0,350,850,350);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        
        private void BaseST_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void BaseST_Click(object sender, EventArgs e)
        {
            
        }

        private void BaseST_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void BaseST_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down = false;
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                BaseST.Location = new Point((BaseST.Left + dx), (BaseST.Top + dy));
                
                //pictureBox2.Location = new Point((Cursor.Position.X - this.Location.X), (Cursor.Position.Y - this.Location.Y));
            }


        }

        private void BaseST_MouseUp(object sender, MouseEventArgs e)
        {
            Down = true;
            //pictureBox2.Location = new Point((pictureBox2.Left), (pictureBox2.Top + 100));
        }
        public void DropBaseTS (PictureBox Name, PictureBox lastName) // Падение фигур
        {
            if (!Name.Bounds.IntersectsWith(BaseFundament.Bounds) ) //Падение
            {
                Name.Location = new Point((Name.Left), (Name.Top + 10));
            }
            if (!lastName.Bounds.IntersectsWith(BaseFundament.Bounds)) //падение последнего элемента
            {
                lastName.Location = new Point((lastName.Left), (lastName.Top + 10));
            }
        }
        public void DeadZoneBaseST (PictureBox Name, PictureBox lastName)
        {

            if (Name.Top > BaseFundament.Top) //Не даёт вытеснить вниз
            {
                Name.Location = new Point((Name.Left), (Name.Top - 15));
            }
            if (lastName.Top > BaseFundament.Top) //Не даёт вытеснить вниз
            {
                lastName.Location = new Point((lastName.Left), (Name.Top - 15));
            }

            if (Name.Right > BaseFundament.Right) //Не даёт вытеснить влево
            {
                Name.Location = new Point((Name.Left - 5), (Name.Top));
            }
            if (lastName.Right > BaseFundament.Right) //Не даёт вытеснить влево первый элемент
            {
                lastName.Location = new Point((lastName.Left - 5), (Name.Top));
            }

            if (Name.Left < BaseFundament.Left) //Не даёт вытеснить вправо
            {
                Name.Location = new Point((Name.Left + 5), (Name.Top));
            }
            if (lastName.Left < BaseFundament.Left) //Не даёт вытеснить вправо первый элемент
            {
                lastName.Location = new Point((lastName.Left + 5), (Name.Top));
            }
        } //мертвая зона для пользователя
        public void IfVictory (PictureBox stolb)
        {
            if (BaseST.Bounds.Bottom == BaseST2.Bounds.Top && BaseST2.Bounds.Bottom == BaseST3.Bounds.Top && BaseST3.Bounds.Bottom == BaseST4.Bounds.Top && BaseST5.Bounds.Bottom == BaseST6.Bounds.Top && BaseST5.Bounds.Top == BaseST4.Bounds.Bottom && BaseST.Bounds.IntersectsWith(stolb.Bounds))
            {
                OK = true;

            }
            else
            {
                OK = false;
            }
            if (OK == true)
            {
                MainInformation.ForeColor = Color.Green;
                MainInformation.Text = "Башня собранна";
            }
            else
            {
                MainInformation.ForeColor = Color.Brown;
                MainInformation.Text = "Башня не собранна";
            }
        } //условия победы
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            PictureBox[] Name = new PictureBox[] { BaseST6,BaseST5,BaseST4,BaseST3,BaseST2,BaseST};
            PictureBox[] Stolbs = new PictureBox[] { Stolb, StolbR};
            List<PictureBox> items = new List<PictureBox>() {BaseST,BaseST2,BaseST3 };
            
            Point NewPoint;
            isIntersects3 = BaseST3.Bounds.IntersectsWith(BaseFundament.Bounds);
            isIntersects2 = BaseST2.Bounds.IntersectsWith(BaseFundament.Bounds);
            isIntersects = BaseST.Bounds.IntersectsWith(BaseFundament.Bounds);
            //if (isIntersects != true && Down == true) //Падение
            //{
            //    //if (pictureBox2.Top != 300)
            //    //{
            //        BaseST.Location = new Point((BaseST.Left), (BaseST.Top + 10));
            //    //}
            //}


            //if (isIntersects2 != true && Down2 == true)
            //{
            //    BaseST2.Location = new Point((BaseST2.Left), (BaseST2.Top + 10));
            //}
            //if (isIntersects3 != true && Down3 == true)
            //{
            //    BaseST3.Location = new Point((BaseST3.Left), (BaseST3.Top + 10));
            //}
            //if (!BaseST4.Bounds.IntersectsWith(BaseFundament.Bounds) && Down4 == true)
            //{
            //    BaseST4.Location = new Point((BaseST4.Left), (BaseST4.Top + 10));
            //}
            //if (!BaseST5.Bounds.IntersectsWith(BaseFundament.Bounds) && Down5 == true)
            //{
            //    BaseST5.Location = new Point((BaseST5.Left), (BaseST5.Top + 10));
            //}
            //if (!BaseST6.Bounds.IntersectsWith(BaseFundament.Bounds) && Down6 == true)
            //{
            //    BaseST6.Location = new Point((BaseST6.Left), (BaseST6.Top + 10));
            //}

            //foreach  (PictureBox item in items.ToList())
            //{
            //    if(BaseFundament.Bounds.IntersectsWith(item.Bounds))
            //    {
            //        items.Remove(item);
            //        item.Location = new Point(item.Left, item.Top);
            //        //this.Controls.Remove(item);

            //    }
            //}

            //if (BaseST.Bounds.IntersectsWith(BaseST2.Bounds))
            //{

            //    //BaseST2.Location = new Point(BaseST2.Left, BaseST.Top-20);
            //    BaseST.Location = new Point(BaseST.Left, BaseST2.Top - 20);
            //}
            //if (BaseST.Bounds.IntersectsWith(BaseST2.Bounds))
            //{
            //    BaseST2.Location = new Point(BaseST2.Left, BaseST.Top - 20);
            //    OK = true;
            //}
            //if (BaseST.Bounds.IntersectsWith(BaseST2.Bounds))
            //{
            //    //BaseST.Location = new Point(BaseST.Left, BaseST2.Top-25);
            //    BaseST.Bounds.Intersect(BaseST2.Bounds);
            //    OK = false;
            //}


            //if (BaseST.Bounds.IntersectsWith(BaseST2.Bounds) && BaseST.Bounds.Top == BaseST2.Bounds.Bottom)
            // {
            //     BaseST2.Location = new Point(BaseST2.Left, BaseST.Top - 20);
            // }

            //типо колизия
            //if(BaseST.Bounds.IntersectsWith(BaseST2.Bounds) && BaseST.Bounds.Bottom > BaseST2.Bounds.Top)
            //{
            //    BaseST.Top -= 10;
            //}
            //if(BaseST.Bounds.IntersectsWith(BaseST2.Bounds) && BaseST2.Bounds.Bottom > BaseST.Bounds.Top)
            //{
            //    BaseST2.Top -= 10;
            //}
           


                for (int i = 1; i < Name.Length; i++)
                {
                    DropBaseTS(Name[i], Name[Name.Length - Name.Length]);
                    DeadZoneBaseST(Name[i], Name[Name.Length - Name.Length]);

                if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i].Width)
                {
                    Name[i - 1].Location = new Point(10, 100);
                } // не даёт большей фигуре наслаеватся на малую, проблема дальнейшие фигуры выходящие из цикла двух выталкиватся не будет


                //if (i%2 == 0)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i].Width)
                //    {
                //        Name[i-2].Location = new Point(10, 100);
                //    }
                //}

                //не даёт большим элементвам упасть на наименьшую
                //if (i == 1)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Bottom > Name[i - 1].Bounds.Bottom && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 2)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Bottom > Name[i - 2].Bounds.Bottom && Name[i - 2].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top && Name[i - 3].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 4)
                //{
                //    if (Name[i - 4].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 4].Bounds.Top && Name[i - 4].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 4].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 2)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 2].Bounds.Top && Name[i - 2].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 4)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top && Name[i - 3].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 2].Bounds.Top && Name[i - 2].Width > Name[i].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 3].Bounds.Top && Name[i - 3].Width > Name[i].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 2].Bounds.Top && Name[i - 2].Width > Name[i].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                ////конец



                //не даёт 6 элементу упасть на наименьшую
                //if (i == 5)
                //{
                //    if (Name[i - 5].Bounds.IntersectsWith(Name[i].Bounds) && (Name[i].Bounds.Bottom < Name[i - 5].Bounds.Bottom || Name[i].Bounds.Top > Name[i - 5].Bounds.Top) && Name[i - 5].Width > Name[i].Width)
                //    {
                //        Name[i - 5].Location = new Point(10, 100);
                //    }
                //}
                if (i == 5)
                {
                    if (Name[i - 5].Bounds.IntersectsWith(Name[i - 4].Bounds) && (Name[i - 4].Bounds.Bottom < Name[i - 5].Bounds.Bottom || Name[i - 4].Bounds.Top > Name[i - 5].Bounds.Top) && Name[i - 5].Width > Name[i - 4].Width)
                    {
                        Name[i - 5].Location = new Point(10, 100);
                    }
                }
                if (i == 4)
                {
                    if (Name[i - 4].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 4].Width > Name[i + 1].Width)
                    {
                        Name[i - 4].Location = new Point(10, 100);
                    }
                }
                if (i == 3)
                {
                    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 3].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top) && Name[i - 3].Width > Name[i + 1].Width)
                    {
                        Name[i - 3].Location = new Point(10, 100);
                    }
                }
                if (i == 2)
                {
                    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 2].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i + 1].Width)
                    {
                        Name[i - 2].Location = new Point(10, 100);
                    }
                }
                if (i == 1)
                {
                    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 1].Width)
                    {
                        Name[i - 1].Location = new Point(10, 100);
                    }
                }

                //конец

                //не даёт 5 элементу упасть на наименьшую
                if (i == 4)
                {
                    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 3].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top) && Name[i - 3].Width > Name[i + 1].Width)
                    {
                        Name[i - 3].Location = new Point(10, 100);
                    }
                }
                if (i == 3)
                {
                    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 2].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i + 1].Width)
                    {
                        Name[i - 2].Location = new Point(10, 100);
                    }
                }
                if (i == 2)
                {
                    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 1].Width)
                    {
                        Name[i - 1].Location = new Point(10, 100);
                    }
                }
                if (i == 1)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i].Bounds.Top) && Name[i].Width > Name[i + 1].Width)
                    {
                        Name[i].Location = new Point(10, 100);
                    }
                }
                if (i== 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i].Bounds.Top) && Name[i].Width > Name[i + 1].Width)
                    {
                        Name[i].Location = new Point(10, 100);
                    }

                }
                //конец


                //не даёт 4 элементу упасть на наименьшую
                if (i == 3)
                {
                    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 2].Bounds) && (Name[i + 2].Bounds.Bottom < Name[i - 1].Bounds.Bottom || Name[i + 2].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 2].Width)
                    {
                        Name[i - 1].Location = new Point(10, 100);
                    }
                }
                if (i == 3)
                {
                    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 1].Width)
                    {
                        Name[i - 1].Location = new Point(10, 100);
                    }
                }
                if (i == 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i].Bounds.Bottom < Name[i + 1].Bounds.Bottom || Name[i].Bounds.Top > Name[i + 1].Bounds.Top) && Name[i + 1].Width > Name[i].Width)
                    {
                        Name[i].Location = new Point(10, 100);
                    }
                }
                if (i == 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i + 2].Bounds) && (Name[i].Bounds.Bottom < Name[i + 2].Bounds.Bottom || Name[i].Bounds.Top > Name[i + 2].Bounds.Top) && Name[i + 2].Width < Name[i].Width)
                    {
                        Name[i].Location = new Point(10, 100);
                    }
                }
                //конец


                //не даёт 3 элементу упасть на наименьшую
                if (i == 4)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom < Name[i].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i].Bounds.Top) && Name[i].Width > Name[i + 1].Width)
                    {
                        Name[i].Location = new Point(10, 100);
                    }
                }
                //конец


                //не даёт большим элементвам упасть на наименьшую
                //if (i == 1)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 2)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 2].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 3].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top) && Name[i - 3].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 4)
                //{
                //    if (Name[i - 4].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 4].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 4].Bounds.Top) && Name[i - 4].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 4].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 2)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 1].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top) && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 2].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 4)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i + 1].Bounds) && (Name[i + 1].Bounds.Bottom > Name[i - 3].Bounds.Bottom || Name[i + 1].Bounds.Top > Name[i - 3].Bounds.Top) && Name[i - 3].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i].Bounds) && (Name[i].Bounds.Bottom > Name[i - 2].Bounds.Bottom || Name[i].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 3].Bounds.IntersectsWith(Name[i].Bounds) && (Name[i].Bounds.Bottom > Name[i - 3].Bounds.Bottom || Name[i].Bounds.Top > Name[i - 3].Bounds.Top) && Name[i - 3].Width > Name[i].Width)
                //    {
                //        Name[i - 3].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 2].Bounds.IntersectsWith(Name[i].Bounds) && (Name[i].Bounds.Bottom > Name[i - 2].Bounds.Bottom || Name[i].Bounds.Top > Name[i - 2].Bounds.Top) && Name[i - 2].Width > Name[i].Width)
                //    {
                //        Name[i - 2].Location = new Point(10, 100);
                //    }
                //}
                ////конец


                //if (i == 2)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 3)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 4)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i + 1].Bounds) && Name[i + 1].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i + 1].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 5].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 5].Bounds.Top && Name[i - 5].Width > Name[i].Width)
                //    {
                //        Name[i - 5].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    }
                //}



                //if (i == 4)
                //{
                //    if (Name[i - 4].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 4].Bounds.Top && Name[i - 4].Width > Name[i].Width)
                //    {
                //        Name[i ].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 5)
                //{
                //    if (Name[i - 5].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 5].Bounds.Top && Name[i - 5].Width > Name[i].Width)
                //    {
                //        Name[i].Location = new Point(10, 100);
                //    }
                //}
                //if (i == 6)
                //{
                //    if (Name[i - 6].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 6].Bounds.Top && Name[i - 6].Width > Name[i].Width)
                //    {
                //        Name[i].Location = new Point(10, 100);
                //    }
                //}


                //for (int o = 2; o < Name.Length; o++)
                //{
                //    if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Bounds.Top > Name[i - 1].Bounds.Top && Name[i - 1].Width > Name[i].Width)
                //    {
                //        Name[i - 1].Location = new Point(10, 100);
                //    } // не даёт большей фигуре наслаеватся на малую, проблема дальнейшие фигуры выходящие из цикла двух выталкиватся не будет
                //    if (i == o)
                //    {
                //        if (Name[i - o].Bounds.IntersectsWith(Name[i - 1].Bounds) && Name[i - 1].Bounds.Top > Name[i - o].Bounds.Top && Name[i - o].Width > Name[i - 1].Width)
                //        {
                //            Name[i - o].Location = new Point(10, 100);
                //        }
                //    }
                //}


                //if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds) && Name[i].Width == Name[i].Width)
                //{
                //    Name[i].Location = new Point(Name[i].Left, Name[i - 1].Bounds.Y - 25);

                //}


                //не дает вершине упасть
                if (i == 5)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 5].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 5].Bounds.Y - 25);
                    }
                }
                if (i == 5)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 4].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 4].Bounds.Y - 25);
                    }
                }
                if (i == 5)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 3].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 3].Bounds.Y - 25);
                    }
                }
                if (i == 5)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 2].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 2].Bounds.Y - 25);
                    }
                }
                //конец

                //не дает  второй вершине упасть
                if (i == 4)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 4].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 4].Bounds.Y - 25);
                    }
                }
                if (i == 4)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 3].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 3].Bounds.Y - 25);
                    }
                }
                if (i == 4)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 2].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 2].Bounds.Y - 25);
                    }
                }
                //конец

                //не дает  третьей вершине упасть
                if (i == 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 3].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 3].Bounds.Y - 25);
                    }
                }
                if (i == 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 2].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 2].Bounds.Y - 25);
                    }
                }
                if (i == 3)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 1].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 1].Bounds.Y - 25);
                    }
                }
                //конец

                //не дает  четвертой вершине упасть
                if (i == 2)
                {
                    if (Name[i].Bounds.IntersectsWith(Name[i - 2].Bounds))
                    {
                        Name[i].Location = new Point(Name[i].Left, Name[i - 2].Bounds.Y - 25);
                    }
                }
                //конец

                if (Name[i - 1].Bounds.IntersectsWith(Name[i].Bounds))
                    {

                    Name[i].Location = new Point(Name[i].Left, Name[i - 1].Top - 25); //= Name[i-1].Top-10;
                    for (int j = 0; j < Stolbs.Length; j++)
                        {
                            if (Name[i].Bounds.IntersectsWith(Stolbs[j].Bounds))
                            {
                                Name[i].Left = Stolbs[j].Bounds.X - (125 - (i * 15));
                            IfVictory(Stolbs[j]);
                            //if (Name[(Name.Length - Name.Length) + 1].Bottom == Name[Name.Length - Name.Length].Top) // последний элемент
                            //{
                            //    Name[Name.Length - Name.Length].Left = Stolbs[j].Bounds.X - (125);
                            //}

                        }
                        

                    }

                        //NewPoint = Name[i - 1].Location;
                        //Name[i].Location = NewPoint;
                    }



                }
            
            
            //if (OK == true)
            //{
            //    timer1.Stop();

            //    if (DialogResult.OK == MessageBox.Show("Ну поздравляю", "Похоже это победа", MessageBoxButtons.OK, MessageBoxIcon.Information))
            //    {
            //        OK = false;
            //        timer1.Start();
            //    }
            //}


        }
        private void BaseST2_MouseMove(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
                Down2 = false;
                int dx = e.X - mousePos2.X;
                int dy = e.Y - mousePos2.Y;
                BaseST2.Location = new Point((BaseST2.Left + dx), (BaseST2.Top + dy));

                
            }

        }

        private void BaseST2_MouseUp(object sender, MouseEventArgs e)
        {
            Down2 = true;
        }

        private void BaseST2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos2 = e.Location;
        }

        private void BaseST2_Click(object sender, EventArgs e)
        {

        }

        private void BaseST3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down2 = false;
                int dx = e.X - mousePos3.X;
                int dy = e.Y - mousePos3.Y;
                BaseST3.Location = new Point((BaseST3.Left + dx), (BaseST3.Top + dy));


            }
        }

        private void BaseST3_MouseUp(object sender, MouseEventArgs e)
        {
            Down3 = true;
        }

        private void BaseST3_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos3 = e.Location;
        }

        private void BaseST_DragOver(object sender, DragEventArgs e)
        {
            
        }

        private void BaseST4_Click(object sender, EventArgs e)
        {

        }

        private void BaseST4_MouseDown(object sender, MouseEventArgs e)
        {

                mousePos = e.Location;
        }

        private void BaseST4_MouseMove(object sender, MouseEventArgs e)
        {

                if (e.Button == MouseButtons.Left)
                {
                    Down = false;
                    int dx = e.X - mousePos.X;
                    int dy = e.Y - mousePos.Y;
                    BaseST4.Location = new Point((BaseST4.Left + dx), (BaseST4.Top + dy));

                    //pictureBox2.Location = new Point((Cursor.Position.X - this.Location.X), (Cursor.Position.Y - this.Location.Y));
                }

        }

        private void BaseST5_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void BaseST5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down = false;
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                BaseST5.Location = new Point((BaseST5.Left + dx), (BaseST5.Top + dy));

                //pictureBox2.Location = new Point((Cursor.Position.X - this.Location.X), (Cursor.Position.Y - this.Location.Y));
            }
        }

        private void BaseST6_MouseDown(object sender, MouseEventArgs e)
        {
            mousePos = e.Location;
        }

        private void BaseST6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Down = false;
                int dx = e.X - mousePos.X;
                int dy = e.Y - mousePos.Y;
                BaseST6.Location = new Point((BaseST6.Left + dx), (BaseST6.Top + dy));

                //pictureBox2.Location = new Point((Cursor.Position.X - this.Location.X), (Cursor.Position.Y - this.Location.Y));
            }
        }

        private void BaseST4_MouseUp(object sender, MouseEventArgs e)
        {
            Down4 = true;
        }

        private void BaseST5_MouseUp(object sender, MouseEventArgs e)
        {
            Down5 = true;
        }

        private void BaseST6_MouseUp(object sender, MouseEventArgs e)
        {
            Down6 = true;
        }

        private void BaseST6_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void вернутьсяВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mainmenu mainmenu = new Mainmenu();
            mainmenu.Show();
            this.Hide();
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

        private void MainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
