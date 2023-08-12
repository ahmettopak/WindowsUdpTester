namespace UdpTester {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.idChecksumTextBox = new System.Windows.Forms.TextBox();
            this.d0ChecksumTextBox = new System.Windows.Forms.TextBox();
            this.d1ChecksumTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearChecksumListBoxButton = new System.Windows.Forms.Button();
            this.saveChecksumButton = new System.Windows.Forms.Button();
            this.generateChecksumButton = new System.Windows.Forms.Button();
            this.checksumLabel = new System.Windows.Forms.Label();
            this.savedChecksumListBox = new System.Windows.Forms.ListBox();
            this.checksumTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checksumNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idChecksumTextBox
            // 
            this.idChecksumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idChecksumTextBox.Location = new System.Drawing.Point(131, 79);
            this.idChecksumTextBox.MaxLength = 2;
            this.idChecksumTextBox.Name = "idChecksumTextBox";
            this.idChecksumTextBox.Size = new System.Drawing.Size(58, 28);
            this.idChecksumTextBox.TabIndex = 0;
            this.idChecksumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idChecksumTextBox.TextChanged += new System.EventHandler(this.TextBoxUpperCase);
            this.idChecksumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateHexTextBox_KeyPress);
            // 
            // d0ChecksumTextBox
            // 
            this.d0ChecksumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d0ChecksumTextBox.Location = new System.Drawing.Point(195, 79);
            this.d0ChecksumTextBox.MaxLength = 2;
            this.d0ChecksumTextBox.Name = "d0ChecksumTextBox";
            this.d0ChecksumTextBox.Size = new System.Drawing.Size(58, 28);
            this.d0ChecksumTextBox.TabIndex = 1;
            this.d0ChecksumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d0ChecksumTextBox.TextChanged += new System.EventHandler(this.TextBoxUpperCase);
            this.d0ChecksumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateHexTextBox_KeyPress);
            // 
            // d1ChecksumTextBox
            // 
            this.d1ChecksumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1ChecksumTextBox.Location = new System.Drawing.Point(259, 79);
            this.d1ChecksumTextBox.MaxLength = 2;
            this.d1ChecksumTextBox.Name = "d1ChecksumTextBox";
            this.d1ChecksumTextBox.Size = new System.Drawing.Size(58, 28);
            this.d1ChecksumTextBox.TabIndex = 2;
            this.d1ChecksumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.d1ChecksumTextBox.TextChanged += new System.EventHandler(this.TextBoxUpperCase);
            this.d1ChecksumTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateHexTextBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearChecksumListBoxButton);
            this.groupBox1.Controls.Add(this.saveChecksumButton);
            this.groupBox1.Controls.Add(this.generateChecksumButton);
            this.groupBox1.Controls.Add(this.checksumLabel);
            this.groupBox1.Controls.Add(this.savedChecksumListBox);
            this.groupBox1.Controls.Add(this.checksumTypeComboBox);
            this.groupBox1.Controls.Add(this.d1ChecksumTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.d0ChecksumTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.idChecksumTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checksumNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 502);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Checksum Generator";
            // 
            // clearChecksumListBoxButton
            // 
            this.clearChecksumListBoxButton.Location = new System.Drawing.Point(10, 25);
            this.clearChecksumListBoxButton.Name = "clearChecksumListBoxButton";
            this.clearChecksumListBoxButton.Size = new System.Drawing.Size(85, 36);
            this.clearChecksumListBoxButton.TabIndex = 11;
            this.clearChecksumListBoxButton.Text = "Clear";
            this.clearChecksumListBoxButton.UseVisualStyleBackColor = true;
            this.clearChecksumListBoxButton.Click += new System.EventHandler(this.clearChecksumListBoxButton_Click);
            // 
            // saveChecksumButton
            // 
            this.saveChecksumButton.Location = new System.Drawing.Point(259, 165);
            this.saveChecksumButton.Name = "saveChecksumButton";
            this.saveChecksumButton.Size = new System.Drawing.Size(85, 36);
            this.saveChecksumButton.TabIndex = 10;
            this.saveChecksumButton.Text = "Save";
            this.saveChecksumButton.UseVisualStyleBackColor = true;
            this.saveChecksumButton.Click += new System.EventHandler(this.saveChecksumButton_Click);
            // 
            // generateChecksumButton
            // 
            this.generateChecksumButton.Location = new System.Drawing.Point(259, 123);
            this.generateChecksumButton.Name = "generateChecksumButton";
            this.generateChecksumButton.Size = new System.Drawing.Size(85, 36);
            this.generateChecksumButton.TabIndex = 9;
            this.generateChecksumButton.Text = "Generate";
            this.generateChecksumButton.UseVisualStyleBackColor = true;
            this.generateChecksumButton.Click += new System.EventHandler(this.generateChecksumButton_Click);
            // 
            // checksumLabel
            // 
            this.checksumLabel.AutoSize = true;
            this.checksumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksumLabel.Location = new System.Drawing.Point(6, 120);
            this.checksumLabel.Name = "checksumLabel";
            this.checksumLabel.Size = new System.Drawing.Size(0, 20);
            this.checksumLabel.TabIndex = 8;
            this.checksumLabel.Click += new System.EventHandler(this.CopyLabelText);
            // 
            // savedChecksumListBox
            // 
            this.savedChecksumListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedChecksumListBox.FormattingEnabled = true;
            this.savedChecksumListBox.ItemHeight = 20;
            this.savedChecksumListBox.Location = new System.Drawing.Point(10, 207);
            this.savedChecksumListBox.Name = "savedChecksumListBox";
            this.savedChecksumListBox.Size = new System.Drawing.Size(334, 284);
            this.savedChecksumListBox.TabIndex = 7;
            this.savedChecksumListBox.Tag = "";
            this.savedChecksumListBox.SelectedIndexChanged += new System.EventHandler(this.CopyListBoxItemText);
            // 
            // checksumTypeComboBox
            // 
            this.checksumTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checksumTypeComboBox.FormattingEnabled = true;
            this.checksumTypeComboBox.Location = new System.Drawing.Point(223, 21);
            this.checksumTypeComboBox.Name = "checksumTypeComboBox";
            this.checksumTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.checksumTypeComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "D0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "D1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // checksumNameTextBox
            // 
            this.checksumNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksumNameTextBox.Location = new System.Drawing.Point(11, 79);
            this.checksumNameTextBox.Name = "checksumNameTextBox";
            this.checksumNameTextBox.Size = new System.Drawing.Size(110, 28);
            this.checksumNameTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 259);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(447, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 224);
            this.listBox1.TabIndex = 12;
            this.listBox1.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(113, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(113, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 28);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 28);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(113, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 28);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(6, 79);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(101, 28);
            this.textBox4.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(113, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 28);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(6, 113);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(101, 28);
            this.textBox6.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(113, 147);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(186, 28);
            this.textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(6, 147);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(101, 28);
            this.textBox8.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(305, 147);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(113, 216);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(186, 28);
            this.textBox9.TabIndex = 31;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(6, 216);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(101, 28);
            this.textBox10.TabIndex = 30;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(305, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 28);
            this.button5.TabIndex = 29;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(113, 182);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(186, 28);
            this.textBox11.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(6, 182);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(101, 28);
            this.textBox12.TabIndex = 27;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(305, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 28);
            this.button6.TabIndex = 26;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(376, 216);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 28);
            this.button7.TabIndex = 37;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(376, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 28);
            this.button8.TabIndex = 36;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(376, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(65, 28);
            this.button9.TabIndex = 35;
            this.button9.Text = "Save";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(376, 113);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(65, 28);
            this.button10.TabIndex = 34;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(376, 79);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(65, 28);
            this.button11.TabIndex = 33;
            this.button11.Text = "Save";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(376, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(65, 28);
            this.button12.TabIndex = 32;
            this.button12.Text = "Save";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(368, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 237);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(162, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(549, 212);
            this.listBox2.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "UDP Tester";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox idChecksumTextBox;
        private System.Windows.Forms.TextBox d0ChecksumTextBox;
        private System.Windows.Forms.TextBox d1ChecksumTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox checksumTypeComboBox;
        private System.Windows.Forms.TextBox checksumNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label checksumLabel;
        private System.Windows.Forms.ListBox savedChecksumListBox;
        private System.Windows.Forms.Button generateChecksumButton;
        private System.Windows.Forms.Button saveChecksumButton;
        private System.Windows.Forms.Button clearChecksumListBoxButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
    }
}

