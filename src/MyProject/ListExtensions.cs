using System.Runtime.InteropServices;

namespace MyProject;

public static class ListExtensions
{
    public static string ConcatenateStrings(this List<string> list)
    {
      
        
            var separator = ",";
            int strLength = separator.Length * list.Count;

            foreach (var s in list)
                strLength += s.Length;

            return string.Create(strLength, (separator, list), static (span, state) =>
            {
                var strings = CollectionsMarshal.AsSpan(state.list);

                for (int i = 0, offset = 0; i < strings.Length; i++)
                {
                    strings[i].CopyTo(span[offset..]);
                    offset += strings[i].Length;

                    if (state.separator.Length == 1)
                        span[offset] = state.separator[0];
                    else
                        state.separator.CopyTo(span[offset..]);

                    offset += state.separator.Length;
                }
            });
        }
    }



