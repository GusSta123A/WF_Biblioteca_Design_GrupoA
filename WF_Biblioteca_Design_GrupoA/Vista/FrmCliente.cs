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

namespace WF_Biblioteca_Design_GrupoA.Vista
{
    public partial class FrmCliente : Form
    {
        private RolRepositorio repositorio;
        public FrmCliente()
        {
            InitializeComponent();
            repositorio = new RolRepositorio();
            LoadInfo();
        }

        public void LoadInfo()
        {
            dgvCliente.DataSource = repositorio.GetAll();
        }
    }

}
    
