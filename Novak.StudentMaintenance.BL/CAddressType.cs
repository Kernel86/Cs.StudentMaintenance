using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Novak.StudentMaintenance.Utilities.PL;

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

        public CAddressType(DataRow oDR)
        {
            _id = (int)oDR["Id"];
            _description = (string)oDR["Description"];
        }

        public int Delete()
        {
            try
            {
                CDataAccess oCD = new CDataAccess();
                string sCommand = "DELETE FROM tblAddressType WHERE id =" + this.Id;
                int iRows = oCD.Delete(sCommand);
                oCD = null;
                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update()
        {
            try
            {
                CDataAccess oCD = new CDataAccess();
                string sCommand = "UPDATE tblAddressType VALUES(" + this.Description + ") WHERE id =" + this.Id;
                int iRows = oCD.Update(sCommand);
                oCD = null;
                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
