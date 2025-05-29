<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OwnerPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OwnerPage))
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.reportsPage = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Sales = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label166 = New System.Windows.Forms.Label()
        Me.lblMostAvailedItem = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.lblMostAvailedService = New System.Windows.Forms.Label()
        Me.Label162 = New System.Windows.Forms.Label()
        Me.cbFilterReport = New System.Windows.Forms.ComboBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.lblMostTransactionFinished = New System.Windows.Forms.Label()
        Me.Label161 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.chService = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.chItems = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Inventory = New System.Windows.Forms.TabPage()
        Me.btnSwitchOrdersTable = New System.Windows.Forms.Button()
        Me.btnInventoryRefresh = New System.Windows.Forms.Button()
        Me.btnViewItem = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.panConfigureItem = New System.Windows.Forms.Panel()
        Me.txtRestockItem = New System.Windows.Forms.TextBox()
        Me.btnClearItemFields = New System.Windows.Forms.Button()
        Me.cbItemName = New System.Windows.Forms.ComboBox()
        Me.dateRestock = New System.Windows.Forms.DateTimePicker()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.txtItemCost = New System.Windows.Forms.TextBox()
        Me.txtItemPrice = New System.Windows.Forms.TextBox()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.cbItemBrand = New System.Windows.Forms.ComboBox()
        Me.lblDateModified = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.lblItemStatus = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.lblReorderLevel = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lblLastRestock = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.btnInventoryReport = New System.Windows.Forms.Button()
        Me.dgvInventory = New System.Windows.Forms.DataGridView()
        Me.txtInventorySearch = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSwitchTables = New System.Windows.Forms.Button()
        Me.btnRefreshServices = New System.Windows.Forms.Button()
        Me.btnWeeklyServicesReport = New System.Windows.Forms.Button()
        Me.btnViewService = New System.Windows.Forms.Button()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.panServiceOptions = New System.Windows.Forms.Panel()
        Me.lblTimesAvailed = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.txtServiceDescription = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.btnClearFields = New System.Windows.Forms.Button()
        Me.btnUpdateService = New System.Windows.Forms.Button()
        Me.cbServiceStatus = New System.Windows.Forms.ComboBox()
        Me.btnAddService = New System.Windows.Forms.Button()
        Me.lblServiceDateAdded = New System.Windows.Forms.Label()
        Me.btnDeleteService = New System.Windows.Forms.Button()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.cbServiceAvail = New System.Windows.Forms.ComboBox()
        Me.txtServiceFee = New System.Windows.Forms.TextBox()
        Me.cbServiceName = New System.Windows.Forms.ComboBox()
        Me.lblServiceDateModified = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.lblServiceID = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.cbServiceCategory = New System.Windows.Forms.ComboBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.dgvServices = New System.Windows.Forms.DataGridView()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.employeePage = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnEmployeeDGVrefresh = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.AddEmployee = New System.Windows.Forms.TabPage()
        Me.btnClearAddEm = New System.Windows.Forms.Button()
        Me.cbAddEmSex = New System.Windows.Forms.ComboBox()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.btnAddEmConfirm = New System.Windows.Forms.Button()
        Me.btnAddEmPass = New System.Windows.Forms.Button()
        Me.txtEmployeeAge = New System.Windows.Forms.TextBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.cbAddShift = New System.Windows.Forms.ComboBox()
        Me.cbAddWorkingHours = New System.Windows.Forms.ComboBox()
        Me.cbAddProvince = New System.Windows.Forms.ComboBox()
        Me.cbAddCity = New System.Windows.Forms.ComboBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtAddEmUserName = New System.Windows.Forms.TextBox()
        Me.txtAddConfirmPass = New System.Windows.Forms.TextBox()
        Me.txtAddEmPassword = New System.Windows.Forms.TextBox()
        Me.txtAddEmEmail = New System.Windows.Forms.TextBox()
        Me.txtAddEmContact = New System.Windows.Forms.TextBox()
        Me.txtAddEmLast = New System.Windows.Forms.TextBox()
        Me.txtAddEmFirst = New System.Windows.Forms.TextBox()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.EditDetails = New System.Windows.Forms.TabPage()
        Me.btnEditConfirm = New System.Windows.Forms.Button()
        Me.btnEditUserAcc = New System.Windows.Forms.Button()
        Me.lblInvisibleIDEDIT = New System.Windows.Forms.Label()
        Me.btnClearEditFields = New System.Windows.Forms.Button()
        Me.txtEditEmAge = New System.Windows.Forms.TextBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.btnSelectEdit = New System.Windows.Forms.Button()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.lblEmployeeFunc = New System.Windows.Forms.Label()
        Me.cbEmShift = New System.Windows.Forms.ComboBox()
        Me.cbEmWorkingHours = New System.Windows.Forms.ComboBox()
        Me.cbEmProvince = New System.Windows.Forms.ComboBox()
        Me.cbEmCityTown = New System.Windows.Forms.ComboBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.lblEmployeeDateAdded = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.txtEmUserName = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtEditConfirmPass = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.txtEmPassword = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnEditEmployees = New System.Windows.Forms.Button()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmployeeLastName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeFirstName = New System.Windows.Forms.TextBox()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.RemoveEmployee = New System.Windows.Forms.TabPage()
        Me.btnRemoveFields = New System.Windows.Forms.Button()
        Me.lblRemEmDate = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.lblRemEmInvi = New System.Windows.Forms.Label()
        Me.btnSelectDelete = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lblRemEmStatus = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lblRemEmContact = New System.Windows.Forms.Label()
        Me.lblRemEmEmail = New System.Windows.Forms.Label()
        Me.lblRemEmName = New System.Windows.Forms.Label()
        Me.lblRemEmID = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.btnRemoveEmployee = New System.Windows.Forms.Button()
        Me.dgvEmployee = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.add = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panOrderInfo = New System.Windows.Forms.Panel()
        Me.lblInvisibleOrderID = New System.Windows.Forms.Label()
        Me.lblInvisibleCustomerID = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.txtMiddleIni = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.cbCustomerSex = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbCity = New System.Windows.Forms.ComboBox()
        Me.cbProvince = New System.Windows.Forms.ComboBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtContactNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.lblDateAdded = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPaymentMethod = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblIscolored = New System.Windows.Forms.Label()
        Me.Label168 = New System.Windows.Forms.Label()
        Me.lblServiceCategory = New System.Windows.Forms.Label()
        Me.lblInvisibleTransactionID = New System.Windows.Forms.Label()
        Me.lblServiceFee = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.lblAddon4Total = New System.Windows.Forms.Label()
        Me.lblAddon3Total = New System.Windows.Forms.Label()
        Me.lblAddon2Total = New System.Windows.Forms.Label()
        Me.lblAddon1Total = New System.Windows.Forms.Label()
        Me.lblLoadWeight = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.lblAddon4Fee = New System.Windows.Forms.Label()
        Me.lblAddon3Fee = New System.Windows.Forms.Label()
        Me.lblAddon2Fee = New System.Windows.Forms.Label()
        Me.lblAddon1Fee = New System.Windows.Forms.Label()
        Me.lblAddon4 = New System.Windows.Forms.Label()
        Me.lblAddon3 = New System.Windows.Forms.Label()
        Me.lblAddon2 = New System.Windows.Forms.Label()
        Me.lblAddon1 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblServiceAvailed = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNextAd = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.panLayer3 = New System.Windows.Forms.Panel()
        Me.numLoadWeight = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.panLayer2 = New System.Windows.Forms.Panel()
        Me.numAddon4 = New System.Windows.Forms.NumericUpDown()
        Me.numAddon3 = New System.Windows.Forms.NumericUpDown()
        Me.numAddon2 = New System.Windows.Forms.NumericUpDown()
        Me.numAddon1 = New System.Windows.Forms.NumericUpDown()
        Me.cbNone = New System.Windows.Forms.CheckBox()
        Me.cbAddon4 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAddon3 = New System.Windows.Forms.CheckBox()
        Me.cbAddon2 = New System.Windows.Forms.CheckBox()
        Me.cbAddon1 = New System.Windows.Forms.CheckBox()
        Me.panLayer1 = New System.Windows.Forms.Panel()
        Me.cbColored = New System.Windows.Forms.ComboBox()
        Me.Label167 = New System.Windows.Forms.Label()
        Me.panSelfService = New System.Windows.Forms.Panel()
        Me.cbDry = New System.Windows.Forms.CheckBox()
        Me.cbWash = New System.Windows.Forms.CheckBox()
        Me.rbFullService = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbSelfService = New System.Windows.Forms.RadioButton()
        Me.panFullService = New System.Windows.Forms.Panel()
        Me.rbComforters = New System.Windows.Forms.RadioButton()
        Me.rbWDF = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Pending = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panPendingOrdersss = New System.Windows.Forms.Panel()
        Me.lblProcessedBy = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPendingTransacDateAdded = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblPendingChange = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lblPaymentReceived = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.lblPendingTotal = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.lblPendingAddon4 = New System.Windows.Forms.Label()
        Me.lblPendingAddon3 = New System.Windows.Forms.Label()
        Me.lblPendingAddon2 = New System.Windows.Forms.Label()
        Me.lblPendingAddon1 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.lblPendingOrderID = New System.Windows.Forms.Label()
        Me.lblPendingService = New System.Windows.Forms.Label()
        Me.lblPendingContact = New System.Windows.Forms.Label()
        Me.lblPendingFullName = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.dgvPending = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearchPending = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cancelled = New System.Windows.Forms.TabPage()
        Me.btnFinishedRefreshed = New System.Windows.Forms.Button()
        Me.btnFinishedFields = New System.Windows.Forms.Button()
        Me.btnViewFinished = New System.Windows.Forms.Button()
        Me.panFinished = New System.Windows.Forms.Panel()
        Me.lblFinishedUser = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.lblFinishedDate = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.lblFinishedChange = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.lblFinishedPayment = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.lblFinishedAmount = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.lblFinishedAddon4 = New System.Windows.Forms.Label()
        Me.lblFinishedAddon3 = New System.Windows.Forms.Label()
        Me.lblFinishedAddon2 = New System.Windows.Forms.Label()
        Me.lblFinishedAddon1 = New System.Windows.Forms.Label()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.lblFinishedID = New System.Windows.Forms.Label()
        Me.lblFinishedService = New System.Windows.Forms.Label()
        Me.lblFinishedContact = New System.Windows.Forms.Label()
        Me.lblFinishedFullName = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Label157 = New System.Windows.Forms.Label()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label159 = New System.Windows.Forms.Label()
        Me.dgvFinished = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.cbFilter = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSearchFinished = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl6 = New System.Windows.Forms.TabControl()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.lblAdminUsername = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.lblAccountDateCreated = New System.Windows.Forms.Label()
        Me.lblAdminFullName = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.btnClearAccountFields = New System.Windows.Forms.Button()
        Me.btnInsertOwndata = New System.Windows.Forms.Button()
        Me.txtEditAdminEmail = New System.Windows.Forms.TextBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.txtEditAdminContact = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.txtAdminEditLName = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtAdminEditFName = New System.Windows.Forms.TextBox()
        Me.btnConfirmChanges = New System.Windows.Forms.Button()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.btnHideUser = New System.Windows.Forms.Button()
        Me.txtChangePassword = New System.Windows.Forms.TextBox()
        Me.lblEditOwnID = New System.Windows.Forms.Label()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.btnHidePassword = New System.Windows.Forms.Button()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.txtEditAdminUser = New System.Windows.Forms.TextBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnDeleteOwnAccount = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtChangeConfigUs = New System.Windows.Forms.TextBox()
        Me.txtChangeConfigPass = New System.Windows.Forms.TextBox()
        Me.btnChangeConfig = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label160 = New System.Windows.Forms.Label()
        Me.lblSmallUserID = New System.Windows.Forms.Label()
        Me.btnDeleteTransac = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.reportsPage.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.Sales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.chService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inventory.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.panConfigureItem.SuspendLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.panServiceOptions.SuspendLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.employeePage.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.AddEmployee.SuspendLayout()
        Me.EditDetails.SuspendLayout()
        Me.RemoveEmployee.SuspendLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.add.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panOrderInfo.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panLayer3.SuspendLayout()
        CType(Me.numLoadWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panLayer2.SuspendLayout()
        CType(Me.numAddon4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAddon3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAddon2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAddon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panLayer1.SuspendLayout()
        Me.panSelfService.SuspendLayout()
        Me.panFullService.SuspendLayout()
        Me.Pending.SuspendLayout()
        Me.panPendingOrdersss.SuspendLayout()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cancelled.SuspendLayout()
        Me.panFinished.SuspendLayout()
        CType(Me.dgvFinished, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabControl6.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(28, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 46)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.reportsPage)
        Me.TabControl1.Controls.Add(Me.employeePage)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(1, 84)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1633, 971)
        Me.TabControl1.TabIndex = 14
        '
        'reportsPage
        '
        Me.reportsPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reportsPage.Controls.Add(Me.TabControl2)
        Me.reportsPage.ForeColor = System.Drawing.Color.Black
        Me.reportsPage.Location = New System.Drawing.Point(4, 34)
        Me.reportsPage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reportsPage.Name = "reportsPage"
        Me.reportsPage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reportsPage.Size = New System.Drawing.Size(1625, 933)
        Me.reportsPage.TabIndex = 0
        Me.reportsPage.Text = "Dashboard"
        Me.reportsPage.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl2.Controls.Add(Me.Sales)
        Me.TabControl2.Controls.Add(Me.Inventory)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(6, 2)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1782, 925)
        Me.TabControl2.TabIndex = 16
        '
        'Sales
        '
        Me.Sales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Sales.Controls.Add(Me.Panel1)
        Me.Sales.Controls.Add(Me.Label43)
        Me.Sales.Controls.Add(Me.Panel17)
        Me.Sales.Controls.Add(Me.Panel16)
        Me.Sales.Controls.Add(Me.cbFilterReport)
        Me.Sales.Controls.Add(Me.Panel15)
        Me.Sales.Controls.Add(Me.Panel14)
        Me.Sales.Controls.Add(Me.btnSalesReport)
        Me.Sales.Controls.Add(Me.Label5)
        Me.Sales.Location = New System.Drawing.Point(4, 32)
        Me.Sales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sales.Name = "Sales"
        Me.Sales.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sales.Size = New System.Drawing.Size(1774, 889)
        Me.Sales.TabIndex = 0
        Me.Sales.Text = "Sales"
        Me.Sales.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.lblTotalCustomers)
        Me.Panel1.Location = New System.Drawing.Point(1053, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 146)
        Me.Panel1.TabIndex = 37
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(13, 7)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(172, 22)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Total customers"
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCustomers.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTotalCustomers.Location = New System.Drawing.Point(14, 60)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(58, 18)
        Me.lblTotalCustomers.TabIndex = 36
        Me.lblTotalCustomers.Text = "xxxxx"
        '
        'Label43
        '
        Me.Label43.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(1380, 184)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 20)
        Me.Label43.TabIndex = 34
        Me.Label43.Text = "Filter by:"
        '
        'Panel17
        '
        Me.Panel17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel17.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel17.Controls.Add(Me.Label166)
        Me.Panel17.Controls.Add(Me.lblMostAvailedItem)
        Me.Panel17.Location = New System.Drawing.Point(717, 89)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(321, 146)
        Me.Panel17.TabIndex = 33
        '
        'Label166
        '
        Me.Label166.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label166.AutoSize = True
        Me.Label166.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label166.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label166.Location = New System.Drawing.Point(13, 7)
        Me.Label166.Name = "Label166"
        Me.Label166.Size = New System.Drawing.Size(188, 22)
        Me.Label166.TabIndex = 36
        Me.Label166.Text = "Most availed item"
        '
        'lblMostAvailedItem
        '
        Me.lblMostAvailedItem.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMostAvailedItem.AutoSize = True
        Me.lblMostAvailedItem.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostAvailedItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMostAvailedItem.Location = New System.Drawing.Point(14, 60)
        Me.lblMostAvailedItem.Name = "lblMostAvailedItem"
        Me.lblMostAvailedItem.Size = New System.Drawing.Size(58, 18)
        Me.lblMostAvailedItem.TabIndex = 36
        Me.lblMostAvailedItem.Text = "xxxxx"
        '
        'Panel16
        '
        Me.Panel16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel16.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel16.Controls.Add(Me.lblMostAvailedService)
        Me.Panel16.Controls.Add(Me.Label162)
        Me.Panel16.Location = New System.Drawing.Point(379, 89)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(321, 146)
        Me.Panel16.TabIndex = 33
        '
        'lblMostAvailedService
        '
        Me.lblMostAvailedService.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMostAvailedService.AutoSize = True
        Me.lblMostAvailedService.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostAvailedService.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMostAvailedService.Location = New System.Drawing.Point(16, 61)
        Me.lblMostAvailedService.Name = "lblMostAvailedService"
        Me.lblMostAvailedService.Size = New System.Drawing.Size(58, 18)
        Me.lblMostAvailedService.TabIndex = 35
        Me.lblMostAvailedService.Text = "xxxxx"
        '
        'Label162
        '
        Me.Label162.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label162.AutoSize = True
        Me.Label162.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label162.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label162.Location = New System.Drawing.Point(15, 7)
        Me.Label162.Name = "Label162"
        Me.Label162.Size = New System.Drawing.Size(216, 22)
        Me.Label162.TabIndex = 34
        Me.Label162.Text = "Most availed service"
        '
        'cbFilterReport
        '
        Me.cbFilterReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cbFilterReport.FormattingEnabled = True
        Me.cbFilterReport.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cbFilterReport.Location = New System.Drawing.Point(1382, 207)
        Me.cbFilterReport.Name = "cbFilterReport"
        Me.cbFilterReport.Size = New System.Drawing.Size(185, 28)
        Me.cbFilterReport.TabIndex = 33
        '
        'Panel15
        '
        Me.Panel15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Panel15.Controls.Add(Me.lblMostTransactionFinished)
        Me.Panel15.Controls.Add(Me.Label161)
        Me.Panel15.Location = New System.Drawing.Point(39, 89)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(321, 146)
        Me.Panel15.TabIndex = 32
        '
        'lblMostTransactionFinished
        '
        Me.lblMostTransactionFinished.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMostTransactionFinished.AutoSize = True
        Me.lblMostTransactionFinished.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMostTransactionFinished.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMostTransactionFinished.Location = New System.Drawing.Point(9, 60)
        Me.lblMostTransactionFinished.Name = "lblMostTransactionFinished"
        Me.lblMostTransactionFinished.Size = New System.Drawing.Size(58, 18)
        Me.lblMostTransactionFinished.TabIndex = 34
        Me.lblMostTransactionFinished.Text = "xxxxx"
        '
        'Label161
        '
        Me.Label161.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label161.AutoSize = True
        Me.Label161.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label161.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label161.Location = New System.Drawing.Point(8, 7)
        Me.Label161.Name = "Label161"
        Me.Label161.Size = New System.Drawing.Size(278, 22)
        Me.Label161.TabIndex = 33
        Me.Label161.Text = "Most transactions finished"
        '
        'Panel14
        '
        Me.Panel14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel14.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel14.Controls.Add(Me.chService)
        Me.Panel14.Controls.Add(Me.Label105)
        Me.Panel14.Controls.Add(Me.chItems)
        Me.Panel14.Controls.Add(Me.Label70)
        Me.Panel14.Location = New System.Drawing.Point(39, 293)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1546, 469)
        Me.Panel14.TabIndex = 31
        '
        'chService
        '
        Me.chService.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chService.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea11.Name = "ChartArea1"
        Me.chService.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.chService.Legends.Add(Legend11)
        Me.chService.Location = New System.Drawing.Point(800, 76)
        Me.chService.Name = "chService"
        Series11.ChartArea = "ChartArea1"
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.chService.Series.Add(Series11)
        Me.chService.Size = New System.Drawing.Size(705, 336)
        Me.chService.TabIndex = 28
        Me.chService.Text = "Chart1"
        '
        'Label105
        '
        Me.Label105.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label105.Location = New System.Drawing.Point(795, 24)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(171, 25)
        Me.Label105.TabIndex = 30
        Me.Label105.Text = "Services chart"
        '
        'chItems
        '
        Me.chItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.chItems.BackColor = System.Drawing.Color.WhiteSmoke
        ChartArea12.Name = "ChartArea1"
        Me.chItems.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.chItems.Legends.Add(Legend12)
        Me.chItems.Location = New System.Drawing.Point(35, 76)
        Me.chItems.Name = "chItems"
        Series12.ChartArea = "ChartArea1"
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.chItems.Series.Add(Series12)
        Me.chItems.Size = New System.Drawing.Size(705, 336)
        Me.chItems.TabIndex = 25
        Me.chItems.Text = "Chart1"
        '
        'Label70
        '
        Me.Label70.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label70.Location = New System.Drawing.Point(34, 28)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(188, 25)
        Me.Label70.TabIndex = 29
        Me.Label70.Text = "Inventory chart"
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSalesReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSalesReport.FlatAppearance.BorderSize = 0
        Me.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSalesReport.Location = New System.Drawing.Point(1380, 113)
        Me.btnSalesReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(187, 54)
        Me.btnSalesReport.TabIndex = 23
        Me.btnSalesReport.Text = "Generate report"
        Me.btnSalesReport.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(19, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 31)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sales page"
        '
        'Inventory
        '
        Me.Inventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Inventory.Controls.Add(Me.btnSwitchOrdersTable)
        Me.Inventory.Controls.Add(Me.btnInventoryRefresh)
        Me.Inventory.Controls.Add(Me.btnViewItem)
        Me.Inventory.Controls.Add(Me.Panel11)
        Me.Inventory.Controls.Add(Me.btnInventoryReport)
        Me.Inventory.Controls.Add(Me.dgvInventory)
        Me.Inventory.Controls.Add(Me.txtInventorySearch)
        Me.Inventory.Controls.Add(Me.Label25)
        Me.Inventory.Controls.Add(Me.Label18)
        Me.Inventory.ForeColor = System.Drawing.Color.Black
        Me.Inventory.Location = New System.Drawing.Point(4, 32)
        Me.Inventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Inventory.Size = New System.Drawing.Size(1774, 889)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "Inventory"
        Me.Inventory.UseVisualStyleBackColor = True
        '
        'btnSwitchOrdersTable
        '
        Me.btnSwitchOrdersTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSwitchOrdersTable.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnSwitchOrdersTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwitchOrdersTable.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSwitchOrdersTable.Location = New System.Drawing.Point(736, 52)
        Me.btnSwitchOrdersTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSwitchOrdersTable.Name = "btnSwitchOrdersTable"
        Me.btnSwitchOrdersTable.Size = New System.Drawing.Size(326, 38)
        Me.btnSwitchOrdersTable.TabIndex = 34
        Me.btnSwitchOrdersTable.Text = "Switch to Order transactions"
        Me.btnSwitchOrdersTable.UseVisualStyleBackColor = False
        '
        'btnInventoryRefresh
        '
        Me.btnInventoryRefresh.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnInventoryRefresh.FlatAppearance.BorderSize = 0
        Me.btnInventoryRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryRefresh.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventoryRefresh.Location = New System.Drawing.Point(440, 55)
        Me.btnInventoryRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventoryRefresh.Name = "btnInventoryRefresh"
        Me.btnInventoryRefresh.Size = New System.Drawing.Size(112, 38)
        Me.btnInventoryRefresh.TabIndex = 27
        Me.btnInventoryRefresh.Text = "Refresh"
        Me.btnInventoryRefresh.UseVisualStyleBackColor = False
        '
        'btnViewItem
        '
        Me.btnViewItem.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewItem.FlatAppearance.BorderSize = 0
        Me.btnViewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewItem.Location = New System.Drawing.Point(558, 55)
        Me.btnViewItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewItem.Name = "btnViewItem"
        Me.btnViewItem.Size = New System.Drawing.Size(154, 38)
        Me.btnViewItem.TabIndex = 26
        Me.btnViewItem.Text = "Select item"
        Me.btnViewItem.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.panConfigureItem)
        Me.Panel11.Location = New System.Drawing.Point(935, 101)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(647, 742)
        Me.Panel11.TabIndex = 25
        '
        'panConfigureItem
        '
        Me.panConfigureItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panConfigureItem.Controls.Add(Me.txtRestockItem)
        Me.panConfigureItem.Controls.Add(Me.btnClearItemFields)
        Me.panConfigureItem.Controls.Add(Me.cbItemName)
        Me.panConfigureItem.Controls.Add(Me.dateRestock)
        Me.panConfigureItem.Controls.Add(Me.Label129)
        Me.panConfigureItem.Controls.Add(Me.txtItemCost)
        Me.panConfigureItem.Controls.Add(Me.txtItemPrice)
        Me.panConfigureItem.Controls.Add(Me.Label124)
        Me.panConfigureItem.Controls.Add(Me.btnUpdateItem)
        Me.panConfigureItem.Controls.Add(Me.btnAddItem)
        Me.panConfigureItem.Controls.Add(Me.Label125)
        Me.panConfigureItem.Controls.Add(Me.btnDeleteItem)
        Me.panConfigureItem.Controls.Add(Me.cbItemBrand)
        Me.panConfigureItem.Controls.Add(Me.lblDateModified)
        Me.panConfigureItem.Controls.Add(Me.Label112)
        Me.panConfigureItem.Controls.Add(Me.lblItemStatus)
        Me.panConfigureItem.Controls.Add(Me.Label111)
        Me.panConfigureItem.Controls.Add(Me.lblReorderLevel)
        Me.panConfigureItem.Controls.Add(Me.Label109)
        Me.panConfigureItem.Controls.Add(Me.lblQuantityInStock)
        Me.panConfigureItem.Controls.Add(Me.Label108)
        Me.panConfigureItem.Controls.Add(Me.Label20)
        Me.panConfigureItem.Controls.Add(Me.Label21)
        Me.panConfigureItem.Controls.Add(Me.lblItemID)
        Me.panConfigureItem.Controls.Add(Me.lblLastRestock)
        Me.panConfigureItem.Controls.Add(Me.Label29)
        Me.panConfigureItem.Controls.Add(Me.Label28)
        Me.panConfigureItem.Controls.Add(Me.Label27)
        Me.panConfigureItem.Controls.Add(Me.Label)
        Me.panConfigureItem.Location = New System.Drawing.Point(3, 2)
        Me.panConfigureItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panConfigureItem.Name = "panConfigureItem"
        Me.panConfigureItem.Size = New System.Drawing.Size(639, 736)
        Me.panConfigureItem.TabIndex = 23
        '
        'txtRestockItem
        '
        Me.txtRestockItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRestockItem.Location = New System.Drawing.Point(280, 377)
        Me.txtRestockItem.Name = "txtRestockItem"
        Me.txtRestockItem.Size = New System.Drawing.Size(179, 28)
        Me.txtRestockItem.TabIndex = 87
        '
        'btnClearItemFields
        '
        Me.btnClearItemFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearItemFields.BackColor = System.Drawing.Color.Orange
        Me.btnClearItemFields.FlatAppearance.BorderSize = 0
        Me.btnClearItemFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearItemFields.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearItemFields.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClearItemFields.Location = New System.Drawing.Point(442, 672)
        Me.btnClearItemFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearItemFields.Name = "btnClearItemFields"
        Me.btnClearItemFields.Size = New System.Drawing.Size(154, 46)
        Me.btnClearItemFields.TabIndex = 86
        Me.btnClearItemFields.Text = "Clear fields"
        Me.btnClearItemFields.UseVisualStyleBackColor = False
        '
        'cbItemName
        '
        Me.cbItemName.FormattingEnabled = True
        Me.cbItemName.Location = New System.Drawing.Point(278, 147)
        Me.cbItemName.Name = "cbItemName"
        Me.cbItemName.Size = New System.Drawing.Size(179, 28)
        Me.cbItemName.TabIndex = 44
        '
        'dateRestock
        '
        Me.dateRestock.Location = New System.Drawing.Point(278, 538)
        Me.dateRestock.Name = "dateRestock"
        Me.dateRestock.Size = New System.Drawing.Size(318, 28)
        Me.dateRestock.TabIndex = 43
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label129.Location = New System.Drawing.Point(23, 538)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(130, 20)
        Me.Label129.TabIndex = 42
        Me.Label129.Text = "Restock Date:"
        '
        'txtItemCost
        '
        Me.txtItemCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemCost.Location = New System.Drawing.Point(278, 276)
        Me.txtItemCost.Name = "txtItemCost"
        Me.txtItemCost.Size = New System.Drawing.Size(179, 28)
        Me.txtItemCost.TabIndex = 41
        '
        'txtItemPrice
        '
        Me.txtItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemPrice.Location = New System.Drawing.Point(278, 243)
        Me.txtItemPrice.Name = "txtItemPrice"
        Me.txtItemPrice.Size = New System.Drawing.Size(179, 28)
        Me.txtItemPrice.TabIndex = 40
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label124.Location = New System.Drawing.Point(23, 284)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(100, 20)
        Me.Label124.TabIndex = 39
        Me.Label124.Text = "Item cost:"
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnUpdateItem.FlatAppearance.BorderSize = 0
        Me.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateItem.ForeColor = System.Drawing.Color.DimGray
        Me.btnUpdateItem.Location = New System.Drawing.Point(208, 672)
        Me.btnUpdateItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(106, 46)
        Me.btnUpdateItem.TabIndex = 8
        Me.btnUpdateItem.Text = "Update"
        Me.btnUpdateItem.UseVisualStyleBackColor = False
        '
        'btnAddItem
        '
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.BackColor = System.Drawing.Color.White
        Me.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddItem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnAddItem.Location = New System.Drawing.Point(90, 671)
        Me.btnAddItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(112, 48)
        Me.btnAddItem.TabIndex = 7
        Me.btnAddItem.Text = "Add"
        Me.btnAddItem.UseVisualStyleBackColor = False
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label125.Location = New System.Drawing.Point(23, 243)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(107, 20)
        Me.Label125.TabIndex = 38
        Me.Label125.Text = "Item price:"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteItem.BackColor = System.Drawing.Color.Red
        Me.btnDeleteItem.FlatAppearance.BorderSize = 0
        Me.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteItem.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteItem.Location = New System.Drawing.Point(320, 672)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(106, 46)
        Me.btnDeleteItem.TabIndex = 9
        Me.btnDeleteItem.Text = "Delete"
        Me.btnDeleteItem.UseVisualStyleBackColor = False
        '
        'cbItemBrand
        '
        Me.cbItemBrand.FormattingEnabled = True
        Me.cbItemBrand.Location = New System.Drawing.Point(278, 188)
        Me.cbItemBrand.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbItemBrand.Name = "cbItemBrand"
        Me.cbItemBrand.Size = New System.Drawing.Size(179, 28)
        Me.cbItemBrand.TabIndex = 37
        '
        'lblDateModified
        '
        Me.lblDateModified.AutoSize = True
        Me.lblDateModified.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateModified.Location = New System.Drawing.Point(276, 579)
        Me.lblDateModified.Name = "lblDateModified"
        Me.lblDateModified.Size = New System.Drawing.Size(59, 20)
        Me.lblDateModified.TabIndex = 36
        Me.lblDateModified.Text = "xxxxx"
        Me.lblDateModified.Visible = False
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label112.Location = New System.Drawing.Point(23, 579)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(144, 20)
        Me.Label112.TabIndex = 35
        Me.Label112.Text = "Date modified: "
        '
        'lblItemStatus
        '
        Me.lblItemStatus.AutoSize = True
        Me.lblItemStatus.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblItemStatus.Location = New System.Drawing.Point(274, 498)
        Me.lblItemStatus.Name = "lblItemStatus"
        Me.lblItemStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblItemStatus.TabIndex = 34
        Me.lblItemStatus.Text = "xxxxx"
        Me.lblItemStatus.Visible = False
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label111.Location = New System.Drawing.Point(23, 498)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(79, 20)
        Me.Label111.TabIndex = 33
        Me.Label111.Text = "Status: "
        '
        'lblReorderLevel
        '
        Me.lblReorderLevel.AutoSize = True
        Me.lblReorderLevel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblReorderLevel.Location = New System.Drawing.Point(274, 455)
        Me.lblReorderLevel.Name = "lblReorderLevel"
        Me.lblReorderLevel.Size = New System.Drawing.Size(59, 20)
        Me.lblReorderLevel.TabIndex = 32
        Me.lblReorderLevel.Text = "xxxxx"
        Me.lblReorderLevel.Visible = False
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label109.Location = New System.Drawing.Point(23, 455)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(136, 20)
        Me.Label109.TabIndex = 31
        Me.Label109.Text = "Reorder level: "
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblQuantityInStock.Location = New System.Drawing.Point(276, 343)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(59, 20)
        Me.lblQuantityInStock.TabIndex = 30
        Me.lblQuantityInStock.Text = "xxxxx"
        Me.lblQuantityInStock.Visible = False
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label108.Location = New System.Drawing.Point(23, 343)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(164, 20)
        Me.Label108.TabIndex = 29
        Me.Label108.Text = "Quantity in stock:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.Location = New System.Drawing.Point(23, 188)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 20)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Item brand:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(22, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(157, 25)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Item options"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblItemID.Location = New System.Drawing.Point(276, 60)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(59, 20)
        Me.lblItemID.TabIndex = 10
        Me.lblItemID.Text = "xxxxx"
        Me.lblItemID.Visible = False
        '
        'lblLastRestock
        '
        Me.lblLastRestock.AutoSize = True
        Me.lblLastRestock.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLastRestock.Location = New System.Drawing.Point(276, 91)
        Me.lblLastRestock.Name = "lblLastRestock"
        Me.lblLastRestock.Size = New System.Drawing.Size(59, 20)
        Me.lblLastRestock.TabIndex = 6
        Me.lblLastRestock.Text = "xxxxx"
        Me.lblLastRestock.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label29.Location = New System.Drawing.Point(23, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(171, 20)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Last Restock Date:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.Location = New System.Drawing.Point(23, 385)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(164, 20)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Restock Quantity:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label27.Location = New System.Drawing.Point(23, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(113, 20)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Item name:"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label.Location = New System.Drawing.Point(23, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(86, 20)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Item ID:"
        '
        'btnInventoryReport
        '
        Me.btnInventoryReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventoryReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnInventoryReport.FlatAppearance.BorderSize = 0
        Me.btnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventoryReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnInventoryReport.Location = New System.Drawing.Point(1411, 52)
        Me.btnInventoryReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInventoryReport.Name = "btnInventoryReport"
        Me.btnInventoryReport.Size = New System.Drawing.Size(171, 39)
        Me.btnInventoryReport.TabIndex = 22
        Me.btnInventoryReport.Text = "Weekly report"
        Me.btnInventoryReport.UseVisualStyleBackColor = False
        '
        'dgvInventory
        '
        Me.dgvInventory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventory.Location = New System.Drawing.Point(42, 101)
        Me.dgvInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvInventory.Name = "dgvInventory"
        Me.dgvInventory.RowHeadersWidth = 51
        Me.dgvInventory.Size = New System.Drawing.Size(883, 739)
        Me.dgvInventory.TabIndex = 21
        '
        'txtInventorySearch
        '
        Me.txtInventorySearch.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtInventorySearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInventorySearch.Location = New System.Drawing.Point(132, 62)
        Me.txtInventorySearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInventorySearch.Name = "txtInventorySearch"
        Me.txtInventorySearch.Size = New System.Drawing.Size(302, 28)
        Me.txtInventorySearch.TabIndex = 20
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(32, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 20)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "Search.."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Location = New System.Drawing.Point(19, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(346, 31)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Inventory management"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnSwitchTables)
        Me.TabPage3.Controls.Add(Me.btnRefreshServices)
        Me.TabPage3.Controls.Add(Me.btnWeeklyServicesReport)
        Me.TabPage3.Controls.Add(Me.btnViewService)
        Me.TabPage3.Controls.Add(Me.Panel18)
        Me.TabPage3.Controls.Add(Me.dgvServices)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label107)
        Me.TabPage3.Controls.Add(Me.Label106)
        Me.TabPage3.Location = New System.Drawing.Point(4, 32)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1774, 889)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Services"
        '
        'btnSwitchTables
        '
        Me.btnSwitchTables.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSwitchTables.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnSwitchTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwitchTables.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnSwitchTables.Location = New System.Drawing.Point(757, 55)
        Me.btnSwitchTables.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSwitchTables.Name = "btnSwitchTables"
        Me.btnSwitchTables.Size = New System.Drawing.Size(326, 38)
        Me.btnSwitchTables.TabIndex = 33
        Me.btnSwitchTables.Text = "Switch to Service transactions"
        Me.btnSwitchTables.UseVisualStyleBackColor = False
        '
        'btnRefreshServices
        '
        Me.btnRefreshServices.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRefreshServices.FlatAppearance.BorderSize = 0
        Me.btnRefreshServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefreshServices.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnRefreshServices.Location = New System.Drawing.Point(440, 55)
        Me.btnRefreshServices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefreshServices.Name = "btnRefreshServices"
        Me.btnRefreshServices.Size = New System.Drawing.Size(112, 38)
        Me.btnRefreshServices.TabIndex = 32
        Me.btnRefreshServices.Text = "Refresh"
        Me.btnRefreshServices.UseVisualStyleBackColor = False
        '
        'btnWeeklyServicesReport
        '
        Me.btnWeeklyServicesReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWeeklyServicesReport.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnWeeklyServicesReport.FlatAppearance.BorderSize = 0
        Me.btnWeeklyServicesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeeklyServicesReport.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnWeeklyServicesReport.Location = New System.Drawing.Point(1407, 51)
        Me.btnWeeklyServicesReport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWeeklyServicesReport.Name = "btnWeeklyServicesReport"
        Me.btnWeeklyServicesReport.Size = New System.Drawing.Size(171, 39)
        Me.btnWeeklyServicesReport.TabIndex = 31
        Me.btnWeeklyServicesReport.Text = "Weekly report"
        Me.btnWeeklyServicesReport.UseVisualStyleBackColor = False
        '
        'btnViewService
        '
        Me.btnViewService.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnViewService.FlatAppearance.BorderSize = 0
        Me.btnViewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewService.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewService.Location = New System.Drawing.Point(558, 55)
        Me.btnViewService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewService.Name = "btnViewService"
        Me.btnViewService.Size = New System.Drawing.Size(168, 38)
        Me.btnViewService.TabIndex = 30
        Me.btnViewService.Text = "Select service"
        Me.btnViewService.UseVisualStyleBackColor = False
        '
        'Panel18
        '
        Me.Panel18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.panServiceOptions)
        Me.Panel18.Location = New System.Drawing.Point(931, 101)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(647, 755)
        Me.Panel18.TabIndex = 26
        '
        'panServiceOptions
        '
        Me.panServiceOptions.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panServiceOptions.Controls.Add(Me.lblTimesAvailed)
        Me.panServiceOptions.Controls.Add(Me.Label110)
        Me.panServiceOptions.Controls.Add(Me.txtServiceDescription)
        Me.panServiceOptions.Controls.Add(Me.Label82)
        Me.panServiceOptions.Controls.Add(Me.btnClearFields)
        Me.panServiceOptions.Controls.Add(Me.btnUpdateService)
        Me.panServiceOptions.Controls.Add(Me.cbServiceStatus)
        Me.panServiceOptions.Controls.Add(Me.btnAddService)
        Me.panServiceOptions.Controls.Add(Me.lblServiceDateAdded)
        Me.panServiceOptions.Controls.Add(Me.btnDeleteService)
        Me.panServiceOptions.Controls.Add(Me.Label132)
        Me.panServiceOptions.Controls.Add(Me.cbServiceAvail)
        Me.panServiceOptions.Controls.Add(Me.txtServiceFee)
        Me.panServiceOptions.Controls.Add(Me.cbServiceName)
        Me.panServiceOptions.Controls.Add(Me.lblServiceDateModified)
        Me.panServiceOptions.Controls.Add(Me.Label114)
        Me.panServiceOptions.Controls.Add(Me.Label116)
        Me.panServiceOptions.Controls.Add(Me.Label120)
        Me.panServiceOptions.Controls.Add(Me.Label121)
        Me.panServiceOptions.Controls.Add(Me.Label122)
        Me.panServiceOptions.Controls.Add(Me.lblServiceID)
        Me.panServiceOptions.Controls.Add(Me.Label126)
        Me.panServiceOptions.Controls.Add(Me.Label127)
        Me.panServiceOptions.Controls.Add(Me.cbServiceCategory)
        Me.panServiceOptions.Controls.Add(Me.Label128)
        Me.panServiceOptions.Location = New System.Drawing.Point(3, 2)
        Me.panServiceOptions.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panServiceOptions.Name = "panServiceOptions"
        Me.panServiceOptions.Size = New System.Drawing.Size(639, 749)
        Me.panServiceOptions.TabIndex = 23
        '
        'lblTimesAvailed
        '
        Me.lblTimesAvailed.AutoSize = True
        Me.lblTimesAvailed.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTimesAvailed.Location = New System.Drawing.Point(280, 388)
        Me.lblTimesAvailed.Name = "lblTimesAvailed"
        Me.lblTimesAvailed.Size = New System.Drawing.Size(59, 20)
        Me.lblTimesAvailed.TabIndex = 47
        Me.lblTimesAvailed.Text = "xxxxx"
        Me.lblTimesAvailed.Visible = False
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label110.Location = New System.Drawing.Point(26, 388)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(135, 20)
        Me.Label110.TabIndex = 46
        Me.Label110.Text = "Times availed:"
        '
        'txtServiceDescription
        '
        Me.txtServiceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceDescription.Location = New System.Drawing.Point(30, 549)
        Me.txtServiceDescription.Name = "txtServiceDescription"
        Me.txtServiceDescription.Size = New System.Drawing.Size(579, 28)
        Me.txtServiceDescription.TabIndex = 45
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label82.Location = New System.Drawing.Point(26, 517)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(181, 20)
        Me.Label82.TabIndex = 44
        Me.Label82.Text = "Service description:"
        '
        'btnClearFields
        '
        Me.btnClearFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearFields.BackColor = System.Drawing.Color.Orange
        Me.btnClearFields.FlatAppearance.BorderSize = 0
        Me.btnClearFields.ForeColor = System.Drawing.Color.White
        Me.btnClearFields.Location = New System.Drawing.Point(478, 680)
        Me.btnClearFields.Name = "btnClearFields"
        Me.btnClearFields.Size = New System.Drawing.Size(141, 53)
        Me.btnClearFields.TabIndex = 43
        Me.btnClearFields.Text = "Clear Fields"
        Me.btnClearFields.UseVisualStyleBackColor = False
        '
        'btnUpdateService
        '
        Me.btnUpdateService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateService.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnUpdateService.FlatAppearance.BorderSize = 0
        Me.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateService.ForeColor = System.Drawing.Color.DimGray
        Me.btnUpdateService.Location = New System.Drawing.Point(255, 683)
        Me.btnUpdateService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdateService.Name = "btnUpdateService"
        Me.btnUpdateService.Size = New System.Drawing.Size(106, 46)
        Me.btnUpdateService.TabIndex = 28
        Me.btnUpdateService.Text = "Update"
        Me.btnUpdateService.UseVisualStyleBackColor = False
        '
        'cbServiceStatus
        '
        Me.cbServiceStatus.FormattingEnabled = True
        Me.cbServiceStatus.Items.AddRange(New Object() {"Available", "Unavailble", "Discontinued"})
        Me.cbServiceStatus.Location = New System.Drawing.Point(279, 324)
        Me.cbServiceStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbServiceStatus.Name = "cbServiceStatus"
        Me.cbServiceStatus.Size = New System.Drawing.Size(151, 28)
        Me.cbServiceStatus.TabIndex = 42
        '
        'btnAddService
        '
        Me.btnAddService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddService.BackColor = System.Drawing.Color.White
        Me.btnAddService.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddService.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnAddService.Location = New System.Drawing.Point(137, 683)
        Me.btnAddService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddService.Name = "btnAddService"
        Me.btnAddService.Size = New System.Drawing.Size(112, 46)
        Me.btnAddService.TabIndex = 27
        Me.btnAddService.Text = "Add"
        Me.btnAddService.UseVisualStyleBackColor = False
        '
        'lblServiceDateAdded
        '
        Me.lblServiceDateAdded.AutoSize = True
        Me.lblServiceDateAdded.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblServiceDateAdded.Location = New System.Drawing.Point(280, 432)
        Me.lblServiceDateAdded.Name = "lblServiceDateAdded"
        Me.lblServiceDateAdded.Size = New System.Drawing.Size(59, 20)
        Me.lblServiceDateAdded.TabIndex = 41
        Me.lblServiceDateAdded.Text = "xxxxx"
        Me.lblServiceDateAdded.Visible = False
        '
        'btnDeleteService
        '
        Me.btnDeleteService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteService.BackColor = System.Drawing.Color.Red
        Me.btnDeleteService.FlatAppearance.BorderSize = 0
        Me.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteService.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteService.Location = New System.Drawing.Point(367, 683)
        Me.btnDeleteService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteService.Name = "btnDeleteService"
        Me.btnDeleteService.Size = New System.Drawing.Size(106, 46)
        Me.btnDeleteService.TabIndex = 29
        Me.btnDeleteService.Text = "Delete"
        Me.btnDeleteService.UseVisualStyleBackColor = False
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label132.Location = New System.Drawing.Point(26, 432)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(122, 20)
        Me.Label132.TabIndex = 40
        Me.Label132.Text = "Date added: "
        '
        'cbServiceAvail
        '
        Me.cbServiceAvail.FormattingEnabled = True
        Me.cbServiceAvail.Items.AddRange(New Object() {"True", "False"})
        Me.cbServiceAvail.Location = New System.Drawing.Point(281, 262)
        Me.cbServiceAvail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbServiceAvail.Name = "cbServiceAvail"
        Me.cbServiceAvail.Size = New System.Drawing.Size(151, 28)
        Me.cbServiceAvail.TabIndex = 39
        '
        'txtServiceFee
        '
        Me.txtServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceFee.Location = New System.Drawing.Point(280, 213)
        Me.txtServiceFee.Name = "txtServiceFee"
        Me.txtServiceFee.Size = New System.Drawing.Size(152, 28)
        Me.txtServiceFee.TabIndex = 38
        '
        'cbServiceName
        '
        Me.cbServiceName.FormattingEnabled = True
        Me.cbServiceName.Location = New System.Drawing.Point(280, 158)
        Me.cbServiceName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbServiceName.Name = "cbServiceName"
        Me.cbServiceName.Size = New System.Drawing.Size(151, 28)
        Me.cbServiceName.TabIndex = 37
        '
        'lblServiceDateModified
        '
        Me.lblServiceDateModified.AutoSize = True
        Me.lblServiceDateModified.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblServiceDateModified.Location = New System.Drawing.Point(280, 466)
        Me.lblServiceDateModified.Name = "lblServiceDateModified"
        Me.lblServiceDateModified.Size = New System.Drawing.Size(59, 20)
        Me.lblServiceDateModified.TabIndex = 36
        Me.lblServiceDateModified.Text = "xxxxx"
        Me.lblServiceDateModified.Visible = False
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label114.Location = New System.Drawing.Point(26, 466)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(144, 20)
        Me.Label114.TabIndex = 35
        Me.Label114.Text = "Date modified: "
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label116.Location = New System.Drawing.Point(26, 327)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(79, 20)
        Me.Label116.TabIndex = 33
        Me.Label116.Text = "Status: "
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label120.Location = New System.Drawing.Point(25, 213)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(118, 20)
        Me.Label120.TabIndex = 29
        Me.Label120.Text = "Service fee: "
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label121.Location = New System.Drawing.Point(25, 158)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(134, 20)
        Me.Label121.TabIndex = 28
        Me.Label121.Text = "Service name:"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(22, 15)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(185, 25)
        Me.Label122.TabIndex = 11
        Me.Label122.Text = "Service options"
        '
        'lblServiceID
        '
        Me.lblServiceID.AutoSize = True
        Me.lblServiceID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblServiceID.Location = New System.Drawing.Point(276, 60)
        Me.lblServiceID.Name = "lblServiceID"
        Me.lblServiceID.Size = New System.Drawing.Size(59, 20)
        Me.lblServiceID.TabIndex = 10
        Me.lblServiceID.Text = "xxxxx"
        Me.lblServiceID.Visible = False
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label126.Location = New System.Drawing.Point(23, 265)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(168, 20)
        Me.Label126.TabIndex = 3
        Me.Label126.Text = "Service available: "
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label127.Location = New System.Drawing.Point(25, 111)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(163, 20)
        Me.Label127.TabIndex = 2
        Me.Label127.Text = "Service Category:"
        '
        'cbServiceCategory
        '
        Me.cbServiceCategory.FormattingEnabled = True
        Me.cbServiceCategory.Items.AddRange(New Object() {"Full Service", "Self Service"})
        Me.cbServiceCategory.Location = New System.Drawing.Point(279, 108)
        Me.cbServiceCategory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbServiceCategory.Name = "cbServiceCategory"
        Me.cbServiceCategory.Size = New System.Drawing.Size(151, 28)
        Me.cbServiceCategory.TabIndex = 1
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label128.Location = New System.Drawing.Point(23, 60)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(107, 20)
        Me.Label128.TabIndex = 0
        Me.Label128.Text = "Service ID:"
        '
        'dgvServices
        '
        Me.dgvServices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServices.Location = New System.Drawing.Point(42, 101)
        Me.dgvServices.Name = "dgvServices"
        Me.dgvServices.RowHeadersWidth = 51
        Me.dgvServices.RowTemplate.Height = 24
        Me.dgvServices.Size = New System.Drawing.Size(883, 752)
        Me.dgvServices.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(132, 62)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(302, 28)
        Me.TextBox2.TabIndex = 21
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.ForeColor = System.Drawing.Color.Black
        Me.Label107.Location = New System.Drawing.Point(32, 63)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(80, 20)
        Me.Label107.TabIndex = 20
        Me.Label107.Text = "Search.."
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label106.Location = New System.Drawing.Point(19, 14)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(326, 31)
        Me.Label106.TabIndex = 13
        Me.Label106.Text = "Services management"
        '
        'employeePage
        '
        Me.employeePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.employeePage.Controls.Add(Me.Panel7)
        Me.employeePage.Controls.Add(Me.Label23)
        Me.employeePage.Location = New System.Drawing.Point(4, 34)
        Me.employeePage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.employeePage.Name = "employeePage"
        Me.employeePage.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.employeePage.Size = New System.Drawing.Size(1625, 933)
        Me.employeePage.TabIndex = 1
        Me.employeePage.Text = "Employees"
        Me.employeePage.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.AutoScroll = True
        Me.Panel7.Controls.Add(Me.btnEmployeeDGVrefresh)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.dgvEmployee)
        Me.Panel7.Controls.Add(Me.txtSearch)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(2, 50)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1780, 875)
        Me.Panel7.TabIndex = 14
        '
        'btnEmployeeDGVrefresh
        '
        Me.btnEmployeeDGVrefresh.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEmployeeDGVrefresh.FlatAppearance.BorderSize = 0
        Me.btnEmployeeDGVrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployeeDGVrefresh.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployeeDGVrefresh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEmployeeDGVrefresh.Location = New System.Drawing.Point(351, 14)
        Me.btnEmployeeDGVrefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEmployeeDGVrefresh.Name = "btnEmployeeDGVrefresh"
        Me.btnEmployeeDGVrefresh.Size = New System.Drawing.Size(154, 46)
        Me.btnEmployeeDGVrefresh.TabIndex = 24
        Me.btnEmployeeDGVrefresh.Text = "Refresh"
        Me.btnEmployeeDGVrefresh.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.TabControl4)
        Me.Panel8.Location = New System.Drawing.Point(885, 65)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(727, 756)
        Me.Panel8.TabIndex = 20
        '
        'TabControl4
        '
        Me.TabControl4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl4.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl4.Controls.Add(Me.AddEmployee)
        Me.TabControl4.Controls.Add(Me.EditDetails)
        Me.TabControl4.Controls.Add(Me.RemoveEmployee)
        Me.TabControl4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl4.Location = New System.Drawing.Point(7, 2)
        Me.TabControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(715, 750)
        Me.TabControl4.TabIndex = 0
        '
        'AddEmployee
        '
        Me.AddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddEmployee.Controls.Add(Me.btnClearAddEm)
        Me.AddEmployee.Controls.Add(Me.cbAddEmSex)
        Me.AddEmployee.Controls.Add(Me.Label117)
        Me.AddEmployee.Controls.Add(Me.btnAddEmConfirm)
        Me.AddEmployee.Controls.Add(Me.btnAddEmPass)
        Me.AddEmployee.Controls.Add(Me.txtEmployeeAge)
        Me.AddEmployee.Controls.Add(Me.Label113)
        Me.AddEmployee.Controls.Add(Me.Label68)
        Me.AddEmployee.Controls.Add(Me.Label74)
        Me.AddEmployee.Controls.Add(Me.Label103)
        Me.AddEmployee.Controls.Add(Me.Label104)
        Me.AddEmployee.Controls.Add(Me.Label102)
        Me.AddEmployee.Controls.Add(Me.cbAddShift)
        Me.AddEmployee.Controls.Add(Me.cbAddWorkingHours)
        Me.AddEmployee.Controls.Add(Me.cbAddProvince)
        Me.AddEmployee.Controls.Add(Me.cbAddCity)
        Me.AddEmployee.Controls.Add(Me.Label98)
        Me.AddEmployee.Controls.Add(Me.Label99)
        Me.AddEmployee.Controls.Add(Me.Label100)
        Me.AddEmployee.Controls.Add(Me.Label101)
        Me.AddEmployee.Controls.Add(Me.Label53)
        Me.AddEmployee.Controls.Add(Me.Label54)
        Me.AddEmployee.Controls.Add(Me.Label56)
        Me.AddEmployee.Controls.Add(Me.Label57)
        Me.AddEmployee.Controls.Add(Me.txtAddEmUserName)
        Me.AddEmployee.Controls.Add(Me.txtAddConfirmPass)
        Me.AddEmployee.Controls.Add(Me.txtAddEmPassword)
        Me.AddEmployee.Controls.Add(Me.txtAddEmEmail)
        Me.AddEmployee.Controls.Add(Me.txtAddEmContact)
        Me.AddEmployee.Controls.Add(Me.txtAddEmLast)
        Me.AddEmployee.Controls.Add(Me.txtAddEmFirst)
        Me.AddEmployee.Controls.Add(Me.btnAddEmployee)
        Me.AddEmployee.Location = New System.Drawing.Point(4, 32)
        Me.AddEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddEmployee.Name = "AddEmployee"
        Me.AddEmployee.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddEmployee.Size = New System.Drawing.Size(707, 714)
        Me.AddEmployee.TabIndex = 1
        Me.AddEmployee.Text = "Add employee"
        Me.AddEmployee.UseVisualStyleBackColor = True
        '
        'btnClearAddEm
        '
        Me.btnClearAddEm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearAddEm.BackColor = System.Drawing.Color.Orange
        Me.btnClearAddEm.FlatAppearance.BorderSize = 0
        Me.btnClearAddEm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAddEm.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAddEm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClearAddEm.Location = New System.Drawing.Point(358, 657)
        Me.btnClearAddEm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearAddEm.Name = "btnClearAddEm"
        Me.btnClearAddEm.Size = New System.Drawing.Size(154, 46)
        Me.btnClearAddEm.TabIndex = 84
        Me.btnClearAddEm.Text = "Clear fields"
        Me.btnClearAddEm.UseVisualStyleBackColor = False
        '
        'cbAddEmSex
        '
        Me.cbAddEmSex.FormattingEnabled = True
        Me.cbAddEmSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbAddEmSex.Location = New System.Drawing.Point(236, 251)
        Me.cbAddEmSex.Name = "cbAddEmSex"
        Me.cbAddEmSex.Size = New System.Drawing.Size(189, 28)
        Me.cbAddEmSex.TabIndex = 83
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(48, 251)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(49, 20)
        Me.Label117.TabIndex = 82
        Me.Label117.Text = "Sex:"
        '
        'btnAddEmConfirm
        '
        Me.btnAddEmConfirm.Location = New System.Drawing.Point(640, 576)
        Me.btnAddEmConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddEmConfirm.Name = "btnAddEmConfirm"
        Me.btnAddEmConfirm.Size = New System.Drawing.Size(51, 28)
        Me.btnAddEmConfirm.TabIndex = 81
        Me.btnAddEmConfirm.Text = "👁"
        Me.btnAddEmConfirm.UseVisualStyleBackColor = True
        '
        'btnAddEmPass
        '
        Me.btnAddEmPass.Location = New System.Drawing.Point(640, 537)
        Me.btnAddEmPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddEmPass.Name = "btnAddEmPass"
        Me.btnAddEmPass.Size = New System.Drawing.Size(51, 28)
        Me.btnAddEmPass.TabIndex = 80
        Me.btnAddEmPass.Text = "👁"
        Me.btnAddEmPass.UseVisualStyleBackColor = True
        '
        'txtEmployeeAge
        '
        Me.txtEmployeeAge.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmployeeAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeAge.Location = New System.Drawing.Point(235, 203)
        Me.txtEmployeeAge.Name = "txtEmployeeAge"
        Me.txtEmployeeAge.Size = New System.Drawing.Size(384, 28)
        Me.txtEmployeeAge.TabIndex = 79
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(47, 205)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(50, 20)
        Me.Label113.TabIndex = 78
        Me.Label113.Text = "Age:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(23, 466)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(92, 22)
        Me.Label68.TabIndex = 77
        Me.Label68.Text = "Account"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(52, 505)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(103, 20)
        Me.Label74.TabIndex = 75
        Me.Label74.Text = "Username:"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(47, 576)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(129, 20)
        Me.Label103.TabIndex = 74
        Me.Label103.Text = "Confirm Pass:"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(50, 541)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(97, 20)
        Me.Label104.TabIndex = 73
        Me.Label104.Text = "Password:"
        '
        'Label102
        '
        Me.Label102.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(25, 12)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(184, 22)
        Me.Label102.TabIndex = 71
        Me.Label102.Text = "Employee Details"
        '
        'cbAddShift
        '
        Me.cbAddShift.FormattingEnabled = True
        Me.cbAddShift.Location = New System.Drawing.Point(236, 394)
        Me.cbAddShift.Name = "cbAddShift"
        Me.cbAddShift.Size = New System.Drawing.Size(189, 28)
        Me.cbAddShift.TabIndex = 70
        '
        'cbAddWorkingHours
        '
        Me.cbAddWorkingHours.FormattingEnabled = True
        Me.cbAddWorkingHours.Items.AddRange(New Object() {"Full-time", "Part-time"})
        Me.cbAddWorkingHours.Location = New System.Drawing.Point(236, 361)
        Me.cbAddWorkingHours.Name = "cbAddWorkingHours"
        Me.cbAddWorkingHours.Size = New System.Drawing.Size(189, 28)
        Me.cbAddWorkingHours.TabIndex = 69
        '
        'cbAddProvince
        '
        Me.cbAddProvince.FormattingEnabled = True
        Me.cbAddProvince.Items.AddRange(New Object() {"Camarines Norte"})
        Me.cbAddProvince.Location = New System.Drawing.Point(236, 326)
        Me.cbAddProvince.Name = "cbAddProvince"
        Me.cbAddProvince.Size = New System.Drawing.Size(189, 28)
        Me.cbAddProvince.TabIndex = 68
        '
        'cbAddCity
        '
        Me.cbAddCity.FormattingEnabled = True
        Me.cbAddCity.Items.AddRange(New Object() {"Daet", "Basud", "Capalonga", "Jose Panganiban", "Labo", "Mercedes", "Paracale", "San Lorenzo Ruiz", "San Vicente", "Santa Elena", "Talisay", "Vinzons"})
        Me.cbAddCity.Location = New System.Drawing.Point(236, 287)
        Me.cbAddCity.Name = "cbAddCity"
        Me.cbAddCity.Size = New System.Drawing.Size(189, 28)
        Me.cbAddCity.TabIndex = 67
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(48, 397)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(58, 20)
        Me.Label98.TabIndex = 66
        Me.Label98.Text = "Shift:"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(48, 361)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(143, 20)
        Me.Label99.TabIndex = 65
        Me.Label99.Text = "Working Hours:"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(48, 326)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(89, 20)
        Me.Label100.TabIndex = 64
        Me.Label100.Text = "Province:"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(48, 295)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(102, 20)
        Me.Label101.TabIndex = 63
        Me.Label101.Text = "City/Town:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(48, 162)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(65, 20)
        Me.Label53.TabIndex = 62
        Me.Label53.Text = "Email:"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(48, 93)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(108, 20)
        Me.Label54.TabIndex = 61
        Me.Label54.Text = "Last Name:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(48, 127)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(83, 20)
        Me.Label56.TabIndex = 59
        Me.Label56.Text = "Contact:"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(48, 59)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(111, 20)
        Me.Label57.TabIndex = 58
        Me.Label57.Text = "First Name:"
        '
        'txtAddEmUserName
        '
        Me.txtAddEmUserName.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmUserName.Location = New System.Drawing.Point(235, 499)
        Me.txtAddEmUserName.Name = "txtAddEmUserName"
        Me.txtAddEmUserName.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmUserName.TabIndex = 57
        '
        'txtAddConfirmPass
        '
        Me.txtAddConfirmPass.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddConfirmPass.Location = New System.Drawing.Point(235, 574)
        Me.txtAddConfirmPass.Name = "txtAddConfirmPass"
        Me.txtAddConfirmPass.Size = New System.Drawing.Size(384, 28)
        Me.txtAddConfirmPass.TabIndex = 55
        '
        'txtAddEmPassword
        '
        Me.txtAddEmPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmPassword.Location = New System.Drawing.Point(235, 539)
        Me.txtAddEmPassword.Name = "txtAddEmPassword"
        Me.txtAddEmPassword.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmPassword.TabIndex = 53
        '
        'txtAddEmEmail
        '
        Me.txtAddEmEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmEmail.Location = New System.Drawing.Point(235, 154)
        Me.txtAddEmEmail.Name = "txtAddEmEmail"
        Me.txtAddEmEmail.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmEmail.TabIndex = 50
        '
        'txtAddEmContact
        '
        Me.txtAddEmContact.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmContact.Location = New System.Drawing.Point(235, 119)
        Me.txtAddEmContact.Name = "txtAddEmContact"
        Me.txtAddEmContact.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmContact.TabIndex = 49
        '
        'txtAddEmLast
        '
        Me.txtAddEmLast.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmLast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmLast.Location = New System.Drawing.Point(235, 85)
        Me.txtAddEmLast.Name = "txtAddEmLast"
        Me.txtAddEmLast.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmLast.TabIndex = 48
        '
        'txtAddEmFirst
        '
        Me.txtAddEmFirst.BackColor = System.Drawing.SystemColors.Info
        Me.txtAddEmFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddEmFirst.Location = New System.Drawing.Point(235, 51)
        Me.txtAddEmFirst.Name = "txtAddEmFirst"
        Me.txtAddEmFirst.Size = New System.Drawing.Size(384, 28)
        Me.txtAddEmFirst.TabIndex = 47
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmployee.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnAddEmployee.FlatAppearance.BorderSize = 0
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAddEmployee.Location = New System.Drawing.Point(518, 657)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(154, 46)
        Me.btnAddEmployee.TabIndex = 23
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'EditDetails
        '
        Me.EditDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EditDetails.Controls.Add(Me.btnEditConfirm)
        Me.EditDetails.Controls.Add(Me.btnEditUserAcc)
        Me.EditDetails.Controls.Add(Me.lblInvisibleIDEDIT)
        Me.EditDetails.Controls.Add(Me.btnClearEditFields)
        Me.EditDetails.Controls.Add(Me.txtEditEmAge)
        Me.EditDetails.Controls.Add(Me.Label115)
        Me.EditDetails.Controls.Add(Me.btnSelectEdit)
        Me.EditDetails.Controls.Add(Me.Label97)
        Me.EditDetails.Controls.Add(Me.lblEmployeeFunc)
        Me.EditDetails.Controls.Add(Me.cbEmShift)
        Me.EditDetails.Controls.Add(Me.cbEmWorkingHours)
        Me.EditDetails.Controls.Add(Me.cbEmProvince)
        Me.EditDetails.Controls.Add(Me.cbEmCityTown)
        Me.EditDetails.Controls.Add(Me.Label96)
        Me.EditDetails.Controls.Add(Me.Label95)
        Me.EditDetails.Controls.Add(Me.lblEmployeeDateAdded)
        Me.EditDetails.Controls.Add(Me.Label94)
        Me.EditDetails.Controls.Add(Me.Label93)
        Me.EditDetails.Controls.Add(Me.Label91)
        Me.EditDetails.Controls.Add(Me.txtEmUserName)
        Me.EditDetails.Controls.Add(Me.Label71)
        Me.EditDetails.Controls.Add(Me.txtEditConfirmPass)
        Me.EditDetails.Controls.Add(Me.Label69)
        Me.EditDetails.Controls.Add(Me.txtEmPassword)
        Me.EditDetails.Controls.Add(Me.Label42)
        Me.EditDetails.Controls.Add(Me.btnEditEmployees)
        Me.EditDetails.Controls.Add(Me.lblEmployeeID)
        Me.EditDetails.Controls.Add(Me.txtEmail)
        Me.EditDetails.Controls.Add(Me.txtContact)
        Me.EditDetails.Controls.Add(Me.txtEmployeeLastName)
        Me.EditDetails.Controls.Add(Me.txtEmployeeFirstName)
        Me.EditDetails.Controls.Add(Me.lblEmployeeStatus)
        Me.EditDetails.Controls.Add(Me.Label51)
        Me.EditDetails.Controls.Add(Me.Label50)
        Me.EditDetails.Controls.Add(Me.Label49)
        Me.EditDetails.Controls.Add(Me.Label48)
        Me.EditDetails.Controls.Add(Me.Label31)
        Me.EditDetails.Controls.Add(Me.Label30)
        Me.EditDetails.Controls.Add(Me.btnEdit)
        Me.EditDetails.Location = New System.Drawing.Point(4, 32)
        Me.EditDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditDetails.Name = "EditDetails"
        Me.EditDetails.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditDetails.Size = New System.Drawing.Size(707, 714)
        Me.EditDetails.TabIndex = 0
        Me.EditDetails.Text = "Edit employee"
        Me.EditDetails.UseVisualStyleBackColor = True
        '
        'btnEditConfirm
        '
        Me.btnEditConfirm.Location = New System.Drawing.Point(629, 522)
        Me.btnEditConfirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditConfirm.Name = "btnEditConfirm"
        Me.btnEditConfirm.Size = New System.Drawing.Size(51, 28)
        Me.btnEditConfirm.TabIndex = 88
        Me.btnEditConfirm.Text = "👁"
        Me.btnEditConfirm.UseVisualStyleBackColor = True
        '
        'btnEditUserAcc
        '
        Me.btnEditUserAcc.Location = New System.Drawing.Point(629, 483)
        Me.btnEditUserAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditUserAcc.Name = "btnEditUserAcc"
        Me.btnEditUserAcc.Size = New System.Drawing.Size(51, 28)
        Me.btnEditUserAcc.TabIndex = 87
        Me.btnEditUserAcc.Text = "👁"
        Me.btnEditUserAcc.UseVisualStyleBackColor = True
        '
        'lblInvisibleIDEDIT
        '
        Me.lblInvisibleIDEDIT.AutoSize = True
        Me.lblInvisibleIDEDIT.Location = New System.Drawing.Point(454, 55)
        Me.lblInvisibleIDEDIT.Name = "lblInvisibleIDEDIT"
        Me.lblInvisibleIDEDIT.Size = New System.Drawing.Size(107, 20)
        Me.lblInvisibleIDEDIT.TabIndex = 86
        Me.lblInvisibleIDEDIT.Text = "invisible_id"
        Me.lblInvisibleIDEDIT.Visible = False
        '
        'btnClearEditFields
        '
        Me.btnClearEditFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearEditFields.BackColor = System.Drawing.Color.Orange
        Me.btnClearEditFields.FlatAppearance.BorderSize = 0
        Me.btnClearEditFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearEditFields.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEditFields.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClearEditFields.Location = New System.Drawing.Point(366, 662)
        Me.btnClearEditFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClearEditFields.Name = "btnClearEditFields"
        Me.btnClearEditFields.Size = New System.Drawing.Size(154, 46)
        Me.btnClearEditFields.TabIndex = 85
        Me.btnClearEditFields.Text = "Clear fields"
        Me.btnClearEditFields.UseVisualStyleBackColor = False
        '
        'txtEditEmAge
        '
        Me.txtEditEmAge.BackColor = System.Drawing.SystemColors.Info
        Me.txtEditEmAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditEmAge.Location = New System.Drawing.Point(296, 234)
        Me.txtEditEmAge.Name = "txtEditEmAge"
        Me.txtEditEmAge.Size = New System.Drawing.Size(384, 28)
        Me.txtEditEmAge.TabIndex = 61
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(37, 242)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(50, 20)
        Me.Label115.TabIndex = 60
        Me.Label115.Text = "Age:"
        '
        'btnSelectEdit
        '
        Me.btnSelectEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectEdit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSelectEdit.FlatAppearance.BorderSize = 0
        Me.btnSelectEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectEdit.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectEdit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectEdit.Location = New System.Drawing.Point(231, 662)
        Me.btnSelectEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectEdit.Name = "btnSelectEdit"
        Me.btnSelectEdit.Size = New System.Drawing.Size(129, 46)
        Me.btnSelectEdit.TabIndex = 23
        Me.btnSelectEdit.Text = "Select"
        Me.btnSelectEdit.UseVisualStyleBackColor = False
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(17, 412)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(92, 22)
        Me.Label97.TabIndex = 59
        Me.Label97.Text = "Account"
        '
        'lblEmployeeFunc
        '
        Me.lblEmployeeFunc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployeeFunc.AutoSize = True
        Me.lblEmployeeFunc.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeFunc.Location = New System.Drawing.Point(13, 16)
        Me.lblEmployeeFunc.Name = "lblEmployeeFunc"
        Me.lblEmployeeFunc.Size = New System.Drawing.Size(184, 22)
        Me.lblEmployeeFunc.TabIndex = 22
        Me.lblEmployeeFunc.Text = "Employee Details"
        '
        'cbEmShift
        '
        Me.cbEmShift.FormattingEnabled = True
        Me.cbEmShift.Location = New System.Drawing.Point(296, 384)
        Me.cbEmShift.Name = "cbEmShift"
        Me.cbEmShift.Size = New System.Drawing.Size(189, 28)
        Me.cbEmShift.TabIndex = 58
        '
        'cbEmWorkingHours
        '
        Me.cbEmWorkingHours.FormattingEnabled = True
        Me.cbEmWorkingHours.Location = New System.Drawing.Point(296, 351)
        Me.cbEmWorkingHours.Name = "cbEmWorkingHours"
        Me.cbEmWorkingHours.Size = New System.Drawing.Size(189, 28)
        Me.cbEmWorkingHours.TabIndex = 57
        '
        'cbEmProvince
        '
        Me.cbEmProvince.FormattingEnabled = True
        Me.cbEmProvince.Location = New System.Drawing.Point(296, 316)
        Me.cbEmProvince.Name = "cbEmProvince"
        Me.cbEmProvince.Size = New System.Drawing.Size(189, 28)
        Me.cbEmProvince.TabIndex = 56
        '
        'cbEmCityTown
        '
        Me.cbEmCityTown.FormattingEnabled = True
        Me.cbEmCityTown.Location = New System.Drawing.Point(296, 277)
        Me.cbEmCityTown.Name = "cbEmCityTown"
        Me.cbEmCityTown.Size = New System.Drawing.Size(189, 28)
        Me.cbEmCityTown.TabIndex = 55
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(37, 387)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(58, 20)
        Me.Label96.TabIndex = 54
        Me.Label96.Text = "Shift:"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(37, 351)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(143, 20)
        Me.Label95.TabIndex = 53
        Me.Label95.Text = "Working Hours:"
        '
        'lblEmployeeDateAdded
        '
        Me.lblEmployeeDateAdded.AutoSize = True
        Me.lblEmployeeDateAdded.Location = New System.Drawing.Point(296, 589)
        Me.lblEmployeeDateAdded.Name = "lblEmployeeDateAdded"
        Me.lblEmployeeDateAdded.Size = New System.Drawing.Size(108, 20)
        Me.lblEmployeeDateAdded.TabIndex = 52
        Me.lblEmployeeDateAdded.Text = "placeholder"
        Me.lblEmployeeDateAdded.Visible = False
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(41, 589)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(118, 20)
        Me.Label94.TabIndex = 51
        Me.Label94.Text = "Date Added:"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(37, 316)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(89, 20)
        Me.Label93.TabIndex = 50
        Me.Label93.Text = "Province:"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(37, 285)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(102, 20)
        Me.Label91.TabIndex = 49
        Me.Label91.Text = "City/Town:"
        '
        'txtEmUserName
        '
        Me.txtEmUserName.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmUserName.Location = New System.Drawing.Point(296, 443)
        Me.txtEmUserName.Name = "txtEmUserName"
        Me.txtEmUserName.Size = New System.Drawing.Size(384, 28)
        Me.txtEmUserName.TabIndex = 48
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(46, 451)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(103, 20)
        Me.Label71.TabIndex = 47
        Me.Label71.Text = "Username:"
        '
        'txtEditConfirmPass
        '
        Me.txtEditConfirmPass.BackColor = System.Drawing.SystemColors.Info
        Me.txtEditConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditConfirmPass.Location = New System.Drawing.Point(296, 520)
        Me.txtEditConfirmPass.Name = "txtEditConfirmPass"
        Me.txtEditConfirmPass.Size = New System.Drawing.Size(316, 28)
        Me.txtEditConfirmPass.TabIndex = 46
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(41, 522)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(129, 20)
        Me.Label69.TabIndex = 45
        Me.Label69.Text = "Confirm Pass:"
        '
        'txtEmPassword
        '
        Me.txtEmPassword.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmPassword.Location = New System.Drawing.Point(296, 485)
        Me.txtEmPassword.Name = "txtEmPassword"
        Me.txtEmPassword.Size = New System.Drawing.Size(316, 28)
        Me.txtEmPassword.TabIndex = 44
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(44, 487)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(97, 20)
        Me.Label42.TabIndex = 43
        Me.Label42.Text = "Password:"
        '
        'btnEditEmployees
        '
        Me.btnEditEmployees.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditEmployees.BackColor = System.Drawing.Color.Yellow
        Me.btnEditEmployees.FlatAppearance.BorderSize = 0
        Me.btnEditEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditEmployees.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEmployees.ForeColor = System.Drawing.Color.Black
        Me.btnEditEmployees.Location = New System.Drawing.Point(526, 662)
        Me.btnEditEmployees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditEmployees.Name = "btnEditEmployees"
        Me.btnEditEmployees.Size = New System.Drawing.Size(154, 46)
        Me.btnEditEmployees.TabIndex = 42
        Me.btnEditEmployees.Text = "Apply Edit"
        Me.btnEditEmployees.UseVisualStyleBackColor = False
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(296, 55)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(108, 20)
        Me.lblEmployeeID.TabIndex = 41
        Me.lblEmployeeID.Text = "placeholder"
        Me.lblEmployeeID.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(296, 196)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(384, 28)
        Me.txtEmail.TabIndex = 40
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.SystemColors.Info
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Location = New System.Drawing.Point(296, 161)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(384, 28)
        Me.txtContact.TabIndex = 39
        '
        'txtEmployeeLastName
        '
        Me.txtEmployeeLastName.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmployeeLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeLastName.Location = New System.Drawing.Point(296, 127)
        Me.txtEmployeeLastName.Name = "txtEmployeeLastName"
        Me.txtEmployeeLastName.Size = New System.Drawing.Size(384, 28)
        Me.txtEmployeeLastName.TabIndex = 38
        '
        'txtEmployeeFirstName
        '
        Me.txtEmployeeFirstName.BackColor = System.Drawing.SystemColors.Info
        Me.txtEmployeeFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeFirstName.Location = New System.Drawing.Point(296, 93)
        Me.txtEmployeeFirstName.Name = "txtEmployeeFirstName"
        Me.txtEmployeeFirstName.Size = New System.Drawing.Size(384, 28)
        Me.txtEmployeeFirstName.TabIndex = 37
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(296, 558)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(108, 20)
        Me.lblEmployeeStatus.TabIndex = 35
        Me.lblEmployeeStatus.Text = "placeholder"
        Me.lblEmployeeStatus.Visible = False
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(41, 558)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(73, 20)
        Me.Label51.TabIndex = 34
        Me.Label51.Text = "Status:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(37, 198)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(65, 20)
        Me.Label50.TabIndex = 33
        Me.Label50.Text = "Email:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(37, 129)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(108, 20)
        Me.Label49.TabIndex = 31
        Me.Label49.Text = "Last Name:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(36, 55)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(128, 20)
        Me.Label48.TabIndex = 29
        Me.Label48.Text = "Employee ID:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(37, 163)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 20)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "Contact:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(37, 95)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(111, 20)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "First Name:"
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Black
        Me.btnEdit.Location = New System.Drawing.Point(526, 715)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(154, 46)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Confirm edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'RemoveEmployee
        '
        Me.RemoveEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemoveEmployee.Controls.Add(Me.btnRemoveFields)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmDate)
        Me.RemoveEmployee.Controls.Add(Me.Label118)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmInvi)
        Me.RemoveEmployee.Controls.Add(Me.btnSelectDelete)
        Me.RemoveEmployee.Controls.Add(Me.Label55)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmStatus)
        Me.RemoveEmployee.Controls.Add(Me.Label92)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmContact)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmEmail)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmName)
        Me.RemoveEmployee.Controls.Add(Me.lblRemEmID)
        Me.RemoveEmployee.Controls.Add(Me.Label59)
        Me.RemoveEmployee.Controls.Add(Me.Label61)
        Me.RemoveEmployee.Controls.Add(Me.Label62)
        Me.RemoveEmployee.Controls.Add(Me.Label63)
        Me.RemoveEmployee.Controls.Add(Me.btnRemoveEmployee)
        Me.RemoveEmployee.Location = New System.Drawing.Point(4, 32)
        Me.RemoveEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RemoveEmployee.Name = "RemoveEmployee"
        Me.RemoveEmployee.Size = New System.Drawing.Size(707, 714)
        Me.RemoveEmployee.TabIndex = 2
        Me.RemoveEmployee.Text = "Remove Employee"
        Me.RemoveEmployee.UseVisualStyleBackColor = True
        '
        'btnRemoveFields
        '
        Me.btnRemoveFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveFields.BackColor = System.Drawing.Color.Orange
        Me.btnRemoveFields.FlatAppearance.BorderSize = 0
        Me.btnRemoveFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveFields.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveFields.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnRemoveFields.Location = New System.Drawing.Point(340, 649)
        Me.btnRemoveFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveFields.Name = "btnRemoveFields"
        Me.btnRemoveFields.Size = New System.Drawing.Size(154, 46)
        Me.btnRemoveFields.TabIndex = 86
        Me.btnRemoveFields.Text = "Clear fields"
        Me.btnRemoveFields.UseVisualStyleBackColor = False
        '
        'lblRemEmDate
        '
        Me.lblRemEmDate.AutoSize = True
        Me.lblRemEmDate.Location = New System.Drawing.Point(223, 302)
        Me.lblRemEmDate.Name = "lblRemEmDate"
        Me.lblRemEmDate.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmDate.TabIndex = 76
        Me.lblRemEmDate.Visible = False
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(42, 302)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(116, 20)
        Me.Label118.TabIndex = 75
        Me.Label118.Text = "Date added:"
        '
        'lblRemEmInvi
        '
        Me.lblRemEmInvi.AutoSize = True
        Me.lblRemEmInvi.Location = New System.Drawing.Point(407, 114)
        Me.lblRemEmInvi.Name = "lblRemEmInvi"
        Me.lblRemEmInvi.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmInvi.TabIndex = 74
        Me.lblRemEmInvi.Visible = False
        '
        'btnSelectDelete
        '
        Me.btnSelectDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectDelete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnSelectDelete.FlatAppearance.BorderSize = 0
        Me.btnSelectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectDelete.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDelete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSelectDelete.Location = New System.Drawing.Point(205, 649)
        Me.btnSelectDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelectDelete.Name = "btnSelectDelete"
        Me.btnSelectDelete.Size = New System.Drawing.Size(129, 46)
        Me.btnSelectDelete.TabIndex = 73
        Me.btnSelectDelete.Text = "Select"
        Me.btnSelectDelete.UseVisualStyleBackColor = False
        '
        'Label55
        '
        Me.Label55.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(24, 58)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(184, 22)
        Me.Label55.TabIndex = 72
        Me.Label55.Text = "Employee Details"
        '
        'lblRemEmStatus
        '
        Me.lblRemEmStatus.AutoSize = True
        Me.lblRemEmStatus.Location = New System.Drawing.Point(223, 260)
        Me.lblRemEmStatus.Name = "lblRemEmStatus"
        Me.lblRemEmStatus.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmStatus.TabIndex = 56
        Me.lblRemEmStatus.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(42, 260)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(73, 20)
        Me.Label92.TabIndex = 55
        Me.Label92.Text = "Status:"
        '
        'lblRemEmContact
        '
        Me.lblRemEmContact.AutoSize = True
        Me.lblRemEmContact.Location = New System.Drawing.Point(223, 192)
        Me.lblRemEmContact.Name = "lblRemEmContact"
        Me.lblRemEmContact.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmContact.TabIndex = 54
        Me.lblRemEmContact.Visible = False
        '
        'lblRemEmEmail
        '
        Me.lblRemEmEmail.AutoSize = True
        Me.lblRemEmEmail.Location = New System.Drawing.Point(223, 227)
        Me.lblRemEmEmail.Name = "lblRemEmEmail"
        Me.lblRemEmEmail.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmEmail.TabIndex = 54
        Me.lblRemEmEmail.Visible = False
        '
        'lblRemEmName
        '
        Me.lblRemEmName.AutoSize = True
        Me.lblRemEmName.Location = New System.Drawing.Point(223, 151)
        Me.lblRemEmName.Name = "lblRemEmName"
        Me.lblRemEmName.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmName.TabIndex = 52
        Me.lblRemEmName.Visible = False
        '
        'lblRemEmID
        '
        Me.lblRemEmID.AutoSize = True
        Me.lblRemEmID.Location = New System.Drawing.Point(223, 116)
        Me.lblRemEmID.Name = "lblRemEmID"
        Me.lblRemEmID.Size = New System.Drawing.Size(0, 20)
        Me.lblRemEmID.TabIndex = 51
        Me.lblRemEmID.Visible = False
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(42, 227)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(65, 20)
        Me.Label59.TabIndex = 46
        Me.Label59.Text = "Email:"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(42, 114)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(128, 20)
        Me.Label61.TabIndex = 44
        Me.Label61.Text = "Employee ID:"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(42, 192)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(83, 20)
        Me.Label62.TabIndex = 43
        Me.Label62.Text = "Contact:"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(42, 151)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(104, 20)
        Me.Label63.TabIndex = 42
        Me.Label63.Text = "Full Name:"
        '
        'btnRemoveEmployee
        '
        Me.btnRemoveEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveEmployee.BackColor = System.Drawing.Color.Red
        Me.btnRemoveEmployee.FlatAppearance.BorderSize = 0
        Me.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveEmployee.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoveEmployee.Location = New System.Drawing.Point(500, 649)
        Me.btnRemoveEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemoveEmployee.Name = "btnRemoveEmployee"
        Me.btnRemoveEmployee.Size = New System.Drawing.Size(192, 46)
        Me.btnRemoveEmployee.TabIndex = 24
        Me.btnRemoveEmployee.Text = "Remove Employee"
        Me.btnRemoveEmployee.UseVisualStyleBackColor = False
        '
        'dgvEmployee
        '
        Me.dgvEmployee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployee.Location = New System.Drawing.Point(14, 65)
        Me.dgvEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvEmployee.Name = "dgvEmployee"
        Me.dgvEmployee.RowHeadersWidth = 51
        Me.dgvEmployee.Size = New System.Drawing.Size(865, 756)
        Me.dgvEmployee.TabIndex = 19
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(117, 24)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 29)
        Me.txtSearch.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(17, 26)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 22)
        Me.Label24.TabIndex = 17
        Me.Label24.Text = "Search.."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label23.Location = New System.Drawing.Point(16, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(343, 31)
        Me.Label23.TabIndex = 13
        Me.Label23.Text = "Employee management"
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.TabControl3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1625, 933)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Orders"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl3.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl3.Controls.Add(Me.add)
        Me.TabControl3.Controls.Add(Me.Pending)
        Me.TabControl3.Controls.Add(Me.Cancelled)
        Me.TabControl3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(3, 2)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1614, 933)
        Me.TabControl3.TabIndex = 0
        '
        'add
        '
        Me.add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.add.Controls.Add(Me.PictureBox2)
        Me.add.Controls.Add(Me.panOrderInfo)
        Me.add.Controls.Add(Me.Panel2)
        Me.add.Location = New System.Drawing.Point(4, 32)
        Me.add.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.add.Name = "add"
        Me.add.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.add.Size = New System.Drawing.Size(1606, 897)
        Me.add.TabIndex = 0
        Me.add.Text = "Add"
        Me.add.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(6, 659)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(777, 227)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'panOrderInfo
        '
        Me.panOrderInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panOrderInfo.BackColor = System.Drawing.SystemColors.Control
        Me.panOrderInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panOrderInfo.Controls.Add(Me.lblInvisibleOrderID)
        Me.panOrderInfo.Controls.Add(Me.lblInvisibleCustomerID)
        Me.panOrderInfo.Controls.Add(Me.Panel13)
        Me.panOrderInfo.Controls.Add(Me.Label1)
        Me.panOrderInfo.Controls.Add(Me.Panel12)
        Me.panOrderInfo.Controls.Add(Me.btnCancelOrder)
        Me.panOrderInfo.Controls.Add(Me.Panel10)
        Me.panOrderInfo.Controls.Add(Me.Panel5)
        Me.panOrderInfo.Controls.Add(Me.Label6)
        Me.panOrderInfo.Controls.Add(Me.Label34)
        Me.panOrderInfo.Controls.Add(Me.btnComplete)
        Me.panOrderInfo.Location = New System.Drawing.Point(789, 3)
        Me.panOrderInfo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panOrderInfo.Name = "panOrderInfo"
        Me.panOrderInfo.Size = New System.Drawing.Size(809, 888)
        Me.panOrderInfo.TabIndex = 25
        Me.panOrderInfo.Visible = False
        '
        'lblInvisibleOrderID
        '
        Me.lblInvisibleOrderID.AutoSize = True
        Me.lblInvisibleOrderID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvisibleOrderID.Location = New System.Drawing.Point(561, 655)
        Me.lblInvisibleOrderID.Name = "lblInvisibleOrderID"
        Me.lblInvisibleOrderID.Size = New System.Drawing.Size(164, 22)
        Me.lblInvisibleOrderID.TabIndex = 44
        Me.lblInvisibleOrderID.Text = "invisible-order-id"
        Me.lblInvisibleOrderID.Visible = False
        '
        'lblInvisibleCustomerID
        '
        Me.lblInvisibleCustomerID.AutoSize = True
        Me.lblInvisibleCustomerID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvisibleCustomerID.Location = New System.Drawing.Point(531, 287)
        Me.lblInvisibleCustomerID.Name = "lblInvisibleCustomerID"
        Me.lblInvisibleCustomerID.Size = New System.Drawing.Size(199, 22)
        Me.lblInvisibleCustomerID.TabIndex = 43
        Me.lblInvisibleCustomerID.Text = "invisible-customer-id"
        Me.lblInvisibleCustomerID.Visible = False
        '
        'Panel13
        '
        Me.Panel13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel13.BackColor = System.Drawing.Color.MintCream
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Controls.Add(Me.txtMiddleIni)
        Me.Panel13.Controls.Add(Me.Label119)
        Me.Panel13.Controls.Add(Me.cbCustomerSex)
        Me.Panel13.Controls.Add(Me.Label41)
        Me.Panel13.Controls.Add(Me.cbCity)
        Me.Panel13.Controls.Add(Me.cbProvince)
        Me.Panel13.Controls.Add(Me.lblPostalCode)
        Me.Panel13.Controls.Add(Me.Label9)
        Me.Panel13.Controls.Add(Me.Label32)
        Me.Panel13.Controls.Add(Me.Label33)
        Me.Panel13.Controls.Add(Me.Label35)
        Me.Panel13.Controls.Add(Me.txtFirstName)
        Me.Panel13.Controls.Add(Me.Label60)
        Me.Panel13.Controls.Add(Me.txtLastName)
        Me.Panel13.Controls.Add(Me.Label75)
        Me.Panel13.Controls.Add(Me.txtContactNum)
        Me.Panel13.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(32, 44)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(746, 241)
        Me.Panel13.TabIndex = 32
        '
        'txtMiddleIni
        '
        Me.txtMiddleIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMiddleIni.BackColor = System.Drawing.SystemColors.Info
        Me.txtMiddleIni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMiddleIni.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleIni.Location = New System.Drawing.Point(176, 69)
        Me.txtMiddleIni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMiddleIni.Name = "txtMiddleIni"
        Me.txtMiddleIni.Size = New System.Drawing.Size(442, 28)
        Me.txtMiddleIni.TabIndex = 33
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(26, 74)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(112, 20)
        Me.Label119.TabIndex = 32
        Me.Label119.Text = "Middle Ini:"
        '
        'cbCustomerSex
        '
        Me.cbCustomerSex.FormattingEnabled = True
        Me.cbCustomerSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbCustomerSex.Location = New System.Drawing.Point(176, 134)
        Me.cbCustomerSex.Name = "cbCustomerSex"
        Me.cbCustomerSex.Size = New System.Drawing.Size(173, 28)
        Me.cbCustomerSex.TabIndex = 31
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(88, 146)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(50, 20)
        Me.Label41.TabIndex = 30
        Me.Label41.Text = "Sex:"
        '
        'cbCity
        '
        Me.cbCity.FormattingEnabled = True
        Me.cbCity.Items.AddRange(New Object() {"Basud", "Capalonga", "Daet", "Jose Panganiban", "Labo", "Mercedes", "Paracale", "San Lorenzo Ruiz", "San Vicente", "Santa Elena", "Talisay", "Vinzons"})
        Me.cbCity.Location = New System.Drawing.Point(176, 201)
        Me.cbCity.Name = "cbCity"
        Me.cbCity.Size = New System.Drawing.Size(173, 28)
        Me.cbCity.TabIndex = 29
        '
        'cbProvince
        '
        Me.cbProvince.FormattingEnabled = True
        Me.cbProvince.Items.AddRange(New Object() {"Camarines Norte"})
        Me.cbProvince.Location = New System.Drawing.Point(176, 168)
        Me.cbProvince.Name = "cbProvince"
        Me.cbProvince.Size = New System.Drawing.Size(173, 28)
        Me.cbProvince.TabIndex = 28
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(569, 204)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(108, 20)
        Me.lblPostalCode.TabIndex = 26
        Me.lblPostalCode.Text = "placeholder"
        Me.lblPostalCode.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Postal Code:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(20, 204)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(118, 20)
        Me.Label32.TabIndex = 24
        Me.Label32.Text = "City/Town:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(40, 171)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(98, 20)
        Me.Label33.TabIndex = 23
        Me.Label33.Text = "Province:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(25, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 20)
        Me.Label35.TabIndex = 14
        Me.Label35.Text = "First name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Info
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(176, 9)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(442, 28)
        Me.txtFirstName.TabIndex = 15
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(28, 41)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(114, 20)
        Me.Label60.TabIndex = 16
        Me.Label60.Text = "Last name:"
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Info
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(176, 39)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(442, 28)
        Me.txtLastName.TabIndex = 17
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(49, 109)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(89, 20)
        Me.Label75.TabIndex = 20
        Me.Label75.Text = "Contact:"
        '
        'txtContactNum
        '
        Me.txtContactNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContactNum.BackColor = System.Drawing.SystemColors.Info
        Me.txtContactNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactNum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNum.Location = New System.Drawing.Point(176, 101)
        Me.txtContactNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtContactNum.Name = "txtContactNum"
        Me.txtContactNum.Size = New System.Drawing.Size(442, 28)
        Me.txtContactNum.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 652)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Payment Information"
        '
        'Panel12
        '
        Me.Panel12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel12.BackColor = System.Drawing.Color.MintCream
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Controls.Add(Me.txtRemarks)
        Me.Panel12.Controls.Add(Me.Label123)
        Me.Panel12.Controls.Add(Me.lblDateAdded)
        Me.Panel12.Controls.Add(Me.Label3)
        Me.Panel12.Controls.Add(Me.Label4)
        Me.Panel12.Controls.Add(Me.cbPaymentMethod)
        Me.Panel12.Controls.Add(Me.Label2)
        Me.Panel12.Controls.Add(Me.txtAmountPaid)
        Me.Panel12.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(32, 689)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(746, 136)
        Me.Panel12.TabIndex = 31
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.BackColor = System.Drawing.SystemColors.Info
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(202, 96)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(497, 28)
        Me.txtRemarks.TabIndex = 35
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(20, 96)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(92, 20)
        Me.Label123.TabIndex = 34
        Me.Label123.Text = "Remarks:"
        '
        'lblDateAdded
        '
        Me.lblDateAdded.AutoSize = True
        Me.lblDateAdded.Location = New System.Drawing.Point(482, 55)
        Me.lblDateAdded.Name = "lblDateAdded"
        Me.lblDateAdded.Size = New System.Drawing.Size(108, 20)
        Me.lblDateAdded.TabIndex = 30
        Me.lblDateAdded.Text = "placeholder"
        Me.lblDateAdded.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Payment method:"
        '
        'cbPaymentMethod
        '
        Me.cbPaymentMethod.FormattingEnabled = True
        Me.cbPaymentMethod.Items.AddRange(New Object() {"Cash", "Gcash", "Paymaya"})
        Me.cbPaymentMethod.Location = New System.Drawing.Point(202, 55)
        Me.cbPaymentMethod.Name = "cbPaymentMethod"
        Me.cbPaymentMethod.Size = New System.Drawing.Size(173, 28)
        Me.cbPaymentMethod.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Payment received:"
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmountPaid.BackColor = System.Drawing.SystemColors.Info
        Me.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountPaid.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(202, 9)
        Me.txtAmountPaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(497, 28)
        Me.txtAmountPaid.TabIndex = 31
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelOrder.BackColor = System.Drawing.Color.Red
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelOrder.FlatAppearance.BorderSize = 0
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelOrder.ForeColor = System.Drawing.Color.MintCream
        Me.btnCancelOrder.Location = New System.Drawing.Point(512, 829)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(121, 45)
        Me.btnCancelOrder.TabIndex = 27
        Me.btnCancelOrder.Text = "Cancel"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel10.BackColor = System.Drawing.Color.MintCream
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.lblTotal)
        Me.Panel10.Controls.Add(Me.Label40)
        Me.Panel10.Location = New System.Drawing.Point(32, 601)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(746, 49)
        Me.Panel10.TabIndex = 26
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(634, 12)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 22)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "xxxxx"
        Me.lblTotal.Visible = False
        '
        'Label40
        '
        Me.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(33, 12)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(67, 22)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "Total:"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblIscolored)
        Me.Panel5.Controls.Add(Me.Label168)
        Me.Panel5.Controls.Add(Me.lblServiceCategory)
        Me.Panel5.Controls.Add(Me.lblInvisibleTransactionID)
        Me.Panel5.Controls.Add(Me.lblServiceFee)
        Me.Panel5.Controls.Add(Me.Label73)
        Me.Panel5.Controls.Add(Me.Label72)
        Me.Panel5.Controls.Add(Me.lblAddon4Total)
        Me.Panel5.Controls.Add(Me.lblAddon3Total)
        Me.Panel5.Controls.Add(Me.lblAddon2Total)
        Me.Panel5.Controls.Add(Me.lblAddon1Total)
        Me.Panel5.Controls.Add(Me.lblLoadWeight)
        Me.Panel5.Controls.Add(Me.Label37)
        Me.Panel5.Controls.Add(Me.lblAddon4Fee)
        Me.Panel5.Controls.Add(Me.lblAddon3Fee)
        Me.Panel5.Controls.Add(Me.lblAddon2Fee)
        Me.Panel5.Controls.Add(Me.lblAddon1Fee)
        Me.Panel5.Controls.Add(Me.lblAddon4)
        Me.Panel5.Controls.Add(Me.lblAddon3)
        Me.Panel5.Controls.Add(Me.lblAddon2)
        Me.Panel5.Controls.Add(Me.lblAddon1)
        Me.Panel5.Controls.Add(Me.Label38)
        Me.Panel5.Controls.Add(Me.lblServiceAvailed)
        Me.Panel5.Controls.Add(Me.Label39)
        Me.Panel5.Location = New System.Drawing.Point(32, 314)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(746, 283)
        Me.Panel5.TabIndex = 25
        '
        'lblIscolored
        '
        Me.lblIscolored.AutoSize = True
        Me.lblIscolored.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIscolored.Location = New System.Drawing.Point(107, 253)
        Me.lblIscolored.Name = "lblIscolored"
        Me.lblIscolored.Size = New System.Drawing.Size(73, 18)
        Me.lblIscolored.TabIndex = 45
        Me.lblIscolored.Text = "Colored:"
        '
        'Label168
        '
        Me.Label168.AutoSize = True
        Me.Label168.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label168.Location = New System.Drawing.Point(25, 253)
        Me.Label168.Name = "Label168"
        Me.Label168.Size = New System.Drawing.Size(76, 18)
        Me.Label168.TabIndex = 44
        Me.Label168.Text = "Colored:"
        '
        'lblServiceCategory
        '
        Me.lblServiceCategory.AutoSize = True
        Me.lblServiceCategory.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceCategory.Location = New System.Drawing.Point(56, 77)
        Me.lblServiceCategory.Name = "lblServiceCategory"
        Me.lblServiceCategory.Size = New System.Drawing.Size(65, 22)
        Me.lblServiceCategory.TabIndex = 43
        Me.lblServiceCategory.Text = "xxxxx"
        Me.lblServiceCategory.Visible = False
        '
        'lblInvisibleTransactionID
        '
        Me.lblInvisibleTransactionID.AutoSize = True
        Me.lblInvisibleTransactionID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvisibleTransactionID.Location = New System.Drawing.Point(20, -1)
        Me.lblInvisibleTransactionID.Name = "lblInvisibleTransactionID"
        Me.lblInvisibleTransactionID.Size = New System.Drawing.Size(215, 22)
        Me.lblInvisibleTransactionID.TabIndex = 42
        Me.lblInvisibleTransactionID.Text = "invisible-transaction-id"
        Me.lblInvisibleTransactionID.Visible = False
        '
        'lblServiceFee
        '
        Me.lblServiceFee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServiceFee.AutoSize = True
        Me.lblServiceFee.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFee.Location = New System.Drawing.Point(634, 81)
        Me.lblServiceFee.Name = "lblServiceFee"
        Me.lblServiceFee.Size = New System.Drawing.Size(65, 22)
        Me.lblServiceFee.TabIndex = 41
        Me.lblServiceFee.Text = "xxxxx"
        Me.lblServiceFee.Visible = False
        '
        'Label73
        '
        Me.Label73.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(588, 16)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(143, 22)
        Me.Label73.TabIndex = 40
        Me.Label73.Text = "Total amount"
        '
        'Label72
        '
        Me.Label72.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(493, 16)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(61, 22)
        Me.Label72.TabIndex = 39
        Me.Label72.Text = "Price"
        '
        'lblAddon4Total
        '
        Me.lblAddon4Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon4Total.AutoSize = True
        Me.lblAddon4Total.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon4Total.Location = New System.Drawing.Point(634, 200)
        Me.lblAddon4Total.Name = "lblAddon4Total"
        Me.lblAddon4Total.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon4Total.TabIndex = 38
        Me.lblAddon4Total.Text = "xxxxx"
        Me.lblAddon4Total.Visible = False
        '
        'lblAddon3Total
        '
        Me.lblAddon3Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon3Total.AutoSize = True
        Me.lblAddon3Total.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon3Total.Location = New System.Drawing.Point(634, 178)
        Me.lblAddon3Total.Name = "lblAddon3Total"
        Me.lblAddon3Total.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon3Total.TabIndex = 37
        Me.lblAddon3Total.Text = "xxxxx"
        Me.lblAddon3Total.Visible = False
        '
        'lblAddon2Total
        '
        Me.lblAddon2Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon2Total.AutoSize = True
        Me.lblAddon2Total.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon2Total.Location = New System.Drawing.Point(634, 156)
        Me.lblAddon2Total.Name = "lblAddon2Total"
        Me.lblAddon2Total.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon2Total.TabIndex = 36
        Me.lblAddon2Total.Text = "xxxxx"
        Me.lblAddon2Total.Visible = False
        '
        'lblAddon1Total
        '
        Me.lblAddon1Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon1Total.AutoSize = True
        Me.lblAddon1Total.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon1Total.Location = New System.Drawing.Point(634, 134)
        Me.lblAddon1Total.Name = "lblAddon1Total"
        Me.lblAddon1Total.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon1Total.TabIndex = 35
        Me.lblAddon1Total.Text = "xxxxx"
        Me.lblAddon1Total.Visible = False
        '
        'lblLoadWeight
        '
        Me.lblLoadWeight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoadWeight.AutoSize = True
        Me.lblLoadWeight.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadWeight.Location = New System.Drawing.Point(634, 231)
        Me.lblLoadWeight.Name = "lblLoadWeight"
        Me.lblLoadWeight.Size = New System.Drawing.Size(65, 22)
        Me.lblLoadWeight.TabIndex = 31
        Me.lblLoadWeight.Text = "xxxxx"
        Me.lblLoadWeight.Visible = False
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(20, 231)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(134, 22)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "Load weight"
        '
        'lblAddon4Fee
        '
        Me.lblAddon4Fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon4Fee.AutoSize = True
        Me.lblAddon4Fee.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon4Fee.Location = New System.Drawing.Point(493, 200)
        Me.lblAddon4Fee.Name = "lblAddon4Fee"
        Me.lblAddon4Fee.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon4Fee.TabIndex = 29
        Me.lblAddon4Fee.Text = "xxxxx"
        Me.lblAddon4Fee.Visible = False
        '
        'lblAddon3Fee
        '
        Me.lblAddon3Fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon3Fee.AutoSize = True
        Me.lblAddon3Fee.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon3Fee.Location = New System.Drawing.Point(493, 178)
        Me.lblAddon3Fee.Name = "lblAddon3Fee"
        Me.lblAddon3Fee.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon3Fee.TabIndex = 28
        Me.lblAddon3Fee.Text = "xxxxx"
        Me.lblAddon3Fee.Visible = False
        '
        'lblAddon2Fee
        '
        Me.lblAddon2Fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon2Fee.AutoSize = True
        Me.lblAddon2Fee.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon2Fee.Location = New System.Drawing.Point(493, 156)
        Me.lblAddon2Fee.Name = "lblAddon2Fee"
        Me.lblAddon2Fee.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon2Fee.TabIndex = 27
        Me.lblAddon2Fee.Text = "xxxxx"
        Me.lblAddon2Fee.Visible = False
        '
        'lblAddon1Fee
        '
        Me.lblAddon1Fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddon1Fee.AutoSize = True
        Me.lblAddon1Fee.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon1Fee.Location = New System.Drawing.Point(493, 134)
        Me.lblAddon1Fee.Name = "lblAddon1Fee"
        Me.lblAddon1Fee.Size = New System.Drawing.Size(65, 22)
        Me.lblAddon1Fee.TabIndex = 26
        Me.lblAddon1Fee.Text = "xxxxx"
        Me.lblAddon1Fee.Visible = False
        '
        'lblAddon4
        '
        Me.lblAddon4.AutoSize = True
        Me.lblAddon4.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon4.Location = New System.Drawing.Point(56, 200)
        Me.lblAddon4.Name = "lblAddon4"
        Me.lblAddon4.Size = New System.Drawing.Size(0, 22)
        Me.lblAddon4.TabIndex = 25
        Me.lblAddon4.Visible = False
        '
        'lblAddon3
        '
        Me.lblAddon3.AutoSize = True
        Me.lblAddon3.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon3.Location = New System.Drawing.Point(56, 178)
        Me.lblAddon3.Name = "lblAddon3"
        Me.lblAddon3.Size = New System.Drawing.Size(0, 22)
        Me.lblAddon3.TabIndex = 24
        Me.lblAddon3.Visible = False
        '
        'lblAddon2
        '
        Me.lblAddon2.AutoSize = True
        Me.lblAddon2.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon2.Location = New System.Drawing.Point(56, 156)
        Me.lblAddon2.Name = "lblAddon2"
        Me.lblAddon2.Size = New System.Drawing.Size(0, 22)
        Me.lblAddon2.TabIndex = 23
        Me.lblAddon2.Visible = False
        '
        'lblAddon1
        '
        Me.lblAddon1.AutoSize = True
        Me.lblAddon1.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddon1.Location = New System.Drawing.Point(56, 134)
        Me.lblAddon1.Name = "lblAddon1"
        Me.lblAddon1.Size = New System.Drawing.Size(0, 22)
        Me.lblAddon1.TabIndex = 22
        Me.lblAddon1.Visible = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(25, 109)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(95, 22)
        Me.Label38.TabIndex = 21
        Me.Label38.Text = "Add-ons"
        '
        'lblServiceAvailed
        '
        Me.lblServiceAvailed.AutoSize = True
        Me.lblServiceAvailed.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceAvailed.Location = New System.Drawing.Point(238, 77)
        Me.lblServiceAvailed.Name = "lblServiceAvailed"
        Me.lblServiceAvailed.Size = New System.Drawing.Size(65, 22)
        Me.lblServiceAvailed.TabIndex = 19
        Me.lblServiceAvailed.Text = "xxxxx"
        Me.lblServiceAvailed.Visible = False
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(28, 48)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(85, 22)
        Me.Label39.TabIndex = 18
        Me.Label39.Text = "Service"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Order Summary"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(13, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(261, 25)
        Me.Label34.TabIndex = 22
        Me.Label34.Text = "Customer Information"
        '
        'btnComplete
        '
        Me.btnComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnComplete.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnComplete.FlatAppearance.BorderSize = 0
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnComplete.ForeColor = System.Drawing.Color.MintCream
        Me.btnComplete.Location = New System.Drawing.Point(639, 829)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(121, 45)
        Me.btnComplete.TabIndex = 23
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnNextAd)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.panLayer3)
        Me.Panel2.Controls.Add(Me.panLayer2)
        Me.Panel2.Controls.Add(Me.panLayer1)
        Me.Panel2.Controls.Add(Me.btnNext)
        Me.Panel2.Location = New System.Drawing.Point(6, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 642)
        Me.Panel2.TabIndex = 24
        '
        'btnNextAd
        '
        Me.btnNextAd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNextAd.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNextAd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextAd.FlatAppearance.BorderSize = 0
        Me.btnNextAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNextAd.ForeColor = System.Drawing.Color.MintCream
        Me.btnNextAd.Location = New System.Drawing.Point(633, 585)
        Me.btnNextAd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNextAd.Name = "btnNextAd"
        Me.btnNextAd.Size = New System.Drawing.Size(129, 47)
        Me.btnNextAd.TabIndex = 27
        Me.btnNextAd.Text = "Next"
        Me.btnNextAd.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(14, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(228, 31)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Add order page"
        '
        'panLayer3
        '
        Me.panLayer3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panLayer3.BackColor = System.Drawing.Color.MintCream
        Me.panLayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panLayer3.Controls.Add(Me.numLoadWeight)
        Me.panLayer3.Controls.Add(Me.Label11)
        Me.panLayer3.Controls.Add(Me.Label12)
        Me.panLayer3.Location = New System.Drawing.Point(14, 516)
        Me.panLayer3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panLayer3.Name = "panLayer3"
        Me.panLayer3.Size = New System.Drawing.Size(748, 62)
        Me.panLayer3.TabIndex = 26
        '
        'numLoadWeight
        '
        Me.numLoadWeight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numLoadWeight.Location = New System.Drawing.Point(175, 15)
        Me.numLoadWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numLoadWeight.Name = "numLoadWeight"
        Me.numLoadWeight.ReadOnly = True
        Me.numLoadWeight.Size = New System.Drawing.Size(110, 28)
        Me.numLoadWeight.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Load weight:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(302, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "kg"
        '
        'panLayer2
        '
        Me.panLayer2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panLayer2.BackColor = System.Drawing.Color.MintCream
        Me.panLayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panLayer2.Controls.Add(Me.numAddon4)
        Me.panLayer2.Controls.Add(Me.numAddon3)
        Me.panLayer2.Controls.Add(Me.numAddon2)
        Me.panLayer2.Controls.Add(Me.numAddon1)
        Me.panLayer2.Controls.Add(Me.cbNone)
        Me.panLayer2.Controls.Add(Me.cbAddon4)
        Me.panLayer2.Controls.Add(Me.Label10)
        Me.panLayer2.Controls.Add(Me.cbAddon3)
        Me.panLayer2.Controls.Add(Me.cbAddon2)
        Me.panLayer2.Controls.Add(Me.cbAddon1)
        Me.panLayer2.Location = New System.Drawing.Point(14, 270)
        Me.panLayer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panLayer2.Name = "panLayer2"
        Me.panLayer2.Size = New System.Drawing.Size(748, 235)
        Me.panLayer2.TabIndex = 24
        '
        'numAddon4
        '
        Me.numAddon4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numAddon4.Location = New System.Drawing.Point(295, 158)
        Me.numAddon4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numAddon4.Name = "numAddon4"
        Me.numAddon4.ReadOnly = True
        Me.numAddon4.Size = New System.Drawing.Size(79, 28)
        Me.numAddon4.TabIndex = 38
        '
        'numAddon3
        '
        Me.numAddon3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numAddon3.Location = New System.Drawing.Point(295, 126)
        Me.numAddon3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numAddon3.Name = "numAddon3"
        Me.numAddon3.ReadOnly = True
        Me.numAddon3.Size = New System.Drawing.Size(79, 28)
        Me.numAddon3.TabIndex = 37
        '
        'numAddon2
        '
        Me.numAddon2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numAddon2.Location = New System.Drawing.Point(295, 90)
        Me.numAddon2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numAddon2.Name = "numAddon2"
        Me.numAddon2.ReadOnly = True
        Me.numAddon2.Size = New System.Drawing.Size(79, 28)
        Me.numAddon2.TabIndex = 36
        '
        'numAddon1
        '
        Me.numAddon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.numAddon1.Location = New System.Drawing.Point(295, 55)
        Me.numAddon1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numAddon1.Name = "numAddon1"
        Me.numAddon1.ReadOnly = True
        Me.numAddon1.Size = New System.Drawing.Size(79, 28)
        Me.numAddon1.TabIndex = 35
        '
        'cbNone
        '
        Me.cbNone.AutoSize = True
        Me.cbNone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbNone.Location = New System.Drawing.Point(15, 190)
        Me.cbNone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbNone.Name = "cbNone"
        Me.cbNone.Size = New System.Drawing.Size(75, 24)
        Me.cbNone.TabIndex = 31
        Me.cbNone.Text = "None"
        Me.cbNone.UseVisualStyleBackColor = True
        '
        'cbAddon4
        '
        Me.cbAddon4.AutoSize = True
        Me.cbAddon4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbAddon4.Location = New System.Drawing.Point(16, 154)
        Me.cbAddon4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbAddon4.Name = "cbAddon4"
        Me.cbAddon4.Size = New System.Drawing.Size(253, 24)
        Me.cbAddon4.TabIndex = 30
        Me.cbAddon4.Text = "Fabric Conditioner (40ml)"
        Me.cbAddon4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Add-ons"
        '
        'cbAddon3
        '
        Me.cbAddon3.AutoSize = True
        Me.cbAddon3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbAddon3.Location = New System.Drawing.Point(16, 122)
        Me.cbAddon3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbAddon3.Name = "cbAddon3"
        Me.cbAddon3.Size = New System.Drawing.Size(269, 24)
        Me.cbAddon3.TabIndex = 29
        Me.cbAddon3.Text = "Colored Safe Bleach (20ml)"
        Me.cbAddon3.UseVisualStyleBackColor = True
        '
        'cbAddon2
        '
        Me.cbAddon2.AutoSize = True
        Me.cbAddon2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbAddon2.Location = New System.Drawing.Point(16, 91)
        Me.cbAddon2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbAddon2.Name = "cbAddon2"
        Me.cbAddon2.Size = New System.Drawing.Size(226, 24)
        Me.cbAddon2.TabIndex = 28
        Me.cbAddon2.Text = "Regular Bleach (20ml)"
        Me.cbAddon2.UseVisualStyleBackColor = True
        '
        'cbAddon1
        '
        Me.cbAddon1.AutoSize = True
        Me.cbAddon1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbAddon1.Location = New System.Drawing.Point(16, 61)
        Me.cbAddon1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbAddon1.Name = "cbAddon1"
        Me.cbAddon1.Size = New System.Drawing.Size(240, 24)
        Me.cbAddon1.TabIndex = 27
        Me.cbAddon1.Text = "Ariel/Breeze/Tide(60ml)"
        Me.cbAddon1.UseVisualStyleBackColor = True
        '
        'panLayer1
        '
        Me.panLayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panLayer1.BackColor = System.Drawing.Color.MintCream
        Me.panLayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panLayer1.Controls.Add(Me.cbColored)
        Me.panLayer1.Controls.Add(Me.Label167)
        Me.panLayer1.Controls.Add(Me.panSelfService)
        Me.panLayer1.Controls.Add(Me.rbFullService)
        Me.panLayer1.Controls.Add(Me.Label8)
        Me.panLayer1.Controls.Add(Me.rbSelfService)
        Me.panLayer1.Controls.Add(Me.panFullService)
        Me.panLayer1.Location = New System.Drawing.Point(14, 55)
        Me.panLayer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panLayer1.Name = "panLayer1"
        Me.panLayer1.Size = New System.Drawing.Size(748, 211)
        Me.panLayer1.TabIndex = 24
        '
        'cbColored
        '
        Me.cbColored.FormattingEnabled = True
        Me.cbColored.Items.AddRange(New Object() {"True", "False"})
        Me.cbColored.Location = New System.Drawing.Point(123, 161)
        Me.cbColored.Name = "cbColored"
        Me.cbColored.Size = New System.Drawing.Size(121, 28)
        Me.cbColored.TabIndex = 15
        '
        'Label167
        '
        Me.Label167.AutoSize = True
        Me.Label167.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label167.Location = New System.Drawing.Point(10, 161)
        Me.Label167.Name = "Label167"
        Me.Label167.Size = New System.Drawing.Size(106, 25)
        Me.Label167.TabIndex = 14
        Me.Label167.Text = "Colored:"
        '
        'panSelfService
        '
        Me.panSelfService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panSelfService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panSelfService.Controls.Add(Me.cbDry)
        Me.panSelfService.Controls.Add(Me.cbWash)
        Me.panSelfService.Location = New System.Drawing.Point(350, 55)
        Me.panSelfService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panSelfService.Name = "panSelfService"
        Me.panSelfService.Size = New System.Drawing.Size(193, 93)
        Me.panSelfService.TabIndex = 13
        Me.panSelfService.Visible = False
        '
        'cbDry
        '
        Me.cbDry.AutoSize = True
        Me.cbDry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbDry.Location = New System.Drawing.Point(16, 36)
        Me.cbDry.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDry.Name = "cbDry"
        Me.cbDry.Size = New System.Drawing.Size(67, 24)
        Me.cbDry.TabIndex = 26
        Me.cbDry.Text = "Dry "
        Me.cbDry.UseVisualStyleBackColor = True
        '
        'cbWash
        '
        Me.cbWash.AutoSize = True
        Me.cbWash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbWash.Location = New System.Drawing.Point(16, 8)
        Me.cbWash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbWash.Name = "cbWash"
        Me.cbWash.Size = New System.Drawing.Size(83, 24)
        Me.cbWash.TabIndex = 25
        Me.cbWash.Text = "Wash "
        Me.cbWash.UseVisualStyleBackColor = True
        '
        'rbFullService
        '
        Me.rbFullService.AutoSize = True
        Me.rbFullService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbFullService.Location = New System.Drawing.Point(56, 27)
        Me.rbFullService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbFullService.Name = "rbFullService"
        Me.rbFullService.Size = New System.Drawing.Size(130, 24)
        Me.rbFullService.TabIndex = 9
        Me.rbFullService.TabStop = True
        Me.rbFullService.Text = "Full Service"
        Me.rbFullService.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Services"
        '
        'rbSelfService
        '
        Me.rbSelfService.AutoSize = True
        Me.rbSelfService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSelfService.Location = New System.Drawing.Point(350, 27)
        Me.rbSelfService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbSelfService.Name = "rbSelfService"
        Me.rbSelfService.Size = New System.Drawing.Size(132, 24)
        Me.rbSelfService.TabIndex = 10
        Me.rbSelfService.TabStop = True
        Me.rbSelfService.Text = "Self Service"
        Me.rbSelfService.UseVisualStyleBackColor = True
        '
        'panFullService
        '
        Me.panFullService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panFullService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panFullService.Controls.Add(Me.rbComforters)
        Me.panFullService.Controls.Add(Me.rbWDF)
        Me.panFullService.Location = New System.Drawing.Point(56, 55)
        Me.panFullService.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panFullService.Name = "panFullService"
        Me.panFullService.Size = New System.Drawing.Size(245, 93)
        Me.panFullService.TabIndex = 12
        Me.panFullService.Visible = False
        '
        'rbComforters
        '
        Me.rbComforters.AutoSize = True
        Me.rbComforters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbComforters.Location = New System.Drawing.Point(3, 38)
        Me.rbComforters.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbComforters.Name = "rbComforters"
        Me.rbComforters.Size = New System.Drawing.Size(131, 24)
        Me.rbComforters.TabIndex = 11
        Me.rbComforters.TabStop = True
        Me.rbComforters.Text = "Comforters "
        Me.rbComforters.UseVisualStyleBackColor = True
        '
        'rbWDF
        '
        Me.rbWDF.AutoSize = True
        Me.rbWDF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbWDF.Location = New System.Drawing.Point(4, 10)
        Me.rbWDF.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbWDF.Name = "rbWDF"
        Me.rbWDF.Size = New System.Drawing.Size(170, 24)
        Me.rbWDF.TabIndex = 10
        Me.rbWDF.TabStop = True
        Me.rbWDF.Text = "Wash, Dry, Fold "
        Me.rbWDF.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNext.ForeColor = System.Drawing.Color.MintCream
        Me.btnNext.Location = New System.Drawing.Point(1135, 1094)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(122, 30)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'Pending
        '
        Me.Pending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pending.Controls.Add(Me.Button1)
        Me.Pending.Controls.Add(Me.panPendingOrdersss)
        Me.Pending.Controls.Add(Me.dgvPending)
        Me.Pending.Controls.Add(Me.btnRefresh)
        Me.Pending.Controls.Add(Me.txtSearchPending)
        Me.Pending.Controls.Add(Me.Label7)
        Me.Pending.Controls.Add(Me.Button2)
        Me.Pending.Controls.Add(Me.Label16)
        Me.Pending.Location = New System.Drawing.Point(4, 32)
        Me.Pending.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pending.Name = "Pending"
        Me.Pending.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pending.Size = New System.Drawing.Size(1606, 897)
        Me.Pending.TabIndex = 1
        Me.Pending.Text = "Pending"
        Me.Pending.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MintCream
        Me.Button1.Location = New System.Drawing.Point(1466, 815)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 48)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Clear Fields"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'panPendingOrdersss
        '
        Me.panPendingOrdersss.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panPendingOrdersss.BackColor = System.Drawing.SystemColors.Info
        Me.panPendingOrdersss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panPendingOrdersss.Controls.Add(Me.btnDeleteTransac)
        Me.panPendingOrdersss.Controls.Add(Me.lblProcessedBy)
        Me.panPendingOrdersss.Controls.Add(Me.Label19)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingTransacDateAdded)
        Me.panPendingOrdersss.Controls.Add(Me.Label44)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingChange)
        Me.panPendingOrdersss.Controls.Add(Me.Label45)
        Me.panPendingOrdersss.Controls.Add(Me.lblPaymentReceived)
        Me.panPendingOrdersss.Controls.Add(Me.Label46)
        Me.panPendingOrdersss.Controls.Add(Me.btnFinish)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingTotal)
        Me.panPendingOrdersss.Controls.Add(Me.btnCancel)
        Me.panPendingOrdersss.Controls.Add(Me.Label47)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingAddon4)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingAddon3)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingAddon2)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingAddon1)
        Me.panPendingOrdersss.Controls.Add(Me.Label76)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingOrderID)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingService)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingContact)
        Me.panPendingOrdersss.Controls.Add(Me.lblPendingFullName)
        Me.panPendingOrdersss.Controls.Add(Me.Label80)
        Me.panPendingOrdersss.Controls.Add(Me.Label88)
        Me.panPendingOrdersss.Controls.Add(Me.Label89)
        Me.panPendingOrdersss.Controls.Add(Me.Label90)
        Me.panPendingOrdersss.Location = New System.Drawing.Point(1111, 97)
        Me.panPendingOrdersss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panPendingOrdersss.Name = "panPendingOrdersss"
        Me.panPendingOrdersss.Size = New System.Drawing.Size(477, 714)
        Me.panPendingOrdersss.TabIndex = 17
        '
        'lblProcessedBy
        '
        Me.lblProcessedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProcessedBy.AutoSize = True
        Me.lblProcessedBy.Location = New System.Drawing.Point(294, 490)
        Me.lblProcessedBy.Name = "lblProcessedBy"
        Me.lblProcessedBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblProcessedBy.Size = New System.Drawing.Size(59, 20)
        Me.lblProcessedBy.TabIndex = 26
        Me.lblProcessedBy.Text = "xxxxx"
        Me.lblProcessedBy.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 488)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 22)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Processed by:"
        '
        'lblPendingTransacDateAdded
        '
        Me.lblPendingTransacDateAdded.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingTransacDateAdded.AutoSize = True
        Me.lblPendingTransacDateAdded.Location = New System.Drawing.Point(140, 573)
        Me.lblPendingTransacDateAdded.Name = "lblPendingTransacDateAdded"
        Me.lblPendingTransacDateAdded.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPendingTransacDateAdded.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingTransacDateAdded.TabIndex = 24
        Me.lblPendingTransacDateAdded.Text = "xxxxx"
        Me.lblPendingTransacDateAdded.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(14, 526)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(174, 22)
        Me.Label44.TabIndex = 23
        Me.Label44.Text = "Date Processed:"
        '
        'lblPendingChange
        '
        Me.lblPendingChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingChange.AutoSize = True
        Me.lblPendingChange.Location = New System.Drawing.Point(290, 423)
        Me.lblPendingChange.Name = "lblPendingChange"
        Me.lblPendingChange.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingChange.TabIndex = 22
        Me.lblPendingChange.Text = "xxxxx"
        Me.lblPendingChange.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(15, 421)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(93, 22)
        Me.Label45.TabIndex = 21
        Me.Label45.Text = "Change:"
        '
        'lblPaymentReceived
        '
        Me.lblPaymentReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPaymentReceived.AutoSize = True
        Me.lblPaymentReceived.Location = New System.Drawing.Point(290, 350)
        Me.lblPaymentReceived.Name = "lblPaymentReceived"
        Me.lblPaymentReceived.Size = New System.Drawing.Size(59, 20)
        Me.lblPaymentReceived.TabIndex = 20
        Me.lblPaymentReceived.Text = "xxxxx"
        Me.lblPaymentReceived.Visible = False
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(14, 348)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(199, 22)
        Me.Label46.TabIndex = 19
        Me.Label46.Text = "Payment received:"
        '
        'btnFinish
        '
        Me.btnFinish.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinish.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFinish.FlatAppearance.BorderSize = 0
        Me.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinish.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.ForeColor = System.Drawing.Color.MintCream
        Me.btnFinish.Location = New System.Drawing.Point(334, 616)
        Me.btnFinish.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(122, 48)
        Me.btnFinish.TabIndex = 8
        Me.btnFinish.Text = "Finish order"
        Me.btnFinish.UseVisualStyleBackColor = False
        '
        'lblPendingTotal
        '
        Me.lblPendingTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingTotal.AutoSize = True
        Me.lblPendingTotal.Location = New System.Drawing.Point(290, 387)
        Me.lblPendingTotal.Name = "lblPendingTotal"
        Me.lblPendingTotal.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingTotal.TabIndex = 18
        Me.lblPendingTotal.Text = "xxxxx"
        Me.lblPendingTotal.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.Red
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.MintCream
        Me.btnCancel.Location = New System.Drawing.Point(196, 616)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(132, 48)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel order"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(14, 385)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(200, 22)
        Me.Label47.TabIndex = 17
        Me.Label47.Text = "Total amount paid:"
        '
        'lblPendingAddon4
        '
        Me.lblPendingAddon4.AutoSize = True
        Me.lblPendingAddon4.Location = New System.Drawing.Point(290, 290)
        Me.lblPendingAddon4.Name = "lblPendingAddon4"
        Me.lblPendingAddon4.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingAddon4.TabIndex = 12
        Me.lblPendingAddon4.Text = "xxxxx"
        Me.lblPendingAddon4.Visible = False
        '
        'lblPendingAddon3
        '
        Me.lblPendingAddon3.AutoSize = True
        Me.lblPendingAddon3.Location = New System.Drawing.Point(290, 268)
        Me.lblPendingAddon3.Name = "lblPendingAddon3"
        Me.lblPendingAddon3.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingAddon3.TabIndex = 11
        Me.lblPendingAddon3.Text = "xxxxx"
        Me.lblPendingAddon3.Visible = False
        '
        'lblPendingAddon2
        '
        Me.lblPendingAddon2.AutoSize = True
        Me.lblPendingAddon2.Location = New System.Drawing.Point(290, 246)
        Me.lblPendingAddon2.Name = "lblPendingAddon2"
        Me.lblPendingAddon2.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingAddon2.TabIndex = 10
        Me.lblPendingAddon2.Text = "xxxxx"
        Me.lblPendingAddon2.Visible = False
        '
        'lblPendingAddon1
        '
        Me.lblPendingAddon1.AutoSize = True
        Me.lblPendingAddon1.Location = New System.Drawing.Point(290, 221)
        Me.lblPendingAddon1.Name = "lblPendingAddon1"
        Me.lblPendingAddon1.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingAddon1.TabIndex = 9
        Me.lblPendingAddon1.Text = "xxxxx"
        Me.lblPendingAddon1.Visible = False
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(14, 184)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(181, 22)
        Me.Label76.TabIndex = 8
        Me.Label76.Text = "Add-ons availed:"
        '
        'lblPendingOrderID
        '
        Me.lblPendingOrderID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingOrderID.AutoSize = True
        Me.lblPendingOrderID.Location = New System.Drawing.Point(290, 12)
        Me.lblPendingOrderID.Name = "lblPendingOrderID"
        Me.lblPendingOrderID.Size = New System.Drawing.Size(0, 20)
        Me.lblPendingOrderID.TabIndex = 7
        '
        'lblPendingService
        '
        Me.lblPendingService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingService.AutoSize = True
        Me.lblPendingService.Location = New System.Drawing.Point(136, 145)
        Me.lblPendingService.Name = "lblPendingService"
        Me.lblPendingService.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingService.TabIndex = 6
        Me.lblPendingService.Text = "xxxxx"
        Me.lblPendingService.Visible = False
        '
        'lblPendingContact
        '
        Me.lblPendingContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingContact.AutoSize = True
        Me.lblPendingContact.Location = New System.Drawing.Point(290, 75)
        Me.lblPendingContact.Name = "lblPendingContact"
        Me.lblPendingContact.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingContact.TabIndex = 5
        Me.lblPendingContact.Text = "xxxxx"
        Me.lblPendingContact.Visible = False
        '
        'lblPendingFullName
        '
        Me.lblPendingFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPendingFullName.AutoSize = True
        Me.lblPendingFullName.Location = New System.Drawing.Point(290, 50)
        Me.lblPendingFullName.Name = "lblPendingFullName"
        Me.lblPendingFullName.Size = New System.Drawing.Size(59, 20)
        Me.lblPendingFullName.TabIndex = 4
        Me.lblPendingFullName.Text = "xxxxx"
        Me.lblPendingFullName.Visible = False
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(14, 12)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(173, 22)
        Me.Label80.TabIndex = 3
        Me.Label80.Text = "Transaction ID: "
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(14, 101)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(171, 22)
        Me.Label88.TabIndex = 2
        Me.Label88.Text = "Service availed:"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(14, 75)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(134, 22)
        Me.Label89.TabIndex = 1
        Me.Label89.Text = "Contact No.:"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(14, 53)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(118, 22)
        Me.Label90.TabIndex = 0
        Me.Label90.Text = "Full Name:"
        '
        'dgvPending
        '
        Me.dgvPending.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPending.Location = New System.Drawing.Point(50, 97)
        Me.dgvPending.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPending.Name = "dgvPending"
        Me.dgvPending.RowHeadersWidth = 51
        Me.dgvPending.Size = New System.Drawing.Size(1055, 714)
        Me.dgvPending.TabIndex = 16
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.ForeColor = System.Drawing.Color.MintCream
        Me.btnRefresh.Location = New System.Drawing.Point(457, 52)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 41)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtSearchPending
        '
        Me.txtSearchPending.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtSearchPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchPending.Location = New System.Drawing.Point(149, 60)
        Me.txtSearchPending.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchPending.Name = "txtSearchPending"
        Me.txtSearchPending.Size = New System.Drawing.Size(302, 28)
        Me.txtSearchPending.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Search.."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Location = New System.Drawing.Point(587, 52)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 41)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "View order"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(44, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(318, 31)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Pending Transactions"
        '
        'Cancelled
        '
        Me.Cancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cancelled.Controls.Add(Me.btnFinishedRefreshed)
        Me.Cancelled.Controls.Add(Me.btnFinishedFields)
        Me.Cancelled.Controls.Add(Me.btnViewFinished)
        Me.Cancelled.Controls.Add(Me.panFinished)
        Me.Cancelled.Controls.Add(Me.dgvFinished)
        Me.Cancelled.Controls.Add(Me.Label13)
        Me.Cancelled.Controls.Add(Me.btnFilter)
        Me.Cancelled.Controls.Add(Me.cbFilter)
        Me.Cancelled.Controls.Add(Me.Label17)
        Me.Cancelled.Controls.Add(Me.Label14)
        Me.Cancelled.Controls.Add(Me.txtSearchFinished)
        Me.Cancelled.Location = New System.Drawing.Point(4, 32)
        Me.Cancelled.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cancelled.Name = "Cancelled"
        Me.Cancelled.Size = New System.Drawing.Size(1606, 897)
        Me.Cancelled.TabIndex = 2
        Me.Cancelled.Text = "Finished"
        Me.Cancelled.UseVisualStyleBackColor = True
        '
        'btnFinishedRefreshed
        '
        Me.btnFinishedRefreshed.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFinishedRefreshed.FlatAppearance.BorderSize = 0
        Me.btnFinishedRefreshed.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinishedRefreshed.ForeColor = System.Drawing.Color.MintCream
        Me.btnFinishedRefreshed.Location = New System.Drawing.Point(443, 54)
        Me.btnFinishedRefreshed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFinishedRefreshed.Name = "btnFinishedRefreshed"
        Me.btnFinishedRefreshed.Size = New System.Drawing.Size(124, 41)
        Me.btnFinishedRefreshed.TabIndex = 29
        Me.btnFinishedRefreshed.Text = "Refresh"
        Me.btnFinishedRefreshed.UseVisualStyleBackColor = False
        '
        'btnFinishedFields
        '
        Me.btnFinishedFields.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinishedFields.BackColor = System.Drawing.Color.Orange
        Me.btnFinishedFields.FlatAppearance.BorderSize = 0
        Me.btnFinishedFields.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFinishedFields.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinishedFields.ForeColor = System.Drawing.Color.MintCream
        Me.btnFinishedFields.Location = New System.Drawing.Point(1448, 750)
        Me.btnFinishedFields.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFinishedFields.Name = "btnFinishedFields"
        Me.btnFinishedFields.Size = New System.Drawing.Size(122, 48)
        Me.btnFinishedFields.TabIndex = 28
        Me.btnFinishedFields.Text = "Clear Fields"
        Me.btnFinishedFields.UseVisualStyleBackColor = False
        '
        'btnViewFinished
        '
        Me.btnViewFinished.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnViewFinished.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnViewFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFinished.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnViewFinished.Location = New System.Drawing.Point(585, 56)
        Me.btnViewFinished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnViewFinished.Name = "btnViewFinished"
        Me.btnViewFinished.Size = New System.Drawing.Size(122, 37)
        Me.btnViewFinished.TabIndex = 19
        Me.btnViewFinished.Text = "Select"
        Me.btnViewFinished.UseVisualStyleBackColor = False
        '
        'panFinished
        '
        Me.panFinished.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panFinished.BackColor = System.Drawing.SystemColors.Info
        Me.panFinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panFinished.Controls.Add(Me.lblFinishedUser)
        Me.panFinished.Controls.Add(Me.Label134)
        Me.panFinished.Controls.Add(Me.lblFinishedDate)
        Me.panFinished.Controls.Add(Me.Label136)
        Me.panFinished.Controls.Add(Me.lblFinishedChange)
        Me.panFinished.Controls.Add(Me.Label138)
        Me.panFinished.Controls.Add(Me.lblFinishedPayment)
        Me.panFinished.Controls.Add(Me.Label140)
        Me.panFinished.Controls.Add(Me.lblFinishedAmount)
        Me.panFinished.Controls.Add(Me.Label142)
        Me.panFinished.Controls.Add(Me.lblFinishedAddon4)
        Me.panFinished.Controls.Add(Me.lblFinishedAddon3)
        Me.panFinished.Controls.Add(Me.lblFinishedAddon2)
        Me.panFinished.Controls.Add(Me.lblFinishedAddon1)
        Me.panFinished.Controls.Add(Me.Label151)
        Me.panFinished.Controls.Add(Me.lblFinishedID)
        Me.panFinished.Controls.Add(Me.lblFinishedService)
        Me.panFinished.Controls.Add(Me.lblFinishedContact)
        Me.panFinished.Controls.Add(Me.lblFinishedFullName)
        Me.panFinished.Controls.Add(Me.Label156)
        Me.panFinished.Controls.Add(Me.Label157)
        Me.panFinished.Controls.Add(Me.Label158)
        Me.panFinished.Controls.Add(Me.Label159)
        Me.panFinished.Location = New System.Drawing.Point(1093, 97)
        Me.panFinished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panFinished.Name = "panFinished"
        Me.panFinished.Size = New System.Drawing.Size(477, 649)
        Me.panFinished.TabIndex = 18
        '
        'lblFinishedUser
        '
        Me.lblFinishedUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedUser.AutoSize = True
        Me.lblFinishedUser.Location = New System.Drawing.Point(253, 475)
        Me.lblFinishedUser.Name = "lblFinishedUser"
        Me.lblFinishedUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFinishedUser.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedUser.TabIndex = 26
        Me.lblFinishedUser.Text = "xxxxx"
        Me.lblFinishedUser.Visible = False
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(15, 475)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(152, 22)
        Me.Label134.TabIndex = 25
        Me.Label134.Text = "Processed by:"
        '
        'lblFinishedDate
        '
        Me.lblFinishedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedDate.AutoSize = True
        Me.lblFinishedDate.Location = New System.Drawing.Point(112, 550)
        Me.lblFinishedDate.Name = "lblFinishedDate"
        Me.lblFinishedDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblFinishedDate.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedDate.TabIndex = 24
        Me.lblFinishedDate.Text = "xxxxx"
        Me.lblFinishedDate.Visible = False
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(14, 513)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(174, 22)
        Me.Label136.TabIndex = 23
        Me.Label136.Text = "Date Processed:"
        '
        'lblFinishedChange
        '
        Me.lblFinishedChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedChange.AutoSize = True
        Me.lblFinishedChange.Location = New System.Drawing.Point(249, 408)
        Me.lblFinishedChange.Name = "lblFinishedChange"
        Me.lblFinishedChange.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedChange.TabIndex = 22
        Me.lblFinishedChange.Text = "xxxxx"
        Me.lblFinishedChange.Visible = False
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label138.Location = New System.Drawing.Point(15, 408)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(93, 22)
        Me.Label138.TabIndex = 21
        Me.Label138.Text = "Change:"
        '
        'lblFinishedPayment
        '
        Me.lblFinishedPayment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedPayment.AutoSize = True
        Me.lblFinishedPayment.Location = New System.Drawing.Point(249, 335)
        Me.lblFinishedPayment.Name = "lblFinishedPayment"
        Me.lblFinishedPayment.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedPayment.TabIndex = 20
        Me.lblFinishedPayment.Text = "xxxxx"
        Me.lblFinishedPayment.Visible = False
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.Location = New System.Drawing.Point(14, 335)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(199, 22)
        Me.Label140.TabIndex = 19
        Me.Label140.Text = "Payment received:"
        '
        'lblFinishedAmount
        '
        Me.lblFinishedAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedAmount.AutoSize = True
        Me.lblFinishedAmount.Location = New System.Drawing.Point(249, 372)
        Me.lblFinishedAmount.Name = "lblFinishedAmount"
        Me.lblFinishedAmount.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedAmount.TabIndex = 18
        Me.lblFinishedAmount.Text = "xxxxx"
        Me.lblFinishedAmount.Visible = False
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(14, 372)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(200, 22)
        Me.Label142.TabIndex = 17
        Me.Label142.Text = "Total amount paid:"
        '
        'lblFinishedAddon4
        '
        Me.lblFinishedAddon4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedAddon4.AutoSize = True
        Me.lblFinishedAddon4.Location = New System.Drawing.Point(249, 269)
        Me.lblFinishedAddon4.Name = "lblFinishedAddon4"
        Me.lblFinishedAddon4.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedAddon4.TabIndex = 16
        Me.lblFinishedAddon4.Text = "xxxxx"
        Me.lblFinishedAddon4.Visible = False
        '
        'lblFinishedAddon3
        '
        Me.lblFinishedAddon3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedAddon3.AutoSize = True
        Me.lblFinishedAddon3.Location = New System.Drawing.Point(249, 247)
        Me.lblFinishedAddon3.Name = "lblFinishedAddon3"
        Me.lblFinishedAddon3.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedAddon3.TabIndex = 15
        Me.lblFinishedAddon3.Text = "xxxxx"
        Me.lblFinishedAddon3.Visible = False
        '
        'lblFinishedAddon2
        '
        Me.lblFinishedAddon2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedAddon2.AutoSize = True
        Me.lblFinishedAddon2.Location = New System.Drawing.Point(249, 225)
        Me.lblFinishedAddon2.Name = "lblFinishedAddon2"
        Me.lblFinishedAddon2.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedAddon2.TabIndex = 14
        Me.lblFinishedAddon2.Text = "xxxxx"
        Me.lblFinishedAddon2.Visible = False
        '
        'lblFinishedAddon1
        '
        Me.lblFinishedAddon1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedAddon1.AutoSize = True
        Me.lblFinishedAddon1.Location = New System.Drawing.Point(249, 200)
        Me.lblFinishedAddon1.Name = "lblFinishedAddon1"
        Me.lblFinishedAddon1.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedAddon1.TabIndex = 13
        Me.lblFinishedAddon1.Text = "xxxxx"
        Me.lblFinishedAddon1.Visible = False
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label151.Location = New System.Drawing.Point(14, 171)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(181, 22)
        Me.Label151.TabIndex = 8
        Me.Label151.Text = "Add-ons availed:"
        '
        'lblFinishedID
        '
        Me.lblFinishedID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedID.AutoSize = True
        Me.lblFinishedID.Location = New System.Drawing.Point(249, 12)
        Me.lblFinishedID.Name = "lblFinishedID"
        Me.lblFinishedID.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedID.TabIndex = 7
        Me.lblFinishedID.Text = "xxxxx"
        Me.lblFinishedID.Visible = False
        '
        'lblFinishedService
        '
        Me.lblFinishedService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedService.AutoSize = True
        Me.lblFinishedService.Location = New System.Drawing.Point(108, 133)
        Me.lblFinishedService.Name = "lblFinishedService"
        Me.lblFinishedService.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedService.TabIndex = 6
        Me.lblFinishedService.Text = "xxxxx"
        Me.lblFinishedService.Visible = False
        '
        'lblFinishedContact
        '
        Me.lblFinishedContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedContact.AutoSize = True
        Me.lblFinishedContact.Location = New System.Drawing.Point(249, 75)
        Me.lblFinishedContact.Name = "lblFinishedContact"
        Me.lblFinishedContact.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedContact.TabIndex = 5
        Me.lblFinishedContact.Text = "xxxxx"
        Me.lblFinishedContact.Visible = False
        '
        'lblFinishedFullName
        '
        Me.lblFinishedFullName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFinishedFullName.AutoSize = True
        Me.lblFinishedFullName.Location = New System.Drawing.Point(249, 50)
        Me.lblFinishedFullName.Name = "lblFinishedFullName"
        Me.lblFinishedFullName.Size = New System.Drawing.Size(59, 20)
        Me.lblFinishedFullName.TabIndex = 4
        Me.lblFinishedFullName.Text = "xxxxx"
        Me.lblFinishedFullName.Visible = False
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.Location = New System.Drawing.Point(14, 12)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(173, 22)
        Me.Label156.TabIndex = 3
        Me.Label156.Text = "Transaction ID: "
        '
        'Label157
        '
        Me.Label157.AutoSize = True
        Me.Label157.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label157.Location = New System.Drawing.Point(14, 101)
        Me.Label157.Name = "Label157"
        Me.Label157.Size = New System.Drawing.Size(171, 22)
        Me.Label157.TabIndex = 2
        Me.Label157.Text = "Service availed:"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.Location = New System.Drawing.Point(14, 75)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(134, 22)
        Me.Label158.TabIndex = 1
        Me.Label158.Text = "Contact No.:"
        '
        'Label159
        '
        Me.Label159.AutoSize = True
        Me.Label159.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label159.Location = New System.Drawing.Point(14, 53)
        Me.Label159.Name = "Label159"
        Me.Label159.Size = New System.Drawing.Size(118, 22)
        Me.Label159.TabIndex = 0
        Me.Label159.Text = "Full Name:"
        '
        'dgvFinished
        '
        Me.dgvFinished.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvFinished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinished.Location = New System.Drawing.Point(50, 97)
        Me.dgvFinished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvFinished.Name = "dgvFinished"
        Me.dgvFinished.RowHeadersWidth = 51
        Me.dgvFinished.Size = New System.Drawing.Size(1037, 649)
        Me.dgvFinished.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(713, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Filter by:"
        '
        'btnFilter
        '
        Me.btnFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFilter.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnFilter.FlatAppearance.BorderSize = 0
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFilter.ForeColor = System.Drawing.Color.MintCream
        Me.btnFilter.Location = New System.Drawing.Point(964, 53)
        Me.btnFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(122, 37)
        Me.btnFilter.TabIndex = 12
        Me.btnFilter.Text = "Apply "
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'cbFilter
        '
        Me.cbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFilter.FormattingEnabled = True
        Me.cbFilter.Items.AddRange(New Object() {"All", "Finished", "Cancelled"})
        Me.cbFilter.Location = New System.Drawing.Point(807, 62)
        Me.cbFilter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(151, 28)
        Me.cbFilter.TabIndex = 11
        Me.cbFilter.Text = "All"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Location = New System.Drawing.Point(46, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(232, 31)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Finished orders"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(46, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 20)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Search.."
        '
        'txtSearchFinished
        '
        Me.txtSearchFinished.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtSearchFinished.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchFinished.Location = New System.Drawing.Point(135, 63)
        Me.txtSearchFinished.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchFinished.Name = "txtSearchFinished"
        Me.txtSearchFinished.Size = New System.Drawing.Size(302, 28)
        Me.txtSearchFinished.TabIndex = 8
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage5.Controls.Add(Me.TabControl6)
        Me.TabPage5.Controls.Add(Me.btnDeleteOwnAccount)
        Me.TabPage5.Controls.Add(Me.Label52)
        Me.TabPage5.Location = New System.Drawing.Point(4, 34)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1625, 933)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "Account Settings"
        '
        'TabControl6
        '
        Me.TabControl6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl6.Controls.Add(Me.TabPage6)
        Me.TabControl6.Controls.Add(Me.TabPage7)
        Me.TabControl6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl6.Location = New System.Drawing.Point(-5, 76)
        Me.TabControl6.Multiline = True
        Me.TabControl6.Name = "TabControl6"
        Me.TabControl6.Padding = New System.Drawing.Point(0, 0)
        Me.TabControl6.SelectedIndex = 0
        Me.TabControl6.Size = New System.Drawing.Size(1787, 848)
        Me.TabControl6.TabIndex = 24
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage6.Controls.Add(Me.Panel9)
        Me.TabPage6.Controls.Add(Me.PictureBox3)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1779, 815)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Account info"
        '
        'Panel9
        '
        Me.Panel9.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel9.Controls.Add(Me.Label77)
        Me.Panel9.Controls.Add(Me.Label83)
        Me.Panel9.Controls.Add(Me.Label58)
        Me.Panel9.Controls.Add(Me.Label64)
        Me.Panel9.Controls.Add(Me.Label65)
        Me.Panel9.Controls.Add(Me.Label66)
        Me.Panel9.Controls.Add(Me.lblAdminUsername)
        Me.Panel9.Controls.Add(Me.Label67)
        Me.Panel9.Controls.Add(Me.lblAccountID)
        Me.Panel9.Controls.Add(Me.lblAccountDateCreated)
        Me.Panel9.Controls.Add(Me.lblAdminFullName)
        Me.Panel9.Location = New System.Drawing.Point(63, 204)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(409, 358)
        Me.Panel9.TabIndex = 40
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(37, 192)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(119, 20)
        Me.Label77.TabIndex = 35
        Me.Label77.Text = "User Name:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Verdana", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label83.Location = New System.Drawing.Point(31, 35)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(172, 26)
        Me.Label83.TabIndex = 25
        Me.Label83.Text = "Account Info"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(76, 108)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(88, 20)
        Me.Label58.TabIndex = 23
        Me.Label58.Text = "User ID:"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(19, 282)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(137, 20)
        Me.Label64.TabIndex = 24
        Me.Label64.Text = "Date created:"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(45, 148)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(111, 20)
        Me.Label65.TabIndex = 25
        Me.Label65.Text = "Full Name:"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(98, 240)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(58, 20)
        Me.Label66.TabIndex = 26
        Me.Label66.Text = "Role:"
        '
        'lblAdminUsername
        '
        Me.lblAdminUsername.AutoSize = True
        Me.lblAdminUsername.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminUsername.Location = New System.Drawing.Point(170, 190)
        Me.lblAdminUsername.Name = "lblAdminUsername"
        Me.lblAdminUsername.Size = New System.Drawing.Size(65, 22)
        Me.lblAdminUsername.TabIndex = 36
        Me.lblAdminUsername.Text = "xxxxx"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(168, 240)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(67, 22)
        Me.Label67.TabIndex = 27
        Me.Label67.Text = "Admin"
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.Location = New System.Drawing.Point(170, 108)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(65, 22)
        Me.lblAccountID.TabIndex = 29
        Me.lblAccountID.Text = "xxxxx"
        '
        'lblAccountDateCreated
        '
        Me.lblAccountDateCreated.AutoSize = True
        Me.lblAccountDateCreated.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountDateCreated.Location = New System.Drawing.Point(170, 282)
        Me.lblAccountDateCreated.Name = "lblAccountDateCreated"
        Me.lblAccountDateCreated.Size = New System.Drawing.Size(65, 22)
        Me.lblAccountDateCreated.TabIndex = 32
        Me.lblAccountDateCreated.Text = "xxxxx"
        '
        'lblAdminFullName
        '
        Me.lblAdminFullName.AutoSize = True
        Me.lblAdminFullName.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminFullName.Location = New System.Drawing.Point(170, 148)
        Me.lblAdminFullName.Name = "lblAdminFullName"
        Me.lblAdminFullName.Size = New System.Drawing.Size(65, 22)
        Me.lblAdminFullName.TabIndex = 30
        Me.lblAdminFullName.Text = "xxxxx"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(512, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1045, 514)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage7.Controls.Add(Me.Panel6)
        Me.TabPage7.Location = New System.Drawing.Point(4, 29)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1779, 815)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Edit account"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.Controls.Add(Me.lblAdminID)
        Me.Panel6.Controls.Add(Me.Label36)
        Me.Panel6.Controls.Add(Me.btnClearAccountFields)
        Me.Panel6.Controls.Add(Me.btnInsertOwndata)
        Me.Panel6.Controls.Add(Me.txtEditAdminEmail)
        Me.Panel6.Controls.Add(Me.Label131)
        Me.Panel6.Controls.Add(Me.txtEditAdminContact)
        Me.Panel6.Controls.Add(Me.Label130)
        Me.Panel6.Controls.Add(Me.txtAdminEditLName)
        Me.Panel6.Controls.Add(Me.Label81)
        Me.Panel6.Controls.Add(Me.txtAdminEditFName)
        Me.Panel6.Controls.Add(Me.btnConfirmChanges)
        Me.Panel6.Controls.Add(Me.Label84)
        Me.Panel6.Controls.Add(Me.btnHideUser)
        Me.Panel6.Controls.Add(Me.txtChangePassword)
        Me.Panel6.Controls.Add(Me.lblEditOwnID)
        Me.Panel6.Controls.Add(Me.btnConf)
        Me.Panel6.Controls.Add(Me.Label85)
        Me.Panel6.Controls.Add(Me.Label87)
        Me.Panel6.Controls.Add(Me.Label86)
        Me.Panel6.Controls.Add(Me.btnHidePassword)
        Me.Panel6.Controls.Add(Me.Label79)
        Me.Panel6.Controls.Add(Me.txtEditAdminUser)
        Me.Panel6.Controls.Add(Me.Label78)
        Me.Panel6.Controls.Add(Me.txtConfirmPassword)
        Me.Panel6.Location = New System.Drawing.Point(579, 93)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(612, 594)
        Me.Panel6.TabIndex = 61
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.lblAdminID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminID.Location = New System.Drawing.Point(210, 93)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(65, 22)
        Me.lblAdminID.TabIndex = 71
        Me.lblAdminID.Text = "xxxxx"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(62, 94)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(106, 20)
        Me.Label36.TabIndex = 70
        Me.Label36.Text = "Admin ID:"
        '
        'btnClearAccountFields
        '
        Me.btnClearAccountFields.BackColor = System.Drawing.Color.Orange
        Me.btnClearAccountFields.FlatAppearance.BorderSize = 0
        Me.btnClearAccountFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAccountFields.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAccountFields.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClearAccountFields.Location = New System.Drawing.Point(214, 498)
        Me.btnClearAccountFields.Name = "btnClearAccountFields"
        Me.btnClearAccountFields.Size = New System.Drawing.Size(179, 50)
        Me.btnClearAccountFields.TabIndex = 69
        Me.btnClearAccountFields.Text = "Clear Fields"
        Me.btnClearAccountFields.UseVisualStyleBackColor = False
        '
        'btnInsertOwndata
        '
        Me.btnInsertOwndata.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnInsertOwndata.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnInsertOwndata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsertOwndata.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertOwndata.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnInsertOwndata.Location = New System.Drawing.Point(29, 498)
        Me.btnInsertOwndata.Name = "btnInsertOwndata"
        Me.btnInsertOwndata.Size = New System.Drawing.Size(179, 50)
        Me.btnInsertOwndata.TabIndex = 68
        Me.btnInsertOwndata.Text = "Insert data"
        Me.btnInsertOwndata.UseVisualStyleBackColor = False
        '
        'txtEditAdminEmail
        '
        Me.txtEditAdminEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditAdminEmail.Location = New System.Drawing.Point(212, 272)
        Me.txtEditAdminEmail.Name = "txtEditAdminEmail"
        Me.txtEditAdminEmail.Size = New System.Drawing.Size(287, 28)
        Me.txtEditAdminEmail.TabIndex = 67
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(99, 274)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(69, 20)
        Me.Label131.TabIndex = 66
        Me.Label131.Text = "Email:"
        '
        'txtEditAdminContact
        '
        Me.txtEditAdminContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditAdminContact.Location = New System.Drawing.Point(213, 216)
        Me.txtEditAdminContact.Name = "txtEditAdminContact"
        Me.txtEditAdminContact.Size = New System.Drawing.Size(287, 28)
        Me.txtEditAdminContact.TabIndex = 65
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(79, 216)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(89, 20)
        Me.Label130.TabIndex = 64
        Me.Label130.Text = "Contact:"
        '
        'txtAdminEditLName
        '
        Me.txtAdminEditLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdminEditLName.Location = New System.Drawing.Point(214, 171)
        Me.txtAdminEditLName.Name = "txtAdminEditLName"
        Me.txtAdminEditLName.Size = New System.Drawing.Size(287, 28)
        Me.txtAdminEditLName.TabIndex = 63
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(52, 171)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(116, 20)
        Me.Label81.TabIndex = 62
        Me.Label81.Text = "Last Name:"
        '
        'txtAdminEditFName
        '
        Me.txtAdminEditFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdminEditFName.Location = New System.Drawing.Point(214, 124)
        Me.txtAdminEditFName.Name = "txtAdminEditFName"
        Me.txtAdminEditFName.Size = New System.Drawing.Size(287, 28)
        Me.txtAdminEditFName.TabIndex = 61
        '
        'btnConfirmChanges
        '
        Me.btnConfirmChanges.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnConfirmChanges.FlatAppearance.BorderSize = 0
        Me.btnConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmChanges.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmChanges.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnConfirmChanges.Location = New System.Drawing.Point(399, 498)
        Me.btnConfirmChanges.Name = "btnConfirmChanges"
        Me.btnConfirmChanges.Size = New System.Drawing.Size(179, 50)
        Me.btnConfirmChanges.TabIndex = 25
        Me.btnConfirmChanges.Text = "Apply Changes"
        Me.btnConfirmChanges.UseVisualStyleBackColor = False
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Verdana", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label84.Location = New System.Drawing.Point(27, 24)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(168, 26)
        Me.Label84.TabIndex = 51
        Me.Label84.Text = "Edit Account"
        '
        'btnHideUser
        '
        Me.btnHideUser.Location = New System.Drawing.Point(534, 334)
        Me.btnHideUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHideUser.Name = "btnHideUser"
        Me.btnHideUser.Size = New System.Drawing.Size(51, 28)
        Me.btnHideUser.TabIndex = 60
        Me.btnHideUser.Text = "👁"
        Me.btnHideUser.UseVisualStyleBackColor = True
        '
        'txtChangePassword
        '
        Me.txtChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangePassword.Location = New System.Drawing.Point(213, 385)
        Me.txtChangePassword.Name = "txtChangePassword"
        Me.txtChangePassword.Size = New System.Drawing.Size(287, 28)
        Me.txtChangePassword.TabIndex = 53
        '
        'lblEditOwnID
        '
        Me.lblEditOwnID.AutoSize = True
        Me.lblEditOwnID.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditOwnID.Location = New System.Drawing.Point(208, 63)
        Me.lblEditOwnID.Name = "lblEditOwnID"
        Me.lblEditOwnID.Size = New System.Drawing.Size(65, 22)
        Me.lblEditOwnID.TabIndex = 44
        Me.lblEditOwnID.Text = "xxxxx"
        '
        'btnConf
        '
        Me.btnConf.Location = New System.Drawing.Point(535, 429)
        Me.btnConf.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(51, 28)
        Me.btnConf.TabIndex = 59
        Me.btnConf.Text = "👁"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(51, 126)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(119, 20)
        Me.Label85.TabIndex = 41
        Me.Label85.Text = "First Name:"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(83, 63)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(88, 20)
        Me.Label87.TabIndex = 39
        Me.Label87.Text = "User ID:"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(28, 431)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(140, 20)
        Me.Label86.TabIndex = 40
        Me.Label86.Text = "Confirm Pass:"
        '
        'btnHidePassword
        '
        Me.btnHidePassword.Location = New System.Drawing.Point(535, 385)
        Me.btnHidePassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHidePassword.Name = "btnHidePassword"
        Me.btnHidePassword.Size = New System.Drawing.Size(51, 28)
        Me.btnHidePassword.TabIndex = 58
        Me.btnHidePassword.Text = "👁"
        Me.btnHidePassword.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(51, 334)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(119, 20)
        Me.Label79.TabIndex = 47
        Me.Label79.Text = "User Name:"
        '
        'txtEditAdminUser
        '
        Me.txtEditAdminUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEditAdminUser.Location = New System.Drawing.Point(212, 334)
        Me.txtEditAdminUser.Name = "txtEditAdminUser"
        Me.txtEditAdminUser.Size = New System.Drawing.Size(287, 28)
        Me.txtEditAdminUser.TabIndex = 55
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(63, 385)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(108, 20)
        Me.Label78.TabIndex = 52
        Me.Label78.Text = "Password:"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmPassword.Location = New System.Drawing.Point(213, 429)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(287, 28)
        Me.txtConfirmPassword.TabIndex = 54
        '
        'btnDeleteOwnAccount
        '
        Me.btnDeleteOwnAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteOwnAccount.BackColor = System.Drawing.Color.Red
        Me.btnDeleteOwnAccount.FlatAppearance.BorderSize = 0
        Me.btnDeleteOwnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteOwnAccount.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOwnAccount.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnDeleteOwnAccount.Location = New System.Drawing.Point(1421, 15)
        Me.btnDeleteOwnAccount.Name = "btnDeleteOwnAccount"
        Me.btnDeleteOwnAccount.Size = New System.Drawing.Size(167, 55)
        Me.btnDeleteOwnAccount.TabIndex = 23
        Me.btnDeleteOwnAccount.Text = "Delete account"
        Me.btnDeleteOwnAccount.UseVisualStyleBackColor = False
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Verdana", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label52.Location = New System.Drawing.Point(27, 23)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(252, 31)
        Me.Label52.TabIndex = 15
        Me.Label52.Text = "Account Settings"
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.MintCream
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnLogout.Location = New System.Drawing.Point(1460, 21)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(137, 46)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 11.0!)
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(119, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(154, 23)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Welcome back!"
        '
        'txtChangeConfigUs
        '
        Me.txtChangeConfigUs.Location = New System.Drawing.Point(276, 36)
        Me.txtChangeConfigUs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtChangeConfigUs.Name = "txtChangeConfigUs"
        Me.txtChangeConfigUs.Size = New System.Drawing.Size(201, 22)
        Me.txtChangeConfigUs.TabIndex = 17
        Me.txtChangeConfigUs.Visible = False
        '
        'txtChangeConfigPass
        '
        Me.txtChangeConfigPass.Location = New System.Drawing.Point(494, 35)
        Me.txtChangeConfigPass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtChangeConfigPass.Name = "txtChangeConfigPass"
        Me.txtChangeConfigPass.Size = New System.Drawing.Size(201, 22)
        Me.txtChangeConfigPass.TabIndex = 18
        Me.txtChangeConfigPass.Visible = False
        '
        'btnChangeConfig
        '
        Me.btnChangeConfig.BackColor = System.Drawing.Color.MintCream
        Me.btnChangeConfig.FlatAppearance.BorderSize = 0
        Me.btnChangeConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangeConfig.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeConfig.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnChangeConfig.Location = New System.Drawing.Point(711, 32)
        Me.btnChangeConfig.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangeConfig.Name = "btnChangeConfig"
        Me.btnChangeConfig.Size = New System.Drawing.Size(122, 30)
        Me.btnChangeConfig.TabIndex = 19
        Me.btnChangeConfig.Text = "Change pass"
        Me.btnChangeConfig.UseVisualStyleBackColor = False
        Me.btnChangeConfig.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.MintCream
        Me.lblDate.Location = New System.Drawing.Point(1121, 35)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(64, 20)
        Me.lblDate.TabIndex = 20
        Me.lblDate.Text = "xxxxx"
        '
        'Label160
        '
        Me.Label160.AutoSize = True
        Me.Label160.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label160.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label160.Location = New System.Drawing.Point(119, 9)
        Me.Label160.Name = "Label160"
        Me.Label160.Size = New System.Drawing.Size(68, 18)
        Me.Label160.TabIndex = 21
        Me.Label160.Text = "user ID:"
        '
        'lblSmallUserID
        '
        Me.lblSmallUserID.AutoSize = True
        Me.lblSmallUserID.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallUserID.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSmallUserID.Location = New System.Drawing.Point(193, 9)
        Me.lblSmallUserID.Name = "lblSmallUserID"
        Me.lblSmallUserID.Size = New System.Drawing.Size(68, 18)
        Me.lblSmallUserID.TabIndex = 22
        Me.lblSmallUserID.Text = "user ID:"
        '
        'btnDeleteTransac
        '
        Me.btnDeleteTransac.BackColor = System.Drawing.Color.Black
        Me.btnDeleteTransac.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnDeleteTransac.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteTransac.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTransac.ForeColor = System.Drawing.Color.Red
        Me.btnDeleteTransac.Location = New System.Drawing.Point(16, 616)
        Me.btnDeleteTransac.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteTransac.Name = "btnDeleteTransac"
        Me.btnDeleteTransac.Size = New System.Drawing.Size(132, 48)
        Me.btnDeleteTransac.TabIndex = 27
        Me.btnDeleteTransac.Text = "Delete"
        Me.btnDeleteTransac.UseVisualStyleBackColor = False
        Me.btnDeleteTransac.Visible = False
        '
        'OwnerPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1634, 1055)
        Me.Controls.Add(Me.lblSmallUserID)
        Me.Controls.Add(Me.Label160)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnChangeConfig)
        Me.Controls.Add(Me.txtChangeConfigPass)
        Me.Controls.Add(Me.txtChangeConfigUs)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "OwnerPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lavadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.reportsPage.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.Sales.ResumeLayout(False)
        Me.Sales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.chService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inventory.ResumeLayout(False)
        Me.Inventory.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.panConfigureItem.ResumeLayout(False)
        Me.panConfigureItem.PerformLayout()
        CType(Me.dgvInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.panServiceOptions.ResumeLayout(False)
        Me.panServiceOptions.PerformLayout()
        CType(Me.dgvServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.employeePage.ResumeLayout(False)
        Me.employeePage.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.AddEmployee.ResumeLayout(False)
        Me.AddEmployee.PerformLayout()
        Me.EditDetails.ResumeLayout(False)
        Me.EditDetails.PerformLayout()
        Me.RemoveEmployee.ResumeLayout(False)
        Me.RemoveEmployee.PerformLayout()
        CType(Me.dgvEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.add.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panOrderInfo.ResumeLayout(False)
        Me.panOrderInfo.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panLayer3.ResumeLayout(False)
        Me.panLayer3.PerformLayout()
        CType(Me.numLoadWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panLayer2.ResumeLayout(False)
        Me.panLayer2.PerformLayout()
        CType(Me.numAddon4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAddon3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAddon2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAddon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panLayer1.ResumeLayout(False)
        Me.panLayer1.PerformLayout()
        Me.panSelfService.ResumeLayout(False)
        Me.panSelfService.PerformLayout()
        Me.panFullService.ResumeLayout(False)
        Me.panFullService.PerformLayout()
        Me.Pending.ResumeLayout(False)
        Me.Pending.PerformLayout()
        Me.panPendingOrdersss.ResumeLayout(False)
        Me.panPendingOrdersss.PerformLayout()
        CType(Me.dgvPending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cancelled.ResumeLayout(False)
        Me.Cancelled.PerformLayout()
        Me.panFinished.ResumeLayout(False)
        Me.panFinished.PerformLayout()
        CType(Me.dgvFinished, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl6.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents reportsPage As TabPage
    Friend WithEvents employeePage As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnLogout As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Sales As TabPage
    Friend WithEvents Inventory As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents add As TabPage
    Friend WithEvents panOrderInfo As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnComplete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNextAd As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents panLayer3 As Panel
    Friend WithEvents numLoadWeight As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents panLayer2 As Panel
    Friend WithEvents cbNone As CheckBox
    Friend WithEvents cbAddon4 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAddon3 As CheckBox
    Friend WithEvents cbAddon2 As CheckBox
    Friend WithEvents cbAddon1 As CheckBox
    Friend WithEvents panLayer1 As Panel
    Friend WithEvents panSelfService As Panel
    Friend WithEvents cbDry As CheckBox
    Friend WithEvents cbWash As CheckBox
    Friend WithEvents rbFullService As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents rbSelfService As RadioButton
    Friend WithEvents panFullService As Panel
    Friend WithEvents rbComforters As RadioButton
    Friend WithEvents rbWDF As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents Pending As TabPage
    Friend WithEvents dgvPending As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearchPending As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Cancelled As TabPage
    Friend WithEvents dgvFinished As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents cbFilter As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSearchFinished As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnRemoveEmployee As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents lblEmployeeFunc As Label
    Friend WithEvents txtInventorySearch As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnInventoryReport As Button
    Friend WithEvents panConfigureItem As Panel
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label As Label
    Friend WithEvents lblLastRestock As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnUpdateItem As Button
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txtChangeConfigUs As TextBox
    Friend WithEvents txtChangeConfigPass As TextBox
    Friend WithEvents btnChangeConfig As Button
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents EditDetails As TabPage
    Friend WithEvents AddEmployee As TabPage
    Friend WithEvents RemoveEmployee As TabPage
    Friend WithEvents btnSelectEdit As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents lblLoadWeight As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents lblAddon4Fee As Label
    Friend WithEvents lblAddon3Fee As Label
    Friend WithEvents lblAddon2Fee As Label
    Friend WithEvents lblAddon1Fee As Label
    Friend WithEvents lblAddon4 As Label
    Friend WithEvents lblAddon3 As Label
    Friend WithEvents lblAddon2 As Label
    Friend WithEvents lblAddon1 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents lblServiceAvailed As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmployeeLastName As TextBox
    Friend WithEvents txtEmployeeFirstName As TextBox
    Friend WithEvents lblEmployeeStatus As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents lblEmployeeID As Label
    Friend WithEvents txtAddEmEmail As TextBox
    Friend WithEvents txtAddEmContact As TextBox
    Friend WithEvents txtAddEmLast As TextBox
    Friend WithEvents txtAddEmFirst As TextBox
    Friend WithEvents lblRemEmID As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents lblItemID As Label
    Friend WithEvents btnEditEmployees As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label52 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents lblAddon4Total As Label
    Friend WithEvents lblAddon3Total As Label
    Friend WithEvents lblAddon2Total As Label
    Friend WithEvents lblAddon1Total As Label
    Friend WithEvents lblServiceFee As Label
    Friend WithEvents btnDeleteOwnAccount As Button
    Friend WithEvents TabControl6 As TabControl
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents lblAccountDateCreated As Label
    Friend WithEvents lblAdminFullName As Label
    Friend WithEvents lblAccountID As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents chItems As DataVisualization.Charting.Chart
    Friend WithEvents txtEmPassword As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txtAddEmPassword As TextBox
    Friend WithEvents txtEditConfirmPass As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents txtAddConfirmPass As TextBox
    Friend WithEvents txtEmUserName As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents txtAddEmUserName As TextBox
    Friend WithEvents lblAdminUsername As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label79 As Label
    Friend WithEvents lblEditOwnID As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents btnConfirmChanges As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents txtChangePassword As TextBox
    Friend WithEvents txtEditAdminUser As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnHideUser As Button
    Friend WithEvents btnConf As Button
    Friend WithEvents btnHidePassword As Button
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnViewItem As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblRemEmStatus As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents lblRemEmContact As Label
    Friend WithEvents lblRemEmEmail As Label
    Friend WithEvents lblRemEmName As Label
    Friend WithEvents numAddon4 As NumericUpDown
    Friend WithEvents numAddon3 As NumericUpDown
    Friend WithEvents numAddon2 As NumericUpDown
    Friend WithEvents numAddon1 As NumericUpDown
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lblDateAdded As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPaymentMethod As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents cbCity As ComboBox
    Friend WithEvents cbProvince As ComboBox
    Friend WithEvents lblPostalCode As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents txtContactNum As TextBox
    Friend WithEvents panPendingOrdersss As Panel
    Friend WithEvents lblProcessedBy As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblPendingTransacDateAdded As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lblPendingChange As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents lblPaymentReceived As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents lblPendingTotal As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label47 As Label
    Friend WithEvents lblPendingAddon4 As Label
    Friend WithEvents lblPendingAddon3 As Label
    Friend WithEvents lblPendingAddon2 As Label
    Friend WithEvents lblPendingAddon1 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents lblPendingOrderID As Label
    Friend WithEvents lblPendingService As Label
    Friend WithEvents lblPendingContact As Label
    Friend WithEvents lblPendingFullName As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents lblEmployeeDateAdded As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents cbEmShift As ComboBox
    Friend WithEvents cbEmWorkingHours As ComboBox
    Friend WithEvents cbEmProvince As ComboBox
    Friend WithEvents cbEmCityTown As ComboBox
    Friend WithEvents Label96 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents cbAddShift As ComboBox
    Friend WithEvents cbAddWorkingHours As ComboBox
    Friend WithEvents cbAddProvince As ComboBox
    Friend WithEvents cbAddCity As ComboBox
    Friend WithEvents Label98 As Label
    Friend WithEvents Label99 As Label
    Friend WithEvents Label100 As Label
    Friend WithEvents Label101 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents chService As DataVisualization.Charting.Chart
    Friend WithEvents Label105 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents btnSelectDelete As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents cbCustomerSex As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label106 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label107 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents lblQuantityInStock As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents lblItemStatus As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents lblReorderLevel As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents cbItemBrand As ComboBox
    Friend WithEvents lblDateModified As Label
    Friend WithEvents dgvServices As DataGridView
    Friend WithEvents Panel18 As Panel
    Friend WithEvents panServiceOptions As Panel
    Friend WithEvents cbServiceName As ComboBox
    Friend WithEvents lblServiceDateModified As Label
    Friend WithEvents Label114 As Label
    Friend WithEvents Label116 As Label
    Friend WithEvents Label120 As Label
    Friend WithEvents Label121 As Label
    Friend WithEvents Label122 As Label
    Friend WithEvents lblServiceID As Label
    Friend WithEvents Label126 As Label
    Friend WithEvents Label127 As Label
    Friend WithEvents cbServiceCategory As ComboBox
    Friend WithEvents Label128 As Label
    Friend WithEvents Label124 As Label
    Friend WithEvents Label125 As Label
    Friend WithEvents txtItemCost As TextBox
    Friend WithEvents txtItemPrice As TextBox
    Friend WithEvents dateRestock As DateTimePicker
    Friend WithEvents Label129 As Label
    Friend WithEvents txtAdminEditFName As TextBox
    Friend WithEvents txtAdminEditLName As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents txtEditAdminEmail As TextBox
    Friend WithEvents Label131 As Label
    Friend WithEvents txtEditAdminContact As TextBox
    Friend WithEvents Label130 As Label
    Friend WithEvents txtServiceFee As TextBox
    Friend WithEvents btnViewService As Button
    Friend WithEvents btnUpdateService As Button
    Friend WithEvents btnAddService As Button
    Friend WithEvents btnDeleteService As Button
    Friend WithEvents cbServiceStatus As ComboBox
    Friend WithEvents lblServiceDateAdded As Label
    Friend WithEvents Label132 As Label
    Friend WithEvents cbServiceAvail As ComboBox
    Friend WithEvents btnClearFields As Button
    Friend WithEvents btnWeeklyServicesReport As Button
    Friend WithEvents txtEmployeeAge As TextBox
    Friend WithEvents Label113 As Label
    Friend WithEvents txtEditEmAge As TextBox
    Friend WithEvents Label115 As Label
    Friend WithEvents btnAddEmConfirm As Button
    Friend WithEvents btnAddEmPass As Button
    Friend WithEvents cbAddEmSex As ComboBox
    Friend WithEvents Label117 As Label
    Friend WithEvents btnEmployeeDGVrefresh As Button
    Friend WithEvents btnClearAddEm As Button
    Friend WithEvents btnClearEditFields As Button
    Friend WithEvents lblInvisibleIDEDIT As Label
    Friend WithEvents btnEditConfirm As Button
    Friend WithEvents btnEditUserAcc As Button
    Friend WithEvents lblRemEmInvi As Label
    Friend WithEvents lblRemEmDate As Label
    Friend WithEvents Label118 As Label
    Friend WithEvents cbItemName As ComboBox
    Friend WithEvents btnInventoryRefresh As Button
    Friend WithEvents btnRemoveFields As Button
    Friend WithEvents btnRefreshServices As Button
    Friend WithEvents btnClearItemFields As Button
    Friend WithEvents txtRestockItem As TextBox
    Friend WithEvents btnClearAccountFields As Button
    Friend WithEvents Label82 As Label
    Friend WithEvents txtServiceDescription As TextBox
    Friend WithEvents lblTimesAvailed As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents cbFilterReport As ComboBox
    Friend WithEvents Label119 As Label
    Friend WithEvents txtMiddleIni As TextBox
    Friend WithEvents lblInvisibleOrderID As Label
    Friend WithEvents lblInvisibleCustomerID As Label
    Friend WithEvents lblInvisibleTransactionID As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label123 As Label
    Friend WithEvents panFinished As Panel
    Friend WithEvents lblFinishedUser As Label
    Friend WithEvents Label134 As Label
    Friend WithEvents lblFinishedDate As Label
    Friend WithEvents Label136 As Label
    Friend WithEvents lblFinishedChange As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents lblFinishedPayment As Label
    Friend WithEvents Label140 As Label
    Friend WithEvents lblFinishedAmount As Label
    Friend WithEvents Label142 As Label
    Friend WithEvents lblFinishedAddon4 As Label
    Friend WithEvents lblFinishedAddon3 As Label
    Friend WithEvents lblFinishedAddon2 As Label
    Friend WithEvents lblFinishedAddon1 As Label
    Friend WithEvents Label151 As Label
    Friend WithEvents lblFinishedID As Label
    Friend WithEvents lblFinishedService As Label
    Friend WithEvents lblFinishedContact As Label
    Friend WithEvents lblFinishedFullName As Label
    Friend WithEvents Label156 As Label
    Friend WithEvents Label157 As Label
    Friend WithEvents Label158 As Label
    Friend WithEvents Label159 As Label
    Friend WithEvents btnViewFinished As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnFinishedFields As Button
    Friend WithEvents Label160 As Label
    Friend WithEvents lblSmallUserID As Label
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents btnInsertOwndata As Button
    Friend WithEvents Label161 As Label
    Friend WithEvents lblServiceCategory As Label
    Friend WithEvents Label166 As Label
    Friend WithEvents lblMostAvailedItem As Label
    Friend WithEvents lblMostAvailedService As Label
    Friend WithEvents Label162 As Label
    Friend WithEvents lblMostTransactionFinished As Label
    Friend WithEvents cbColored As ComboBox
    Friend WithEvents Label167 As Label
    Friend WithEvents lblIscolored As Label
    Friend WithEvents Label168 As Label
    Friend WithEvents btnSwitchTables As Button
    Friend WithEvents btnSwitchOrdersTable As Button
    Friend WithEvents lblAdminID As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents btnFinishedRefreshed As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents btnDeleteTransac As Button
End Class
