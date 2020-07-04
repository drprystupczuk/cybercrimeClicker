namespace Final_Estructura
{
    partial class frmCarga
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
            this.Cambiofrm = new System.Windows.Forms.Timer(this.components);
            this.picFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // Cambiofrm
            // 
            this.Cambiofrm.Interval = 4000;
            this.Cambiofrm.Tick += new System.EventHandler(this.Cambiofrm_Tick);
            // 
            // picFondo
            // 
            this.picFondo.ErrorImage = null;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(100, 50);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarga";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        public System.Windows.Forms.Timer Cambiofrm;
    }
}