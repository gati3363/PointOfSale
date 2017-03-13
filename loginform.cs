using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PointofSale
{
    public partial class loginform : Form
    {
        private string username, password;
        public loginform()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            this.username = this.usernameBox.Text.ToString();
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            this.password = this.passBox.Text.ToString();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            SignUp obj = new SignUp();
            obj.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and Password cannot be blank");
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Projects;Data Source=KARAN-PATEL"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_pointofsale", con);
                      
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "Authentication";
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                        //cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = username;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

                        cmd.ExecuteNonQuery();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            MainPage obj = new MainPage();
                            obj.Show();
                        }
                        else
                        {
                            MessageBox.Show("Verify your username and password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.usernameBox.Text = string.Empty;
                    this.passBox.Text = string.Empty;
                }
            }
        }

    }
}
