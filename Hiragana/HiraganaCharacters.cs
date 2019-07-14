using System;
using System.Collections.Generic;

namespace Hiragana
{
    class HiraganaCharacters
    {
        Dictionary<string, string> hiraganaAlphabet;
        public HiraganaCharacters()
        {
            hiraganaAlphabet = new Dictionary<string, string>() {
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

    }
}
