using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Aplikacja_do_awizacji
{
    public partial class LoggingView : Form
    {
        public LoggingView()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text) ||
                string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Podaj login i hasło");
                return;
            }

            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            string hashedPassword;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }

            using (SqlConnection connection = new SqlConnection(Program.ConnectionString))
            {
                connection.Open();

                string query = "SELECT Password FROM Workers WHERE Email = '@Login'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);

                    string storedHash = command.ExecuteScalar() as string;
                    //if (storedHash != null && storedHash.Equals(ComputeSHA256Hash(password)))
                    //{
                    //    MessageBox.Show("Logowanie udane!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("B³¹d logowania. Spróbuj ponownie.");
                    //}
                }

            }
        }
    }
}
