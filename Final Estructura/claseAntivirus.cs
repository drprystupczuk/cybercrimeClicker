using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Final_Estructura
{
    public class claseAntivirus
    {
        

        public PictureBox[] picAntivirus;

        public Boolean Descontaminador = false;
        public Boolean Cortafuegos = false;
        public Boolean Preventor = false;
        public Boolean AntiSpyware = false;
        
        
        //Descontaminador        
        public int AnalisisDescontaminador = 0;

        //AntiSpyware
        public int AnalisisAntiSpyware= 0;

        //CortaFuegos
        public int AnalisisCortaFuegos= 0;

        //Preventor
        public int AnalisisPreventor= 0;






        #region Agregar Descontaminador
        public void AgregarDescontaminador(Form Pantalla, int descontaminador)
        {
            picAntivirus = new PictureBox[1];
            picAntivirus[descontaminador] = new PictureBox();

            picAntivirus[descontaminador].Image = Properties.Resources.descontaminador;
            picAntivirus[descontaminador].Size = new System.Drawing.Size(147, 127);
            picAntivirus[descontaminador].SizeMode = PictureBoxSizeMode.StretchImage;
            picAntivirus[descontaminador].Location = new Point(609, 345);
            picAntivirus[descontaminador].BackColor = Color.Transparent;
            Pantalla.Controls.Add(picAntivirus[0]);
        }
        #endregion
        #region Agregar cortafuegos
        public void Agregarcortafuegos(Form Pantalla, int cortafuegos)
        {
            picAntivirus = new PictureBox[1];
            picAntivirus[cortafuegos] = new PictureBox();

            picAntivirus[cortafuegos].Image = Properties.Resources.cortafuegos;
            picAntivirus[cortafuegos].Size = new System.Drawing.Size(147, 127);
            picAntivirus[cortafuegos].SizeMode = PictureBoxSizeMode.StretchImage;
            picAntivirus[cortafuegos].Location = new Point(609, 148);
            picAntivirus[cortafuegos].BackColor = Color.Transparent;

            Pantalla.Controls.Add(picAntivirus[0]);
        }
        #endregion
        #region Agregar preventor
        public void Agregarpreventor(Form Pantalla, int preventor)
        {
            picAntivirus = new PictureBox[1];
            picAntivirus[preventor] = new PictureBox();

            picAntivirus[0].Image = Properties.Resources.preventor;
            picAntivirus[0].Size = new System.Drawing.Size(147, 127);
            picAntivirus[0].SizeMode = PictureBoxSizeMode.StretchImage;
            picAntivirus[0].Location = new Point(126, 345);
            picAntivirus[0].BackColor = Color.Transparent;
            Pantalla.Controls.Add(picAntivirus[0]);
        }
        #endregion
        #region Agregar antispyware
        public void Agregarantispyware(Form Pantalla, int antispyware)
        {
            picAntivirus = new PictureBox[1];
            picAntivirus[antispyware] = new PictureBox();
            picAntivirus[0].Image = Properties.Resources.antispyware;
            picAntivirus[0].Size = new System.Drawing.Size(147, 127);
            picAntivirus[0].SizeMode = PictureBoxSizeMode.StretchImage;
            picAntivirus[0].Location = new Point(126, 148);
            picAntivirus[0].BackColor = Color.Transparent;
            Pantalla.Controls.Add(picAntivirus[0]);
        }
        #endregion
        #region Sumas Variables
        public void SumaDeAnalisis()
        {
            AnalisisAntiSpyware++;
            AnalisisCortaFuegos++;
            AnalisisDescontaminador++;
            AnalisisPreventor++;
        }
        public void SumaAntiSpyware()
        {
            AnalisisAntiSpyware++;            
        }
        public void SumaCortaFuegos()
        {
           AnalisisCortaFuegos++;            
        }
        public void SumaDescontaminador()
        {
            AnalisisDescontaminador++;
        }
        public void SumaPreventor()
        {
            AnalisisPreventor++;
        }
        #endregion



    }
}
