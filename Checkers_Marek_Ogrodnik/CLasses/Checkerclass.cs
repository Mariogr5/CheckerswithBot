using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Checkers_Marek_Ogrodnik.Enums.Enums;

namespace Checkers_Marek_Ogrodnik.CLasses
{
    public class Checkerclass
    {
        public Checkerclass(string numberoffield, PlayerColour Colour, bool isinthegame, System.Drawing.Bitmap image)
        {
            this.Numberoffield = numberoffield;
            this.colour = Colour;
            this.Isinthegame = isinthegame;
            this.Image = image;
        }

        public string Numberoffield { get; set; }
        public PlayerColour colour { get; set; }
        public bool Isinthegame { get; set; }
        
        public System.Drawing.Bitmap Image { get; set; }
    }
}
