namespace ProgressBar
{
    public class ProgressBar
    {
        /*
        * An implementation of a Progress bar inside C#
        */
        public ProgressBar(decimal totalFiles, decimal currentFile = 0, decimal oldProgress = 0, char style = "█", int sticks = 20)
        {
            TotalFiles = totalFiles;
            CurrentFile = currentFile;
            OldProgress = oldProgress;
        }
        public decimal CurrentFile { get; private set; }
        public decimal TotalFiles { get; private set; }
        public decimal OldProgress { get; set; }
        public void Tick()
        {
            CurrentFile++;
            decimal percentageDone = Decimal.Divide(CurrentFile, TotalFiles);
            var progress = Math.Ceiling(percentageDone * Sticks);
            var left = Sticks - progress;
            if (progress % 1 == 0 && progress != OldProgress)
            {
                OldProgress = progress;
            }
            if (CurrentFile != 1)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            Console.SetCursorPosition(0, Console.CursorTop);

            Console.Write("[");
            for (int i = 0; i < progress; i++) { Console.Write($"{Style}"); }
            for(int i = 0; i < left; i++) { Console.Write("-"); }

            Console.Write("]");

            Console.Write($"File {CurrentFile} / {TotalFiles} ");
            Console.WriteLine();
        }
    }
}