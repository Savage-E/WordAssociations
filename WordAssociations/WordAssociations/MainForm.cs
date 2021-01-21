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
        private string[] wordsList;
        private List<string> associationsList;
        private int count;
        private int amount;
        private bool isStarted;

        public MainForm()
        {
            InitializeComponent();
            testeeData = new string[4];
            wordsList = InitWords();
            associationsList = new List<string>();
            count = 1;
            amount = wordsList.Length;
            isStarted = false;
        }

        private static string[] InitWords()
        {
            string[] tempWordsList = null;

            try
            {
                tempWordsList = WordsReader.ReadWords();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show("Файл \"Words.txt \" со списком слов не найден!");
            }

            return tempWordsList;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (testeeLabel.Text == "")
            {
                MessageBox.Show("Введите данные испытуемого!");
            }
            else if (wordsList.Length == 0)
            {
                MessageBox.Show("Невозможно продолжить, т.к. отсутствуют слова в списке слов");
            }

            else if (isStarted == true)
            {
                MessageBox.Show("Тест уже запущен!");
            }
            else
            {
                isStarted = true;
                wordCountLabel.Visible = true;
                outputWordTextBox.Text = UpdateLabel();
                wordCountLabel.Text = "Слово : " + count + " из " + amount;
            }
        }


        private void addTesteeButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" || lastNameLabel.Text == "" || ageNumericUpDown.Value == 0)
            {
                MessageBox.Show("Введите Имя, Фамилию, Отчество(если имеется) и возраст!");
            }

            else
            {
                testeeData[0] = firstNameTextBox.Text.Trim();
                testeeData[1] = lastNameTextBox.Text.Trim();
                testeeData[2] = patronymicTextBox.Text.Trim();
                testeeData[3] = ageNumericUpDown.Text.Trim();
                testeeLabel.Visible = true;
                if (testeeLabel.Text != "")
                {
                    testeeLabel.Text = "";
                }

                testeeLabel.Text += testeeData[1] + " " + testeeData[0] +
                                    " " + testeeData[2] + " " + testeeData[3] + "лет";
            }
        }

        private void addAssocTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isStarted == true)
            {
                if (addAssocTextBox.Text != "")
                {
                    associationsList.Add(addAssocTextBox.Text.Trim());
                    count++;
                    if (count == amount + 1)
                    {
                        WordsLoader.LoadWords(testeeData, associationsList, wordsList);
                        Restore();
                        return;
                    }

                    outputWordTextBox.Text = UpdateLabel();
                    wordCountLabel.Text = "Слово : " + count + " из " + amount;
                }
            }
        }

        private void Restore()
        {
            isStarted = false;
            outputWordTextBox.Text = "";
            wordCountLabel.Text = "";
            wordCountLabel.Visible = false;
            associationsList = new List<string>();
            count = 1;
        }

        private string UpdateLabel()
        {
            return wordsList[count - 1];
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (isStarted == true)
            {
                DialogResult dr =
                    MessageBox.Show("Вы уверены, что хотите завершить тест?\nРезультаты теста не будут сохранены.",
                        "Внимание!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    Restore();
                }
            }
        }
    }
}