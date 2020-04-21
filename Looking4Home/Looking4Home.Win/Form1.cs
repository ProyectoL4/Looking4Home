using Looking4Home.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looking4Home.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            productosBLBindingSource.DataSource = listadeProductos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
