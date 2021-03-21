using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.AddProduct(new Product
            {
                Name = tbxName.Text.ToString(),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
            });

            UpdateTable();
            MessageBox.Show("Product Added!");

        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStock.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxUpdateName.Text,
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxUpdateStock.Text),
            };

            _productDal.UpdateProduct(product);

            UpdateTable();
            MessageBox.Show("Product Updated!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);

            _productDal.DeleteProduct(id);

            UpdateTable();
            MessageBox.Show("Procudt Deleted!");
        }
    }
}
