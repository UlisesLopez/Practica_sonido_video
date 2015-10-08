using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.Collections;


namespace Ejemplo_de_Sonidos
{
    public partial class Form1 : Form
    {
        ArrayList milista = new ArrayList();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

            if (e.ColumnIndex == 2)
            {
                Animal obj = (Animal)milista[e.RowIndex];
                obj.Sonido();
                obj.Sonido();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Animal hombre = new hombre("Hombre Libre", Image.FromFile("t139638857-i900676035_s400.jpg"));
            milista.Add(hombre);

            Animal moderato = new moderato("Zodiaco", Image.FromFile("46.jpg"));
            milista.Add(moderato);

            Animal final = new final("Al Final", Image.FromFile("enrique-bunbury-licenciado-cantinas-2011.jpg"));
            milista.Add(final);

            Video ACDC = new Video("AC/DC",Image.FromFile("MI0002419254.jpg"), "https://www.youtube.com/watch?v=gEPmA3USJdI");
            milista.Add(ACDC);
            int i = 0;

            foreach (Animal item in milista)
            {
                dataGridView1.Rows.Add();
                dataGridView1[0, i].Value = item.P_foto;
                dataGridView1[1, i].Value = item.P_nombre;
                dataGridView1[2, i].Value = " Da Click";
                i++;
            }

        }
    }
}
