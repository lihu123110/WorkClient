using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Commands;
namespace ClientOA.ViewModel
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {

        }

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
    }
}
