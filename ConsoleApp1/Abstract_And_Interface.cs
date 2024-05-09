using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    abstract class MyAbstract
    {
        public abstract void AbstractDisplay();
        public abstract void AbstractSelect();
        public void AbstractSave()
        {
            Console.WriteLine("Hello Abstract");
        }
    }


        interface MyInterface

        {
            void display();
            void select();
        }
        /*interface can have multiple interface but class cannot have
         * only method name*/
        interface Interface2
        {
            void save();
        }
    

    
    class ImplementClass: MyAbstract,MyInterface, Interface2 //abstract class should be made before interface class



    {
        public void display()
        {
            Console.WriteLine("Display Method of MyInterface class.");

        }
        public void select()
        {
            Console.WriteLine("Select method of MyInterface class.");
        }
        public void save()
        {
            Console.WriteLine("save method of Interface2 class");
        }
            public override void AbstractDisplay()
            {
                Console.WriteLine("Display Abstract  method.");
            }
            public override void AbstractSelect()
            {
                Console.WriteLine("Select Abstract method.");
            }
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyInterface obj = new ImplementClass();//interface obj created using class( ImplementClass) reference
            obj.display();
            obj.select();
            Interface2 obj1 = new ImplementClass();
            obj1.save();
            MyAbstract myAbstract = new ImplementClass();
            myAbstract.AbstractDisplay();
            myAbstract.AbstractSelect();
            Console.ReadKey();
        }
    }
    }

