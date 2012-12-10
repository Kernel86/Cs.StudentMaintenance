using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Novak.StudentMaintenance.Utilities.Excel;
using Novak.StudentMaintenance.Utilities.PL;

namespace Novak.StudentMaintenance.BL
{
    public class CStudents
    {
        private List<CStudent> oStudents;

        public List<CStudent> Items
        {
            get { return oStudents; }
            set { oStudents = value; }
        }

        public int Count
        {
            get { return oStudents.Count; }
        }

        public CStudent this[int index]
        {
            get { return Items[index]; }
            set { Items[index] = value; }
        }

        public void Add(CStudent oItem)
        {
            oStudents.Add(oItem);
        }

        public void RemoveAt(int iIndex)
        {
            oStudents.RemoveAt(iIndex);
        }

        public bool Export()
        {
            try
            {
                int count = this.Count;

                string[,] oArrayStudents = new string[count, 3];

                // Fill the array
                for (int iCnt = 0; iCnt < count; iCnt++)
                {
                    CStudent oStudent = this[iCnt];
                    oArrayStudents[iCnt, 0] = oStudent.Firstname;
                    oArrayStudents[iCnt, 1] = oStudent.Lastname;
                    oArrayStudents[iCnt, 3] = oStudent.Gpa.ToString();
                }

                // Call the export
                Novak.StudentMaintenance.Utilities.Excel.CExcel.Export(oArrayStudents);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveStudents()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.StudentsXML);
                oFile.Serialize(oStudents, typeof(List<CStudent>));
                oFile = null;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool LoadStudents()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.StudentsXML);
                oStudents = (List<CStudent>)oFile.Deserialize(typeof(List<CStudent>));
                oFile = null;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MakeStudents()
        {
            oStudents = new List<CStudent>();

            CAddresses oAddresses = new CAddresses();
            oAddresses.MakeAddresses();
            oStudents.Add(new CStudent("1", "234623811", 3.9, "Shawn", "Novak", oAddresses));

            oStudents.Add(new CStudent("2", "235784522", 2.7, "Bill", "Blargh", oAddresses));
        }
    }
}
