using Checkers_Marek_Ogrodnik.CLasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Marek_Ogrodnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 8;
            var P = Board.GenerateFields();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    CheckersBoard.Controls.Add(P[i, j]);
            Board.NumberFields(P);
            Board.GiveCheckers(P);
            //Board.TestBoard(P);
            ///asdasdas


        }


        private void Mouseclick(object sender, MouseEventArgs e)
        {
            if(sender is PictureBox)
            {
                //sender = sender as PictureBox;
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BackColor = Color.Green;
            }
        }



        private void CheckersBoard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckersBoard_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                //sender = sender as PictureBox;
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BackColor = Color.Green;
            }
        }
    }
}
