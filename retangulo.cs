public class Retangulo()
{
    double largura;

    double altura;

    public Retangulo ( )
    {
        largura = 0;
        altura = 0;

    }

    public Retangulo ( )
    {
        largura = 0;
        altura = 0;
    }

    public Retangulo(double valor)
    {
        altura = valor;
        largura = valor;
    }

    public Retangulo(double valor, double valor)
    {
        largura = valor;
        altura = valor;
    }

    public double CalcularArea()
    {
        return largura * altura ;
    }

    public double CalcularPerimetro()
    {
        return ( largura + altura ) * 2;
    }

    public void Redimencionar()

        {

        }

    public void Redimencionar(double fator)
    {
        altura *= fator;
        largura *= fator;
    }

    public void Redimencionar(doouble largura, double altura)
    {
        this.altura = altura;
        this largura = largura;
    }


}














