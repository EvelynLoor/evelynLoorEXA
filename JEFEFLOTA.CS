public class JEFEFLOTA{

 public int PESOpescado, PESOmarisco;
    public int sueldo = 3500;
    public double sueldoTotal, Bpescado, Bmarisco;
    public Jefe_de_Flota(string Nombre, string Sexo, int telefono, int cedula, int edad, int tiempoEmpresa, double sueldoTotal,
     double BonoMarisco, double BonoPescado):base(Nombre,Sexo,telefono,cedula,edad,tiempoEmpresa){

        
        this.Nombre = "KAREN LOOR";
        this.Sexo = "F";
        this.telefono = 0970328785;
        this.cedula = 1304353335;
        this.edad = 32;
        this.tiempoEmpresa = 112;
        this.sueldo = sueldo;
        this.Bpescado = Bpescado;
        this.Bmarisco = Bmarisco;
        this.sueldoTotal = sueldoTotal;
        this.sueldoTotal = sueldoTotal;
        this.Bmarisco= Bmarisco;
        this.Bpescado = Bpescado;
    }
    public void bono(int PESCADO){
        if (pesoPescado == PESCADO)
        {
            pesoPescado %= 1;
        }if (pesoMarisco == PESCADO)
        {
            pesoMarisco %= 2;
        }
        sueldoTotal = sueldo + Bmarisco;
        sueldoTotal = sueldo + Bpescado;
        return;
    }

    public void imprimir(){
        Console.WriteLine("Cedula: "+cedula);

        Console.WriteLine("Nombre: "+Nombre);

        Console.WriteLine("Sexo: "+Sexo);

        Console.WriteLine("Edad: "+edad);

        Console.WriteLine("Telefono: "+telefono);

        Console.WriteLine("Tiempo en la empresa: "+tiempoEmpresa+" años");

        Console.WriteLine("Sueldo base: "+sueldo);

        Console.WriteLine("Bono por pescado: "+Bpescado);

        Console.WriteLine("Bono por mariscos: "+Bmarisco);

        Console.WriteLine("Sueldo total: "+sueldoTotal);

        return;

    }

}