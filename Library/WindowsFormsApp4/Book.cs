using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApp4
{
    class Book
    {
        public Dictionary<string, string> Params { get; private set; }
        public Book(string Name)
        {
            Params = new Dictionary<string, string>();
            Params.Add("Title", Name);
        }
        public void Set_Author(string author)
        {
            Params.Add("Author", author);
        }
        public void Set_Straight(string straight)
        {
            Params.Add("Straight", straight);
        }
        public void Set_Genre(string genre)
        {
            Params.Add("Genre", genre);
        }
        public IEnumerator GetEnumerator()
        {
            return Params.GetEnumerator();
        }
    }
}
