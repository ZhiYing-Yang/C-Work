using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3_1
{
    class CourseInfo
    {
        public string CourseName { set; get; }
        public enum CourseTime{春季=0, 秋季=1 }
        public string Season { set;  get; }
        public string BookName { set; get; }
        public double Price { set; get; }
        private static int counter = 0;
        public CourseInfo(){
            CourseName = "";
            BookName = "";
            Price = 0;
            counter++;

        }
        public CourseInfo(string CourseName, int seasonNum, string BookName,  double Price){
            this.CourseName = CourseName;
            this.BookName = BookName;
            Season = Enum.GetName(typeof(CourseTime), seasonNum);
            this.Price = Price;
            counter++;
        }
        public void Print() {
            Console.WriteLine(this.CourseName+this.BookName+this.Price+Season);
        }

    }
}
