using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cages.App_Code.Model
{
    [Persistent("PZPEDIDO")]
    public class PZPEDIDO : XPLiteObject
    {
        //public ANDROID_CAGE(Session session) : base(session) { }
        //public System.Int32 IDCAGE
        //{

        //    get { return fIDCAGE; }
        //    set
        //    {
        //        SetPropertyValue(nameof(IDCAGE), ref fIDCAGE, value);
        //    }
        //}
        //System.Int32 fIDCAGE;



        //public System.String AREA
        //{

        //    get { return fAREA; }
        //    set
        //    {
        //        SetPropertyValue(nameof(IDCAGE), ref fAREA, value);
        //    }
        //}
        //System.String fAREA;

        public PZPEDIDO(Session session) : base(session) { }
        [Key, DevExpress.Xpo.DisplayName("CODPZPEDIDO")]
        public System.Int32 CODPZPEDIDO;
        [DevExpress.Xpo.DisplayName("PEDIDO")]
        public System.Int32 PEDIDO;
        [DevExpress.Xpo.DisplayName("O_PED")]
        public string O_PED;



    }
}
