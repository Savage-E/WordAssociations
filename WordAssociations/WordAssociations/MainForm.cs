using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WordAssociations
{
    public partial class MainForm : Form
    {
        private string[] testeeData;
        private string[,] associations;
        private bool isStarted;
        private bool isUserAdded;
        private string[] setttings;
        private int amount;
        private int count;
        private int chainNumber;
        private int currentIndex;
        private int ind;
        private int index;

        private string[] instruction;

        public MainForm()
        {
            InitializeComponent();
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            if (testeeLabel.Text == "")
            {
                MessageBox.Show("Введите данные испытуемого!");
            }

            else if (chainOptionRadioButton.Checked == false && singleOptionRadioButton.Checked == false)
            {
                MessageBox.Show("Выберите режим работы!");
            }
            else if (setttings == null)
            {
                MessageBox.Show("Добавьте настройки!");
            }

            else
            {
                addTesteeButton.Enabled = false;
                SettingsButton.Enabled = false;
                startButton.Enabled = false;
                workOptionGroupBox.Enabled = false;
                addInstructionButton.Enabled = false;
                isStarted = true;
                addAssocTextBox.Enabled = true;
                chainOptionRadioButton.Enabled = false;
                singleOptionRadioButton.Enabled = false;
                if (chainOptionRadioButton.Checked)
                {
                    outputWordTextBox.Text = setttings[1];

                    amount = int.Parse(setttings[0].Split(' ')[1]);

                    chainNumber = int.Parse(setttings[0].Split(' ')[0]);

                    associations[0, 0] = setttings[1];
                }
                else
                {
                    chainNumber = int.Parse(setttings[ind].Split(' ')[0]);
                    outputWordTextBox.Text = setttings[ind + 1];
                    amount = int.Parse(setttings[ind].Split(' ')[1]);
                    associations = new string[
                        int.Parse(setttings[ind].Split(' ')[1]), index];

                    associations[0, 0] = setttings[ind + 1];
                }


                count = 1;
                currentIndex = 1;
                wordCountLabel.Text = 1 + " из " + amount + "  Цепочка номер: " + currentIndex + " из " + chainNumber;
            }
        }


        private void addTesteeButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" || lastNameLabel.Text == "" || ageNumericUpDown.Value == 0 ||
                genderComboBox.Text == ""
                || patronymicTextBox.Text == "")
            {
                MessageBox.Show("Введите Имя, Фамилию, Отчество, пол и возраст!");
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
                isUserAdded = true;
                workOptionGroupBox.Enabled = true;
                testeeGroupBox.Size = new Size(329, 100);
            }
        }

        private void addAssocTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isStarted)
            {
                e.SuppressKeyPress = true;


                if (addAssocTextBox.Text != "")
                {
                    if (count <= amount)
                    {
                        associations[count - 1, currentIndex - 1] = addAssocTextBox.Text;

                        count++;

                        if (count > amount)
                        {
                            wordCountLabel.Text = count - 1 + " из " + amount + "  Цепочка номер: " + currentIndex +
                                                  " из " + chainNumber;
                            addAssocTextBox.Enabled = false;
                            stopButton.Enabled = true;
                            addAssocTextBox.Text = "";
                            stopButton.Text = "Завершить " + currentIndex++ + " цепочку";
                        }
                        else
                        {
                            wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex +
                                                  " из " + chainNumber;
                        }

                        bool option = chainOptionRadioButton.Checked;
                        if (option)
                        {
                            outputWordTextBox.Text = addAssocTextBox.Text.Trim();
                        }


                        addAssocTextBox.Text = "";
                    }
                }
            }
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            if (currentIndex - 1 == chainNumber)
            {
                string[] tempArray;
                MessageBox.Show("Тестирование завершено. Спасибо");

                if (singleOptionRadioButton.Checked)
                {
                    //Выделяем базовые слова из настроек .
                    tempArray = new string[chainNumber + 1];
                    Array.Copy(setttings, ind, tempArray, 0, chainNumber + 1);
                }

                else
                {
                    //Выделяем базовые слова из настроек.
                    tempArray = new string[chainNumber + 1];
                    Array.Copy(setttings, 0, tempArray, 0, chainNumber + 1);
                }

                ResultWriter.writeData(testeeData, associations, tempArray);
                Application.Exit();
            }

            else
            {
                stopButton.Enabled = false;
                NextWord();
            }
        }

        //Переход к следующей цепочке.
        private void NextWord()
        {
            addAssocTextBox.Enabled = true;
            if (chainOptionRadioButton.Checked)
            {
                outputWordTextBox.Text = setttings[currentIndex];
            }
            else
            {
                outputWordTextBox.Text = setttings[currentIndex + ind];
            }

            count = 1;

            wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex + " из " + chainNumber;
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog.FileName;
                setttings = SettingsLoader.LoadInstruction(filename, setttings);
                if (chainOptionRadioButton.Checked)
                {
                    associations = new string[
                        int.Parse(setttings[0].Split(' ')[1]), int.Parse(setttings[0].Split(' ')[0])];
                }

                if (singleOptionRadioButton.Checked)
                {
                    int index = int.Parse(setttings[ind].Split(' ')[0]);
                    associations = new string[
                        int.Parse(setttings[index].Split(' ')[1]), index];
                }
            }
            catch (Exception exception)
            {
                // ignored
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                setttings = SettingsLoader.LoadInstruction("Resources/settings.txt", setttings);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Отсутствует файл с инструкцией, загрузите новый, нажав на соответствующую кнопку");
            }

            try
            {
                instruction = InstructionLoader.LoadInst("Resources/instruction.txt");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Отсутствует загруженная инструкция, загрузите новый файл");
            }

            //Деактивируем элементы.
            testeeData = new string[5];
            isStarted = false;
            isUserAdded = false;
            outputWordTextBox.ReadOnly = false;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (setttings.Length != 0)
            {
                SettingsSaver.SaveInst(setttings);
            }

            if (instruction.Length != 0 || instruction != null)
            {
                InstructionSaver.saveInst(instruction);
            }
        }

        private void chainOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            if (setttings == null)
            {
                MessageBox.Show("Загрузите файл с настройками!");
            }
            else
            {
                associations = new string[
                    int.Parse(setttings[0].Split(' ')[1]), int.Parse(setttings[0].Split(' ')[0])];
                instuctionRichTextBox.Text = "";
                if (instruction.Length != 0 || setttings != null)
                {
                    foreach (var data in instruction)
                    {
                        instuctionRichTextBox.Text += data;
                    }
                }
            }
        }

        private void singleOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            if (setttings == null)
            {
                MessageBox.Show("Загрузите файл с настройками!");
            }
            else
            {
                instuctionRichTextBox.Text = "";
                if (instruction.Length != 0 || setttings != null)
                {
                    foreach (var data in instruction)
                    {
                        instuctionRichTextBox.Text += data;
                    }
                }

                //Получаем значения для режима Звезда.
                ind = int.Parse(setttings[0].Split(' ')[0]) + 1;
                index = int.Parse(setttings[ind].Split(' ')[0]);
                associations = new string[
                    int.Parse(setttings[ind].Split(' ')[1]), index];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog.FileName;
                //Загружаем его в переменную.
                instruction = InstructionLoader.LoadInst(filename);
                //Заполняем текстбокс.
                if (instruction.Length != 0)
                {
                    instuctionRichTextBox.Text = "";
                    foreach (var data in instruction)
                    {
                        instuctionRichTextBox.Text += data;
                    }
                }
            }
            catch (Exception exception)
            {
                // ignored
            }
        }
    }
}