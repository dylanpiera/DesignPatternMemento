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

        /// <summary>
        /// Important note: the args array is in the same order as the params provided when creating the Memento
        /// </summary>
        public void RestoreMemento(object[] args)
        {
            Console.WriteLine("-- Restoring Memento --"); // For demo purposes
            Text = (string)args[0];
            TextColor = (ConsoleColor)args[1];
        }
    }
    #endregion
}