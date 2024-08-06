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
    public partial class Form7 : Form
    {
        // Dictionary for Morse code to Khmer conversion
        private Dictionary<string, char> morseToKhmer = new Dictionary<string, char>
        {
            {".-", 'ក'}, {"-...", 'ខ'}, {"-.-.", 'គ'}, {"-..", 'ឃ'}, {".", 'ង'}, {"..-.", 'ច'},
            {"--.", 'ឆ'}, {"....", 'ជ'}, {"..", 'ឈ'}, {".---", 'ញ'}, {"-.-", 'ដ'}, {".-..",'ឋ' },{"--", 'ឌ'},
            {"-.--.",'ឍ' },{"-.", 'ណ'}, {"---", 'ត'}, {".--.", 'ថ'}, {"--.-", 'ទ'}, {".-.", 'ធ'}, {"...", 'ន'},
            {"-", 'ប'}, {"..-", 'ផ'}, {"...-", 'ព'}, {".--", 'ភ'}, {"-..-", 'ម'}, {"-.--", 'យ'},
            {"--..", 'រ'}, {"._._._", 'ល'}, {"__..__", 'វ'}, {"..__..", 'ស'}, {"_._.__", 'ហ'},
            {".____.", 'ឡ'}, {"._.._", 'អ'}, {"-----", '០'}, {".----", '១'}, {"..---", '២'},
            {"...--", '៣'}, {"....-", '៤'}, {".....", '៥'}, {"-....", '៦'}, {"--...", '៧'},
            {"---..", '៨'}, {"----.", '៩'}, {" ", ' '}  // Use ' ' for space between words
        };

        public Form7()
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
            string khmerText = ConvertMorseToKhmer(morseCode);
            textBox2.Text = khmerText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private string ConvertMorseToKhmer(string morseCode)
        {
            string[] morseWords = morseCode.Split(new[] { "   " }, StringSplitOptions.None); // Split words by three spaces
            List<string> khmerWords = new List<string>();

            foreach (string morseWord in morseWords)
            {
                string[] morseChars = morseWord.Split(' '); // Split characters by one space
                StringBuilder khmerWord = new StringBuilder();

                foreach (string morseChar in morseChars)
                {
                    if (morseToKhmer.TryGetValue(morseChar, out char khmerChar))
                    {
                        khmerWord.Append(khmerChar);
                    }
                }

                khmerWords.Add(khmerWord.ToString());
            }

            return string.Join(" ", khmerWords);
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
