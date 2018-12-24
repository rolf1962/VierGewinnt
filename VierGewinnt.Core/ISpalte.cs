namespace VierGewinnt.Core
{
    public interface ISpalte
    {
        void LasseSpielsteinFallen(Spielstein spielstein);
        bool IstSpalteVoll { get; }
    }
}