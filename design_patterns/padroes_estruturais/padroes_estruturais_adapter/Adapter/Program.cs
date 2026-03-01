namespace Adapter;

interface IDisp_USB
{
    void Ligar();
}

class Disp_USB : IDisp_USB
{
    public void Ligar()
    {
        System.Console.WriteLine("USB Ligado");
    }
}

interface PortaHDMI
{
    void LigarHDMI();
}

class USBparaHDMI : PortaHDMI
{//Adapter
    private IDisp_USB usb;

    public USBparaHDMI(IDisp_USB disp_USB)
    {
        usb = disp_USB;
    }

    public void LigarHDMI()
    {
        usb.Ligar();
        System.Console.WriteLine("USB conectado pelo adaptador HDMI");
    }
}


class Program
{
    static void Main(string[] args)
    {
        PortaHDMI hdmi = new USBparaHDMI(new Disp_USB());
        hdmi.LigarHDMI();
    }
}
