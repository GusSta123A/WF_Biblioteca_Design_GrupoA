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
    public partial class Dashboard : Form
    {
        private int anchoMenuLateral;
        private Boolean menuLateralFullTamaño;

        public Dashboard()
        {
            InitializeComponent();
            //- Configuracion de Formulario
            formConfig();

            //- Configuracion de animacion de Menu Lateral
            menuLateralFullTamaño   = true;//- Nos dice que inicialmente el menu esta maximizado
            anchoMenuLateral        = pnlMenuLateral.Width;//- toma el tamaño inical del menu lateral
            timerAnimacion.Stop();//- evita que el timer corra de forma automatica
        }

        //- Movimiento de arrastre de formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void formConfig()
        {
            //- Configuracion de ancho y alto
            this.Width = 900;
            this.Height = 600;
        }
        private void abrirFormlarioEnContenedor(Object formUI)
        {
            //- Remueve los controles dentro del Panel Contenedor
            if (this.pnlContenedor.Controls.Count > 0) { this.pnlContenedor.Controls.RemoveAt(0); }

            //- Configuracion del formulario a abrir
            Form formularioHijo = formUI as Form;//- Convierte objeto en un Formulario
            formularioHijo.TopLevel = false;//- No top margin
            formularioHijo.Dock = DockStyle.Fill;//- abarca todo el panel contenedor

            //-Agregar el formulario al panel contenedor
            this.pnlContenedor.Controls.Add(formularioHijo);//- Agrega el formulario hijo al contenedor
            this.pnlContenedor.Tag = formularioHijo.Tag;//- cambia el tag del contenedor al del formulario hijo

            //- Mostrar el formulario hijo
            formularioHijo.Show();
        }

        private void pcbCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbMenu_Click(object sender, EventArgs e)
        {
            timerAnimacion.Start();
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            if (menuLateralFullTamaño)
            {
                contraerMenu();
            }
            else
            {
                maximizarMenu();
            }
        }

        private void pnlControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            abrirFormlarioEnContenedor(new FrmUsuario());
            catSelect();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormlarioEnContenedor(new FrmCliente());
            catSelect();
        }

        private void contraerMenu()
        {
            //- resta al tamaño del menu en 25 puntos
            anchoMenuLateral -= 25;//- Nuevo ancho

            //- asignar el nuevo tamaño al menu
            pnlMenuLateral.Width = anchoMenuLateral;

            if (pnlMenuLateral.Width == 75)
            {
                //- tomar el ancho del menu
                anchoMenuLateral = pnlMenuLateral.Width;

                //- El menu ahora esta contraido
                menuLateralFullTamaño = false;

                //- detener animacion
                timerAnimacion.Stop();
            }
        }

        private void maximizarMenu()
        {
            //- aumenta al tamaño del menu en 25 puntos
            anchoMenuLateral += 25;//- Nuevo ancho

            //- asignar el nuevo tamaño al menu
            pnlMenuLateral.Width = anchoMenuLateral;

            if (pnlMenuLateral.Width == 250)
            {
                //- tomar el ancho del menu
                anchoMenuLateral = pnlMenuLateral.Width;

                //- El menu ahora esta contraido
                menuLateralFullTamaño = true;

                //- detener animacion
                timerAnimacion.Stop();
            }
        }

        private void catSelect()
        {
            if (menuLateralFullTamaño)
            {
                timerAnimacion.Start();
            }
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            abrirFormlarioEnContenedor(new FrmRol());
            catSelect();
        }
    }
}
