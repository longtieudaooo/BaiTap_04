using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bai_tap_04
{
    public partial class FormProduct : Form
    {
        private BindingList<Product> listProducts = new BindingList<Product>();

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            listProducts.Add(new Product("SP01", "Laptop Dell XPS 15", 35000000m, 10));
            listProducts.Add(new Product("SP02", "Điện thoại iPhone 15 Pro", 28000000m, 15));
            listProducts.Add(new Product("SP03", "Bàn phím cơ Logitech", 2500000m, 30));

            dgvProducts.DataSource = listProducts;

            if (this.MdiParent is FormMain mainForm)
            {
                mainForm.SetStatusMessage("Đã nạp danh sách sản phẩm.");
            }
        }
    }
}