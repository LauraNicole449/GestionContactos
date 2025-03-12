using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionContactos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //yo
        private const int MAX_CONTACTS = 10;
        private string[] nombres = new string[MAX_CONTACTS];
        private string[] telefonos = new string[MAX_CONTACTS];
        private int count = 0;

        // el otro
        private void btnAddContacto_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del contacto:"); 
            string phone = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el teléfono del contacto:");

            bool exists = false;
            for (int i = 0; i < count; i++)
            {
                if (nombres[i] == name)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                MessageBox.Show("El contacto ya existe.");
            }       
            else if (count >= MAX_CONTACTS)
            {
                MessageBox.Show("No se pueden agregar más contactos.");
            }  
            else
            {
                nombres[count] = name;
                telefonos[count] = phone;
                count++;
            }
        }
        //yo
        private void btnDeleteContacto_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del contacto a eliminar:"); ;
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (nombres[i] == name)
                {
                    index = i;
                }
            }

            if (index == -1)
            {
                MessageBox.Show("El contacto no existe.");
            }
               
            else
            {
                nombres[index] = "";
                telefonos[index] = "";
            }
        
        }
        //el otro
        private void btnMostrarContactos_Click(object sender, EventArgs e)
        {
            string contactList = "Contactos:\n";
            for (int i = 0; i < count; i++)
            {
                contactList += $"{nombres[i]} - {telefonos[i]}\n";
            }
            MessageBox.Show(contactList, "Lista de Contactos");
        }

       
    }
}
