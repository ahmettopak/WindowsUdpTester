using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpTester {
    internal class Utils {

        private static bool IsHexDigit(char c) {
            return (c >= '0' && c <= '9') ||
                   (c >= 'A' && c <= 'F') ||
                   (c >= 'a' && c <= 'f');
        }

        public static void validateTextBoxInput(KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !IsHexDigit(e.KeyChar)) {
                e.Handled = true;
            }

        }

        public static byte generateMod256Checksum(byte id, byte d0, byte d1) {
            byte checksum = (byte)((byte)(id + d0 + d1) % 256);

            return checksum;
        }

        public static byte generateMod256Checksum(string id, string d0, string d1) {
            byte checksum = (byte)(Convert.ToByte(id) + Convert.ToByte(d0) + Convert.ToByte(d1) % 256);
            
            return checksum;
        }

        public static string generateFullMod256Checksum(string id, string d0, string d1) {

            byte checksum = ((byte)((byte)(Convert.ToByte(id) + Convert.ToByte(d0) + Convert.ToByte(d1)) % 256));

            return id + d0 + d1+ checksum;
        }




    }
}
