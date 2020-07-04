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
    public partial class frmCarga : Form
    {
        public frmCarga()
        {
            InitializeComponent();
        }

        Random R = new Random();
        int Random;

        private void frmCarga_Load(object sender, EventArgs e)
        {
            #region Imagen Fondo
            picFondo.Location = new Point(0,0);
            picFondo.Height = 768;
            picFondo.Width = 1360;
            picFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            Random = R.Next(0, 7);
            switch (Random)
            {
                case 0:
                    picFondo.Image = Properties.Resources.CARGANDO_0;
                    break;
                case 1:
                    picFondo.Image = Properties.Resources.CARGANDO_1;
                    break;
                case 2:
                    picFondo.Image = Properties.Resources.CARGANDO_2;
                    break;
                case 3:
                    picFondo.Image = Properties.Resources.CARGANDO_3;
                    break;
                case 4:
                    picFondo.Image = Properties.Resources.CARGANDO_4;
                    break;
                case 5:
                    picFondo.Image = Properties.Resources.CARGANDO_5;
                    break;
                case 6:
                    picFondo.Image = Properties.Resources.CARGANDO_6;
                    break;
                default:
                    Random = 0;
                    break;
            }
            #endregion
            #region Timer
            Cambiofrm.Enabled = true;
            Cambiofrm.Start();
            #endregion
        }

        private void Cambiofrm_Tick(object sender, EventArgs e)
        {
            switch (frmJuego.NivelTerminado)
            {
                case true:
                    frmPantallaFin Fin = new frmPantallaFin();
                    Fin.Show();
                    break;
                case false:
                    frmJuego Juego = new frmJuego();
                    Juego.Show();   
                    break;
                default:
                    break;
            }

            Cambiofrm.Stop();
            Cambiofrm.Enabled = false;
            this.Close();
        }
            
    }
}
