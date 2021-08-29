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
using Project2;

namespace sample
{
    public partial class buy : Form
    {
        public string s = "";
        public buy()
        {
            InitializeComponent();
        }
        public buy(string c_ID)
        {
            InitializeComponent();
            s = c_ID;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string location = textBox3.Text;
            string available = "not taken";
            if (!File.Exists("flats.xml"))
            {
                XmlWriter writer = XmlWriter.Create("flats.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteAttributeString("name", "flats");


                writer.WriteStartElement("flats");
                writer.WriteStartElement("id");
                writer.WriteString(id);
                writer.WriteEndElement();

                writer.WriteStartElement("location");
                writer.WriteString(location);
                writer.WriteEndElement();

                writer.WriteStartElement("available");

             
             
                   available = "not taken";
                    writer.WriteString(available);
                    writer.WriteEndElement();
               

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();




            }
            else
            {
                XmlDocument doc = new XmlDocument();




                XmlElement xe = doc.CreateElement("flats");
                XmlElement child = doc.CreateElement("id");
                child.InnerText = id;
                xe.AppendChild(child);


                child = doc.CreateElement("location");
                child.InnerText = location;
                xe.AppendChild(child);

                

                child = doc.CreateElement("available");
                child.InnerText = available;
                xe.AppendChild(child);

              



                doc.Load("flats.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(xe);
                doc.Save("flats.xml");


            }



            MessageBox.Show("added");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool answer = false;

            radioButton2.Visible = true;
            radioButton3.Visible = true;
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");

            XmlDocument doc2 = new XmlDocument();
            doc2.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");

            XmlNodeList list2 = doc2.GetElementsByTagName("customer");

            for (int k = 0; k < list2.Count; k++)
            {

                XmlNodeList children2 = list2[k].ChildNodes;

                if (children2[0].InnerText == s)
                {
                    answer = true;
                    

                    if (radioButton2.Checked)
                    {


                        Employee emp = new Employee();
                        if (MessageBox.Show("Do you want to confirm", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {

                                XmlNodeList children = list[i].ChildNodes;
                                if (children[0].InnerText == textBox1.Text)
                                {
                                    

                                    children[6].InnerText = "bought";
                                    children[1].InnerText = s;

                                    

                                }
                            }
                            doc.Save("flats.xml");
                            emp.un_assign_employee();
                            MessageBox.Show("Confirmed");
                        }
                    }

                    else if (radioButton3.Checked)
                    {
                        Employee emp = new Employee();
                        if (MessageBox.Show("Do you want to confirm", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {

                                XmlNodeList children = list[i].ChildNodes;
                                if (children[0].InnerText == textBox1.Text)
                                {
                                    children[6].InnerText = "rented";
                                    children[1].InnerText = s;
                                    
                                    
                                }
                            }
                            doc.Save("flats.xml");
                            emp.un_assign_employee();
                            MessageBox.Show("Confirmed");
                        }
                    }

                }
             
            }

            if (!answer)
            {
                MessageBox.Show("ID Not Found");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            string s = "";
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;

                s = children[6].InnerText;
                if (s != "bought" &&s!="rented")
                {
                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add(children[0].Name, children[0].Name);
                        dataGridView1.Columns.Add(children[1].Name, children[1].Name);
                        dataGridView1.Columns.Add(children[2].Name, children[2].Name);
                        dataGridView1.Columns.Add(children[5].Name, children[5].Name);
                        dataGridView1.Columns.Add(children[3].Name, children[3].Name);
                        dataGridView1.Columns.Add(children[6].Name, children[6].Name);

                    }

                    dataGridView1.Rows.Add(new string[] { children[0].InnerText, children[1].InnerText, children[2].InnerText,children[5].InnerText, children[3].InnerText, children[6].InnerText });
                }

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void buy_Load(object sender, EventArgs e)
        {

        }

        //    private void button4_Click(object sender, EventArgs e)
        //    {
        //        string message = "Do you want to Buy Or Rent this Flat?";
        //        // string title = "Close Window";
        //        MessageBoxButtons buttons = MessageBoxButtons.OK.;
        //        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        //        if (result == DialogResult.Abort)
        //        {
        //            this.Close();
        //            DialogResult.
        //        }
        //}
    }
}