using Checkers_Marek_Ogrodnik.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Marek_Ogrodnik.CLasses
{
    public class OptionalMechanic
    {
        public static void MouseHoverLeave(int i, int j, PictureBox[,] MyBox, List<Checkerclass> Allcheckers, bool flags,List<Checkerclass> Greencheckers, List<Checkerclass> Redcheckers)
        {
            if (Allcheckers.Count == 0)
                return;
            MyBox[i, j].MouseHover += (sender2, e2) =>
            {
                //Checkerclass papa2 = new Checkerclass();
                PictureBox x = sender2 as PictureBox;
               
                var papa2 = Allcheckers.Find(z => z.Numberoffield == x.Name);
                if (x.Image != null && papa2 != null)
                {
                    if (papa2.colour == Enums.Enums.PlayerColour.Green && papa2.Flags)
                        x.Image = Resources.GreenPick;
                    else if (papa2.colour == Enums.Enums.PlayerColour.Red && papa2.Flags)
                        x.Image = Resources.RedPick;
                    x.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            };
            MyBox[i, j].MouseLeave += (sender2, e2) =>
            {
                //Checkerclass papa2 = new Checkerclass();
                PictureBox x = sender2 as PictureBox;
                var papa2 = Allcheckers.Find(z => z.Numberoffield == x.Name);
                if (x.Image != null && papa2 != null)
                {
                    if (papa2.colour == Enums.Enums.PlayerColour.Green && papa2.Flags)
                        x.Image = Resources.Green1;
                    else if (papa2.colour == Enums.Enums.PlayerColour.Red && papa2.Flags)
                        x.Image = Resources.Red1;
                    x.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            };
        }
        public static void NewClick(int i, int j, PictureBox[,] MyBox, List<Checkerclass> Allcheckers,List<Checkerclass> Greencheckers, List<Checkerclass> Redcheckers, Playerclass Player1, Playerclass Player2)
        {
            bool Takecondition = true;
            Player2.DelayFlags();
            MyBox[i, j].Click += (sender3, e3) =>
            {
                PictureBox x = sender3 as PictureBox;
               if (Allcheckers.Count == 0)
                    return;
               var moved = Allcheckers.Find(z => z.IsNotPicked == false);
                var papa = Allcheckers.Find(z => z.Numberoffield == x.Name);
                if (papa != null && papa.Flags)
                {
                    if (moved != null)
                        moved.IsNotPicked = true;
                    foreach (PictureBox p in MyBox)
                    {
                        string[] idi = new string[2];
                        if (p.Image == null)
                            idi = p.Name.Split(' ');
                        if (p.Image == null && ((Int32.Parse(idi[0]) % 2 == 0 && Int32.Parse(idi[1]) % 2 == 0) || (Int32.Parse(idi[0]) % 2 == 1 && Int32.Parse(idi[1]) % 2 == 1)))
                            p.BackColor = Color.Black;
                    }
                    string[] id = papa.Numberoffield.Split(' ');
                    if (papa.colour == Enums.Enums.PlayerColour.Green && papa.Flags)
                    {
                        if (Int32.Parse(id[1]) != 0 && Int32.Parse(id[0]) != 0)
                        {
                            MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) - 1].BackColor = Color.Yellow;
                            if (MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) - 1].Image != null && MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) - 2].Image == null)
                            {
                                MyBox[Int32.Parse(id[0]) - 2, Int32.Parse(id[1]) - 2].BackColor = Color.Yellow;
                                papa.Takeleftcondition = true;
                            }

                        }
                        if (Int32.Parse(id[1]) != 7 && Int32.Parse(id[0]) != 0)
                        {
                            MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) + 1].BackColor = Color.Yellow;
                            if (MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) + 1].Image != null && MyBox[Int32.Parse(id[0]) - 1, Int32.Parse(id[1]) + 2].Image == null)
                            {
                                MyBox[Int32.Parse(id[0]) - 2, Int32.Parse(id[1]) + 2].BackColor = Color.Yellow;
                                papa.Takerightcondition = true;
                            }
                        }
                        papa.IsNotPicked = false;
                    }
                    else if (papa.colour == Enums.Enums.PlayerColour.Red && papa.Flags)
                    {
                        if (Int32.Parse(id[1]) != 0 && Int32.Parse(id[0]) != 7)
                        {
                            MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) - 1].BackColor = Color.Yellow;
                            if (MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) - 1].Image != null && MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) - 2].Image == null)
                            {
                                MyBox[Int32.Parse(id[0]) + 2, Int32.Parse(id[1]) - 2].BackColor = Color.Yellow;
                                papa.Takeleftcondition = true;
                            }
                        }
                        if (Int32.Parse(id[1]) != 7 && Int32.Parse(id[0]) != 7)
                        {
                            MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) + 1].BackColor = Color.Yellow;
                            if (MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) + 1].Image != null && MyBox[Int32.Parse(id[0]) + 1, Int32.Parse(id[1]) + 2].Image == null)
                            {
                                MyBox[Int32.Parse(id[0]) + 2, Int32.Parse(id[1]) + 2].BackColor = Color.Yellow;
                                papa.Takerightcondition = true;
                            }
                        }
                        papa.IsNotPicked = false;
                    }
                    
                }
                else if(papa == null && moved != null && moved.Flags)
                {
                    if (moved.Numberoffield != null)
                    {
                        if (x.BackColor == Color.Yellow)
                        {
                            string[] id = moved.Numberoffield.Split(' ');
                            MyBox[Int32.Parse(id[0]), Int32.Parse(id[1])].Image = null;
                            MyBox[Int32.Parse(id[0]), Int32.Parse(id[1])].BackColor = Color.Black;
                            if (moved.Takeleftcondition || moved.Takerightcondition)
                                Hitting(MyBox,moved,Redcheckers,Greencheckers, Int32.Parse(id[0]), Int32.Parse(id[1]), Allcheckers);
                            x.Image = moved.Image;
                            x.SizeMode = PictureBoxSizeMode.StretchImage;
                            moved.Numberoffield = x.Name;
                            moved.IsNotPicked = true;
                            if (moved.colour == Enums.Enums.PlayerColour.Green)
                            {
                                 Player1.DelayFlags();
                                 Player2.SetFlags();
                                
                            }
                            if (moved.colour == Enums.Enums.PlayerColour.Red)
                            {
                                  Player1.SetFlags();
                                  Player2.DelayFlags();
                                
                            }
                            foreach (PictureBox p in MyBox)
                            {
                                string[] idi = new string[2];
                                if (p.Image == null)
                                    idi = p.Name.Split(' ');
                                if (p.Image == null && ((Int32.Parse(idi[0]) % 2 == 0 && Int32.Parse(idi[1]) % 2 == 0) || (Int32.Parse(idi[0]) % 2 == 1 && Int32.Parse(idi[1]) % 2 == 1)))
                                    p.BackColor = Color.Black;
                            }
                        }

                    }
                }

            };
        }
        public static void Hitting(PictureBox[,] Box, Checkerclass moved, List<Checkerclass> Redcheckers, List<Checkerclass> Greencheckers, int i, int j, List<Checkerclass> Allcheckers)
        {
            if(moved.colour == Enums.Enums.PlayerColour.Green)
            {
                if (moved.Takerightcondition)
                {

                    Box[i - 1, j + 1].Image = null;
                    var Takes = Allcheckers.Find(z => z.Numberoffield == (i - 1) + " " + (j + 1));
                    Allcheckers.Remove(Takes);
                }
                else if (moved.Takeleftcondition)
                {
                    Box[i - 1, j - 1].Image = null;
                    var Takes = Allcheckers.Find(z => z.Numberoffield == (i - 1) + " " + (j - 1));
                    Allcheckers.Remove(Takes);
                }
            }
            if(moved.colour == Enums.Enums.PlayerColour.Red)
            {
                if (moved.Takerightcondition)
                {
                    Box[i + 1, j + 1].Image = null;
                    var Takes = Allcheckers.Find(z => z.Numberoffield == (i + 1) + " " + (j + 1));
                    Allcheckers.Remove(Takes);
                }
                else if (moved.Takeleftcondition)
                {
                    Box[i + 1, j - 1].Image = null;
                    var Takes = Allcheckers.Find(z => z.Numberoffield == (i + 1) + " " + (j - 1));
                    Allcheckers.Remove(Takes);
                }
            }
        }
    }
}
