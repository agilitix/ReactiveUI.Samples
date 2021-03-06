﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using WpfCustomControl.Models;

namespace WpfCustomControl.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IMainWindowViewModel
    {
        private readonly IScheduler _scheduler;
        private readonly ITimerModel _model;
        private readonly CompositeDisposable _disposables = new CompositeDisposable();
        private string _dateInfo;

        public string DateInfo
        {
            get { return _dateInfo; }
            set { this.RaiseAndSetIfChanged(ref _dateInfo, value); }
        }

        public MainWindowViewModel(IScheduler scheduler, ITimerModel model)
        {
            _scheduler = scheduler;
            _model = model;

            _disposables.Add(_model.CurrentDateTime
                                   .Select(dt => dt.ToString("yyyy-MM-dd HH:mm:ss"))
                                   .ObserveOn(_scheduler)
                                   .Subscribe(x => DateInfo = x));
        }

        public void Dispose()
        {
            _disposables?.Dispose();
        }
    }
}
