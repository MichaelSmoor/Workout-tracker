using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout_tracker
{
    //List class voor opgehaalde resultaten
    class Resultaten
    {
        private string oefening;
        private int sets;
        private int herhalingen;
        private int gewicht;
        private string commentaar;

        public Resultaten(string oefening, int sets, int herhalingen, int gewicht, string commentaar)
        {
            this.oefening = oefening;
            this.sets = sets;
            this.herhalingen = herhalingen;
            this.gewicht = gewicht;
            this.commentaar = commentaar;
        }

        public string Oefening
        {
            get { return oefening; }
        }

        public int Sets
        {
            get { return sets; }
        }

        public int Herhalingen
        {
            get { return herhalingen; }
        }

        public int Gewicht
        {
            get { return gewicht; }
        }

        public string Commentaar
        {
            get { return commentaar; }
        }
    }
}
