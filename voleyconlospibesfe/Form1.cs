using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voleyconlospibesfe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblSaludar.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblSaludar.Text = this.txtNombre.Text + " " + this.txtApellidos.Text + " " + this.txtNumeros.Text;

            
        }

        private void Jugador_Click(object sender, EventArgs e)
        {

        }

        
    }
    }

