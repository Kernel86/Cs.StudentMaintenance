using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Novak.StudentMaintenance.Interfaces;
using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CStudent : CPerson, IStudent
    {
        CAddresses _oAddresses;
        private double _gpa;
        private string _studentId;

    // Public Properties
        public CAddresses Addresses
        {
            get { return _oAddresses; }
            set { _oAddresses = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        public string StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

    // Public Constructors
        public CStudent()
        {

        }

        public CStudent(string id, double gpa)
        {
            this.Id = id;
            _gpa = gpa;
        }

        public CStudent(string id, string studentid, double gpa, string firstname, string lastname, CAddresses oAddresses)
        {
            this.Id = id;
            _studentId = studentid;
            _gpa = gpa;
            base.Firstname = firstname;
            base.Lastname = lastname;
            _oAddresses = oAddresses;
        }

    // Public Methods
        public void MakeStudent()
        {
            _oAddresses = new CAddresses();
            this.Id = "1";
            this.Gpa = 3.45;
            this.Firstname = "Shawn";
            this.Lastname = "Novak";

            _oAddresses.MakeAddresses();
        }

        public void SaveStudent()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.StudentXML);
                oFile.Serialize(this, typeof(CStudent));
                oFile = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void LoadStudent()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.StudentXML);
                CStudent oStudent = (CStudent)oFile.Deserialize(typeof(CStudent));
                oFile = null;

                this.Id = oStudent.Id;
                this.Gpa = oStudent.Gpa;
                this.Addresses = oStudent.Addresses;
                this.Firstname = oStudent.Firstname;
                this.Lastname = oStudent.Lastname;
                oStudent = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Enroll()
        {
            throw new NotImplementedException();
        }
    }
}
