using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ClientOA
{
    /// <summary>
    /// Shell2.xaml 的交互逻辑
    /// </summary>
    //[Export]
    public partial class Shell2 : Window
    {
        public Shell2()
        {
            InitializeComponent();
           
        }

        private bool isLayerMenuShow = false;//标记图层选择按钮是否展开
        /// <summary>
        /// IsLayerMenuShow设置为true时播放展开墒情动画，false则播放关闭动画
        /// </summary>
        public bool IsLayerMenuShow
        {
            get { return isLayerMenuShow; }
            set
            {
                isLayerMenuShow = value;
                if (isLayerMenuShow)
                {
                    Storyboard ArcMenuShowStoryboard = (Storyboard)this.Resources["CircleMenuShow"];
                    ArcMenuShowStoryboard.Begin();
                }
                else
                {
                    Storyboard ArcMenuShowStoryboard = (Storyboard)this.Resources["CircleMenuHidden"];
                    ArcMenuShowStoryboard.Begin();
                }
            }
        }

        private void SelectLayer_Click(object sender, RoutedEventArgs e)
        {
            IsLayerMenuShow = !IsLayerMenuShow;
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsLayerMenuShow = !IsLayerMenuShow;
        }
    }
}
