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
        private string[] instructions;
        private int amount;
        private int count;
        private int chainNumber;
        private int currentIndex;

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

            else
            {
                addTesteeButton.Enabled = false;
                instructionsButton.Enabled = false;
                startButton.Enabled = false;
                workOptionGroupBox.Enabled = false;
                isStarted = true;
                addAssocTextBox.Enabled = true;
                chainOptionRadioButton.Enabled = false;
                singleOptionRadioButton.Enabled = false;
                outputWordTextBox.Text = instructions[1];
                count = 1;
                amount = int.Parse(instructions[0].Split(' ')[1]);
                currentIndex = 1;
                chainNumber = int.Parse(instructions[0].Split(' ')[0]);
                wordCountLabel.Text = 1 + " из " + amount + "  Цепочка номер: " + currentIndex;
                associations[0, 0] = instructions[1];
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
                    if (count != amount)
                    {
                        associations[currentIndex - 1, count - 1] = outputWordTextBox.Text;

                        count++;
                        if (count > amount)
                            wordCountLabel.Text = count - 1 + " из " + amount + "  Цепочка номер: " + currentIndex;
                        else
                        {
                            wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex;
                        }

                        bool option = chainOptionRadioButton.Checked;
                        if (option)
                        {
                            outputWordTextBox.Text = addAssocTextBox.Text.Trim();
                        }


                        addAssocTextBox.Text = "";
                    }
                    else
                    {
                        addAssocTextBox.Enabled = false;
                        stopButton.Enabled = true;
                        addAssocTextBox.Text = "";
                        stopButton.Text = "Завершить " + currentIndex++ + " цепочку";
                    }
                }
            }
        }


        private void stopButton_Click(object sender, EventArgs e)
        {
            if (currentIndex - 1 == chainNumber)
            {
                MessageBox.Show("Тестирование завершено. Спасибо");
                ResultWriter.writeData(testeeData, associations, instructions);
                Application.Exit();
            }

            else
            {
                stopButton.Enabled = false;
                NextWord();
            }
        }

        private void NextWord()
        {
            addAssocTextBox.Enabled = true;
            outputWordTextBox.Text = instructions[currentIndex];
            count = 1;

            wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex;
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog.FileName;
                instructions = InstructionLoader.LoadInstruction(filename, instructions);
                associations = new string[int.Parse(instructions[0].Split(' ')[0]),
                    int.Parse(instructions[0].Split(' ')[1])];
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
                instructions = InstructionLoader.LoadInstruction("Resources/instruction_C.txt", instructions);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Отсутствует файл с инструкцией, загрузите новый, нажав на соответствующую кнопку");
            }

            testeeData = new string[5];

            associations = new string[int.Parse(instructions[0].Split(' ')[0]),
                int.Parse(instructions[0].Split(' ')[1])];
            isStarted = false;
            isUserAdded = false;
            outputWordTextBox.ReadOnly = false;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InstructionSaver.SaveInst(instructions);
        }

        private void chainOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
        }

        private void singleOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            startButton.Enabled = true;
        }
    }
}