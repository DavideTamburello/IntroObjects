using System;

namespace Cap14Es1;

public class Studente
{
	//le costanti vengono definite al tempo di compilazione - in fase statica
	public const double PI = 3.1415926535897932385;
	//le variabili di tipo readonly vengono definite in fase di esecuzione:
	//una volta che è stato definito il loro valore non non possono più essere modificate
	public readonly double Size;


	//full name, course, subject, university, e-mail and phone number
	//per i campi di una classe la visibilità di default è private\
	private string fullName;
	private string course;
	private string subject;
	private string university;
	private string eMail;
	private string phoneNumber;

	public Studente(string _fullName, string course, string subject, string university, string eMail, string phoneNumber)
	{
		fullName = _fullName;
		this.course = course;
		this.subject = subject;
		this.university = university;
		this.eMail = eMail;
		this.phoneNumber = phoneNumber;
		Size= 10;
	}
	public Studente()
	{
		
	}

	//properties --> c'è una property per un campo
	//per quale motivo creiamo le properties e anche i campi associati?
	//Information Hiding 
	// --> di un oggetto devo nascondere la complessità interna
	// --> l'utilizzo di un oggetto dovrebbe prescindere dalla sua implementazione.
	//--> ci interessa conoscere solo le componenti pubbliche dell'oggetto e non come è "fatto dentro"
	 
	public string FullName { get => fullName; set => fullName = value; }
	public string Course { get => course; set => course = value; }
	public string Subject { get => subject; set => subject = value; }
	public string University { get => university; set => university = value; }
	public string EMail { get => eMail; set => eMail = value; }
	public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

	//auto properties
	//il compilatore crea una variabile (field) nascosto associato alla property

	public override string ToString()
	{
		return $"Full Name = {FullName}";
	}


	
}