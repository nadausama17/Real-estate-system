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
using System.Threading;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(formRun));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        private void formRun()
        {
            Application.Run(new loadingscreen());
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

            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool all = true;

            string name = bunifuCustomTextbox1.Text;
            if (name == "")
            {
                MessageBox.Show("Please enter your name");
                all = false;
            }
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
            string check = bunifuCustomTextbox4.Text;
            if (check == "")
            {
                MessageBox.Show("Please reenter your password");
                all = false;
            }

            ////////for checking id
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("Login.xml");
            XmlNodeList list1 = doc1.GetElementsByTagName("Emp");

            for (int i = 0; i < list1.Count; i++)
            {
                XmlNodeList children = list1[i].ChildNodes;
                if (children[0].InnerText == id)
                {
                    MessageBox.Show("ID Is Already Taken");
                    all = false;
                }
            }
            ///////for checking
           

            if (pass != check)
            {
                MessageBox.Show("Please reenter your password correctly");
                all = false;
            }

            if (all == true)
            {

                if (!File.Exists("Login.xml"))
                {
                    XmlWriter w = XmlWriter.Create("Login.xml");
                    w.WriteStartDocument();
                    w.WriteStartElement("table");
                    w.WriteAttributeString("Name", "Emp");

                    w.WriteStartElement("Emp");

                    w.WriteStartElement("ID");
                    w.WriteString(id);
                    w.WriteEndElement();

                    w.WriteStartElement("Name");
                    w.WriteString(name);
                    w.WriteEndElement();

                    w.WriteStartElement("Password");
                    w.WriteString(pass);
                    w.WriteEndElement();

                    w.WriteEndElement();
                    w.WriteEndElement();
                    w.WriteEndDocument();
                    w.Close();

                    MessageBox.Show("Sign up Successfully");

                }

                else if(File.Exists("Login.xml"))
                {

                    
                   
                    XmlDocument doc = new XmlDocument();

                    doc.Load("Login.xml");
                    XmlElement Emp = doc.CreateElement("Emp");

                    XmlElement node = doc.CreateElement("ID");
                    node.InnerText = id;
                    Emp.AppendChild(node);

                    node = doc.CreateElement("Name");
                    node.InnerText = name;
                    Emp.AppendChild(node);

                    node = doc.CreateElement("Password");
                    node.InnerText = pass;
                    Emp.AppendChild(node);

                    XmlElement root = doc.DocumentElement;

                    root.AppendChild(Emp);
                    doc.Save("Login.xml");

                    MessageBox.Show("Signed up Successfully");

                }
            }
        

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }
    }
}
