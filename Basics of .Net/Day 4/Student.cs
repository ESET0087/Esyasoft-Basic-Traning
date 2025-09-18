using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_demo
{
    internal class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }
        
        public Student(int id, string name, int marks) { 
            this.id = id;
            this.name = name; 
            this.marks = marks;
        }
    }
}
