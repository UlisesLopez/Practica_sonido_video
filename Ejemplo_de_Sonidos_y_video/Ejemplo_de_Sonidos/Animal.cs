using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing;

namespace Ejemplo_de_Sonidos
{
    class Animal
    {
        private Image foto;
        private String nombre;
        

        public string P_nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public Image P_foto
        {
            set { foto = value; }
            get { return foto; }
        }

        public Animal(string non, Image fo)
        {
            foto = fo;
            nombre = non;
        }

        public virtual void Sonido()
        {
            SoundPlayer s = new SoundPlayer("03_hombre_libre.wav");
            s.Play();
        }

      

    }//fin de la clase 
}//fin del namespace 


//watch?v=FbPrZVfu6iw video dragon ball 
//watch?v=y7UH6D1K4Jg video guitarra 