namespace Final_Estructura
{
    partial class frmPantallaFin
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
            this.lblMensajeFin = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.picIES = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensajeFin
            // 
            this.lblMensajeFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensajeFin.BackColor = System.Drawing.Color.Black;
            this.lblMensajeFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeFin.Location = new System.Drawing.Point(26, 103);
            this.lblMensajeFin.Name = "lblMensajeFin";
            this.lblMensajeFin.Size = new System.Drawing.Size(1306, 244);
            this.lblMensajeFin.TabIndex = 0;
            this.lblMensajeFin.Text = "lblMensajeFin";
            this.lblMensajeFin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeFin.Click += new System.EventHandler(this.lblMensajeFin_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.BackColor = System.Drawing.Color.Crimson;
            this.cmdVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVolver.ForeColor = System.Drawing.Color.Yellow;
            this.cmdVolver.Location = new System.Drawing.Point(594, 439);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(208, 59);
            this.cmdVolver.TabIndex = 2;
            this.cmdVolver.Text = "Volver a Inicio";
            this.cmdVolver.UseVisualStyleBackColor = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // picIES
            // 
            this.picIES.BackColor = System.Drawing.Color.Transparent;
            this.picIES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIES.Image = global::Final_Estructura.Properties.Resources.logo_ies;
            this.picIES.Location = new System.Drawing.Point(25, 657);
            this.picIES.Name = "picIES";
            this.picIES.Size = new System.Drawing.Size(125, 72);
            this.picIES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIES.TabIndex = 11;
            this.picIES.TabStop = false;
            this.picIES.Click += new System.EventHandler(this.picIES_Click);
            // 
            // frmPantallaFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Estructura.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 730);
            this.Controls.Add(this.picIES);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lblMensajeFin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaFin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaFin";
            this.Load += new System.EventHandler(this.frmPantallaFin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMensajeFin;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.PictureBox picIES;

    }
}