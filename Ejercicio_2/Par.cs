class Par{
    public int num1;
    public void PedirNumero(){
        Console.WriteLine("Ingrese el primer número");
        num1=Convert.ToInt32(Console.ReadLine());

        if (num1%2==0){
            Console.WriteLine("El numero "+num1+" es par");
        }else{
            Console.WriteLine("El numero "+num1+" es impar");
        }
    }
}