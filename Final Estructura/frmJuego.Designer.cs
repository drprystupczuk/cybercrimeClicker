namespace Final_Estructura
{
    partial class frmJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAnalisisCompleto = new System.Windows.Forms.Timer(this.components);
            this.cmdComprarAntiSpyware = new System.Windows.Forms.Button();
            this.cmdComprarPreventor = new System.Windows.Forms.Button();
            this.cmdComprarCortafuegos = new System.Windows.Forms.Button();
            this.cmdComprarDescontaminador = new System.Windows.Forms.Button();
            this.lblProteccionDelEquipo = new System.Windows.Forms.Label();
            this.lblCantidadVirus = new System.Windows.Forms.Label();
            this.cmdAnalisisCompleto = new System.Windows.Forms.Button();
            this.cmdAnalisisBasico = new System.Windows.Forms.Button();
            this.cmdAnalisisCortaFuego = new System.Windows.Forms.Button();
            this.cmdAnalisisPreventor = new System.Windows.Forms.Button();
            this.cmdAnalisisDescontaminador = new System.Windows.Forms.Button();
            this.cmdAnalisisAntiSpyware = new System.Windows.Forms.Button();
            this.timerAnalisisBasico = new System.Windows.Forms.Timer(this.components);
            this.timerCortaFuego = new System.Windows.Forms.Timer(this.components);
            this.timerPreventor = new System.Windows.Forms.Timer(this.components);
            this.timerDescontaminador = new System.Windows.Forms.Timer(this.components);
            this.timerAntiSpyware = new System.Windows.Forms.Timer(this.components);
            this.cmdMejorar = new System.Windows.Forms.Button();
            this.lblAntiSpyware = new System.Windows.Forms.Label();
            this.lblPreventores = new System.Windows.Forms.Label();
            this.lblCortafuegos = new System.Windows.Forms.Label();
            this.lblDescontaminador = new System.Windows.Forms.Label();
            this.timerMejorar = new System.Windows.Forms.Timer(this.components);
            this.ListaCola = new System.Windows.Forms.ListBox();
            this.ListaPila = new System.Windows.Forms.ListBox();
            this.timerVirus = new System.Windows.Forms.Timer(this.components);
            this.Everytick = new System.Windows.Forms.Timer(this.components);
            this.timerNivel = new System.Windows.Forms.Timer(this.components);
            this.lblTiempoRestante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picIES = new System.Windows.Forms.PictureBox();
            this.TimerSegundos = new System.Windows.Forms.Timer(this.components);
            this.lblIndicador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).BeginInit();
            this.SuspendLayout();
            // 
            // timerAnalisisCompleto
            // 
            this.timerAnalisisCompleto.Interval = 10000;
            this.timerAnalisisCompleto.Tick += new System.EventHandler(this.timerAnalisisCompleto_Tick);
            // 
            // cmdComprarAntiSpyware
            // 
            this.cmdComprarAntiSpyware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprarAntiSpyware.Location = new System.Drawing.Point(126, 118);
            this.cmdComprarAntiSpyware.Name = "cmdComprarAntiSpyware";
            this.cmdComprarAntiSpyware.Size = new System.Drawing.Size(147, 23);
            this.cmdComprarAntiSpyware.TabIndex = 0;
            this.cmdComprarAntiSpyware.Text = "Comprar AntiSpyware";
            this.cmdComprarAntiSpyware.UseVisualStyleBackColor = true;
            this.cmdComprarAntiSpyware.EnabledChanged += new System.EventHandler(this.cmdComprarAntiSpyware_EnabledChanged);
            this.cmdComprarAntiSpyware.Click += new System.EventHandler(this.cmdComprarAntiSpyware_Click);
            // 
            // cmdComprarPreventor
            // 
            this.cmdComprarPreventor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprarPreventor.Location = new System.Drawing.Point(126, 295);
            this.cmdComprarPreventor.Name = "cmdComprarPreventor";
            this.cmdComprarPreventor.Size = new System.Drawing.Size(147, 23);
            this.cmdComprarPreventor.TabIndex = 1;
            this.cmdComprarPreventor.Text = "Comprar  Preventor";
            this.cmdComprarPreventor.UseVisualStyleBackColor = true;
            this.cmdComprarPreventor.EnabledChanged += new System.EventHandler(this.cmdComprarAntiSpyware_EnabledChanged);
            this.cmdComprarPreventor.Click += new System.EventHandler(this.cmdComprarPreventor_Click);
            // 
            // cmdComprarCortafuegos
            // 
            this.cmdComprarCortafuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprarCortafuegos.Location = new System.Drawing.Point(609, 118);
            this.cmdComprarCortafuegos.Name = "cmdComprarCortafuegos";
            this.cmdComprarCortafuegos.Size = new System.Drawing.Size(147, 23);
            this.cmdComprarCortafuegos.TabIndex = 2;
            this.cmdComprarCortafuegos.Text = "Comprar CortaFuegos";
            this.cmdComprarCortafuegos.UseVisualStyleBackColor = true;
            this.cmdComprarCortafuegos.EnabledChanged += new System.EventHandler(this.cmdComprarAntiSpyware_EnabledChanged);
            this.cmdComprarCortafuegos.Click += new System.EventHandler(this.cmdComprarCortafuegos_Click);
            // 
            // cmdComprarDescontaminador
            // 
            this.cmdComprarDescontaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComprarDescontaminador.Location = new System.Drawing.Point(609, 300);
            this.cmdComprarDescontaminador.Name = "cmdComprarDescontaminador";
            this.cmdComprarDescontaminador.Size = new System.Drawing.Size(147, 23);
            this.cmdComprarDescontaminador.TabIndex = 3;
            this.cmdComprarDescontaminador.Text = "Descontaminador";
            this.cmdComprarDescontaminador.UseVisualStyleBackColor = true;
            this.cmdComprarDescontaminador.EnabledChanged += new System.EventHandler(this.cmdComprarAntiSpyware_EnabledChanged);
            this.cmdComprarDescontaminador.Click += new System.EventHandler(this.cmdComprarDescontaminador_Click);
            // 
            // lblProteccionDelEquipo
            // 
            this.lblProteccionDelEquipo.AutoSize = true;
            this.lblProteccionDelEquipo.BackColor = System.Drawing.Color.Black;
            this.lblProteccionDelEquipo.Location = new System.Drawing.Point(834, 128);
            this.lblProteccionDelEquipo.Name = "lblProteccionDelEquipo";
            this.lblProteccionDelEquipo.Size = new System.Drawing.Size(114, 13);
            this.lblProteccionDelEquipo.TabIndex = 4;
            this.lblProteccionDelEquipo.Text = "Proteccion del Equipo:";
            // 
            // lblCantidadVirus
            // 
            this.lblCantidadVirus.AutoSize = true;
            this.lblCantidadVirus.BackColor = System.Drawing.Color.Black;
            this.lblCantidadVirus.ForeColor = System.Drawing.Color.Red;
            this.lblCantidadVirus.Location = new System.Drawing.Point(834, 157);
            this.lblCantidadVirus.Name = "lblCantidadVirus";
            this.lblCantidadVirus.Size = new System.Drawing.Size(33, 13);
            this.lblCantidadVirus.TabIndex = 5;
            this.lblCantidadVirus.Text = "Virus:";
            // 
            // cmdAnalisisCompleto
            // 
            this.cmdAnalisisCompleto.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisCompleto.ForeColor = System.Drawing.Color.Lime;
            this.cmdAnalisisCompleto.Location = new System.Drawing.Point(339, 105);
            this.cmdAnalisisCompleto.Name = "cmdAnalisisCompleto";
            this.cmdAnalisisCompleto.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisCompleto.TabIndex = 6;
            this.cmdAnalisisCompleto.Text = "Analisis Completo General";
            this.cmdAnalisisCompleto.UseVisualStyleBackColor = false;
            this.cmdAnalisisCompleto.Click += new System.EventHandler(this.cmdAnalisisCompleto_Click);
            // 
            // cmdAnalisisBasico
            // 
            this.cmdAnalisisBasico.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisBasico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisBasico.ForeColor = System.Drawing.Color.Yellow;
            this.cmdAnalisisBasico.Location = new System.Drawing.Point(339, 146);
            this.cmdAnalisisBasico.Name = "cmdAnalisisBasico";
            this.cmdAnalisisBasico.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisBasico.TabIndex = 7;
            this.cmdAnalisisBasico.Text = "Analisis Basico General";
            this.cmdAnalisisBasico.UseVisualStyleBackColor = false;
            this.cmdAnalisisBasico.Click += new System.EventHandler(this.cmdAnalisisBasico_Click);
            // 
            // cmdAnalisisCortaFuego
            // 
            this.cmdAnalisisCortaFuego.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisCortaFuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisCortaFuego.ForeColor = System.Drawing.Color.White;
            this.cmdAnalisisCortaFuego.Location = new System.Drawing.Point(339, 192);
            this.cmdAnalisisCortaFuego.Name = "cmdAnalisisCortaFuego";
            this.cmdAnalisisCortaFuego.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisCortaFuego.TabIndex = 8;
            this.cmdAnalisisCortaFuego.Text = "Analisis CortaFuego";
            this.cmdAnalisisCortaFuego.UseVisualStyleBackColor = false;
            this.cmdAnalisisCortaFuego.Click += new System.EventHandler(this.cmdAnalisisCortaFuego_Click);
            // 
            // cmdAnalisisPreventor
            // 
            this.cmdAnalisisPreventor.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisPreventor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisPreventor.ForeColor = System.Drawing.Color.White;
            this.cmdAnalisisPreventor.Location = new System.Drawing.Point(339, 235);
            this.cmdAnalisisPreventor.Name = "cmdAnalisisPreventor";
            this.cmdAnalisisPreventor.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisPreventor.TabIndex = 9;
            this.cmdAnalisisPreventor.Text = "Analisis Preventor";
            this.cmdAnalisisPreventor.UseVisualStyleBackColor = false;
            this.cmdAnalisisPreventor.Click += new System.EventHandler(this.cmdAnalisisPreventor_Click);
            // 
            // cmdAnalisisDescontaminador
            // 
            this.cmdAnalisisDescontaminador.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisDescontaminador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisDescontaminador.ForeColor = System.Drawing.Color.White;
            this.cmdAnalisisDescontaminador.Location = new System.Drawing.Point(339, 280);
            this.cmdAnalisisDescontaminador.Name = "cmdAnalisisDescontaminador";
            this.cmdAnalisisDescontaminador.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisDescontaminador.TabIndex = 10;
            this.cmdAnalisisDescontaminador.Text = "Analisis Descontaminador";
            this.cmdAnalisisDescontaminador.UseVisualStyleBackColor = false;
            this.cmdAnalisisDescontaminador.Click += new System.EventHandler(this.cmdAnalisisDescontaminador_Click);
            // 
            // cmdAnalisisAntiSpyware
            // 
            this.cmdAnalisisAntiSpyware.BackColor = System.Drawing.Color.Gray;
            this.cmdAnalisisAntiSpyware.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnalisisAntiSpyware.ForeColor = System.Drawing.Color.White;
            this.cmdAnalisisAntiSpyware.Location = new System.Drawing.Point(339, 321);
            this.cmdAnalisisAntiSpyware.Name = "cmdAnalisisAntiSpyware";
            this.cmdAnalisisAntiSpyware.Size = new System.Drawing.Size(171, 23);
            this.cmdAnalisisAntiSpyware.TabIndex = 11;
            this.cmdAnalisisAntiSpyware.Text = "Analisis AntiSpyware";
            this.cmdAnalisisAntiSpyware.UseVisualStyleBackColor = false;
            this.cmdAnalisisAntiSpyware.Click += new System.EventHandler(this.cmdAnalisisAntiSpyware_Click);
            // 
            // timerAnalisisBasico
            // 
            this.timerAnalisisBasico.Interval = 5000;
            this.timerAnalisisBasico.Tick += new System.EventHandler(this.timerAnalisisBasico_Tick);
            // 
            // timerCortaFuego
            // 
            this.timerCortaFuego.Interval = 2000;
            this.timerCortaFuego.Tick += new System.EventHandler(this.timerCortaFuego_Tick);
            // 
            // timerPreventor
            // 
            this.timerPreventor.Interval = 500;
            this.timerPreventor.Tick += new System.EventHandler(this.timerPreventor_Tick);
            // 
            // timerDescontaminador
            // 
            this.timerDescontaminador.Interval = 3000;
            this.timerDescontaminador.Tick += new System.EventHandler(this.timerDescontaminador_Tick);
            // 
            // timerAntiSpyware
            // 
            this.timerAntiSpyware.Interval = 500;
            this.timerAntiSpyware.Tick += new System.EventHandler(this.timerAntiSpyware_Tick);
            // 
            // cmdMejorar
            // 
            this.cmdMejorar.BackColor = System.Drawing.Color.Gray;
            this.cmdMejorar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMejorar.ForeColor = System.Drawing.Color.Lime;
            this.cmdMejorar.Location = new System.Drawing.Point(316, 512);
            this.cmdMejorar.Name = "cmdMejorar";
            this.cmdMejorar.Size = new System.Drawing.Size(217, 23);
            this.cmdMejorar.TabIndex = 12;
            this.cmdMejorar.Text = "Mejorar Sotware";
            this.cmdMejorar.UseVisualStyleBackColor = false;
            this.cmdMejorar.Click += new System.EventHandler(this.cmdMejorar_Click);
            // 
            // lblAntiSpyware
            // 
            this.lblAntiSpyware.AutoSize = true;
            this.lblAntiSpyware.BackColor = System.Drawing.Color.Black;
            this.lblAntiSpyware.ForeColor = System.Drawing.Color.Lime;
            this.lblAntiSpyware.Location = new System.Drawing.Point(834, 193);
            this.lblAntiSpyware.Name = "lblAntiSpyware";
            this.lblAntiSpyware.Size = new System.Drawing.Size(110, 13);
            this.lblAntiSpyware.TabIndex = 13;
            this.lblAntiSpyware.Text = "Análisis AntiSpyware :";
            // 
            // lblPreventores
            // 
            this.lblPreventores.AutoSize = true;
            this.lblPreventores.BackColor = System.Drawing.Color.Black;
            this.lblPreventores.ForeColor = System.Drawing.Color.Lime;
            this.lblPreventores.Location = new System.Drawing.Point(834, 224);
            this.lblPreventores.Name = "lblPreventores";
            this.lblPreventores.Size = new System.Drawing.Size(105, 13);
            this.lblPreventores.TabIndex = 14;
            this.lblPreventores.Text = "Analisis Preventores:";
            // 
            // lblCortafuegos
            // 
            this.lblCortafuegos.AutoSize = true;
            this.lblCortafuegos.BackColor = System.Drawing.Color.Black;
            this.lblCortafuegos.ForeColor = System.Drawing.Color.Lime;
            this.lblCortafuegos.Location = new System.Drawing.Point(834, 263);
            this.lblCortafuegos.Name = "lblCortafuegos";
            this.lblCortafuegos.Size = new System.Drawing.Size(100, 13);
            this.lblCortafuegos.TabIndex = 15;
            this.lblCortafuegos.Text = "Analisis Cortafuego:";
            // 
            // lblDescontaminador
            // 
            this.lblDescontaminador.AutoSize = true;
            this.lblDescontaminador.BackColor = System.Drawing.Color.Black;
            this.lblDescontaminador.ForeColor = System.Drawing.Color.Lime;
            this.lblDescontaminador.Location = new System.Drawing.Point(834, 301);
            this.lblDescontaminador.Name = "lblDescontaminador";
            this.lblDescontaminador.Size = new System.Drawing.Size(142, 13);
            this.lblDescontaminador.TabIndex = 16;
            this.lblDescontaminador.Text = "Analisis Descontaminadores:";
            // 
            // timerMejorar
            // 
            this.timerMejorar.Interval = 8000;
            this.timerMejorar.Tick += new System.EventHandler(this.timerMejorar_Tick);
            // 
            // ListaCola
            // 
            this.ListaCola.BackColor = System.Drawing.Color.Red;
            this.ListaCola.FormattingEnabled = true;
            this.ListaCola.Location = new System.Drawing.Point(1020, 118);
            this.ListaCola.Name = "ListaCola";
            this.ListaCola.Size = new System.Drawing.Size(133, 355);
            this.ListaCola.TabIndex = 17;
            // 
            // ListaPila
            // 
            this.ListaPila.BackColor = System.Drawing.Color.Black;
            this.ListaPila.ForeColor = System.Drawing.Color.Red;
            this.ListaPila.FormattingEnabled = true;
            this.ListaPila.Location = new System.Drawing.Point(1207, 118);
            this.ListaPila.Name = "ListaPila";
            this.ListaPila.Size = new System.Drawing.Size(133, 355);
            this.ListaPila.TabIndex = 18;
            // 
            // timerVirus
            // 
            this.timerVirus.Interval = 3000;
            this.timerVirus.Tick += new System.EventHandler(this.timerVirus_Tick);
            // 
            // Everytick
            // 
            this.Everytick.Enabled = true;
            this.Everytick.Interval = 200;
            this.Everytick.Tick += new System.EventHandler(this.Everytick_Tick);
            // 
            // timerNivel
            // 
            this.timerNivel.Interval = 30000;
            this.timerNivel.Tick += new System.EventHandler(this.timerNivel_Tick);
            // 
            // lblTiempoRestante
            // 
            this.lblTiempoRestante.AutoSize = true;
            this.lblTiempoRestante.BackColor = System.Drawing.Color.Transparent;
            this.lblTiempoRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoRestante.ForeColor = System.Drawing.Color.Yellow;
            this.lblTiempoRestante.Location = new System.Drawing.Point(495, 706);
            this.lblTiempoRestante.Name = "lblTiempoRestante";
            this.lblTiempoRestante.Size = new System.Drawing.Size(261, 33);
            this.lblTiempoRestante.TabIndex = 19;
            this.lblTiempoRestante.Text = "Tiempo Restante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(1008, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "LISTA DE ACCCIONES:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(1204, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "PILA DE ACCCIONES:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picIES
            // 
            this.picIES.BackColor = System.Drawing.Color.Transparent;
            this.picIES.Image = global::Final_Estructura.Properties.Resources.logo_ies;
            this.picIES.Location = new System.Drawing.Point(29, 689);
            this.picIES.Name = "picIES";
            this.picIES.Size = new System.Drawing.Size(122, 67);
            this.picIES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIES.TabIndex = 22;
            this.picIES.TabStop = false;
            this.picIES.Click += new System.EventHandler(this.picIES_Click);
            // 
            // TimerSegundos
            // 
            this.TimerSegundos.Interval = 1000;
            this.TimerSegundos.Tick += new System.EventHandler(this.TimerSegundos_Tick);
            // 
            // lblIndicador
            // 
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.BackColor = System.Drawing.Color.Transparent;
            this.lblIndicador.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicador.ForeColor = System.Drawing.Color.Yellow;
            this.lblIndicador.Location = new System.Drawing.Point(72, 26);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(609, 33);
            this.lblIndicador.TabIndex = 23;
            this.lblIndicador.Text = "Para empezar debes conseguir el software";
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Estructura.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.lblIndicador);
            this.Controls.Add(this.picIES);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTiempoRestante);
            this.Controls.Add(this.ListaPila);
            this.Controls.Add(this.ListaCola);
            this.Controls.Add(this.lblDescontaminador);
            this.Controls.Add(this.lblCortafuegos);
            this.Controls.Add(this.lblPreventores);
            this.Controls.Add(this.lblAntiSpyware);
            this.Controls.Add(this.cmdMejorar);
            this.Controls.Add(this.cmdAnalisisAntiSpyware);
            this.Controls.Add(this.cmdAnalisisDescontaminador);
            this.Controls.Add(this.cmdAnalisisPreventor);
            this.Controls.Add(this.cmdAnalisisCortaFuego);
            this.Controls.Add(this.cmdAnalisisBasico);
            this.Controls.Add(this.cmdAnalisisCompleto);
            this.Controls.Add(this.lblCantidadVirus);
            this.Controls.Add(this.lblProteccionDelEquipo);
            this.Controls.Add(this.cmdComprarDescontaminador);
            this.Controls.Add(this.cmdComprarCortafuegos);
            this.Controls.Add(this.cmdComprarPreventor);
            this.Controls.Add(this.cmdComprarAntiSpyware);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJuego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer timerAnalisisCompleto;
        private System.Windows.Forms.Button cmdComprarAntiSpyware;
        private System.Windows.Forms.Button cmdComprarPreventor;
        private System.Windows.Forms.Button cmdComprarCortafuegos;
        private System.Windows.Forms.Button cmdComprarDescontaminador;
        private System.Windows.Forms.Label lblProteccionDelEquipo;
        private System.Windows.Forms.Label lblCantidadVirus;
        private System.Windows.Forms.Button cmdAnalisisCompleto;
        private System.Windows.Forms.Button cmdAnalisisBasico;
        private System.Windows.Forms.Button cmdAnalisisCortaFuego;
        private System.Windows.Forms.Button cmdAnalisisPreventor;
        private System.Windows.Forms.Button cmdAnalisisDescontaminador;
        private System.Windows.Forms.Button cmdAnalisisAntiSpyware;
        private System.Windows.Forms.Timer timerAnalisisBasico;
        private System.Windows.Forms.Timer timerCortaFuego;
        private System.Windows.Forms.Timer timerPreventor;
        private System.Windows.Forms.Timer timerDescontaminador;
        private System.Windows.Forms.Timer timerAntiSpyware;
        private System.Windows.Forms.Button cmdMejorar;
        private System.Windows.Forms.Label lblAntiSpyware;
        private System.Windows.Forms.Label lblPreventores;
        private System.Windows.Forms.Label lblCortafuegos;
        private System.Windows.Forms.Label lblDescontaminador;
        private System.Windows.Forms.Timer timerMejorar;
        private System.Windows.Forms.ListBox ListaCola;
        private System.Windows.Forms.ListBox ListaPila;
        private System.Windows.Forms.Timer timerVirus;
        private System.Windows.Forms.Timer Everytick;
        private System.Windows.Forms.Timer timerNivel;
        private System.Windows.Forms.Label lblTiempoRestante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picIES;
        private System.Windows.Forms.Timer TimerSegundos;
        private System.Windows.Forms.Label lblIndicador;
    }
}