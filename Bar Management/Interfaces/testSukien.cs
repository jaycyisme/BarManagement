using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class testSukien: Form {
        private readonly BindingList<SuKien> _table;
        private readonly SukienLogic _sukienLogic;

        public testSukien() {
            _sukienLogic = new SukienLogic();
            InitializeComponent();
            _table = new BindingList<SuKien>(_sukienLogic.GetAll().ToList());
            dataGridView1.DataSource = _table;
        }

        private async void button1_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                SuKien sukien = new SuKien();
                sukien.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            }
        }

        private void testSukien_Load(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                SuKien sukien = new SuKien();
                sukien.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (_sukienLogic.Delete(sukien)) {
                    MessageBox.Show("dsss");
                    _table.Remove(sukien);
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }
                

            }
        }
    }
}
