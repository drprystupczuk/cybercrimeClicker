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
    public partial class frmPantallaFin : Form
    {
        public frmPantallaFin()
        {
            InitializeComponent();
        }
        static public Boolean ganaste;
        SoundPlayer SonidoFin = new SoundPlayer();
        
        private void frmPantallaFin_Load(object sender, EventArgs e)
        {
            SonidoFin.SoundLocation = "fin.wav";
            SonidoFin.PlayLooping();

           
            #region IF Seguridad
            if (frmJuego.Seguridad > 50)
            {
                ganaste = true;
                lblMensajeFin.ForeColor = Color.Lime;
                lblMensajeFin.Text = "10/10 ¡LO HICISTE INCREIBLE!";
            }
            else if (frmJuego.Seguridad > 25 && frmJuego.Seguridad < 50)
            {
                ganaste = true;
                lblMensajeFin.ForeColor = Color.Green;
                lblMensajeFin.Text = "8 PUNTOS ¡ERES GENIAL!";
            }
            else if (frmJuego.Seguridad > 0 && frmJuego.Seguridad <= 25)
            {
                ganaste = true;
                lblMensajeFin.ForeColor = Color.Yellow;
                lblMensajeFin.Text = "APENAS APRUEBAS, ESFUERATE MAS";
            }
            else if (frmJuego.Seguridad > -25 && frmJuego.Seguridad <= 0)
            {
                ganaste = false;
                lblMensajeFin.ForeColor = Color.Red;
                lblMensajeFin.Text = "ESTUVISTE CERCA, PERO NO LO LOGRASTE";
            }
            else if (frmJuego.Seguridad < -25)
            {
                ganaste = false;
                lblMensajeFin.ForeColor = Color.Red;
                lblMensajeFin.Text = "TU PUNTAJE ES 2 ((COMO DIEGO EN EL PRIMER PARCIAL)), TERRIBLE.";
            }

            #endregion
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            SonidoFin.Stop();
            frmJuego.NivelTerminado = false;
            this.Close();

        }

        private void picIES_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://prezi.com/0w2legup9vre/delitos-informaticos/");
        }

        private void lblMensajeFin_Click(object sender, EventArgs e)
        {

        }
    }
}
