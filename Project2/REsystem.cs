using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace Project2
{
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
        public Flats()
        {

        }
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
        public void insert_flats_info(string f_ID, string f_Desc, string p, string f_Location)
        {
            if (!File.Exists("flats.xml"))
            {
                XmlWriter writer = XmlWriter.Create("flats.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("RE");
                writer.WriteStartElement("flat");

                writer.WriteStartElement("FlatID");
                writer.WriteString(f_ID);
                writer.WriteEndElement();

                writer.WriteStartElement("CustomerID");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteStartElement("EmpID");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteStartElement("FlatDesc");
                writer.WriteString(f_Desc);
                writer.WriteEndElement();

                writer.WriteStartElement("Price");
                writer.WriteString(p);
                writer.WriteEndElement();

                writer.WriteStartElement("FlatLocation");
                writer.WriteString(f_Location);
                writer.WriteEndElement();

                writer.WriteStartElement("FlatStatus");
                writer.WriteString("not taken");
                writer.WriteEndElement();

                writer.WriteStartElement("CustomerReviews");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                XmlDocument doc=new XmlDocument();
                
                XmlElement flat = doc.CreateElement("flat");
                XmlElement node = doc.CreateElement("FlatID");
                node.InnerText = f_ID;
                flat.AppendChild(node);

                node = doc.CreateElement("CustomerID");
                node.InnerText = "";
                flat.AppendChild(node);

                node = doc.CreateElement("EmpID");
                node.InnerText = "";
                flat.AppendChild(node);

                node = doc.CreateElement("FlatDesc");
                node.InnerText = f_Desc;
                flat.AppendChild(node);

                node = doc.CreateElement("Price");
                node.InnerText = p;
                flat.AppendChild(node);

                node = doc.CreateElement("FlatLocation");
                node.InnerText = f_Location;
                flat.AppendChild(node);

                node = doc.CreateElement("FlatStatus");
                node.InnerText = "not taken";
                flat.AppendChild(node);

                node = doc.CreateElement("CustomerReviews");
                node.InnerText = "";
                flat.AppendChild(node);

                doc.Load("flats.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(flat);
                doc.Save("flats.xml");
            }
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
        public Customers()
        {

        }

        public void delete_customerfromflats(String c_ID)
        {
            if (File.Exists("flats.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("flats.xml");
                XmlNodeList list = doc.GetElementsByTagName("CustomerID");
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].InnerText == c_ID)
                    {
                        list[i].InnerText = "";
                    }
                }
                doc.Save("flats.xml");
            }

            if (File.Exists("flats_ads.xml"))
            {
                XmlDocument doc2 = new XmlDocument();
                doc2.Load("flats_ads.xml");
                foreach (XmlNode node in doc2.SelectNodes("table/flats_ads"))
                {
                    if (node.SelectSingleNode("customerID_f").InnerText == c_ID)
                    {

                        node.ParentNode.RemoveChild(node);

                    }
                    if (node.SelectSingleNode("buyer_id").InnerText == c_ID)
                    {
                        node.SelectSingleNode("buyer_id").InnerText = "";
                    }
                }
                doc2.Save("flats_ads.xml");
            }

        }
        public void add_customer(string c_ID,string c_name,string a,string p,string pass)
        {
            if (!File.Exists("Customers.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Customers.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("RE");
                writer.WriteStartElement("customer");

                writer.WriteStartElement("CustomerID");
                writer.WriteString(c_ID);
                writer.WriteEndElement();


                writer.WriteStartElement("CustomerName");
                writer.WriteString(c_name);
                writer.WriteEndElement();

                writer.WriteStartElement("Address");
                writer.WriteString(a);
                writer.WriteEndElement();

                writer.WriteStartElement("phoneNO");
                writer.WriteString(p);
                writer.WriteEndElement();

                writer.WriteStartElement("Password");
                writer.WriteString(pass);
                writer.WriteEndElement();

                writer.WriteStartElement("Favourite");
                writer.WriteString("");
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

            }
            else
            {
                XmlDocument doc = new XmlDocument();

                XmlElement customer = doc.CreateElement("customer");
                XmlElement node = doc.CreateElement("CustomerID");
                node.InnerText = c_ID;
                customer.AppendChild(node);

                node = doc.CreateElement("CustomerName");
                node.InnerText = c_name;
                customer.AppendChild(node);

                node = doc.CreateElement("Address");
                node.InnerText = a;
                customer.AppendChild(node);

                node = doc.CreateElement("phoneNO");
                node.InnerText = p;
                customer.AppendChild(node);

                node = doc.CreateElement("Password");
                node.InnerText = pass;
                customer.AppendChild(node);

                node = doc.CreateElement("Favourite");
                node.InnerText = "";
                customer.AppendChild(node);

                doc.Load("Customers.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(customer);
                doc.Save("Customers.xml");
            }
        }
        
    }
    public class Employee
    {
        public string empID;
        public static int no_AssignedFlats=0;
        public string rate;
        public Employee()
        {

        }
        public Employee(string e_ID, int no_AF, string r)
        {
            empID = e_ID;
            no_AssignedFlats = no_AF;
            rate = r;
        }
        public void add_employee(string e_ID,string p)
        {
            if(!File.Exists("Employee.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Employee.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("RE");
                writer.WriteStartElement("employee");

                writer.WriteStartElement("EmpID");
                writer.WriteString(e_ID);
                writer.WriteEndElement();

                int n = 0;
                writer.WriteStartElement("No-AssignedFlats");
                writer.WriteString(n.ToString());
                writer.WriteEndElement();

                int n1 = 0;
                writer.WriteStartElement("Rate");
                writer.WriteString(n1.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("password");
                writer.WriteString(p);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();

            }
            else
            {
                XmlDocument doc = new XmlDocument();

                XmlElement employee = doc.CreateElement("employee");
                XmlElement node = doc.CreateElement("EmpID");
                node.InnerText = e_ID;
                employee.AppendChild(node);

                int n = 0;
                node = doc.CreateElement("No-AssignedFlats");
                node.InnerText = n.ToString();
                employee.AppendChild(node);

                int n1=0;
                node = doc.CreateElement("Rate");
                node.InnerText = n1.ToString();
                employee.AppendChild(node);

                node = doc.CreateElement("password");
                node.InnerText = p;
                employee.AppendChild(node);

                doc.Load("Employee.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(employee);
                doc.Save("Employee.xml");
            }
        }
        public bool check_ID(string f_ID,string e_ID)
        {
            bool b1 = false;
            bool b2 = false;
            XmlDocument fdoc=new XmlDocument();
            fdoc.Load("flats.xml");
            XmlNodeList flist = fdoc.GetElementsByTagName("FlatID");
            for (int i=0;i<flist.Count;i++)
            {
                if (f_ID==flist[i].InnerText)
                {
                    b1 = true;
                }
            }

            XmlDocument edoc = new XmlDocument();
            edoc.Load("Employee.xml");
            XmlNodeList elist = edoc.GetElementsByTagName("EmpID");
            for (int i = 0; i < elist.Count; i++)
            {
                if (e_ID == elist[i].InnerText)
                {
                    b2 = true;
                }
            }
            if (b1==true && b2==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void no_assigned_flats(string e_ID,int no_assignedflats)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for (int i=0;i<list.Count;i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText==e_ID)
                {
                    children[1].InnerText = no_assignedflats.ToString();
                    doc.Save("Employee.xml");
                    break;
                }
            }
        }
        public bool assign_flat(string f_ID, string e_ID)
        {

            XmlDocument fdoc = new XmlDocument();
            fdoc.Load("flats.xml");
            XmlNodeList flist = fdoc.GetElementsByTagName("flat");
            for (int i = 0; i < flist.Count; i++)
            {
                XmlNodeList children = flist[i].ChildNodes;
                if (children[0].InnerText == f_ID)
                {
                    if (children[6].InnerText != "taken")
                    {
                        if (children[2].InnerText == "")
                        {
                            children[2].InnerText = e_ID;
                            fdoc.Save("flats.xml");
                            return true;
                        }
                    }


                }
            }
            return false;

        }

        public void delete_flatemp(string e_ID)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[2].InnerText == e_ID)
                {
                    children[2].InnerText = "";
                }
            }
            doc.Save("flats.xml");
        }
        public void un_assign_employee()
        {
            
            XmlDocument fdoc = new XmlDocument();
            fdoc.Load("flats.xml");
            XmlNodeList flist = fdoc.GetElementsByTagName("flat");
            
            for (int i=0;i<flist.Count;i++)
            {
                XmlNodeList fchildren = flist[i].ChildNodes;
                if (fchildren[6].InnerText == "bought" )
                {
                    reduce_Noassigned(fchildren[2].InnerText);
                    fchildren[2].InnerText = "";
                }
                else if ( fchildren[6].InnerText == "rented")
                {
                    reduce_Noassigned(fchildren[2].InnerText);
                    fchildren[2].InnerText = "";
                }
            }
            fdoc.Save("flats.xml");

        }
        public void reduce_Noassigned(string e_ID)
        {
            if (File.Exists("Employee.xml"))
            {
                XmlDocument edoc = new XmlDocument();
                edoc.Load("Employee.xml");
                XmlNodeList elist = edoc.GetElementsByTagName("employee");
                for (int i = 0; i < elist.Count; i++)
                {
                    XmlNodeList echildren = elist[i].ChildNodes;
                    if (echildren[0].InnerText == e_ID)
                    {
                        int n = int.Parse(echildren[1].InnerText);
                        n--;
                        echildren[1].InnerText = n.ToString();
                    }
                }
                edoc.Save("Employee.xml");
            }
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
}
