using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddStudent : Form
    {
        UniversityEntities context;
        //List<Rostra> rostraNames;
        List<Teachers> teachersNames;

        public AddStudent()
        {
            InitializeComponent();
            context = new UniversityEntities();
            teachersNames = context.Teachers.ToList();

            foreach (Teachers teacher in teachersNames)
            {
                comboBox2.Items.Add(teacher.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.Name = textBox1.Text;
            student.Class = textBox2.Text;
            student.Teachers = teachersNames[comboBox2.SelectedIndex];
            Rostra rostra = (from i in context.Rostra
                             where i.Id == student.Teachers.RostRum_Id
                             select i).FirstOrDefault();
            student.Rostra = rostra;
            context.Students.Add(student);
            context.SaveChanges();
            Close();
        }
    }
}
