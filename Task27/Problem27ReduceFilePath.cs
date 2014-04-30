using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task27
{
    //A file path in a Unix OS looks like this - /home/radorado/code/hackbulgaria/week0
    //We start from the root - / and we navigate to the destination fodler.
    //But there is a problem - if we have .. and . in our file path, it's not clear where we are going to end up.
    class Problem27ReduceFilePath
    {
        static string reduce_file_path(string path)
        {
            string[] foldersInArray = path.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> foldersInList = new List<string>();
            for (int i = 0; i < foldersInArray.Length; i++)
            {
                foldersInList.Add(foldersInArray[i]);
            }
            for (int i = foldersInList.Count - 1; i >= 0; i--)
            {
                if (foldersInList[i] == ".")
                {
                    foldersInList.RemoveAt(i);
                }
            }
            for (int i = foldersInList.Count - 1; i >= 0; i--)
            {
                if (foldersInList[i] == "..")
                {
                    foldersInList.RemoveAt(i);
                    i--;
                    if (i < 0)
                    {
                        break;
                    }
                    foldersInList.RemoveAt(i);
                }
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < foldersInList.Count; i++)
            {
                result.Append("/");
                result.Append(foldersInList[i]);
            }
            if (foldersInList.Count == 0)
            {
                result.Append("/");
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(reduce_file_path("/home//radorado/code/./hackbulgaria/week0/../"));
            Console.WriteLine(reduce_file_path("/"));
            Console.WriteLine(reduce_file_path("/srv/../"));
            Console.WriteLine(reduce_file_path("/srv/www/htdocs/wtf/"));
            Console.WriteLine(reduce_file_path("/srv/www/htdocs/wtf"));
            Console.WriteLine(reduce_file_path("/srv/./././././"));//
            Console.WriteLine(reduce_file_path("/etc//wtf/"));
            Console.WriteLine(reduce_file_path("/etc/../etc/../etc/../"));//
            Console.WriteLine(reduce_file_path("//////////////"));
            Console.WriteLine(reduce_file_path("/../"));
        }
    }
}
