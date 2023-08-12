using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdpTester {
    internal class Checksum {

        public static string generateFullMod256Checksum(string id, string d0, string d1) {

            byte checksum = (byte)((byte)(Utils.HexStringToInt(id) + Utils.HexStringToInt(d0) + Utils.HexStringToInt(d1)) % 256);

            return $"{id.ToUpper()} {d0.ToUpper()} {d1.ToUpper()} {checksum:X2}";
        }

        public static byte generateMod256Checksum(string id, string d0, string d1) {

            byte checksum = (byte)((byte)(Utils.HexStringToInt(id) + Utils.HexStringToInt(d0) + Utils.HexStringToInt(d1)) % 256);

            return checksum;
        }

        public static string generateFullXorChecksum(string id, string d0, string d1) {

            byte checksum = (byte)(Utils.HexStringToInt(id) ^ Utils.HexStringToInt(d0) ^ Utils.HexStringToInt(d1));

            return $"{id.ToUpper()} {d0.ToUpper()} {d1.ToUpper()} {checksum:X2}";
        }

        public static byte generateXorChecksum(string id, string d0, string d1) {

            byte checksum = (byte)(Utils.HexStringToInt(id) ^ Utils.HexStringToInt(d0) ^ Utils.HexStringToInt(d1));
           
            return checksum;
        }
    }
}
