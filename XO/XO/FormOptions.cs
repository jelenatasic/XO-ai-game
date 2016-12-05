using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO
{
    public partial class FormOptions : MetroFramework.Forms.MetroForm
    {
        public FormOptions()
        {
            InitializeComponent();
            RadioButton_Human_vs_Human.Checked = true;
            RadioButton_Human_vs_Computer.Checked = false;
            groupBox_FirstPlayer.Visible = false;
            
        }

        private void RadioButton_Human_vs_Human_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Human_vs_Human.Checked)
            {
                RadioButton_Human_vs_Computer.Checked = false;
                groupBox_FirstPlayer.Visible = false;
            }
            else
                groupBox_FirstPlayer.Visible = true;
        }

        private void RadioButton_Human_vs_Computer_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Human_vs_Computer.Checked)
            {
                RadioButton_Human_vs_Human.Checked = false;
                groupBox_FirstPlayer.Visible = true;
            }
            else
                groupBox_FirstPlayer.Visible = false;
        }

        private void Button_StartGame_Click(object sender, EventArgs e)
        {
            FormTabel tabla = new FormTabel(RadioButton_Human_vs_Computer.Checked, RadioButton_FirtstPlayer_Computer.Checked, this);
            this.Visible = false;
            tabla.Visible = true;
        }
    }
}
