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

namespace UoH
{
    public partial class Main : Form
    {
        // loads components, ignore this
        public Main() { InitializeComponent(); }

        // forcing program to focus on source address textbox
        private void Main_Load(object sender, EventArgs e)
        { ActiveControl = sourceAddressTextBox; }

        // function initiated when text of the main address is being changed
        private void sourceAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            // range in long variable that will be added/removed from source address
            long range = 0;

            // source address in long variable that below will add/remove range to
            long sourceAddress = 0;

            // parse sanitized range string to "long" number +
            // parse sanitiez source address to "long" number
            if (long.TryParse(sanitizeString(rangeTextBox.Text), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out range) &&
            (long.TryParse(sanitizeString(sourceAddressTextBox.Text), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out sourceAddress)))
            {
                // add range, convert to hex and display
                minusAddressTextBox.Text = (sourceAddress - range).ToString("X");
                plusAddressTextBox.Text = (sourceAddress + range).ToString("X");

                // changing error indicator to success
                errorIndicator.BackColor = Color.LimeGreen;
            }
            // changing error indicator to error
            else errorIndicator.BackColor = Color.Red;
        }

        // select all text on clicked textbox
        void selectAllText(object sender, EventArgs e)
        {
            // getting clicked textbox
            TextBox toChange = sender as TextBox;

            // selecting all text on clicked textbox
            toChange.SelectAll();
        }

        // sanitizes string before parsing
        string sanitizeString(string text)
        {
            // replace spaces with nothing
            while (text.IndexOf(" ") != -1)
                text.Replace(" ", "");

            // removing 0x for hexa numbers
            text.Replace("0x", "");

            // return sanitized string
            return text;
        }

        // selecting all text for minus/plus textboxes after clicking on them
        private void minusAddressTextBox_MouseDown(object sender, MouseEventArgs e) { minusAddressTextBox.SelectAll(); }
        private void plusAddressTextBox_MouseDown(object sender, MouseEventArgs e) { plusAddressTextBox.SelectAll(); }
    }
}