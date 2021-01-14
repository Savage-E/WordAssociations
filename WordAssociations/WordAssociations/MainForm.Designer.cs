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
            this.addWordButton = new System.Windows.Forms.Button();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.addWordTextBox = new System.Windows.Forms.TextBox();
            this.outputWordTextBox = new System.Windows.Forms.TextBox();
            this.associationLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.addAssocTextBox = new System.Windows.Forms.TextBox();
            this.addAssocButton = new System.Windows.Forms.Button();
            this.workType1RadioButton = new System.Windows.Forms.RadioButton();
            this.workType2RadioButton = new System.Windows.Forms.RadioButton();
            this.workTypesGroupBox = new System.Windows.Forms.GroupBox();
            this.workTypesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(639, 287);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(149, 40);
            this.addWordButton.TabIndex = 0;
            this.addWordButton.Text = "Добавить слово в общий список";
            this.addWordButton.UseVisualStyleBackColor = true;
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.Location = new System.Drawing.Point(639, 12);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(149, 186);
            this.wordsListBox.TabIndex = 1;
            // 
            // addWordTextBox
            // 
            this.addWordTextBox.Location = new System.Drawing.Point(639, 261);
            this.addWordTextBox.Name = "addWordTextBox";
            this.addWordTextBox.Size = new System.Drawing.Size(149, 20);
            this.addWordTextBox.TabIndex = 2;
            // 
            // outputWordTextBox
            // 
            this.outputWordTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.outputWordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputWordTextBox.Location = new System.Drawing.Point(33, 85);
            this.outputWordTextBox.Name = "outputWordTextBox";
            this.outputWordTextBox.Size = new System.Drawing.Size(117, 20);
            this.outputWordTextBox.TabIndex = 3;
            // 
            // associationLabel
            // 
            this.associationLabel.BackColor = System.Drawing.SystemColors.Info;
            this.associationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.associationLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.associationLabel.Location = new System.Drawing.Point(33, 12);
            this.associationLabel.Name = "associationLabel";
            this.associationLabel.Size = new System.Drawing.Size(117, 61);
            this.associationLabel.TabIndex = 4;
            this.associationLabel.Text = "Ниже вы увидите слово, для которого следует написать ассоциации";
            // 
            // wordLabel
            // 
            this.wordLabel.BackColor = System.Drawing.SystemColors.Info;
            this.wordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordLabel.Location = new System.Drawing.Point(639, 207);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(149, 51);
            this.wordLabel.TabIndex = 5;
            this.wordLabel.Text = "Введите слово, которое добавить в общий список слов для исследования";
            // 
            // addAssocTextBox
            // 
            this.addAssocTextBox.Location = new System.Drawing.Point(33, 124);
            this.addAssocTextBox.Name = "addAssocTextBox";
            this.addAssocTextBox.Size = new System.Drawing.Size(117, 20);
            this.addAssocTextBox.TabIndex = 6;
            // 
            // addAssocButton
            // 
            this.addAssocButton.Location = new System.Drawing.Point(33, 161);
            this.addAssocButton.Name = "addAssocButton";
            this.addAssocButton.Size = new System.Drawing.Size(117, 37);
            this.addAssocButton.TabIndex = 7;
            this.addAssocButton.Text = "Добавить ассоциации";
            this.addAssocButton.UseVisualStyleBackColor = true;
            // 
            // workType1RadioButton
            // 
            this.workType1RadioButton.Location = new System.Drawing.Point(6, 19);
            this.workType1RadioButton.Name = "workType1RadioButton";
            this.workType1RadioButton.Size = new System.Drawing.Size(120, 32);
            this.workType1RadioButton.TabIndex = 8;
            this.workType1RadioButton.TabStop = true;
            this.workType1RadioButton.Text = "Первый режим";
            this.workType1RadioButton.UseVisualStyleBackColor = true;
            // 
            // workType2RadioButton
            // 
            this.workType2RadioButton.Location = new System.Drawing.Point(6, 57);
            this.workType2RadioButton.Name = "workType2RadioButton";
            this.workType2RadioButton.Size = new System.Drawing.Size(105, 24);
            this.workType2RadioButton.TabIndex = 9;
            this.workType2RadioButton.TabStop = true;
            this.workType2RadioButton.Text = "Второй режим";
            this.workType2RadioButton.UseVisualStyleBackColor = true;
            // 
            // workTypesGroupBox
            // 
            this.workTypesGroupBox.Controls.Add(this.workType1RadioButton);
            this.workTypesGroupBox.Controls.Add(this.workType2RadioButton);
            this.workTypesGroupBox.Location = new System.Drawing.Point(179, 94);
            this.workTypesGroupBox.Name = "workTypesGroupBox";
            this.workTypesGroupBox.Size = new System.Drawing.Size(132, 104);
            this.workTypesGroupBox.TabIndex = 10;
            this.workTypesGroupBox.TabStop = false;
            this.workTypesGroupBox.Text = "Режимы работы";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workTypesGroupBox);
            this.Controls.Add(this.addAssocButton);
            this.Controls.Add(this.addAssocTextBox);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.associationLabel);
            this.Controls.Add(this.outputWordTextBox);
            this.Controls.Add(this.addWordTextBox);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.addWordButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.workTypesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox workTypesGroupBox;

        private System.Windows.Forms.Button addAssocButton;
        private System.Windows.Forms.RadioButton workType2RadioButton;
        private System.Windows.Forms.RadioButton workType1RadioButton;

        private System.Windows.Forms.TextBox addAssocTextBox;

        private System.Windows.Forms.Label wordLabel;

        private System.Windows.Forms.Label associationLabel;
        private System.Windows.Forms.TextBox outputWordTextBox;

        private System.Windows.Forms.TextBox addWordTextBox;
        private System.Windows.Forms.ListBox wordsListBox;

        private System.Windows.Forms.Button addWordButton;

        #endregion
    }
}