namespace WF_Biblioteca_Design_GrupoA.Vista
{
    partial class Alert
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
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pcbCerrarApp = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlControl.Controls.Add(this.lblTitulo);
            this.pnlControl.Controls.Add(this.pcbCerrarApp);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(0, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(400, 45);
            this.pnlControl.TabIndex = 2;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            // 
            // pcbCerrarApp
            // 
            this.pcbCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrarApp.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.close_button;
            this.pcbCerrarApp.Location = new System.Drawing.Point(364, 10);
            this.pcbCerrarApp.Name = "pcbCerrarApp";
            this.pcbCerrarApp.Size = new System.Drawing.Size(24, 23);
            this.pcbCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrarApp.TabIndex = 2;
            this.pcbCerrarApp.TabStop = false;
            this.pcbCerrarApp.Click += new System.EventHandler(this.pcbCerrarApp_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(122, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Example Text";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Black;
            this.lblMensaje.Location = new System.Drawing.Point(131, 102);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(134, 18);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "Mesaje de Ejemplo";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 191);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pcbCerrarApp;
        private System.Windows.Forms.Label lblMensaje;
    }
}