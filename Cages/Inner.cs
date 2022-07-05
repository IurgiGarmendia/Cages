﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cages
{
    public partial class Inner : Form
    {
        int zenbat = 0; 
        public Inner()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.GetEnumerable += pLinqInstantFeedbackSource1_GetEnumerable;
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.DismissEnumerable += pLinqInstantFeedbackSource1_DismissEnumerable;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Instantiate a new DataContext
            Cages.App_Code.Model.Pzastrabajo dataContext = new Cages.App_Code.Model.Pzastrabajo();
            // Assign a queryable source to the PLinqInstantFeedbackSource
            e.Source = from a in dataContext.DBPztrabajo
                       join b in dataContext.DBLNPLANIF on new{a.PEDIDO, a.O_PED } equals new { b.PEDIDO, b.O_PED }
                       select new { a.CODIGO, a.PEDIDO, a.O_PED,a.POS, KODE=b.CODIGO };
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            e.Tag = dataContext;

            zenbat = (from a in dataContext.DBPztrabajo
                      join b in dataContext.DBLNPLANIF on new { a.PEDIDO, a.O_PED } equals new { b.PEDIDO, b.O_PED }
                      select new { a.CODIGO, a.PEDIDO, a.O_PED, a.POS, KODE = b.CODIGO }).Count();


            label1.Text = "Erregistro kopurua (load eta gero)" + zenbat;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_DismissEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Dispose of the DataContext
            ((Cages.App_Code.Model.Pzastrabajo)e.Tag).Dispose();
        }

        private void Inner_Load(object sender, EventArgs e)
        {
            label1.Text = "Erregistro kopurua " + zenbat;
        }
    }
}
