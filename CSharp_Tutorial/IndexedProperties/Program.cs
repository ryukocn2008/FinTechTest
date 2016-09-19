using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexedProperties
{
    public class Document
    {
        public class WordCollection
        {
            readonly Document document;

            internal WordCollection(Document d)
            {
                document = d;
            }

            private bool GetWord(char[] text, int begin, int wordCount, out int start, out int length)
            {
                int end = text.Length;
                int count = 0;
                int inWord = -1;
                start = length = 0;

                for (int i = begin; i<= end; ++i)
                {
                    bool isLetter = i < end && Char.IsLetterOrDigit(text[i]);

                    if (inWord >= 0)
                    {
                        if (!isLetter)
                        {
                            start = inWord;
                            length = i - inWord;
                            return true;
                        }
                        inWord = -1;
                    }
                    else
                    {
                        if (isLetter) inWord = -1;
                    }
                }
                return false;
            }

            public string this[int index]
            {
                get
                {
                    int start, length;
                    if (GetWord(document.TextArray, 0, index, out start, out length))
                        return new string(document.TextArray, start, length);
                    else
                        throw new IndexOutOfRangeException();
                }
                set
                {
                    int start, length;
                    if (GetWord(document.TextArray, 0, index, out start, out length))
                    {
                        if (length == value.Length)
                        {
                            Array.Copy(value.ToCharArray(), 0, document.TextArray, start, length);
                        }
                        else
                        {
                            char[] newText = new char[document.TextArray.Length + value.Length - length];
                            Array.Copy(document.TextArray, 0, newText, 0, start);
                            Array.Copy(value.ToCharArray(), 0, newText, start, value.Length);
                            Array.Copy(document.TextArray, start + length, newText, start + value.Length, document.TextArray.Length - start - length);
                            document.TextArray = newText;

                        }
                    }
                    else
                        throw new IndexOutOfRangeException();
                }
            }

            public int Count
            {
                get
                {
                    int count = 0, start = 0, length = 0;
                    while (GetWord(document.TextArray, start + length, 0, out start, out length))
                        ++count;
                    return count;
                }
            }
        }

        public class CharacterCollection
        {
            readonly Document document;

            internal CharacterCollection(Document d)
            {
                document = d;
            }

            public char this[int index]
            {
                get { return document.TextArray[index]; }
                set { document.TextArray[index] = value; }
            }

            public int Count
            {
                get { return document.TextArray.Length; }
            }
        }


        public readonly WordCollection Words;
        public readonly CharacterCollection Characters;

        private char[] TextArray;

        public Document(string initialText)
        {
            TextArray = initialText.ToCharArray();
            Words = new WordCollection(this);
            Characters = new CharacterCollection(this);
        }

        public string Text
        {
            get { return new string(TextArray); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("peter piper picked a peck of pickled peppers, How many pickled peppers did peter piper pick?");

            for (int i = 0; i < d.Words.Count; ++i)
            {
                if (d.Words[i] == "peter")
                    d.Words[i] = "penelope";
            }

            for (int i = 0; i < d.Characters.Count; ++i)
            {
                if (d.Characters[i] == 'p')
                    d.Characters[i] = 'P';
            }

            Console.WriteLine(d.Text);
        }
    }
}
