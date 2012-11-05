using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CAddresses
    {
        private List<CAddress> oAddresses;

        public List<CAddress> Items
        {
            get { return oAddresses; }
            set { oAddresses = value; }
        }

        public int Count()
        {
            return oAddresses.Count;
        }

        public void Add(CAddress oItem)
        {
            oAddresses.Add(oItem);
        }

        public void RemoveAt(int iIndex)
        {
            oAddresses.RemoveAt(iIndex);
        }

        public bool Save()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.Addresses);
                oFile.Delete();

                string sFileContents = string.Empty;
                foreach (CAddress oAddress in oAddresses)
                    sFileContents = sFileContents + oAddress.Id + "|"
                                                  + oAddress.Type.ToString()
                                                  + oAddress.Street
                                                  + oAddress.City
                                                  + oAddress.State
                                                  + oAddress.Zip + "\r\n";

                oFile.Write(sFileContents);
                oFile = null;

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
                CFile oFile = new CFile(Properties.Settings.Default.Addresses);

                // Clear the list
                oAddresses = new List<CAddress>();

                string sContents = oFile.Read();
                string[] sAddresses = Regex.Split(sContents, "\r\n");

                // Cycles through the array and make oAddressType objects
                foreach (string sAddress in sAddresses)
                {
                    if (sAddress.Length > 0)
                    {
                        // Make an AddressType and populate via a custom constructor
                        CAddress oAddress = new CAddress(sAddress);

                        oAddresses.Add(oAddress);
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
                CFile oFile = new CFile(Properties.Settings.Default.AddressesXML);
                oFile.Serialize(oAddresses, typeof(List<CAddress>));
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
                CFile oFile = new CFile(Properties.Settings.Default.AddressesXML);
                oAddresses = (List<CAddress>)oFile.Deserialize(typeof(List<CAddress>));

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MakeAddresses()
        {
            oAddresses = new List<CAddress>();

            oAddresses.Add(new CAddress(1, AddressType.Local, "111 Main St.", "Appleton", "WI", "54957"));

            oAddresses.Add(new CAddress(2, AddressType.Permanent, "1235 North Ave..", "Appleton", "WI", "54957"));
        }
    }
}
