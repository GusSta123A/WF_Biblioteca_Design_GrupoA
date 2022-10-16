namespace WF_Biblioteca_Design_GrupoA.Vista
{
    partial class Dashboard
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnRol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.pcbCerrarApp = new System.Windows.Forms.PictureBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenuLateral.Controls.Add(this.btnRol);
            this.pnlMenuLateral.Controls.Add(this.button1);
            this.pnlMenuLateral.Controls.Add(this.btnUsuario);
            this.pnlMenuLateral.Controls.Add(this.label1);
            this.pnlMenuLateral.Controls.Add(this.pictureBox1);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(250, 600);
            this.pnlMenuLateral.TabIndex = 0;
            // 
            // btnRol
            // 
            this.btnRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRol.FlatAppearance.BorderSize = 0;
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRol.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.product;
            this.btnRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRol.Location = new System.Drawing.Point(0, 185);
            this.btnRol.Name = "btnRol";
            this.btnRol.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnRol.Size = new System.Drawing.Size(250, 45);
            this.btnRol.TabIndex = 6;
            this.btnRol.Text = "Rol";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.people;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 115);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsuario.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.grupo_de_usuarios;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 50);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnUsuario.Size = new System.Drawing.Size(250, 45);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dev Team Project";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.dev;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.pcbMenu);
            this.pnlControl.Controls.Add(this.pcbCerrarApp);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControl.Location = new System.Drawing.Point(250, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(650, 50);
            this.pnlControl.TabIndex = 1;
            this.pnlControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlControl_MouseDown);
            // 
            // pcbMenu
            // 
            this.pcbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbMenu.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.menu;
            this.pcbMenu.Location = new System.Drawing.Point(6, 12);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(31, 23);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 2;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.Click += new System.EventHandler(this.pcbMenu_Click);
            // 
            // pcbCerrarApp
            // 
            this.pcbCerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbCerrarApp.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.close_button;
            this.pcbCerrarApp.Location = new System.Drawing.Point(614, 12);
            this.pcbCerrarApp.Name = "pcbCerrarApp";
            this.pcbCerrarApp.Size = new System.Drawing.Size(24, 23);
            this.pcbCerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbCerrarApp.TabIndex = 2;
            this.pcbCerrarApp.TabStop = false;
            this.pcbCerrarApp.Click += new System.EventHandler(this.pcbCerrarApp_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(250, 50);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(650, 550);
            this.pnlContenedor.TabIndex = 2;
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Enabled = true;
            this.timerAnimacion.Interval = 5;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCerrarApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.PictureBox pcbCerrarApp;
        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerAnimacion;
    }
}