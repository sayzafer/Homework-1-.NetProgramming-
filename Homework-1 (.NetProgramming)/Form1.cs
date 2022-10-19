using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1__.NetProgramming_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customer> customers = new List<Customer>();
        List<Employee> employees = new List<Employee>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clearTxtBox()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            bool checkID = false;
            bool checkName = false;
            bool checlLastName = false;

            Customer customer = new Customer();
            customer.ID = Convert.ToInt16(txtID.Text);
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Address = txtAddress.Text;

            if (customer.FirstName != "")
            {
                checkName = true;
            }


            if (customer.LastName != "")
            {
                checlLastName = true;
            }

            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == customer.ID)
                {
                    checkID = true;
                    break;
                }
            }

            if (checkID == false && checkName == true && checlLastName == true)
            {
                customers.Add(customer);
                cboxCustID.Items.Add(customer.ID);
                clearTxtBox();
            }
            else
            {
                MessageBox.Show("Please check the id information or leave no free space!!!");
            }
        }

        private void btnListCust_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in customers)
                listBox1.Items.Add(x.FirstName + " " + x.LastName);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            bool checkID = false;
            bool checkName = false;
            bool checkLastName = false;

            Employee employee = new Employee();
            employee.ID = Convert.ToInt16(txtID.Text);
            employee.FirstName = txtFirstName.Text;
            employee.LastName = txtLastName.Text;
            employee.Address = txtAddress.Text;

            if (employee.FirstName != "")
            {
                checkName = true;
            }

            if (employee.LastName != "")
            {
                checkLastName = true;
            }

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].ID == employee.ID)
                {
                    checkID = true;
                    break;
                }
            }

            if (checkID == false && checkName == true && checkLastName == true)
            {
                employees.Add(employee);
                cboxEmpID.Items.Add(employee.ID);
                clearTxtBox();
            }
            else
            {
                MessageBox.Show("Please check the id information or leave no free space!!!");
            }
        }

        private void btnListEmp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (IPerson x in employees)
                listBox1.Items.Add(x.FirstName + " " + x.LastName);
        }

        private void cboxCustID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int selectedIndex = cboxCustID.SelectedIndex;
            listBox1.Items.Add(customers[selectedIndex].FirstName + " " + customers[selectedIndex].LastName);
        }

        private void btnRemoveCust_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboxCustID.SelectedIndex;
            if (selectedIndex != -1)
            {
                customers.Remove(customers[selectedIndex]);
                cboxCustID.Items.RemoveAt(selectedIndex);
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please select customer ID that is remove!!!");
            }

        }

        private void cboxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int selectedIndex = cboxEmpID.SelectedIndex;
            listBox1.Items.Add(employees[selectedIndex].FirstName + " " + employees[selectedIndex].LastName);
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboxEmpID.SelectedIndex;
            Console.WriteLine(selectedIndex);
            if (selectedIndex != -1)
            {
                employees.Remove(employees[selectedIndex]);
                cboxEmpID.Items.RemoveAt(selectedIndex);
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please select employee ID that is remove!!!");
            }
        }
    }
}