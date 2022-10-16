using ClassLibrary_GurpoA.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Biblioteca_Design_GrupoA.Vista.CRUD;

namespace WF_Biblioteca_Design_GrupoA.Vista
{
    public partial class FrmRol : Form
    {
        private RolRepositorio repositorio;
        public FrmRol()
        {
            InitializeComponent();
            this.repositorio = new RolRepositorio();

            //- Load info
            LoadInfo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmCrudRol crud = new FrmCrudRol();
            crud.ShowDialog();
            LoadInfo();
        }

        public void LoadInfo()
        {
            dgvRol.DataSource = repositorio.GetAll();
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {

        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
