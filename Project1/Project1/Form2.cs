using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form2 : Form
    {
        private string connectionString = "data source=stud-mssql.sttec.yar.ru,38325;user id=user121_db;password=user121;MultipleActiveResultSets=True;App=EntityFramework";

        public Form2()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string password = passwordBox.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT id_role FROM Polzovatel WHERE Email = '{email}' AND Password = '{password}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int idRole = Convert.ToInt32(result);
                            MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (idRole == 1)
                            {
                                Form4 form4 = new Form4();
                                form4.Show();
                            }
                            else if (idRole == 2)
                            {
                                Form5 form5 = new Form5();
                                form5.Show();
                            }
                            this.Hide(); 
                        }
                        else
                        {
                            MessageBox.Show("Неверный Email или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
