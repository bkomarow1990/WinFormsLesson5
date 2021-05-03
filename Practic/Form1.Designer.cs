
namespace Practic
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
            this.listNums = new System.Windows.Forms.ListBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.leftUpDown = new System.Windows.Forms.NumericUpDown();
            this.rightUpDown = new System.Windows.Forms.NumericUpDown();
            this.countUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationsComboBox = new System.Windows.Forms.ComboBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.fromRndValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // listNums
            // 
            this.listNums.FormattingEnabled = true;
            this.listNums.ItemHeight = 20;
            this.listNums.Location = new System.Drawing.Point(32, 35);
            this.listNums.Name = "listNums";
            this.listNums.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listNums.Size = new System.Drawing.Size(182, 384);
            this.listNums.TabIndex = 0;
            this.listNums.SelectedIndexChanged += new System.EventHandler(this.listNums_SelectedIndexChanged);
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(249, 225);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(168, 41);
            this.generatebtn.TabIndex = 1;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // leftUpDown
            // 
            this.leftUpDown.Location = new System.Drawing.Point(249, 35);
            this.leftUpDown.Name = "leftUpDown";
            this.leftUpDown.Size = new System.Drawing.Size(150, 27);
            this.leftUpDown.TabIndex = 2;
            // 
            // rightUpDown
            // 
            this.rightUpDown.Location = new System.Drawing.Point(249, 86);
            this.rightUpDown.Name = "rightUpDown";
            this.rightUpDown.Size = new System.Drawing.Size(150, 27);
            this.rightUpDown.TabIndex = 3;
            // 
            // countUpDown
            // 
            this.countUpDown.Location = new System.Drawing.Point(249, 147);
            this.countUpDown.Name = "countUpDown";
            this.countUpDown.Size = new System.Drawing.Size(150, 27);
            this.countUpDown.TabIndex = 4;
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.FormattingEnabled = true;
            this.operationsComboBox.Location = new System.Drawing.Point(248, 303);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(169, 28);
            this.operationsComboBox.TabIndex = 5;
            this.operationsComboBox.SelectedIndexChanged += new System.EventHandler(this.operationsComboBox_SelectedIndexChanged);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.Location = new System.Drawing.Point(249, 348);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(52, 20);
            this.resultlbl.TabIndex = 6;
            this.resultlbl.Text = "Result:";
            // 
            // fromRndValueLbl
            // 
            this.fromRndValueLbl.AutoSize = true;
            this.fromRndValueLbl.Location = new System.Drawing.Point(251, 12);
            this.fromRndValueLbl.Name = "fromRndValueLbl";
            this.fromRndValueLbl.Size = new System.Drawing.Size(146, 20);
            this.fromRndValueLbl.TabIndex = 7;
            this.fromRndValueLbl.Text = "From Random Value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fromRndValueLbl);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.operationsComboBox);
            this.Controls.Add(this.countUpDown);
            this.Controls.Add(this.rightUpDown);
            this.Controls.Add(this.leftUpDown);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.listNums);
            this.Name = "Form1";
            this.Text = "Result:";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leftUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNums;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.NumericUpDown leftUpDown;
        private System.Windows.Forms.NumericUpDown rightUpDown;
        private System.Windows.Forms.NumericUpDown countUpDown;
        private System.Windows.Forms.ComboBox operationsComboBox;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label fromRndValueLbl;
    }
}

