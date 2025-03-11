namespace Pag34Ex07;

public class ContaBancaria
{
    double saldo, saque, deposito;

    public double Saque(double saldo, double saque)
    {
        if (saldo > saque)
        {
            return saldo - saque;
        }
        else
            return -1;
    }

    public double Deposito(double saldo, double deposito)
    {

        return saldo + deposito;
    }
}
