using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Project2
{
    public partial class Form2 : Form
    {
        public string s = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool all = true;
            string id = bunifuCustomTextbox2.Text;
            if (id == "")
            {
                MessageBox.Show("Please enter your id");
                all = false;
            }
            string pass = bunifuCustomTextbox3.Text;
            if (pass == "")
            {
                MessageBox.Show("Please enter your password");
                all = false;
            }


            if (all == true)
            {
                if (radioButton1.Checked)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Login.xml");
                    XmlNodeList list = doc.GetElementsByTagName("Emp");


                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList children = list[i].ChildNodes;
                        if (id == children[0].InnerText)
                        {
                            if (pass == children[2].InnerText)
                            {

                                Form3 f = new Form3();
                                f.Show();
                                this.Hide();
                                MessageBox.Show("Loged in");

                            }

                        }
                    }
                }

                if (radioButton2.Checked)
                {
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load("Employee.xml");
                    XmlNodeList list1 = doc1.GetElementsByTagName("employee");


                    for (int i = 0; i < list1.Count; i++)
                    {
                        XmlNodeList children = list1[i].ChildNodes;
                        if (id == children[0].InnerText)
                        {
                            if (pass == children[3].InnerText)
                            {
                                s = bunifuCustomTextbox2.Text;
                                employye_tasks f = new employye_tasks(s);
                                f.Show();
                                this.Hide();
                                MessageBox.Show("Loged in");

                            }

                        }
                    }
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
