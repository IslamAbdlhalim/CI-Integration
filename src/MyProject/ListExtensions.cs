namespace MyProject;

    public static class ListExtensions
    {
        public static string ConcatenateStrings(this List<string> list)
        {
            string? totalString = null;
            string lastString = list[^1];
            foreach (var item in list)
            {
                if (item != lastString)
                {
                    totalString += item + ",";
                }
                else
                {
                    totalString += lastString;
                }

            }

            return totalString;
        }

        public static int ARandomMethod()
        {
            return 1;
        }
    }

