namespace Cages
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpInstantFeedbackSource1 = new DevExpress.Xpo.XPInstantFeedbackSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colO_PED = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODPZPEDIDO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 266);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpInstantFeedbackSource1
            // 
            this.xpInstantFeedbackSource1.ObjectType = typeof(Cages.ORMDataModel2.PZPEDIDO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPEDIDO,
            this.colO_PED,
            this.colCODPZPEDIDO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colPEDIDO
            // 
            this.colPEDIDO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colPEDIDO.AppearanceCell.Options.UseBackColor = true;
            this.colPEDIDO.FieldName = "PEDIDO";
            this.colPEDIDO.MinWidth = 25;
            this.colPEDIDO.Name = "colPEDIDO";
            this.colPEDIDO.Visible = true;
            this.colPEDIDO.VisibleIndex = 0;
            this.colPEDIDO.Width = 94;
            // 
            // colO_PED
            // 
            this.colO_PED.FieldName = "O_PED";
            this.colO_PED.MinWidth = 25;
            this.colO_PED.Name = "colO_PED";
            this.colO_PED.Visible = true;
            this.colO_PED.VisibleIndex = 1;
            this.colO_PED.Width = 94;
            // 
            // colCODPZPEDIDO
            // 
            this.colCODPZPEDIDO.FieldName = "CODPZPEDIDO";
            this.colCODPZPEDIDO.MinWidth = 25;
            this.colCODPZPEDIDO.Name = "colCODPZPEDIDO";
            this.colCODPZPEDIDO.Visible = true;
            this.colCODPZPEDIDO.VisibleIndex = 2;
            this.colCODPZPEDIDO.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPEDIDO;
        private DevExpress.XtraGrid.Columns.GridColumn colO_PED;
        private DevExpress.XtraGrid.Columns.GridColumn colCODPZPEDIDO;
        private DevExpress.Xpo.XPInstantFeedbackSource xpInstantFeedbackSource1;
    }
}