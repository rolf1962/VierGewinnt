using System.Windows.Input;

namespace VierGewinnt.WpfClient
{
    public interface IKlickSpalteCommand : ICommand
    {
        int Spaltenindex { get; }
    }
}