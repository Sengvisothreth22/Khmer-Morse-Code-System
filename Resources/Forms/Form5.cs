using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khmer_Morse_Code_System.Resources.Forms
{
    public partial class Form5 : Form
    {
        // Dictionary for Morse code to English conversion
        private Dictionary<string, char> morseToEnglish = new Dictionary<string, char>
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'}, {"..-.", 'F'}, {"--.", 'G'},
            {"....", 'H'}, {"..", 'I'}, {".---", 'J'}, {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'},
            {"---", 'O'}, {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'}, {"..-", 'U'},
            {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'}, {"--..", 'Z'}, {"-----", '0'},
            {".----", '1'}, {"..---", '2'}, {"...--", '3'}, {"....-", '4'}, {".....", '5'}, {"-....", '6'},
            {"--...", '7'}, {"---..", '8'}, {"----.", '9'}, {"​​ ", ' '}   // Use ' ' for space between words
        };

        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change events if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string morseCode = textBox1.Text.Trim();
            string englishText = ConvertMorseToEnglish(morseCode);
            textBox2.Text = englishText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private string ConvertMorseToEnglish(string morseCode)
        {
            string[] morseWords = morseCode.Split(new[] { "   " }, StringSplitOptions.None); // Split words by three spaces
            List<string> englishWords = new List<string>();

            foreach (string morseWord in morseWords)
            {
                string[] morseChars = morseWord.Split(' '); // Split characters by one space
                StringBuilder englishWord = new StringBuilder();

                foreach (string morseChar in morseChars)
                {
                    if (morseToEnglish.TryGetValue(morseChar, out char englishChar))
                    {
                        englishWord.Append(englishChar);
                    }
                }

                englishWords.Add(englishWord.ToString());
            }

            return string.Join(" ", englishWords);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change events if needed
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
