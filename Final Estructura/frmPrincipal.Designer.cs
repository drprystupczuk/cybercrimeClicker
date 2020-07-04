namespace Final_Estructura
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdInciar = new System.Windows.Forms.Button();
            this.linkAcercaDe = new System.Windows.Forms.LinkLabel();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picIES = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTitulo.Location = new System.Drawing.Point(839, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 98);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Delitos Informáticos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // cmdInciar
            // 
            this.cmdInciar.BackColor = System.Drawing.Color.Crimson;
            this.cmdInciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInciar.ForeColor = System.Drawing.Color.Yellow;
            this.cmdInciar.Location = new System.Drawing.Point(554, 229);
            this.cmdInciar.Name = "cmdInciar";
            this.cmdInciar.Size = new System.Drawing.Size(208, 59);
            this.cmdInciar.TabIndex = 1;
            this.cmdInciar.Text = "Iniciar";
            this.cmdInciar.UseVisualStyleBackColor = false;
            this.cmdInciar.Click += new System.EventHandler(this.cmdInciar_Click);
            // 
            // linkAcercaDe
            // 
            this.linkAcercaDe.AutoSize = true;
            this.linkAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.linkAcercaDe.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.linkAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAcercaDe.ForeColor = System.Drawing.Color.Transparent;
            this.linkAcercaDe.LinkColor = System.Drawing.Color.Yellow;
            this.linkAcercaDe.Location = new System.Drawing.Point(628, 709);
            this.linkAcercaDe.Name = "linkAcercaDe";
            this.linkAcercaDe.Size = new System.Drawing.Size(93, 20);
            this.linkAcercaDe.TabIndex = 2;
            this.linkAcercaDe.TabStop = true;
            this.linkAcercaDe.Text = "Acerca De";
            this.linkAcercaDe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAcercaDe_LinkClicked);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.Gray;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Yellow;
            this.cmdSalir.Location = new System.Drawing.Point(554, 370);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(208, 59);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(164, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(886, 696);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Docente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1036, 696);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Juan Carlos Casale";
            // 
            // picIES
            // 
            this.picIES.BackColor = System.Drawing.Color.Transparent;
            this.picIES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIES.Image = global::Final_Estructura.Properties.Resources.logo_ies;
            this.picIES.Location = new System.Drawing.Point(37, 686);
            this.picIES.Name = "picIES";
            this.picIES.Size = new System.Drawing.Size(103, 70);
            this.picIES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIES.TabIndex = 10;
            this.picIES.TabStop = false;
            this.picIES.Click += new System.EventHandler(this.picIES_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Final_Estructura.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.picIES);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.linkAcercaDe);
            this.Controls.Add(this.cmdInciar);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.frmPrincipal_Activated);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdInciar;
        private System.Windows.Forms.LinkLabel linkAcercaDe;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picIES;
    }
}

