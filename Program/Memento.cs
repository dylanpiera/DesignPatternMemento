using System;

namespace Program
{
    #region Memento
    public class Memento
    {
        private Editor editor;
        private string text;
        private ConsoleColor textColor;

        public Memento(Editor editor, string text, ConsoleColor textColor)
        {
            this.editor = editor;
            this.text = text;
            this.textColor = textColor;
        }

        public void RestoreMemento()
        {
            Console.WriteLine("-- Undoing --");
            editor.Text = text;
            editor.TextColor = textColor;
        }
    }
    #endregion
}