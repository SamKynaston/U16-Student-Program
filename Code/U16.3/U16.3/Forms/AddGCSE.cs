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
    public partial class AddGCSE : Form
    {
        public AddGCSE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GCSE newGCSE = new GCSE();
            newGCSE.setGrade(this.gradeBox.Text);
            newGCSE.setTitle(this.titleBox.Text);

            var viewForm = Application.OpenForms.OfType<PersonView>().Single();
            viewForm.AddGCSE(newGCSE);
        }
    }
}
