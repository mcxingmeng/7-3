using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentguanli
{
    public class PostGraduate:Student 
    {
        private string Major;
        private string Grade;
        private string ObjectOfstudy;
        private string Tutor;
        public static int num=0;
        public string major
        {
            get { return Major; }
            set { Major = value; }
        }
        public string grade
        {
            get { return Grade; }
            set { Grade = value; }
        }
        public string objectofstudy
        {
            get { return ObjectOfstudy; }
            set { ObjectOfstudy = value; }
        }
        public string tutor
        {
            get { return Tutor; }
            set { Tutor = value; }
        }
        public void setdata(string _major,string _grade,string _objectofstudy,string _tutor)
        {
            this.Grade = _grade;
            this.Major = _major;
            this.ObjectOfstudy = _objectofstudy;
            this.Tutor = _tutor;
            num++;
        }
        public override void display()
        {
            Console.WriteLine($"本科生：学号：{id}，姓名：{name}，性别：{sex}，年龄：{age}，专业：{grade}，年级：{major}，研究方向：{objectofstudy}，导师：{tutor}。");
        }
        public override void displaynum()
        {
            Console.WriteLine($"研究生目前有{num}人");
        }
    }
}
