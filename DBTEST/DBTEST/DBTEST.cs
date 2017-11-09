using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBTEST.DatabaseManager;
using DBTEST.Model;
using MySql.Data;

namespace DBTEST
{
    public partial class DBTEST : Form
    {
        DataAccess dataAccess;
        StaffUser currentUser;
        public DBTEST()
        {
            InitializeComponent();
        }

        private void DBTEST_Load(object sender, EventArgs e)
        {
            string connection_string = @"server=localhost;user id=root;password=123456a@;persistsecurityinfo=True;database=swilifecore";
            try
            {
                dataAccess = new DataAccess(connection_string);
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StaffUser user = new StaffUser()
            {
                UserName = textBoxUserName.Text.Trim(),
                Password = textBoxPassword.Text.Trim(),
                Salt = "123456",
                Role = (StaffUser.StaffRole)comboBoxRole.SelectedIndex
            };
            try
            {
                dataAccess.executeNonQuery(QueryBuilder.Create(user));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
                return;
            try
            {
                dataAccess.executeNonQuery(QueryBuilder.Delete(currentUser));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
                return;
            try
            {
                currentUser.UserName = textBoxUserName.Text.Trim();
                currentUser.Password = textBoxPassword.Text.Trim();
                currentUser.Role = (StaffUser.StaffRole)comboBoxRole.SelectedIndex;
                dataAccess.executeNonQuery(QueryBuilder.Update(currentUser));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string query = "Select * from staffuser";
            try
            {
                dataGridViewUser.DataSource = dataAccess.getTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= dataGridViewUser.Rows.Count)
                return;
            try
            {
                currentUser = new StaffUser()
                {
                    Index = int.Parse(dataGridViewUser.Rows[row].Cells[0].Value.ToString()),
                    UserName = dataGridViewUser.Rows[row].Cells[1].Value.ToString(),
                    PasswordHash = dataGridViewUser.Rows[row].Cells[2].Value.ToString(),
                    Salt = dataGridViewUser.Rows[row].Cells[3].Value.ToString(),
                    Role = (StaffUser.StaffRole)int.Parse(dataGridViewUser.Rows[row].Cells[4].Value.ToString())
                };

                textBoxUserName.Text = currentUser.UserName;
                textBoxPassword.Text = "******";
                comboBoxRole.SelectedIndex = (int)currentUser.Role;
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Cannot connect to database, error = {0}!", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
