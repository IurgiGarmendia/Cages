namespace Cages
{
    partial class DbLotData
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
            this.colPOS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO_PED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "CODIGO ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(Cages.App_Code.Model.Pztrabajo);
            this.entityInstantFeedbackSource1.KeyExpression = "CODIGO;POS";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODIGO,
            this.colPOS,
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
            // colPOS
            // 
            this.colPOS.FieldName = "POS";
            this.colPOS.MinWidth = 25;
            this.colPOS.Name = "colPOS";
            this.colPOS.Visible = true;
            this.colPOS.VisibleIndex = 1;
            this.colPOS.Width = 94;
            // 
            // colPEDIDO
            // 
            this.colPEDIDO.FieldName = "PEDIDO";
            this.colPEDIDO.MinWidth = 25;
            this.colPEDIDO.Name = "colPEDIDO";
            this.colPEDIDO.Visible = true;
            this.colPEDIDO.VisibleIndex = 2;
            this.colPEDIDO.Width = 94;
            // 
            // colO_PED
            // 
            this.colO_PED.FieldName = "O_PED";
            this.colO_PED.MinWidth = 25;
            this.colO_PED.Name = "colO_PED";
            this.colO_PED.Visible = true;
            this.colO_PED.VisibleIndex = 3;
            this.colO_PED.Width = 94;
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "CODIGO ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Cages.App_Code.Model.Pztrabajo);
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "CODIGO ASC";
            this.entityServerModeSource1.ElementType = typeof(Cages.App_Code.Model.Pztrabajo);
            this.entityServerModeSource1.KeyExpression = "CODIGO;POS";
            // 
            // DbLotData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "DbLotData";
            this.Text = "DbLotData";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn colPOS;
        private DevExpress.XtraGrid.Columns.GridColumn colPEDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colO_PED;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
    }
}