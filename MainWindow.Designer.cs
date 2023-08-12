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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checksumNameTextBox = new System.Windows.Forms.TextBox();
            this.checksumTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idChecksumTextBox
            // 
            this.idChecksumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idChecksumTextBox.Location = new System.Drawing.Point(158, 83);
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
            this.d0ChecksumTextBox.Location = new System.Drawing.Point(222, 83);
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
            this.d1ChecksumTextBox.Location = new System.Drawing.Point(286, 83);
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
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checksumNameTextBox);
            this.groupBox1.Controls.Add(this.checksumTypeComboBox);
            this.groupBox1.Controls.Add(this.d1ChecksumTextBox);
            this.groupBox1.Controls.Add(this.idChecksumTextBox);
            this.groupBox1.Controls.Add(this.d0ChecksumTextBox);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "D0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "D1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // checksumNameTextBox
            // 
            this.checksumNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksumNameTextBox.Location = new System.Drawing.Point(6, 83);
            this.checksumNameTextBox.Name = "checksumNameTextBox";
            this.checksumNameTextBox.Size = new System.Drawing.Size(146, 28);
            this.checksumNameTextBox.TabIndex = 5;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 526);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainWindow";
            this.Text = "UDP Tester";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

