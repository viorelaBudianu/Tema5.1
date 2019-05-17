using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{

    class Program
    {
       static void Main(string[] args)
        {
            List<Discipline> d1=new List<Discipline>();
            d1.Add(new Discipline ("Mathematics",23,190));
            List<Students> s1=new List<Students>();
            s1.Add(new Students("Vio","Budianu","1A"));
            List<Teachers> t1=new List<Teachers>();
            t1.Add(new Teachers("Maria","Ionescu",d1));
            Class a1= new Class(s1,t1,"1A");
            Class a2=new Class(s1,t1,"1A");
            Console.Write(a1.ClassID,a2.ClassID);

            Console.ReadKey();
            
        }
    }
    }

