namespace Cages
{
    partial class FrmNotGlobalDB
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
            this.colIDCAGE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAREA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colESTANTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Cages.App_Code.Model.KAJA);
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
            this.entityInstantFeedbackSource1.DefaultSorting = "IDCAGE ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(Cages.App_Code.Model.KAJA);
            this.entityInstantFeedbackSource1.KeyExpression = "IDCAGE";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCAGE,
            this.colAREA,
            this.colESTANTE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colIDCAGE
            // 
            this.colIDCAGE.FieldName = "IDCAGE";
            this.colIDCAGE.MinWidth = 25;
            this.colIDCAGE.Name = "colIDCAGE";
            this.colIDCAGE.Visible = true;
            this.colIDCAGE.VisibleIndex = 0;
            this.colIDCAGE.Width = 94;
            // 
            // colAREA
            // 
            this.colAREA.FieldName = "AREA";
            this.colAREA.MinWidth = 25;
            this.colAREA.Name = "colAREA";
            this.colAREA.Visible = true;
            this.colAREA.VisibleIndex = 1;
            this.colAREA.Width = 94;
            // 
            // colESTANTE
            // 
            this.colESTANTE.FieldName = "ESTANTE";
            this.colESTANTE.MinWidth = 25;
            this.colESTANTE.Name = "colESTANTE";
            this.colESTANTE.Visible = true;
            this.colESTANTE.VisibleIndex = 2;
            this.colESTANTE.Width = 94;
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "IDCAGE ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Cages.App_Code.Model.KAJA);
            // 
            // FrmNotGlobalDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmNotGlobalDB";
            this.Text = "FrmNotGlobalDB";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCAGE;
        private DevExpress.XtraGrid.Columns.GridColumn colAREA;
        private DevExpress.XtraGrid.Columns.GridColumn colESTANTE;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
    }
}