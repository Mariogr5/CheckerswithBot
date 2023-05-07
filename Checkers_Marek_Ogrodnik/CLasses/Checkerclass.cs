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
        public Checkerclass(string numberoffield, PlayerColour Colour, bool isinthegame, System.Drawing.Bitmap image, bool isnotpicked, bool flags)
        {
            this.Numberoffield = numberoffield;
            this.colour = Colour;
            this.Isinthegame = isinthegame;
            this.Image = image;
            this.IsNotPicked = isnotpicked;
            this.Flags = flags;
        }
        public Checkerclass()
        {
            //this.Numberoffield = null;
            //this.colour = null;
            //this.Isinthegame = null;
            //this.Image = null;
        }

        public string Numberoffield { get; set; }
        public PlayerColour colour { get; set; }
        public bool Isinthegame { get; set; }
        public bool IsNotPicked { get; set; }
        public bool Flags { get; set; }
        public bool Takeleftcondition { get; set; }
        public bool Takerightcondition { get; set; }
        
        public System.Drawing.Bitmap Image { get; set; }
        public void ChangeImage()
        {
            if (Isinthegame == false)
                Image = null;
        }
    }
}
