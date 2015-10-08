using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace Ejemplo_de_Sonidos
{
    class Video : Animal
    {
        public Video(string nombre, Image imagen, string url)
            : base(nombre, imagen)
        {
            Url = url;
        }
        private string _Url;
        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }

        public override void Sonido()
        {
            EjecutaProceso();
        }

        private void EjecutaProceso()
        {
            Process nuevoProceso = new Process();
            nuevoProceso.StartInfo.FileName = Url;
            nuevoProceso.Start();
        }


    }//fin de la clase 
}//fin del namespace 
