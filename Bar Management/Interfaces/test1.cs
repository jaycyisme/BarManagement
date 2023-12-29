using Bar_Management.DAO;
using Bar_Management.DTO;
using Bar_Management.Models;
using Bar_Management.Tool;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class test1: Form {
        private readonly AppDbContext _context;
        private readonly GenericRepository<Setting> _repository;
        private readonly BindingList<Setting> _settings;
        public test1() {
            _repository = new GenericRepository<Setting>();
            _context = AppDbContextSingleton.Instance;
            InitializeComponent();
            _settings = new BindingList<Setting>(_context.Settings.ToList());
            dataGridView1.DataSource = _settings;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private async void button1_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                Setting setting = new Setting();
                setting.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                setting.NgonNgu = selectedRow.Cells["NgonNgu"].Value.ToString();

                Result result =  _repository.Delete(setting);
                if (result.IsSuccess) {
                    MessageBox.Show("dsss");
                    _settings.Remove(setting);
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox1.Text)) {
                var setting = new Setting();
                setting.NgonNgu = textBox1.Text;
                 _repository.Insert(setting);
                _settings.Add(setting);
            }
        }

        private void test1_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            var setting = new Setting();
            setting.NgonNgu = textBox1.Text;
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            var settingCu = _repository.GetAll().SingleOrDefault(c => c.Id == id);
            settingCu.NgonNgu = textBox1.Text;
            DbContextStatic.DbContext.Update(settingCu);
            DbContextStatic.DbContext.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e) {
            new testSukien().ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
