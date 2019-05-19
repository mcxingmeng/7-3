using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentguanli
{
    public class Bachelor:Student 
    {
        private string Major;
        private string Grade;
        private string ClassGrade;
        public static int num=0;
        public string major
        {
            get { return Major; }
            set { major = value; }
        }
        public string grade
        {
            get { return Grade; }
            set { grade = value; }
        }
        public string classgrade
        {
            get { return ClassGrade; }
            set { classgrade = value; }
        }
        public void setdata(string major,string grade,string classgrade)
        {
            this.Major = major;
            this.Grade = grade;
            this.ClassGrade = classgrade;
            num++;
        }
        public override void display()
        {
            Console.WriteLine($"本科生：学号：{id}，姓名：{name}，性别：{sex}，年龄：{age}，专业：{major }，年级：{grade }，班级：{classgrade }");
        }
        public override void displaynum()
        {
            Console.WriteLine($"本科生目前有{num}人");
        }
    }
}
