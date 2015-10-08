using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;

namespace Ejemplo_de_Sonidos
{
    class moderato : Animal
    {
        public moderato(string non, Image fo)
            : base(non, fo)
        {
        }

        public override void Sonido()
        {
            SoundPlayer s = new SoundPlayer("zodiaco_2_.wav");
            s.Play();
        }
     
    }//fin de la clase 
}//fin del namespace 
