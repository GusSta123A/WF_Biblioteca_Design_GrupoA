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
using ClassLibrary_GurpoA;
using WF_Biblioteca_Design_GrupoA.Vista;
using ClassLibrary_GurpoA.Modelo;

namespace WF_Biblioteca_Design_GrupoA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //- Movimiento de arrastre de formulario
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //- Instanciar formulario dashboard
            Dashboard dashboard = new Dashboard();

            //- Mostrar formulario
            dashboard.Show();


            //- Ocultar login
            this.Hide();

            /*try
            {
                //- Obtener contexto para conexión a base de datos
                DB_CustomerTestDBEntities dbContext = new DB_CustomerTestDBEntities();

                //- Creacion de objeto a insertar en base de datos
                Ctr_Rol rol     = new Ctr_Rol();//- Instancia de modelo de DB
                rol.rol_name    = "Administrador";
                rol.rol_id      = 2;

                //- Inserción de objeto a base de datos
                dbContext.Ctr_Rol.Add(rol);

                //- Evaluacion de cambios realizados / inserción exitosa a nivel de DB
                if (dbContext.SaveChanges() > 0)
                {
                    MessageBox.Show("Rol Agregado");
                }
                else
                {
                    MessageBox.Show("Lo sentimos, ha ocurrido un error inesperado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error de conexión: {ex}");
            }
            finally
            {

            }*/
        }
    }
}
