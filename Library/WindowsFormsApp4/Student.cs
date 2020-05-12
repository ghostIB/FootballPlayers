using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WindowsFormsApp4
{
    class Student
    {
        public Dictionary<string, string> Params { get; private set; }
        public Student(string surname)
        {
            Params = new Dictionary<string, string>();
            Params.Add("Surname", surname);
        }
        public void Set_Name(string name)
        {
            Params.Add("Name", name);
        }
        public void Set_Class(string inputClass)
        {
            Params.Add("Class", inputClass);
        }
        public void Set_Image(string image)
        {
            Params.Add("Image", image);
        }
        public IEnumerator GetEnumerator()
        {
            return Params.GetEnumerator();
        }
    }
}
