using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Media;
namespace Ejemplo_de_Sonidos
{
    class hombre : Animal
    {
        public hombre(string nom, Image im)
            :base(nom, im)
        {
        }

        public override void Sonido()
        {
            SoundPlayer s = new SoundPlayer("03_hombre_libre.wav");
            s.Play();
        }
        

    }//fin de la clase 
}//fin del namespace 
