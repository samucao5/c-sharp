namespace polimorfismo;

class Program
{
    /*
    Polimorfismo baseia-se nas diferentes formas que um objeto pode ter.

    Por exemplo os tipos que pode assumir.
    */
    static void Main(string[] args)
    {
        Vaca vaca_1 = new Vaca();
        Cachorro cao_1 = new Cachorro();
        //daria erro se voce tentasse fazer um vetor de cachorro com vaca
        //Cachorro[] vetor = {vaca_1, cao_1};
        //pois cachorro não possui vaca
        //mas como ambos são classe filhas de mamiferos, voce pode criar um vetor com ambas as classes
        Mamiferos[] vetor = {vaca_1, cao_1};
    }
}

class Mamiferos
{
    
}

class Vaca:Mamiferos
{
    
}

class Cachorro:Mamiferos
{
    
}
