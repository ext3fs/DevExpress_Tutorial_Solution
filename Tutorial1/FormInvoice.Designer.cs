
namespace Tutorial1
{
    partial class FormInvoice
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnLoadData = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.DtToDate = new DevExpress.XtraEditors.DateEdit();
            this.DtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.GridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnLoadData);
            this.layoutControl1.Controls.Add(this.BtnPrint);
            this.layoutControl1.Controls.Add(this.DtToDate);
            this.layoutControl1.Controls.Add(this.DtFromDate);
            this.layoutControl1.Controls.Add(this.GridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1096, 622);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnLoadData
            // 
            this.BtnLoadData.Location = new System.Drawing.Point(943, 578);
            this.BtnLoadData.Name = "BtnLoadData";
            this.BtnLoadData.Size = new System.Drawing.Size(141, 32);
            this.BtnLoadData.StyleController = this.layoutControl1;
            this.BtnLoadData.TabIndex = 8;
            this.BtnLoadData.Text = "Load Data";
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(799, 578);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(140, 32);
            this.BtnPrint.StyleController = this.layoutControl1;
            this.BtnPrint.TabIndex = 7;
            this.BtnPrint.Text = "Print";
            // 
            // DtToDate
            // 
            this.DtToDate.EditValue = null;
            this.DtToDate.Location = new System.Drawing.Point(440, 12);
            this.DtToDate.Name = "DtToDate";
            this.DtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtToDate.Size = new System.Drawing.Size(224, 28);
            this.DtToDate.StyleController = this.layoutControl1;
            this.DtToDate.TabIndex = 6;
            // 
            // DtFromDate
            // 
            this.DtFromDate.EditValue = null;
            this.DtFromDate.Location = new System.Drawing.Point(112, 12);
            this.DtFromDate.Name = "DtFromDate";
            this.DtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFromDate.Size = new System.Drawing.Size(224, 28);
            this.DtFromDate.StyleController = this.layoutControl1;
            this.DtFromDate.TabIndex = 5;
            // 
            // GridControl
            // 
            this.GridControl.DataSource = this.ordersBindingSource;
            this.GridControl.Location = new System.Drawing.Point(12, 44);
            this.GridControl.MainView = this.gridView1;
            this.GridControl.Name = "GridControl";
            this.GridControl.Size = new System.Drawing.Size(1072, 530);
            this.GridControl.TabIndex = 4;
            this.GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderId,
            this.colCustomerId,
            this.colShipName,
            this.colShipAddress,
            this.colShipPostalCode,
            this.colShipCountry,
            this.colShipCity,
            this.colOrderDate});
            this.gridView1.GridControl = this.GridControl;
            this.gridView1.Name = "gridView1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1096, 622);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.GridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1076, 534);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DtFromDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(328, 32);
            this.layoutControlItem2.Text = "From Date:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.DtToDate;
            this.layoutControlItem3.Location = new System.Drawing.Point(328, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(328, 32);
            this.layoutControlItem3.Text = "To Date:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(88, 22);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(656, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(420, 32);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.BtnPrint;
            this.layoutControlItem4.Location = new System.Drawing.Point(787, 566);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(144, 36);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(144, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(144, 36);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.BtnLoadData;
            this.layoutControlItem5.Location = new System.Drawing.Point(931, 566);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(145, 36);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(145, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(145, 36);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 566);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(787, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(Tutorial1.BLL.Orders);
            // 
            // colOrderId
            // 
            this.colOrderId.FieldName = "OrderId";
            this.colOrderId.MinWidth = 30;
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 0;
            this.colOrderId.Width = 112;
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.MinWidth = 30;
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 1;
            this.colCustomerId.Width = 112;
            // 
            // colShipName
            // 
            this.colShipName.FieldName = "ShipName";
            this.colShipName.MinWidth = 30;
            this.colShipName.Name = "colShipName";
            this.colShipName.Visible = true;
            this.colShipName.VisibleIndex = 2;
            this.colShipName.Width = 112;
            // 
            // colShipAddress
            // 
            this.colShipAddress.FieldName = "ShipAddress";
            this.colShipAddress.MinWidth = 30;
            this.colShipAddress.Name = "colShipAddress";
            this.colShipAddress.Visible = true;
            this.colShipAddress.VisibleIndex = 3;
            this.colShipAddress.Width = 112;
            // 
            // colShipPostalCode
            // 
            this.colShipPostalCode.FieldName = "ShipPostalCode";
            this.colShipPostalCode.MinWidth = 30;
            this.colShipPostalCode.Name = "colShipPostalCode";
            this.colShipPostalCode.Visible = true;
            this.colShipPostalCode.VisibleIndex = 4;
            this.colShipPostalCode.Width = 112;
            // 
            // colShipCountry
            // 
            this.colShipCountry.FieldName = "ShipCountry";
            this.colShipCountry.MinWidth = 30;
            this.colShipCountry.Name = "colShipCountry";
            this.colShipCountry.Visible = true;
            this.colShipCountry.VisibleIndex = 5;
            this.colShipCountry.Width = 112;
            // 
            // colShipCity
            // 
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.MinWidth = 30;
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.Visible = true;
            this.colShipCity.VisibleIndex = 6;
            this.colShipCity.Width = 112;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.MinWidth = 30;
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 7;
            this.colOrderDate.Width = 112;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 622);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton BtnLoadData;
        private DevExpress.XtraEditors.SimpleButton BtnPrint;
        private DevExpress.XtraEditors.DateEdit DtToDate;
        private DevExpress.XtraEditors.DateEdit DtFromDate;
        private DevExpress.XtraGrid.GridControl GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colShipPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
    }
}