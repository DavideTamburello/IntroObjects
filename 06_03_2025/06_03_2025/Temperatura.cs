namespace _06_03_2025
//se si implementa IComparables<T> è possibile fare l'override degli operatori
{
    internal class Temperatura : IComparable, IComparable<Temperatura>
    {
        //internamente la classe Temperatura memorizza la temperatura in gradi
        //Fahreneit
        protected double temperaturaF;
        public double Fahreneit
        {
            get
            {
                return temperaturaF;
            }
            set
            {
                temperaturaF = value;
            }
        }
        
        public double Celsius
        {
            get
            {
                return (temperaturaF - 32) * (5.0 / 9);
            }
            set
            {
                temperaturaF = (value*9.0/5)+32;
            }
        }
        public Temperatura(double celsius)
        {
            Celsius = celsius;
        }
        public int CompareTo(object? obj)
        {
            if(obj == null) //oppure obj is null
            {
                return 1; //vuol dire che this (che è non nullo) è maggiore di null
            }
            Temperatura objTemperatura = obj as Temperatura;
            if(objTemperatura is not null) //oppure objTemperatura != null
            {
                return temperaturaF.CompareTo(objTemperatura.temperaturaF);

            }else //l'oggetto obj non è una temperatura
            {
                throw new ArgumentException("object non è una temperatura");
            }
        }

        //versione tipizzata del CompareTo
        public int CompareTo(Temperatura? other)
        {
            if(other == null)
            {
                return 1;
            }
            return temperaturaF.CompareTo(other.temperaturaF);
        }

    }
}
