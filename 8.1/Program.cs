namespace Ex1
{
    class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("file.txt");
            Subtitle[] subtitles = new Subtitle[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                subtitles[i] = SubtitlesGetter.CreateSubtitle(text[i]);
            }
            SubtitleOutputer show = new SubtitleOutputer(subtitles);
            show.Timer();

            Console.ReadKey();
        }
    }
}