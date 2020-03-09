using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Model
{
    class Client : Person
    {
        private string companyName;
        //public string name = "client";


        public Client(string name, string companyName) : base(name)
        {
            this.companyName = companyName;
        }

        public void DoClientStuff()
        {
            Console.WriteLine( this.protData);
           

            Console.WriteLine("DoClientStuff");
        }

        public override void IntroduceYourself()
        {
            base.IntroduceYourself();
            Console.WriteLine("... and I work in " + companyName);
        }

        public new void  DoStuff()
        {

        }

    }
}
