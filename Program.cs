

internal class Program
{
    public static void Main(string[]agrs){

        GPS GPS1 = new GPS();
        GPS1.imprimir();
        CAPITAN capitan1 = new TRIPULANTE();
        capitan1.bono();
        capitan1.imprimir();
        Jefe_de_Flota jFlota = TRIPULANTE();
        jFlota.bono(1);
        jFlota.imprimir();
        Marinero marinero = TRIPULANTE();
        jFlota.bono(1);
        jFlota.imprimir();

    }
}