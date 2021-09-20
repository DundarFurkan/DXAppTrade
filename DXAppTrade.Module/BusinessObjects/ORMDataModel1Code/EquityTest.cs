using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DXAppTrade.Module.BusinessObjects.ORMDataModel1;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using System.Collections;

namespace DXAppTrade.Module.BusinessObjects.ORMDataModel1
{

    [DefaultClassOptions, ImageName("BO_EQUITY")]
    public partial class EquityTest 
    {
        public EquityTest(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }



        [Action(Caption = "Show High Low")]
        public void Popup(/*Popup parameters*/)
        {

        }

    }


    [DomainComponent]
    public class Popup
    {
        public Popup(EquityTest equitypop)
        {


            // Burada price nesnesinin verilerine ulaşamadıgım için Barkın beyin yardımıyla pop-up u yapmıştık fakat verileri ViewControllerda veri
            //çekme işlemi ile aynı yapmayı düşündüm fakat olmadı. Pop-up nesnesi de sadece tek bir nesne sınıfı aldıgı için Price sınıfını göndere-
            //medim. Bu yüzden case in bu kısmını tamamlayamadım.

            //Diger bütün işlevler çalışıyor.

            LowestPrice = equitypop.LastPrice;
            
            //Price price1 =.GetObjectByKey<Price>(equitypop.Name);

        }


        public DateTime LowestPriceDate { get; set; }
        public DateTime HighPriceDate { get; set; }
        public Double LowestPrice { get; set; }
        public Double HighPrice { get; set; }




        //public uint PostponeForDays { get; set; }
        //[Size(SizeAttribute.Unlimited)]
        //public string Comment { get; set; }
    }



}
