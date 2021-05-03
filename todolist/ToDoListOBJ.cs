using System;
using System.Collections.Generic;
using System.Text;

namespace todolist
{
    class ToDoListOBJ
    {

        private String toDo;
        private String descripcion;
        private String date;
        private String priority;

        public ToDoListOBJ()
        {

        }

        public ToDoListOBJ(string toDo, string descripcion, string date, string priority)
        {
            this.ToDo = toDo;
            this.Descripcion = descripcion;
            this.Date = date;
            this.Priority = priority;
        }

        public string ToDo { get => toDo; set => toDo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Date { get => date; set => date = value; }
        public string Priority { get => priority; set => priority = value; }
    }
    }

