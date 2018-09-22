using System;
using System.Reactive.Concurrency;
using System.Windows;
using MahApps.Metro.Controls;
using ReactiveUI;
using WpfCustomControl.ViewModels;

namespace WpfCustomControl.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, IViewFor<IMainWindowViewModel>
    {
        protected static DependencyProperty ViewModelProperty = DependencyProperty.Register(nameof(ViewModel),
                                                                                            typeof(IMainWindowViewModel),
                                                                                            typeof(MainWindow),
                                                                                            new PropertyMetadata(default(IMainWindowViewModel)));

        public MainWindow(IMainWindowViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (IMainWindowViewModel) value; }
        }

        public IMainWindowViewModel ViewModel
        {
            get { return (IMainWindowViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
