namespace WeatherMelon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            this.tbNameRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameRegist.Location = new System.Drawing.Point(236, 370);
            this.tbNameRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNameRegist.Name = "tbNameRegist";
            this.tbNameRegist.Size = new System.Drawing.Size(480, 41);
            this.tbNameRegist.TabIndex = 1;
            // 
            // tbEmailRegist
            // 
            this.tbEmailRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailRegist.Location = new System.Drawing.Point(236, 469);
            this.tbEmailRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmailRegist.Name = "tbEmailRegist";
            this.tbEmailRegist.Size = new System.Drawing.Size(480, 41);
            this.tbEmailRegist.TabIndex = 2;
            // 
            // tbPasswordRegist
            // 
            this.tbPasswordRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRegist.Location = new System.Drawing.Point(236, 561);
            this.tbPasswordRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPasswordRegist.Name = "tbPasswordRegist";
            this.tbPasswordRegist.Size = new System.Drawing.Size(480, 41);
            this.tbPasswordRegist.TabIndex = 3;
            // 
            // tbCityRegist
            // 
            this.tbCityRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCityRegist.Location = new System.Drawing.Point(236, 652);
            this.tbCityRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCityRegist.Name = "tbCityRegist";
            this.tbCityRegist.Size = new System.Drawing.Size(480, 41);
            this.tbCityRegist.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Indigo;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegister.Location = new System.Drawing.Point(375, 747);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(228, 54);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Sign Up";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Indigo;
            this.lblLogin.Location = new System.Drawing.Point(513, 244);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 26);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.DoubleClick += new System.EventHandler(this.lblLogin_DoubleClick);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1689, 922);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbCityRegist);
            this.Controls.Add(this.tbPasswordRegist);
            this.Controls.Add(this.tbEmailRegist);
            this.Controls.Add(this.tbNameRegist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
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