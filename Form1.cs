using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

namespace SecureDatabaseModifier
{
    public partial class Form1 : Form
    {
        public SqlConnection conn;
        private DataSet ds = new DataSet();
        private SqlDataAdapter myada = null;

        string txtSQLAddress = "";//数据库地址
        string txtSQLDataBase = "";//数据库名
        string txtSQLUser = "";//数据库登录名
        string txtSQLPwd = "";//数据库密码
        public Form1(string txtSQLAddress, string txtSQLDataBase, string txtSQLUser, string txtSQLPwd)
        {
            InitializeComponent();
            this.txtSQLAddress = txtSQLAddress;
            this.txtSQLDataBase = txtSQLDataBase;
            this.txtSQLUser = txtSQLUser;
            this.txtSQLPwd = txtSQLPwd;
        }
        public void open()
        {
            string cnn = Main.GetConnection(this.txtSQLAddress, this.txtSQLDataBase, this.txtSQLUser, this.txtSQLPwd);
            conn = new SqlConnection(cnn);
            conn.Open();
        }
        public void close()
        {
            conn.Close();
            conn = null;
        }
        public SqlCommand command(string cmdstring)
        {
            SqlCommand cmd = new SqlCommand(cmdstring, conn);
            return cmd;
        }
        public void login()
        {
            SqlCommand cmd = new SqlCommand("select count(*) from userInfo where username = '" + this.textBox1.Text.Trim() + "' and password = '" + this.textBox2.Text.Trim() + "'", conn);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {

                MessageBox.Show("successed");

                string cmdstring = "select * from userinfo";
                myada = new SqlDataAdapter(cmdstring, conn);
                myada.Fill(ds, "username");
                dataGridView1.DataSource = ds.Tables["username"];
            }

            else
            {
                MessageBox.Show("failed");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            open();
            login();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "D:" + "\\DefualtName.xls";
            ExportExcel(a, dataGridView1);
        }
        private void ExportExcel(string fileName, DataGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.DefaultExt = "xls";
            savedialog.Filter = "Excel|*.xls";
            savedialog.FileName = fileName;
            savedialog.ShowDialog();
            saveFileName = savedialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return;
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            if (xlapp == null)
            {
                MessageBox.Show("excel didn't installed");
                return;
            }
            Workbooks workbooks = xlapp.Workbooks;
            Workbook workbook = workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet worksheet = (Worksheet)workbook.Worksheets[1];
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            }
            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error while opening, file is occupied！\n" + ex.Message);
                }

            }
            xlapp.Quit();
            GC.Collect();
            MessageBox.Show("File： " + fileName + ".xls saved", "information box", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open();

            SqlCommandBuilder builder = new SqlCommandBuilder(myada);
            try
            {
                myada.Update(ds, "username");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("update success");
        }


        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.SelectedRows.Count; i > 0; i--)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i - 1].Index);
            }
            MessageBox.Show("data deleted");
        }
    }
}
