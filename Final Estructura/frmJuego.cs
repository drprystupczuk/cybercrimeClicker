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
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }


        ClaseCola EDCola = new ClaseCola();
        ClassPila estructuraPila = new ClassPila();

        SoundPlayer SonidoJuego = new SoundPlayer();
         
        #region declaracion de obj
        claseAntivirus objGeneral=new claseAntivirus();
        claseAntivirus objPreventor = new claseAntivirus();
        claseAntivirus objCortaFuegos = new claseAntivirus();
        claseAntivirus objAntiSpyware = new claseAntivirus();
        claseAntivirus objDescontaminador = new claseAntivirus();
        #endregion

        static public int segundosrestantes;

        static public int Seguridad;
        static public int Virus;
        static public int Preventor;
        static public int CortaFuegos;
        static public int AntiSpyware;
        static public int Descontaminador;
        static public int Mejoras;

        static public Boolean NivelTerminado = false;        

        private void frmJuego_Load(object sender, EventArgs e)
        {
            #region INICIALIZACIÓN DE VARIABLES
            segundosrestantes = 30;
            Seguridad = 0;
            Virus = 0;
            Preventor = 0;
            CortaFuegos = 0;
            AntiSpyware = 0;
            Descontaminador = 0;
            Mejoras = 1;
            #endregion

            SonidoJuego.SoundLocation = "juego.wav";
            SonidoJuego.PlayLooping();

            MessageBox.Show("Disfruta protegiendo la PC (mientras puedas hacerlo)");
            cmdAnalisisAntiSpyware.Enabled = false;
            cmdAnalisisPreventor.Enabled = false;
            cmdAnalisisDescontaminador.Enabled = false;
            cmdAnalisisCortaFuego.Enabled = false;
            cmdAnalisisBasico.Enabled = false;
            cmdAnalisisCompleto.Enabled = false;
            cmdMejorar.Enabled = false;
            Everytick.Start();

            
            ListaCola.Items.Clear();
        }
       
        #region Comprar Software
        private void cmdComprarAntiSpyware_Click(object sender, EventArgs e)
        {
            objAntiSpyware.Agregarantispyware(this,AntiSpyware);
            objAntiSpyware.AntiSpyware = true;
            cmdComprarAntiSpyware.Enabled = false;
            cmdAnalisisAntiSpyware.Enabled = true;
           
            
            #region Spawn Virus
            if (timerVirus.Enabled == false)
            {
                timerVirus.Enabled = true;
                timerVirus.Start();
            }
            #endregion

            #region Comprar Todo
            if (objAntiSpyware.AntiSpyware == true && objCortaFuegos.Cortafuegos == true && objDescontaminador.Descontaminador == true && objPreventor.Preventor == true)
            {
                lblIndicador.Visible = false;
                cmdMejorar.Enabled = true;
                cmdAnalisisCompleto.Enabled = true;
                cmdAnalisisBasico.Enabled = true;
                timerNivel.Enabled = true;
                timerNivel.Start();
                TimerSegundos.Enabled = true;
                TimerSegundos.Start();
            }
            #endregion
        }

        private void cmdComprarPreventor_Click(object sender, EventArgs e)
        {
            objPreventor.Agregarpreventor(this, Preventor);
            objPreventor.Preventor = true;
            cmdComprarPreventor.Enabled = false;
            cmdAnalisisPreventor.Enabled = true;
            #region Spawn Virus
            if (timerVirus.Enabled == false)
            {
                timerVirus.Enabled = true;
                timerVirus.Start();
            }
            #endregion

            #region Comprar Todo
            if (objAntiSpyware.AntiSpyware == true && objCortaFuegos.Cortafuegos == true && objDescontaminador.Descontaminador == true && objPreventor.Preventor == true)
            {
                lblIndicador.Visible = false;
                cmdMejorar.Enabled = true;
                cmdAnalisisCompleto.Enabled = true;
                cmdAnalisisBasico.Enabled = true;
                timerNivel.Enabled = true;
                timerNivel.Start();
                TimerSegundos.Enabled = true;
                TimerSegundos.Start();
            }
            #endregion
        }

        private void cmdComprarCortafuegos_Click(object sender, EventArgs e)
        {
            objCortaFuegos.Agregarcortafuegos(this, CortaFuegos);
            objCortaFuegos.Cortafuegos = true;
            cmdComprarCortafuegos.Enabled = false;
            cmdAnalisisCortaFuego.Enabled = true;
            #region Spawn Virus
            if (timerVirus.Enabled == false)
            {
                timerVirus.Enabled = true;
                timerVirus.Start();
            }
            #endregion

            #region Comprar Todo
            if (objAntiSpyware.AntiSpyware == true && objCortaFuegos.Cortafuegos == true && objDescontaminador.Descontaminador == true && objPreventor.Preventor == true)
            {
                lblIndicador.Visible = false;
                cmdMejorar.Enabled = true;
                cmdAnalisisCompleto.Enabled = true;
                cmdAnalisisBasico.Enabled = true;
                timerNivel.Enabled = true;
                timerNivel.Start();
                TimerSegundos.Enabled = true;
                TimerSegundos.Start();
            }
            #endregion
        }

        private void cmdComprarDescontaminador_Click(object sender, EventArgs e)
        {
            cmdAnalisisDescontaminador.Enabled = true;
            objDescontaminador.AgregarDescontaminador(this, Descontaminador);
            objDescontaminador.Descontaminador = true;
            cmdComprarDescontaminador.Enabled = false;

            #region Spawn Virus
            if (timerVirus.Enabled == false)
            {
                timerVirus.Enabled = true;
                timerVirus.Start();
            }
            #endregion


            #region Comprar Todo
            if (objAntiSpyware.AntiSpyware == true && objCortaFuegos.Cortafuegos == true && objDescontaminador.Descontaminador == true && objPreventor.Preventor == true)
            {
                lblIndicador.Visible = false;
                cmdMejorar.Enabled = true;
                cmdAnalisisCompleto.Enabled = true;
                cmdAnalisisBasico.Enabled = true;
                timerNivel.Enabled = true;
                timerNivel.Start();
                TimerSegundos.Enabled = true;
                TimerSegundos.Start();
            }
            #endregion
        }

        #endregion

        #region RealizarAnalisis
        private void cmdAnalisisCompleto_Click(object sender, EventArgs e)
        {
            Virus -= 30*Mejoras;
            Seguridad += 30*Mejoras;
            cmdAnalisisCompleto.Enabled = false;
            timerAnalisisCompleto.Enabled = true;
            timerAnalisisCompleto.Start();
            objGeneral.SumaDeAnalisis();

            #region Acciones de la cola y Pila
            EDCola.Crear(cmdAnalisisCompleto.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);

            estructuraPila.Crear(cmdAnalisisCompleto.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion

        }

        private void cmdAnalisisBasico_Click(object sender, EventArgs e)
        {
            Virus -= 10*Mejoras;
            Seguridad += 10*Mejoras;
            cmdAnalisisBasico.Enabled = false;
            timerAnalisisBasico.Enabled = true;
            timerAnalisisBasico.Start();            
            objGeneral.SumaDeAnalisis();

            #region Acciones de la cola y pila
            EDCola.Crear(cmdAnalisisBasico.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);

            estructuraPila.Crear(cmdAnalisisBasico.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion
        }

        private void cmdAnalisisCortaFuego_Click(object sender, EventArgs e)
        {
            Virus -= 3*Mejoras;
            Seguridad += 3*Mejoras;
            cmdAnalisisCortaFuego.Enabled = false;
            timerCortaFuego.Enabled = true;
            timerCortaFuego.Start();
            objGeneral.SumaCortaFuegos();

            #region Acciones de la cola y pila
            EDCola.Crear(cmdAnalisisCortaFuego.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);

            estructuraPila.Crear(cmdAnalisisCortaFuego.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion;
        }

        private void cmdAnalisisPreventor_Click(object sender, EventArgs e)
        {
            Virus -= 6*Mejoras;
            Seguridad+=6*Mejoras;
            cmdAnalisisPreventor.Enabled = false;
            timerPreventor.Enabled = true;
            timerPreventor.Start();
            objGeneral.SumaPreventor();
            
            #region Acciones de la cola y pila
            EDCola.Crear(cmdAnalisisPreventor.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);

            estructuraPila.Crear(cmdAnalisisPreventor.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion
        }

        private void cmdAnalisisDescontaminador_Click(object sender, EventArgs e)
        {
            Virus -= 8*Mejoras;
            Seguridad += 8*Mejoras;
            cmdAnalisisDescontaminador.Enabled = false;
            timerDescontaminador.Enabled = true;
            timerDescontaminador.Start();
            objGeneral.SumaDescontaminador();
            
            #region Acciones de la cola y pila
            EDCola.Crear(cmdAnalisisDescontaminador.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);

            estructuraPila.Crear(cmdAnalisisDescontaminador.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion
        }

        private void cmdAnalisisAntiSpyware_Click(object sender, EventArgs e)
        {
            Virus -= 6*Mejoras;
            Seguridad += 6*Mejoras;
            cmdAnalisisAntiSpyware.Enabled = false;
            timerAntiSpyware.Enabled = true;
            timerAntiSpyware.Start();

            objGeneral.SumaAntiSpyware();
           

            #region Acciones de la cola y pila
            EDCola.Crear(cmdAnalisisAntiSpyware.Text);
            ListaCola.Items.Clear();
            EDCola.Listar(ListaCola);


            estructuraPila.Crear(cmdAnalisisAntiSpyware.Text);
            ListaPila.Items.Clear();
            estructuraPila.Listar(ListaPila);
            #endregion
        }

        #endregion

        #region Fin temporizadores
        private void timerAnalisisCompleto_Tick(object sender, EventArgs e)
        {
            cmdAnalisisCompleto.Enabled = true;
            timerAnalisisCompleto.Stop();
            timerAnalisisCompleto.Enabled = false;
        }

        private void timerAnalisisBasico_Tick(object sender, EventArgs e)
        {
            cmdAnalisisBasico.Enabled = true;
            timerAnalisisBasico.Stop();
            timerAnalisisBasico.Enabled = false;
        }

        private void timerCortaFuego_Tick(object sender, EventArgs e)
        {
            cmdAnalisisCortaFuego.Enabled = true;
            timerCortaFuego.Stop();
            timerCortaFuego.Enabled = false;

        }

        private void timerPreventor_Tick(object sender, EventArgs e)
        {
            cmdAnalisisPreventor.Enabled = true;
            timerPreventor.Stop();
            timerPreventor.Enabled = false;
        }

        private void timerDescontaminador_Tick(object sender, EventArgs e)
        {
            cmdAnalisisDescontaminador.Enabled = true;
            timerDescontaminador.Stop();
            timerDescontaminador.Enabled = false;
        }

        private void timerAntiSpyware_Tick(object sender, EventArgs e)
        {
            cmdAnalisisAntiSpyware.Enabled = true;
            timerAntiSpyware.Stop();
            timerAntiSpyware.Enabled = false;
        }
        #endregion

        private void cmdMejorar_Click(object sender, EventArgs e)
        {
            cmdMejorar.Enabled = false;
            timerMejorar.Enabled = true;
            timerMejorar.Start();
            Mejoras++;

        }

        private void timerMejorar_Tick(object sender, EventArgs e)
        {
            cmdMejorar.Enabled = true;
            timerMejorar.Stop();
            timerMejorar.Enabled = false;
        }

        private void timerVirus_Tick(object sender, EventArgs e)
        {
            Virus += 30;
            Seguridad -= 30;
        }

        private void Everytick_Tick(object sender, EventArgs e)
        {
            #region IF Virus
            if (Virus>0)
            {
                lblCantidadVirus.Text = "Virus: " + Virus.ToString();
            }
            else
            {
                lblCantidadVirus.Text = "Virus: 0";
            }
            #endregion

            #region IF Seguridad
            if (Seguridad>50)
            {
                lblProteccionDelEquipo.Text = "Proteccion del equipo: Excelente";
                lblProteccionDelEquipo.ForeColor = Color.Lime;
            }
            else if (Seguridad > 25 && Seguridad <50)
            {
                lblProteccionDelEquipo.Text = "Proteccion del equipo: Muy Buena";
                lblProteccionDelEquipo.ForeColor = Color.Green;
            }
            else if (Seguridad > 0 && Seguridad <= 25)
            {
                lblProteccionDelEquipo.Text = "Proteccion del equipo: Buena";
                lblProteccionDelEquipo.ForeColor = Color.Yellow;
            }
            else if (Seguridad > -25 && Seguridad <= 0)
            {
                lblProteccionDelEquipo.Text = "Proteccion del equipo: Mala";
                lblProteccionDelEquipo.ForeColor = Color.Orange;
            }
            else if (Seguridad < -25)
            {
                lblProteccionDelEquipo.Text = "Proteccion del equipo: De Terror";
                lblProteccionDelEquipo.ForeColor = Color.Red;
            }

            #endregion


            lblPreventores.Text = "Analisis Preventores: "+ objGeneral.AnalisisPreventor.ToString();
            lblDescontaminador.Text = "Analisis Descontaminadores: " + objGeneral.AnalisisDescontaminador.ToString();
            lblCortafuegos.Text = "Analisis Cortafuegos: " + objGeneral.AnalisisCortaFuegos.ToString();
            lblAntiSpyware.Text = "Analisis AntiSpyware: " + objGeneral.AnalisisAntiSpyware.ToString();
            lblTiempoRestante.Text = "Tiempo Restante: " + segundosrestantes.ToString();
            

            
            
        }

        private void timerNivel_Tick(object sender, EventArgs e)
        {
            NivelTerminado = true;
            frmCarga carga = new frmCarga();
            carga.Show();
            this.Close();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picIES_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ies21.edu.ar/");
        }

        private void TimerSegundos_Tick(object sender, EventArgs e)
        {
            if (segundosrestantes>0)
            {
                segundosrestantes--;
            }
            
        }

        private void cmdComprarAntiSpyware_EnabledChanged(object sender, EventArgs e)
        {
            
        }

    }
}
