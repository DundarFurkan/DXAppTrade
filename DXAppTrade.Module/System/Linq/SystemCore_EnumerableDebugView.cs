using DevExpress.Xpo;
using DXAppTrade.Module.BusinessObjects.ORMDataModel1;

namespace System.Linq
{
    internal class SystemCore_EnumerableDebugView<T>
    {
        private XPCollection<Price> prices;

        public SystemCore_EnumerableDebugView(XPCollection<Price> prices)
        {
            this.prices = prices;
        }
    }
}