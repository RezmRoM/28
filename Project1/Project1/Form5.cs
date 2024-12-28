using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form5 : Form
    {
        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";

        public Form5()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            k.id_knigi, 
                            k.Name, 
                            r.Razdel AS Razdel, 
                            i.Izdatelstvo AS Izdatelstvo, 
                            k.Year_izdanie 
                        FROM 
                            Knigii k
                        JOIN 
                            Razdel r ON k.id_razdel = r.id_razdel
                        JOIN 
                            Izdatelstvo i ON k.id_izdatelstvo = i.id_izdatelstvo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable); 

                        dataGridView1.DataSource = dataTable; 
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {sqlEx.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
