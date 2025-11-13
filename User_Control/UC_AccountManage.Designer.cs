namespace CoffeeHouseABC.User_Control
{
    partial class UC_AccountManage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvAccountList = new Guna.UI2.WinForms.Guna2DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblAdd = new Label();
            panel2 = new Panel();
            lblEdit = new Label();
            panel3 = new Panel();
            lblDelete = new Label();
            panel4 = new Panel();
            tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAccountList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAccountList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvAccountList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAccountList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAccountList.ColumnHeadersHeight = 25;
            dgvAccountList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAccountList.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAccountList.Dock = DockStyle.Fill;
            dgvAccountList.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccountList.Location = new Point(0, 110);
            dgvAccountList.MultiSelect = false;
            dgvAccountList.Name = "dgvAccountList";
            dgvAccountList.ReadOnly = true;
            dgvAccountList.RowHeadersVisible = false;
            dgvAccountList.RowHeadersWidth = 51;
            dgvAccountList.Size = new Size(1498, 818);
            dgvAccountList.TabIndex = 2;
            dgvAccountList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAccountList.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAccountList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAccountList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAccountList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAccountList.ThemeStyle.BackColor = Color.White;
            dgvAccountList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAccountList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAccountList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAccountList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvAccountList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAccountList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAccountList.ThemeStyle.HeaderStyle.Height = 25;
            dgvAccountList.ThemeStyle.ReadOnly = true;
            dgvAccountList.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAccountList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccountList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvAccountList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAccountList.ThemeStyle.RowsStyle.Height = 29;
            dgvAccountList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAccountList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(15);
            flowLayoutPanel1.Size = new Size(1498, 110);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblAdd);
            panel1.Location = new Point(30, 18);
            panel1.Margin = new Padding(15, 3, 15, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 75);
            panel1.TabIndex = 1;
            // 
            // lblAdd
            // 
            lblAdd.BackColor = Color.Lime;
            lblAdd.BorderStyle = BorderStyle.FixedSingle;
            lblAdd.Dock = DockStyle.Left;
            lblAdd.Font = new Font("Segoe UI", 14F);
            lblAdd.Image = Properties.Resources.icon_add;
            lblAdd.ImageAlign = ContentAlignment.MiddleLeft;
            lblAdd.Location = new Point(0, 0);
            lblAdd.Margin = new Padding(7, 0, 7, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Padding = new Padding(5);
            lblAdd.Size = new Size(210, 75);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "Add";
            lblAdd.TextAlign = ContentAlignment.MiddleRight;
            lblAdd.Click += lblAdd_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblEdit);
            panel2.Location = new Point(270, 18);
            panel2.Margin = new Padding(15, 3, 15, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 75);
            panel2.TabIndex = 2;
            // 
            // lblEdit
            // 
            lblEdit.BackColor = Color.Cyan;
            lblEdit.BorderStyle = BorderStyle.FixedSingle;
            lblEdit.Dock = DockStyle.Left;
            lblEdit.Font = new Font("Segoe UI", 14F);
            lblEdit.Image = Properties.Resources.icon_edit;
            lblEdit.ImageAlign = ContentAlignment.MiddleLeft;
            lblEdit.Location = new Point(0, 0);
            lblEdit.Margin = new Padding(7, 0, 7, 0);
            lblEdit.Name = "lblEdit";
            lblEdit.Padding = new Padding(5);
            lblEdit.Size = new Size(210, 75);
            lblEdit.TabIndex = 0;
            lblEdit.Text = "Edit";
            lblEdit.TextAlign = ContentAlignment.MiddleRight;
            lblEdit.Click += lblEdit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblDelete);
            panel3.Location = new Point(510, 18);
            panel3.Margin = new Padding(15, 3, 15, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(210, 75);
            panel3.TabIndex = 3;
            // 
            // lblDelete
            // 
            lblDelete.BackColor = Color.Red;
            lblDelete.BorderStyle = BorderStyle.FixedSingle;
            lblDelete.Dock = DockStyle.Left;
            lblDelete.Font = new Font("Segoe UI", 14F);
            lblDelete.Image = Properties.Resources.icon_delete;
            lblDelete.ImageAlign = ContentAlignment.MiddleLeft;
            lblDelete.Location = new Point(0, 0);
            lblDelete.Margin = new Padding(7, 0, 7, 0);
            lblDelete.Name = "lblDelete";
            lblDelete.Padding = new Padding(5);
            lblDelete.Size = new Size(210, 75);
            lblDelete.TabIndex = 0;
            lblDelete.Text = "Delete";
            lblDelete.TextAlign = ContentAlignment.MiddleRight;
            lblDelete.Click += lblDelete_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(tbSearch);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(835, 18);
            panel4.Margin = new Padding(100, 3, 3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15);
            panel4.Size = new Size(633, 75);
            panel4.TabIndex = 4;
            // 
            // tbSearch
            // 
            tbSearch.BorderThickness = 2;
            tbSearch.CustomizableEdges = customizableEdges3;
            tbSearch.DefaultText = "";
            tbSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearch.Font = new Font("Segoe UI", 9F);
            tbSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbSearch.Location = new Point(194, 15);
            tbSearch.Margin = new Padding(3, 4, 3, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "";
            tbSearch.SelectedText = "";
            tbSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbSearch.Size = new Size(422, 43);
            tbSearch.TabIndex = 1;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(179, 43);
            label1.TabIndex = 0;
            label1.Text = "Search by Name";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_AccountManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvAccountList);
            Controls.Add(flowLayoutPanel1);
            Name = "UC_AccountManage";
            Size = new Size(1498, 928);
            Load += UC_AccountManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAccountList).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblAdd;
        private Panel panel2;
        private Label lblEdit;
        private Panel panel3;
        private Label lblDelete;
        private Panel panel4;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAccountList;
    }
}
