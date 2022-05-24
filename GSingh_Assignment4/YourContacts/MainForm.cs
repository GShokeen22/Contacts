/*
 * File Name: MainForm.cs
 * Assignment4 for PROG1815-20S-Sec2-Programming Concepts II
 * 
 * Revision History
 *      Garima Singh, 2020-08-05 : Created
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourContacts
{
    public partial class MainForm : Form
    {
        string fileName = "AllContacts.txt";  //Main file
        string temporaryFileName = "TemporaryAllContacts.txt";  //Temporary file created only while editing and is then deleted
        public MainForm()
        {
            InitializeComponent();
        }

        BindingList<Photo> newPhotos = new BindingList<Photo>();  //Binding list of type 'Photo'

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string savedFileData = reader.ReadLine();
                    string[] wordForSplittingString = savedFileData.Split('|');

                    lstContacts.Items.Add($"{wordForSplittingString[2]} {wordForSplittingString[3]}");
                }
            }

            picContact.Enabled = false;

            txtFirstName.Enabled = false;
            lblFirstName.Enabled = false;

            txtLastName.Enabled = false;
            lblLastName.Enabled = false;

            btnEditContact.Enabled = false;

            grbAddress.Enabled = false;

            grbEmail.Enabled = false;

            grbPhone.Enabled = false;
            
            grbTakeANote.Enabled = false;
            
            grbNotes.Enabled = false;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContact = new AddContactForm();
            if (addContact.ShowDialog(this) == DialogResult.OK)
            { }
            txtNotes.Text = "";            
        }

        /// <summary>
        /// Makes a new object of type 'Photo', and sends and sets its corresponding values
        /// </summary>
        /// <param name="indexValue"></param>
        /// <param name="imagePath"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="addressType"></param>
        /// <param name="addressStreet"></param>
        /// <param name="addressCity"></param>
        /// <param name="province"></param>
        /// <param name="zipCode"></param>
        /// <param name="emailAddress"></param>
        /// <param name="emailType"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="phoneType"></param>
        /// <param name="addNotes"></param>
        public void SetValues(int indexValue, string imagePath, string firstName, string lastName, string addressType, string addressStreet, string addressCity, string province, string zipCode, string emailAddress, string emailType, string phoneNumber, string phoneType, string addNotes)
        {
            Photo newpic = new Photo(indexValue, imagePath, firstName, lastName, addressType, addressStreet, addressCity, province, zipCode, emailAddress, emailType, phoneNumber, phoneType, addNotes);

            newpic.IndexValue = indexValue; 
            newpic.ImgPath = imagePath;
            newpic.FirstName = firstName;
            newpic.LastName = lastName;
            newpic.AddressType = addressType;
            newpic.AddressStreet = addressStreet;
            newpic.AddressCity = addressCity;
            newpic.Province = province;
            newpic.ZipCode = zipCode;
            newpic.EmailAddress = emailAddress;
            newpic.EmailType = emailType;
            newpic.PhoneNumber = phoneNumber;
            newpic.PhoneType = phoneType;
            newpic.AddNotes = addNotes;

            lstContacts.Items.Add($"{newpic}");
            newPhotos.Add(newpic);
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1)
            {
                int index = lstContacts.SelectedIndex;
                txtNotes.Text = "";

                picContact.Enabled = true;

                txtFirstName.Enabled = true;
                lblFirstName.Enabled = true;

                txtLastName.Enabled = true;
                lblLastName.Enabled = true;

                btnEditContact.Enabled = true;

                grbAddress.Enabled = true;

                grbEmail.Enabled = true;

                grbPhone.Enabled = true;

                grbTakeANote.Enabled = true;

                grbNotes.Enabled = true;

                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (reader.EndOfStream == false)
                    {
                        string savedFileData = reader.ReadLine();
                        string[] wordForSplittingString = savedFileData.Split('|');
                        
                        if (index.ToString() == wordForSplittingString[0])
                        {
                            int i = 0;
                            while (wordForSplittingString != null)
                            {
                                if (i == 0)
                                { }
                                else if (i == 1)
                                {
                                    picContact.ImageLocation = wordForSplittingString[i];
                                }
                                else if (i == 2)
                                {
                                    txtFirstName.Text = wordForSplittingString[i];
                                }
                                else if (i == 3)
                                {
                                    txtLastName.Text = wordForSplittingString[i];
                                }
                                else if (i == 4)
                                {
                                    txtAddressType.Text = wordForSplittingString[i];
                                }
                                else if (i == 5)
                                {
                                    txtStreet.Text = wordForSplittingString[i];
                                }
                                else if (i == 6)
                                {
                                    txtCity.Text = wordForSplittingString[i];
                                }
                                else if (i == 7)
                                {
                                    txtProvince.Text = wordForSplittingString[i];
                                }
                                else if (i == 8)
                                {
                                    txtZip.Text = wordForSplittingString[i];
                                }
                                else if (i == 9)
                                {
                                    txtEmail.Text = wordForSplittingString[i];
                                }
                                else if (i == 10)
                                {
                                    txtEmailType.Text = wordForSplittingString[i];
                                }
                                else if (i == 11)
                                {
                                    txtPhone.Text = wordForSplittingString[i];
                                }
                                else if (i == 12)
                                {
                                    txtPhoneType.Text = wordForSplittingString[i];
                                }
                                else if (i == 13)
                                {
                                    if (wordForSplittingString[i] != "")
                                    {
                                        txtNotes.Text = "";
                                        string wordForNotesText = wordForSplittingString[i];
                                        string[] wordsToPrintInNotesTextBox = wordForNotesText.Split('~');
                                        int numberOfWordsForNotesText = wordsToPrintInNotesTextBox.Length;

                                        for (int j = numberOfWordsForNotesText-1; j >= 0; j--)
                                        {
                                            if (j % 2 == 0)
                                            {
                                                txtNotes.Text += wordsToPrintInNotesTextBox[j] + Environment.NewLine;
                                            }
                                            if (j % 2 != 0)
                                            {
                                                txtNotes.Text += wordsToPrintInNotesTextBox[j] + Environment.NewLine;
                                            }
                                        }
                                    }
                                }

                                else
                                {
                                    break;
                                }
                                i++;
                            }
                        }
                    }
                }                
            }
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContact = new AddContactForm();
            if (lstContacts.SelectedIndex != -1)
            {
                int contactListSelectedIndex = lstContacts.SelectedIndex;
                addContact.methodForEditing(contactListSelectedIndex);
                addContact.ShowDialog(this);
                lstContacts.Items.Clear();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string savedFileData = reader.ReadLine();
                        string[] wordForSplittingString = savedFileData.Split('|');
                        
                        lstContacts.Items.Add($"{wordForSplittingString[2]} {wordForSplittingString[3]}");
                    }
                }
                lstContacts.SetSelected(contactListSelectedIndex, true);
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (reader.EndOfStream == false)
                    {
                        string savedFileData = reader.ReadLine();
                        string[] wordForSplittingString = savedFileData.Split('|');

                        if (contactListSelectedIndex.ToString() == wordForSplittingString[0])
                        {
                            int i = 0;
                            while (wordForSplittingString != null)
                            {
                                if (i == 1)
                                {
                                    picContact.ImageLocation = wordForSplittingString[i];
                                }
                                else if (i == 2)
                                {
                                    txtFirstName.Text = wordForSplittingString[i];
                                }
                                else if (i == 3)
                                {
                                    txtLastName.Text = wordForSplittingString[i];
                                }
                                else if (i == 4)
                                {
                                    txtAddressType.Text = wordForSplittingString[i];
                                }
                                else if (i == 5)
                                {
                                    txtStreet.Text = wordForSplittingString[i];
                                }
                                else if (i == 6)
                                {
                                    txtCity.Text = wordForSplittingString[i];
                                }
                                else if (i == 7)
                                {
                                    txtProvince.Text = wordForSplittingString[i];
                                }
                                else if (i == 8)
                                {
                                    txtZip.Text = wordForSplittingString[i];
                                }
                                else if (i == 9)
                                {
                                    txtEmail.Text = wordForSplittingString[i];
                                }
                                else if (i == 10)
                                {
                                    txtEmailType.Text = wordForSplittingString[i];
                                }
                                else if (i == 11)
                                {
                                    txtPhone.Text = wordForSplittingString[i];
                                }
                                else if (i == 12)
                                {
                                    txtPhoneType.Text = wordForSplittingString[i];
                                }
                                else if (i == 13)
                                { }

                                else
                                {
                                    break;
                                }

                                i++;
                            }
                        }
                    }
                }
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedIndex != -1 && txtTakeANote.Text != "")
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (reader.EndOfStream == false)
                    {
                        string savedFileData = reader.ReadLine();
                        string[] wordForSplittingString = savedFileData.Split('|');

                        if (lstContacts.SelectedIndex.ToString() != wordForSplittingString[0])
                        {
                            using (StreamWriter writer = File.AppendText(temporaryFileName))
                            {
                                writer.WriteLine(savedFileData);
                            }
                        }

                        else if (lstContacts.SelectedIndex.ToString() == wordForSplittingString[0])
                        {
                            DateTime currentDateTime = DateTime.Now;
                            
                            wordForSplittingString[13] += txtTakeANote.Text + "~" + currentDateTime.ToString() + "~";

                            using (StreamWriter writer = File.AppendText(temporaryFileName))
                            {
                                writer.WriteLine($"{wordForSplittingString[0]}|{wordForSplittingString[1]}|{wordForSplittingString[2]}|{wordForSplittingString[3]}|{wordForSplittingString[4]}|{wordForSplittingString[5]}|{wordForSplittingString[6]}|{wordForSplittingString[7]}|{wordForSplittingString[8]}|{wordForSplittingString[9]}|{wordForSplittingString[10]}|{wordForSplittingString[11]}|{wordForSplittingString[12]}|{wordForSplittingString[13]}");
                            }

                            txtNotes.Text = "";
                            string wordForNotesText = wordForSplittingString[13];
                            string[] wordsToPrintInNotesTextBox = wordForNotesText.Split('~');
                            int numberOfWordsForNotesText = wordsToPrintInNotesTextBox.Length;

                            for (int j = numberOfWordsForNotesText - 1; j >= 0; j--)
                            {
                                if (j % 2 == 0)
                                {
                                    txtNotes.Text += wordsToPrintInNotesTextBox[j] + Environment.NewLine;
                                }
                                if (j % 2 != 0)
                                {
                                    txtNotes.Text += wordsToPrintInNotesTextBox[j] + Environment.NewLine;
                                }
                            }
                        }
                    }
                }
                File.Delete(fileName);
                File.Move(temporaryFileName, fileName);
                txtTakeANote.Clear();
            }
        }
    }
}