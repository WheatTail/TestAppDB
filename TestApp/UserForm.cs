using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TestApp
{
    public partial class UserForm : Form
    {
        LoginForm loginForm = null;

        public UserForm(LoginForm loginForm)
        {
            this.loginForm = loginForm as LoginForm;
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            string userEmail = string.Empty;
            SqlCommand getEmal = new SqlCommand("SELECT Email FROM Users WHERE Login=@Login", loginForm.sqlConnection);            
            SqlCommand getImage = new SqlCommand("SELECT Image FROM Users WHERE Login=@Login", loginForm.sqlConnection); 
            getEmal.Parameters.AddWithValue("Login", SqlDbType.NVarChar).Value = loginForm.CurrentUserLogin;
            getImage.Parameters.AddWithValue("Login", SqlDbType.NVarChar).Value = loginForm.CurrentUserLogin;
            try
            {
                userEmail = (string)getEmal.ExecuteScalar();
            }
            catch (SqlException SE)
            {
                MessageBox.Show(SE.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loginForm.sqlConnection.State != ConnectionState.Closed)
                {
                    loginForm.sqlConnection.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loginForm.sqlConnection.State != ConnectionState.Closed)
                {
                    loginForm.sqlConnection.Close();
                }
            }
            UserInfoLabel.Text = "Текущий пользователь: " + loginForm.CurrentUserLogin + "\nПочта: "+userEmail;
            MemoryStream imageStream = new MemoryStream((byte[])getImage.ExecuteScalar());
            UserPicture.Image = Image.FromStream(imageStream);

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (loginForm.sqlConnection.State != ConnectionState.Closed)
            {
                loginForm.sqlConnection.Close();
            }
            Application.Exit();
        }
    }
}
