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

namespace UITest
{
    public partial class NumberTextBox : TextBox
    {
        private decimal? _value;
        public decimal? Value {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        private static CultureInfo CURRENT_CULTURE;
        public NumberTextBox()
        {
            InitializeComponent();
            CURRENT_CULTURE = CultureInfo.CurrentCulture;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            try
            {
                if (!char.IsControl(e.KeyChar)
                    && !char.IsNumber(e.KeyChar)
                    && e.KeyChar != '-' 
                    && e.KeyChar != ','
                    && e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            try
            {
                if (this.Text.Contains(","))
                {
                    if (this.Text.Where(x => x == ',').Count() > 1)
                    {
                        _value = decimal.Parse(this.Text.Replace(",", ""));
                    }
                    else
                        _value = decimal.Parse(this.Text, new NumberFormatInfo { NumberDecimalSeparator = "," });
                }
                else
                    _value = Convert.ToDecimal(this.Text);

                this.Text = string.Format(CURRENT_CULTURE, "{0:#,##0.##}", _value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
