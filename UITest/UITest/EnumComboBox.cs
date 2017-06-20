using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITest
{
    public partial class EnumComboBox : ComboBox
    {
        public Type EnumType { get; set; }
        public Enum Value
        {
            get
            {
                return ReturnValue();
            }
            set { }
        }

        public EnumComboBox()
        {
            InitializeComponent();
        }

        private Enum ReturnValue()
        {
            if (this.SelectedItem != null)
            {
                return (Enum)this.SelectedValue;
            }
            return null;
        }
    }
}
