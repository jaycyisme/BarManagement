
using Bar_Management.FoodForm;
using Bar_Management.HomeForm;
using Bar_Management.OrderForm;
using Bar_Management.TableForm;
using Bar_Management.CategoryForm;
using Bar_Management.EmployeeForm;
using Bar_Management.RevenueForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bar_Management.OrderHistoryForm;
using Bar_Management.AccountForm;
using Bar_Management.Interfaces.WarehouseForm;

namespace Bar_Management.MainForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void addControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addControls(new Home());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            addControls(new Order());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            addControls(new Food());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            addControls(new Table());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            addControls(new Category());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            addControls(new Employee());
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            addControls(new Revenue());
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            addControls(new OrderHistory());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            addControls(new Account());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            addControls(new Warehouse());
        }
    }
}
