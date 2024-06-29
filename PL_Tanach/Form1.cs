using BLL_Tanach;
using DAL_Tanach;
using Enteties_Dto_Tanach;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PL_Tanach
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassBll classBll = new ClassBll();
            string word = textBox1.Text;
            List<int> searchResults = classBll.SearchWord(word);
            listBox1.Items.Clear();
            foreach (int item in searchResults)
            {
                listBox1.Items.Add($"place: {item}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassBll classBll = new ClassBll();
            string word = textBox1.Text;
            List<Location> searchResults = classBll.wordLocationSearch(word);
            listBox1.Items.Clear();
            foreach (Location item in searchResults)
            {
                listBox1.Items.Add($"Book: {item.book}, Parasha: {item.parsha}, Chapter: {item.chapter}, Pasuk: {item.pasuk} ");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            ClassBll classBll = new ClassBll();
            string word = textBox1.Text;
            List<string> searchResults = classBll.SearchInitials(word);
            listBox1.Items.Clear();
            foreach (string item in searchResults)
            {
                listBox1.Items.Add($"Initials: {item}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}


