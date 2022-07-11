using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class NewUserAddForm : Form
    {
        FormUsers formUsers;

        public NewUserAddForm(FormUsers formUsers)
        {
            InitializeComponent();

            this.formUsers = formUsers;
        }

        private void NewUserAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (!Regex.IsMatch(emailTextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Ошибка! Введите корректный email!");
                emailTextBox.Text = string.Empty;
                    return;
            }


            if (string.IsNullOrEmpty(loginTextBox.Text) || string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Ошибка! Введите логин, пароль и email!");
                return;
            }
            if (phoneTextBox.Text.Length < 10)
            {
                MessageBox.Show("Ошибка! Введите правильно номер телефона!");
                return;
            }

            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(surnameTextBox.Text))
            {
                MessageBox.Show("Введите имя и фамилию корректно", "Ошибка!");
                return;
            }

            phoneTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                MessageBox.Show("Введите свой номер телефона корректно", "Ошибка!");
                return;
            }

            formUsers.AddNewUser(new FormUsers.User(passwordTextBox.Text, loginTextBox.Text, dateTextBox.Value,
                phoneTextBox.Text, emailTextBox.Text, nameTextBox.Text, surnameTextBox.Text));

            Close();
        }
        

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nameTextBox.Text, "[^А-яА-Я]"))
            {
                MessageBox.Show("Можно использовать только русские буквы!");
                nameTextBox.Text = Regex.Replace(nameTextBox.Text, "[^А-яА-Я]", "");
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs args)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Можно использовать только цифры!");
                phoneTextBox.Text = Regex.Replace(phoneTextBox.Text, "[\\D]", ""); 
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(surnameTextBox.Text, "[^А-яА-Я]"))
            {
                MessageBox.Show("Можно использовать только русские буквы!");
                surnameTextBox.Text = Regex.Replace(surnameTextBox.Text, "[^А-яА-Я]", "");
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(loginTextBox.Text, "[^A-zA-Z-0-9]"))
            {
                MessageBox.Show("Можно использовать только латинские буквы!");
                loginTextBox.Text = Regex.Replace(loginTextBox.Text, "[^A-zA-Z-0-9]", "");
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
