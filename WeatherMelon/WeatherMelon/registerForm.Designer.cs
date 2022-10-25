namespace WeatherMelon
{
    partial class registerForm
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tbNameRegist = new System.Windows.Forms.TextBox();
            this.tbEmailRegist = new System.Windows.Forms.TextBox();
            this.tbPasswordRegist = new System.Windows.Forms.TextBox();
            this.tbCityRegist = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(0, 0);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
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
            this.btnRegister.Text = "Login";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherMelon.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1267, 802);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbCityRegist);
            this.Controls.Add(this.tbPasswordRegist);
            this.Controls.Add(this.tbEmailRegist);
            this.Controls.Add(this.tbNameRegist);
            this.Controls.Add(this.maskedTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox tbNameRegist;
        private System.Windows.Forms.TextBox tbEmailRegist;
        private System.Windows.Forms.TextBox tbPasswordRegist;
        private System.Windows.Forms.TextBox tbCityRegist;
        private System.Windows.Forms.Button btnRegister;
    }
}