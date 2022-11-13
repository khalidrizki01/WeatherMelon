namespace WeatherMelon
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbToday = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTodayWeather = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRec = new System.Windows.Forms.Label();
            this.lblHum = new System.Windows.Forms.Label();
            this.lblMaxWS = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lblMaxWSNo = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMinWSNo = new System.Windows.Forms.Label();
            this.lblMaxTempNo = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMinTempNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btFavCity = new System.Windows.Forms.Button();
            this.gbToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbToday
            // 
            this.gbToday.BackColor = System.Drawing.Color.Lavender;
            this.gbToday.Controls.Add(this.lbTemp);
            this.gbToday.Controls.Add(this.label1);
            this.gbToday.Controls.Add(this.pictureBox1);
            this.gbToday.Controls.Add(this.lblTodayWeather);
            this.gbToday.Controls.Add(this.lblToday);
            this.gbToday.Location = new System.Drawing.Point(76, 256);
            this.gbToday.Name = "gbToday";
            this.gbToday.Size = new System.Drawing.Size(274, 360);
            this.gbToday.TabIndex = 0;
            this.gbToday.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.47561F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.52439F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(441, 256);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(652, 208);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "°C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 104);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblTodayWeather
            // 
            this.lblTodayWeather.AutoSize = true;
            this.lblTodayWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayWeather.Location = new System.Drawing.Point(30, 296);
            this.lblTodayWeather.Name = "lblTodayWeather";
            this.lblTodayWeather.Size = new System.Drawing.Size(199, 31);
            this.lblTodayWeather.TabIndex = 1;
            this.lblTodayWeather.Text = "Today Weather";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(91, 16);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(102, 33);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Today";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.favoriteCityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // favoriteCityToolStripMenuItem
            // 
            this.favoriteCityToolStripMenuItem.Name = "favoriteCityToolStripMenuItem";
            this.favoriteCityToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.favoriteCityToolStripMenuItem.Text = "Favorite City";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(822, 153);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(217, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(489, 578);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(46, 16);
            this.lblRec.TabIndex = 5;
            this.lblRec.Text = "lblRec";
            // 
            // lblHum
            // 
            this.lblHum.AutoSize = true;
            this.lblHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHum.Location = new System.Drawing.Point(671, 578);
            this.lblHum.Name = "lblHum";
            this.lblHum.Size = new System.Drawing.Size(49, 16);
            this.lblHum.TabIndex = 6;
            this.lblHum.Text = "lblHum";
            // 
            // lblMaxWS
            // 
            this.lblMaxWS.AutoSize = true;
            this.lblMaxWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWS.Location = new System.Drawing.Point(794, 578);
            this.lblMaxWS.Name = "lblMaxWS";
            this.lblMaxWS.Size = new System.Drawing.Size(54, 16);
            this.lblMaxWS.TabIndex = 7;
            this.lblMaxWS.Text = "MaxWS";
            this.lblMaxWS.Click += new System.EventHandler(this.lblMaxWS_Click);
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(961, 578);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(82, 16);
            this.lblMaxTemp.TabIndex = 8;
            this.lblMaxTemp.Text = "lblMaxTemp";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(161, 163);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(102, 37);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "lbCity";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemp.Location = new System.Drawing.Point(115, 181);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(89, 25);
            this.lbTemp.TabIndex = 4;
            this.lbTemp.Text = "lbTemp";
            this.lbTemp.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblMaxWSNo
            // 
            this.lblMaxWSNo.AutoSize = true;
            this.lblMaxWSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxWSNo.Location = new System.Drawing.Point(857, 578);
            this.lblMaxWSNo.Name = "lblMaxWSNo";
            this.lblMaxWSNo.Size = new System.Drawing.Size(64, 16);
            this.lblMaxWSNo.TabIndex = 11;
            this.lblMaxWSNo.Text = "lblMaxNo";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(794, 609);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(50, 16);
            this.lblMin.TabIndex = 12;
            this.lblMin.Text = "MinWS";
            // 
            // lblMinWSNo
            // 
            this.lblMinWSNo.AutoSize = true;
            this.lblMinWSNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinWSNo.Location = new System.Drawing.Point(857, 609);
            this.lblMinWSNo.Name = "lblMinWSNo";
            this.lblMinWSNo.Size = new System.Drawing.Size(60, 16);
            this.lblMinWSNo.TabIndex = 13;
            this.lblMinWSNo.Text = "lblMinNo";
            // 
            // lblMaxTempNo
            // 
            this.lblMaxTempNo.AutoSize = true;
            this.lblMaxTempNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTempNo.Location = new System.Drawing.Point(1045, 578);
            this.lblMaxTempNo.Name = "lblMaxTempNo";
            this.lblMaxTempNo.Size = new System.Drawing.Size(68, 16);
            this.lblMaxTempNo.TabIndex = 14;
            this.lblMaxTempNo.Text = "MaxTemp";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(961, 609);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(78, 16);
            this.lblMinTemp.TabIndex = 15;
            this.lblMinTemp.Text = "lblMinTemp";
            // 
            // lblMinTempNo
            // 
            this.lblMinTempNo.AutoSize = true;
            this.lblMinTempNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTempNo.Location = new System.Drawing.Point(1045, 609);
            this.lblMinTempNo.Name = "lblMinTempNo";
            this.lblMinTempNo.Size = new System.Drawing.Size(64, 16);
            this.lblMinTempNo.TabIndex = 16;
            this.lblMinTempNo.Text = "MinTemp";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btFavCity
            // 
            this.btFavCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFavCity.Location = new System.Drawing.Point(923, 80);
            this.btFavCity.Name = "btFavCity";
            this.btFavCity.Size = new System.Drawing.Size(120, 23);
            this.btFavCity.TabIndex = 18;
            this.btFavCity.Text = "Favorite City";
            this.btFavCity.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1177, 687);
            this.Controls.Add(this.btFavCity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMinTempNo);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblMaxTempNo);
            this.Controls.Add(this.lblMinWSNo);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMaxWSNo);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMaxWS);
            this.Controls.Add(this.lblHum);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbToday);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "WeatherMelon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.gbToday.ResumeLayout(false);
            this.gbToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTodayWeather;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favoriteCityToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblHum;
        private System.Windows.Forms.Label lblMaxWS;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lblMaxWSNo;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMinWSNo;
        private System.Windows.Forms.Label lblMaxTempNo;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMinTempNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btFavCity;
    }
}

