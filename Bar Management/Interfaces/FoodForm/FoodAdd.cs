using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.FoodForm
{
    public partial class FoodAdd : Form
    {
        public FoodAdd()
        {
            InitializeComponent();

            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FoodAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
