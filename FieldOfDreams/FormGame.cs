using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FieldOfDreams
{
    public partial class FormGame : Form
    {
        string word = "стул";
        string template = "";
        string badLetters = "";

        string[] wordsAnimals = new string[] {"слон", "мышь", "гиппопотам"};
        string[] wordsFruits = new string[] { "яблоко", "банан", "груша" };

        Random rnd = new Random();

        string RandomWord(string[] words)
        {
            int countWords = words.Length;
            int indexWord = rnd.Next(0, countWords);
            string word = words[indexWord];
            return word;
        }

        string MakeTemplate(string word)
        {
            int count = word.Length;
            string temp = "";
            for (int i = 0; i < count; i++)
            {
                temp = temp + "*";
            }
            return temp;
        }

        bool ExistLetter(string word, char letter)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    return true;
                }
            }
            return false;
        }

        string ChangeTemplate(string template, char letter, string word)
        {
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    temp = temp + letter;
                }
                else
                {
                    temp += template[i];
                }
            }
            return temp;
        }

        public FormGame()
        {
            InitializeComponent();
            word = RandomWord(wordsFruits);
            template = MakeTemplate(word);
            labelTemplate.Text = template;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            char letter = textBoxLetter.Text[0];
            bool answer = ExistLetter(word, letter);
            if (answer)
            {
                template = ChangeTemplate(template, letter, word);
                labelTemplate.Text = template;
            }
            else
            {
                MessageBox.Show("Не угадал букву");
                badLetters += letter;
                labelBadLetters.Text = badLetters;
            }

        }
    }
}
