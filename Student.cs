using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentguanli
{
    public class Student
    {
        protected string Id;
        protected string Name;
        protected string Sex;
        protected int Age;
        public static int num=0;
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string sex
        {
            get { return Sex; }
            set { Sex = value; }
        }
        public int age
        {
            get { return Age; }
            set { Age = value; }
        }
        public void setdata(string id,string name,string sex,int age)
        {
            this.Id = id;
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            num++;
        }
        public virtual void display()
        {
            Console.WriteLine($"学号：{Id }姓名：{Name}性别:{Sex }年龄：{Age }");
        }
        public virtual void displaynum()
        {
            Console.WriteLine($"目前有{num}名学生");
        }
    }
}
