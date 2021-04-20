using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class ToDoListOBJ
    {

        private String toDo;

        public ToDoListOBJ(string toDo)
        {
            this.ToDo = toDo;
        }

        public string ToDo { get => toDo; set => toDo = value; }
    }
}
