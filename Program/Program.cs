using System;

namespace Program
{
    public class Program
    {
        static void Main(
            string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            #region Main
            switch (region)
            {
                case "Example":
                    Example();
                    break;
                case "example":
                    Example();
                    break;;
            }
        }
        #endregion

        public static void Example()
        {
            #region Example
            Caretaker historyManager = new Caretaker();
            Editor paragraph = new Editor();

            // Edit paragraph
            paragraph.Text = "Some Piece of Text";
            paragraph.TextColor = ConsoleColor.Red;
            paragraph.Display();
            // Save
            historyManager.Save(paragraph);
            // Make Change
            paragraph.Text = "Different Text!";
            paragraph.TextColor = ConsoleColor.Blue;
            paragraph.Display();
            // Undo last change
            historyManager.Undo();

            paragraph.Display();
            Console.WriteLine("Done!");
            #endregion
        }
    }
}
