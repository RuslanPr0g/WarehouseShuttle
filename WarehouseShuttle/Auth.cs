using System;
using System.Linq;
using System.Windows.Forms;
using WarehouseShuttle.Common;
using WarehouseShuttle.Infrastructure;
using WarehouseShuttle.Models;

namespace WarehouseShuttle
{
    public partial class Auth : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly AuthHandler AH;
        private MainFormScreen SP;
        private bool _LOGINMODE = true;

        public Auth(IUserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            AH = new AuthHandler(_userRepository);
            SP = new MainFormScreen(new InMemoryStoreRepository(), UserRole.Admin);
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            string forbiddenFieldInfo = "";

            for (int i = 0; i < ForbiddenSymbols.SignUP.Length; i++)
                forbiddenFieldInfo += ForbiddenSymbols.SignUP[i];

            label14.Text = "Fields cannot contain the following: " + forbiddenFieldInfo;

            VisibilityConfirmField();

            SignupRequirements.Visible = false;

            ShowPasswordHandler();

            this.WindowState = FormWindowState.Maximized;
        }

        private string Username
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        private string Password
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        private string ConfirmPassword
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }

        private void VisibilityConfirmField()
        {
            if (_LOGINMODE == false)
            {
                label4.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void LoginMode()
        {
            _LOGINMODE = true;
            VisibilityConfirmField();
            button1.Text = AH.LoginText;
            button2.Text = AH.NeedAccount;
            ClearTextBoxes(textBox1, textBox2, textBox3);
            SignupRequirements.Visible = false;
        }

        private void SignUpMode()
        {
            _LOGINMODE = false;
            VisibilityConfirmField();
            button1.Text = AH.SignupText;
            button2.Text = AH.AccountExists;
            SignupRequirements.Visible = true;
        }

        private void ClearTextBoxes(params TextBox[] tx)
        {
            foreach (TextBox textbox in tx)
            {
                textbox.Text = string.Empty;
            }
        }

        private void ShowPasswordHandler()
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new Administrator
            {
                Username = Username,
                Password = Password
            };

            switch (_LOGINMODE)
            {
                case false:
                    var response = AH.SignUp(user, ConfirmPassword);
                    if (response == "")
                    {
                        MessageBox.Show("Now Login!");
                        LoginMode();
                    }
                    else
                    {
                        MessageBox.Show(response);
                    }
                    break;
                case true:
                    string result = AH.LogIn(user);

                    if (result == "")
                    {
                        Administrator s = _userRepository.GetUsers().FirstOrDefault(u => u.Username == user.Username);

                        if (AdminRadio.Checked is false)
                            SP.CurrentRole = UserRole.Customer;

                        Hide();
                        SP.ShowDialog();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show(result);
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _LOGINMODE = !_LOGINMODE;

            switch (_LOGINMODE)
            {
                case true:
                    LoginMode();
                    break;
                case false:
                    SignUpMode();
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowPasswordHandler();
        }
    }
}
