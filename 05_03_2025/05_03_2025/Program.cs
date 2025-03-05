//pag 836
//polimorfismo = capacità delle reference di comportarsi in maniera differente a seconda dell'oggetto referenziale
//per avere polimorfismo dobbiamo usare una reference di tipo base class e più oggetti di classi derivate
//esempio: uso una reference di tipo felino per "puntare" (referenziare) oggetti di tipo Leone oppure di tipo Leopardo

//coesione
//è uno stile di programmazione ad oggetti
//prevede che le classi siano internamente coese --> all'interno della classe ci sono metodi, proprietà e campi che sono progettati 
//per un task specifico (ad esempio le funzioni matematiche)
//tra classi distinte invece si dovrebbe avere bassa coesione, ossia le classi non dovrebbero dipendere troppo le une dalle altre

//best practices
//si dovrebbe programmare per interfacce, questo vuol dire che quando si utilizzano dei servizi di altre classi si dovrebbe fare 
//riferimento alle interfacce pubbliche che tali classi implementano
// questo stile di programmazione si chiama anche DESIGN BY CONTRACT

//il metodo Equals di Object considera uguali sue oggetti quando hanno lo stesso indirizzo in memoria,
//ossia quando il referenze è lo stesso. se volessimo modificare il comportamento di Equals dovremmo ridefinire il metodo Equals



//analisi degli operatori is e as
//is
//voglio verificare se una data variabile è compatibile con Felino

//if(leone1 is Felino)
//{
//Console.WriteLine("leone1 è un felino");
//}else
//{
//Console.WriteLine("leone1 NON è un felino");
//}

//nell'esempio precedente l'operatore is verifica la compatibilità dei tipi
//ossia verifica che il reference leone1 sia del tipo Felino oppure discende da esso

//if(felino1 is Leone)
//{
//Console.WriteLine("felino1 è un leone");
//}else
//{
//Console.WriteLine("felino1 NON è un leone");
//}

//l'operatore is permette anche di ottenere delle versioni tipizzate di un oggetto
//questa volta facciamo l'esempio con Lion e Felidae perchè Felidae non è astratta


//operatore as
//l'operatore as effettua un cast ma se il cast non è possibile restituisce null

//felidae felinoIs = new Lion(true, 200);
// Lion unLeone = felinoIs as Lion;
//if(unLeone != null)
{
    Console.WriteLine("felinoIs è compatibile con Lion");
}//else
{
    Console.WriteLine("felinoIs è NON compatibile con Lion");
}



//analisi del metodo GetType
//il metodo GetType restituisce il tipo runtime dell'oggetto

//if(felinoIs.GetType() == typeof(Leopardo))
{
    Console.WriteLine("felinoIs è un leopardo");
}//else if(felinoIs.GetType() == typeof(Lion))
{
    Console.WriteLine("felinoIs è un leone");
}

