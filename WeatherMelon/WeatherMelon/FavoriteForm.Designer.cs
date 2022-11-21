namespace WeatherMelon
{
    partial class FavoriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteForm));
            this.sPanel1 = new WeatherMelon.SPanel();
            this.lblWeatherMelon = new System.Windows.Forms.Label();
            this.lblNext4Days = new System.Windows.Forms.Label();
            this.orchidSPanel2 = new WeatherMelon.OrchidSPanel();
            this.favoriteContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.sPanel1.SuspendLayout();
            this.orchidSPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.sPanel1.Controls.Add(this.favoriteContainer);
            this.sPanel1.Controls.Add(this.orchidSPanel2);
            this.sPanel1.Controls.Add(this.lblWeatherMelon);
            this.sPanel1.Location = new System.Drawing.Point(0, 0);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(1008, 644);
            this.sPanel1.TabIndex = 0;
            // 
            // lblWeatherMelon
            // 
            this.lblWeatherMelon.AutoSize = true;
            this.lblWeatherMelon.BackColor = System.Drawing.Color.White;
            this.lblWeatherMelon.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherMelon.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblWeatherMelon.Location = new System.Drawing.Point(188, 78);
            this.lblWeatherMelon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeatherMelon.Name = "lblWeatherMelon";
            this.lblWeatherMelon.Size = new System.Drawing.Size(215, 33);
            this.lblWeatherMelon.TabIndex = 28;
            this.lblWeatherMelon.Text = "WeatherMelon";
            // 
            // lblNext4Days
            // 
            this.lblNext4Days.AutoSize = true;
            this.lblNext4Days.BackColor = System.Drawing.Color.Transparent;
            this.lblNext4Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext4Days.ForeColor = System.Drawing.Color.White;
            this.lblNext4Days.Location = new System.Drawing.Point(65, 5);
            this.lblNext4Days.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNext4Days.Name = "lblNext4Days";
            this.lblNext4Days.Size = new System.Drawing.Size(181, 24);
            this.lblNext4Days.TabIndex = 25;
            this.lblNext4Days.Text = "♡ FAVORITE CITY";
            // 
            // orchidSPanel2
            // 
            this.orchidSPanel2.BackColor = System.Drawing.Color.Transparent;
            this.orchidSPanel2.Controls.Add(this.lblNext4Days);
            this.orchidSPanel2.Location = new System.Drawing.Point(88, 148);
            this.orchidSPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.orchidSPanel2.Name = "orchidSPanel2";
            this.orchidSPanel2.Size = new System.Drawing.Size(275, 34);
            this.orchidSPanel2.TabIndex = 29;
            // 
            // favoriteContainer
            // 
            this.favoriteContainer.BackColor = System.Drawing.Color.Transparent;
            this.favoriteContainer.Location = new System.Drawing.Point(86, 241);
            this.favoriteContainer.Name = "favoriteContainer";
            this.favoriteContainer.Size = new System.Drawing.Size(833, 317);
            this.favoriteContainer.TabIndex = 30;
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 644);
            this.Controls.Add(this.sPanel1);
            this.Name = "FavoriteForm";
            this.Text = "FavoriteForm";
            this.sPanel1.ResumeLayout(false);
            this.sPanel1.PerformLayout();
            this.orchidSPanel2.ResumeLayout(false);
            this.orchidSPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SPanel sPanel1;
        private System.Windows.Forms.Label lblWeatherMelon;
        private System.Windows.Forms.FlowLayoutPanel favoriteContainer;
        private OrchidSPanel orchidSPanel2;
        private System.Windows.Forms.Label lblNext4Days;
    }
}