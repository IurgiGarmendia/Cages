using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XpoDefault.ConnectionString = FirebirdConnectionProvider.GetConnectionString("localhost", "SYSDBA", "masterkey", @"C:\gdb\LaserKen\GESTOR.GDB");


            // This line of code is generated by Data Source Configuration Wizard
            this.xpInstantFeedbackSource1.ResolveSession += xpInstantFeedbackSource1_ResolveSession;
            // This line of code is generated by Data Source Configuration Wizard
            this.xpInstantFeedbackSource1.DismissSession += xpInstantFeedbackSource1_DismissSession;
        }

        // This event is generated by Data Source Configuration Wizard
        void xpInstantFeedbackSource1_ResolveSession(object sender, ResolveSessionEventArgs e)
        {

            // Assign a session to the Session property,
            e.Session = new DevExpress.Xpo.UnitOfWork();
        }

        // This event is generated by Data Source Configuration Wizard
        void xpInstantFeedbackSource1_DismissSession(object sender, ResolveSessionEventArgs e)
        {

            // Here you can dismiss the session instance you have assigned to the ResolveSessionEventArgs.Session property in the ResolveSession event handler.
            IDisposable session = e.Session as IDisposable;
            if (session != null)
                session.Dispose();
        }

        // This event is generated by Data Source Configuration Wizard

    }
}
