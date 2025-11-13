using Ktra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_AccountManage : UserControl
    {
        public UC_AccountManage()
        {
            InitializeComponent();
        }

        private void UC_AccountManage_Load(object sender, EventArgs e)
        {
            // Get account's data 
            DataTable dt = DataProcess.ReadTable("SELECT Username, Fullname, Role FROM Accounts");

            AdjustColumnWidths();
        }

        private void AdjustColumnWidths()
        {
            if (lsvAccountList.Columns.Count == 0) return;

            int totalWidth = lsvAccountList.ClientSize.Width;
            int colWidth = totalWidth / lsvAccountList.Columns.Count;

            foreach (ColumnHeader col in lsvAccountList.Columns)
                col.Width = colWidth;
        }
    }
}
