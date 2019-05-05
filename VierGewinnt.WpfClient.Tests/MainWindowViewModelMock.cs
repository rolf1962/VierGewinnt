using System;
using System.Collections.Generic;
using System.ComponentModel;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    public class MainWindowViewModelMock : IMainWindowViewModel
    {
        public ISpielbrettViewModel SpielbrettViewModel
        {
            get { throw new System.NotImplementedException(); }
        }

        public IReadOnlyList<ISpielerViewModel> SpielerViewModels
        {
            get { throw new System.NotImplementedException(); }
        }

        public string Gewinnername { get; private set; }

        public int AnzahlSpieleZugAufrufe { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SpieleZug(ISpalte spalte)
        {
            AnzahlSpieleZugAufrufe++;
        }

        public void SetzeGewinnername(string name)
        {
            Gewinnername = name;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Gewinnername)));
        }

        public bool WurdeSpieleZugGenauEinmalAufgerufen { get { return AnzahlSpieleZugAufrufe == 1; } }
    }
}