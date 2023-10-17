using Hospital_project.Forms;
using Hospital_project.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PnlMain.Hide();
            PnlRegister.Show();
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsernameSU.Text != "" && tbEmail.Text != "" && tbPasswordSU.Text != "" && tbConfirmPasswordSU.Text != "")
                {
                    string jsonFilePath = "Files/users.json";
                    string jsonReadContent = File.ReadAllText(jsonFilePath);
                    var users = JsonConvert.DeserializeObject<List<Users>>(jsonReadContent);
                    if (users.Count == 0 && tbUsernameSU.Text != "")
                    {
                        Users user = new Users();
                        user.Username = tbUsernameSU.Text;
                        user.Email = tbEmail.Text;
                        user.Password = tbPasswordSU.Text;
                        user.ConfirmPassword = tbConfirmPasswordSU.Text;

                        users.Add(user);

                        string jsonContent = JsonConvert.SerializeObject(users);
                        File.WriteAllText(jsonFilePath, jsonContent);
                        MessageBox.Show("Siz roʻyxatdan muvaffaqiyatli oʻtdingiz!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else if (users.Count >= 1)
                    {
                        bool isCheck = true;
                        foreach (var item in users)
                        {
                            if (item.Username == tbUsernameSU.Text && tbUsernameSU.Text != "")
                            {
                                isCheck = false;
                            }
                        }
                        if (!isCheck)
                        {
                            DialogResult result = MessageBox.Show("Bu username band!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (result == DialogResult.OK)
                            {
                                tbUsernameSU.Text = "";
                                tbEmail.Text = "";
                                tbPasswordSU.Text = "";
                                tbConfirmPasswordSU.Text = "";
                            }
                        }
                        else
                        {
                            Users user = new Users();
                            user.Username = tbUsernameSU.Text;
                            user.Email = tbEmail.Text;
                            user.Password = tbPasswordSU.Text;
                            user.ConfirmPassword = tbConfirmPasswordSU.Text;
                            if (user.Email.Contains("@gmail.com") || user.Email.Contains("@mail.ru"))
                            {
                                users.Add(user);
                                string jsonContent = JsonConvert.SerializeObject(users);
                                File.WriteAllText(jsonFilePath, jsonContent);
                                MessageBox.Show("You've successfully registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                MessageBox.Show("Iltimos, ma'lumotlarni tog'ri tartibda kiriting!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                tbUsernameSU.Text = "";
                                tbEmail.Text = "";
                                tbPasswordSU.Text = "";
                                tbConfirmPasswordSU.Text = "";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Iltimos, ma'lumotlarni tog'ri tartibda kiriting!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch { }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PnlMain.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFilePath = "Files/users.json";
                string jsonReadContent = File.ReadAllText(jsonFilePath);
                var users = JsonConvert.DeserializeObject<List<Users>>(jsonReadContent);
                bool isMatch = false;
                if (users.Count >= 1)
                {
                    foreach (var item in users)
                    {
                        if (item.Username == tbUsername.Text && item.Password == tbPassword.Text)
                        {
                            isMatch = true;
                            MenuForm menuForm = new MenuForm();
                            this.Hide();
                            menuForm.ShowDialog();
                            this.Show();
                            break;
                        }
                    }
                    if (!isMatch)
                    {
                        DialogResult result = MessageBox.Show("Username yoki password xato kiritilgan!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.OK)
                        {
                            tbUsername.Text = String.Empty;
                            tbPassword.Text = String.Empty;
                        }
                    }
                }
            }
            catch { }

        }
        private void MainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                tbPasswordSU.PasswordChar = '\0';
                tbConfirmPasswordSU.PasswordChar = '\0';

            }
            else
            {
                tbPasswordSU.PasswordChar = '*';
                tbConfirmPasswordSU.PasswordChar = '*';
            }
        }
    }
}


