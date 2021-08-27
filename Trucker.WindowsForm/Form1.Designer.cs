namespace Trucker.WindowsForm
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trucker_tab = new System.Windows.Forms.TabControl();
            this.addTruck_Tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.addTruck_truckNoTxtBox = new System.Windows.Forms.TextBox();
            this.addTruck_truckAgeTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addTruck_driverNameTxtBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.addTruck_plateNoTxtBox = new System.Windows.Forms.TextBox();
            this.addTruck_addButton = new System.Windows.Forms.Button();
            this.getTruck_tab = new System.Windows.Forms.TabPage();
            this.getTruck_dataGrid = new System.Windows.Forms.DataGridView();
            this.getTruck_truckId_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTruck_truckNo_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTruck_plateNo_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTruck_driverName_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTruck_truckAge_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTruck_delete_dataGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addTrip_tab = new System.Windows.Forms.TabPage();
            this.addTripTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addTrip_rateTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addTrip_directCostTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTrip_clientTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addTrip_destTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addTrip_sourceTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addTrip_addButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addTrip_dateTxtBox = new System.Windows.Forms.TextBox();
            this.dateGuideLabel = new System.Windows.Forms.Label();
            this.addTrip_tuckNoComboBox = new System.Windows.Forms.ComboBox();
            this.getTrip_tab = new System.Windows.Forms.TabPage();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.clientFilterLabel = new System.Windows.Forms.Label();
            this.getTrip_clientComboBox = new System.Windows.Forms.ComboBox();
            this.getTrip_filterButton = new System.Windows.Forms.Button();
            this.truckNoFilterLabel = new System.Windows.Forms.Label();
            this.getTrip_truckNoComboBox = new System.Windows.Forms.ComboBox();
            this.getTrip_dataGrid = new System.Windows.Forms.DataGridView();
            this.getTrip_tripId_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_truckNo_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_date_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_client_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_source_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_destination_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_directCost_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_rate_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTrip_delete_dataGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addMaintenance_tab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addMaintenance_costTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.addMaintenance_typeTxtBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.maintTruckNoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.addMaintenance_dateTxtBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addMaintenance_addButton = new System.Windows.Forms.Button();
            this.addMaintenance_truckNoComboBox = new System.Windows.Forms.ComboBox();
            this.getMaintenance_tab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getMaintenance_filterButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.getMaintenance_truckNoComboBox = new System.Windows.Forms.ComboBox();
            this.getMaintenance_dataGrid = new System.Windows.Forms.DataGridView();
            this.getMaintenance_maintenanceId_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMaintenance_truckNo_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMaintenance_date_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMaintenance_type_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMaintenance_cost_dataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getMaintenance_delete_dataGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.incomeStatement_tab = new System.Windows.Forms.TabPage();
            this.incomeStatementTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.revenueLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.incomeStatement_revenueTxtBox = new System.Windows.Forms.TextBox();
            this.totalDirectCostLabel = new System.Windows.Forms.Label();
            this.grossProfitLabel = new System.Windows.Forms.Label();
            this.incomeStatement_grossProfitTxtBox = new System.Windows.Forms.TextBox();
            this.totalMaintenanceCostLabel = new System.Windows.Forms.Label();
            this.incomeStatement_maintFeeTxtBox = new System.Windows.Forms.TextBox();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.incomeStatement_directCostTxtBox = new System.Windows.Forms.TextBox();
            this.incomeStatement_netIncomeTxtBox = new System.Windows.Forms.TextBox();
            this.incomeStateFilterBox = new System.Windows.Forms.GroupBox();
            this.incomeStatement_filterButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getTruck_filterButton = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.getTruck_truckNoComboBox = new System.Windows.Forms.ComboBox();
            this.incomeStatement_checkedComboBox = new Trucker.WindowsForm.CheckedComboBox();
            this.trucker_tab.SuspendLayout();
            this.addTruck_Tab.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.getTruck_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getTruck_dataGrid)).BeginInit();
            this.addTrip_tab.SuspendLayout();
            this.addTripTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.getTrip_tab.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getTrip_dataGrid)).BeginInit();
            this.addMaintenance_tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.getMaintenance_tab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMaintenance_dataGrid)).BeginInit();
            this.incomeStatement_tab.SuspendLayout();
            this.incomeStatementTableLayout.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.incomeStateFilterBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trucker_tab
            // 
            this.trucker_tab.Controls.Add(this.addTruck_Tab);
            this.trucker_tab.Controls.Add(this.getTruck_tab);
            this.trucker_tab.Controls.Add(this.addTrip_tab);
            this.trucker_tab.Controls.Add(this.getTrip_tab);
            this.trucker_tab.Controls.Add(this.addMaintenance_tab);
            this.trucker_tab.Controls.Add(this.getMaintenance_tab);
            this.trucker_tab.Controls.Add(this.incomeStatement_tab);
            this.trucker_tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trucker_tab.Location = new System.Drawing.Point(0, 0);
            this.trucker_tab.Name = "trucker_tab";
            this.trucker_tab.SelectedIndex = 0;
            this.trucker_tab.Size = new System.Drawing.Size(846, 482);
            this.trucker_tab.TabIndex = 0;
            // 
            // addTruck_Tab
            // 
            this.addTruck_Tab.Controls.Add(this.tableLayoutPanel2);
            this.addTruck_Tab.Location = new System.Drawing.Point(4, 25);
            this.addTruck_Tab.Name = "addTruck_Tab";
            this.addTruck_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.addTruck_Tab.Size = new System.Drawing.Size(838, 453);
            this.addTruck_Tab.TabIndex = 5;
            this.addTruck_Tab.Text = "Add Truck";
            this.addTruck_Tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.addTruck_truckNoTxtBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.addTruck_truckAgeTxtBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.addTruck_driverNameTxtBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.addTruck_addButton, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(832, 447);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // addTruck_truckNoTxtBox
            // 
            this.addTruck_truckNoTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTruck_truckNoTxtBox.Location = new System.Drawing.Point(169, 56);
            this.addTruck_truckNoTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTruck_truckNoTxtBox.Name = "addTruck_truckNoTxtBox";
            this.addTruck_truckNoTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTruck_truckNoTxtBox.TabIndex = 1;
            // 
            // addTruck_truckAgeTxtBox
            // 
            this.addTruck_truckAgeTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTruck_truckAgeTxtBox.Location = new System.Drawing.Point(169, 188);
            this.addTruck_truckAgeTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTruck_truckAgeTxtBox.Name = "addTruck_truckAgeTxtBox";
            this.addTruck_truckAgeTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTruck_truckAgeTxtBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(90, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 44);
            this.label10.TabIndex = 8;
            this.label10.Text = "Truck Age";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTruck_driverNameTxtBox
            // 
            this.addTruck_driverNameTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTruck_driverNameTxtBox.Location = new System.Drawing.Point(169, 144);
            this.addTruck_driverNameTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTruck_driverNameTxtBox.Name = "addTruck_driverNameTxtBox";
            this.addTruck_driverNameTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTruck_driverNameTxtBox.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Right;
            this.label14.Location = new System.Drawing.Point(66, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 44);
            this.label14.TabIndex = 6;
            this.label14.Text = "Driver\'s Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Location = new System.Drawing.Point(101, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 44);
            this.label16.TabIndex = 0;
            this.label16.Text = "Plate No";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Right;
            this.label17.Location = new System.Drawing.Point(97, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 44);
            this.label17.TabIndex = 15;
            this.label17.Text = "Truck No";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.addTruck_plateNoTxtBox);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(169, 91);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(660, 38);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // addTruck_plateNoTxtBox
            // 
            this.addTruck_plateNoTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTruck_plateNoTxtBox.Location = new System.Drawing.Point(3, 12);
            this.addTruck_plateNoTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTruck_plateNoTxtBox.Name = "addTruck_plateNoTxtBox";
            this.addTruck_plateNoTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTruck_plateNoTxtBox.TabIndex = 2;
            // 
            // addTruck_addButton
            // 
            this.addTruck_addButton.Location = new System.Drawing.Point(169, 223);
            this.addTruck_addButton.Name = "addTruck_addButton";
            this.addTruck_addButton.Size = new System.Drawing.Size(75, 38);
            this.addTruck_addButton.TabIndex = 16;
            this.addTruck_addButton.Text = "Add";
            this.addTruck_addButton.UseVisualStyleBackColor = true;
            this.addTruck_addButton.Click += new System.EventHandler(this.addTruck_ButtonClick);
            // 
            // getTruck_tab
            // 
            this.getTruck_tab.Controls.Add(this.groupBox2);
            this.getTruck_tab.Controls.Add(this.getTruck_dataGrid);
            this.getTruck_tab.Location = new System.Drawing.Point(4, 25);
            this.getTruck_tab.Name = "getTruck_tab";
            this.getTruck_tab.Size = new System.Drawing.Size(838, 453);
            this.getTruck_tab.TabIndex = 6;
            this.getTruck_tab.Text = "Get Truck";
            this.getTruck_tab.UseVisualStyleBackColor = true;
            // 
            // getTruck_dataGrid
            // 
            this.getTruck_dataGrid.AllowUserToAddRows = false;
            this.getTruck_dataGrid.AllowUserToDeleteRows = false;
            this.getTruck_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.getTruck_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getTruck_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getTruck_truckId_dataGrid,
            this.getTruck_truckNo_dataGrid,
            this.getTruck_plateNo_dataGrid,
            this.getTruck_driverName_dataGrid,
            this.getTruck_truckAge_dataGrid,
            this.getTruck_delete_dataGrid});
            this.getTruck_dataGrid.Location = new System.Drawing.Point(28, 121);
            this.getTruck_dataGrid.Name = "getTruck_dataGrid";
            this.getTruck_dataGrid.RowTemplate.Height = 24;
            this.getTruck_dataGrid.Size = new System.Drawing.Size(779, 301);
            this.getTruck_dataGrid.TabIndex = 1;
            this.getTruck_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetTruck_DataGrid_CellContentClick);
            // 
            // getTruck_truckId_dataGrid
            // 
            this.getTruck_truckId_dataGrid.HeaderText = "Truck ID";
            this.getTruck_truckId_dataGrid.Name = "getTruck_truckId_dataGrid";
            this.getTruck_truckId_dataGrid.ReadOnly = true;
            this.getTruck_truckId_dataGrid.Visible = false;
            this.getTruck_truckId_dataGrid.Width = 90;
            // 
            // getTruck_truckNo_dataGrid
            // 
            this.getTruck_truckNo_dataGrid.HeaderText = "Truck No";
            this.getTruck_truckNo_dataGrid.Name = "getTruck_truckNo_dataGrid";
            this.getTruck_truckNo_dataGrid.Width = 95;
            // 
            // getTruck_plateNo_dataGrid
            // 
            this.getTruck_plateNo_dataGrid.HeaderText = "Plate No";
            this.getTruck_plateNo_dataGrid.Name = "getTruck_plateNo_dataGrid";
            this.getTruck_plateNo_dataGrid.Width = 91;
            // 
            // getTruck_driverName_dataGrid
            // 
            this.getTruck_driverName_dataGrid.HeaderText = "Driver\'s Name";
            this.getTruck_driverName_dataGrid.Name = "getTruck_driverName_dataGrid";
            this.getTruck_driverName_dataGrid.Width = 126;
            // 
            // getTruck_truckAge_dataGrid
            // 
            this.getTruck_truckAge_dataGrid.HeaderText = "Truck Age";
            this.getTruck_truckAge_dataGrid.Name = "getTruck_truckAge_dataGrid";
            this.getTruck_truckAge_dataGrid.Width = 102;
            // 
            // getTruck_delete_dataGrid
            // 
            this.getTruck_delete_dataGrid.HeaderText = "Action";
            this.getTruck_delete_dataGrid.Name = "getTruck_delete_dataGrid";
            this.getTruck_delete_dataGrid.Text = "Delete";
            this.getTruck_delete_dataGrid.UseColumnTextForButtonValue = true;
            this.getTruck_delete_dataGrid.Width = 53;
            // 
            // addTrip_tab
            // 
            this.addTrip_tab.Controls.Add(this.addTripTableLayoutPanel);
            this.addTrip_tab.Location = new System.Drawing.Point(4, 25);
            this.addTrip_tab.Name = "addTrip_tab";
            this.addTrip_tab.Padding = new System.Windows.Forms.Padding(3);
            this.addTrip_tab.Size = new System.Drawing.Size(838, 453);
            this.addTrip_tab.TabIndex = 0;
            this.addTrip_tab.Text = "Add Trip";
            this.addTrip_tab.UseVisualStyleBackColor = true;
            // 
            // addTripTableLayoutPanel
            // 
            this.addTripTableLayoutPanel.ColumnCount = 2;
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_rateTxtBox, 1, 7);
            this.addTripTableLayoutPanel.Controls.Add(this.label5, 0, 7);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_directCostTxtBox, 1, 6);
            this.addTripTableLayoutPanel.Controls.Add(this.label4, 0, 6);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_clientTxtBox, 1, 5);
            this.addTripTableLayoutPanel.Controls.Add(this.label2, 0, 5);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_destTxtBox, 1, 4);
            this.addTripTableLayoutPanel.Controls.Add(this.label7, 0, 4);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_sourceTxtBox, 1, 3);
            this.addTripTableLayoutPanel.Controls.Add(this.label6, 0, 3);
            this.addTripTableLayoutPanel.Controls.Add(this.label1, 0, 2);
            this.addTripTableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_addButton, 1, 8);
            this.addTripTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.addTripTableLayoutPanel.Controls.Add(this.addTrip_tuckNoComboBox, 1, 1);
            this.addTripTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTripTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.addTripTableLayoutPanel.Name = "addTripTableLayoutPanel";
            this.addTripTableLayoutPanel.RowCount = 10;
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.addTripTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.addTripTableLayoutPanel.Size = new System.Drawing.Size(832, 447);
            this.addTripTableLayoutPanel.TabIndex = 1;
            // 
            // addTrip_rateTxtBox
            // 
            this.addTrip_rateTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_rateTxtBox.Location = new System.Drawing.Point(169, 320);
            this.addTrip_rateTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_rateTxtBox.Name = "addTrip_rateTxtBox";
            this.addTrip_rateTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_rateTxtBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(125, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 44);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTrip_directCostTxtBox
            // 
            this.addTrip_directCostTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_directCostTxtBox.Location = new System.Drawing.Point(169, 276);
            this.addTrip_directCostTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_directCostTxtBox.Name = "addTrip_directCostTxtBox";
            this.addTrip_directCostTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_directCostTxtBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(86, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 44);
            this.label4.TabIndex = 20;
            this.label4.Text = "Direct Cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTrip_clientTxtBox
            // 
            this.addTrip_clientTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_clientTxtBox.Location = new System.Drawing.Point(169, 232);
            this.addTrip_clientTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_clientTxtBox.Name = "addTrip_clientTxtBox";
            this.addTrip_clientTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_clientTxtBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(120, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Client";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTrip_destTxtBox
            // 
            this.addTrip_destTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_destTxtBox.Location = new System.Drawing.Point(169, 188);
            this.addTrip_destTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_destTxtBox.Name = "addTrip_destTxtBox";
            this.addTrip_destTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_destTxtBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(84, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 44);
            this.label7.TabIndex = 8;
            this.label7.Text = "Destination";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTrip_sourceTxtBox
            // 
            this.addTrip_sourceTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_sourceTxtBox.Location = new System.Drawing.Point(169, 144);
            this.addTrip_sourceTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_sourceTxtBox.Name = "addTrip_sourceTxtBox";
            this.addTrip_sourceTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_sourceTxtBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(110, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 44);
            this.label6.TabIndex = 6;
            this.label6.Text = "Source";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(125, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(97, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "Truck No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addTrip_addButton
            // 
            this.addTrip_addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_addButton.Location = new System.Drawing.Point(169, 355);
            this.addTrip_addButton.Name = "addTrip_addButton";
            this.addTrip_addButton.Size = new System.Drawing.Size(75, 38);
            this.addTrip_addButton.TabIndex = 8;
            this.addTrip_addButton.Text = "Add";
            this.addTrip_addButton.UseVisualStyleBackColor = true;
            this.addTrip_addButton.Click += new System.EventHandler(this.addTrip_ButtonClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addTrip_dateTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.dateGuideLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 91);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(660, 38);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // addTrip_dateTxtBox
            // 
            this.addTrip_dateTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_dateTxtBox.Location = new System.Drawing.Point(3, 12);
            this.addTrip_dateTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_dateTxtBox.Name = "addTrip_dateTxtBox";
            this.addTrip_dateTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addTrip_dateTxtBox.TabIndex = 2;
            // 
            // dateGuideLabel
            // 
            this.dateGuideLabel.AutoSize = true;
            this.dateGuideLabel.Location = new System.Drawing.Point(109, 15);
            this.dateGuideLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.dateGuideLabel.Name = "dateGuideLabel";
            this.dateGuideLabel.Size = new System.Drawing.Size(82, 17);
            this.dateGuideLabel.TabIndex = 9;
            this.dateGuideLabel.Text = "mm/dd/yyyy";
            // 
            // addTrip_tuckNoComboBox
            // 
            this.addTrip_tuckNoComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addTrip_tuckNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTrip_tuckNoComboBox.FormattingEnabled = true;
            this.addTrip_tuckNoComboBox.Location = new System.Drawing.Point(169, 56);
            this.addTrip_tuckNoComboBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addTrip_tuckNoComboBox.Name = "addTrip_tuckNoComboBox";
            this.addTrip_tuckNoComboBox.Size = new System.Drawing.Size(100, 24);
            this.addTrip_tuckNoComboBox.TabIndex = 23;
            // 
            // getTrip_tab
            // 
            this.getTrip_tab.Controls.Add(this.filtersGroupBox);
            this.getTrip_tab.Controls.Add(this.getTrip_dataGrid);
            this.getTrip_tab.Location = new System.Drawing.Point(4, 25);
            this.getTrip_tab.Name = "getTrip_tab";
            this.getTrip_tab.Padding = new System.Windows.Forms.Padding(3);
            this.getTrip_tab.Size = new System.Drawing.Size(838, 453);
            this.getTrip_tab.TabIndex = 1;
            this.getTrip_tab.Text = "Get Trip";
            this.getTrip_tab.UseVisualStyleBackColor = true;
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.clientFilterLabel);
            this.filtersGroupBox.Controls.Add(this.getTrip_clientComboBox);
            this.filtersGroupBox.Controls.Add(this.getTrip_filterButton);
            this.filtersGroupBox.Controls.Add(this.truckNoFilterLabel);
            this.filtersGroupBox.Controls.Add(this.getTrip_truckNoComboBox);
            this.filtersGroupBox.Location = new System.Drawing.Point(27, 19);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(396, 82);
            this.filtersGroupBox.TabIndex = 1;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // clientFilterLabel
            // 
            this.clientFilterLabel.AutoSize = true;
            this.clientFilterLabel.Location = new System.Drawing.Point(133, 25);
            this.clientFilterLabel.Name = "clientFilterLabel";
            this.clientFilterLabel.Size = new System.Drawing.Size(43, 17);
            this.clientFilterLabel.TabIndex = 4;
            this.clientFilterLabel.Text = "Client";
            // 
            // getTrip_clientComboBox
            // 
            this.getTrip_clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getTrip_clientComboBox.FormattingEnabled = true;
            this.getTrip_clientComboBox.Location = new System.Drawing.Point(136, 45);
            this.getTrip_clientComboBox.Name = "getTrip_clientComboBox";
            this.getTrip_clientComboBox.Size = new System.Drawing.Size(121, 24);
            this.getTrip_clientComboBox.TabIndex = 3;
            // 
            // getTrip_filterButton
            // 
            this.getTrip_filterButton.Location = new System.Drawing.Point(263, 47);
            this.getTrip_filterButton.Name = "getTrip_filterButton";
            this.getTrip_filterButton.Size = new System.Drawing.Size(75, 23);
            this.getTrip_filterButton.TabIndex = 2;
            this.getTrip_filterButton.Text = "Filter";
            this.getTrip_filterButton.UseVisualStyleBackColor = true;
            this.getTrip_filterButton.Click += new System.EventHandler(this.getTrip_filterButtonClicked);
            // 
            // truckNoFilterLabel
            // 
            this.truckNoFilterLabel.AutoSize = true;
            this.truckNoFilterLabel.Location = new System.Drawing.Point(6, 26);
            this.truckNoFilterLabel.Name = "truckNoFilterLabel";
            this.truckNoFilterLabel.Size = new System.Drawing.Size(66, 17);
            this.truckNoFilterLabel.TabIndex = 1;
            this.truckNoFilterLabel.Text = "Truck No";
            // 
            // getTrip_truckNoComboBox
            // 
            this.getTrip_truckNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getTrip_truckNoComboBox.FormattingEnabled = true;
            this.getTrip_truckNoComboBox.Location = new System.Drawing.Point(9, 46);
            this.getTrip_truckNoComboBox.Name = "getTrip_truckNoComboBox";
            this.getTrip_truckNoComboBox.Size = new System.Drawing.Size(121, 24);
            this.getTrip_truckNoComboBox.TabIndex = 0;
            // 
            // getTrip_dataGrid
            // 
            this.getTrip_dataGrid.AllowUserToAddRows = false;
            this.getTrip_dataGrid.AllowUserToDeleteRows = false;
            this.getTrip_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.getTrip_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getTrip_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getTrip_tripId_dataGrid,
            this.getTrip_truckNo_dataGrid,
            this.getTrip_date_dataGrid,
            this.getTrip_client_dataGrid,
            this.getTrip_source_dataGrid,
            this.getTrip_destination_dataGrid,
            this.getTrip_directCost_dataGrid,
            this.getTrip_rate_dataGrid,
            this.getTrip_delete_dataGrid});
            this.getTrip_dataGrid.Location = new System.Drawing.Point(27, 129);
            this.getTrip_dataGrid.Name = "getTrip_dataGrid";
            this.getTrip_dataGrid.RowTemplate.Height = 24;
            this.getTrip_dataGrid.Size = new System.Drawing.Size(779, 301);
            this.getTrip_dataGrid.TabIndex = 0;
            this.getTrip_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetTrip_DataGrid_CellContentClick);
            // 
            // getTrip_tripId_dataGrid
            // 
            this.getTrip_tripId_dataGrid.HeaderText = "Trip ID";
            this.getTrip_tripId_dataGrid.Name = "getTrip_tripId_dataGrid";
            this.getTrip_tripId_dataGrid.ReadOnly = true;
            this.getTrip_tripId_dataGrid.Visible = false;
            this.getTrip_tripId_dataGrid.Width = 79;
            // 
            // getTrip_truckNo_dataGrid
            // 
            this.getTrip_truckNo_dataGrid.HeaderText = "Truck No";
            this.getTrip_truckNo_dataGrid.Name = "getTrip_truckNo_dataGrid";
            this.getTrip_truckNo_dataGrid.Width = 95;
            // 
            // getTrip_date_dataGrid
            // 
            this.getTrip_date_dataGrid.HeaderText = "Date";
            this.getTrip_date_dataGrid.Name = "getTrip_date_dataGrid";
            this.getTrip_date_dataGrid.Width = 67;
            // 
            // getTrip_client_dataGrid
            // 
            this.getTrip_client_dataGrid.HeaderText = "Client";
            this.getTrip_client_dataGrid.Name = "getTrip_client_dataGrid";
            this.getTrip_client_dataGrid.Width = 72;
            // 
            // getTrip_source_dataGrid
            // 
            this.getTrip_source_dataGrid.HeaderText = "Source";
            this.getTrip_source_dataGrid.Name = "getTrip_source_dataGrid";
            this.getTrip_source_dataGrid.Width = 82;
            // 
            // getTrip_destination_dataGrid
            // 
            this.getTrip_destination_dataGrid.HeaderText = "Destination";
            this.getTrip_destination_dataGrid.Name = "getTrip_destination_dataGrid";
            this.getTrip_destination_dataGrid.Width = 108;
            // 
            // getTrip_directCost_dataGrid
            // 
            this.getTrip_directCost_dataGrid.HeaderText = "Direct Cost";
            this.getTrip_directCost_dataGrid.Name = "getTrip_directCost_dataGrid";
            this.getTrip_directCost_dataGrid.Width = 106;
            // 
            // getTrip_rate_dataGrid
            // 
            this.getTrip_rate_dataGrid.HeaderText = "Rate";
            this.getTrip_rate_dataGrid.Name = "getTrip_rate_dataGrid";
            this.getTrip_rate_dataGrid.Width = 67;
            // 
            // getTrip_delete_dataGrid
            // 
            this.getTrip_delete_dataGrid.HeaderText = "Action";
            this.getTrip_delete_dataGrid.Name = "getTrip_delete_dataGrid";
            this.getTrip_delete_dataGrid.Text = "Delete";
            this.getTrip_delete_dataGrid.UseColumnTextForButtonValue = true;
            this.getTrip_delete_dataGrid.Width = 53;
            // 
            // addMaintenance_tab
            // 
            this.addMaintenance_tab.Controls.Add(this.tableLayoutPanel1);
            this.addMaintenance_tab.Location = new System.Drawing.Point(4, 25);
            this.addMaintenance_tab.Name = "addMaintenance_tab";
            this.addMaintenance_tab.Padding = new System.Windows.Forms.Padding(3);
            this.addMaintenance_tab.Size = new System.Drawing.Size(838, 453);
            this.addMaintenance_tab.TabIndex = 3;
            this.addMaintenance_tab.Text = "Add Maintenance";
            this.addMaintenance_tab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.addMaintenance_costTxtBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.addMaintenance_typeTxtBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.maintTruckNoLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addMaintenance_addButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.addMaintenance_truckNoComboBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 447);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addMaintenance_costTxtBox
            // 
            this.addMaintenance_costTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addMaintenance_costTxtBox.Location = new System.Drawing.Point(169, 188);
            this.addMaintenance_costTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addMaintenance_costTxtBox.Name = "addMaintenance_costTxtBox";
            this.addMaintenance_costTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addMaintenance_costTxtBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(127, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 44);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cost";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addMaintenance_typeTxtBox
            // 
            this.addMaintenance_typeTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addMaintenance_typeTxtBox.Location = new System.Drawing.Point(169, 144);
            this.addMaintenance_typeTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addMaintenance_typeTxtBox.Name = "addMaintenance_typeTxtBox";
            this.addMaintenance_typeTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addMaintenance_typeTxtBox.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Right;
            this.label12.Location = new System.Drawing.Point(123, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 44);
            this.label12.TabIndex = 6;
            this.label12.Text = "Type";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Right;
            this.label13.Location = new System.Drawing.Point(125, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 44);
            this.label13.TabIndex = 0;
            this.label13.Text = "Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maintTruckNoLabel
            // 
            this.maintTruckNoLabel.AutoSize = true;
            this.maintTruckNoLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.maintTruckNoLabel.Location = new System.Drawing.Point(97, 44);
            this.maintTruckNoLabel.Name = "maintTruckNoLabel";
            this.maintTruckNoLabel.Size = new System.Drawing.Size(66, 44);
            this.maintTruckNoLabel.TabIndex = 15;
            this.maintTruckNoLabel.Text = "Truck No";
            this.maintTruckNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.addMaintenance_dateTxtBox);
            this.flowLayoutPanel3.Controls.Add(this.label15);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(169, 91);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(660, 38);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // addMaintenance_dateTxtBox
            // 
            this.addMaintenance_dateTxtBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addMaintenance_dateTxtBox.Location = new System.Drawing.Point(3, 12);
            this.addMaintenance_dateTxtBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addMaintenance_dateTxtBox.Name = "addMaintenance_dateTxtBox";
            this.addMaintenance_dateTxtBox.Size = new System.Drawing.Size(100, 22);
            this.addMaintenance_dateTxtBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(109, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 15, 3, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "mm/dd/yyyy";
            // 
            // addMaintenance_addButton
            // 
            this.addMaintenance_addButton.Location = new System.Drawing.Point(169, 223);
            this.addMaintenance_addButton.Name = "addMaintenance_addButton";
            this.addMaintenance_addButton.Size = new System.Drawing.Size(75, 38);
            this.addMaintenance_addButton.TabIndex = 16;
            this.addMaintenance_addButton.Text = "Add";
            this.addMaintenance_addButton.UseVisualStyleBackColor = true;
            this.addMaintenance_addButton.Click += new System.EventHandler(this.addMaintenance_ButtonClick);
            // 
            // addMaintenance_truckNoComboBox
            // 
            this.addMaintenance_truckNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addMaintenance_truckNoComboBox.FormattingEnabled = true;
            this.addMaintenance_truckNoComboBox.Location = new System.Drawing.Point(169, 56);
            this.addMaintenance_truckNoComboBox.Margin = new System.Windows.Forms.Padding(3, 12, 3, 12);
            this.addMaintenance_truckNoComboBox.Name = "addMaintenance_truckNoComboBox";
            this.addMaintenance_truckNoComboBox.Size = new System.Drawing.Size(100, 24);
            this.addMaintenance_truckNoComboBox.TabIndex = 17;
            // 
            // getMaintenance_tab
            // 
            this.getMaintenance_tab.Controls.Add(this.groupBox1);
            this.getMaintenance_tab.Controls.Add(this.getMaintenance_dataGrid);
            this.getMaintenance_tab.Location = new System.Drawing.Point(4, 25);
            this.getMaintenance_tab.Name = "getMaintenance_tab";
            this.getMaintenance_tab.Padding = new System.Windows.Forms.Padding(3);
            this.getMaintenance_tab.Size = new System.Drawing.Size(838, 453);
            this.getMaintenance_tab.TabIndex = 4;
            this.getMaintenance_tab.Text = "Get Maintenance";
            this.getMaintenance_tab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.getMaintenance_filterButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.getMaintenance_truckNoComboBox);
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // getMaintenance_filterButton
            // 
            this.getMaintenance_filterButton.Location = new System.Drawing.Point(136, 46);
            this.getMaintenance_filterButton.Name = "getMaintenance_filterButton";
            this.getMaintenance_filterButton.Size = new System.Drawing.Size(75, 23);
            this.getMaintenance_filterButton.TabIndex = 2;
            this.getMaintenance_filterButton.Text = "Filter";
            this.getMaintenance_filterButton.UseVisualStyleBackColor = true;
            this.getMaintenance_filterButton.Click += new System.EventHandler(this.getMaintenance_FilterButtonClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Truck No";
            // 
            // getMaintenance_truckNoComboBox
            // 
            this.getMaintenance_truckNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getMaintenance_truckNoComboBox.FormattingEnabled = true;
            this.getMaintenance_truckNoComboBox.Location = new System.Drawing.Point(9, 46);
            this.getMaintenance_truckNoComboBox.Name = "getMaintenance_truckNoComboBox";
            this.getMaintenance_truckNoComboBox.Size = new System.Drawing.Size(121, 24);
            this.getMaintenance_truckNoComboBox.TabIndex = 0;
            // 
            // getMaintenance_dataGrid
            // 
            this.getMaintenance_dataGrid.AllowUserToAddRows = false;
            this.getMaintenance_dataGrid.AllowUserToDeleteRows = false;
            this.getMaintenance_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.getMaintenance_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.getMaintenance_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.getMaintenance_maintenanceId_dataGrid,
            this.getMaintenance_truckNo_dataGrid,
            this.getMaintenance_date_dataGrid,
            this.getMaintenance_type_dataGrid,
            this.getMaintenance_cost_dataGrid,
            this.getMaintenance_delete_dataGrid});
            this.getMaintenance_dataGrid.Location = new System.Drawing.Point(28, 124);
            this.getMaintenance_dataGrid.Name = "getMaintenance_dataGrid";
            this.getMaintenance_dataGrid.RowTemplate.Height = 24;
            this.getMaintenance_dataGrid.Size = new System.Drawing.Size(779, 301);
            this.getMaintenance_dataGrid.TabIndex = 1;
            this.getMaintenance_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetMaintenance_DataGrid_CellContentClick);
            // 
            // getMaintenance_maintenanceId_dataGrid
            // 
            this.getMaintenance_maintenanceId_dataGrid.HeaderText = "Maintenance ID";
            this.getMaintenance_maintenanceId_dataGrid.Name = "getMaintenance_maintenanceId_dataGrid";
            this.getMaintenance_maintenanceId_dataGrid.ReadOnly = true;
            this.getMaintenance_maintenanceId_dataGrid.Visible = false;
            this.getMaintenance_maintenanceId_dataGrid.Width = 135;
            // 
            // getMaintenance_truckNo_dataGrid
            // 
            this.getMaintenance_truckNo_dataGrid.HeaderText = "Truck No";
            this.getMaintenance_truckNo_dataGrid.Name = "getMaintenance_truckNo_dataGrid";
            this.getMaintenance_truckNo_dataGrid.Width = 95;
            // 
            // getMaintenance_date_dataGrid
            // 
            this.getMaintenance_date_dataGrid.HeaderText = "Date";
            this.getMaintenance_date_dataGrid.Name = "getMaintenance_date_dataGrid";
            this.getMaintenance_date_dataGrid.Width = 67;
            // 
            // getMaintenance_type_dataGrid
            // 
            this.getMaintenance_type_dataGrid.HeaderText = "Type";
            this.getMaintenance_type_dataGrid.Name = "getMaintenance_type_dataGrid";
            this.getMaintenance_type_dataGrid.Width = 69;
            // 
            // getMaintenance_cost_dataGrid
            // 
            this.getMaintenance_cost_dataGrid.HeaderText = "Cost";
            this.getMaintenance_cost_dataGrid.Name = "getMaintenance_cost_dataGrid";
            this.getMaintenance_cost_dataGrid.Width = 65;
            // 
            // getMaintenance_delete_dataGrid
            // 
            this.getMaintenance_delete_dataGrid.HeaderText = "Action";
            this.getMaintenance_delete_dataGrid.Name = "getMaintenance_delete_dataGrid";
            this.getMaintenance_delete_dataGrid.Text = "Delete";
            this.getMaintenance_delete_dataGrid.UseColumnTextForButtonValue = true;
            this.getMaintenance_delete_dataGrid.Width = 53;
            // 
            // incomeStatement_tab
            // 
            this.incomeStatement_tab.Controls.Add(this.incomeStatementTableLayout);
            this.incomeStatement_tab.Location = new System.Drawing.Point(4, 25);
            this.incomeStatement_tab.Name = "incomeStatement_tab";
            this.incomeStatement_tab.Padding = new System.Windows.Forms.Padding(3);
            this.incomeStatement_tab.Size = new System.Drawing.Size(838, 453);
            this.incomeStatement_tab.TabIndex = 2;
            this.incomeStatement_tab.Text = "Income Statement";
            this.incomeStatement_tab.UseVisualStyleBackColor = true;
            // 
            // incomeStatementTableLayout
            // 
            this.incomeStatementTableLayout.ColumnCount = 2;
            this.incomeStatementTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.incomeStatementTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.incomeStatementTableLayout.Controls.Add(this.revenueLabel, 0, 1);
            this.incomeStatementTableLayout.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.incomeStatementTableLayout.Controls.Add(this.totalDirectCostLabel, 0, 2);
            this.incomeStatementTableLayout.Controls.Add(this.grossProfitLabel, 0, 3);
            this.incomeStatementTableLayout.Controls.Add(this.incomeStatement_grossProfitTxtBox, 1, 3);
            this.incomeStatementTableLayout.Controls.Add(this.totalMaintenanceCostLabel, 0, 4);
            this.incomeStatementTableLayout.Controls.Add(this.incomeStatement_maintFeeTxtBox, 1, 4);
            this.incomeStatementTableLayout.Controls.Add(this.netIncomeLabel, 0, 5);
            this.incomeStatementTableLayout.Controls.Add(this.incomeStatement_directCostTxtBox, 1, 2);
            this.incomeStatementTableLayout.Controls.Add(this.incomeStatement_netIncomeTxtBox, 1, 5);
            this.incomeStatementTableLayout.Controls.Add(this.incomeStateFilterBox, 0, 0);
            this.incomeStatementTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeStatementTableLayout.Location = new System.Drawing.Point(3, 3);
            this.incomeStatementTableLayout.Name = "incomeStatementTableLayout";
            this.incomeStatementTableLayout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.incomeStatementTableLayout.RowCount = 6;
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.incomeStatementTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.incomeStatementTableLayout.Size = new System.Drawing.Size(832, 447);
            this.incomeStatementTableLayout.TabIndex = 0;
            // 
            // revenueLabel
            // 
            this.revenueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.revenueLabel.AutoSize = true;
            this.revenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenueLabel.Location = new System.Drawing.Point(76, 99);
            this.revenueLabel.Name = "revenueLabel";
            this.revenueLabel.Size = new System.Drawing.Size(87, 24);
            this.revenueLabel.TabIndex = 0;
            this.revenueLabel.Text = "Revenue";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.incomeStatement_revenueTxtBox);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(169, 77);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(660, 68);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // incomeStatement_revenueTxtBox
            // 
            this.incomeStatement_revenueTxtBox.Enabled = false;
            this.incomeStatement_revenueTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStatement_revenueTxtBox.Location = new System.Drawing.Point(3, 30);
            this.incomeStatement_revenueTxtBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.incomeStatement_revenueTxtBox.Name = "incomeStatement_revenueTxtBox";
            this.incomeStatement_revenueTxtBox.Size = new System.Drawing.Size(91, 28);
            this.incomeStatement_revenueTxtBox.TabIndex = 0;
            // 
            // totalDirectCostLabel
            // 
            this.totalDirectCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalDirectCostLabel.AutoSize = true;
            this.totalDirectCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDirectCostLabel.Location = new System.Drawing.Point(63, 173);
            this.totalDirectCostLabel.Name = "totalDirectCostLabel";
            this.totalDirectCostLabel.Size = new System.Drawing.Size(100, 24);
            this.totalDirectCostLabel.TabIndex = 2;
            this.totalDirectCostLabel.Text = "Direct Cost";
            // 
            // grossProfitLabel
            // 
            this.grossProfitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grossProfitLabel.AutoSize = true;
            this.grossProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossProfitLabel.Location = new System.Drawing.Point(63, 247);
            this.grossProfitLabel.Name = "grossProfitLabel";
            this.grossProfitLabel.Size = new System.Drawing.Size(100, 24);
            this.grossProfitLabel.TabIndex = 4;
            this.grossProfitLabel.Text = "Grost Profit";
            // 
            // incomeStatement_grossProfitTxtBox
            // 
            this.incomeStatement_grossProfitTxtBox.Enabled = false;
            this.incomeStatement_grossProfitTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStatement_grossProfitTxtBox.Location = new System.Drawing.Point(169, 252);
            this.incomeStatement_grossProfitTxtBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.incomeStatement_grossProfitTxtBox.Name = "incomeStatement_grossProfitTxtBox";
            this.incomeStatement_grossProfitTxtBox.Size = new System.Drawing.Size(94, 28);
            this.incomeStatement_grossProfitTxtBox.TabIndex = 5;
            // 
            // totalMaintenanceCostLabel
            // 
            this.totalMaintenanceCostLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totalMaintenanceCostLabel.AutoSize = true;
            this.totalMaintenanceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMaintenanceCostLabel.Location = new System.Drawing.Point(5, 321);
            this.totalMaintenanceCostLabel.Name = "totalMaintenanceCostLabel";
            this.totalMaintenanceCostLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalMaintenanceCostLabel.Size = new System.Drawing.Size(158, 24);
            this.totalMaintenanceCostLabel.TabIndex = 6;
            this.totalMaintenanceCostLabel.Text = "Maintenance Fee";
            this.totalMaintenanceCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incomeStatement_maintFeeTxtBox
            // 
            this.incomeStatement_maintFeeTxtBox.Enabled = false;
            this.incomeStatement_maintFeeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStatement_maintFeeTxtBox.Location = new System.Drawing.Point(169, 326);
            this.incomeStatement_maintFeeTxtBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.incomeStatement_maintFeeTxtBox.Name = "incomeStatement_maintFeeTxtBox";
            this.incomeStatement_maintFeeTxtBox.Size = new System.Drawing.Size(94, 28);
            this.incomeStatement_maintFeeTxtBox.TabIndex = 7;
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netIncomeLabel.Location = new System.Drawing.Point(56, 396);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(107, 24);
            this.netIncomeLabel.TabIndex = 8;
            this.netIncomeLabel.Text = "Net Income";
            // 
            // incomeStatement_directCostTxtBox
            // 
            this.incomeStatement_directCostTxtBox.Enabled = false;
            this.incomeStatement_directCostTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStatement_directCostTxtBox.Location = new System.Drawing.Point(169, 178);
            this.incomeStatement_directCostTxtBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.incomeStatement_directCostTxtBox.Name = "incomeStatement_directCostTxtBox";
            this.incomeStatement_directCostTxtBox.Size = new System.Drawing.Size(100, 28);
            this.incomeStatement_directCostTxtBox.TabIndex = 9;
            // 
            // incomeStatement_netIncomeTxtBox
            // 
            this.incomeStatement_netIncomeTxtBox.Enabled = false;
            this.incomeStatement_netIncomeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeStatement_netIncomeTxtBox.Location = new System.Drawing.Point(169, 400);
            this.incomeStatement_netIncomeTxtBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 30);
            this.incomeStatement_netIncomeTxtBox.Name = "incomeStatement_netIncomeTxtBox";
            this.incomeStatement_netIncomeTxtBox.Size = new System.Drawing.Size(94, 28);
            this.incomeStatement_netIncomeTxtBox.TabIndex = 3;
            // 
            // incomeStateFilterBox
            // 
            this.incomeStatementTableLayout.SetColumnSpan(this.incomeStateFilterBox, 2);
            this.incomeStateFilterBox.Controls.Add(this.incomeStatement_filterButton);
            this.incomeStateFilterBox.Controls.Add(this.label8);
            this.incomeStateFilterBox.Controls.Add(this.incomeStatement_checkedComboBox);
            this.incomeStateFilterBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incomeStateFilterBox.Location = new System.Drawing.Point(3, 3);
            this.incomeStateFilterBox.Name = "incomeStateFilterBox";
            this.incomeStateFilterBox.Size = new System.Drawing.Size(826, 68);
            this.incomeStateFilterBox.TabIndex = 10;
            this.incomeStateFilterBox.TabStop = false;
            this.incomeStateFilterBox.Text = "Filters";
            // 
            // incomeStatement_filterButton
            // 
            this.incomeStatement_filterButton.Location = new System.Drawing.Point(563, 34);
            this.incomeStatement_filterButton.Name = "incomeStatement_filterButton";
            this.incomeStatement_filterButton.Size = new System.Drawing.Size(75, 23);
            this.incomeStatement_filterButton.TabIndex = 5;
            this.incomeStatement_filterButton.Text = "Filter";
            this.incomeStatement_filterButton.UseVisualStyleBackColor = true;
            this.incomeStatement_filterButton.Click += new System.EventHandler(this.incomeStatement_FilterButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Truck No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getTruck_filterButton);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.getTruck_truckNoComboBox);
            this.groupBox2.Location = new System.Drawing.Point(28, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // getTruck_filterButton
            // 
            this.getTruck_filterButton.Location = new System.Drawing.Point(136, 46);
            this.getTruck_filterButton.Name = "getTruck_filterButton";
            this.getTruck_filterButton.Size = new System.Drawing.Size(75, 23);
            this.getTruck_filterButton.TabIndex = 2;
            this.getTruck_filterButton.Text = "Filter";
            this.getTruck_filterButton.UseVisualStyleBackColor = true;
            this.getTruck_filterButton.Click += new System.EventHandler(this.getTruck_filterButton_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 1;
            this.label18.Text = "Truck No";
            // 
            // getTruck_truckNoComboBox
            // 
            this.getTruck_truckNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.getTruck_truckNoComboBox.FormattingEnabled = true;
            this.getTruck_truckNoComboBox.Location = new System.Drawing.Point(9, 46);
            this.getTruck_truckNoComboBox.Name = "getTruck_truckNoComboBox";
            this.getTruck_truckNoComboBox.Size = new System.Drawing.Size(121, 24);
            this.getTruck_truckNoComboBox.TabIndex = 0;
            // 
            // incomeStatement_checkedComboBox
            // 
            this.incomeStatement_checkedComboBox.CheckOnClick = true;
            this.incomeStatement_checkedComboBox.DisplayMember = "Name";
            this.incomeStatement_checkedComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.incomeStatement_checkedComboBox.DropDownHeight = 1;
            this.incomeStatement_checkedComboBox.FormattingEnabled = true;
            this.incomeStatement_checkedComboBox.IntegralHeight = false;
            this.incomeStatement_checkedComboBox.Location = new System.Drawing.Point(64, 34);
            this.incomeStatement_checkedComboBox.Name = "incomeStatement_checkedComboBox";
            this.incomeStatement_checkedComboBox.Size = new System.Drawing.Size(493, 23);
            this.incomeStatement_checkedComboBox.TabIndex = 0;
            this.incomeStatement_checkedComboBox.ValueSeparator = ", ";
            this.incomeStatement_checkedComboBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkComboBox_ItemCheck);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 482);
            this.Controls.Add(this.trucker_tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trucker_tab.ResumeLayout(false);
            this.addTruck_Tab.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.getTruck_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.getTruck_dataGrid)).EndInit();
            this.addTrip_tab.ResumeLayout(false);
            this.addTripTableLayoutPanel.ResumeLayout(false);
            this.addTripTableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.getTrip_tab.ResumeLayout(false);
            this.filtersGroupBox.ResumeLayout(false);
            this.filtersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getTrip_dataGrid)).EndInit();
            this.addMaintenance_tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.getMaintenance_tab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getMaintenance_dataGrid)).EndInit();
            this.incomeStatement_tab.ResumeLayout(false);
            this.incomeStatementTableLayout.ResumeLayout(false);
            this.incomeStatementTableLayout.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.incomeStateFilterBox.ResumeLayout(false);
            this.incomeStateFilterBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl trucker_tab;
        private System.Windows.Forms.TabPage addTrip_tab;
        private System.Windows.Forms.TableLayoutPanel addTripTableLayoutPanel;
        private System.Windows.Forms.TextBox addTrip_rateTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addTrip_directCostTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addTrip_clientTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addTrip_destTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addTrip_sourceTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addTrip_addButton;
        private System.Windows.Forms.TabPage getTrip_tab;
        private System.Windows.Forms.DataGridView getTrip_dataGrid;
        private System.Windows.Forms.GroupBox filtersGroupBox;
        private System.Windows.Forms.Label truckNoFilterLabel;
        private System.Windows.Forms.ComboBox getTrip_truckNoComboBox;
        private System.Windows.Forms.Button getTrip_filterButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox addTrip_dateTxtBox;
        private System.Windows.Forms.Label dateGuideLabel;
        private System.Windows.Forms.Label clientFilterLabel;
        private System.Windows.Forms.ComboBox getTrip_clientComboBox;
        private System.Windows.Forms.TabPage incomeStatement_tab;
        private System.Windows.Forms.TableLayoutPanel incomeStatementTableLayout;
        private System.Windows.Forms.Label revenueLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox incomeStatement_revenueTxtBox;
        private System.Windows.Forms.Label totalDirectCostLabel;
        private System.Windows.Forms.TextBox incomeStatement_netIncomeTxtBox;
        private System.Windows.Forms.Label grossProfitLabel;
        private System.Windows.Forms.TextBox incomeStatement_grossProfitTxtBox;
        private System.Windows.Forms.TabPage addMaintenance_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox addMaintenance_costTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox addMaintenance_typeTxtBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label maintTruckNoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox addMaintenance_dateTxtBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button addMaintenance_addButton;
        private System.Windows.Forms.TabPage getMaintenance_tab;
        private System.Windows.Forms.DataGridView getMaintenance_dataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getMaintenance_filterButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox getMaintenance_truckNoComboBox;
        private System.Windows.Forms.Label totalMaintenanceCostLabel;
        private System.Windows.Forms.TextBox incomeStatement_maintFeeTxtBox;
        private System.Windows.Forms.TextBox incomeStatement_directCostTxtBox;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.GroupBox incomeStateFilterBox;
        private System.Windows.Forms.Button incomeStatement_filterButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage addTruck_Tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox addTruck_truckNoTxtBox;
        private System.Windows.Forms.TextBox addTruck_truckAgeTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox addTruck_driverNameTxtBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox addTruck_plateNoTxtBox;
        private System.Windows.Forms.Button addTruck_addButton;
        private System.Windows.Forms.TabPage getTruck_tab;
        private System.Windows.Forms.DataGridView getTruck_dataGrid;
        private System.Windows.Forms.ComboBox addTrip_tuckNoComboBox;
        private System.Windows.Forms.ComboBox addMaintenance_truckNoComboBox;
        private CheckedComboBox incomeStatement_checkedComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTruck_truckId_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTruck_truckNo_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTruck_plateNo_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTruck_driverName_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTruck_truckAge_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn getTruck_delete_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_tripId_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_truckNo_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_date_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_client_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_source_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_destination_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_directCost_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTrip_rate_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn getTrip_delete_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getMaintenance_maintenanceId_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getMaintenance_truckNo_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getMaintenance_date_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getMaintenance_type_dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn getMaintenance_cost_dataGrid;
        private System.Windows.Forms.DataGridViewButtonColumn getMaintenance_delete_dataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getTruck_filterButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox getTruck_truckNoComboBox;
    }
}

