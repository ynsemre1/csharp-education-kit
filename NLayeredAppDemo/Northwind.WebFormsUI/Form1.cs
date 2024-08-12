using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Nothwind.Business.Abstract;
using Nothwind.Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            dgwProduct.DataSource = _productService.GetAll();
        }
    }
}
