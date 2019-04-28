using System;

namespace VierGewinnt.WpfClient.SampleData
{
    internal class KlickSpalteCommandDummy : IKlickSpalteCommand
    {
        private readonly int _spaltenindex;
        private bool _canExecute;

        public KlickSpalteCommandDummy(int spaltenindex, bool canExecute)
        {
            this._spaltenindex = spaltenindex;
            this._canExecute = canExecute;
        }

        public int Spaltenindex
        {
            get { return _spaltenindex; }
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}