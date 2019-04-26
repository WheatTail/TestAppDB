using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TestApp
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm = null;
        SqlConnection sqlConnection = null;
        string ImagePath = string.Empty;
        byte[] Image;
        Regex emailCheck = new Regex("^[a-zA-Z0-9]{1,}[_]{0,1}[a-zA-Z0-9]{2,}[@][a-zA-Z0-9]{3,}[.][a-zA-Z]{2,}");

        public RegisterForm(LoginForm loginForm)
        {
            this.loginForm = loginForm as LoginForm;
            sqlConnection = loginForm.sqlConnection;
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            PasswordText.PasswordChar = '*';
            RepeatPasswordText.PasswordChar = '*';
        }

        private void LoadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadPicture = new OpenFileDialog
            {
                Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png|Все файлы(*.*)|*.*"
            };
            if (loadPicture.ShowDialog() == DialogResult.OK)
            {
                ImagePath = loadPicture.FileName;
                UserPicture.Load(ImagePath);
                using (FileStream fileStream = new FileStream(ImagePath, FileMode.Open, FileAccess.Read))
                {
                    BinaryReader binaryReader = new BinaryReader(fileStream);
                    Image = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }
            
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            SqlCommand checkUserLogin = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login=@Login", sqlConnection);
            SqlCommand registerUser = new SqlCommand("INSERT INTO Users VALUES(@Login, @Password, @Email, @Image)", sqlConnection);

            if (PasswordText.Text != RepeatPasswordText.Text || (PasswordText.Text == "" && RepeatPasswordText.Text == ""))
            {
                MessageBox.Show("Пароли не совпадают или пусты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!emailCheck.IsMatch(EmailText.Text))
            {
                MessageBox.Show("Почта не соответствует шаблону", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (UserPicture.Image == null)
            {
                MessageBox.Show("Картинка не загружена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                checkUserLogin.Parameters.AddWithValue("Login", SqlDbType.NVarChar).Value = LoginText.Text;
                if ((int)await checkUserLogin.ExecuteScalarAsync() == 1 || LoginText.Text=="")
                {
                    
                    MessageBox.Show("Логин уже занят или пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                registerUser.Parameters.AddWithValue("Login", SqlDbType.NVarChar).Value = LoginText.Text;
                registerUser.Parameters.AddWithValue("Password", SqlDbType.NVarChar).Value = PasswordText.Text;
                registerUser.Parameters.AddWithValue("Email", SqlDbType.NVarChar).Value = EmailText.Text;
                registerUser.Parameters.AddWithValue("Image", SqlDbType.VarBinary).Value = Image;

                await registerUser.ExecuteNonQueryAsync();

                loginForm.CurrentUserLogin = LoginText.Text;

                UserForm userForm = new UserForm((LoginForm)Owner)
                {
                    Owner = Owner
                };
                userForm.Show();
                Close();
            }
            catch (SqlException SE)
            {
                MessageBox.Show(SE.Message.ToString(), "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString(), "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ShowPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheck.Checked)
            {
                PasswordText.PasswordChar = '\0';
                RepeatPasswordText.PasswordChar = '\0';
            }
            else
            {
                PasswordText.PasswordChar = '*';
                RepeatPasswordText.PasswordChar = '*';
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }

    }
}
