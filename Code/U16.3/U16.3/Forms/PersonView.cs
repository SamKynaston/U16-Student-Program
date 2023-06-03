using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U16._3.Classes;

namespace U16._3.Forms
{
    public partial class PersonView : Form
    {
        Student selStudent = null;

        public PersonView(Student student)
        {
            selStudent = student;
            InitializeComponent();
        }

        public void AddGCSE(GCSE gcseToAdd)
        {
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            mainForm.addGCSE(gcseToAdd, Int32.Parse(selStudent.getID()));
        }

        private void Person_Load(object sender, EventArgs e)
        {
            this.Text = selStudent.getName() + " (" + selStudent.getID() + ")";

            listBox1.Items.Add(selStudent.getID());
            listBox2.Items.Add("ID: ");

            listBox1.Items.Add(selStudent.getName());
            listBox2.Items.Add("Name: ");

            listBox1.Items.Add(selStudent.getDoB());
            listBox2.Items.Add("DoB: ");

            Course course = selStudent.getCourse();

            listBox1.Items.Add(course.getTitle());
            listBox2.Items.Add("Course Title: ");

            listBox1.Items.Add(course.getGrade());
            listBox2.Items.Add("Course Grade: ");

            if (selStudent.getGCSECount() > 0)
            {
                foreach(GCSE gsce in selStudent.GetGCSEs())
                {
                    listBox1.Items.Add(gsce.getGrade());
                    listBox2.Items.Add(gsce.getTitle());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddGCSE form = new AddGCSE();
            form.Show();
        }
    }
}
