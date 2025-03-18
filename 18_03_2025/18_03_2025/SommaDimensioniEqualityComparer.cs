
using ConfrontoOggettiDemo;
using System.Diagnostics.CodeAnalysis;

namespace _18_03_2025
{
    internal class SommaDimensioniEqualityComparer : EqualityComparer<Box>
    {
        public override bool Equals(Box? x, Box? y)
        {
            //gestione dei valori nulli
            if(x is null && y is null) return true;
            if(x is null || y is null) return false;
            //criterio di uguaglianza aggiuntivo
            var sommaDimensioniX = x.Altezza + x.Larghezza + x.Profondità;
            var sommaDimensioniY = y.Altezza + y.Larghezza + y.Profondità;
            return sommaDimensioniX.Equals(sommaDimensioniY);
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            //bisogna avere coerenza tra il criterio di uguaglianza aggiuntivo
            //e il GetHashCode aggiuntivo --> se due Box sono Equals allora devono anche avere lo stesso hash code
            return HashCode.Combine(obj.Altezza, obj.Larghezza, obj.Profondità);
        }
    }
}
