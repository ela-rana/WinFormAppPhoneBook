﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WinFormAppPhoneBook
{
    public partial class Form1 : Form
    {
        ContactBook myContacts = new ContactBook();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myContacts.Contact.Add("allen", new Person("Allen", "Jones", "123-456-2345", "", "234 Baker St, Abcville, GA 24564"));
            myContacts.Contact.Add("james", new Person("James", "Bond", "245-996-2555", "", "007 Action Lane, Secret Service City, UK 4857693"));
            myContacts.Contact.Add("darth", new Person("Darth", "Vader", "435-456-5345", "435-354-5643", "5648 Star Wars Ave, The Empire, TT 34265"));
            myContacts.Contact.Add("joe h.", new Person("Joe H.","Roberts", "735-456-5345", "295-354-5643", "11 Mulberry Ave, The Empire, TT 34285"));
            dtGrdContacts.DataSource = myContacts.Contact.Values.ToList();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            List<Person> searchResults = new List<Person>();
            foreach(var c in myContacts.Contact)
            {
                if(c.Key.Contains(txtbxSearchName.Text.ToLower()))
                {
                    searchResults.Add(c.Value);
                }
            }
            if(searchResults.Count<1)
            {
                MessageBox.Show("The first name you entered is not in the contact book");
            }
            else
            {
                dtGrdContacts.DataSource = null;
                dtGrdContacts.DataSource = searchResults;
                grpDisplayContact.Text = "Contacts Display  (Currently displaying search results only. Please click Display All Contacts button if you want to see all contacts)";

            }
            txtbxSearchName.Clear();
            btnSearchContact.Enabled = false;
        }

        private void btnDisplayAllContacts_Click(object sender, EventArgs e)
        {
            dtGrdContacts.DataSource = null;
            dtGrdContacts.DataSource = myContacts.Contact.Values.ToList();
            grpDisplayContact.Text = "Contacts Display   (Currently displaying all contacts)";
        }

        private void txtbxSearchName_TextChanged(object sender, EventArgs e)
        {
            btnSearchContact.Enabled = true;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (txtbxFirstName.Text!=String.Empty) 
            {
                if (myContacts.Contact.ContainsKey(txtbxFirstName.Text.ToLower()))
                {
                    MessageBox.Show(
                    "You already have a contact with that first name. Cannot have multiple contacts with same name.\nPlease add a number or middle initial after the name in First Name field"
                    );
                }
                else
                {
                    string key = txtbxFirstName.Text.ToLower();
                    myContacts.Contact.Add(key, new Person(txtbxFirstName.Text,txtbxLastName.Text,txtbxCellPhone.Text,txtbxHomePhone.Text,txtbxAddress.Text));
                    MessageBox.Show("Record has been added");
                    RefreshAll();
                }
            }
            else
            {
                MessageBox.Show("First Name field cannot be empty");
            }
        }

        public void RefreshAll()
        {
            txtbxFirstName.Clear();
            txtbxLastName.Clear();
            txtbxCellPhone.Clear();
            txtbxHomePhone.Clear();
            txtbxAddress.Clear();
            dtGrdContacts.DataSource = null;
            dtGrdContacts.DataSource = myContacts.Contact.Values.ToList();
        }
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (dtGrdContacts.RowCount < 1)
            {
                MessageBox.Show("There is nothing available to delete");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete: ", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    myContacts.Contact.Remove(dtGrdContacts.CurrentRow.Cells[0].Value.ToString().ToLower());
                    dtGrdContacts.DataSource = null;
                    dtGrdContacts.DataSource = myContacts.Contact.Values.ToList();
                }
            }
        }
    }
}
