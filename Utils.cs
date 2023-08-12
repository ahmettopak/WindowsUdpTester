using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace UdpTester {
    internal class Utils {

        private static bool IsHexDigit(char c) {
            return (c >= '0' && c <= '9') ||
                   (c >= 'A' && c <= 'F') ||
                   (c >= 'a' && c <= 'f');
        }

        public static void ValidateHexTextBoxInput(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !IsHexDigit(e.KeyChar)) {
                e.Handled = true;
            }

        }

        public static void ValidateDecimalTextBoxInput(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        

        public static int HexStringToInt(string str) {
            return int.Parse(str, System.Globalization.NumberStyles.HexNumber);
        }

        public static void ValidateTextBoxValue(TextBox textBox) {

            string value = textBox.Text;

            // Değer 1 karakter ise başına 0 ekleyerek düzenle
            if (value.Length == 1) {
                value = "0" + value;
            }
            // Değer 0 karakter ise değeri 00 yaparak düzenle
            else if (value.Length == 0) {
                value = "00";
            }

        
            textBox.Text = value;
        }




    }
}
