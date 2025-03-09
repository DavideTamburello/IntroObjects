using System;

namespace EsercitazioneClassi1;

public abstract class Veicolo
{
    public string Targa { get; set; }
    public string Modello { get; set; }
    static int NumeroVeicoli { get; set; }
    public double Velocità { get; set; }
    public double Accelerazione { get; set; }
    public double MetriPercorsi { get; set; }

    abstract void Accelera(double deltaAccelerazione, double deltaTempo)
    {
        //permette di incrementare la velocità applicando una accelerazione per un deltaTempo
    
    }
    abstract void Frena(double deltaDecelerazione, double deltaTempo)
    {
        //permette di ridurre la velocità applicando una decelerazione per un deltaTempo.

    }
    abstract void MantieniVelocità(double deltaTempo)
    {
        //mantiene la velocità costante per il deltaTempo

    }
    void ToString()
    {

    }

    public Veicolo(string targa, string modello, double velocità, double accelerazione, double metriPercorsi)
    {
        Targa = targa;
        Modello = modello;
        Velocità = velocità;
        Accelerazione = accelerazione;
        MetriPercorsi = metriPercorsi;
    }
    public Veicolo(string targa, string modello)
    {
        
    }
}
