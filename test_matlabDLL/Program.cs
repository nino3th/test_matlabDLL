/*
 *  LiteON-ModuleTeam RF-Chamber Matlab_OnNet DLL.
 *  
 *  Copyright (c)  NinoLiu\LiteON , Inc 2012
 * 
 *  Description:
 *         Base on Matlab_OnNet.dll to simulate integration Test 
 * 
 * ======================================================================================================
 * History
 * ----------------------------------------------------------------------------------------------------
 * 20120607  | NinoLiu  | 1.0.0  | Integration Test 
 * ----------------------------------------------------------------------------------------------------
 * ======================================================================================================
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Matlab_OnNet;
//using Matlab_DLL;
using System.IO;

namespace test_matlabDLL
{
    class Program
    {
        static void Main(string[] args)
        {
            string SheetName1 = "Cells$";
            string SheetName2 = "CH-35$";
            string SheetName3 = "CH-975$";
            string SheetName4 = "CH-124$";
            string SheetName5 = "CH-885-Really$";
            string SheetName6 = "CH-699-Really$";
            string SheetName7 = "CH-512-Really$";
            string SheetName8 = "CCC$";

            string FILE_NAME1 = "D:\\Project\\Chamber\\Data\\TIS_Chain_1_Antenna_7.xls";
            string FILE_NAME2 = "D:\\Project\\Chamber\\Data\\example\\TRP_3D_2007_03_03_17-14-27\\result.xls";
            string FILE_NAME3 = "D:\\Project\\Chamber\\Data\\example\\TIS_3D_2007_03_05_13-04-31\\result.xls";
            string FILE_NAME4 = "D:\\Project\\Chamber\\Data\\AAAA.xlsx";
            string str = "Horizontal Polarization";

            Matlab_OnNet.matlab_plot matlab = new Matlab_OnNet.matlab_plot();

            matlab.matlab_set();
            matlab.Data_plot(FILE_NAME1, SheetName1, str);
            
            matlab.Data_plot(FILE_NAME2, SheetName2, str);
            matlab.Data_plot(FILE_NAME2, SheetName3, str);
            matlab.Data_plot(FILE_NAME2, SheetName4, str);
    
            matlab.Data_plot(FILE_NAME3, SheetName5, str);
            matlab.Data_plot(FILE_NAME3, SheetName6, str);
            matlab.Data_plot(FILE_NAME3, SheetName7, str);
            matlab.Data_plot(FILE_NAME4, SheetName8, str);

        
            for (; ; ) ;
        }
    }
}
