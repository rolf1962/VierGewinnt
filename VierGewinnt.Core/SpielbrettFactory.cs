using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class SpielbrettFactory
    {
        public Spielbrett Erstelle(int reihenAnzahl, int spaltenAnzahl)
        {
            if (spaltenAnzahl < 2) throw new ArgumentOutOfRangeException(nameof(spaltenAnzahl), "Die Anzahl der Spalten darf nicht kleiner 2 sein.");
            if (reihenAnzahl < 2) throw new ArgumentOutOfRangeException(nameof(reihenAnzahl), "Die Anzahl der Reihen darf nicht kleiner 2 sein.");

            // 2-dimensionlen Array aus Plätzen erzeugen
            var plätze = new Platz[spaltenAnzahl][];

            for (int i = 0; i < spaltenAnzahl; i++)
            {
                plätze[i] = new Platz[reihenAnzahl];

                for (var j = 0; j < reihenAnzahl; j++)
                {
                    plätze[i][j] = new Platz();
                }
            }

            // Spalten
            var spalten = new List<Spalte>();
            for (int i = 0; i < spaltenAnzahl; i++)
            {
                var spaltenPlätze = new List<Platz>();

                for (int j = 0; j < reihenAnzahl; j++)
                {
                    spaltenPlätze.Add(plätze[i][j]);
                }

                spalten.Add(new Spalte(spaltenPlätze));
            }

            // Reihen 
            var reihen = new List<Reihe>();
            for (int j = 0; j < reihenAnzahl; j++)
            {
                var reihenPlätze = new List<Platz>();

                // Video: 12:48

                reihen.Add(new Reihe(reihenPlätze));
            }

            // Diagonalen 

            // Spielbrett initialisieren
        }
    }
}
