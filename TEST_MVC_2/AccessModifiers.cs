using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEST_MVC_2
{
    public class AccessModifiers
    {
        //SUJEET no change again

        //1. public access modifier
        public string name1 = "Sheeran";
        public void print1()
        {
            Console.WriteLine("Hello from Student class");
        }

        //2. private access modifier
        private string name2 = "Sheeran";
        private void print2()
        {
            Console.WriteLine("Hello from Student class");
        }

        //3. protected access modifier
        protected string name3 = "Sheeran";


        //4. internal access modifier
        internal string name4 = "Sheeran";


        //5. protected internal access modifier
        protected internal string name5 = "Hello";


        //6. private protected access modifier
        private protected string name = "Sheeran";
    }

    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }

    }

    public class TESTCLASS : AccessModifiers
    {
        AccessModifiers access = new AccessModifiers();
        TESTCLASS testClass = new TESTCLASS();

        private void TestHere()
        {
            //string ss = access.;

            //string ss1 = testClass.;
        }

        public void TestPolymorphism()
        {
            Animal a1 = new Animal();
            a1.eat();

            Animal a2 = new Dog();
            a2.eat();
        }
    }
}