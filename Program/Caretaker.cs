using System;
using System.Collections.Generic;

namespace Program
{
    #region Caretaker
    public class Caretaker
    {
        public List<Memento> BackupHistory { get; set; } = new List<Memento>();

        public void Save(Editor editor)
        {
            Console.WriteLine("-- Saving ---");
            BackupHistory.Add(editor.CreateMemento());
        }

        public void Undo()
        {
            BackupHistory[BackupHistory.Count - 1].RestoreMemento();
        }
    }
    #endregion
}