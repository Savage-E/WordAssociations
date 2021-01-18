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
        private ArrayList wordsList;
        private List<string> associationsList;
        private int count;
        private int amount;

        public MainForm()
        {
            InitializeComponent();
            testeeData = new string[4];
            wordsList = LoadWords();
            associationsList = new List<string>();
            count = 0;
            amount = wordsList.Count;
        }

        private static ArrayList LoadWords()
        {
            ArrayList tempWordsList = new ArrayList();

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
            else if (wordsList.Count == 0)
            {
                MessageBox.Show("Невозможно продолжить, т.к. отсутствуют слова в списке слов");
            }
            else
            {
                wordCountLabel.Visible = true;
                wordCountLabel.Text = "Слово : " + count++ + " из " + amount;
                outputWordTextBox.Text = UpdateLabel().ToString();
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
                testeeData[0] = firstNameTextBox.Text;
                testeeData[1] = lastNameTextBox.Text;
                testeeData[2] = patronymicTextBox.Text;
                testeeData[3] = ageNumericUpDown.Text;
                testeeLabel.Visible = true;
                testeeLabel.Text += testeeData[0] + " " + testeeData[1] + " " + testeeData[2] + " " + testeeData[3];
            }
        }

        private void addAssocTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (addAssocTextBox.Text != "")
                {
                    associationsList.Add(addAssocTextBox.Text);
                }
                wordCountLabel.Text = "Слово : " + count++ + " из " + amount;
                outputWordTextBox.Text=UpdateLabel().ToString();
            }
        }

        private IEnumerator UpdateLabel()
        {
            foreach (string w in wordsList)
            {
                yield return w;
            }
        }
    }
}