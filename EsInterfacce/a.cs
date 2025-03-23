//public bool Equals(Persona? other)
//if(other is null) return false;
//return criterio1 == other.criterio1 && ...

//public override bool (object? obj)
//if(obj is null ) return false;
//if(obj is Persona other) return Equals(other)
//return false

//public override int GetHashCode()
//return HashCode.Combine(criterio1, ...);


//public bool CompareTo(Persona? other)
//if(other is null) return 1
//retun Criterio.CompareTo(other.Criterio)

//public bool CompareTo(object? obj)
//if(obj is null) return 1
//if(obj is Persona other) return CompareTo(other)
//throw new ArgumentException("l'oggetto non è una persona", (nameof(obj))) 

//public static bool operator ==(Persona left, Persona right)
//if(left is null) return right is null

//public static bool operator !=(Persona left, Persona right)
//return !(left == right)

//public static bool operator <(Persona left, Persona right)
//if(left is null) return right is not null
//if(right is null) return false
//return left.CompareTo(right) < 0;

//public static bool operator <=(Persona left, Persona right)
//if(left is null) return true
//if(right is null) return false
//return left.CompareTo(right) <= 0;

// public static bool operator >(Persona left, Persona right)
//return right < left;

//public static bool operator >=(Persona left, Persona right)
//return right <= left;



