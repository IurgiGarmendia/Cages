using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cages.App_Code.Model
{
    [Persistent("ANDROID_CAGE")]
    class ANDROID_CAGE : XPLiteObject
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

        public ANDROID_CAGE(Session session) : base(session) { }
        [Key, DevExpress.Xpo.DisplayName("IDCAGE")]
        public System.Int32 IDCAGE;
        [DevExpress.Xpo.DisplayName("AREA")]
        public string AREA;
        [DevExpress.Xpo.DisplayName("ESTANTE")]
        public string ESTANTE;
    }
}