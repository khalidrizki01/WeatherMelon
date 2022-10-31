﻿namespace WeatherMelon
{
    partial class RegisterForm
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
            this.tbNameRegist = new System.Windows.Forms.TextBox();
            this.tbEmailRegist = new System.Windows.Forms.TextBox();
            this.tbPasswordRegist = new System.Windows.Forms.TextBox();
            this.tbCityRegist = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNameRegist
            // 
            this.tbNameRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameRegist.Location = new System.Drawing.Point(507, 261);
            this.tbNameRegist.Name = "tbNameRegist";
            this.tbNameRegist.Size = new System.Drawing.Size(271, 49);
            this.tbNameRegist.TabIndex = 1;
            // 
            // tbEmailRegist
            // 
            this.tbEmailRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailRegist.Location = new System.Drawing.Point(506, 350);
            this.tbEmailRegist.Name = "tbEmailRegist";
            this.tbEmailRegist.Size = new System.Drawing.Size(271, 49);
            this.tbEmailRegist.TabIndex = 2;
            // 
            // tbPasswordRegist
            // 
            this.tbPasswordRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRegist.Location = new System.Drawing.Point(507, 441);
            this.tbPasswordRegist.Name = "tbPasswordRegist";
            this.tbPasswordRegist.Size = new System.Drawing.Size(271, 49);
            this.tbPasswordRegist.TabIndex = 3;
            // 
            // tbCityRegist
            // 
            this.tbCityRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCityRegist.Location = new System.Drawing.Point(506, 530);
            this.tbCityRegist.Name = "tbCityRegist";
            this.tbCityRegist.Size = new System.Drawing.Size(271, 49);
            this.tbCityRegist.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegister.Location = new System.Drawing.Point(555, 608);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(171, 44);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(686, 677);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 15);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            this.lblLogin.DoubleClick += new System.EventHandler(this.lblLogin_DoubleClick);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMelon.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1267, 788);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbCityRegist);
            this.Controls.Add(this.tbPasswordRegist);
            this.Controls.Add(this.tbEmailRegist);
            this.Controls.Add(this.tbNameRegist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNameRegist;
        private System.Windows.Forms.TextBox tbEmailRegist;
        private System.Windows.Forms.TextBox tbPasswordRegist;
        private System.Windows.Forms.TextBox tbCityRegist;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblLogin;
    }
}