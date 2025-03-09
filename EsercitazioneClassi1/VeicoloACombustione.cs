using System;

namespace EsercitazioneClassi1;

public class VeicoloACombustione : Veicolo
{
    Random gen = new Random();
    int carburante = gen.Next(1, 51);

    abstract void Accelera(double deltaAccelerazione, double deltaTempo)
    {
        //permette di incrementare la velocità applicando una accelerazione per un deltaTempo
        accelerazione = accelerazione +deltaAccelerazione;
        velocità = velocità + accelerazione*deltaTempo;
        metriPercorsi = metriPercorsi +velocità*deltaTempo;
        carburante = carburante - 0.008* accelerazione*deltaTempo;
        //se il carburante va a 0 il veicolo deve fermarsi

    }
    abstract void Frena(double deltaDecelerazione, double deltaTempo)
    {
        //permette di ridurre la velocità applicando una decelerazione per un deltaTempo.
        accelerazione = accelerazione -deltaAccelerazione; 
        velocità = velocità - accelerazione*deltaTempo;
        metriPercorsi = metriPercorsi + velocità*deltaTempo;
        carburante = carburante - 0.0001* velocità*deltaTempo;
        //se il carburante va a 0 il veicolo deve fermarsi

    }
    abstract void MantieniVelocità(double deltaTempo)
    {
        //mantiene la velocità costante per il deltaTempo
        accelerazione = 0;
        //la velocità rimane costante
        metriPercorsi = metriPercorsi + velocità*deltaTempo;
        carburante = carburante - 0.0004* velocità*deltaTempo;
        //se il carburante va a 0 il veicolo deve fermarsi

    }
    override void ToString()
    {

    }
    public void Rifornisci(double carburante)
    {
        //incrementa il quantitativo di carburante nel serbatoio, verificando che non venga superato il valore massimo di capienza del serbatoio.

    }
}
