using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;

namespace LibraryScanner
{
    public partial class Form1 : Form
    {

        public static Microsoft.Office.Interop.Excel.Application xlDatabase, xlLog;
        public static Workbook wbDatabase, wbLog;
        public static Worksheet wsDatabase, wsLog;

        private String databasePath;
        private String logPath;
        private String logFileName;
        private String databaseFileName;

        private int tally;
        private int nextRow;

        public Form1()
        {
            //Create form
            InitializeComponent();

            //Open excel
            xlDatabase = new Microsoft.Office.Interop.Excel.Application();
            xlLog = new Microsoft.Office.Interop.Excel.Application();
            //Prevent log file from sending save overwrite alerts
            xlLog.DisplayAlerts = false;

            //Set text labels values
            idLabel.Text = "";
            nameLabel.Text = "";
            gradeLabel.Text = "";
            updateDatabasePath((String)Properties.Settings.Default["databasePath"]);
            updateLogPath((String)Properties.Settings.Default["logPath"]);
            updateTally((int)Properties.Settings.Default["tally"]);

            //File.SetAttributes(logPath, FileAttributes.ReadOnly);
            createDatabase(databasePath);
        }

        //Creates notepad file with database from Excel file. Input full path of file. 
        private void createDatabase(String xlPath)
        {

        
            //Opens Excel file
            if (File.Exists(xlPath) && (xlPath.IndexOf(".xls") >= 0 || xlPath.IndexOf(".xlsx") >= 0)) //Checks if file is a valid Excel file.
            {
                try
                {
                    wbDatabase = xlDatabase.Workbooks.Open(xlPath);
                    wsDatabase = wbDatabase.ActiveSheet;
                }
                catch
                {
                    MessageBox.Show("Please close any open instances of the database.");
                }

            }
            else
            {
                MessageBox.Show("Student database does not exist. Please select a valid file.");
            }

            //Finds columns with ID, name, and grade
            int idCol = wsDatabase.Cells.Find("ID").Column;
            int nameCol = wsDatabase.Cells.Find("Name").Column;
            int gradeCol = wsDatabase.Cells.Find("Gr").Column;
            int row = wsDatabase.Cells.Find("ID").Row;

            ArrayList data = new ArrayList();

            while(row <= wsDatabase.UsedRange.Rows.Count)
            {
                data.Add(wsDatabase.Cells[row, idCol].Value + ", " + wsDatabase.Cells[row, nameCol].Value + ", " + wsDatabase.Cells[row, gradeCol].Value);
                row++;
                data.Sort();
            }

            System.IO.File.WriteAllLines(@"D:\Antony\Desktop\test.txt", (String[])data.ToArray(typeof(string)));

            xlDatabase.Quit();
        }

        //Sets textbox to path of student database
        private void updateDatabasePath(String path)
        {
            databasePath = path;
            databaseLabel.Text = databasePath;
            Properties.Settings.Default["databasePath"] = databasePath;
            Properties.Settings.Default.Save();
            //TEST
            openDatabase();
        }

        //Sets textbox to folder where logs are stored
        private void updateLogPath(String path)
        {
            logPath = path;
            logLabel.Text = logPath;
            Properties.Settings.Default["logPath"] = logPath;
            Properties.Settings.Default.Save();
            //TEST
            openLog();
        }

        //Sets check in tally to desired number
        private void updateTally(int t)
        {
            tally = t;
            tallyLabel.Text = ""+tally;
            Properties.Settings.Default["tally"] = tally;
            Properties.Settings.Default.Save();
        }

        //Opens student database
        private void openDatabase()
        {
            //Check if file is valid
            if (File.Exists(databasePath) && (databasePath.IndexOf(".xls") >= 0 || databasePath.IndexOf(".xlsx") >= 0))
            {
                try
                {
                    wbDatabase = xlDatabase.Workbooks.Open(databasePath);
                    wsDatabase = wbDatabase.ActiveSheet;
                }
                catch
                {
                    MessageBox.Show("Please close any open instances of the database.");
                }
                
            }
            else
            {
                MessageBox.Show("Student database does not exist. Please select a valid file.");
            }
        }

        //Creates and opens log file
        private void openLog()
        {
            logFileName = logPath + "\\Library_Log_";
            DateTime today = DateTime.Today;
            logFileName += today.ToString("MM_yyyy")+".xlsx";
            if(File.Exists(logFileName))
            {
                
                //xlLog.Visible = true;
                try
                {
                    File.SetAttributes(logFileName, ~FileAttributes.ReadOnly);
                    wbLog = xlLog.Workbooks.Open(logFileName);
                    wsLog = wbLog.ActiveSheet;
                    wbLog.Save();
                    //MessageBox.Show("wbLog.Save() openlog");
                }
                catch
                {
                    MessageBox.Show("Please close any open instances of " + logFileName);
                }

                //Range startCell = wsLog.Cells[1, 1];
                //Range endCell = wsLog.Cells[65536, 5];
                nextRow = wsLog./*Range[startCell,endCell].*/UsedRange.Rows.Count+1;

            }
            else
            {
                wbLog = xlLog.Application.Workbooks.Add();
                wsLog = wbLog.Application.Worksheets.Add();
                wsLog.Columns[1].ColumnWidth = 10;
                wsLog.Cells[1, 1].Value = "Date";

                wsLog.Columns[2].ColumnWidth = 10;
                wsLog.Cells[1, 2].Value = "Time";

                wsLog.Columns[3].ColumnWidth = 25;
                wsLog.Cells[1, 3].Value = "Student Name";

                wsLog.Columns[4].ColumnWidth = 10;
                wsLog.Cells[1, 4].Value = "ID";

                wsLog.Columns[5].ColumnWidth = 10;
                wsLog.Cells[1, 5].Value = "Grade";

                wsLog.Cells[1, 7].Value = "Date";
                wsLog.Columns[7].ColumnWidth = 10;

                wsLog.Cells[1, 8].Value = "Count";
                wsLog.Columns[8].ColumnWidth = 10;

                wsLog.Cells[1, 9].Value = DateTime.Now.ToString("MMM") + " Total";
                wsLog.Cells[1, 9].Font.Bold = true;
                wsLog.Cells[2, 9].Value = 0;
                wsLog.Cells[2, 9].Font.Bold = true;
                wsLog.Columns[9].ColumnWidth = 10;

                //File.SetAttributes(logFileName, ~FileAttributes.ReadOnly);
                try {
                    wbLog.SaveAs(logFileName);
                }
                catch { }

                nextRow = 2;
            }
            try
            {
                File.SetAttributes(logFileName, ~FileAttributes.ReadOnly);
                //MessageBox.Show(logFileName);
            }
            catch { }
        }

        //Finds student in database, displays their name on screen, and adds them to the log
        private void recordStudent(String id)
        {
            //if(wbDatabase == null || wsDatabase == null)
            {
                openDatabase();
            }

            if(wbLog == null || wbDatabase == null)
            {
                openLog();
            }


            if (wsDatabase.Cells.Find("ID") == null || wsDatabase.Cells.Find("Name") == null || wsDatabase.Cells.Find("Gr") == null)
            {
                MessageBox.Show("Database file does not have columns for \"Student Id\", \"Student Name\", and \"Grd\".");
                return;
            }


            int idCol = wsDatabase.Cells.Find("ID").Column;
            int nameCol = wsDatabase.Cells.Find("Name").Column;
            int gradeCol = wsDatabase.Cells.Find("Gr").Column;

            

            Range idCell = wsDatabase.Cells.Find(id);
            
            idBox.Text = "";
            if(idCell == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            int studentRow = idCell.Row;
            String name = wsDatabase.Cells[studentRow, nameCol].Value;
            String grade = ""+wsDatabase.Cells[studentRow, gradeCol].Value;
            DateTime time = DateTime.Now;

            idLabel.Text = id;
            nameLabel.Text = name;
            gradeLabel.Text = grade;

            wsLog.Cells[nextRow, 1].Value = time.ToString("MM/dd/yyyy");
            wsLog.Cells[nextRow, 2].Value = time.ToString("hh:mm:ss");
            wsLog.Cells[nextRow, 3].Value = name;
            wsLog.Cells[nextRow, 4].Value = id;
            wsLog.Cells[nextRow, 5].Value = grade;

            nextRow++;

            updateTally(tally + 1);

            incrementDailyTally();

            try
            {
                File.SetAttributes(logFileName, ~FileAttributes.ReadOnly);
                wbLog.Save();
                //MessageBox.Show("wbLog.Save() at closing");
            }
            catch
            {
                MessageBox.Show("Please close any open instances of the log file.");
                return;
            }
        }

        private void incrementDailyTally()
        {
            if (wbLog == null)
            {
                openLog();
            }

            int row = 2;
            while(wsLog.Cells[row,7].Value != null)
            {
                row++;
            }

            String date = DateTime.Today.ToString("MM/dd/yyyy");
            //MessageBox.Show(wsLog.Cells[row - 1, 7].Value.GetType().ToString());
            if (wsLog.Cells[row-1,7].Value.ToString() == DateTime.Today.ToString())
            {
                //wsLog.Cells[row-1, 8].Value = Int32.Parse(wsLog.Cells[row-1, 8].Value) + 1;
                wsLog.Cells[row - 1, 8].Value = wsLog.Cells[row - 1, 8].Value + 1;
            }
            else
            {
                wsLog.Cells[row, 7].Value = date;
                wsLog.Cells[row, 8].Value = 1;
            }

            wsLog.Cells[2, 9].Value = wsLog.Cells[2, 9].Value + 1;


        }

        //ID Textbox event handler to remove non numerical characters
        private void idBox_TextChanged(object sender, EventArgs e)
        {
            //Retrieve text from textbox
            System.Windows.Forms.TextBox box = (System.Windows.Forms.TextBox)sender;
            String text = box.Text;

            //Remove non numerical characters
            for(int i=0; i<text.Length; i++)
            {
                if (text.Length > 0 && ((int)text[i] < 48 || (int)text[i] > 57))
                {
                    box.Text = text.Substring(0, i) + text.Substring(i+1);
                    box.Select(i, 0);
                }
            }
        }

        //ID Textbox event handler to process ID
        private void idBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Check if key pressed is Enter
            if (e.KeyCode == Keys.Enter)
            {                
                //Retrieve text from textbox
                System.Windows.Forms.TextBox box = (System.Windows.Forms.TextBox)sender;
                String text = box.Text;

                if(text.Length != 7)
                {
                    box.Text = "";
                    MessageBox.Show("ID Must be 7 digits long.");
                    return;
                }

                recordStudent(text);

                
            }
        }

        //Allows user to select database Excel file after clicking the Browse button
        private void databaseBrowseButton_Click(object sender, EventArgs e)
        {
            //Create a new dialog that allows user to select .xls or .xlsx files
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel Files (*.xls,*.xlsx)|*.xls;*.xlsx|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            //Displays dialog and records selected file
            DialogResult result = openFileDialog1.ShowDialog();
            String fileName = openFileDialog1.FileName;

            //Checks if file is valid and updates path
            if (result == DialogResult.OK && File.Exists(fileName) && (fileName.IndexOf(".xls") >= 0 || fileName.IndexOf(".xlsx") >= 0))
            {
                updateDatabasePath(fileName);
                if(wbDatabase == null)
                {
                    openDatabase();
                }
            }
            else if(result != DialogResult.Cancel)
            {
                MessageBox.Show("File does not exist or is not a valid Excel file.");
            }
        }

        //Opens folder with log files
        private void openButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(logPath);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.SetAttributes(logFileName, ~FileAttributes.ReadOnly);
                wbLog.Save();
                //MessageBox.Show("wbLog.Save() at closing");
            }
            catch
            {
                MessageBox.Show("Please close any open instances of the log file before quitting.");
                return;
            }

            xlDatabase.Quit();
            xlLog.Quit();
            File.SetAttributes(logFileName, FileAttributes.ReadOnly);
        }




        //Allows user to select folder for storing logs after clicking the Browse button
        private void logBrowseButton_Click(object sender, EventArgs e)
        {
            //Creates a new dialog that allows user to select folder
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Displays dialog and records user selection
            DialogResult result = fbd.ShowDialog();

            //Checks if folder is valid and updates path
            if (result == DialogResult.OK)
            {
                updateLogPath(fbd.SelectedPath);
            }
        }

        //Resets tally
        private void resetButton_Click(object sender, EventArgs e)
        {
            updateTally(0);
            //openLog();
        }

        //Sends enter key to idBox when button is pressed
        private void enterButton_Click(object sender, EventArgs e)
        {
            idBox.Focus();
            SendKeys.Send("{ENTER}");

        }

        //Stops log from being deleted, courtesy of MSDN
        private void lockFile()
        {
            FileSecurity fSecurity = File.GetAccessControl(logFileName);
            fSecurity.AddAccessRule(new FileSystemAccessRule("Authenticated Users", FileSystemRights.Read, AccessControlType.Allow));
            fSecurity.AddAccessRule(new FileSystemAccessRule("Authenticated Users", FileSystemRights.Write, AccessControlType.Deny));
            File.SetAccessControl(logFileName, fSecurity);
        }

        private void unlockFile()
        {
            FileSecurity fSecurity = File.GetAccessControl(logFileName);
            fSecurity.AddAccessRule(new FileSystemAccessRule("Authenticated Users", FileSystemRights.Read, AccessControlType.Allow));
            fSecurity.AddAccessRule(new FileSystemAccessRule("Authenticated Users", FileSystemRights.Write, AccessControlType.Allow));
            File.SetAccessControl(logFileName, fSecurity);
        }
    }
}
