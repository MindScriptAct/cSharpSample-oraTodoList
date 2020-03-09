using System;
using System.Collections.Generic;
using System.Text;

namespace TodoListConsoleApp.Model
{
    class ToDoItem
    {

        private string name;

        private int preority = 0;

        private DateTime? deadLine  = null;

        public ToDoItem(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }




    }
}
