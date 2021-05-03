
namespace Practic2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.citiesComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cityUrl = new System.Windows.Forms.LinkLabel();
            this.nextImageBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // citiesComboBox
            // 
            this.citiesComboBox.FormattingEnabled = true;
            this.citiesComboBox.Location = new System.Drawing.Point(359, 27);
            this.citiesComboBox.Name = "citiesComboBox";
            this.citiesComboBox.Size = new System.Drawing.Size(174, 28);
            this.citiesComboBox.TabIndex = 0;
            this.citiesComboBox.SelectedIndexChanged += new System.EventHandler(this.citiesComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(244, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 267);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cityUrl
            // 
            this.cityUrl.AutoSize = true;
            this.cityUrl.LinkColor = System.Drawing.Color.Maroon;
            this.cityUrl.Location = new System.Drawing.Point(411, 354);
            this.cityUrl.Name = "cityUrl";
            this.cityUrl.Size = new System.Drawing.Size(60, 20);
            this.cityUrl.TabIndex = 2;
            this.cityUrl.TabStop = true;
            this.cityUrl.Text = "LinkCity";
            this.cityUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cityUrl_LinkClicked);
            // 
            // nextImageBtn
            // 
            this.nextImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextImageBtn.BackgroundImage = global::Practic2.Properties.Resources.icons8_forward_100;
            this.nextImageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextImageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.nextImageBtn.Location = new System.Drawing.Point(674, 189);
            this.nextImageBtn.Name = "nextImageBtn";
            this.nextImageBtn.Size = new System.Drawing.Size(41, 36);
            this.nextImageBtn.TabIndex = 3;
            this.nextImageBtn.UseVisualStyleBackColor = false;
            this.nextImageBtn.Click += new System.EventHandler(this.nextImageBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.BackColor = System.Drawing.Color.Transparent;
            this.prevBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prevBtn.BackgroundImage")));
            this.prevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prevBtn.ForeColor = System.Drawing.Color.Transparent;
            this.prevBtn.Location = new System.Drawing.Point(178, 189);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(41, 36);
            this.prevBtn.TabIndex = 4;
            this.prevBtn.UseVisualStyleBackColor = false;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.nextImageBtn);
            this.Controls.Add(this.cityUrl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.citiesComboBox);
            this.Name = "Form1";
            this.Text = "Cities";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox citiesComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel cityUrl;
        private System.Windows.Forms.Button nextImageBtn;
        private System.Windows.Forms.Button prevBtn;
    }
}

