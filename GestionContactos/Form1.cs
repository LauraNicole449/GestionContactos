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
        private void btnAddContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarContactos_Click(object sender, EventArgs e)
        {       

        }
    }
}
