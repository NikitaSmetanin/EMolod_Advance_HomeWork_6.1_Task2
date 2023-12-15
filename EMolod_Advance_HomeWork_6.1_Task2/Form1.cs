using System;
using System.Windows.Forms;

namespace EMolod_Advance_HomeWork_6._1_Task2
{  
    public partial class Form1 : Form
    {       
        static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "1234567890";
        string specialSymbols = "!@$%^&*+#()_-";
        string passwordCharSet = alphabet;
        public Form1()
        {
            InitializeComponent();
        }
        // Функція очистки 
        private void button2_Click(object sender, EventArgs e)
        {
            passwordCharSet = alphabet;
            textBox1.Text = "";
            numericUpDown1.Value = 6;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }        
        // Функція генерації пароля
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                foreach (int indexChecked in checkedListBox1.CheckedIndices)
                {
                    switch (indexChecked)
                    {
                        case 0:
                            passwordCharSet += upperCase; break;
                        case 1:
                            passwordCharSet += numbers; break;
                        case 2:
                            passwordCharSet += specialSymbols; break;
                    }
                }
            }
            Random random = new Random(DateTimeOffset.Now.Millisecond);
            string result = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                result += passwordCharSet[random.Next(0, passwordCharSet.Length)];
            }
            textBox1.Text = result;
        }
    }
}
