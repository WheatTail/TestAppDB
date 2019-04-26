using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestApp
{
    public partial class LoginForm : Form
    {

        public SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        public string CurrentUserLogin = string.Empty;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            SqlCommand loginAttempt = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login=@Login AND Password=@Password", sqlConnection);
            loginAttempt.Parameters.AddWithValue("Login", SqlDbType.NVarChar).Value = LoginText.Text;
            loginAttempt.Parameters.AddWithValue("Password", SqlDbType.NVarChar).Value = PasswordText.Text;
            try
            {
                await sqlConnection.OpenAsync();
                if ((int)await loginAttempt.ExecuteScalarAsync() == 1)
                {
                    CurrentUserLogin = LoginText.Text;
                }
                else
                {
                    MessageBox.Show("Логин или пароль неверны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }                
            }
            catch (SqlException SE)
            {
                MessageBox.Show(SE.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString(), "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
            UserForm userForm = new UserForm(this)
            {
                Owner = this
            };
            userForm.Show();
            Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegiserLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this)
            {
                Owner = this
            };
            registerForm.Show();
            Hide();
        }
    }
}
