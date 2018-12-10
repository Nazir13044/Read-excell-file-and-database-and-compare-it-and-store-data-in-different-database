using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_Uploder
{
    public partial class Excel_Uploder : Form
    {

        #region Other Events

        private string _path;
        public Excel_Uploder()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblNocHeader.ForeColor != Color.Green)

               lblNocHeader.ForeColor = Color.Green;
            else
               lblNocHeader.ForeColor = Color.Brown;

            if (lblMobImportHeader.ForeColor != Color.Green)

                lblMobImportHeader.ForeColor = Color.Green;
            else
                lblMobImportHeader.ForeColor = Color.Brown;



        }

        private void Excel_Uploder_Load(object sender, EventArgs e)
        {

        }

        //For Background Running Process
        private BackgroundWorker bw = new BackgroundWorker
        {
            WorkerReportsProgress = true,
            WorkerSupportsCancellation = true
        };
        #endregion Other Events

       

        #region Noc Mobile Data Import Events
        //For Mobile Import Upload Button Click Event
        private void btnMobImportBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Excell|*.xls;*.xlsx;*xlsm;";
            //od.FileName = "EmployeeList.xlsx";
            DialogResult dr = od.ShowDialog();
            if (dr == DialogResult.Abort)
                return;
            if (dr == DialogResult.Cancel)
                return;
            txtMobImportPath.Text = od.FileName.ToString();
            btnMobImportUpload.Visible = true;
            btnMobImportUpload.Enabled = true;   
        }


        public DataTable GetTable1Data()
        {
            _path = txtMobImportPath.Text;
            string extension = "." + _path.Split('.')[_path.Split('.').Length - 1];
            //  ExcelConn(_path);  
            string conString = string.Empty;




            switch (extension)
            {
                case ".xls": //Excel 97-03.
                    conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
                case ".xlsx": //Excel 07 and above.
                    conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
                case ".xlsm": //Excel 07 and above.
                    conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
            }


            var connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _path + ";Extended Properties=Excel 12.0;";
            //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";
            // conString = string.Format(conString, _path);
            var econ = new OleDbConnection(connStr);

            econ.Open();
            var count = 0;



            DataTable dtExcelSchema = econ.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            DataTable exceldt = null;
            if (dtExcelSchema != null)
            {
                var sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                var query =
                    string.Format(
                        "Select [Date],[S/N],[BarCode] FROM [" +
                        sheetName + "]");
                var ecom = new OleDbCommand(query, econ);
                var ds = new DataSet();
                var oda = new OleDbDataAdapter(query, econ);
                econ.Close();
                oda.Fill(ds);
                exceldt = ds.Tables[0];
                count = ds.Tables[0].Rows.Count;
                exceldt.AcceptChanges();
            }
            return exceldt;
        }



        //for mobile import upload event
        private void btnMobImportUpload_Click(object sender, EventArgs e)
        {

            string extension = "." + txtMobImportPath.Text.Split('.')[txtMobImportPath.Text.Split('.').Length - 1];
            if (txtMobImportPath.Text == "")
            {
                MessageBox.Show("Please Upload an Excel File");
            }


            if (extension != ".xls" && extension != ".xlsx" && extension != ".xlsm")
            {

                MessageBox.Show("Please Upload a valid Excel File", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }



            else
            {

                //lblProgress.Text = "Please wait Uploading  data...";
                imeiBackgroundWorker.WorkerReportsProgress = true;
                imeiBackgroundWorker.RunWorkerAsync();
            }
            //btnMobImportUpload.Visible = false;
            //_path = txtMobImportPath.Text;
            //// if (textBox1.Text == "" || !textBox1.Text.Contains("EmployeeList.xlsx"))
            //if (txtMobImportPath.Text == "")
            //{
            //    MessageBox.Show("Please Browse Application For Noc Excel File to upload", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtMobImportPath.Text = "";
            //    txtMobImportPath.Visible = false;
            //    return ;
            //}
            //if (bw.IsBusy)
            //{
            //    return;
            //}

            //System.Diagnostics.Stopwatch sWatch = new System.Diagnostics.Stopwatch();
            //bw.DoWork += (bwSender, bwArg) =>
            //{
            //    //what happens here must not touch the form  
            //    //as it's in a different thread          
            //    sWatch.Start();
            //    InsertMobImportExcelRecords();
            //};

            //bw.ProgressChanged += (bwSender, bwArg) =>
            //{
            //    //update progress bars here  

            //};

            //bw.RunWorkerCompleted += (bwSender, bwArg) =>
            //{
            //    //pBar.Maximum = 100;
            //    sWatch.Stop();

            //    //work is done, no need for the stop button now...  
            //    //pb1.Visible = false;
            //    txtMobImportPath.Text = "";
            //    btnMobImportBrowse.Enabled = true;
            //    btnMobImportUpload.Enabled = false;
            //    //label1.Visible = false;
            //    bw.Dispose();
            //};
            ////lets allow the user to click stop  
            //MessageBox.Show("Uploading has been started !.\nyou are free to do any other tasks in this application,if you wish to close this screen  you can do it.but please don't close this application until upload message popups.", "Upload processing..", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //// button1.Enabled = false;

            ////Starts the actual work - triggerrs the "DoWork" event  
            //bw.RunWorkerAsync(); 

        }

        private void InsertMobImportExcelRecords()
        {
            try
            {
                string extension = "." + _path.Split('.')[_path.Split('.').Length - 1];
                //  ExcelConn(_path);  
                string conString = string.Empty;
                if (extension != ".xls" && extension != ".xlsx" && extension != ".xlsm")
                {

                    MessageBox.Show("Please Upload a valid Excel File", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bw.Dispose();

                    return;
                }
                else
                {
                    switch (extension)
                    {
                        case ".xls": //Excel 97-03.
                            conString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                            break;
                        case ".xlsx": //Excel 07 and above.
                            conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                            break;
                        case ".xlsm": //Excel 07 and above.
                            conString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                            break;
                    }
                    conString = string.Format(conString, _path);
                    OleDbConnection Econ = new OleDbConnection(conString);

                    Econ.Open();

                    //Get The Sheet name to make it dybnamic 
                    DataTable dtExcelSchema;
                    dtExcelSchema = Econ.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

                    //string Query = string.Format("Select [Company],[ Name],[Port],[Land Date],[Pay Date],[QTY],[Value],[CD],[VAT],[AIT],[Total Duty],[AVG Value BDT],[AVG value USD],[AVG MKT Value],[25% Value sagment],[50% Value sagment],[100% value sagment] FROM [" + sheetName + "]");
                    string Query =
                        string.Format("Select * FROM [" +sheetName + "]");
                    
                    OleDbCommand Ecom = new OleDbCommand(Query, Econ);

                    DataSet ds = new DataSet();
                    OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                    Econ.Close();
                    oda.Fill(ds);

                    DataTable data = ds.Tables["myTable"];



                    DataTable Exceldt = ds.Tables[0];
                    string consString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    SqlConnection con = new SqlConnection(consString);
                    con.Open();

                    ArrayList list = new ArrayList();

                    foreach (DataColumn dc in Exceldt.Columns)
                    {
                        list.Add( dc.ColumnName);

                    }





                    ////var mm = list;

                    //// SqlBulkCopy      
                    //SqlBulkCopy objbulk = new SqlBulkCopy(con);
                    ////assigning Destination table name     
 
                    //objbulk.DestinationTableName = "TestIMEIUploadForUpdate";
                    ////Mapping Table column 
                    //objbulk.ColumnMappings.Add("" +list[2]+"","Model");
                    //objbulk.ColumnMappings.Add(""+list[3]+"","Color");
                    //objbulk.ColumnMappings.Add(""+list[5]+"","IMEI1");
                    //objbulk.ColumnMappings.Add(""+list[6]+"","IMEI2");
                                

                    ////inserting Datatable Records to DataBase   

                    //objbulk.WriteToServer(Exceldt);
                    con.Close();
                    MessageBox.Show("Data has been Imported successfully. Total='" + list.Count , "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Data has not been Imported due to :{0}", ex.Message), "Not Imported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //pb1.Visible = false;
                txtMobImportPath.Text = "";
                btnMobImportBrowse.Enabled = true;
                //label1.Visible = false;

            }
            
        }
        #endregion Noc Mobile Data Import Events

        private void imeiBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Get data from databse
            var dtProgress = GetTable1Data();

            for (int i = 1; i <= dtProgress.Rows.Count; i++)
            {
                //Thread.Sleep(100);
                int percents = (i*100)/dtProgress.Rows.Count;
                //Save data


                //var wo = dtProgress.Rows[i - 1]["Date"].ToString();
                //var project = dtProgress.Rows[i - 1]["S/N"].ToString();
                var model = dtProgress.Rows[i - 1]["BarCode"].ToString();




                if (!string.IsNullOrEmpty(model))
                {
                    var bCode = model.Remove(model.Length - 2).Trim();


                    var consString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                    var con = new SqlConnection(consString);
                    con.Open();



                    //var sql= string.Format("select * from ProductionMaster where MobileCode = '" + bCode + "' ");
                    var comm = new SqlCommand(@"select * from ProductionMaster where MobileCode = '" + bCode + "' ", con);
                    try
                    {
                        SqlDataReader dreader = comm.ExecuteReader();
                        if (dreader.Read())
                        {
                            var barcode = bCode;
                            var imei1 = dreader["Imei1"].ToString();
                            var imei2 = dreader["Imei2"].ToString();
                            dreader.Close();
                            var sql = string.Format("insert into AgingReport values('" + barcode + "','" + imei1 + "','" + imei2 + "')");
                            var nwcomm = new SqlCommand("insert into AgingReport values('" + barcode + "','" + imei1 + "','" + imei2 + "')", con);

                            nwcomm.ExecuteNonQuery();

                        }



                        else
                        {
                            //MessageBox.Show(" No Record");
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show(" No Record");
                    }
                    finally
                    {
                        con.Close();
                    }

                }














            }
        }




    }
}
