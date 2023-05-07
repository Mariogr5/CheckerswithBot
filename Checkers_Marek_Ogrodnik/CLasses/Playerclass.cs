using Checkers_Marek_Ogrodnik.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Checkers_Marek_Ogrodnik.Enums.Enums;

namespace Checkers_Marek_Ogrodnik.CLasses
{
    public class Playerclass
    {
        public Playerclass(PlayerColour Colour, List<Checkerclass> list)
        {
            this.colour = Colour;
            this.checkers = list;
        }
        public PlayerColour colour { get; set; }
        public bool flagsy()
        {
            if(colour == PlayerColour.Green)
                return true;
            return false;
        }

        List<Checkerclass> checkers { get; set; }

        public int numberofcheckers(List<Checkerclass> P)
        {
            int number = 0;
            foreach(var p in P)
            {
                // if(colour == PlayerColour.Red)
                //     if(p.Image == Resources.Red1)
                //         number++;
                // else if(colour == PlayerColour.Green)
                //     if (p.Image == Resources.Green1)
                //         number++;
                if(p.colour == colour)
                    number++;
            }
            return number;
        }

        public void SetFlags()
        {
            foreach(var P in checkers)
            {
                P.Flags = true;
            }
        }
        public void DelayFlags()
        {
            foreach (var P in checkers)
            {
                P.Flags = false;
            }
        }
    }
}
