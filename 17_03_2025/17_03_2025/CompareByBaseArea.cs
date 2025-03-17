
using ConfrontoOggettiDemo;

namespace _17_03_2025

//per creare ordinamenti aggiuntivi su una classe andiamo a estendere la classe astratta CompareTo()

{
    internal class CompareByBaseArea : Comparer<Box>
    {
        public override int Compare(Box? x, Box? y)
        {
            //gestione dei valorei nulli - tutti i casi
            if (x is null && y is null)
            {
                return 0;
            }else if(x is null) //x è null ma y no
            {
                return -1;
            }else if (y is null) //y è nullo ma x no
            {
                return 1;
            }
            
            //se sono qui nessuno dei 2 parametri è null
            //il criterio è l'area di base
            var areaBaseX = x.Larghezza * x.Profondità;
            var areaBaseY = y.Larghezza * y.Profondità;
            return areaBaseX.CompareTo(areaBaseY);


        }
    }
}
