namespace WF_Biblioteca_Design_GrupoA.Vista.CRUD
{
    partial class FrmCrudRol
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbCerrarApp = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtRolName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(520, 55);
            this.pnlControl.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Texto de Ejemplo";
            // 
            // pcbCerrarApp
            // 
            this.pcbCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrarApp.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.close_button;
            this.pcbCerrarApp.Location = new System.Drawing.Point(472, 12);
            this.pcbCerrarApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCerrarApp.Name = "pcbCerrarApp";
            this.pcbCerrarApp.Size = new System.Drawing.Size(32, 28);
            this.pcbCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrarApp.TabIndex = 2;
            this.pcbCerrarApp.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(88, 193);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(328, 57);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtRolName
            // 
            this.txtRolName.Location = new System.Drawing.Point(89, 128);
            this.txtRolName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRolName.Name = "txtRolName";
            this.txtRolName.Size = new System.Drawing.Size(327, 22);
            this.txtRolName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre ";
            // 
            // FrmCrudRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRolName);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCrudRol";
            this.Text = "FrmCrudRol";
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtRolName;
        private System.Windows.Forms.Label label1;
    }
}