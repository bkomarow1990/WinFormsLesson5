using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }
        private void ChangeResult()
        {
            int result = 0;
            if (this.operationsComboBox.SelectedIndex == 0)
            {
                foreach (var item in this.listNums.SelectedItems)
                {
                    result += (int)item;
                }
            }
            else if (this.operationsComboBox.SelectedIndex == 1)
            {
                result = 1;
                foreach (var item in this.listNums.SelectedItems)
                {
                    result *= (int)item;
                }
            }
            resultlbl.Text = result.ToString();
        }
        public enum Operation { Summ = 1, Mult }
        private void generatebtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            this.listNums.Items.Clear();
            for (int i = 0; i < this.countUpDown.Value; i++)
            {
                this.listNums.Items.Add(rnd.Next((int)this.leftUpDown.Value, (int)(this.rightUpDown.Value+1)));
            }
            if (this.operationsComboBox.SelectedItem == null)
            {
                return;
            }
            ChangeResult();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.operationsComboBox.DataSource = Enum.GetValues(typeof(Operation));
        }
        private void operationsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeResult();
        }

        private void listNums_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeResult();
        }
    }
}
