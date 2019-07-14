using System;
using System.Collections.Generic;
using System.Linq;

public class HiraganaCharacters
{
    Dictionary<string, string> HiraganaAlphabet { get; set; }
    public HiraganaCharacters()
    {
        HiraganaAlphabet = new Dictionary<string, string>() {
                { "あ", "a"  },
                { "い", "i"  },
                { "う", "u"  },
                { "え", "e"  },
                { "お", "o"  },//vowels
                { "か", "ka" },
                { "き", "ki" },
                { "く", "ku" },
                { "け", "ke" },
                { "こ", "ko" },//k
                { "さ", "sa" },
                { "し", "shi"},
                { "す", "su" },
                { "せ", "se" },
                { "そ", "so" },//s
                { "た", "ta" },
                { "ち", "chi"},
                { "っ", "tsu"},
                { "て", "te" },
                { "と", "to" },//t
                { "な", "na" },
                { "に", "ni" },
                { "ぬ", "nu" },
                { "ね", "ne" },
                { "の", "no" },//n
                { "は", "ha" },
                { "ひ", "hi" },
                { "ふ", "fu" },
                { "へ", "he" },
                { "ほ", "ho" },//h
                { "ま", "ma" },
                { "み", "mi" },
                { "む", "mu" },
                { "め", "me" },
                { "も", "mo" },//m
                { "や", "ya" },
                { "ゆ", "yu" },
                { "よ", "yo" },//y
                { "ら", "ra" },
                { "り", "ri" },
                { "る", "ru" },
                { "れ", "re" },
                { "ろ", "ro" },//r
                { "わ", "wa" },
                { "を", "wo" },//w
                { "ん", "n"  }
            };
    }

    public Dictionary<string, string> getRandomChars(int n)
    {
        if (n > HiraganaAlphabet.Count)
        {
            return null;
        }

        //create a working copy of Hiragana
        Dictionary<string, string> workingCopy = new Dictionary<string, string>(HiraganaAlphabet);
        //Dictionary that is going to be returned
        Dictionary<string, string> randomChars = new Dictionary<string, string>();
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            var chosenEntry = workingCopy.ElementAt(random.Next(workingCopy.Count - 1));
            randomChars.Add(chosenEntry.Key, chosenEntry.Value);
            workingCopy.Remove(chosenEntry.Key);
        }

        return randomChars;
    }

    public string getKeyByValue(string value)
    {
        return HiraganaAlphabet.FirstOrDefault(x => x.Value == value).Key;
    }

    public string getValueByKey(string key)
    {
        return HiraganaAlphabet[key];
    }

    public bool compareKeyAndValue(string key, string value)
    {
        return HiraganaAlphabet[key] == value;
    }
}
