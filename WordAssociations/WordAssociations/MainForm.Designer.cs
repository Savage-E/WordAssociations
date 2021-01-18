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
            this.associationLabel = new System.Windows.Forms.Label();
            this.addAssocTextBox = new System.Windows.Forms.TextBox();
            this.testeeGroupBox = new System.Windows.Forms.GroupBox();
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
            this.wordCountLabel = new System.Windows.Forms.Label();
            this.configureWordsButton = new System.Windows.Forms.Button();
            this.testeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // outputWordTextBox
            // 
            this.outputWordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.outputWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputWordTextBox.Location = new System.Drawing.Point(12, 92);
            this.outputWordTextBox.Name = "outputWordTextBox";
            this.outputWordTextBox.ReadOnly = true;
            this.outputWordTextBox.Size = new System.Drawing.Size(140, 20);
            this.outputWordTextBox.TabIndex = 3;
            // 
            // associationLabel
            // 
            this.associationLabel.BackColor = System.Drawing.SystemColors.Info;
            this.associationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.associationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.associationLabel.Location = new System.Drawing.Point(12, 12);
            this.associationLabel.Name = "associationLabel";
            this.associationLabel.Size = new System.Drawing.Size(140, 61);
            this.associationLabel.TabIndex = 4;
            this.associationLabel.Text = "Ниже вы увидите слово, для которого следует написать ассоциации";
            // 
            // addAssocTextBox
            // 
            this.addAssocTextBox.Location = new System.Drawing.Point(12, 129);
            this.addAssocTextBox.Name = "addAssocTextBox";
            this.addAssocTextBox.Size = new System.Drawing.Size(140, 20);
            this.addAssocTextBox.TabIndex = 6;
            this.addAssocTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addAssocTextBox_KeyDown);
            // 
            // testeeGroupBox
            // 
            this.testeeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.testeeGroupBox.Location = new System.Drawing.Point(373, 12);
            this.testeeGroupBox.Name = "testeeGroupBox";
            this.testeeGroupBox.Size = new System.Drawing.Size(194, 229);
            this.testeeGroupBox.TabIndex = 8;
            this.testeeGroupBox.TabStop = false;
            this.testeeGroupBox.Text = "Данные испытуемого";
            // 
            // ageNumericUpDown
            // 
            this.ageNumericUpDown.Location = new System.Drawing.Point(107, 163);
            this.ageNumericUpDown.Name = "ageNumericUpDown";
            this.ageNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.ageNumericUpDown.TabIndex = 10;
            // 
            // testeeLabel
            // 
            this.testeeLabel.Location = new System.Drawing.Point(15, 28);
            this.testeeLabel.Name = "testeeLabel";
            this.testeeLabel.Size = new System.Drawing.Size(143, 33);
            this.testeeLabel.TabIndex = 9;
            this.testeeLabel.Visible = false;
            // 
            // ageLabel
            // 
            this.ageLabel.Location = new System.Drawing.Point(108, 139);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(74, 16);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Возраст";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.Location = new System.Drawing.Point(12, 139);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(74, 16);
            this.patronymicLabel.TabIndex = 7;
            this.patronymicLabel.Text = "Отчество";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(108, 84);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(74, 16);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(12, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(74, 16);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(6, 158);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(80, 20);
            this.patronymicTextBox.TabIndex = 3;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 103);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(80, 20);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(6, 103);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(80, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // addTesteeButton
            // 
            this.addTesteeButton.Location = new System.Drawing.Point(61, 198);
            this.addTesteeButton.Name = "addTesteeButton";
            this.addTesteeButton.Size = new System.Drawing.Size(80, 25);
            this.addTesteeButton.TabIndex = 0;
            this.addTesteeButton.Text = "Добавить испытуемого";
            this.addTesteeButton.UseVisualStyleBackColor = true;
            this.addTesteeButton.Click += new System.EventHandler(this.addTesteeButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 170);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(93, 170);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(77, 23);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Завершить";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // wordCountLabel
            // 
            this.wordCountLabel.Location = new System.Drawing.Point(12, 73);
            this.wordCountLabel.Name = "wordCountLabel";
            this.wordCountLabel.Size = new System.Drawing.Size(96, 18);
            this.wordCountLabel.TabIndex = 11;
            this.wordCountLabel.Text = "Слово : ";
            this.wordCountLabel.Visible = false;
            // 
            // configureWordsButton
            // 
            this.configureWordsButton.Location = new System.Drawing.Point(429, 398);
            this.configureWordsButton.Name = "configureWordsButton";
            this.configureWordsButton.Size = new System.Drawing.Size(138, 40);
            this.configureWordsButton.TabIndex = 12;
            this.configureWordsButton.Text = "Настроить список доступных слов";
            this.configureWordsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.configureWordsButton);
            this.Controls.Add(this.wordCountLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.testeeGroupBox);
            this.Controls.Add(this.addAssocTextBox);
            this.Controls.Add(this.associationLabel);
            this.Controls.Add(this.outputWordTextBox);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Word Associations";
            this.testeeGroupBox.ResumeLayout(false);
            this.testeeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ageNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown ageNumericUpDown;

        private System.Windows.Forms.Label testeeLabel;

        private System.Windows.Forms.Button configureWordsButton;

        private System.Windows.Forms.Label wordCountLabel;

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

        private System.Windows.Forms.Label associationLabel;
        private System.Windows.Forms.TextBox outputWordTextBox;

        #endregion
    }
}