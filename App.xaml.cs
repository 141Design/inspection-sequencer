using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InspectionSequencer
{
    using InspectionSequencer.Views;
    using InspectionSequencer.ViewModels;
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var inspView = new InspectionView();
            var inspViewModel = new InspectionViewModel();
            var errView = new ErrorView();
            var errViewModel = new ErrorViewModel();

            //ViewModelをデータコンテキストに指定
            inspView.DataContext = inspViewModel;
            errView.DataContext = errViewModel;

            inspView.Show();

        }
    }
}
