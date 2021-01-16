using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    public class DigitEventArgs
    {
        public DigitEventArgs(string text)
        {
            this.text = text;
        }
        string text;
    }
    public class LetterEventArgs
    {
        public LetterEventArgs(string text)
        {
            this.text = text;
        }
        string text;
    }
    class Zad2
    {
        public event EventHandler<DigitEventArgs> DigitEvent; // w tym zawart jest: delegate void Zad2EventHandler(object sender, Zad2EventArgs e);
        public event EventHandler<LetterEventArgs> LetterEvent;
        public void OnDigit(DigitEventArgs e)
        {
            DigitEvent?.Invoke(this, e);
        }
        public void OnLetter(LetterEventArgs e)
        {
            LetterEvent?.Invoke(this, e);
        }

        void PrintDigit(object sender, DigitEventArgs e) {Console.WriteLine("Naciśnięto cyfrę!");}
        void PrintLetter(object sender, LetterEventArgs e) { Console.WriteLine("Naciśnięto literę!"); }

        public void Perform()
        {
            string line;
            bool digit = true, letter = true;
                while ((line = Console.ReadLine()) != null && 
                        ((digit= Char.IsDigit(line[0])) || 
                        (letter = Char.IsLetter(line[0]))))
                {
                    if (digit)
                    {
                        DigitEvent = PrintDigit;
                        OnDigit(new DigitEventArgs("Working digit!"));
                    }
                    else if (letter) {
                        LetterEvent = PrintLetter;
                        OnLetter(new LetterEventArgs("Working letter!"));
                    }
                }
        }

    }
}
