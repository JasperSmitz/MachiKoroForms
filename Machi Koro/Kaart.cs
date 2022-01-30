using System;
using System.Collections.Generic;
using System.Text;

namespace Machi_Koro
{
    class Kaart
    {
        public string naam;
        public int kosten;
        public List<int> rolGetallen = new List<int>();
        public string beschrijving;
        public bool koopMeerdere;

        public Kaart(string _naam, int _kosten, int _rolGetallen, string _beschrijving, bool _koopMeerdere)
        {
            naam = _naam;
            kosten = _kosten;
            rolGetallen = new List<int>(_rolGetallen);
            beschrijving = _beschrijving;
            koopMeerdere = _koopMeerdere;
        }

        public void Effect(Player player)
        {
            switch (naam)
            {
                case "Bakkerij":
                    // Als het de beurt van de speler is met deze kaart krijgen ze 1 munt
                    player.geld = player.geld + 1;
                    break;
                case "Supermarkt":
                    // Als het de beurt is van de speler met deze kaart krijgen ze 3 munten
                    player.geld = player.geld + 3;
                    break;
                case "Kaasfabriek":
                    // Als het de beurt is van de speler met deze kaart, krijg 3 munten voor elke veehouderij in bezit

                case "Meubelfabriek":
                    // als het de beurt is van de speler met deze kaart, krijg 3 munten voor elke mijn en bos in bezit

                case "Groente- en Fruitmarkt":
                    // als het de beurt is van de speler met deze kaart, krijg 2 munten voor elke graanveld of appelboomgaard in bezit

                case "Graanveld":
                    // Iedereen met deze kaart krijgt 1 munt

                case "Veehouderij":
                    // Iedereen met deze kaart krijgt 1 munt

                case "Bos":
                    // iedereen met deze kaart krijgt 1 munt

                case "Mijn":
                    // iedereen met deze kaart krijgt 5 munten

                case "Appelboomgaard":
                    // iedereen met deze kaart krijgt 3 munten

                case "Cafe":
                    // iedereen met deze kaart krijgt 1 munten van de speler wiens beurt het is

                case "Restaurant":
                    // iedereen met deze kaart krijgt 2 munten van de speler wiens beurt het is

                case "TV-Station":
                    // als het de beurt is van de speler met deze kaart, krijg 5 munten van een speler naar keuze

                case "Bedrijvencomplex":
                    // als het de beurt is van de speler met deze kaart, mag een kaart ruilen met een speler naar keuze

                case "Stadion":
                    // als het de beurt is van de speler met deze kaart, krijg 2 munten van iedere speler

                case "Radiostation":
                    // dobbelsteen opnieuw rollen

                case "Pretpark":
                    // dubbel gooien kom je direct weer aan de beurt

                case "Winkelcentrum":
                    // verhoog het aantal munten dat je voor cafe, restaurant, bakkerij en supermarkt krijgt

                case "Treinstation":
                    // twee dobbelstenen beschikbaar

                default:
                    break;
            }
        }
    }
}
