using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DXAppTrade.Module.BusinessObjects.ORMDataModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXAppTrade.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController1 : ViewController
    {
        public ViewController1()
        {


            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }


        protected override void OnActivated()
        {
            var Collection = this.ObjectSpace.CreateCollection(typeof(EquityTest), null);
            foreach (EquityTest item in Collection)
            {

                var Collection2 = this.ObjectSpace.CreateCollection(typeof(Price), null);
                foreach (Price item2 in Collection2)
                {
                    if (item == item2.EquityTest)
                    {
                        var max = 0;
                        var tmpItem = item2;

                        foreach (Price item3 in Collection2)
                        {
                            if (item2.EquityTest == item3.EquityTest)
                            {
                                var date = item3.Date.ToString("yyyy-M-d").Replace(@"-", "");
                                var dateInt = Int32.Parse(date);
                                if (max < dateInt)
                                {
                                    max = dateInt;
                                    tmpItem = item3;
                                }

                            }
                        }
                        item.PercentageChange = ((item.LastPrice / tmpItem.Close) - 1) * 100;

                        //var zaman= liste.OrderByDescending(x => x).ToList();
                        // foreach (var cityName in zaman)
                        //     Console.Write(cityName);


                    }

                }

            }
            base.OnActivated();

            //var Collection = this.View.ObjectSpace.CreateCollection(typeof(Price), null);
            //var Collection2 = this.View.ObjectSpace.CreateCollection(typeof(EquityTest), null);
            
          

            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            
            //var Collection = this.ObjectSpace.CreateCollection(typeof(Price), null);

            //foreach (Price item in Collection)
            //{
              
            //    Console.WriteLine("Close fiyatı =" + item.Close);
            //    Console.WriteLine("Equity fiyatı =" + item.EquityTest.LastPrice);
               
            //}
            //var Collection2 = this.ObjectSpace.CreateCollection(typeof(EquityTest), null);
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void CreateColletion_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            //var Collection = this.View.ObjectSpace.CreateCollection(typeof(Price), null);
            //foreach (Price item in Collection)
            //{
            //    Console.WriteLine(item.Close);
            //}

           
        }



    }
}
