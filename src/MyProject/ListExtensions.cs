namespace MyProject;

public static class ListExtension
{
    public static string ConcatenateList(this List<string> list)
    {
        string concatenate = "";
        foreach (var item in list)
        {
            concatenate += item;
        }

        return concatenate;
    }
}
