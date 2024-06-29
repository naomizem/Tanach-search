using DAL_Tanach;
using Enteties_Dto_Tanach;
using System.Text.RegularExpressions;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;


namespace BLL_Tanach
{
    public class ClassBll
    {
        private ClassDal f { get; set; }

        public ClassBll()
        {
            this.f = new ClassDal();
        }


        public List<int> SearchWord(string word)
        {
            List<int> list = new List<int>();
            string text = f.DataAccessRead();
            string[] text1 = Regex.Split(text, @"\s+|(?<=[.,;^~!-])");
            for (int i = 0; i<=text1.Length-1; i++)
            {
                if (text1[i] == word)
                list.Add(i);
            }
            try
            {
                int testAccess = list[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new InvalidOperationException("No matching words found.");
            }

            return list;
        }

        public List<Location> wordLocationSearch(string word)
        {
            string book = "";
            string chapter = "";
            string parasha = "";
            string pasuk = "";
            List<Location> list = new List<Location>();
            string text = f.DataAccessRead();
            text = Regex.Replace(text, "[{}]", "");
            string[] text1 = Regex.Split(text, @"\s+|(?<=[.,;^~!-])");

            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i].Contains("^"))
                    parasha = text1[i + 2];

                if (text1[i].Contains("~"))
                    book = text1[i + 1];

                if (text1[i].Contains("-"))
                    chapter = text1[i + 1];

                if (text1[i].Contains("!"))
                    pasuk = text1[i + 1];

                if (word == text1[i])
                {
                    Location loc = new Location(book, chapter, pasuk, parasha);
                    list.Add(loc);
                }
            }

            if (!list.Any())
            {
                throw new InvalidOperationException("No matching words found.");
            }

            string updateJson = JsonSerializer.Serialize(list);
            File.WriteAllText("Tanach.json", updateJson);

            return list;
        }








        public List<string> SearchInitials(string word)
        {
            string text = f.DataAccessRead();
            string[] text1 = Regex.Split(text, @"\s+|(?<=[.,;^~!-])");
            List<string> list = new List<string>();
            int index = 0;

            for (int i = 0; i < text1.Length; i++)
            {
                if (index < word.Length && text1[i].Length > 0 && text1[i][0] == word[index])
                {
                    index++;
                }
                else
                {
                    index = 0;
                }

                if (index == word.Length)
                {
                    string line = string.Join(" ", text1, i - index + 1, index);
                    list.Add(line);

                    index = 0;
                }

            }
            try
            {
                string testAccess = list[0];
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new InvalidOperationException("No matching words found.");
            }


            return list;
        }


    }
}







