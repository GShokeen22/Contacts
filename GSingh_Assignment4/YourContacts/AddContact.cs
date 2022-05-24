/*
 * File Name: AddContact.cs
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
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YourContacts
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        string imageFilePath = "D:\\Sem2\\C#_Sem2\\Assignments\\GSingh_Assignment4\\YourContacts\\bin\\Debug\\Screenshot.png";
        string fileName = "AllContacts.txt";
        string temporaryFileName = "TemporaryAllContacts.txt";
        public static int indexValue = 0;
        int globalVariableContactListSelectedIndex = 0;
        int variableForEditing = 0;

        private void btnSecondaryFormAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Image Files (*.jpeg;*.jpg;*.bmp;*.gif)|*.jpeg;*.jpg;*.bmp;*.gif";
            OpenFileDialog.InitialDirectory = Environment.CurrentDirectory;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileToOpen = OpenFileDialog.FileName;
                imageFilePath = fileToOpen;

                picSecondaryFormContact.ImageLocation = fileToOpen;
            }
        }

        private void btnSecondaryFormSave_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                if (variableForEditing == 0)
                {
                    MainForm mainForm = (MainForm)Owner;

                    string firstName = "";
                    string lastName = "";
                    string addressType = "";
                    string addressStreet = "";
                    string addressCity = "";
                    string province = "";
                    string zipCode = "";
                    string emailAddress = "";
                    string emailType = "";
                    string phoneNumber = "";
                    string phoneType = "";
                    string addNotes = "";


                    //*******************************  Name  *******************************

                    Regex regexName = new Regex(@"[A-Za-z]{2,20}");

                    //1. First Name

                    Match matchFirstName = regexName.Match(txtSecondaryFormFirstName.Text);

                    if (matchFirstName.Success)
                    {
                        firstName = txtSecondaryFormFirstName.Text;
                    }

                    //2. Last Name

                    Match matchLastName = regexName.Match(txtSecondaryFormLastName.Text);

                    if (matchLastName.Success)
                    {
                        lastName = txtSecondaryFormLastName.Text;
                    }

                    if (txtSecondaryFormFirstName.Text == "" || txtSecondaryFormLastName.Text == "")
                    {
                        MessageBox.Show("Please ensure that both the First and Last names are filled.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //*******************************  Address  *******************************

                    //1. Type

                    if (cmbSecondaryFormAddressType.SelectedIndex != -1)
                    {
                        addressType = cmbSecondaryFormAddressType.Items[cmbSecondaryFormAddressType.SelectedIndex].ToString();
                    }

                    //2. Street

                    if (txtSecondaryFormStreet.Text != "")
                    {
                        addressStreet = txtSecondaryFormStreet.Text;
                    }

                    //3. City

                    if (txtSecondaryFormCity.Text != "")
                    {
                        addressCity = txtSecondaryFormCity.Text;
                    }

                    //4. Province

                    if (cmbSecondaryFormProvince.SelectedIndex != -1)
                    {
                        province = cmbSecondaryFormProvince.Items[cmbSecondaryFormProvince.SelectedIndex].ToString();
                    }

                    //5. Zip

                    if (mtxZip.Text != "")
                    {
                        zipCode = mtxZip.Text.ToUpper();
                    }

                    //*******************************  Email  *******************************

                    //1. Email

                    /*Regex regexEmail = new Regex(@"[0-9]*[A-Za-z]*(@)(.+)$");
                    Match matchEmail = regexEmail.Match(txtSecondaryFormEmail.Text);*/

                    if (txtSecondaryFormEmail.Text != "")
                    {
                        emailAddress = txtSecondaryFormEmail.Text;
                    }

                    //2.Type

                    if (cmbSecondaryFormEmailType.SelectedIndex != -1)
                    {
                        emailType = cmbSecondaryFormEmailType.Items[cmbSecondaryFormEmailType.SelectedIndex].ToString();
                    }

                    //*******************************  Phone Number  *******************************

                    //1. Phone Number

                    if (mtxPhoneNumber.Text != "")
                    {
                        phoneNumber = mtxPhoneNumber.Text;
                    }

                    //2. Type

                    if (cmbSecondaryFormPhoneType.SelectedIndex != -1)
                    {
                        phoneType = cmbSecondaryFormPhoneType.Items[cmbSecondaryFormPhoneType.SelectedIndex].ToString();
                    }

                    //*******************************    *******************************

                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        while (reader.EndOfStream == false)
                        {
                            string savedFileData = reader.ReadLine();
                            string[] wordForSplittingString = savedFileData.Split('|');

                            indexValue = int.Parse(wordForSplittingString[0]);
                        }
                    }

                    if (new FileInfo(fileName).Length == 0)
                    { }
                    else
                    {
                        indexValue++;
                    }
                    
                    variableForEditing = 0;

                    if (firstName != "" && lastName != "")
                    {
                        using (StreamWriter writer = File.AppendText(fileName))
                        {
                            writer.WriteLine($"{indexValue}|{imageFilePath}|{firstName}|{lastName}|{addressType}|{addressStreet}|{addressCity}|{province}|{zipCode}|{emailAddress}|{emailType}|{phoneNumber}|{phoneType}|{addNotes}");
                        }
                        this.Close();
                        mainForm.SetValues(indexValue, imageFilePath, firstName, lastName, addressType, addressStreet, addressCity, province, zipCode, emailAddress, emailType, phoneNumber, phoneType, addNotes);
                    }
                }

                else if (variableForEditing == 1)
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        while (reader.EndOfStream == false)
                        {
                            string savedFileData = reader.ReadLine();
                            string[] wordForSplittingString = savedFileData.Split('|');

                            //MessageBox.Show($"{savedFileData}");

                            if (globalVariableContactListSelectedIndex.ToString() != wordForSplittingString[0])
                            {
                                using (StreamWriter writer = File.AppendText(temporaryFileName))
                                {
                                    writer.WriteLine(savedFileData);
                                }
                            }

                            else if (globalVariableContactListSelectedIndex.ToString() == wordForSplittingString[0])
                            {
                                if (picSecondaryFormContact.ImageLocation != wordForSplittingString[1])
                                {
                                    wordForSplittingString[1] = picSecondaryFormContact.ImageLocation;
                                }
                                
                                if (txtSecondaryFormFirstName.Text != wordForSplittingString[2])
                                {
                                    wordForSplittingString[2] = txtSecondaryFormFirstName.Text;
                                }

                                if (txtSecondaryFormLastName.Text != wordForSplittingString[3])
                                {
                                    wordForSplittingString[3] = txtSecondaryFormLastName.Text;
                                }

                                if (cmbSecondaryFormAddressType.Text != wordForSplittingString[4])
                                {
                                    wordForSplittingString[4] = cmbSecondaryFormAddressType.Text;
                                }

                                if (txtSecondaryFormStreet.Text != wordForSplittingString[5])
                                {
                                    wordForSplittingString[5] = txtSecondaryFormStreet.Text;
                                }
                                
                                if (txtSecondaryFormCity.Text != wordForSplittingString[6])
                                {
                                    wordForSplittingString[6] = txtSecondaryFormCity.Text;
                                }
                                
                                if (cmbSecondaryFormProvince.Text != wordForSplittingString[7])
                                {
                                    wordForSplittingString[7] = cmbSecondaryFormProvince.Text;
                                }

                                if (mtxZip.Text != wordForSplittingString[8])
                                {
                                    wordForSplittingString[8] = mtxZip.Text;
                                }

                                if (txtSecondaryFormEmail.Text != wordForSplittingString[9])
                                {
                                    wordForSplittingString[9] = txtSecondaryFormEmail.Text;
                                }

                                if (cmbSecondaryFormEmailType.Text != wordForSplittingString[10])
                                {
                                    wordForSplittingString[10] = cmbSecondaryFormEmailType.Text;
                                }
                                
                                if (mtxPhoneNumber.Text != wordForSplittingString[11])
                                {
                                    wordForSplittingString[11] = mtxPhoneNumber.Text;
                                }

                                if (cmbSecondaryFormPhoneType.Text != wordForSplittingString[12])
                                {
                                    wordForSplittingString[12] = cmbSecondaryFormPhoneType.Text;
                                }

                                using (StreamWriter writer = File.AppendText(temporaryFileName))
                                {
                                    //MessageBox.Show($"{imageFilePath} {wordForSplittingString[1]}");
                                    //MessageBox.Show($"Entered stream writer: {wordsForImageOne[0]}|{wordsForImageOne[1]}|{wordsForImageOne[2]}|{wordsForImageOne[3]}|{wordsForImageOne[4]}|{wordsForImageOne[5]}|{wordsForImageOne[6]}|{wordsForImageOne[7]}|{wordsForImageOne[8]}|{wordsForImageOne[9]}|{wordsForImageOne[10]}|{wordsForImageOne[11]}|{wordsForImageOne[12]}|{wordsForImageOne[13]}");
                                    writer.WriteLine($"{wordForSplittingString[0]}|{wordForSplittingString[1]}|{wordForSplittingString[2]}|{wordForSplittingString[3]}|{wordForSplittingString[4]}|{wordForSplittingString[5]}|{wordForSplittingString[6]}|{wordForSplittingString[7]}|{wordForSplittingString[8]}|{wordForSplittingString[9]}|{wordForSplittingString[10]}|{wordForSplittingString[11]}|{wordForSplittingString[12]}|{wordForSplittingString[13]}");
                                }
                                
                            }
                        }
                    }
                    File.Delete(fileName);
                    File.Move(temporaryFileName, fileName);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Called when button Edit Contact is clicked on the main form. Used to print all the values
        /// of the selected list item into the text boxes of the secondary form named 'AddContact.cs'
        /// </summary>
        /// <param name="contactListSelectedIndex"></param>
        internal void methodForEditing(int contactListSelectedIndex)
        {
            variableForEditing = 1;
            globalVariableContactListSelectedIndex = contactListSelectedIndex;
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
                                picSecondaryFormContact.ImageLocation = wordForSplittingString[i];
                            }
                            else if (i == 2)
                            {
                                txtSecondaryFormFirstName.Text = wordForSplittingString[i];
                            }
                            else if (i == 3)
                            {
                                txtSecondaryFormLastName.Text = wordForSplittingString[i];
                            }
                            else if (i == 4)
                            {
                                cmbSecondaryFormAddressType.Text = wordForSplittingString[i];
                            }
                            else if (i == 5)
                            {
                                txtSecondaryFormStreet.Text = wordForSplittingString[i];
                            }
                            else if (i == 6)
                            {
                                txtSecondaryFormCity.Text = wordForSplittingString[i];
                            }
                            else if (i == 7)
                            {
                                cmbSecondaryFormProvince.Text = wordForSplittingString[i];
                            }
                            else if (i == 8)
                            {
                                mtxZip.Text = wordForSplittingString[i];
                            }
                            else if (i == 9)
                            {
                                txtSecondaryFormEmail.Text = wordForSplittingString[i];
                            }
                            else if (i == 10)
                            {
                                cmbSecondaryFormEmailType.Text = wordForSplittingString[i];
                            }
                            else if (i == 11)
                            {
                                mtxPhoneNumber.Text = wordForSplittingString[i];
                            }
                            else if (i == 12)
                            {
                                cmbSecondaryFormPhoneType.Text = wordForSplittingString[i];
                            }

                            else if (i == 13)
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
}