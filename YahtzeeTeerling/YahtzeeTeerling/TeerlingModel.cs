using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    public class TeerlingModel
    {

        int maxAantal = 3;
        private int aantalTeerlingen = 5;
        // Onthoudt het aantal ogen van de teerling
        int _aantalOgen;

        // Onthoudt de true of false van de teerling
        Boolean _click = true;

        // Getters en setters van het aantal ogen
       

        public Boolean Click
        {
            get
            {
                return _click;
            }
            set
            {
                _click = value;
            }
        }



        public int AantalOgen
        {
            get
            {
                return _aantalOgen;
            }
            set
            {
                _aantalOgen = value;
            }
        }

        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }

            set
            {
                aantalTeerlingen = value;
            }
        }

        public int MaxAantal
        {
            get
            {
                return maxAantal;
            }

            set
            {
                maxAantal = value;
            }
        }

        
    }
}
