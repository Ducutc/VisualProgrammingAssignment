using Guna.Charts.WinForms;
using Ktra;
using System;
using System.Data;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_Statistic : UserControl
    {
        private GunaBarDataset gunaBarDataset;
        private GunaPieDataset gunaPieDataset;

        public UC_Statistic()
        {
            InitializeComponent();
            InitializeGunaChart();
        }

        private void InitializeGunaChart()
        {
            
            // Set up GunaBarDataset
            gunaBarDataset = new GunaBarDataset();
            gunaBarDataset.Label = "Bar";
            gunaBarDataset.LegendBoxFillColor = Color.MediumSlateBlue;
            gunaBarDataset.FillColors.Add(Color.MediumSlateBlue);
            gunaBarDataset.FillColors.Add(Color.MediumPurple);
            gunaBarDataset.YFormat = "C";

            //Set up GunaPieDataset
            gunaPieDataset = new GunaPieDataset();
            gunaPieDataset.Label = "Pie";
            gunaPieDataset.LegendBoxFillColor = Color.OrangeRed;
            gunaPieDataset.FillColors.Add(Color.Blue);
            gunaPieDataset.FillColors.Add(Color.Gold);
            gunaPieDataset.FillColors.Add(Color.Green);
            gunaPieDataset.FillColors.Add(Color.Red);
            gunaPieDataset.FillColors.Add(Color.Gray);
            gunaPieDataset.YFormat = "C";

            gunaChartByDate.Datasets.Add(gunaBarDataset);
            gunaChartByProduct.Datasets.Add(gunaPieDataset);

            // Generate data and labels for the datasets
            GenerateDataAndLabels();
        }
        
        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;

            // Set up statistic 
            lblBillAmount.Text = DataProcess.ReadTable("select count(*) from DONHANG").Rows[0][0].ToString();
            lblTotalIncome.Text = DataProcess.ReadTable("select sum(TongTien) from DONHANG").Rows[0][0].ToString() + " đ";
            GenerateDataAndLabels();
        }

        private void GenerateDataAndLabels()
        {
            updateBarChartData();
            updatePieChartData();
        }

        private void updatePieChartData()
        {
            string sql = "select ct.MaSP, sp.TenSP, Sum(SoLuong) as Tong from SANPHAM sp join CHITIETDONHANG ct on sp.MaSP = ct.MaSP group by ct.MaSP, sp.TenSP";
            DataTable dt = DataProcess.ReadTable(sql);
            foreach (DataRow row in dt.Rows)
            {
                string tenSP = row["TenSP"].ToString();
                int soLuong = Convert.ToInt32(row["Tong"]);
                gunaPieDataset.DataPoints.Add(new LPoint()
                {
                    Label = tenSP,
                    Y = soLuong
                });
            }
        }

        private void updateBarChartData()
        {
            string ngayBatDau = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = dtpEndDate.Value.ToString("yyyy-MM-dd");
            string sql = "select NgayLap, Sum(ct.SoLuong) as SoLuong from DONHANG dh join CHITIETDONHANG ct on dh.MaHD = ct.MaHD where NgayLap between '" + ngayBatDau + "' and '" + ngayKetThuc + "' group by NgayLap ";
            DataTable dt = DataProcess.ReadTable(sql);
            gunaBarDataset.DataPoints.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string ngayLap = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                gunaBarDataset.DataPoints.Add(new LPoint()
                {
                    Label = ngayLap,
                    Y = soLuong
                });
            }

        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            updateBarChartData();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            updateBarChartData();
        }
    }
}
