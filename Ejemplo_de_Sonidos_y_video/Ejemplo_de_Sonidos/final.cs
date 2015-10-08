using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace Ejemplo_de_Sonidos
{
    class final : Animal
    {
        public final(string nom, Image img)
            :base(nom,img)
        {
        }

        public override void Sonido()
        {
            SoundPlayer s = new SoundPlayer("enrique_bunbury_-_y_al_final_-_copia.wav");
            s.Play();
        }

    }//fin de la clase 
}//fin del namespace 
