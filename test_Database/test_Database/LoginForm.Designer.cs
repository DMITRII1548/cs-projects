﻿namespace test_Database
{
    partial class LoginForm
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
            this.show_password = new System.Windows.Forms.Button();
            this.show_register = new System.Windows.Forms.Button();
            this.password_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_field = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // show_password
            // 
            this.show_password.Location = new System.Drawing.Point(439, 218);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(78, 23);
            this.show_password.TabIndex = 13;
            this.show_password.Text = "Показать";
            this.show_password.UseVisualStyleBackColor = true;
            this.show_password.Click += new System.EventHandler(this.show_password_Click);
            // 
            // show_register
            // 
            this.show_register.Location = new System.Drawing.Point(232, 276);
            this.show_register.Name = "show_register";
            this.show_register.Size = new System.Drawing.Size(139, 23);
            this.show_register.TabIndex = 12;
            this.show_register.Text = "Войти";
            this.show_register.UseVisualStyleBackColor = true;
            this.show_register.Click += new System.EventHandler(this.show_register_Click);
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(285, 220);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(148, 20);
            this.password_field.TabIndex = 11;
            this.password_field.TextChanged += new System.EventHandler(this.password_field_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вход";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // login_field
            // 
            this.login_field.Location = new System.Drawing.Point(285, 168);
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(148, 20);
            this.login_field.TabIndex = 7;
            this.login_field.TextChanged += new System.EventHandler(this.login_field_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(267, 348);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Нет аккаунта";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.show_register);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_field);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_password;
        private System.Windows.Forms.Button show_register;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}