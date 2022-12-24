namespace Ex1
{
    public class Subtitle
    {
        public ConsoleColor Color { get; }
        public string Position { get; }
        public int TimeOfApp { get; }
        public int TimeOfDisapp { get; }
        public string Words { get; }

        public Subtitle(ConsoleColor color, string position, int timeOfApp, int timeOfDisapp, string words)
        {
            Color = color;
            Position = position;
            TimeOfApp = timeOfApp;
            TimeOfDisapp = timeOfDisapp;
            Words = words;
        }
    }
}