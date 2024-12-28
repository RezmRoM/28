using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form3 : Form
    {
        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";

        public Form3()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string family = familyBox.Text;
            string otchestvo = otchestvoBox.Text;
            string email = emailBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(family) ||
                string.IsNullOrWhiteSpace(otchestvo) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"INSERT INTO Polzovatel (Name, Family, Otchestvo, Email, Password, id_role) VALUES ('{name}', '{family}', '{otchestvo}', '{email}', '{password}', 1)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1 form1 = new Form1();
                            form1.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Регистрация не удалась.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
