﻿using System;
using System.Data.SqlClient;
using System.Linq;
using PRPJECT4NEW.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Data;
using System.Windows.Forms;


namespace PRPJECT4NEW.Classes
{
     public class PersonStuff
    {
        protected string ID;
        protected string Fname;
        protected string Lname;
        protected string Telephone;
        protected string Email;
        protected string Password;
        protected string Permission;


        public PersonStuff()
        {
            //SqlConnection sqlcon = General.ConnectToSql();
            //SqlCommand cmd = new SqlCommand("select * from person where ID='" + id + "'", sqlcon);
          //  SqlDataReader dr = cmd.ExecuteReader();
         //   if (dr.Read() == true)
           // {
                ID = "1234567890";
                Fname = "tempo";
                Lname = "temporary";
                Telephone = "0000";
                Email = "temporary@gmail.com";
                Password = "1234";
                Permission = "student";
            //}

        }

        
        public PersonStuff(string id)
        {
            SqlConnection sqlcon = General.ConnectToSql();
            SqlCommand cmd = new SqlCommand("select * from person where ID='"+id+"'", sqlcon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                ID = dr[0].ToString();
                Fname= dr[1].ToString();
                Lname = dr[2].ToString();
                Telephone = dr[3].ToString();
                Email = dr[4].ToString();
                Password = dr[5].ToString();
                Permission = dr[6].ToString();
            }

        }

        public string getID() { return ID; }
        private bool setID(string value) {
            bool allDigits = value.All(char.IsDigit);
            if (value.Length != 9 || allDigits == false){
                return false;
            }
            ID = value;
            return true;
         }
        public string getFname() { return Fname; }
        public bool setFname(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            if (value.Length > 12)
                return false;
            Fname = value;
            return true;
        }
        public string getLname() { return Lname; }
        public bool setLname(string value)
        {
            foreach (char c in value)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            if (value.Length > 12)
                return false;
            Lname = value;
            return true;
        }
        public string getTelephone() { return Telephone; }
        public bool setPhone(string value){
            bool allDigits = value.All(char.IsDigit);
            if (value.Length != 10 || allDigits == false)
                return false;
            Telephone = value;
            return true;
        }
        public string getEmail() { return Email; }
        public bool setEmail(string value)
        {
            bool invalid = false;
            if (String.IsNullOrEmpty(value))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                value = Regex.Replace(value, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(value,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public string getPassword() { return Password; }
        public bool setPassword(string value)
        {
            if (value.Length > 12)
                return false;
            Password = value;
            return true;
        }
        public string getPermission() { return Permission; }
        public bool setPermission(string value)
        { string[] perm = { "Teaching_Assistant", "Secretary", "Admin", "Lecturer", "Student", "Tech_Team", "Dean_of_Faculty", "Exam_Section" };
            foreach (string x in perm) { 
            if (value.Contains(x))
            { Permission = value;
                return true;
            }
           }
            return false;

        }

        public bool updatesql()
        {
            SqlConnection sqlcon = General.ConnectToSql();
            if (sqlcon == null)
            {
                return false;

            }
            try {
                SqlCommand cmd = new SqlCommand("UPDATE Person SET F_name='"+Fname+"'and L_name='"+Lname+"'and Telephone='"+Telephone+"'and Email='"+Email+"'and Password='"+Password+"'Permission='"+Permission+"' where ID='"+ID+"'", sqlcon);
                //SqlDataAdapter sda = new SqlDataAdapter();
                //sda.SelectCommand = cmd;
                //DataTable dbdataset = new DataTable();
                //sda.Fill(dbdataset);
                return true;

            }
            catch (Exception ex)
            {
                return false;
#pragma warning disable CS0162 // Unreachable code detected
                Console.WriteLine(ex.ToString());
#pragma warning restore CS0162 // Unreachable code detected
            }
        

        }
        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                // invalid = true;
            }

            return match.Groups[1].Value + domainName;
        }

    }
}
