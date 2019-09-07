using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KboOpenDataIO
{
    public partial class frmKboOpenDataIO : Form
    {
        public string cnnChosen = "";

        public frmKboOpenDataIO()
        {
            InitializeComponent();
        }

        private void FrmKboOpenDataIO_Load(object sender, EventArgs e)
        {
            Text = "KboOpenData IO";            
            tbLocalConnectionstring.Text = Properties.Settings.Default.LocalSQLSetting;
            tbHostedConnectionstring.Text = Properties.Settings.Default.HostedSQLSetting;
        }

        private void BtnGetCsvLocation_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog CsvOpenFileDialog = new OpenFileDialog())
            {
                CsvOpenFileDialog.InitialDirectory = "c:\\";
                CsvOpenFileDialog.Filter = "csv files (*.csv)|*.csv";
                CsvOpenFileDialog.FilterIndex = 1;
                CsvOpenFileDialog.FileName = "enterprise.csv";

                CsvOpenFileDialog.RestoreDirectory = true;

                if (CsvOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileContent = string.Empty;
                    string filePath = string.Empty;

                    //Get the path of specified file
                    filePath = CsvOpenFileDialog.FileName;
                    tbCsvLocation.Text = filePath.Substring(0, filePath.IndexOf("enterprise.csv"));
                    btnGetCsvLocation.Text = "OK";                    
                    _ = MessageBox.Show("File enterprise.csv at path: " + tbCsvLocation.Text);
                    groupBox1.Visible = true;
                }
            }
        }

        private void BtnCheckLocalSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LocalSQLSetting = tbLocalConnectionstring.Text;
        }

        private void BtnCheckHostedSqlServer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HostedSQLSetting = tbHostedConnectionstring.Text;
        }

        private void RbLocal_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen = tbLocalConnectionstring.Text;
            btnReadCsv.Enabled = true;
        }

        private void RbHosted_CheckedChanged(object sender, EventArgs e)
        {
            cnnChosen = tbHostedConnectionstring.Text;
            btnReadCsv.Enabled = true;
        }

        private void BtnReadCsv_Click(object sender, EventArgs e)
        {
            // enterprise.csv file reader
            MessageBox.Show("Start reading enterprise.csv file.");
            Cursor.Current = Cursors.WaitCursor;

            CsvDataEnterprise enterpriseReader = new CsvDataEnterprise();
            enterpriseReader.CsvReadFile(tbCsvLocation.Text + "enterprise.csv", cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Reading enterprise.csv file finished");

            // code/csv file reader
            MessageBox.Show("Start reading code.csv file.");
            Cursor.Current = Cursors.WaitCursor;

            CsvDataCode codeReader = new CsvDataCode();
            codeReader.CsvReadFile(tbCsvLocation.Text + "code.csv", cnnChosen);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Reading code.csv file finished");
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
