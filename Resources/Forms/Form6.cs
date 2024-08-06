using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khmer_Morse_Code_System.Resources.Forms
{
    public partial class Form6 : Form
    {
        private Dictionary<char, string> morseCodeDict;
        private SoundPlayer dotPlayer;
        private SoundPlayer dashPlayer;
        private CancellationTokenSource cancellationTokenSource;

        public Form6()
        {
            InitializeComponent();
            InitializeMorseCodeDictionary();
            InitializeSoundPlayers();
            cancellationTokenSource = new CancellationTokenSource();
        }

        private void InitializeMorseCodeDictionary()
        {
            morseCodeDict = new Dictionary<char, string>
    {
        { 'ក', ".-" }, { 'ខ', "-..." }, { 'គ', "-.-." }, { 'ឃ', "-.." },
        { 'ង', "." }, { 'ច', "..-." }, { 'ឆ', "--." },
        { 'ជ', "...." }, { 'ឈ', ".." }, { 'ញ', ".---" }, { 'ដ', "-.-" },{'ឋ',".-.."},
        { 'ឌ', "--" },{ 'ឍ',"-.--."}, { 'ណ', "-." }, { 'ត', "---" }, { 'ថ', ".--." },
        { 'ទ', "--.-" }, { 'ធ', ".-." }, { 'ន', "..." }, { 'ប', "-" },
        { 'ផ', "..-" }, { 'ព', "...-" }, { 'ភ', ".--" }, { 'ម', "-..-" },
        { 'យ', "-.--" }, { 'រ', "--.." },  { 'ល', "._._._" }, { 'វ', "__..__" },
        { 'ស', "..__.." }, { 'ហ', "_._.__" }, { 'ឡ', ".____." }, { 'អ', "._.._" },
        { '០', "-----" }, { '១', ".----" }, { '២', "..---" }, { '៣', "...--" },
        { '៤', "....-" }, { '៥', "....." }, { '៦', "-...." }, { '៧', "--..." },
        { '៨', "---.." }, { '៩', "----." }, { ' ', " " } // Space character represented by " "
    };
        }


        private void InitializeSoundPlayers()
        {
            dotPlayer = new SoundPlayer("dot_morse.wav"); // Ensure correct file path
            dashPlayer = new SoundPlayer("dash_morse.wav"); // Ensure correct file path
        }

        private void button1_Click(object sender, EventArgs e) // Translate Button
        {
            cancellationTokenSource = new CancellationTokenSource(); // Reset the cancellation token source
            string inputText = textBox1.Text.ToUpper(); // Convert input to uppercase for consistency
            string morseCode = TranslateToMorseCode(inputText);
            textBox2.Text = morseCode;
            UpdateLetterCountLabel(inputText);
            PlayMorseCode(morseCode, cancellationTokenSource.Token);
        }

        private string TranslateToMorseCode(string input)
        {
            StringBuilder morseCode = new StringBuilder();
            foreach (char c in input)
            {
                if (morseCodeDict.ContainsKey(c))
                {
                    morseCode.Append(morseCodeDict[c] + " ");
                }
                else
                {
                    morseCode.Append("? "); // Use "?" for unknown characters
                }
            }
            return morseCode.ToString();
        }

        private void UpdateLetterCountLabel(string input)
        {
            int letterCount = 0;
            foreach (char c in input)
            {
                if (morseCodeDict.ContainsKey(c) && c != ' ')
                {
                    letterCount++;
                }
            }
            label2.Text = letterCount.ToString("00"); // Ensuring it always displays two digits
        }

        private async void PlayMorseCode(string morseCode, CancellationToken cancellationToken)
        {
            int wpm = (int)numericUpDownWPM.Value;
            int dotDuration = 1200 / wpm; // Duration of a dot in milliseconds
            int dashDuration = dotDuration * 3;
            int interElementGap = dotDuration;
            int interLetterGap = dotDuration * 3;
            int interWordGap = dotDuration * 7;

            try
            {
                foreach (char c in morseCode)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    if (c == '.')
                    {
                        dotPlayer.PlaySync();
                        await Task.Delay(dotDuration, cancellationToken);
                    }
                    else if (c == '-')
                    {
                        dashPlayer.PlaySync();
                        await Task.Delay(dashDuration, cancellationToken);
                    }
                    else if (c == ' ')
                    {
                        await Task.Delay(interLetterGap, cancellationToken);
                    }
                    else if (c == '/')
                    {
                        await Task.Delay(interWordGap, cancellationToken);
                    }

                    await Task.Delay(interElementGap, cancellationToken); // Inter-element gap
                }
            }
            catch (TaskCanceledException)
            {
                // Handle the task cancellation gracefully
                // You might want to stop the sound player or reset the state here
            }
        }

        private void button2_Click(object sender, EventArgs e) // Clear Button
        {
            cancellationTokenSource.Cancel(); // Cancel the ongoing task
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = "00"; // Resetting the letter count to 00
        }

        // Event handlers
        private void label4_Click(object sender, EventArgs e) { } // WPM Label
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { } // Numeric Dropdown List
        private void textBox1_TextChanged(object sender, EventArgs e) { } // Input English Text Box
        private void textBox2_TextChanged(object sender, EventArgs e) { } // Morse Code Text Box
        private void Form4_Load(object sender, EventArgs e) { } // Form Load Event
        private void label2_Click(object sender, EventArgs e) { } // Letter Count Label Click Event
        private void label3_Click(object sender, EventArgs e) { } // Another Label Click Event
        private void label5_Click(object sender, EventArgs e) { } // Another Label Click Event
    }
}
