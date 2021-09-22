using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        String str1 = "Раз два три четыре";
        String str2 = "One two three four";
        private Person[] persons =
        {
            new Person()
            {
                FirstName = "Mariya",
                LastName = "Pavlova"
            },
            new Person()
            {
                FirstName = "At",
                LastName = "dgvb"
            },
            new Person()
            {
                FirstName = "rh",
                LastName = "Pavndndlova"
            }
        };
        public Form1()
        {
            InitializeComponent();
            textboxControl1.SetToolTip("12/23/2021");
            comboboxControl1.AddToList(str1);
            comboboxControl1.AddToList(str2);
            listBoxControl1.MaketLine = "FirstName Мария, LastName Павлова";
           

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            comboboxControl1.SelectedIndex = 0;
        }

        private void comboboxControl1_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(comboboxControl1.SelectedText);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textboxControl1.EnteredDate);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
