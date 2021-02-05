using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson26
{
    class MyProtectedUniqueList<T> : IEnumerable<T>
    {
        private List<T> words = new List<T>();
        private string secretWord;

        public MyProtectedUniqueList(string secretWord)
        {
            this.secretWord = secretWord;
        }

        public void Add(T word)
        {
            if (word == null)
                throw new ArgumentNullException($"Argument Exception! Word is '{word}'");

            if (words.Contains(word))
                throw new InvalidOperationException($"Word '{word}' already exists in the list ");
            else
                words.Add(word);
        }

        public void Remove(T word)
        {
            if (word == null)
                throw new ArgumentNullException($"Argument Exception! Word is '{word}'");

            if (!words.Contains(word))
                throw new ArgumentException($"The word '{word}' is not in the initialization list");
            else
                words.Remove(word);
        }

        public void RemoveAt(int index)
        {
            if (index > words.Count  && index < 0)
                throw new ArgumentOutOfRangeException($"Index {index} out of range ");
            else
                words.Remove(words[index]);
        }

        public void Clear(string word) {
            if (word != this.secretWord)
                throw new AccessViolationException($"The word {word} is not the key ");
            else
                words.Clear();
        }

        public void Sort(string word)
        {
            if (word != this.secretWord)
                throw new AccessViolationException($"The word {word} is not the key ");
            else
                words.Sort();
        }

        public override string ToString()
        {
            string result = "";

            foreach (T word in words)
            {
                result += word + "\n";
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }
    }
}
