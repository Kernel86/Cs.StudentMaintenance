using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Novak.StudentMaintenance.Utilities.PL;
namespace Novak.StudentMaintenance.BL
{
    class CStudents
    {
        private List<CStudent> oStudents;

        public List<CStudent> Items
        {
            get { return oStudents; }
            set { oStudents = value; }
        }

        public int Count()
        {
            return oStudents.Count;
        }

        public void Add(CStudent oItem)
        {
            oStudents.Add(oItem);
        }

        public void RemoveAt(int iIndex)
        {
            oStudents.RemoveAt(iIndex);
        }

        public bool SaveXML()
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

        public bool LoadXML()
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

        public void MakeAddresss()
        {
            oStudents = new List<CStudent>();

            oStudents.Add(new CStudent("1", 3.9));

            oStudents.Add(new CStudent("2", 2.7));
        }
    }
}
