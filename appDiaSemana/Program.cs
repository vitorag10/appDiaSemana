string diasemana;
int numero;

Console.WriteLine("informe um numero de 1 a 7");    
numero = Convert.ToInt16(Console.ReadLine());

if (numero == 1)
{
    diasemana = "Domingo";
}
else if (numero == 2)
{
    diasemana = "Segunda-Feira";
}
else if (numero == 3)
{
    diasemana = "Terça-Feira";
}
else if (numero == 4)
{
    diasemana = "Quarta-Feira";
}
else if (numero == 5)
{
    diasemana = "Quinta-Feira";
}
else if (numero == 6)
{
    diasemana = "Sexta-Feira";
}
else if (numero == 7)
{
    diasemana = "Sabado";
}
else
{
    diasemana = "O numero informado não esta no intervalo solicitado";
}
Console.WriteLine("O número informado corresponde a" + diasemana + ".");





