using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace gestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int TAM = 10;
        string[] nombre = new string[TAM];
        int[] numero = new int[TAM];
        int i = 0;
        void añadirContactos()
        {
            Console.WriteLine(i);
            if (nombre[i]== null && numero[i]==' ')
            {
                nombre[i] = Interaction.InputBox("Introduce tu nombre " + i);
                numero[i] = int.Parse(Interaction.InputBox("Introduce tu numero " + i));
            }
            i++;
        }
        private void añadirContacto_Click(object sender, EventArgs e)
        {
            añadirContactos();
        }
    }
}
