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
            Console.WriteLine("-- Saving ---"); // For demo purposes
            BackupHistory.Add(editor.CreateMemento());
        }

        public void Undo()
        {
            if (BackupHistory.Count > 0)
            {
                BackupHistory[BackupHistory.Count - 1].RestoreMemento();
                BackupHistory.RemoveAt(BackupHistory.Count - 1);
            }
        }
    }
    #endregion
}