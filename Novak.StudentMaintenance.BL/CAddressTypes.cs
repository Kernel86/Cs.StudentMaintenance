using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CAddressTypes : CollectionBase
    {
        private List<CAddressType> oAddressTypes;

        public List<CAddressType> AddressTypes
        {
            get { return oAddressTypes; }
            set { oAddressTypes = value; }
        }

        public new int Count()
        {
            return oAddressTypes.Count;
        }

        public void Add(CAddressType oItem)
        {
            oAddressTypes.Add(oItem);
        }

        public new void RemoveAt(int iIndex)
        {
            oAddressTypes.RemoveAt(iIndex);
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
                oFile.Delete();
                oFile = null;

                TextWriter oTextWriter = new StreamWriter(Properties.Settings.Default.FileNameXML);
                XmlSerializer oSerializer = new XmlSerializer(typeof(List<CAddressType>));
                oSerializer.Serialize(oTextWriter, oAddressTypes);

                oTextWriter.Close();
                oTextWriter.Dispose();
                oTextWriter = null;
                oSerializer = null;

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
