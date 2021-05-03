using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace todolist
{
    public partial class Form2 : Form
    {
        ToDoListOBJ t1 = new ToDoListOBJ();
     
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            t1.ToDo = txtTitle.Text;
            t1.Descripcion = txtDesc.Text;
            t1.Date = txtDate.Text;
            t1.Priority = cmbPriority.Text;

            todoListWorker.newList.Add(t1);

            txtTitle.Clear();
            txtDesc.Clear();
            txtDate.Clear();

            try
            {
                StreamWriter sw = new StreamWriter("toDo.txt");

                foreach (ToDoListOBJ item in todoListWorker.newList)
                {
                    sw.WriteLine(item.ToDo + "," + item.Descripcion + "," + item.Date+ "," + item.Priority);
                }

                sw.Close();
            }
            catch (Exception ew)
            {

                MessageBox.Show(ew.Message);
             
            }
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
        }
    }
}
