using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11_03_2025
{
    internal class Box
    {
        double larghezza;
        double profondità;
        double altezza;

        public Box(double larghezza, double profondità, double altezza)
        {
            this.larghezza = larghezza;
            this.profondità = profondità;
            this.altezza = altezza;
        }

        public double Larghezza { get => larghezza; set => larghezza = value; }
        public double Profondità { get => profondità; set => profondità = value; }
        public double Altezza { get => altezza; set => altezza = value; }

        //due box sono uguali se hanno le stesse dimensioni
        //other = l'altra box
        //return = true se le due box hanno le stesse dimensioni
        public bool Equals(Box? other)
        {
            if (other is null)
            {
                return false;
            }
            return larghezza == other.larghezza && profondità == other.profondità && altezza == other.altezza;
        }

        public override bool Equals(object? obj)
        {
            //gestione casi nulli
            if (obj is null)
            {
                return false;
            }
            //verifichiamo se obj è di tipo Box e nel caso verifico l'uguaglianza
            //se obj non è Box restituisco false
            if (obj is Box other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            //utilizziamo un criterio coerente per la definizione dell'Equals e del GetHashCode
            return HashCode.Combine(larghezza, profondità, altezza);
        }

        public static bool operator ==(Box left, Box right)
        {
            //gestire i casi nulli
            if (left is null)
            {
                return right is null;
            }
            //usare Equals per l'uguaglianza
            return left.Equals(right);
        }
        public static bool operator !=(Box left, Box right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{{{nameof(Larghezza)}: {Larghezza}, {nameof(Profondità)}: {Profondità}, {nameof(Altezza)}: {Altezza}, {nameof(Volume)}: {Volume}}}";
        }
    }
}