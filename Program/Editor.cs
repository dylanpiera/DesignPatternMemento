using System;

namespace Program
{
    #region Editor
    public class Editor
    {
        
        public string Text { get; set; }
        public ConsoleColor TextColor { get; set; }

        public void Display()
        {
            Console.ForegroundColor = TextColor;
            Console.WriteLine($"{Text} [color: {TextColor}]");
            Console.ResetColor();
        }

        public Memento CreateMemento()
        {
            return new Memento(this, Text, TextColor);
        }
    }
    #endregion
}