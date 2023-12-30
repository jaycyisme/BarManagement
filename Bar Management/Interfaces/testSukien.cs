using Bar_Management.DAO;
using Bar_Management.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class testSukien: Form {
        private readonly AppDbContext _context;
        private readonly BindingList<SuKien> _suKien;
        public testSukien() {
            _context = AppDbContextSingleton.Instance;
            InitializeComponent();
            _suKien = new BindingList<SuKien>(_context.SuKiens.AsNoTracking().ToList());
            dataGridView1.DataSource = _suKien;
        }

        private async void button1_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                SuKien sukien = new SuKien();
                sukien.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);


                _context.SuKiens.Remove(sukien);
                _context.SaveChanges();
                dataGridView1.Rows.RemoveAt(selectedRow.Index);



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


                _context.SuKiens.Remove(sukien);
                _context.SaveChanges();
                MessageBox.Show("dsss");
                _suKien.Remove(sukien);
                dataGridView1.Rows.RemoveAt(selectedRow.Index);

            }
        }
    }
}
