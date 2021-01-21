using System.ComponentModel;

namespace WordAssociations
{
    partial class ChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.doButton = new System.Windows.Forms.Button();
            this.deleteRadioButton = new System.Windows.Forms.RadioButton();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeGroupBox = new System.Windows.Forms.GroupBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.changeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(138, 361);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(120, 33);
            this.doButton.TabIndex = 1;
            this.doButton.Text = "Выполнить";
            this.doButton.UseVisualStyleBackColor = true;
            // 
            // deleteRadioButton
            // 
            this.deleteRadioButton.Location = new System.Drawing.Point(0, 58);
            this.deleteRadioButton.Name = "deleteRadioButton";
            this.deleteRadioButton.Size = new System.Drawing.Size(104, 24);
            this.deleteRadioButton.TabIndex = 2;
            this.deleteRadioButton.TabStop = true;
            this.deleteRadioButton.Text = "Удалить слово";
            this.deleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // addRadioButton
            // 
            this.addRadioButton.Location = new System.Drawing.Point(0, 19);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(104, 24);
            this.addRadioButton.TabIndex = 3;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Удалить слово";
            this.addRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 4;
            // 
            // changeGroupBox
            // 
            this.changeGroupBox.Controls.Add(this.addRadioButton);
            this.changeGroupBox.Controls.Add(this.deleteRadioButton);
            this.changeGroupBox.Location = new System.Drawing.Point(12, 307);
            this.changeGroupBox.Name = "changeGroupBox";
            this.changeGroupBox.Size = new System.Drawing.Size(120, 100);
            this.changeGroupBox.TabIndex = 6;
            this.changeGroupBox.TabStop = false;
            this.changeGroupBox.Text = "Изменить список";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(138, 311);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(120, 15);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Введите слово ниже";
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.Location = new System.Drawing.Point(21, 22);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(226, 264);
            this.wordsListBox.TabIndex = 9;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 450);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.changeGroupBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(286, 489);
            this.Name = "ChildForm";
            this.Text = "Настройка слов";
            this.changeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox wordsListBox;

        private System.Windows.Forms.Label descriptionLabel;

        private System.Windows.Forms.GroupBox changeGroupBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton deleteRadioButton;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button doButton;

        #endregion
    }
}