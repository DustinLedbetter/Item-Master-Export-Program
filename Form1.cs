/***********************************************************************************************************************************
*                                                 GOD First                                                                        *
* Author: Dustin Ledbetter                                                                                                         *
* Release Date: 8-28-2018                                                                                                          *
* Version: 4.3                                                                                                                     *
* Purpose: An app where the user chooses between several servers and stored procedures and clicks the submit button.               *
*    When the button is pushed the program runs there selection and retrieves data from a database, adds it to an excel file,      * 
*    and asks the user where they would like to save it. The program can then be ran again with the same or new options selected.  *
************************************************************************************************************************************/

// Using Section
using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Item_Master_Export_SQL
{
    public partial class ItemMasterExport : Form
    {

        public ItemMasterExport()
        {
            InitializeComponent();
        }


        // Declare and initialize variables used with Excel file processing
        object misValue = System.Reflection.Missing.Value;
        int i = 0;
        int j = 0;
        int cellRowIndex = 1;
        int cellColumnIndex = 1;

        // Declare and initialize variables used with SQL setup and processing
        SqlConnection connection;
        string storedProcedure = "";
        string RBStoredProcedure1 = ConfigurationManager.AppSettings["ItemMaster"];
        string RBStoredProcedure2 = ConfigurationManager.AppSettings["InventoryExport"];
        // String RBStoredProcedure3 = ConfigurationManager.AppSettings["Testing"];
        SqlDataAdapter dscmd = new SqlDataAdapter();
        SqlConnection connectionProd = new SqlConnection(ConfigurationManager.ConnectionStrings["PROD"].ConnectionString);
        SqlConnection connectionDev = new SqlConnection(ConfigurationManager.ConnectionStrings["DEV"].ConnectionString);


        /// <summary>
        ///  When the button on the app is clicked the code here:
        ///   1.) connects to a specified database the user chooses,
        ///   2.) runs a query to retrieve data from it, 
        ///   3.) places data into an excel file,
        ///   4.) saves it to where the user chooses
        /// </summary>
        private void MainButton_Click(object sender, EventArgs e)
        {

            // Used to reset label for when the user runs the same choices twice
            SuccessFailLabel.Visible = false;

            // Safety Net SQL
            try
            {

                // Set default values for when the user clicks on button without changing the radio buttons first
                if (connection == null && storedProcedure == "")
                {
                    connection = connectionProd;
                    storedProcedure = RBStoredProcedure1;
                }

                // Set default values for when the user clicks on button but only changes the server choice radio button
                else if (connection == connectionDev && storedProcedure == "")
                {
                    storedProcedure = RBStoredProcedure1;
                }

                // Set default values for when the user clicks on button but only changes the stored procedure radio button
                else if (connection == null && storedProcedure == RBStoredProcedure2)
                {
                    connection = connectionProd;
                }


                // Using SQL declared variables above and radio button (Server Choice) and (Stored Procedure) choices the user chose:
                // Run query and add data to a datatable and then to grid for keeping headers in excel
                connection.Open();
                dscmd = new SqlDataAdapter(storedProcedure, connection);
                DataTable dt = new DataTable();
                dscmd.Fill(dt);
                dataGridView1.DataSource = dt;

                // Safety Net Excel
                try
                {

                    // Setup Excel workbook
                    Excel.Application MyApp = new Excel.Application
                    {
                        Visible = false,
                        DisplayAlerts = false
                    };
                    Excel._Workbook MyBook = (Excel._Workbook)(MyApp.Workbooks.Add(misValue));
                    Excel._Worksheet MySheet = (Excel._Worksheet)MyBook.ActiveSheet;
                    MySheet.Name = "Master Export File";
                    int lastRow = MySheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;

                    // Loop through each row and read value from each column. 
                    // Add -1 to get row placed 1 below where headers are
                    for (i = -1; i < dt.Rows.Count; i++)
                    {
                        for (j = 0; j < dt.Columns.Count; j++)
                        {
                            // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                            if (cellRowIndex == 1)
                            {
                                MySheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                            }
                            else
                            {
                                MySheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            cellColumnIndex++;
                        }
                        // Keep column on 1 row, but allow rows to keep increasing
                        cellColumnIndex = 1;
                        cellRowIndex++;
                    }

                    try
                    {
                        // Open file save dialog and prompt user for save location
                        SaveFileDialog saveDlg = new SaveFileDialog
                        {
                            InitialDirectory = @"C:\",
                            FileName = storedProcedure + ".xls", // Set File name example to match the stored procedure used
                            Filter = "Excel files (*.xls)|*.xls",
                            FilterIndex = 0,
                            RestoreDirectory = true,
                            Title = "Export Excel File To"
                        };

                        // After user hits ok to location and file name; Save file and reset values for next use
                        if (saveDlg.ShowDialog() == DialogResult.OK)
                        {
                            string path = saveDlg.FileName;
                            MyBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlShared, misValue, misValue, misValue, misValue, misValue);
                            MyBook.Saved = true;
                            MyBook.Close(true, misValue, misValue);
                            MyApp.Quit();
                            Marshal.ReleaseComObject(MySheet);
                            Marshal.ReleaseComObject(MyBook);

                            // Update user of successful save
                            SuccessFailLabel.Text = ("File Saved Properly");
                            SuccessFailLabel.Visible = true;
                        }
                        else
                        {
                            // Update user of cancelled save
                            SuccessFailLabel.Text = ("File Save Cancelled");
                            SuccessFailLabel.Visible = true;
                            MyBook.Close();
                            MyApp.Quit();
                            Marshal.ReleaseComObject(MySheet);
                            Marshal.ReleaseComObject(MyBook);

                        }


                    }
                    catch (Exception ex)
                    {
                        // Alert user of failure to save excel file
                        SuccessFailLabel.Text = ("File Not Saved Properly");
                        SuccessFailLabel.Visible = true;
                        MyBook.Close();
                        MyApp.Quit();
                        Marshal.ReleaseComObject(MySheet);
                        Marshal.ReleaseComObject(MyBook);
                        MessageBox.Show
                            (
                                ex.Message,
                                "Excel Proccessing Issue: Failed to Save",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                    }
                    finally
                    {
                        GC.Collect();

                        // Close the connection and reset values for next use
                        connection.Close(); 
                        i = 0;
                        j = 0;
                        cellRowIndex = 1;
                        cellColumnIndex = 1;
                    }


            
                }
                catch (Exception ex)
                {
                    // Alert user of failure to put into an excel file
                    SuccessFailLabel.Text = ("File Not Saved");
                    SuccessFailLabel.Visible = true;
                    MessageBox.Show
                        (
                            ex.Message,
                            "Excel Proccessing Issue: Failed to Export Data to Excel",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
                finally
                {
                    GC.Collect();
                    connection.Close(); // Close the connection
                }



            }
            catch (Exception ex)
            {
                // Alert user of Database connection failure
                SuccessFailLabel.Text = ("File Not Saved Properly");
                SuccessFailLabel.Visible = true;
                MessageBox.Show
                (
                    ex.Message,
                    "Database Issue: Failed to Save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                GC.Collect();
                connection.Close(); // Close the connection
            }
        }


        // Sets the Prod Server button choice as active and resets successfail label
        private void AvantiProdRButton_CheckedChanged(object sender, EventArgs e)
        {
            connection = connectionProd;
            SuccessFailLabel.Visible = false;
        }


        // Sets the Dev Server button choice as active and resets successfail label
        private void AvantiDevRButton_CheckedChanged(object sender, EventArgs e)
        {
            connection = connectionDev;
            SuccessFailLabel.Visible = false;
        }


        // Sets the Master stored procedure button choice as active and resets successfail label
        private void ItemMasterRButton_CheckedChanged(object sender, EventArgs e)
        {
            storedProcedure = RBStoredProcedure1;
            SuccessFailLabel.Visible = false;
        }


        // Sets the Iventory Export stored procedure button choice as active and resets successfail label
        private void InventoryExportRButton_CheckedChanged(object sender, EventArgs e)
        {
            storedProcedure = RBStoredProcedure2;
            SuccessFailLabel.Visible = false;
        }
    }
}
