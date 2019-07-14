using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public partial class Form1 : Form
    {
        HiraganaCharacters hiragana;
        List<Button> buttons;
        string mostRecentClick;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hiragana puzzle";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            hiragana = new HiraganaCharacters();
            buttons = new List<Button>();
            initalizeButtons();
            setTextForButtons();
            initalizeButtons();

        }

        private void initalizeButtons()
        {
            buttons.Add(this.button1);
            buttons.Add(this.button2);
            buttons.Add(this.button3);
            buttons.Add(this.button4);
            buttons.Add(this.button5);
            buttons.Add(this.button6);
            foreach(Button b in buttons)
            {
                b.Font = new System.Drawing.Font("Microsoft Sans Serif", 130);
            }
        }

        private void setTextForButtons()
        {
            Random rng = new Random();
            int next;
            //3*2 = 6
            Dictionary<string, string> keyValuePairs = hiragana.getRandomChars(3);
            //all of this only works because the amount of buttons has to be even
            do
            {
                var keyValuePair = keyValuePairs.First();
                next = rng.Next(buttons.Count);
                buttons[next].Text = keyValuePair.Key;
                buttons.RemoveAt(next);
                next = rng.Next(buttons.Count);
                buttons[next].Text = keyValuePair.Value;
                buttons.RemoveAt(next);
                keyValuePairs.Remove(keyValuePair.Key);
            } while (buttons.Count > 0 && keyValuePairs.Count > 0);
        }

        private void findMatchingButtons(int pos)
        {
            bool isMatch = false;

            if (mostRecentClick == null)
            {
                mostRecentClick = buttons[pos].Text;
            }

            else
            {
                //I can't tell whether my string is a key or value, so I'll have to check both combinations
                if (hiragana.compareKeyAndValue(mostRecentClick, buttons[pos].Text) || hiragana.compareKeyAndValue(buttons[pos].Text, mostRecentClick))
                {
                    isMatch = true;
                }
            }

            if (isMatch)
            {
                buttons[pos].BackColor = System.Drawing.Color.FromArgb(155, 155, 155);
                foreach (var button in buttons)
                {
                    if (button.Text.Equals(mostRecentClick))
                    {
                        button.BackColor = System.Drawing.Color.FromArgb(155, 155, 155);
                    }
                }
            }

            mostRecentClick = buttons[pos].Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            findMatchingButtons(0);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            findMatchingButtons(1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            findMatchingButtons(2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            findMatchingButtons(3);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            findMatchingButtons(4);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            findMatchingButtons(5);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            foreach(var button in buttons)
            {
                button.BackColor = System.Drawing.SystemColors.ButtonFace;
                button.UseVisualStyleBackColor = true;
            }
            setTextForButtons();
            initalizeButtons();

            
        }
    }
}
