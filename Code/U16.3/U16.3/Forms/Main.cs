﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using U16._3.Classes;

namespace U16._3.Forms
{
    public partial class Main : Form
    {
        Student[] students = new Student[] { };
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            TestData();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPerson form = new NewPerson();
            form.Show();
        }

        private void refresh()
        {
            listBox1.Items.Clear();

            if (students.Length > 0)
            {
                foreach (Student student in students)
                {
                    listBox1.Items.Add(student.getName() + " (" + student.getID() + ")");
                }
            }
        }

        private void TestData()
        {
            Course course = new Course();
            course.setTitle("Computing");
            course.setGrade("MMM");

            addPerson("Hello World", "06/08/2003", course);
            addPerson("Hello World 2", "06/08/2003", course);
        }

        public void addPerson(string Name, string DoB, Course Course)
        {
            int newID = students.Length+1;

            Student student = new Student();
            student.setID(newID.ToString());
            student.setName(Name);
            student.setDoB(DoB);
            student.setCourse(Course);

            students = students.Append(student).ToArray();

            refresh();
        }

        public void addGCSE(GCSE GCSEToAdd, int IDNo)
        {
            Student selectedStudent = students[IDNo];
            selectedStudent.addGCSE(GCSEToAdd);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                Student selectedStudent = students[listBox1.SelectedIndex];

                PersonView form = new PersonView(selectedStudent);
                form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    Student selectedStudent = students[listBox1.SelectedIndex];

                    DialogResult result = MessageBox.Show("Confirm this Deletion to Continue", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        Student[] temp = new Student[] { };
                        for (int x = 0; x < students.Length; x++)
                        {
                            if (x != listBox1.SelectedIndex)
                            {
                                temp = temp.Append(students[i]).ToArray();
                            }
                            students = temp;
                            refresh();
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (searchBox.Modified)
            {
                if (string.IsNullOrEmpty(searchBox.Text))
                {
                    refresh();
                    return;
                };

                listBox1.Items.Clear();

                foreach(Student student in students)
                {
                    if (searchBox.Text == student.getID())
                    {
                        listBox1.Items.Add(student.getName() + " (" + student.getID() + ")");
                    } 
                    else if (searchBox.Text == student.getName())
                    {
                        listBox1.Items.Add(student.getName() + " (" + student.getID() + ")");
                    }
                }

                return;
            }
        }
    }
}
