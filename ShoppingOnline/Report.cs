using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public partial class Report : Form
    {
        DataTable dt = new DataTable();

        public Report()
        {
            InitializeComponent();
            Functions.Connect();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            string id = Functions.GetFieldValues("select MAX(ID) from DONHANG");
            string sql = "select TenSP, GiaSP, SoLuong, ThanhTien from GIOHANG where ID = " + id;
            dt = Functions.GetDataToTable(sql);

            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "Report.rdlc";
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1";
            dts.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenNguoiNhan";
            para1.Values.Add(Functions.GetFieldValues("select Ten from DONHANG where ID = " + id));
            ReportParameter para2 = new ReportParameter();
            para2.Name = "SoDienThoai";
            para2.Values.Add(Functions.GetFieldValues("select SoDienThoai from DONHANG where ID = " + id));
            ReportParameter para3 = new ReportParameter();
            para3.Name = "DiaChi";
            para3.Values.Add(Functions.GetFieldValues("select DiaChi from DONHANG where ID = " + id));
            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3 });

            this.reportViewer1.RefreshReport();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                if (f.Name != "Home")
                    f.Close();
        }
    }
}
