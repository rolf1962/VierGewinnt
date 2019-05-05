using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class KlickSpalteCommand : IKlickSpalteCommand
    {
        private readonly ISpalte _spalte;
        private readonly IMainWindowViewModel _mainWindowViewModel;

        public KlickSpalteCommand(ISpalte spalte, IMainWindowViewModel mainWindowViewModel)
        {
            if (spalte == null) { throw new ArgumentNullException(nameof(spalte)); }
            if (mainWindowViewModel == null) { throw new ArgumentNullException(nameof(mainWindowViewModel)); }

            _spalte = spalte;
            _mainWindowViewModel = mainWindowViewModel;
            _mainWindowViewModel.PropertyChanged += MainWindowViewModelOnPropertyChanged;
        }

        private void MainWindowViewModelOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == nameof(IMainWindowViewModel.Gewinnername))
            {
                OnCanExecuteChanged();
            }
        }

        private void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

        public int Spaltenindex
        {
            get
            {
                return _spalte.Index;
            }
        }

        public bool CanExecute(object parameter)
        {
            return string.IsNullOrEmpty(_mainWindowViewModel.Gewinnername) && _spalte.IstSpalteVoll == false;
        }

        public void Execute(object parameter)
        {
            _mainWindowViewModel.SpieleZug(_spalte);
            if(_spalte.IstSpalteVoll)
            {
                OnCanExecuteChanged();
            }
        }
    }
}
