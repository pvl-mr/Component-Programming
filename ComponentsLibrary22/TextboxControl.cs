using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentsLibrary22
{
    public partial class TextboxControl : UserControl
    {
        public TextboxControl()
        {
            InitializeComponent();

        }

        public String patternToData = "MM/dd/yyyy";
        private String _enteredDate;

        public void SetToolTip(string value)
        {
            toolTip.SetToolTip(textBox, value);
        }

        public String EnteredDate
        {
            get
            {
                if (IsRightDate(textBox.Text))
                {
                    _enteredDate = textBox.Text;
                    return _enteredDate;
                }
                else
                {
                    throw new Exception("Введено не в правильном формате");
                };
            }
            set
            {
                _enteredDate = textBox.Text;
            }
        }

        public bool IsRightDate(String date)
        {
            DateTime dt;
            return DateTime.TryParseExact(
                        date,
                        patternToData,
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out dt);
        }
    }
}
