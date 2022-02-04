using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theOfficeAI
{
    public static class TheOffice
    {
        private static void makeTries(string character, string text)
        {
            
        }

        public static int numberOfWordsSpoken(string character)
        {
            // 


            var items = new List<string> { "armed", "armed", "jazz", "jaws" };
            var stream = new StreamReader(@"C:/Users/Public/Dropbox/Repos/theOfficeAI/data/theOfficeTranscript.txt");

            while (!stream.EndOfStream)
                items.Add(stream.ReadLine());

            var trie = new Trie();
            trie.InsertRange(items);
            return 110;
        }
    }
}
