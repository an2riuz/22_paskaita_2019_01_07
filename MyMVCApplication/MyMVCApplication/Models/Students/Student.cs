using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models.Students
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Score { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return $"Student(Id:{Id}, Name:{Name}, Score:{Score}, City:{City})";
        }
    }
}