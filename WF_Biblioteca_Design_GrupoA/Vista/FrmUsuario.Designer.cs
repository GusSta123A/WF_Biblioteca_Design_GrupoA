namespace WF_Biblioteca_Design_GrupoA.Vista
{
    partial class FrmUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Usuarios";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Location = new System.Drawing.Point(291, 12);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.Size = new System.Drawing.Size(347, 526);
            this.dgvUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(19, 78);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(246, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(19, 153);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(246, 20);
            this.txtContrasena.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardar.Image = global::WF_Biblioteca_Design_GrupoA.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(19, 197);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(246, 59);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
    }
}