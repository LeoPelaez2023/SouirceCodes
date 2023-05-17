using Microsoft.VisualBasic.ApplicationServices;
using Protractor.Models;
using System.Windows.Forms;

namespace Protractor
{
    public partial class Form1 : Form
    {
        Models.cWorkOrder _wo = new Models.cWorkOrder();

        Bll.workorders _metod = new Bll.workorders();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData(txtSearch.Text.Trim());
        }

        void GetData(string srchStr)
        {
            List<cWorkOrder> lista = _metod.allRecords(_wo, srchStr);
            dataGridView1.DataSource = lista;
            int i = 0;
            string xx = "";
            dataGridView1.AutoGenerateColumns = false;
            foreach (var prop in _wo.GetType().GetProperties())
            {
                dataGridView1.Columns[i].DataPropertyName = prop.Name;
                i = i + 1;
            }
            dataGridView1.DataSource = lista;
            this.dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "c";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData(txtSearch.Text.Trim());
        }
    }
}