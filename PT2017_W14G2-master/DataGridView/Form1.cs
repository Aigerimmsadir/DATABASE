using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using MySql.Data.MySqlClient;
namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int page = 1;
        MySqlConnection mySqlConnection;
        MySqlDataAdapter mySqlDataAdapter;
        MySqlCommandBuilder mySqlCommandBuilder;
        DataTable dataTable;
        BindingSource bindingSource;

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                            "SERVER=localhost;" +
                            "DATABASE=phone;" +
                            "UID=root;" +
                            "PASSWORD=;");


            mySqlConnection.Open();

            string query = "SELECT * FROM phonebook order by id asc";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int res = mySqlDataAdapter.Update(dataTable);
            toolStripStatusLabel1.Text = res.ToString();
        }

        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell c = dataGridView1[e.ColumnIndex, e.RowIndex];
            string str = c.FormattedValue as string;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
 "SERVER=localhost;" +
 "DATABASE=phone;" +
 "UID=root;" +
 "PASSWORD=;");

            mySqlConnection.Open();
            string k = textBox1.Text;
            string query = string.Format("SELECT * FROM phonebook WHERE name LIKE '%{0}' order by id asc", k);

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string sort = "asc";
        private void button3_Click(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                 "SERVER=localhost;" +
                 "DATABASE=phone;" +
                 "UID=root;" +
                 "PASSWORD=;");


            mySqlConnection.Open();

            string query = String.Format("SELECT * FROM phonebook order by id {0}", sort);

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            mySqlConnection = new MySqlConnection(
                            "SERVER=localhost;" +
                            "DATABASE=phone;" +
                            "UID=root;" +
                            "PASSWORD=;");


            mySqlConnection.Open();

            string query = "SELECT * FROM phonebook order by date asc";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }
 
        private void button6_Click(object sender, EventArgs e)
        {

            mySqlConnection = new MySqlConnection(
                            "SERVER=localhost;" +
                            "DATABASE=phone;" +
                            "UID=root;" +
                            "PASSWORD=;");


            mySqlConnection.Open();

            string query = "SELECT * FROM phonebook order by date desc";
            sort = "desc";
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                                       "SERVER=localhost;" +
                                       "DATABASE=phone;" +
                                       "UID=root;" +
                                       "PASSWORD=;");


            mySqlConnection.Open();

            string query = "SELECT * FROM phonebook order by id asc";

            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delte(object sender, EventArgs e)
        {
            mySqlConnection = new MySqlConnection(
                                      "SERVER=localhost;" +
                                      "DATABASE=phone;" +
                                      "UID=root;" +
                                      "PASSWORD=;");


            mySqlConnection.Open();

            string query = "DELETE * FROM phonebook WHERE ";
            mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
            mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
            mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
            mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

            dataTable = new DataTable();
            mySqlDataAdapter.Dispose();
            ///Fill(dataTable);

            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;

            dataGridView1.DataSource = bindingSource;
            bindingNavigator1.BindingSource = bindingSource;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
        private void button6_Click_1(object sender, EventArgs e)
        {

          if (page == 1)
            {
                mySqlConnection = new MySqlConnection(
    "SERVER=localhost;" +
    "DATABASE=phone;" +
    "UID=root;" +
    "PASSWORD=;");

                mySqlConnection.Open();
                string k = textBox1.Text;

                string query = "SELECT * FROM phonebook Limit 11,11";

                mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
                mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
                mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

                dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);

                bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;

                dataGridView1.DataSource = bindingSource;
                bindingNavigator1.BindingSource = bindingSource;
                page++;
            }
            else if (page == 2) {

              
                    mySqlConnection = new MySqlConnection(
        "SERVER=localhost;" +
        "DATABASE=phone;" +
        "UID=root;" +
        "PASSWORD=;");

                    mySqlConnection.Open();
                    string k = textBox1.Text;
                    string query = "SELECT * FROM phonebook Limit 22,11";

                    mySqlDataAdapter = new MySqlDataAdapter(query, mySqlConnection);
                    mySqlCommandBuilder = new MySqlCommandBuilder(mySqlDataAdapter);

                    mySqlDataAdapter.UpdateCommand = mySqlCommandBuilder.GetUpdateCommand();
                    mySqlDataAdapter.DeleteCommand = mySqlCommandBuilder.GetDeleteCommand();
                    mySqlDataAdapter.InsertCommand = mySqlCommandBuilder.GetInsertCommand();

                    dataTable = new DataTable();
                    mySqlDataAdapter.Fill(dataTable);

                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    dataGridView1.DataSource = bindingSource;
                    bindingNavigator1.BindingSource = bindingSource;
                    page++;

                }
         
        }
    }
}
