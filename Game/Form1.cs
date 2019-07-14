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
        public Form1()
        {
            InitializeComponent();
            hiragana = new HiraganaCharacters();
            buttons = new List<Button>();
            initalizeButtons();
            setTextForButtons();

        }

        private void initalizeButtons()
        {
            buttons.Add(this.button1);
            buttons.Add(this.button2);
            buttons.Add(this.button3);
            buttons.Add(this.button4);
            buttons.Add(this.button5);
            buttons.Add(this.button6);
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
