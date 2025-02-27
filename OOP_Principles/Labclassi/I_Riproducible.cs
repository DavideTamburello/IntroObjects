using System;

namespace OOPPrinciples.LabClassi;

public interface IRiproducible<T> where T:Felidae
{
    //il metodo Reproduce rappresenta il comportamento dell'interfaccia
    //l'implementazione non va messa nell'interfaccia, ma nella classe che 
    //implementa l'interfaccia (vedi più avanti)
    T[] Reproduce(T mate);

}