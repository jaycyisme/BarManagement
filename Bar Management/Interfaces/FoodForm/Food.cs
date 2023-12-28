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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodAdd newForm = new FoodAdd();
            newForm.Show();
        }
    }
}
