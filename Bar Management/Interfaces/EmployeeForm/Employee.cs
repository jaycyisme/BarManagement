using Bar_Management.HomeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.EmployeeForm
{
    public partial class Employee : Form
    {
        public Employee()
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

        private void button6_Click(object sender, EventArgs e)
        {
            EmployeeAdd newFrom = new EmployeeAdd();
            newFrom.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            EmployeeAdd newFrom = new EmployeeAdd();
            newFrom.Show();
        }
    }
}
