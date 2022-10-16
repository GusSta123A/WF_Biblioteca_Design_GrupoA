using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary_GurpoA.Repositorio;
using ClassLibrary_GurpoA.Modelo;

namespace WF_Biblioteca_Design_GrupoA.Vista.CRUD
{
    public partial class FrmCrudRol : Form
    {
        private int? id;
        private RolRepositorio repositorio;
        private Ctr_Rol rol;
        private Alert alert;
        public FrmCrudRol(int? id = null)
        {
            InitializeComponent();
            
            //- Si pasamos un ID de rol significa que editaremos, caso contrario crearemos uno nuevo
            this.id = id;
            
            //- Titulo dependiendo de la edicion o inserción de un registro
            if (id!=null) { lblTitulo.Text = "Edición de Rol"; }
            else { lblTitulo.Text = "Agregar nuevo Rol";  }

            //- Inicialización del repositorio
            this.repositorio = new RolRepositorio();

            //- Inicialización de objeto de rol
            this.rol = new Ctr_Rol();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //- Seteando nombre del rol
            this.rol.rol_name = txtRolName.Text;

            //- Agregar desde repositorio
            if (this.repositorio.Save(this.rol) > 0)
            {
                alert = new Alert("Rol Agregado", "Se agregó el registro satisfactoriamente.");
                alert.ShowDialog();
                this.Close();
            }
            else
            {
                alert = new Alert("Error", "Ha ocurrido un error inesperado.");
                alert.ShowDialog();
                this.Close();
            }

        }

    }
}
