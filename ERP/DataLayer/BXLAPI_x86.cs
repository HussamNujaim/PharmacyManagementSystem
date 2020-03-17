using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace ERP
{
    class BXLAPI_x86
    {
        //////////////////////////////////////////////////////////////////////
        //  Function List
        [DllImport("BXLPDC.dll")]
        public static extern bool ConnectPrinter(string szPrinterName);
        [DllImport("BXLPDC.dll")]
        public static extern void DisconnectPrinter();
        [DllImport("BXLPDC.dll")]
        public static extern bool Start_Doc(string szDocName);
        [DllImport("BXLPDC.dll")]
        public static extern void End_Doc();
        [DllImport("BXLPDC.dll")]
        public static extern bool Start_Page();
        [DllImport("BXLPDC.dll")]
        public static extern void End_Page();
        [DllImport("BXLPDC.dll")]
        public static extern int PrintDeviceFont(int nPositionX, int nPositionY,
                                                  string szFontName, int nFontSize, string szData);
        [DllImport("BXLPDC.dll")]
        public static extern int PrintTrueFont(int nPositionX, int nPositionY,
                                                string szFontName, int nFontSize, string szData,
                                                bool bBold, int nRotation, bool bItalic, bool bUnderline);
        [DllImport("BXLPDC.dll")]
        public static extern int PrintBitmap(int nPositionX, int nPositionY, string bitmapFile);
    }
}
