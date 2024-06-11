using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispit
{
    public partial class Form1 : Form
    {
        List<Class1> Class1List = new List<Class1>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIme.Text == "" ||
                    txtPrezime.Text == "" ||
                    cmbUloge.Text == "")
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                                        "Pogrešan unos", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtIme.Focus();
                }
                else
                {
                    Class1 class1 = new Class1(txtIme.Text,
                        txtPrezime.Text,
                        cmbUloge.Text);
                    Class1List.Add(class1);
                    txtIme.Clear();
                    txtPrezime.Clear();
                    txtIme.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                    "Pogrešan unos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtIme.Clear();
                txtPrezime.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }

}

