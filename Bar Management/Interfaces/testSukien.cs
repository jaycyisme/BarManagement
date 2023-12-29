using Bar_Management.DAO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class testSukien: Form {
        private readonly AppDbContext _context;
        private readonly GenericRepository<SuKien> _repository;
        private readonly BindingList<SuKien> _suKien;
        public testSukien() {
            _context = AppDbContextSingleton.Instance;
            _repository = new GenericRepository<SuKien>();
            InitializeComponent();
            _suKien = new BindingList<SuKien>(_context.SuKiens.ToList());
            dataGridView1.DataSource = _suKien;
        }

        private async void button1_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                SuKien sukien = new SuKien();
                sukien.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                Result result =  _repository.Delete(sukien);
                if (result.IsSuccess) {
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }


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

                Result result =  _repository.Delete(sukien);
                if (result.IsSuccess) {
                    MessageBox.Show("dsss");
                    _suKien.Remove(sukien);
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }
            }
        }
    }
}
