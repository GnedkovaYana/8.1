namespace Ex1
{
    public static class SubtitlesGetter
    {
        public static Subtitle CreateSubtitle(string text)
        {
            int appear = GetTimeOfApp(text);
            int disappear = GetTimeOfDisapp(text);
            ConsoleColor color = GetColor(text);
            string position = GetPosition(text);
            string words = GetWords(text);
            return new Subtitle(color, position, appear, disappear, words);
        }

        private static int GetTimeOfApp(string text)
        {
            int timeOfApp = int.Parse(text.Split(" - ")[0].Split(":")[1]);
            return timeOfApp;
        }

        private static int GetTimeOfDisapp(string text)
        {
            int timeOfDisApp = int.Parse(text.Split(" - ")[1].Split(' ')[0].Split(":")[1]);
            return timeOfDisApp;
        }

        private static ConsoleColor GetColor(string text)
        {
            ConsoleColor color;
            string strColor = "";
            if (text.Contains("]"))
                strColor = text.Split("]")[0].Split(", ")[1];
            switch (strColor)
            {
                case "Red":
                    color = ConsoleColor.Red;
                    break;

                case "Green":
                    color = ConsoleColor.Green;
                    break;

                case "Blue":
                    color = ConsoleColor.Blue;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;
            }
            return color;
        }

        private static string GetPosition(string text)
        {
            string position = "";
            if (text.Contains("["))
                position = text.Split("[")[1].Split(",")[0];
            else
                position = "Bottom";
            return position;
        }

        private static string GetWords(string text)
        {
            string words;
            if (text.Contains("["))
                words = text.Split("] ")[1];
            else
                words = text.Substring(14);
            return words;
        }
    }
}