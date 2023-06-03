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
    public partial class NewPerson : Form
    {
        public NewPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Main>().Single();
            Course course = new Course();

            course.setTitle(this.courseTitle.Text);
            course.setGrade(this.courseGrade.Text);

            mainForm.addPerson(this.nameBox.Text, this.dobBox.Text, course);
            this.Close();
        }
    }
}
