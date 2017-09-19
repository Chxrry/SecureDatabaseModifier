using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureDatabaseModifier
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }
        public static string GetConnection(string server, string database, string user, string pwd)
        {
            string connectionStr = string.Format("Data Source={0};Initial Catalog={1};" + "User ID={2};Password={3}", server, database, user, pwd);
            return connectionStr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cnn = GetConnection(this.txtSQLAddress.Text, this.txtSQLDataBase.Text, this.txtSQLUser.Text, this.txtSQLPwd.Text);
            SqlConnection connection = new SqlConnection(cnn);
            try
            {
                connection.Open();
                connection.Close();
                Form1 form = new Form1(this.txtSQLAddress.Text, this.txtSQLDataBase.Text, this.txtSQLUser.Text, this.txtSQLPwd.Text);
                form.ShowDialog();
                //MessageBox_New.Success("连接成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
