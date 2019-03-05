
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LiveMapApp2.Selectro
{
    public class TemplateSelector : DataTemplateSelector
    {
       // public DataTemplate MoreThanFour { get; set; }
        public DataTemplate NormalTemplate { get; set; }
        public DataTemplate UnitGroupTemplate { get; set; }
         
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var wallModel = (UnitModelSelector)item;
            if (wallModel.IsUnitGroup)
            {
                return UnitGroupTemplate;
            }
            return NormalTemplate;
        }
    }
    public class UnitModelSelector
    {
        public bool IsUnitGroup { get; set; }
        public bool UnitListVisiblity { get; set; }
        public List<UnitModelSelector> UnitGroupList { get; set; }
        public string ContractNumber { get; set; }
        public string  UnitStatus { get; set; }
        public string MOFCompleted { get; set; }

    }
}
