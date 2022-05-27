using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Cages.ORMDataModel2
{

    public partial class PZPEDIDO
    {
        public PZPEDIDO(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
