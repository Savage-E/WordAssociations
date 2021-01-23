using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WordAssociations
{
    public partial class MainForm : Form
    {
        private string[] testeeData;
        private List<string> associationsList;
        private bool isStarted;


        public MainForm()
        {
            InitializeComponent();
            testeeData = new string[5];

            associationsList = new List<string>();
            isStarted = false;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if (testeeLabel.Text == "")
            {
                MessageBox.Show("Введите данные испытуемого!");
            }
            else if (isStarted == true)
            {
                MessageBox.Show("Тест уже запущен!");
            }

            else if (chainOptionRadioButton.Checked == false && singleOprtionRadioButton.Checked == false)
            {
                MessageBox.Show("Выберите режим работы!");
            }

            else
            {
                MessageBox.Show("Сначала введите исходное слово в первую строку");
                isStarted = true;
                outputWordTextBox.ReadOnly = false;
            }
        }


        private void addTesteeButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" || lastNameLabel.Text == "" || ageNumericUpDown.Value == 0 ||
                genderLabel.Text == "")
            {
                MessageBox.Show("Введите Имя, Фамилию, Отчество(если имеется), пол и возраст!");
            }

            else
            {
                testeeData[0] = firstNameTextBox.Text.Trim();
                testeeData[1] = lastNameTextBox.Text.Trim();
                testeeData[2] = patronymicTextBox.Text.Trim();
                testeeData[3] = ageNumericUpDown.Text.Trim();
                testeeData[4] = genderComboBox.Text;
                testeeLabel.Visible = true;
                if (testeeLabel.Text != "")
                {
                    testeeLabel.Text = "";
                }

                testeeLabel.Text += testeeData[1] + " " + testeeData[0] +
                                    " " + testeeData[2] + "\nВозвраст: " + testeeData[3] + "\nПол: " + testeeData[4];

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                patronymicTextBox.Text = "";
                ageNumericUpDown.Text = "";
                genderComboBox.Text = "";
            }
        }

        private void addAssocTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isStarted)
            {
                e.SuppressKeyPress = true;
                if (outputWordTextBox.Text == "")
                {
                    MessageBox.Show("Для начала введите исходное слово");
                    return;
                }


                if (addAssocTextBox.Text != "")
                {
                    associationsList.Add(addAssocTextBox.Text.Trim());

                    bool option = chainOptionRadioButton.Checked;
                    if (option)
                    {
                        outputWordTextBox.Text = addAssocTextBox.Text.Trim();
                    }


                    addAssocTextBox.Text = "";
                }
            }
        }

        private void Restore()
        {
            isStarted = false;
            outputWordTextBox.Text = "";
            associationsList = new List<string>();
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            if (isStarted == true)
            {
                DialogResult dr =
                    MessageBox.Show("Вы уверены, что хотите завершить тест?",
                        "Внимание!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (chainOptionRadioButton.Checked)
                    {
                        WordsLoader.LoadWords(testeeData, associationsList,"1");
                    }

                    else
                    {
                        WordsLoader.LoadWords(testeeData, associationsList,"2");

                    }
                    Restore();
                }
            }
        }
    }
}