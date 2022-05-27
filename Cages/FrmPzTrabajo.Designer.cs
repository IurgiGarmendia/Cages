namespace Cages
{
    partial class FrmPzTrabajo
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO_PED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource2 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODIGO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEDIDO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO_PED1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(397, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = null;
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(Cages.App_Code.Model.LNPLANIF);
            this.entityInstantFeedbackSource1.KeyExpression = "CODIGO";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODIGO,
            this.colPEDIDO,
            this.colO_PED});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colCODIGO
            // 
            this.colCODIGO.FieldName = "CODIGO";
            this.colCODIGO.MinWidth = 25;
            this.colCODIGO.Name = "colCODIGO";
            this.colCODIGO.Visible = true;
            this.colCODIGO.VisibleIndex = 0;
            this.colCODIGO.Width = 94;
            // 
            // colPEDIDO
            // 
            this.colPEDIDO.FieldName = "PEDIDO";
            this.colPEDIDO.MinWidth = 25;
            this.colPEDIDO.Name = "colPEDIDO";
            this.colPEDIDO.Visible = true;
            this.colPEDIDO.VisibleIndex = 1;
            this.colPEDIDO.Width = 94;
            // 
            // colO_PED
            // 
            this.colO_PED.FieldName = "O_PED";
            this.colO_PED.MinWidth = 25;
            this.colO_PED.Name = "colO_PED";
            this.colO_PED.Visible = true;
            this.colO_PED.VisibleIndex = 2;
            this.colO_PED.Width = 94;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.entityInstantFeedbackSource2;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(399, 450);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // entityInstantFeedbackSource2
            // 
            this.entityInstantFeedbackSource2.DefaultSorting = null;
            this.entityInstantFeedbackSource2.DesignTimeElementType = typeof(Cages.App_Code.Model.Pztrabajo);
            this.entityInstantFeedbackSource2.KeyExpression = "CODIGO;POS";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODIGO1,
            this.colPOS,
            this.colPEDIDO1,
            this.colO_PED1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // colCODIGO1
            // 
            this.colCODIGO1.FieldName = "CODIGO";
            this.colCODIGO1.MinWidth = 25;
            this.colCODIGO1.Name = "colCODIGO1";
            this.colCODIGO1.Visible = true;
            this.colCODIGO1.VisibleIndex = 0;
            this.colCODIGO1.Width = 94;
            // 
            // colPOS
            // 
            this.colPOS.FieldName = "POS";
            this.colPOS.MinWidth = 25;
            this.colPOS.Name = "colPOS";
            this.colPOS.Visible = true;
            this.colPOS.VisibleIndex = 1;
            this.colPOS.Width = 94;
            // 
            // colPEDIDO1
            // 
            this.colPEDIDO1.FieldName = "PEDIDO";
            this.colPEDIDO1.MinWidth = 25;
            this.colPEDIDO1.Name = "colPEDIDO1";
            this.colPEDIDO1.Visible = true;
            this.colPEDIDO1.VisibleIndex = 2;
            this.colPEDIDO1.Width = 94;
            // 
            // colO_PED1
            // 
            this.colO_PED1.FieldName = "O_PED";
            this.colO_PED1.MinWidth = 25;
            this.colO_PED1.Name = "colO_PED1";
            this.colO_PED1.Visible = true;
            this.colO_PED1.VisibleIndex = 3;
            this.colO_PED1.Width = 94;
            // 
            // FrmPzTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmPzTrabajo";
            this.Text = "FrmPzTrabajo";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn colPEDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colO_PED;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO1;
        private DevExpress.XtraGrid.Columns.GridColumn colPOS;
        private DevExpress.XtraGrid.Columns.GridColumn colPEDIDO1;
        private DevExpress.XtraGrid.Columns.GridColumn colO_PED1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource2;
    }
}