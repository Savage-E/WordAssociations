using System.ComponentModel;

namespace WordAssociations
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputWordTextBox = new System.Windows.Forms.TextBox();
            this.addAssocTextBox = new System.Windows.Forms.TextBox();
            this.testeeGroupBox = new System.Windows.Forms.GroupBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.testeeLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.addTesteeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.workOptionGroupBox = new System.Windows.Forms.GroupBox();
            this.singleOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.chainOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.addInstructionButton = new System.Windows.Forms.Button();
            this.instuctionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.testeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ageNumericUpDown)).BeginInit();
            this.workOptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputWordTextBox
            // 
            this.outputWordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.outputWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputWordTextBox.Enabled = false;
            this.outputWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.outputWordTextBox.Location = new System.Drawing.Point(299, 330);
            this.outputWordTextBox.Name = "outputWordTextBox";
            this.outputWordTextBox.Size = new System.Drawing.Size(310, 32);
            this.outputWordTextBox.TabIndex = 3;
            // 
            // addAssocTextBox
            // 
            this.addAssocTextBox.Enabled = false;
            this.addAssocTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addAssocTextBox.Location = new System.Drawing.Point(299, 390);
            this.addAssocTextBox.Name = "addAssocTextBox";
            this.addAssocTextBox.Size = new System.Drawing.Size(310, 32);
            this.addAssocTextBox.TabIndex = 6;
            this.addAssocTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addAssocTextBox_KeyDown);
            // 
            // testeeGroupBox
            // 
            this.testeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testeeGroupBox.Controls.Add(this.genderComboBox);
            this.testeeGroupBox.Controls.Add(this.genderLabel);
            this.testeeGroupBox.Controls.Add(this.ageNumericUpDown);
            this.testeeGroupBox.Controls.Add(this.testeeLabel);
            this.testeeGroupBox.Controls.Add(this.ageLabel);
            this.testeeGroupBox.Controls.Add(this.patronymicLabel);
            this.testeeGroupBox.Controls.Add(this.lastNameLabel);
            this.testeeGroupBox.Controls.Add(this.nameLabel);
            this.testeeGroupBox.Controls.Add(this.patronymicTextBox);
            this.testeeGroupBox.Controls.Add(this.lastNameTextBox);
            this.testeeGroupBox.Controls.Add(this.firstNameTextBox);
            this.testeeGroupBox.Controls.Add(this.addTesteeButton);
            this.testeeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.testeeGroupBox.Location = new System.Drawing.Point(669, 24);
            this.testeeGroupBox.Name = "testeeGroupBox";
            this.testeeGroupBox.Size = new System.Drawing.Size(328, 296);
            this.testeeGroupBox.TabIndex = 8;
            this.testeeGroupBox.TabStop = false;
            this.testeeGroupBox.Text = "Данные испытуемого";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Items.AddRange(new object[] {"Мужской", "Женский"});
            this.genderComboBox.Location = new System.Drawing.Point(137, 198);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(97, 28);
            this.genderComboBox.TabIndex = 14;
            // 
            // genderLabel
            // 
            this.genderLabel.Location = new System.Drawing.Point(134, 172);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(69, 23);
            this.genderLabel.TabIndex = 11;
            this.genderLabel.Text = "Пол";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(187, 143);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(47, 27);
            this.ageNumericUpDown.TabIndex = 10;
            // 
            // testeeLabel
            // 
            this.testeeLabel.Location = new System.Drawing.Point(15, 28);
            this.testeeLabel.Name = "testeeLabel";
            this.testeeLabel.Size = new System.Drawing.Size(270, 85);
            this.testeeLabel.TabIndex = 9;
            this.testeeLabel.Visible = false;
            // 
            // ageLabel
            // 
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ageLabel.Location = new System.Drawing.Point(184, 114);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(101, 26);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Возраст";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.Location = new System.Drawing.Point(6, 172);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(101, 22);
            this.patronymicLabel.TabIndex = 7;
            this.patronymicLabel.Text = "Отчество";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.lastNameLabel.Location = new System.Drawing.Point(86, 113);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 26);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nameLabel.Location = new System.Drawing.Point(6, 113);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 26);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(6, 198);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(101, 27);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(98, 142);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(80, 27);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 142);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(80, 27);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // addTesteeButton
            // 
            this.addTesteeButton.Location = new System.Drawing.Point(86, 231);
            this.addTesteeButton.Name = "addTesteeButton";
            this.addTesteeButton.Size = new System.Drawing.Size(117, 35);
            this.addTesteeButton.TabIndex = 0;
            this.addTesteeButton.Text = "Добавить испытуемого";
            this.addTesteeButton.UseVisualStyleBackColor = true;
            this.addTesteeButton.Click += new System.EventHandler(this.addTesteeButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.startButton.Location = new System.Drawing.Point(273, 516);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(174, 46);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.stopButton.Location = new System.Drawing.Point(476, 516);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(208, 47);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Завершить";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // workOptionGroupBox
            // 
            this.workOptionGroupBox.Controls.Add(this.singleOptionRadioButton);
            this.workOptionGroupBox.Controls.Add(this.chainOptionRadioButton);
            this.workOptionGroupBox.Enabled = false;
            this.workOptionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.workOptionGroupBox.Location = new System.Drawing.Point(12, 301);
            this.workOptionGroupBox.Name = "workOptionGroupBox";
            this.workOptionGroupBox.Size = new System.Drawing.Size(228, 121);
            this.workOptionGroupBox.TabIndex = 13;
            this.workOptionGroupBox.TabStop = false;
            this.workOptionGroupBox.Text = "Режим работы";
            // 
            // singleOptionRadioButton
            // 
            this.singleOptionRadioButton.Location = new System.Drawing.Point(13, 69);
            this.singleOptionRadioButton.Name = "singleOptionRadioButton";
            this.singleOptionRadioButton.Size = new System.Drawing.Size(144, 24);
            this.singleOptionRadioButton.TabIndex = 1;
            this.singleOptionRadioButton.TabStop = true;
            this.singleOptionRadioButton.Text = "Одно слово";
            this.singleOptionRadioButton.UseVisualStyleBackColor = true;
            this.singleOptionRadioButton.CheckedChanged += new System.EventHandler(this.singleOptionRadioButton_CheckedChanged);
            // 
            // chainOptionRadioButton
            // 
            this.chainOptionRadioButton.Location = new System.Drawing.Point(13, 25);
            this.chainOptionRadioButton.Name = "chainOptionRadioButton";
            this.chainOptionRadioButton.Size = new System.Drawing.Size(209, 24);
            this.chainOptionRadioButton.TabIndex = 0;
            this.chainOptionRadioButton.TabStop = true;
            this.chainOptionRadioButton.Text = "Цепочка ассоциаций";
            this.chainOptionRadioButton.UseVisualStyleBackColor = true;
            this.chainOptionRadioButton.CheckedChanged += new System.EventHandler(this.chainOptionRadioButton_CheckedChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SettingsButton.Location = new System.Drawing.Point(25, 438);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(178, 60);
            this.SettingsButton.TabIndex = 14;
            this.SettingsButton.Text = "Добавить настройку";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.wordCountLabel.Location = new System.Drawing.Point(309, 287);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(299, 33);
            this.wordCountLabel.TabIndex = 15;
            // 
            // addInstructionButton
            // 
            this.addInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addInstructionButton.Location = new System.Drawing.Point(25, 524);
            this.addInstructionButton.Name = "addInstructionButton";
            this.addInstructionButton.Size = new System.Drawing.Size(177, 57);
            this.addInstructionButton.TabIndex = 16;
            this.addInstructionButton.Text = "Добавить инструкцию";
            this.addInstructionButton.UseVisualStyleBackColor = true;
            this.addInstructionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // instuctionRichTextBox
            // 
            this.instuctionRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instuctionRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.instuctionRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.instuctionRichTextBox.Location = new System.Drawing.Point(299, 12);
            this.instuctionRichTextBox.Name = "instuctionRichTextBox";
            this.instuctionRichTextBox.Size = new System.Drawing.Size(311, 255);
            this.instuctionRichTextBox.TabIndex = 17;
            this.instuctionRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 608);
            this.Controls.Add(this.instuctionRichTextBox);
            this.Controls.Add(this.addInstructionButton);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.workOptionGroupBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.testeeGroupBox);
            this.Controls.Add(this.addAssocTextBox);
            this.Controls.Add(this.outputWordTextBox);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1025, 647);
            this.MinimumSize = new System.Drawing.Size(1025, 647);
            this.Name = "MainForm";
            this.Text = "Word Associations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.testeeGroupBox.ResumeLayout(false);
            this.testeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ageNumericUpDown)).EndInit();
            this.workOptionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox instuctionRichTextBox;

        private System.Windows.Forms.Button addInstructionButton;

        private System.Windows.Forms.Label wordCountLabel;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.ComboBox genderComboBox;

        private System.Windows.Forms.Label genderLabel;

        private System.Windows.Forms.RadioButton chainOptionRadioButton;
        private System.Windows.Forms.RadioButton singleOptionRadioButton;
        private System.Windows.Forms.GroupBox workOptionGroupBox;

        private System.Windows.Forms.NumericUpDown ageNumericUpDown;

        private System.Windows.Forms.Label testeeLabel;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;

        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;

        private System.Windows.Forms.Button addTesteeButton;
        private System.Windows.Forms.GroupBox testeeGroupBox;

        private System.Windows.Forms.TextBox addAssocTextBox;

        private System.Windows.Forms.TextBox outputWordTextBox;

        #endregion
    }
}