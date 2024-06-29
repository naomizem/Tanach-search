using System.Threading.Tasks;

namespace Enteties_Dto_Tanach
{
    public class Location
    {

        public string book { get; set; }
        public string parsha { get; set; }
        public string chapter { get; set; }
        public string pasuk { get; set; }

        public Location(string book, string chapter, string pasuk, string parash){

            this.book = book;
            this.parsha = parash;
            this.chapter = chapter;
            this.pasuk = pasuk;
        }
    }


    public class convertJson
    {
        public List<Location> Location { get; set; }
    }
}
