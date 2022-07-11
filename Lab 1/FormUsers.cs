using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class FormUsers : Form
    {

        public static List<User> Users = new List<User>();

        public DataSourceViewer userViewer;

        public class User
        {
            //Значение переменных - логин, пароль и т.д

            public readonly string password;
            public readonly DateTime dateOfBirth;
            public string login { get; }
            public string phoneNumber { get; }
            public string email { get; }
            public string name { get; } 
            public string surname { get; }

            public User()
            {

            }

            public User(string userPassword, string userLogin, DateTime userDateofBirth, string userPhoneNumber, string userMail, string userName, string userSurname)
            {
                //Конструктор
                this.password = userPassword;
                this.login = userLogin;
                this.dateOfBirth = userDateofBirth;
                this.phoneNumber = userPhoneNumber;
                this.email = userMail;
                this.name = userName;
                this.surname = userSurname;
            }

            public object[] getUserInfo()
            {
                return new object[] { login, name, surname, phoneNumber, email };
            }

        }

        public class DataSourceViewer
        {
            public int SelectedPage { get; set;}
            public int ViewRowsOnPage { get; set; } = 3;

            public List<User> mappingUsers = new List<User>();

            public DataGridView userData;

            public DataSourceViewer(DataGridView userData)
            {
                this.userData = userData;
                userData.DataSource = mappingUsers;
            }

            public void UpdateUsers()
            {
                mappingUsers = new List<User>();
                
                int indexFromStartUsers = SelectedPage * ViewRowsOnPage; ;
                for (int i = indexFromStartUsers; i < indexFromStartUsers + ViewRowsOnPage; i++)
                {
                    if (i >= Users.Count) break;
                    mappingUsers.Add(Users[i]);
                }

                userData.DataSource = mappingUsers;
            }

            public int GetPagesCount() =>
                 (int)Math.Floor((double)(Users.Count / ViewRowsOnPage));
            

            public void NextPage()
            {
                if (SelectedPage >= GetPagesCount()) return;
                SelectedPage++;
                UpdateUsers();
            }

            public void PreviousPage()
            {
                if (SelectedPage <= 0) return;
                SelectedPage--;
                UpdateUsers();
            }

        }

        public FormUsers()
        {
            InitializeComponent();
            UserData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UserData.MultiSelect = true;

            userViewer = new DataSourceViewer(UserData);
        }
        
        public void AddNewUser(User user)
        {
            Users.Add(user);
            userViewer.UpdateUsers();
            UpdateViewInfo();
        }

        private void UserAdd_Click(object sender, EventArgs e)
        {
            
            NewUserAddForm newUserForm = new NewUserAddForm(this);
            newUserForm.ShowDialog();
        }


        //Удаление по индексу (0 элемента)
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserData.SelectedRows.Count <= 0) return;
            User user = UserData.SelectedRows[0].DataBoundItem as User;

            Users.RemoveAll(u => u.login == user.login);
            userViewer.UpdateUsers();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            userViewer.NextPage();
            UpdateViewInfo();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        public void UpdateViewInfo()
        {
            Pagenumber.Text = String.Format("{0}/{1}", userViewer.SelectedPage, userViewer.GetPagesCount());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userViewer.PreviousPage();
            UpdateViewInfo();
        }

        private void Pagenumber_Click(object sender, EventArgs e)
        {

        }
    }
}
