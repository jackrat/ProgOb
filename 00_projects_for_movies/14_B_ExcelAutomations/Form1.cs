using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

using Excel = Microsoft.Office.Interop.Excel;



namespace ExcelAutomation
{
    public partial class Form1 : Form
    {
        Excel.Application ex;
        object exc2;

        public Form1()
        {
            InitializeComponent();
        }

        private void NewExcel1_Click(object sender, EventArgs e)
        {
            ex = new Excel.Application();
        }

        private void AddWorkBook1_Click(object sender, EventArgs e)
        {
            ex.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
        }

        private void Save1_Click(object sender, EventArgs e)
        {
            ex.ActiveWorkbook.Save();
        }

        private void Visible1_Click(object sender, EventArgs e)
        {
            ex.Visible = !ex.Visible;
        }

        private void OUT1_Click(object sender, EventArgs e)
        {
            while (ex.Workbooks.Count > 0)
                ex.ActiveWorkbook.Close(false, null, null);
            ex.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(ex);
            ex = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void SheetName1_Click(object sender, EventArgs e)
        {
            ex.ActiveSheet.Name = "A kuku";
        }

        private void Open1_Click(object sender, EventArgs e)
        {
            ex.Workbooks.Open(@"E:\lulu.xls", 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, false);
        }

        private void SaveAs1_Click(object sender, EventArgs e)
        {
            string fn = @"E:\lulu_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xls";
            ex.ActiveWorkbook.SaveAs(fn, Excel.XlFileFormat.xlExcel7, null, null, false, false, Excel.XlSaveAsAccessMode.xlNoChange, null, null, null, null);
        }



        private void NewExcel2_Click(object sender, EventArgs e)
        {
            exc2 = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));
        }

        private void Visible2_Click(object sender, EventArgs e)
        {
            object vis = exc2.GetType().InvokeMember("Visible", BindingFlags.GetProperty, null, exc2, null);
            exc2.GetType().InvokeMember("Visible", BindingFlags.SetProperty, null, exc2, new Object[1] { !((bool)vis) });
        }

        private void OUT2_Click(object sender, EventArgs e)
        {
            object excBooks = exc2.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, exc2, null);
            while ((int)excBooks.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, excBooks, null) > 0)
            {
                object excActBook = exc2.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc2, null);
                excActBook.GetType().InvokeMember("Close", BindingFlags.InvokeMethod, null, excActBook, new object[3] { false, null, null });
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excBooks);
            excBooks = null;

            exc2.GetType().InvokeMember("Quit", BindingFlags.InvokeMethod, null, exc2, null);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exc2);
            exc2 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void AddWorkbook2_Click(object sender, EventArgs e)
        {
            object exc2Books = exc2.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, exc2, null);
            exc2Books.GetType().InvokeMember("Add", BindingFlags.InvokeMethod, null, exc2Books, null);
        }

        private void SheetName2_Click(object sender, EventArgs e)
        {
            object actSheet = exc2.GetType().InvokeMember("ActiveSheet", BindingFlags.GetProperty, null, exc2, null);
            actSheet.GetType().InvokeMember("Name", BindingFlags.SetProperty, null, actSheet, new object[1] { "A kuku" });
        }

        private void Open2_Click(object sender, EventArgs e)
        {
            object exc2Books = exc2.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, exc2, null);
            exc2Books.GetType().InvokeMember("Open", BindingFlags.InvokeMethod, null, exc2Books, new object[1] { @"e:\lulu.xls" });
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            object exc2ActBook = exc2.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc2, null);
            exc2ActBook.GetType().InvokeMember("Save", BindingFlags.InvokeMethod, null, exc2ActBook, null);
        }

        private void SaveAs2_Click(object sender, EventArgs e)
        {
            object exc2ActBook = exc2.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc2, null);
            string fn = @"D:\xyz2" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xls";
            exc2ActBook.GetType().InvokeMember("SaveAs", BindingFlags.InvokeMethod, null, exc2ActBook, new object[1] { fn });
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now;
            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= 100; j++)
                    ex.Cells[i, j] = i * j;
            DateTime t2 = DateTime.Now;
            MessageBox.Show((t2 - t1).TotalMilliseconds.ToString());
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DateTime t1 = DateTime.Now;
            for (int i = 1; i <= 100; i++)
                for (int j = 1; j <= 100; j++)
                {
                    object exc2rng = exc2.GetType().InvokeMember("Cells", BindingFlags.GetProperty, null, exc2, new object[2] { i, j });
                    exc2rng.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, exc2rng, new object[1] { i * j });
                }
            DateTime t2 = DateTime.Now;
            MessageBox.Show((t2 - t1).TotalMilliseconds.ToString());
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //ex.Application.Run("lulu.xls!Makro1()",
            //   null, null, null, null, null, null, null, null, null, null,
            //   null, null, null, null, null, null, null, null, null, null,
            //   null, null, null, null, null, null, null, null, null, null);
        }



        object exc3;
        object exc3Books;
        private void button20_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckPathExists = false;
            ofd.DefaultExt = ".xls";
            ofd.Filter = "*.xls|*.xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                exc3 = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application"));

                object vis = exc3.GetType().InvokeMember("Visible", BindingFlags.GetProperty, null, exc3, null);
                exc3.GetType().InvokeMember("Visible", BindingFlags.SetProperty, null, exc3, new Object[1] { !((bool)vis) });

                exc3Books = exc3.GetType().InvokeMember("Workbooks", BindingFlags.GetProperty, null, exc3, null);
                exc3Books.GetType().InvokeMember("Open", BindingFlags.InvokeMethod, null, exc3Books, new object[1] { ofd.FileName });
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int irow = 11; irow <= 20; irow++)
                for (int jcol = 3; jcol <= 4; jcol++)
                {
                    object exc3rng = exc3.GetType().InvokeMember("Cells", BindingFlags.GetProperty, null, exc3, new object[2] { irow, jcol });
                    exc3rng.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, exc3rng, new object[1] { irow * jcol });
                }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            object exc3ActBook = exc3.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc3, null);
            exc3ActBook.GetType().InvokeMember("Save", BindingFlags.InvokeMethod, null, exc3ActBook, null);


            while ((int)exc3Books.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, exc3Books, null) > 0)
            {
                object excActBook = exc3.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc3, null);
                excActBook.GetType().InvokeMember("Close", BindingFlags.InvokeMethod, null, excActBook, new object[3] { false, null, null });
            }
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exc3Books);
            exc3Books = null;

            exc3.GetType().InvokeMember("Quit", BindingFlags.InvokeMethod, null, exc3, null);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(exc3);
            exc3 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            object exc2ActBook = exc2.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc2, null);
            object exc2ActBookSheets = exc2.GetType().InvokeMember("Sheets", BindingFlags.GetProperty, null, exc2, null);

            int ccc = (int)exc2ActBookSheets.GetType().InvokeMember("Count", BindingFlags.GetProperty, null, exc2ActBookSheets, null);
            MessageBox.Show(ccc.ToString());
        }








        private void button24_Click(object sender, EventArgs e)
        {
            object exc2ActBook = exc2.GetType().InvokeMember("ActiveWorkbook", BindingFlags.GetProperty, null, exc2, null);
            object exc2ActBookSheets = exc2ActBook.GetType().InvokeMember("Sheets", BindingFlags.GetProperty, null, exc2ActBook, null);
            object field = exc2ActBookSheets.GetType().InvokeMember("Item", BindingFlags.GetProperty, null, exc2ActBookSheets, new object[] { 3 });
            field.GetType().InvokeMember("Activate", BindingFlags.InvokeMethod, null, field, null);
        }
    }
}