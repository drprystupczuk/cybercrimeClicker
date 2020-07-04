using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Final_Estructura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        static public string Nivel;
        StringBuilder queryAddress = new StringBuilder();

        SoundPlayer SonidoMenu = new SoundPlayer(); 
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Nivel = "Uno.txt";
            SonidoMenu.SoundLocation = "sonido.wav";
            SonidoMenu.PlayLooping();
        }

        private void cmdInciar_Click(object sender, EventArgs e)
        {
            SonidoMenu.Stop();
           frmCarga Carga  = new frmCarga();
            Carga.Show();
        }

        private void linkAcercaDe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            frmAcercaDe AcercaDe = new frmAcercaDe();
            AcercaDe.Show();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            this.Close();
        }

        private void picIES_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.ies21.edu.ar/");


        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://prezi.com/0w2legup9vre/delitos-informaticos/");
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            SonidoMenu.SoundLocation = "sonido.wav";
            SonidoMenu.PlayLooping();
        }
    }
}
