/*
 * File Name: Photo.cs
 * Assignment4 for PROG1815-20S-Sec2-Programming Concepts II
 * 
 * Revision History
 *      Garima Singh, 2020-08-05 : Created
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourContacts
{
    class Photo
    {
        private string imgPath;
        public string ImgPath
        {
            get => imgPath;
            set => imgPath = value;
        }

        private string firstName;
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        private string lastName;
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        private string addressStreet;
        public string AddressStreet
        {
            get => addressStreet;
            set => addressStreet = value;
        }

        private string addressCity;
        public string AddressCity
        {
            get => addressCity;
            set => addressCity = value;
        }

        private string emailAddress;
        public string EmailAddress
        {
            get => emailAddress;
            set => emailAddress = value;
        }

        private string zipCode;
        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        private string province;
        public string Province
        {
            get => province;
            set => province = value;
        }

        private string addressType;
        public string AddressType
        {
            get => addressType;
            set => addressType = value;
        }

        private string emailType;
        public string EmailType
        {
            get => emailType;
            set => emailType = value;
        }

        private string phoneType;
        public string PhoneType
        {
            get => phoneType;
            set => phoneType = value;
        }

        private int indexValue;
        public int IndexValue
        {
            get => indexValue;
            set => indexValue = value;
        }

        private string addNotes;
        public string AddNotes
        {
            get => addNotes;
            set => addNotes = value;
        }

        public Photo(int indexValue, string imagePath, string firstName, string lastName, string addressType, string addressStreet, string addressCity, string province, string zipCode, string emailAddress, string emailType, string phoneNumber, string phoneType, string addNotes)
        {
            IndexValue = indexValue;
            ImgPath = imagePath;
            FirstName = firstName;
            LastName = lastName;
            AddressType = addressType;
            AddressStreet = addressStreet;
            AddressCity = addressCity;
            Province = province;
            ZipCode = zipCode;
            EmailAddress = emailAddress;
            EmailType = emailType;
            PhoneNumber = phoneNumber;
            PhoneType = phoneType;
            AddNotes = addNotes;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}