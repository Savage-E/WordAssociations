using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace WordAssociations
{
    public partial class MainForm : Form
    {
        private String[] testeeData;
        private ArrayList wordsList;

        public MainForm()
        {
            InitializeComponent();
            testeeData = new String[4];
            wordsList = LoadWords();
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
            else
            {
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
    }
}