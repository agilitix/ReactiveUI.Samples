using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ReactiveUI;
using WpfCustomControl.ViewModels;

namespace WpfCustomControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, IViewFor<MainWindowViewModel>
    {
        protected static DependencyProperty ViewModelProperty = DependencyProperty.Register(nameof(ViewModel),
                                                                                            typeof(MainWindowViewModel),
                                                                                            typeof(MainWindow),
                                                                                            new PropertyMetadata(default(MainWindowViewModel)));

        public MainWindow(IScheduler scheduler)
        {
            InitializeComponent();

            ViewModel = new MainWindowViewModel(scheduler);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (MainWindowViewModel) value; }
        }

        public MainWindowViewModel ViewModel
        {
            get { return (MainWindowViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Dispose();
            Close();
        }
    }
}
