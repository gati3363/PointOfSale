using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
namespace PointofSale
{
    public partial class SignUp : Form
    {
        public string sfirstname, slastname, susername, semail, spassword; 
        public SignUp()
        {
            InitializeComponent();
            generateImage();
        }

        private void sFirstNameBox_TextChanged(object sender, EventArgs e)
        {
            this.sfirstname = this.sFirstNameBox.Text.ToString();
        }

        private void sLastNameBox_TextChanged(object sender, EventArgs e)
        {
            this.slastname = this.sLastNameBox.Text.ToString();
        }

        private void sUsernameBox_TextChanged(object sender, EventArgs e)
        {
            this.susername = this.sUsernameBox.Text.ToString();
        }

        private void sEmailBox_TextChanged(object sender, EventArgs e)
        {
            this.semail = this.sEmailBox.Text.ToString();
        }

        private void sPassBox_TextChanged(object sender, EventArgs e)
        {
            this.spassword = this.sPassBox.Text.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tick.SetError(sFirstNameBox, "");
            tick.SetError(sLastNameBox, "");
            tick.SetError(sUsernameBox, "");
            tick.SetError(sEmailBox, "");
            tick.SetError(sPassBox, "");
            tick.SetError(sCPassBox, "");
            //Comparing Captacha
            if (this.captchaBox.Text != value.ToString())
            {
                MessageBox.Show("Text entered does not match with the text in the image.");
                captchaBox.Text = String.Empty;
                this.generateImage();
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
                        cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "Add";
                        cmd.Parameters.Add("@first_name", SqlDbType.VarChar).Value = sfirstname;
                        cmd.Parameters.Add("@last_name", SqlDbType.VarChar).Value = slastname;
                        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = susername;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = semail;
                        cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = spassword;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.sFirstNameBox.Text = string.Empty;
                    this.sLastNameBox.Text = string.Empty;
                    this.sUsernameBox.Text = string.Empty;
                    this.sEmailBox.Text = string.Empty;
                    this.sPassBox.Text = string.Empty;
                    this.sCPassBox.Text = string.Empty;
                }
            }
        }

        private void sEmailBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(semail))
            {
                wrong.SetError(sEmailBox, "Email cannot be blank");
                tick.SetError(sEmailBox, "");
                warning.SetError(sEmailBox, "");
            }
            else if (!Regex.IsMatch(semail, @"^([\w\-\.]+)@((\[([0-9]{1,3}\.){3}[0-9]{1,3}\])|(([\w\-]+\.)+)([a-zA-Z]{2,4}))$"))     //bob@somewhere.com | bob.jones@[1.1.1.1] | bob@a.b.c.d.info
            {
                wrong.SetError(sEmailBox, "");
                tick.SetError(sEmailBox, "");
                warning.SetError(sEmailBox, "Email format is incorrect");
            }
            else
            {
                wrong.SetError(sEmailBox, "");
                tick.SetError(sEmailBox, "Correct");
                warning.SetError(sEmailBox, "");
            }
        }

        private void sPassBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(spassword))
            {
                wrong.SetError(sPassBox, "Password cannot be blank");
                tick.SetError(sPassBox, "");
                warning.SetError(sPassBox, "");
            }
            else if (!Regex.IsMatch(spassword, @"(?-i)(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))((?=(.*\d){1,})|(?=(.*\W){1,}))^.*$"))     //Password must have at least 8 characters with at least one Capital letter, at least one lower case letter and at least one number or special character
            {
                wrong.SetError(sPassBox, "");
                tick.SetError(sPassBox, "");
                warning.SetError(sPassBox, "Password must have at least 8 characters with at least one Capital letter, at least one lower case letter and at least one number or special character");
            }
            else
            {
                wrong.SetError(sPassBox, "");
                tick.SetError(sPassBox, "Correct");
                warning.SetError(sPassBox, "");
            }
        }

        private void sCPassBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(sCPassBox.Text))
            {
                wrong.SetError(sCPassBox, "Password cannot be blank");
                tick.SetError(sCPassBox, "");
                warning.SetError(sCPassBox, "");
            }
            else if (!Regex.IsMatch(sCPassBox.Text, @"(?-i)(?=^.{8,}$)((?!.*\s)(?=.*[A-Z])(?=.*[a-z]))((?=(.*\d){1,})|(?=(.*\W){1,}))^.*$"))     //Password must have at least 8 characters with at least one Capital letter, at least one lower case letter and at least one number or special character
            {
                wrong.SetError(sCPassBox, "");
                tick.SetError(sCPassBox, "");
                warning.SetError(sCPassBox, "Password must have at least 8 characters with at least one Capital letter, at least one lower case letter and at least one number or special character");
            }
            else if (sCPassBox.Text != sPassBox.Text)
            {
                wrong.SetError(sCPassBox, "Password do not match");
                tick.SetError(sCPassBox, "");
                warning.SetError(sCPassBox, "");
                this.sCPassBox.Text = "";
                this.sPassBox.Text = "";
            }

            else
            {
                wrong.SetError(sCPassBox, "");
                tick.SetError(sCPassBox, "Correct");
                warning.SetError(sCPassBox, "");
            }
        }

        private void sFirstNameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(sfirstname))
            {
                wrong.SetError(sFirstNameBox, "Password cannot be blank");
                tick.SetError(sFirstNameBox, "");
                warning.SetError(sFirstNameBox, "");
            }
            else
            {
                wrong.SetError(sFirstNameBox, "");
                tick.SetError(sFirstNameBox, "Correct");
                warning.SetError(sFirstNameBox, "");
            }
        }

        private void sLastNameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(slastname))
            {
                wrong.SetError(sLastNameBox, "Password cannot be blank");
                tick.SetError(sLastNameBox, "");
                warning.SetError(sLastNameBox, "");
            }
            else
            {
                wrong.SetError(sLastNameBox, "");
                tick.SetError(sLastNameBox, "Correct");
                warning.SetError(sLastNameBox, "");
            }
        }

        private void sUsernameBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(susername))
            {
                wrong.SetError(sUsernameBox, "Password cannot be blank");
                tick.SetError(sUsernameBox, "");
                warning.SetError(sUsernameBox, "");
            }
            else
            {
                wrong.SetError(sUsernameBox, "");
                tick.SetError(sUsernameBox, "Correct");
                warning.SetError(sUsernameBox, "");
            }
        }

        int value = 0;
        private void generateImage()
        {
            Random random = new Random(); // get a random instance
            value = random.Next(10000, 99999); // get a random value between any range
            var image = new Bitmap(this.captchaPicBox.Width, this.captchaPicBox.Height); // Get a bitmap
            var font = new Font("TimesNewRoman", 25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel); // Get a font
            var graphics = Graphics.FromImage(image); // Get a graphics with the bitmap image
            graphics.DrawString(value.ToString(), font, Brushes.Red, new PointF(0, 0)); // Add the value in the graphics
            Pen p = new Pen(Brushes.Orange, 2.0f); // get pen width
            graphics.DrawLine(p, new PointF(0, this.captchaPicBox.Height), new Point(this.captchaPicBox.Width, 0)); // draw a diagonal line
            graphics.DrawLine(p, new PointF(0, 0), new Point(this.captchaPicBox.Width, this.captchaPicBox.Height)); // draw another diagonal line
            p.Dispose(); // dispose the pen to avoid memory leak
            graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smoothing the pixel
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias; // Smoothing the text rendering because stem width may differ
            this.captchaPicBox.Image = image; // load the image in the picturebox
        }

        private void refreshPicBox_Click(object sender, EventArgs e)
        {
            this.generateImage();
        }
    }
}
