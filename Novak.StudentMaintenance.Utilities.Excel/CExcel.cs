using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;

namespace Novak.StudentMaintenance.Utilities.Excel
{
    public class CExcel
    {
        public static void Export(string[,] oStuff)
        {
            try
            {
                Excel.Application xlApp;
                Excel.Workbook xlWB;
                Excel.Worksheet xlWS;
                object misValue = System.Reflection.Missing.Value;

                // Create new isntances
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(misValue);
                xlWS = (Excel.Worksheet)xlWB.Sheets["Sheet1"];

                // Look through array and set cells contents
                int i, j;
                for (i = 0; i < oStuff.GetLength(0); i++)
                {
                    for (j = 0; j < oStuff.GetLength(1); j++)
                    {
                        xlWS.Cells[i + 1, j + 1] = oStuff[i, j];
                    }
                }

                xlWS.SaveAs("Stuff.xlsx");

                xlWB.Close();
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWB);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWS);

                xlApp = xlWB = xlWS = null;

                // Tell the Garbage Collector to collect garbage
                GC.Collect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
