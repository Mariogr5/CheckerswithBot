using Checkers_Marek_Ogrodnik.Properties;
using Checkers_Marek_Ogrodnik.Enums;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace Checkers_Marek_Ogrodnik.CLasses
{
    public static class Board
    {
        public static PictureBox[,] GenerateFields()
        {
            int n = 8;
            int left = 2, top = 2;
            PictureBox[,] P = new PictureBox[n, n];
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0)
                {
                    colors[0] = Color.White;
                    colors[1] = Color.Black;
                }
                else
                {
                    colors[0] = Color.Black;
                    colors[1] = Color.White;
                }
                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    left += 60;
                    //CheckersBoard.Controls.Add(P[i, j]);
                }
                top += 60;
            }
            return P;
        }

        public static void NumberFields(PictureBox[,] MyBoard)
        {
            int n = 8;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    MyBoard[i, j].Name = i + " " + j;
                }
            }
        }

        public static void GiveCheckers(PictureBox[,] MyBoard, List<Checkerclass> Redcheckers, List<Checkerclass> Greencheckers, List<Checkerclass> Allcheckers)
        {
            int n = 8;
            //List<Checkerclass> Redcheckers = new List<Checkerclass>();
            //List<Checkerclass> Greencheckers = new List<Checkerclass>();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (i < (n / 2) - 1 && MyBoard[i, j].BackColor == Color.Black)
                    {
                        Checkerclass checker = new Checkerclass(MyBoard[i, j].Name, Enums.Enums.PlayerColour.Red, true, Resources.Red1, true, false);
                        Redcheckers.Add(checker);
                        MyBoard[i, j].Image = checker.Image;
                    }
                    else if (i > (n / 2) && MyBoard[i, j].BackColor == Color.Black)
                    {
                        Checkerclass checker = new Checkerclass(MyBoard[i, j].Name, Enums.Enums.PlayerColour.Green, true, Resources.Green1, true, true);
                        Greencheckers.Add(checker);
                        MyBoard[i, j].Image = checker.Image;
                    }
                    MyBoard[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            Allcheckers.AddRange(Redcheckers);
            Allcheckers.AddRange(Greencheckers);
        }
        public static void BoardActualization(PictureBox[,] MyBoard, List<Checkerclass> Allcheckers)
        {
            int n = 8;
            if(Allcheckers.Count != 0)
            foreach (Checkerclass p in Allcheckers)
            {
                string[] idi = new string[2];
                idi = p.Numberoffield.Split(' ');
                MyBoard[Int32.Parse(idi[0]), Int32.Parse(idi[1])].Image = p.Image;
                MyBoard[Int32.Parse(idi[0]), Int32.Parse(idi[1])].SizeMode = PictureBoxSizeMode.StretchImage;
            }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (MyBoard[i, j].Image == null)
                    {
                        if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                            MyBoard[i, j].BackColor = Color.Black;
                        else
                            MyBoard[i, j].BackColor = Color.White;

                    }
                }
                
        }
    }
}
