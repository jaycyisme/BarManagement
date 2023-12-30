using Bar_Management.BusinessLogic;
using Bar_Management.DAO;
using Bar_Management.Models;
using Bar_Management.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Bar_Management.Interfaces {
    public partial class test1: Form {
        private readonly BindingList<Setting> _table;
        private readonly SettingLogic _settingLogic;
        public test1() {
            _settingLogic = new SettingLogic();
            InitializeComponent();
            _table = new BindingList<Setting>(_settingLogic.GetAll().ToList());
            dataGridView1.DataSource = _table;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private async void button1_Click(object sender, EventArgs e) {
            var selectedRow = dataGridView1.SelectedRows[0];

            if (selectedRow != null) {
                Setting setting = new Setting();
                setting.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                
                if (_settingLogic.Delete(setting)) {
                    MessageBox.Show("dsss");
                    _table.Remove(setting);
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }

            }
        }

        private async void button2_Click(object sender, EventArgs e) {
            if (!String.IsNullOrEmpty(textBox1.Text)) {
                var setting = new Setting();
                setting.NgonNgu = textBox1.Text;
                if (_settingLogic.Update(setting)) {
                    MessageBox.Show("true");
                    _table.Add(setting);
                }
                
            }
        }

        private void test1_Load(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {
            int id = int.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
            var settingCu = _settingLogic.GetAll().SingleOrDefault(c => c.Id == id);
            settingCu.NgonNgu = textBox1.Text;
            if (_settingLogic.Update(settingCu)) {
                int index = dataGridView1.SelectedRows[0].Index;
                MessageBox.Show("true");
                _table.RemoveAt(index);
                _table.Insert(index, settingCu);
                dataGridView1.Rows[index].Selected = true;
            }
        }

        private void button4_Click(object sender, EventArgs e) {

            new testSukien().ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
}
