using LiveMapApp2.Selectro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LiveMapApp2.ViewModels
{
    public class UnitListViewModel : BaseViewModel
    {
        private ObservableCollection<UnitModelSelector> _unitModelSelectors;
        public ObservableCollection<UnitModelSelector> UnitModelSelectors
        {
            get => _unitModelSelectors;

            set => SetProperty(ref _unitModelSelectors, value);
        }
        public UnitListViewModel()
        {
            LocadUnitModelData();
        }
        private void LocadUnitModelData()
        {
            List<UnitModelSelector> UnitModelList = new List<UnitModelSelector>();
            UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            UnitModelList.Add(new UnitModelSelector()
            {
                IsUnitGroup = true,
                UnitGroupList = new List<UnitModelSelector>() { new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00035G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00042G", UnitStatus = "Status", MOFCompleted = "Yes" },
                new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00043G", UnitStatus = "Status", MOFCompleted = "Yes" },}

            });
          
            //UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            //UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            //UnitModelList.Add(new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00032G", UnitStatus = "Status", MOFCompleted = "Yes" });
            UnitModelList.Add(new UnitModelSelector()
            {
                IsUnitGroup = true,
                UnitGroupList = new List<UnitModelSelector>()
                {   new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00035G", UnitStatus = "Status", MOFCompleted = "Yes" },
                    new UnitModelSelector()
                    {
                    IsUnitGroup = true,
                    UnitGroupList = new List<UnitModelSelector>() { new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00035G", UnitStatus = "Status", MOFCompleted = "Yes" },
                    new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00040G", UnitStatus = "Status", MOFCompleted = "Yes" },
                    new UnitModelSelector() { IsUnitGroup = false, ContractNumber = "EW00041G", UnitStatus = "Status", MOFCompleted = "Yes" },
                    }
                    },
                }

            });
            UnitModelSelectors = new ObservableCollection<UnitModelSelector>(UnitModelList);
        }


        private ICommand _unitSelectedCommand;
        public ICommand UnitSelectedCommand
        {
            get
            {
                return _unitSelectedCommand ?? (_unitSelectedCommand = new Command<object>((selectedItem) =>
                {
                    object keyword = selectedItem as object;

                }));
            }
        }


    }
}
