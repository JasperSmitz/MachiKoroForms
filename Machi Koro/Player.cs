using System;
using System.Collections.Generic;
using System.Text;

namespace Machi_Koro
{
    class Player
    {
        public string naam;
        public int geld;
        public bool isBeurt;
        public List<Kaart> hand = new List<Kaart>();

        public Player(string _naam, int _geld, List<Kaart> _hand)
        {
            naam = _naam;
            geld = _geld;
            isBeurt = false;
            hand = _hand;
        }

        public void KoopKaart()
        {

        }
    }
}
