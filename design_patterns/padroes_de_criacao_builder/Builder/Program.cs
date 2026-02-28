using System.Collections.Generic;

namespace Builder;

public class Car
{
    public System.String motor{get;set;}

    public int rodas{get; set;}
    public System.String cor{get; set;}

    public override System.String ToString()
    {
        return $"Carro com motor "+motor+", "+rodas+" rodas e cor "+cor;
    }
}

public interface ICarBuilder
{
    void SetMotor(System.String motor);
    void SetRodas(int rodas);
    void SetCor(System.String cor);

    Car GetResult();
}

public class CarBuilder : ICarBuilder
{
    private Car _car = new Car();
    public void SetMotor(System.String motor)
    {
        _car.motor = motor;
    }

    public void SetRodas(int rodas)
    {
        _car.rodas = rodas;
    }

    public void SetCor(System.String cor)
    {
        _car.cor = cor;
    }

    public Car GetResult()
    {
        return _car;
    }
}

public class CarDirector
{
    private readonly ICarBuilder _builder;
    public CarDirector(ICarBuilder builder)
    {
        _builder = builder;
    }

    public void SportCar()
    {
        _builder.SetMotor("V8");
        _builder.SetRodas(4);
        _builder.SetCor("Green");
    }

    public void SUVCar()
    {
        _builder.SetMotor("V6");
        _builder.SetRodas(4);
        _builder.SetCor("Black");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICarBuilder builder = new CarBuilder();
        CarDirector director = new CarDirector(builder);

        director.SportCar();
        Car sportcar = builder.GetResult();
        System.Console.WriteLine(sportcar);

        director.SUVCar();
        Car suvcar = builder.GetResult();
        System.Console.WriteLine(suvcar);

        CarBuilder meu_carro = new CarBuilder();
        meu_carro.SetCor("laranja");
        meu_carro.SetMotor("V4");
        meu_carro.SetRodas(4);

        Car resultado = meu_carro.GetResult();
        System.Console.WriteLine(resultado);
    }
}
