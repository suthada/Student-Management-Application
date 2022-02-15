using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_Application
{
    internal class Student
    {
        private string _id;
        private string _name;
        private string _major;

        //encapsulation
        public string getId() { return _id; }
        public string getName() { return _name; }
        public string getMajor() { return _major;}
    }
}
