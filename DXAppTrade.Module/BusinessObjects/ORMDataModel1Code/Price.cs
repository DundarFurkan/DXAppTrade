using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace DXAppTrade.Module.BusinessObjects.ORMDataModel1
{
    [DefaultClassOptions, ImageName("BO_PRICE")]
    public partial class Price
    {

        public Price(Session session) : base(session) { }

        public override void AfterConstruction() { base.AfterConstruction(); }


    }

}
