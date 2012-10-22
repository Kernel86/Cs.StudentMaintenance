using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Novak.StudentMaintenance.BL
{
    public class CAddressType
    {
    // Private Properties
        private int _id;
        private string _description;

    // Public Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

    // Constructors
        public CAddressType()
        {

        }

        public CAddressType(string sAddressTypeRecord)
        {
            string[] sAddressType = sAddressTypeRecord.Split('|');

            _id = int.Parse(sAddressType[0]);
            _description = sAddressType[1];
        }

        public CAddressType(int iId, string sDescription)
        {
            _id = iId;
            _description = sDescription;
        }
    }
}
