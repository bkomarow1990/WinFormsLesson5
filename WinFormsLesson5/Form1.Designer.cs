
namespace WinFormsLesson5
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
            this.cbColors = new System.Windows.Forms.ComboBox();
            this.colorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbColors
            // 
            this.cbColors.FormattingEnabled = true;
            this.cbColors.Location = new System.Drawing.Point(13, 26);
            this.cbColors.Name = "cbColors";
            this.cbColors.Size = new System.Drawing.Size(151, 28);
            this.cbColors.TabIndex = 0;
            // 
            // colorlbl
            // 
            this.colorlbl.AutoSize = true;
            this.colorlbl.Location = new System.Drawing.Point(266, 110);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(45, 20);
            this.colorlbl.TabIndex = 1;
            this.colorlbl.Text = "Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.cbColors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColors;
        private System.Windows.Forms.Label colorlbl;
    }
}

