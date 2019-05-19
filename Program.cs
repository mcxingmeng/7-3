using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentguanli
{
    class Program
    {
        static void Main(string[] args)
        {
            Bachelor a1 = new Bachelor();
            Bachelor a2 = new Bachelor();
            PostGraduate p = new PostGraduate();
            string name,id,sex,major,grade,classgrade, objectofstudy, tutor;
            int age;
            Console.WriteLine("添加一名本科生，请输入本科生的信息：");
            Console.WriteLine("学号：");
            id=Console.ReadLine();
            Console.WriteLine("姓名：");
            name = Console.ReadLine();
            Console.WriteLine("性别：");
            sex = Console.ReadLine();
            Console.WriteLine("年龄：");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("专业：");
            major  = Console.ReadLine();
            Console.WriteLine("年级：");
            grade  = Console.ReadLine();
            Console.WriteLine("班级：");
            classgrade  = Console.ReadLine();
            a1.setdata(id, name , sex,age );
            a1.setdata(major , grade , classgrade );
            Console.WriteLine("添加一名本科生，请输入本科生的信息：");
            Console.WriteLine("学号：");
            id = Console.ReadLine();
            Console.WriteLine("姓名：");
            name = Console.ReadLine();
            Console.WriteLine("性别：");
            sex = Console.ReadLine();
            Console.WriteLine("年龄：");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("专业：");
            major = Console.ReadLine();
            Console.WriteLine("年级：");
            grade = Console.ReadLine();
            Console.WriteLine("班级：");
            classgrade = Console.ReadLine();
            a2.setdata(id,name,sex,age);
            a2.setdata(major, grade, classgrade);
            Console.WriteLine("添加一名研究生，请输入研究生的信息：");
            Console.WriteLine("学号：");
            id = Console.ReadLine();
            Console.WriteLine("姓名：");
            name = Console.ReadLine();
            Console.WriteLine("性别：");
            sex = Console.ReadLine();
            Console.WriteLine("年龄：");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("专业：");
            major = Console.ReadLine();
            Console.WriteLine("年级：");
            grade = Console.ReadLine();
            Console.WriteLine("研究方向：");
            objectofstudy = Console.ReadLine();
            Console.WriteLine("导师：");
            tutor = Console.ReadLine();
            p.setdata(id, name, sex, age);
            p.setdata(major, grade,objectofstudy ,tutor );
            a1.display();
            a2.display();
            p.display();
            a2.displaynum();
            p.displaynum();
            Console.Read();
        }
    }
}
