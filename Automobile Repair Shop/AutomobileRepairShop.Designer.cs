namespace Automobile_Repair_Shop
{
    partial class AutomobileRepairShop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSaveDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLoadDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.btnNukeDB = new System.Windows.Forms.Button();
            this.btnUpdateChanges = new System.Windows.Forms.Button();
            this.labelServiceCost = new System.Windows.Forms.Label();
            this.textBoxServiceCharge = new System.Windows.Forms.TextBox();
            this.btnEndOrder = new System.Windows.Forms.Button();
            this.labelWorkShopLocation = new System.Windows.Forms.Label();
            this.btnNewService = new System.Windows.Forms.Button();
            this.dataGridViewEmployeeInClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.listBoxServiceLocation = new System.Windows.Forms.ListBox();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.panelManager = new System.Windows.Forms.Panel();
            this.btnServicesByStore = new System.Windows.Forms.Button();
            this.btnClearServicesByDate = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnClearAnualReport = new System.Windows.Forms.Button();
            this.btnMakeAnualReport = new System.Windows.Forms.Button();
            this.btnFindServicesByDate = new System.Windows.Forms.Button();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.dataGridViewServicesManager = new System.Windows.Forms.DataGridView();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.panelNewEmployee = new System.Windows.Forms.Panel();
            this.panelNewClient = new System.Windows.Forms.Panel();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelClientEntry = new System.Windows.Forms.Label();
            this.textBoxClientAddress = new System.Windows.Forms.TextBox();
            this.textBoxClientPhone = new System.Windows.Forms.TextBox();
            this.textBoxClientLName = new System.Windows.Forms.TextBox();
            this.textBoxClientFName = new System.Windows.Forms.TextBox();
            this.listBoxManagerLocation = new System.Windows.Forms.ListBox();
            this.btnInsertNewEmployee = new System.Windows.Forms.Button();
            this.labelEmpAddress = new System.Windows.Forms.Label();
            this.labelEmpPhone = new System.Windows.Forms.Label();
            this.labelEmpLName = new System.Windows.Forms.Label();
            this.labelEmpFName = new System.Windows.Forms.Label();
            this.textBoxEmpAddress = new System.Windows.Forms.TextBox();
            this.textBoxEmpPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmpLName = new System.Windows.Forms.TextBox();
            this.textBoxEmpFName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeInClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.panelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicesManager)).BeginInit();
            this.panelNewEmployee.SuspendLayout();
            this.panelNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.dataEntriesToolStripMenuItem,
            this.dBManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerPanelToolStripMenuItem,
            this.employeePanelToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // managerPanelToolStripMenuItem
            // 
            this.managerPanelToolStripMenuItem.Name = "managerPanelToolStripMenuItem";
            this.managerPanelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.managerPanelToolStripMenuItem.Text = "Manager Panel";
            this.managerPanelToolStripMenuItem.Click += new System.EventHandler(this.managerPanelToolStripMenuItem_Click);
            // 
            // employeePanelToolStripMenuItem
            // 
            this.employeePanelToolStripMenuItem.Name = "employeePanelToolStripMenuItem";
            this.employeePanelToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.employeePanelToolStripMenuItem.Text = "Employee Panel";
            this.employeePanelToolStripMenuItem.Click += new System.EventHandler(this.employeePanelToolStripMenuItem_Click);
            // 
            // dataEntriesToolStripMenuItem
            // 
            this.dataEntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem,
            this.newEmployeeToolStripMenuItem});
            this.dataEntriesToolStripMenuItem.Name = "dataEntriesToolStripMenuItem";
            this.dataEntriesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dataEntriesToolStripMenuItem.Text = "Data Entries";
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newClientToolStripMenuItem.Text = "New Client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.newClientToolStripMenuItem_Click);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // dBManagementToolStripMenuItem
            // 
            this.dBManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportSaveDBToolStripMenuItem,
            this.importLoadDBToolStripMenuItem});
            this.dBManagementToolStripMenuItem.Name = "dBManagementToolStripMenuItem";
            this.dBManagementToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.dBManagementToolStripMenuItem.Text = "DB Management";
            // 
            // exportSaveDBToolStripMenuItem
            // 
            this.exportSaveDBToolStripMenuItem.Name = "exportSaveDBToolStripMenuItem";
            this.exportSaveDBToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exportSaveDBToolStripMenuItem.Text = "Export (Save) DB";
            this.exportSaveDBToolStripMenuItem.Click += new System.EventHandler(this.exportSaveDBToolStripMenuItem_Click);
            // 
            // importLoadDBToolStripMenuItem
            // 
            this.importLoadDBToolStripMenuItem.Name = "importLoadDBToolStripMenuItem";
            this.importLoadDBToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.importLoadDBToolStripMenuItem.Text = "Import (Load) DB";
            this.importLoadDBToolStripMenuItem.Click += new System.EventHandler(this.importLoadDBToolStripMenuItem_Click);
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.btnNukeDB);
            this.panelEmployee.Controls.Add(this.btnUpdateChanges);
            this.panelEmployee.Controls.Add(this.labelServiceCost);
            this.panelEmployee.Controls.Add(this.textBoxServiceCharge);
            this.panelEmployee.Controls.Add(this.btnEndOrder);
            this.panelEmployee.Controls.Add(this.labelWorkShopLocation);
            this.panelEmployee.Controls.Add(this.btnNewService);
            this.panelEmployee.Controls.Add(this.dataGridViewEmployeeInClient);
            this.panelEmployee.Controls.Add(this.dataGridViewParts);
            this.panelEmployee.Controls.Add(this.listBoxServiceLocation);
            this.panelEmployee.Controls.Add(this.dataGridViewServices);
            this.panelEmployee.Controls.Add(this.dataGridViewVehicles);
            this.panelEmployee.Controls.Add(this.dataGridViewClients);
            this.panelEmployee.Location = new System.Drawing.Point(0, 25);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(934, 622);
            this.panelEmployee.TabIndex = 1;
            // 
            // btnNukeDB
            // 
            this.btnNukeDB.Location = new System.Drawing.Point(794, 194);
            this.btnNukeDB.Name = "btnNukeDB";
            this.btnNukeDB.Size = new System.Drawing.Size(116, 23);
            this.btnNukeDB.TabIndex = 15;
            this.btnNukeDB.Text = "Nuke Database";
            this.btnNukeDB.UseVisualStyleBackColor = true;
            this.btnNukeDB.Click += new System.EventHandler(this.btnNukeDB_Click);
            // 
            // btnUpdateChanges
            // 
            this.btnUpdateChanges.Location = new System.Drawing.Point(794, 253);
            this.btnUpdateChanges.Name = "btnUpdateChanges";
            this.btnUpdateChanges.Size = new System.Drawing.Size(116, 23);
            this.btnUpdateChanges.TabIndex = 14;
            this.btnUpdateChanges.Text = "Update Changes";
            this.btnUpdateChanges.UseVisualStyleBackColor = true;
            this.btnUpdateChanges.Click += new System.EventHandler(this.btnUpdateChanges_Click);
            // 
            // labelServiceCost
            // 
            this.labelServiceCost.AutoSize = true;
            this.labelServiceCost.Location = new System.Drawing.Point(606, 253);
            this.labelServiceCost.Name = "labelServiceCost";
            this.labelServiceCost.Size = new System.Drawing.Size(80, 13);
            this.labelServiceCost.TabIndex = 13;
            this.labelServiceCost.Text = "Service Charge";
            // 
            // textBoxServiceCharge
            // 
            this.textBoxServiceCharge.Location = new System.Drawing.Point(603, 272);
            this.textBoxServiceCharge.Name = "textBoxServiceCharge";
            this.textBoxServiceCharge.Size = new System.Drawing.Size(122, 20);
            this.textBoxServiceCharge.TabIndex = 12;
            // 
            // btnEndOrder
            // 
            this.btnEndOrder.Location = new System.Drawing.Point(794, 313);
            this.btnEndOrder.Name = "btnEndOrder";
            this.btnEndOrder.Size = new System.Drawing.Size(116, 23);
            this.btnEndOrder.TabIndex = 11;
            this.btnEndOrder.Text = "End Selected Order";
            this.btnEndOrder.UseVisualStyleBackColor = true;
            this.btnEndOrder.Click += new System.EventHandler(this.btnEndOrder_Click);
            // 
            // labelWorkShopLocation
            // 
            this.labelWorkShopLocation.AutoSize = true;
            this.labelWorkShopLocation.Location = new System.Drawing.Point(603, 193);
            this.labelWorkShopLocation.Name = "labelWorkShopLocation";
            this.labelWorkShopLocation.Size = new System.Drawing.Size(100, 13);
            this.labelWorkShopLocation.TabIndex = 10;
            this.labelWorkShopLocation.Text = "Workshop Location";
            // 
            // btnNewService
            // 
            this.btnNewService.Location = new System.Drawing.Point(603, 313);
            this.btnNewService.Name = "btnNewService";
            this.btnNewService.Size = new System.Drawing.Size(122, 23);
            this.btnNewService.TabIndex = 9;
            this.btnNewService.Text = "Create New Service";
            this.btnNewService.UseVisualStyleBackColor = true;
            this.btnNewService.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEmployeeInClient
            // 
            this.dataGridViewEmployeeInClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeInClient.Location = new System.Drawing.Point(22, 194);
            this.dataGridViewEmployeeInClient.Name = "dataGridViewEmployeeInClient";
            this.dataGridViewEmployeeInClient.Size = new System.Drawing.Size(257, 158);
            this.dataGridViewEmployeeInClient.TabIndex = 8;
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(301, 194);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(279, 157);
            this.dataGridViewParts.TabIndex = 7;
            // 
            // listBoxServiceLocation
            // 
            this.listBoxServiceLocation.FormattingEnabled = true;
            this.listBoxServiceLocation.Items.AddRange(new object[] {
            "New Westminster",
            "Coquitlam"});
            this.listBoxServiceLocation.Location = new System.Drawing.Point(603, 212);
            this.listBoxServiceLocation.Name = "listBoxServiceLocation";
            this.listBoxServiceLocation.Size = new System.Drawing.Size(122, 30);
            this.listBoxServiceLocation.TabIndex = 6;
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(21, 370);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.Size = new System.Drawing.Size(889, 201);
            this.dataGridViewServices.TabIndex = 5;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(301, 24);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.Size = new System.Drawing.Size(609, 150);
            this.dataGridViewVehicles.TabIndex = 4;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(22, 24);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(257, 150);
            this.dataGridViewClients.TabIndex = 3;
            // 
            // panelManager
            // 
            this.panelManager.Controls.Add(this.listBoxManagerLocation);
            this.panelManager.Controls.Add(this.btnServicesByStore);
            this.panelManager.Controls.Add(this.btnClearServicesByDate);
            this.panelManager.Controls.Add(this.dateTimePickerEnd);
            this.panelManager.Controls.Add(this.dateTimePickerStart);
            this.panelManager.Controls.Add(this.btnClearAnualReport);
            this.panelManager.Controls.Add(this.btnMakeAnualReport);
            this.panelManager.Controls.Add(this.btnFindServicesByDate);
            this.panelManager.Controls.Add(this.dataGridViewReport);
            this.panelManager.Controls.Add(this.dataGridViewServicesManager);
            this.panelManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManager.Location = new System.Drawing.Point(0, 24);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(934, 624);
            this.panelManager.TabIndex = 2;
            // 
            // btnServicesByStore
            // 
            this.btnServicesByStore.Location = new System.Drawing.Point(628, 227);
            this.btnServicesByStore.Name = "btnServicesByStore";
            this.btnServicesByStore.Size = new System.Drawing.Size(124, 23);
            this.btnServicesByStore.TabIndex = 10;
            this.btnServicesByStore.Text = "Find Services By Store";
            this.btnServicesByStore.UseVisualStyleBackColor = true;
            this.btnServicesByStore.Click += new System.EventHandler(this.btnServicesByStore_Click);
            // 
            // btnClearServicesByDate
            // 
            this.btnClearServicesByDate.Location = new System.Drawing.Point(779, 194);
            this.btnClearServicesByDate.Name = "btnClearServicesByDate";
            this.btnClearServicesByDate.Size = new System.Drawing.Size(131, 23);
            this.btnClearServicesByDate.TabIndex = 9;
            this.btnClearServicesByDate.Text = "Clear Services";
            this.btnClearServicesByDate.UseVisualStyleBackColor = true;
            this.btnClearServicesByDate.Click += new System.EventHandler(this.btnClearServicesByDate_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(632, 100);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 8;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(632, 51);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStart.TabIndex = 7;
            // 
            // btnClearAnualReport
            // 
            this.btnClearAnualReport.Location = new System.Drawing.Point(779, 341);
            this.btnClearAnualReport.Name = "btnClearAnualReport";
            this.btnClearAnualReport.Size = new System.Drawing.Size(131, 23);
            this.btnClearAnualReport.TabIndex = 4;
            this.btnClearAnualReport.Text = "Clear Annual Report";
            this.btnClearAnualReport.UseVisualStyleBackColor = true;
            this.btnClearAnualReport.Click += new System.EventHandler(this.btnClearAnualReport_Click);
            // 
            // btnMakeAnualReport
            // 
            this.btnMakeAnualReport.Location = new System.Drawing.Point(628, 341);
            this.btnMakeAnualReport.Name = "btnMakeAnualReport";
            this.btnMakeAnualReport.Size = new System.Drawing.Size(124, 23);
            this.btnMakeAnualReport.TabIndex = 3;
            this.btnMakeAnualReport.Text = "Create Annual Report";
            this.btnMakeAnualReport.UseVisualStyleBackColor = true;
            this.btnMakeAnualReport.Click += new System.EventHandler(this.btnMakeAnualReport_Click);
            // 
            // btnFindServicesByDate
            // 
            this.btnFindServicesByDate.Location = new System.Drawing.Point(628, 194);
            this.btnFindServicesByDate.Name = "btnFindServicesByDate";
            this.btnFindServicesByDate.Size = new System.Drawing.Size(124, 23);
            this.btnFindServicesByDate.TabIndex = 2;
            this.btnFindServicesByDate.Text = "Find Services By Date";
            this.btnFindServicesByDate.UseVisualStyleBackColor = true;
            this.btnFindServicesByDate.Click += new System.EventHandler(this.btnFindServicesByDate_Click);
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(39, 313);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(541, 258);
            this.dataGridViewReport.TabIndex = 1;
            // 
            // dataGridViewServicesManager
            // 
            this.dataGridViewServicesManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServicesManager.Location = new System.Drawing.Point(39, 32);
            this.dataGridViewServicesManager.Name = "dataGridViewServicesManager";
            this.dataGridViewServicesManager.Size = new System.Drawing.Size(541, 250);
            this.dataGridViewServicesManager.TabIndex = 0;
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.Location = new System.Drawing.Point(0, 25);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(934, 622);
            this.panelNewOrder.TabIndex = 7;
            // 
            // panelNewEmployee
            // 
            this.panelNewEmployee.Controls.Add(this.btnInsertNewEmployee);
            this.panelNewEmployee.Controls.Add(this.labelEmpAddress);
            this.panelNewEmployee.Controls.Add(this.labelEmpPhone);
            this.panelNewEmployee.Controls.Add(this.labelEmpLName);
            this.panelNewEmployee.Controls.Add(this.labelEmpFName);
            this.panelNewEmployee.Controls.Add(this.textBoxEmpAddress);
            this.panelNewEmployee.Controls.Add(this.textBoxEmpPhone);
            this.panelNewEmployee.Controls.Add(this.textBoxEmpLName);
            this.panelNewEmployee.Controls.Add(this.textBoxEmpFName);
            this.panelNewEmployee.Location = new System.Drawing.Point(0, 25);
            this.panelNewEmployee.Name = "panelNewEmployee";
            this.panelNewEmployee.Size = new System.Drawing.Size(934, 622);
            this.panelNewEmployee.TabIndex = 8;
            // 
            // panelNewClient
            // 
            this.panelNewClient.Controls.Add(this.buttonNewClient);
            this.panelNewClient.Controls.Add(this.labelAddress);
            this.panelNewClient.Controls.Add(this.labelPhone);
            this.panelNewClient.Controls.Add(this.labelLName);
            this.panelNewClient.Controls.Add(this.labelFName);
            this.panelNewClient.Controls.Add(this.labelClientEntry);
            this.panelNewClient.Controls.Add(this.textBoxClientAddress);
            this.panelNewClient.Controls.Add(this.textBoxClientPhone);
            this.panelNewClient.Controls.Add(this.textBoxClientLName);
            this.panelNewClient.Controls.Add(this.textBoxClientFName);
            this.panelNewClient.Location = new System.Drawing.Point(0, 25);
            this.panelNewClient.Name = "panelNewClient";
            this.panelNewClient.Size = new System.Drawing.Size(934, 622);
            this.panelNewClient.TabIndex = 8;
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(402, 259);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(129, 23);
            this.buttonNewClient.TabIndex = 9;
            this.buttonNewClient.Text = "Insert New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(298, 183);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(74, 13);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "Client Address";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(298, 144);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(67, 13);
            this.labelPhone.TabIndex = 7;
            this.labelPhone.Text = "Client Phone";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(298, 106);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(87, 13);
            this.labelLName.TabIndex = 6;
            this.labelLName.Text = "Client Last Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(298, 68);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(86, 13);
            this.labelFName.TabIndex = 5;
            this.labelFName.Text = "Client First Name";
            // 
            // labelClientEntry
            // 
            this.labelClientEntry.AutoSize = true;
            this.labelClientEntry.Location = new System.Drawing.Point(422, 24);
            this.labelClientEntry.Name = "labelClientEntry";
            this.labelClientEntry.Size = new System.Drawing.Size(58, 13);
            this.labelClientEntry.TabIndex = 4;
            this.labelClientEntry.Text = "New Client";
            // 
            // textBoxClientAddress
            // 
            this.textBoxClientAddress.Location = new System.Drawing.Point(425, 180);
            this.textBoxClientAddress.Name = "textBoxClientAddress";
            this.textBoxClientAddress.Size = new System.Drawing.Size(155, 20);
            this.textBoxClientAddress.TabIndex = 3;
            // 
            // textBoxClientPhone
            // 
            this.textBoxClientPhone.Location = new System.Drawing.Point(425, 141);
            this.textBoxClientPhone.Name = "textBoxClientPhone";
            this.textBoxClientPhone.Size = new System.Drawing.Size(155, 20);
            this.textBoxClientPhone.TabIndex = 2;
            // 
            // textBoxClientLName
            // 
            this.textBoxClientLName.Location = new System.Drawing.Point(425, 106);
            this.textBoxClientLName.Name = "textBoxClientLName";
            this.textBoxClientLName.Size = new System.Drawing.Size(155, 20);
            this.textBoxClientLName.TabIndex = 1;
            // 
            // textBoxClientFName
            // 
            this.textBoxClientFName.Location = new System.Drawing.Point(425, 68);
            this.textBoxClientFName.Name = "textBoxClientFName";
            this.textBoxClientFName.Size = new System.Drawing.Size(155, 20);
            this.textBoxClientFName.TabIndex = 0;
            // 
            // listBoxManagerLocation
            // 
            this.listBoxManagerLocation.FormattingEnabled = true;
            this.listBoxManagerLocation.Items.AddRange(new object[] {
            "New Westminster",
            "Coquitlam"});
            this.listBoxManagerLocation.Location = new System.Drawing.Point(632, 142);
            this.listBoxManagerLocation.Name = "listBoxManagerLocation";
            this.listBoxManagerLocation.Size = new System.Drawing.Size(120, 30);
            this.listBoxManagerLocation.TabIndex = 11;
            // 
            // btnInsertNewEmployee
            // 
            this.btnInsertNewEmployee.Location = new System.Drawing.Point(419, 241);
            this.btnInsertNewEmployee.Name = "btnInsertNewEmployee";
            this.btnInsertNewEmployee.Size = new System.Drawing.Size(129, 23);
            this.btnInsertNewEmployee.TabIndex = 19;
            this.btnInsertNewEmployee.Text = "Insert New Employee";
            this.btnInsertNewEmployee.UseVisualStyleBackColor = true;
            this.btnInsertNewEmployee.Click += new System.EventHandler(this.btnInsertNewEmployee_Click);
            // 
            // labelEmpAddress
            // 
            this.labelEmpAddress.AutoSize = true;
            this.labelEmpAddress.Location = new System.Drawing.Point(315, 165);
            this.labelEmpAddress.Name = "labelEmpAddress";
            this.labelEmpAddress.Size = new System.Drawing.Size(94, 13);
            this.labelEmpAddress.TabIndex = 18;
            this.labelEmpAddress.Text = "Employee Address";
            // 
            // labelEmpPhone
            // 
            this.labelEmpPhone.AutoSize = true;
            this.labelEmpPhone.Location = new System.Drawing.Point(315, 126);
            this.labelEmpPhone.Name = "labelEmpPhone";
            this.labelEmpPhone.Size = new System.Drawing.Size(87, 13);
            this.labelEmpPhone.TabIndex = 17;
            this.labelEmpPhone.Text = "Employee Phone";
            // 
            // labelEmpLName
            // 
            this.labelEmpLName.AutoSize = true;
            this.labelEmpLName.Location = new System.Drawing.Point(315, 88);
            this.labelEmpLName.Name = "labelEmpLName";
            this.labelEmpLName.Size = new System.Drawing.Size(107, 13);
            this.labelEmpLName.TabIndex = 16;
            this.labelEmpLName.Text = "Employee Last Name";
            // 
            // labelEmpFName
            // 
            this.labelEmpFName.AutoSize = true;
            this.labelEmpFName.Location = new System.Drawing.Point(315, 50);
            this.labelEmpFName.Name = "labelEmpFName";
            this.labelEmpFName.Size = new System.Drawing.Size(106, 13);
            this.labelEmpFName.TabIndex = 15;
            this.labelEmpFName.Text = "Employee First Name";
            // 
            // textBoxEmpAddress
            // 
            this.textBoxEmpAddress.Location = new System.Drawing.Point(442, 162);
            this.textBoxEmpAddress.Name = "textBoxEmpAddress";
            this.textBoxEmpAddress.Size = new System.Drawing.Size(155, 20);
            this.textBoxEmpAddress.TabIndex = 14;
            // 
            // textBoxEmpPhone
            // 
            this.textBoxEmpPhone.Location = new System.Drawing.Point(442, 123);
            this.textBoxEmpPhone.Name = "textBoxEmpPhone";
            this.textBoxEmpPhone.Size = new System.Drawing.Size(155, 20);
            this.textBoxEmpPhone.TabIndex = 13;
            // 
            // textBoxEmpLName
            // 
            this.textBoxEmpLName.Location = new System.Drawing.Point(442, 88);
            this.textBoxEmpLName.Name = "textBoxEmpLName";
            this.textBoxEmpLName.Size = new System.Drawing.Size(155, 20);
            this.textBoxEmpLName.TabIndex = 12;
            // 
            // textBoxEmpFName
            // 
            this.textBoxEmpFName.Location = new System.Drawing.Point(442, 50);
            this.textBoxEmpFName.Name = "textBoxEmpFName";
            this.textBoxEmpFName.Size = new System.Drawing.Size(155, 20);
            this.textBoxEmpFName.TabIndex = 11;
            // 
            // AutomobileRepairShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 648);
            this.Controls.Add(this.panelNewEmployee);
            this.Controls.Add(this.panelNewClient);
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.panelEmployee);
            this.Controls.Add(this.panelNewOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AutomobileRepairShop";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeInClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.panelManager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServicesManager)).EndInit();
            this.panelNewEmployee.ResumeLayout(false);
            this.panelNewEmployee.PerformLayout();
            this.panelNewClient.ResumeLayout(false);
            this.panelNewClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeePanelToolStripMenuItem;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.ListBox listBoxServiceLocation;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.DataGridView dataGridViewServicesManager;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.ToolStripMenuItem dataEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Panel panelNewEmployee;
        private System.Windows.Forms.Panel panelNewClient;
        private System.Windows.Forms.TextBox textBoxClientAddress;
        private System.Windows.Forms.TextBox textBoxClientPhone;
        private System.Windows.Forms.TextBox textBoxClientLName;
        private System.Windows.Forms.TextBox textBoxClientFName;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelClientEntry;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeInClient;
        private System.Windows.Forms.Button btnNewService;
        private System.Windows.Forms.Button btnEndOrder;
        private System.Windows.Forms.Label labelWorkShopLocation;
        private System.Windows.Forms.Label labelServiceCost;
        private System.Windows.Forms.TextBox textBoxServiceCharge;
        private System.Windows.Forms.Button btnUpdateChanges;
        private System.Windows.Forms.ToolStripMenuItem dBManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSaveDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLoadDBToolStripMenuItem;
        private System.Windows.Forms.Button btnNukeDB;
        private System.Windows.Forms.Button btnClearServicesByDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button btnClearAnualReport;
        private System.Windows.Forms.Button btnMakeAnualReport;
        private System.Windows.Forms.Button btnFindServicesByDate;
        private System.Windows.Forms.Button btnServicesByStore;
        private System.Windows.Forms.ListBox listBoxManagerLocation;
        private System.Windows.Forms.Button btnInsertNewEmployee;
        private System.Windows.Forms.Label labelEmpAddress;
        private System.Windows.Forms.Label labelEmpPhone;
        private System.Windows.Forms.Label labelEmpLName;
        private System.Windows.Forms.Label labelEmpFName;
        private System.Windows.Forms.TextBox textBoxEmpAddress;
        private System.Windows.Forms.TextBox textBoxEmpPhone;
        private System.Windows.Forms.TextBox textBoxEmpLName;
        private System.Windows.Forms.TextBox textBoxEmpFName;
    }
}

