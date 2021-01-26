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
        private List<string> associationsList;
        private bool isStarted;
        private bool isUserAdded;
        private string[] instructions;
        private int amount;
        private int count;
        private int chainNumber;
        private int currentIndex;

        private DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            testeeData = new string[5];
            associationsList = new List<string>();
            isStarted = false;
            isUserAdded = false;
            outputWordTextBox.ReadOnly = false;
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dt = new DataTable("Associations");
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

            else if (chainOptionRadioButton.Checked == false && singleOptionRadioButton.Checked == false)
            {
                MessageBox.Show("Выберите режим работы!");
            }

            else
            {
                DataColumn column;
                DataRow row;
                startButton.Enabled = false;
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
                column = new DataColumn();
                column.DataType = System.Type.GetType("System.String");
                column.ColumnName = instructions[currentIndex];
                dt.Columns.Add(column);
                
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
                isUserAdded = true;

                testeeGroupBox.Size = new Size(329, 100);
            }
        }

        private void addAssocTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isStarted  )
            {
                e.SuppressKeyPress = true;


                if (addAssocTextBox.Text != "")
                {
                    DataRow row;
                    if (count != amount)
                    {
                        count++;
                        wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex;
                        row = dt.NewRow();
                        row[instructions[currentIndex]] = addAssocTextBox.Text.Trim();
                        bool option = chainOptionRadioButton.Checked;
                        if (option)
                        {
                            outputWordTextBox.Text = addAssocTextBox.Text.Trim();
                        }

                        dt.Rows.Add(row);
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

        private void nextWord()
        {
            DataColumn column;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = instructions[currentIndex];
            dt.Columns.Add(column);
            addAssocTextBox.Enabled = true;
            outputWordTextBox.Text = instructions[currentIndex];
            count = 1;
            amount = amount = int.Parse(instructions[0].Split(' ')[1]);
            wordCountLabel.Text = count + " из " + amount + "  Цепочка номер: " + currentIndex;
        }

        /*private void Restore()
        {
            isStarted = false;
            outputWordTextBox.Text = "";
            associationsList = new List<string>();
            chainOptionRadioButton.Enabled = true;
            singleOptionRadioButton.Enabled = true;
        }*/


        private void stopButton_Click(object sender, EventArgs e)
        {
            /*if (isStarted == true)
            {
                DialogResult dr =
                    MessageBox.Show("Вы уверены, что хотите завершить тест?",
                        "Внимание!", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    if (chainOptionRadioButton.Checked)
                    {
                        WordsLoader.WriteWords(testeeData, associationsList, "1");
                    }

                    else
                    {
                        WordsLoader.WriteWords(testeeData, associationsList, "2");
                    }

                    Restore();
                }
            }*/
            if (currentIndex - 1 == chainNumber)
            {
                MessageBox.Show("Тестирование завершено. Спасибо");
                ResultWriter.writeData(testeeData, dt);
                Application.Exit();
            }

            else
            {
                stopButton.Enabled = false;
                nextWord();
            }
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
                InstructionLoader.LoadInstruction("Resources/instruction.txt", instructions);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Отсутствует файл с инструкцией, загрузите новый, нажав на соответствующую кнопку");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveInstruction.SaveInst(instructions);
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