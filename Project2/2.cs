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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flat_id = textBox1.Text;
            string customerID_f = textBox7.Text;
            string empID_f = textBox5.Text;
            string flatDesc = textBox6.Text;
            string price = textBox2.Text;
            string flatLocation = textBox3.Text;
            string flatStatus = textBox4.Text;
            
            if (!File.Exists("flats.xml"))
            {
                XmlWriter writer = XmlWriter.Create("flats.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteAttributeString("name", "flat1");
                writer.WriteStartElement("flats");
                writer.WriteStartElement("flat_id");
                writer.WriteString(flat_id);
                writer.WriteEndElement();
                writer.WriteStartElement("customerID_f");
                writer.WriteString(customerID_f);
                writer.WriteEndElement();
                writer.WriteStartElement("empID_f");
                writer.WriteString(empID_f);
                writer.WriteEndElement();
                writer.WriteStartElement("flatDesc");
                writer.WriteString(flatDesc);
                writer.WriteEndElement();
                writer.WriteStartElement("price");
                writer.WriteString(price);

                writer.WriteEndElement();

                writer.WriteStartElement("favourite");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteStartElement("flatLocation");
                writer.WriteString(flatLocation);
                writer.WriteEndElement();
                writer.WriteStartElement("flatStatus");
                writer.WriteString(flatStatus);
                writer.WriteEndElement();
                writer.WriteStartElement("customer_Reviews");
                writer.WriteString("");
                writer.WriteEndElement();


                writer.WriteEndElement();
              
                writer.WriteEndDocument();
                writer.Close();
                MessageBox.Show("added sucessfully");
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                
                XmlElement customers = doc.CreateElement("flats");
                XmlElement node = doc.CreateElement("flat_id");
                node.InnerText = flat_id;
                customers.AppendChild(node);
                node = doc.CreateElement("customerID_f");
                node.InnerText = customerID_f;
                customers.AppendChild(node);
                node = doc.CreateElement("empID_f");
                node.InnerText = empID_f;
                customers.AppendChild(node);
                node = doc.CreateElement("flatDesc");
                node.InnerText = flatDesc;
                customers.AppendChild(node);
                node = doc.CreateElement("price");
                node.InnerText = price;
                customers.AppendChild(node);

                node = doc.CreateElement("favourite");
                node.InnerText = "";

                customers.AppendChild(node);

                node = doc.CreateElement("flatLocation");
                node.InnerText = flatLocation;
                customers.AppendChild(node);
                node = doc.CreateElement("flatStatus");
                node.InnerText = flatStatus;
                customers.AppendChild(node);
                node = doc.CreateElement("customer_Reviews");
                node.InnerText = "";
                customers.AppendChild(node);

                doc.Load("flats.xml");
                XmlElement root1 = doc.DocumentElement;
                root1.AppendChild(customers);
                doc.Save("flats.xml");

                MessageBox.Show("added sucessfully");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
                f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f1 = new Form3();
            f1.Show();
        }
    }
    }

public class Flats
{
    public string flatID;
    public string customerID_f;
    public string empID_f;
    public string flatDesc;
    public string price;
    public string flatLocation;
    public string flatStatus;
    public string customer_Reviews;
    public Flats(string f_ID, string c_ID, string emp_ID, string f_Desc, string p, string f_Location, string f_status, string c_Reviews)
    {
        flatID = f_ID;
        customerID_f = c_ID;
        empID_f = emp_ID;
        flatDesc = f_Desc;
        price = p;
        flatLocation = f_Location;
        flatStatus = f_status;
        customer_Reviews = c_Reviews;
    }
}
public class Customers
{
    public string CustomerID;
    public string CustomerName;
    public string Address;
    public string phoneNO;
    public Customers(string c_ID, string c_Name, string a, string p)
    {
        CustomerID = c_ID;
        CustomerName = c_Name;
        Address = a;
        phoneNO = p;
    }
}
public class Employee
{
    public string empID;
    public string no_AssignedFlats;
    public string rate;
    public Employee(string e_ID, string no_AF, string r)
    {
        empID = e_ID;
        no_AssignedFlats = no_AF;
        rate = r;
    }
}
public class Admin
{
    private string ID;
    private string Name;
    public Admin(string id, string name)
    {
        ID = id;
        Name = name;
    }
}