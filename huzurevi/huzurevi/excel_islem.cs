using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;


namespace huzurevi
{
    class excel_islem
    {
        
            public void Dt_ExelAktar(DataGridView d)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

                excel.Visible = true;

                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);

                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

                int StartCol = 1;

                int StartRow = 1;

                for (int j = 0; j < d.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = d.Columns[j].HeaderText;
                }

                StartRow++;

                for (int i = 0; i < d.Rows.Count; i++)
                {

                    for (int j = 0; j < d.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = d[j, i].Value == null ? "" : d[j, i].Value;
                        }
                        catch
                        {
                        }
                    }
                }
            }

            public yazma_islemi MyDataGridViewPrinter;
            public bool YazdirmaAyarlari(PrintDocument PrintDoc, DataGridView DataGrid)
            {
                string baslik = "";
                baslik += "'e";
                PrintDialog MyPrintDialog = new PrintDialog();
                MyPrintDialog.AllowCurrentPage = false;
                MyPrintDialog.AllowPrintToFile = false;
                MyPrintDialog.AllowSelection = true;
                MyPrintDialog.AllowSomePages = false;
                MyPrintDialog.PrintToFile = false;
                MyPrintDialog.ShowHelp = false;
                MyPrintDialog.ShowNetwork = false;

                if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                    return false;

                PrintDoc.DocumentName = "Müşteri Siparişleri Listesi";
                PrintDoc.PrinterSettings =
                MyPrintDialog.PrinterSettings;
                PrintDoc.DefaultPageSettings =
                MyPrintDialog.PrinterSettings.DefaultPageSettings;
                PrintDoc.DefaultPageSettings.Margins =
                new Margins(20, 20, 20, 20);

                if (MessageBox.Show("Raporu sayfaya ortalamak ister misiniz?",
                 "Rapor Ortalaması", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == DialogResult.Yes)
                    MyDataGridViewPrinter = new yazma_islemi(DataGrid,
                    PrintDoc, true, true, "Müşteri Sipariş Listesi", new Font("Tahoma", 14,
                    FontStyle.Regular, GraphicsUnit.Point), Color.Black, true);
                else
                    MyDataGridViewPrinter = new yazma_islemi(DataGrid,
                    PrintDoc, false, true, baslik, new Font("Tahoma", 14,
                    FontStyle.Regular, GraphicsUnit.Point), Color.Black, true);

                return true;
            }

        
    }
}
