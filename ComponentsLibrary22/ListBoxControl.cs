using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentsLibrary22
{
    public partial class ListBoxControl : UserControl
    {
        public ListBoxControl()
        {
            InitializeComponent();
        }
        public String _maketLine;
        public String MaketLine {set { _maketLine = value; } }

        /// <summary>
        /// Порядковый номер выбранного элемента
        /// </summary>
        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get { return listBox.SelectedIndex; }
            set
            {
                if (value > -1 && value < listBox.Items.Count)
                {
                     listBox.SelectedIndex = value;
                }
            }
        }
        string[] chars = new string[2];
   

    }
}
