using System;
using System.Collections.Generic;
using System.Text;

namespace Machi_Koro
{
    class Tafel
    {
        public List<Player> players = new List<Player>();
        public List<Kaart> beschikbareKaarten = new List<Kaart>();
        Random random = new Random();

        public Tafel()
        {
            players = new List<Player>();
            beschikbareKaarten = new List<Kaart>();
        }

        public void GenereerKaarten()
        {
            beschikbareKaarten.Add(new Kaart("Bakkerij", 1, 2, "Ontvang 1 munt van de bank als het jouw beurt is.", true)); // moet eigenlijk 2 en 3 voor rolgetal
            beschikbareKaarten.Add(new Kaart("Supermarkt", 2, 4, "Ontvang 3 munten van de bank als het jouw beurt is.", true));
            beschikbareKaarten.Add(new Kaart("Kaasfabriek", 5, 7, "Ontvang 3 munten van de bank voor elke veehouderij die je bezit als het jouw beurt is.", true));
            beschikbareKaarten.Add(new Kaart("Meubelfabriek", 3, 8, "Ontvang 3 munten van de bank voor elke mijn en bos die je bezit als het jouw beurt is.", true));
            beschikbareKaarten.Add(new Kaart("Groente- en Fruitmarkt", 2, 11, "Ontvang 3 munten van de bank voor elke graanveld en appelboomgaard die je bezit als het jouw beurt is.", true));
            beschikbareKaarten.Add(new Kaart("Graanveld", 1, 1, "Ontvang 1 munt van de bank ongeacht wiens beurt het is.", true)); 
            beschikbareKaarten.Add(new Kaart("Veehouderij", 1, 2, "Ontvang 3 munten van de bank ongeacht wiens beurt het is.", true));
            beschikbareKaarten.Add(new Kaart("Bos", 3, 5, "Ontvang 1 munten van de bank ongeacht wiens beurt het is.", true));
            beschikbareKaarten.Add(new Kaart("Mijn", 6, 9, "Ontvang 5 munten van de bank ongeacht wiens beurt het is.", true));
            beschikbareKaarten.Add(new Kaart("Appelboomgaard", 3, 10, "Ontvang 3 munten van de bank ongeacht wiens beurt het is.", true));
            beschikbareKaarten.Add(new Kaart("Cafe", 2, 3, "Ontvang 1 munt van iedere speler die dit getal gooit.", true)); 
            beschikbareKaarten.Add(new Kaart("Restaurant", 3, 9, "Ontvang 2 munten van iedere speler die dit getal gooit.", true));
            beschikbareKaarten.Add(new Kaart("TV-Station", 7, 6, "Ontvang 5 munten van een speler naar keuze als het jouw beurt is.", false));
            beschikbareKaarten.Add(new Kaart("Bedrijvencomplex", 8, 6, "Je mag 1 kaart met een speler naar kuizen ruilen als het jouw beurt is.", false));
            beschikbareKaarten.Add(new Kaart("Groente- en Fruitmarkt", 6, 6, "Ontvang 2 munten van iedere speler als het jouw beurt is.", false));
            beschikbareKaarten.Add(new Kaart("Radiostation", 22, 0, "Je mag je dobbelstenen eenmaal per beurt opnieuw gooien.", false));
            beschikbareKaarten.Add(new Kaart("Pretpark", 16, 0, "Als je dubbel gooit, ben je direct nog een keer aan de beurt.", false));
            beschikbareKaarten.Add(new Kaart("Winkelcentrum", 10, 0, "Verhoog het aantal munten dat je voor cafe, restaurant, bakkerij en supermarkt kaarten krijgt met 1.", false));
            beschikbareKaarten.Add(new Kaart("Treinstation", 4, 0, "Je mag met twee dobbelstenen gooien.", false));
        }

        public void SpelerToevoegen(int playerCount)
        {
            string playerNaam;
            List<Kaart> _hand = new List<Kaart>();
            _hand.Add(beschikbareKaarten[0]);
            _hand.Add(beschikbareKaarten[5]);

            for (int i = 0; i < playerCount; i++)
            {
                playerNaam = "Player " + (i + 1);
                players.Add(new Player(playerNaam, 3, _hand));
            }
        }

        public int rollDice()
        {
            int dice = random.Next(1, 6);
            return dice;
        }
    }
}
