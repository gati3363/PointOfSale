namespace PointofSale
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.sFirstNameBox = new System.Windows.Forms.TextBox();
            this.sLastNameBox = new System.Windows.Forms.TextBox();
            this.sUsernameBox = new System.Windows.Forms.TextBox();
            this.sEmailBox = new System.Windows.Forms.TextBox();
            this.sPassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sCPassBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.wrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.tick = new System.Windows.Forms.ErrorProvider(this.components);
            this.warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.captchaBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.refreshPicBox = new System.Windows.Forms.PictureBox();
            this.captchaPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sFirstNameBox
            // 
            this.sFirstNameBox.Location = new System.Drawing.Point(375, 41);
            this.sFirstNameBox.Name = "sFirstNameBox";
            this.sFirstNameBox.Size = new System.Drawing.Size(209, 26);
            this.sFirstNameBox.TabIndex = 0;
            this.sFirstNameBox.TextChanged += new System.EventHandler(this.sFirstNameBox_TextChanged);
            this.sFirstNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.sFirstNameBox_Validating);
            // 
            // sLastNameBox
            // 
            this.sLastNameBox.Location = new System.Drawing.Point(375, 91);
            this.sLastNameBox.Name = "sLastNameBox";
            this.sLastNameBox.Size = new System.Drawing.Size(209, 26);
            this.sLastNameBox.TabIndex = 1;
            this.sLastNameBox.TextChanged += new System.EventHandler(this.sLastNameBox_TextChanged);
            this.sLastNameBox.Validating += new System.ComponentModel.CancelEventHandler(this.sLastNameBox_Validating);
            // 
            // sUsernameBox
            // 
            this.sUsernameBox.Location = new System.Drawing.Point(375, 140);
            this.sUsernameBox.Name = "sUsernameBox";
            this.sUsernameBox.Size = new System.Drawing.Size(209, 26);
            this.sUsernameBox.TabIndex = 2;
            this.sUsernameBox.TextChanged += new System.EventHandler(this.sUsernameBox_TextChanged);
            this.sUsernameBox.Validating += new System.ComponentModel.CancelEventHandler(this.sUsernameBox_Validating);
            // 
            // sEmailBox
            // 
            this.sEmailBox.Location = new System.Drawing.Point(375, 187);
            this.sEmailBox.Name = "sEmailBox";
            this.sEmailBox.Size = new System.Drawing.Size(209, 26);
            this.sEmailBox.TabIndex = 3;
            this.sEmailBox.TextChanged += new System.EventHandler(this.sEmailBox_TextChanged);
            this.sEmailBox.Validating += new System.ComponentModel.CancelEventHandler(this.sEmailBox_Validating);
            // 
            // sPassBox
            // 
            this.sPassBox.Location = new System.Drawing.Point(375, 236);
            this.sPassBox.Name = "sPassBox";
            this.sPassBox.Size = new System.Drawing.Size(209, 26);
            this.sPassBox.TabIndex = 4;
            this.sPassBox.UseSystemPasswordChar = true;
            this.sPassBox.TextChanged += new System.EventHandler(this.sPassBox_TextChanged);
            this.sPassBox.Validating += new System.ComponentModel.CancelEventHandler(this.sPassBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // sCPassBox
            // 
            this.sCPassBox.Location = new System.Drawing.Point(375, 294);
            this.sCPassBox.Name = "sCPassBox";
            this.sCPassBox.Size = new System.Drawing.Size(209, 26);
            this.sCPassBox.TabIndex = 7;
            this.sCPassBox.UseSystemPasswordChar = true;
            this.sCPassBox.Validating += new System.ComponentModel.CancelEventHandler(this.sCPassBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(375, 520);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(100, 33);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // wrong
            // 
            this.wrong.ContainerControl = this;
            this.wrong.Icon = ((System.Drawing.Icon)(resources.GetObject("wrong.Icon")));
            // 
            // tick
            // 
            this.tick.ContainerControl = this;
            this.tick.Icon = ((System.Drawing.Icon)(resources.GetObject("tick.Icon")));
            // 
            // warning
            // 
            this.warning.ContainerControl = this;
            this.warning.Icon = ((System.Drawing.Icon)(resources.GetObject("warning.Icon")));
            // 
            // captchaBox
            // 
            this.captchaBox.Location = new System.Drawing.Point(375, 463);
            this.captchaBox.Name = "captchaBox";
            this.captchaBox.Size = new System.Drawing.Size(209, 26);
            this.captchaBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter the above text";
            // 
            // refreshPicBox
            // 
            this.refreshPicBox.Image = global::PointofSale.Properties.Resources.refresh1;
            this.refreshPicBox.Location = new System.Drawing.Point(600, 463);
            this.refreshPicBox.Name = "refreshPicBox";
            this.refreshPicBox.Size = new System.Drawing.Size(37, 26);
            this.refreshPicBox.TabIndex = 16;
            this.refreshPicBox.TabStop = false;
            this.refreshPicBox.Click += new System.EventHandler(this.refreshPicBox_Click);
            // 
            // captchaPicBox
            // 
            this.captchaPicBox.Location = new System.Drawing.Point(375, 354);
            this.captchaPicBox.Name = "captchaPicBox";
            this.captchaPicBox.Size = new System.Drawing.Size(153, 69);
            this.captchaPicBox.TabIndex = 13;
            this.captchaPicBox.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 655);
            this.Controls.Add(this.refreshPicBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.captchaBox);
            this.Controls.Add(this.captchaPicBox);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sCPassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sPassBox);
            this.Controls.Add(this.sEmailBox);
            this.Controls.Add(this.sUsernameBox);
            this.Controls.Add(this.sLastNameBox);
            this.Controls.Add(this.sFirstNameBox);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.wrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sFirstNameBox;
        private System.Windows.Forms.TextBox sLastNameBox;
        private System.Windows.Forms.TextBox sUsernameBox;
        private System.Windows.Forms.TextBox sEmailBox;
        private System.Windows.Forms.TextBox sPassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sCPassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.ErrorProvider wrong;
        private System.Windows.Forms.ErrorProvider tick;
        private System.Windows.Forms.ErrorProvider warning;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox captchaBox;
        private System.Windows.Forms.PictureBox captchaPicBox;
        private System.Windows.Forms.PictureBox refreshPicBox;
    }
}