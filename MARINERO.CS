public class MAREINERO : TRIPULANTE
{
    public int PESOTOTALpescado, Bono;
    public int sueldo = 900;
    public Marinero(string Nombre, string Sexo, int telefono, int cedula, int edad, int tiempoEmpresa,int sueldo,
     int Bono, int pesoTotalPescado):base(Nombre,Sexo,telefono,cedula,edad,tiempoEmpresa){
        this.Nombre = Nombre;
        this.Sexo = Sexo;
        this.telefono = 098432123;
        this.cedula = 233987654;
        this.edad = edad;
        this.tiempoEmpresa = tiempoEmpresa;
        this.sueldo = sueldo;
        this.Bono = Bono;
        this.pesoTotalPescado = pesoTotalPescado;
    }
    public void bono(double pez){
        if (pez >= 1 )
        {
           pez *= 0.25;
        }
        pesoTotalPescado = sueldo + Bono;
    }
    public void imprimir(){
        Console.WriteLine("Cedula: "+cedula);
        Console.WriteLine("Nombre: "+Nombre);
        Console.WriteLine("Sexo: "+Sexo);
        Console.WriteLine("Edad: "+edad);
        Console.WriteLine("Telefono: "+telefono);
        Console.WriteLine("Tiempo en la empresa: "+tiempoEmpresa+" años");
        Console.WriteLine("Sueldo base: "+sueldo);
        Console.WriteLine("Bono: "+bono);
        Console.WriteLine("Sueldo total: "+pesoTotalPescado);
        return;
    }
}