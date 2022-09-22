namespace MyProject;

    public static class ListExtensions
    {
        public static string ConcatenateStrings(this List<string> list)
        {
            string? totalString = null;
            string lastString = list[^1];
            foreach (var item in list)
            {
                totalString += lastString;
            }

            return totalString;
        }
        
    }

