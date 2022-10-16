using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WF_Biblioteca_Design_GrupoA.Vista
{
    public partial class Alert : Form
    {
        public Alert(string alertType, string message)
        {
            InitializeComponent();

            //- configuracion de labels
            lblTitulo.Text = alertType;
            lblMensaje.Width = this.Width - 30;
            lblMensaje.Text = message;
           
        }

        //- Movimiento de arrastre de formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);
        
        private void pcbCerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
