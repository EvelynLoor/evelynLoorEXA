public class[


public class CAPITAN : TRIPULANTE
{
    public double horasExperiencia;
    public int sueldo = 4500;
    public double sueldoTotal, Bono;
    public Capitan(string Nombre, string Sexo, int telefono, int cedula, int edad, int tiempoEmpresa, int sueldo, double Bono, double sueldoTotal):base(Nombre,Sexo,telefono,cedula,edad,tiempoEmpresa){
        this.Nombre = "EDUARDO";
        this.Sexo = "M";
        this.telefono = 0988373461;
        this.cedula = 1316451358;
        this.edad = 28;
        this.tiempoEmpresa = 20;
        this.sueldo = sueldo;
        this.Bono = Bono;
        this.sueldoTotal = sueldoTotal;
    }
    public void bono(){
        if (horasExperiencia >= 5000 && horasExperiencia < 150000)
        {
            horasExperiencia%=20;
        }if (horasExperiencia >= 150000 && horasExperiencia < 300000)
        {
            horasExperiencia%=40;
        }if (horasExperiencia > 300000)
        {
            horasExperiencia%=75;
        }
        sueldoTotal =horasExperiencia+Bono;


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
        Console.WriteLine("Bono: "+bono);
        Console.WriteLine("Sueldo total: "+sueldoTotal);
        return;
    }

}

]