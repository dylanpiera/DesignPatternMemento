using System;
using System.Collections.Generic;

namespace Program
{
    #region Memento
    public class Memento
    {
        private Editor editor;
        private List<object> objects = new List<object>();

        public Memento(Editor editor, params object[] args)
        {
            this.editor = editor;
            foreach (var obj in args)
            {
                objects.Add(obj);
            }
        }

        public void RestoreMemento()
        {
            editor.RestoreMemento(objects.ToArray());
        }
    }
    #endregion
}