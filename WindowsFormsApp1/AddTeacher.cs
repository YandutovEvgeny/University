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
    public partial class AddTeacher : Form
    {
        UniversityEntities context;
        List<Rostra> rostraName;
        public AddTeacher()
        {
            InitializeComponent();
            context = new UniversityEntities();
            rostraName = context.Rostra.ToList();

            foreach (Rostra rostra in rostraName)
            {
                comboBox1.Items.Add(rostra.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers();
            teacher.Name = textBox1.Text;
            teacher.BDay = dateTimePicker1.Value;
            teacher.Rostra = rostraName[comboBox1.SelectedIndex];

            context.Teachers.Add(teacher);
            context.SaveChanges();
            Close();
        }
    }
}
