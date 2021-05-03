using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class Form1 : Form
    {
     
        Form2 addForm1 = new Form2();
        public Form1()
        {
            
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addForm1.Visible = false;

            String kb;
            try
            {
                StreamReader f1 = new StreamReader("toDo.txt");
                while ((kb = f1.ReadLine()) != null)
                {
                    string[] kbParts = kb.Split(',');
                    ToDoListOBJ temp = new ToDoListOBJ(kbParts[0], kbParts[1], kbParts[2], kbParts[3]);
                    todoListWorker.newList.Add(temp);
                }
                f1.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error");

            }

            foreach (ToDoListOBJ item in todoListWorker.newList)
            {
                lstboxMain.Items.Add(item.ToDo + " - " + item.Descripcion + " - " + item.Date + 
                    " - " + item.Priority);
            }
        }

        

        private void addButton_Click(object sender, EventArgs e)
        {
            addForm1.Visible = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            String kb;
            try
            {
                StreamReader f1 = new StreamReader("toDo.txt");
                while ((kb = f1.ReadLine()) != null)
                {
                    string[] kbParts = kb.Split(',');
                    ToDoListOBJ temp = new ToDoListOBJ(kbParts[0], kbParts[1], kbParts[2], kbParts[3]);
                    todoListWorker.newList.Add(temp);
                }
                f1.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error");

            }

            foreach (ToDoListOBJ item in todoListWorker.newList)
            {
                lstboxMain.Items.Add(item.ToDo + " - " + item.Descripcion + " - " + item.Date +
                    " - " + item.Priority);
            }
        }
    }
}
