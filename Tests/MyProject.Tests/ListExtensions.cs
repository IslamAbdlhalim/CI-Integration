namespace MyProject.Tests;

public static class ListExtensions
{
    public static string AddItems<T>(this List<string> list)
    {
        string totalString = "";
        foreach (var item in list)
        {
            totalString += item;
        }

        return totalString;
    }
    
}
