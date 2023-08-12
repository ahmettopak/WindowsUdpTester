using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpTester {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
      
        }

        

        private void validateTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.validateTextBoxInput(e);
        }

       

        private void generateChecksumButton_Click(object sender, EventArgs e) {
            checksumLabel.Text = Utils.generateFullMod256Checksum(idChecksumTextBox.Text, d0ChecksumTextBox.Text, d1ChecksumTextBox.Text);
            
        }

   

    }
}
