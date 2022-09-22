namespace MyProject;

    public static class ListExtensions
    {
        public static string ConcatenateStrings(this List<string> list)
        {
            string? totalString = null;
            foreach (var item in list)
            {
                totalString += item;
            }

            return totalString;
        }
        
    }

