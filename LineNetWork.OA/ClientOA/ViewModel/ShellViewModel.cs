using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Commands;
using System.ComponentModel;
using System.Collections.ObjectModel;
using ClientOA.Model;
using MaterialDesignThemes.Wpf;
namespace ClientOA.ViewModel
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {
            Init();
        }

        #region 属性
        private ObservableCollection<HomePageInfo> menuItems;

        public ObservableCollection<HomePageInfo> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; this.SetProperty(ref menuItems, value); }
        }
        #endregion

        #region 命令
        private DelegateCommand apiCommand;

        public DelegateCommand ApiCommand
        {
            get
            {
                if (apiCommand == null)
                {
                    apiCommand = new DelegateCommand(() =>
                    {
                        Shell wind = new Shell();
                        wind.Show();
                    });
                }
                return apiCommand;
            }
        }
        #endregion

        #region 方法
        private void Init()
        {
            MenuItems = new ObservableCollection<HomePageInfo> 
            {
                new HomePageInfo{Id=1,Name="首页",Iocn=PackIconKind.AccessPoint},
                new HomePageInfo{Id=2,Name="工作流程",Iocn=PackIconKind.AccessPointNetwork},
                new HomePageInfo{Id=3,Name="任务管理",Iocn=PackIconKind.Table},
                new HomePageInfo{Id=4,Name="员工管理",Iocn=PackIconKind.Account},
                new HomePageInfo{Id=5,Name="系统设置",Iocn=PackIconKind.Sale},
                new HomePageInfo{Id=6,Name="更多",Iocn=PackIconKind.More},
            };
        }
        #endregion
    }
}
