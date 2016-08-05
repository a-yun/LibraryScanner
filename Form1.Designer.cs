namespace LibraryScanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.databaseBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tallyLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.logBrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(204, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(246, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Number:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.idLabel.Location = new System.Drawing.Point(440, 248);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(101, 31);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "idLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameLabel.Location = new System.Drawing.Point(440, 289);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(147, 31);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "nameLabel";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.idBox.Location = new System.Drawing.Point(446, 172);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(225, 38);
            this.idBox.TabIndex = 4;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            this.idBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(277, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter ID:";
            // 
            // databaseBrowseButton
            // 
            this.databaseBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databaseBrowseButton.Location = new System.Drawing.Point(867, 39);
            this.databaseBrowseButton.Name = "databaseBrowseButton";
            this.databaseBrowseButton.Size = new System.Drawing.Size(100, 38);
            this.databaseBrowseButton.TabIndex = 6;
            this.databaseBrowseButton.Text = "Browse";
            this.databaseBrowseButton.UseVisualStyleBackColor = true;
            this.databaseBrowseButton.Click += new System.EventHandler(this.databaseBrowseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(36, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Database:";
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.databaseLabel.Location = new System.Drawing.Point(282, 50);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(31, 20);
            this.databaseLabel.TabIndex = 9;
            this.databaseLabel.Text = "C:\\";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(92, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Log Directory:";
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logLabel.Location = new System.Drawing.Point(282, 104);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(31, 20);
            this.logLabel.TabIndex = 11;
            this.logLabel.Text = "C:\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(319, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tally:";
            // 
            // tallyLabel
            // 
            this.tallyLabel.AutoSize = true;
            this.tallyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tallyLabel.Location = new System.Drawing.Point(440, 418);
            this.tallyLabel.Name = "tallyLabel";
            this.tallyLabel.Size = new System.Drawing.Size(129, 31);
            this.tallyLabel.TabIndex = 14;
            this.tallyLabel.Text = "tallyLabel";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(729, 417);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 38);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.Lime;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.Black;
            this.enterButton.Location = new System.Drawing.Point(729, 172);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 38);
            this.enterButton.TabIndex = 16;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(302, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grade:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.gradeLabel.Location = new System.Drawing.Point(440, 330);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(149, 31);
            this.gradeLabel.TabIndex = 19;
            this.gradeLabel.Text = "gradeLabel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(37, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(715, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Any manual changes to the database must be made while program is not running.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(37, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(357, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "© 2015 Antony Yun All Rights Reserved";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(37, 511);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(504, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "Contact ant8020@gmail.com with any questions or bugs.";
            // 
            // logBrowseButton
            // 
            this.logBrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBrowseButton.Location = new System.Drawing.Point(867, 93);
            this.logBrowseButton.Name = "logBrowseButton";
            this.logBrowseButton.Size = new System.Drawing.Size(100, 38);
            this.logBrowseButton.TabIndex = 12;
            this.logBrowseButton.Text = "Browse";
            this.logBrowseButton.UseVisualStyleBackColor = true;
            this.logBrowseButton.Click += new System.EventHandler(this.logBrowseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 606);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.tallyLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.logBrowseButton);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.databaseBrowseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Library Scanner v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button databaseBrowseButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tallyLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button logBrowseButton;
    }
}

