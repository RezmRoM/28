using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";

        public Form1()
        {
            InitializeComponent();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); 
            this.Hide();  
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(); 
            this.Hide(); 
        }
    }
}
