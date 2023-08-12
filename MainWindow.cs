using System;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace UdpTester {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            InitializeComboBox();
        }

        private void validateHexTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.ValidateHexTextBoxInput(e);
        }

        private void generateChecksumButton_Click(object sender, EventArgs e) {
            Utils.ValidateTextBoxValue(idChecksumTextBox);
            Utils.ValidateTextBoxValue(d0ChecksumTextBox);
            Utils.ValidateTextBoxValue(d1ChecksumTextBox);
            if (checksumTypeComboBox.SelectedIndex==0) {
                checksumLabel.Text = checksumNameTextBox.Text + " " + Checksum.generateFullMod256Checksum(idChecksumTextBox.Text, d0ChecksumTextBox.Text, d1ChecksumTextBox.Text);
            }
            else if (checksumTypeComboBox.SelectedIndex ==1) {
                checksumLabel.Text = checksumNameTextBox.Text + " " + Checksum.generateFullXorChecksum(idChecksumTextBox.Text, d0ChecksumTextBox.Text, d1ChecksumTextBox.Text);
            }
                  
        }

        private void TextBoxUpperCase(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = textBox.Text.Length;
        }

        private void CopyLabelText(object sender, EventArgs e) {
            Label label = (Label)sender;
            Clipboard.SetText(label.Text);
        }

        private void CopyListBoxItemText(object sender, EventArgs e) {
            ListBox listBox = (ListBox)sender;
            string text = listBox.SelectedItem.ToString();
            //To copy only part of the data, we separate it with the substring method.
            //ex: "11 11 11 11"
            Clipboard.SetText(text.Substring(text.Length - 11));
        }

        private void saveChecksumButton_Click(object sender, EventArgs e) {
            savedChecksumListBox.Items.Add(checksumLabel.Text);
        }

        private void InitializeComboBox() {

            string[] checksumTypeItems = { "Mod 256", "XOR"};

            checksumTypeComboBox.Items.AddRange(checksumTypeItems);

            checksumTypeComboBox.SelectedIndex = 0;
        }

        private void clearChecksumListBoxButton_Click(object sender, EventArgs e) {
            savedChecksumListBox.Items.Clear();
        }

     
    }
}
