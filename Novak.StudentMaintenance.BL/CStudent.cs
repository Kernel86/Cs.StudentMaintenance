using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CStudent : CPerson
    {
        CAddresses _oAddresses;
        private double _gpa;

    // Public Properties
        public CAddresses Addresses
        {
            get { return _oAddresses; }
            set { _oAddresses = value; }
        }

        public new string Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        public double Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }
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
    }
}
