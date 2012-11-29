using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CAddressTypes
    {
        private List<CAddressType> oAddressTypes;

        public List<CAddressType> AddressTypes
        {
            get { return oAddressTypes; }
            set { oAddressTypes = value; }
        }

        public int Count()
        {
            return oAddressTypes.Count;
        }

        public void Add(CAddressType oItem)
        {
            oAddressTypes.Add(oItem);
        }

        public void RemoveAt(int iIndex)
        {
            oAddressTypes.RemoveAt(iIndex);
        }

        public int Delete()
        {
            try
            {
                CDataAccess oCD = new CDataAccess();
                string sCommand = "DELETE FROM tblAddressType";
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

                foreach (CAddressType oAddressType in this.AddressTypes)
                {
                    oCD.Update("UPDATE tblAddressType VALUES(" + this.Description + ") WHERE id =" + oAddressType.Id);
                }
                string sCommand = "DELETE FROM tblAddressType";
                int iRows = oCD.Update(sCommand);
                oCD = null;
                return iRows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Save()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.FileName);
                oFile.Delete();

                string sFileContents = string.Empty;
                foreach (CAddressType oAddressType in oAddressTypes)
                    sFileContents = sFileContents + oAddressType.Id + "|" + oAddressType.Description + "\r\n";

                oFile.Write(sFileContents);
                oFile = null;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetData()
        {
            try
            {
                oAddressTypes = new List<CAddressType>();
                CDataAccess oCD = new CDataAccess();
                DataTable odtAddressTypes = oCD.GetData("SELECT * FROM tblAddressType");

                foreach (DataRow oDR in odtAddressTypes.Rows)
                {
                    CAddressType oAddressType = new CAddressType(oDR);
                    Add(oAddressType);
                }

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Load()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.FileName);

                // Clear the list
                oAddressTypes = new List<CAddressType>();

                string sContents = oFile.Read();
                string[] sAddressTypes = Regex.Split(sContents, "\r\n");

                // Cycles through the array and make oAddressType objects
                foreach (string sAddressType in sAddressTypes)
                {
                    if (sAddressType.Length > 0)
                    {
                        // Make an AddressType and populate via a custom constructor
                        CAddressType oAddressType = new CAddressType(sAddressType);

                        oAddressTypes.Add(oAddressType);
                    }
                }

                oFile.Close();
                oFile = null;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveXML()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.FileNameXML);
                oFile.Serialize(oAddressTypes, typeof(List<CAddressType>));
                oFile = null;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LoadXML()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.FileNameXML);
                oAddressTypes = (List<CAddressType>)oFile.Deserialize(typeof(List<CAddressType>));

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MakeAddressTypes()
        {
            oAddressTypes = new List<CAddressType>();

            oAddressTypes.Add(new CAddressType(1, "Local"));

            oAddressTypes.Add(new CAddressType(2, "Permanent"));
        }
    }
}
