using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Model
{
    class Person : Object
    {

        public int puData;
        protected int protData;
        private int prData;


        public string Name;

        public string name = "person";


        public Person(string name)
        {
            this.name = name;
        }

        public void DoPersonStuff()
        {
            Console.WriteLine("DoPersonStuff");
        }

        public virtual void IntroduceYourself()
        {
            Console.WriteLine("I am a person with name "+name);
        }
        public void DoStuff()
        {

        }
    }
}
