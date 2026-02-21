namespace singleton;

class Program
{
    
    public class Singleton
    {
        private static Singleton instance;
        private Singleton(){}

        public static Singleton GetInstance()
        {
            if(instance == null){
                instance = new Singleton();   
            }
            return instance;
        }
    } 



    static void Main(string[] args)
    {
        Singleton obj = Singleton.GetInstance();
        Singleton obj_2 = Singleton.GetInstance();
        System.Console.WriteLine(obj==obj_2);
    }
}
