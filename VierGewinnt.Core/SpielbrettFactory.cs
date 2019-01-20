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

                for (int i = 0; i < spaltenAnzahl; i++)
                {
                    reihenPlätze.Add(plätze[i][j]);
                }
                reihen.Add(new Reihe(reihenPlätze));
            }

            // Diagonalen 
            var diagonalen = new List<Diagonale>();

            // Diagonalen von links oben nach rechts unten

            for (int i = 0; i < spaltenAnzahl; i++)
            {
                int spaltenIndex = i;
                int reihenIndex = 0;

                var diagonalenPlätze = new List<Platz>();

                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }

                if (diagonalenPlätze.Count >= 4)
                {
                    diagonalen.Add(new Diagonale(diagonalenPlätze));
                }
            }

            for (int j = 1; j < reihenAnzahl; j++)
            {
                int spaltenIndex = 0;
                int reihenIndex = j;

                var diagonalenPlätze = new List<Platz>();

                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }

                if (diagonalenPlätze.Count >= 4)
                {
                    diagonalen.Add(new Diagonale(diagonalenPlätze));
                }
            }

            // Diagnalen von rechts oben nach links unten
            for (int i = 0; i < spaltenAnzahl; i++)
            {
                int spaltenIndex = i;
                int reihenIndex = 0;

                var diagonalenPlätze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }

                if (diagonalenPlätze.Count >= 4)
                {
                    diagonalen.Add(new Diagonale(diagonalenPlätze));
                }
            }

            for(int j = 1; j < reihenAnzahl; j++)
            {
                int spaltenIndex = spaltenAnzahl - 1;
                int reihenIndex = j;

                var diagonalenPlätze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlätze.Add(plätze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }

                if (diagonalenPlätze.Count >= 4)
                {
                    diagonalen.Add(new Diagonale(diagonalenPlätze));
                }
            }

            // Spielbrett initialisieren
            return new Spielbrett(plätze, reihen, spalten, diagonalen);
        }
    }
}
