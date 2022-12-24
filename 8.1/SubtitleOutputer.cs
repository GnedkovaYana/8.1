namespace Ex1
{
    public class SubtitleOutputer
    {
        private static int currentTime;
        private Subtitle[] subtitles;

        public SubtitleOutputer(Subtitle[] subtitles)
        {
            this.subtitles = subtitles;
        }

        private static void ShowSubtitles(Subtitle sub)
        {
            SetPosition(sub);
            Console.ForegroundColor = sub.Color;
            Console.Write(sub.Words);
        }

        private static void DeleteSubtitles(Subtitle sub)
        {
            SetPosition(sub);
            for (int i = 0; i < sub.Words.Length; i++)
                Console.Write(" ");
        }

        public void Timer()
        {
            TimerCallback time = new TimerCallback(CheckTime);
            Timer timer = new Timer(time, subtitles, 0, 1000);
        }

        private static void CheckTime(object obj)
        {
            Subtitle[] text = (Subtitle[])obj;
            foreach (Subtitle sub in text)
            {
                if (sub.TimeOfApp == currentTime)
                    ShowSubtitles(sub);
                else if (sub.TimeOfDisapp == currentTime)
                    DeleteSubtitles(sub);
            }
            currentTime++;
        }

        private static void SetPosition(Subtitle sub)
        {
            switch (sub.Position)
            {
                case "Top":
                    Console.SetCursorPosition((Console.WindowWidth - sub.Words.Length) / 2, 1);
                    break;
                case "Right":
                    Console.SetCursorPosition(Console.WindowWidth - sub.Words.Length, (Console.WindowHeight - 1) / 2);
                    break;
                case "Bottom":
                    Console.SetCursorPosition((Console.WindowWidth - sub.Words.Length) / 2, Console.WindowHeight);
                    break;
                case "Left":
                    Console.SetCursorPosition(0, (Console.WindowHeight - 1) / 2);
                    break;
                default:
                    break;
            }
        }
    }
}