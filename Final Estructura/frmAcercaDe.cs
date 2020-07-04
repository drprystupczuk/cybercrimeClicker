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
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        StringBuilder queryAddress = new StringBuilder();

        private void cmdInciar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
            System.Diagnostics.Process.Start("https://www.ies21.edu.ar/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=new");
        }

        private void lblLinkedIN_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/diegoprystupczuk");
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("https://prezi.com/0w2legup9vre/delitos-informaticos/");
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {

        }


    }
}
