namespace Pag34Ex07;

public class ContaBancaria
{
    double saldo, saque, deposito, desconto;
    
    public double Saque(double saldo, double saque, double deposito, string classificacao)
    {
        if (classificacao == "Comum")
        {
            if (saldo > saque)
            {
                return saldo - saque;
            }
            else
            {
                return -1;
            }
        }
        else
        {
            saque = saque - deposito / 0.8;

            if (saldo > saque)
            {
                return saldo - saque;
            }
            else
            {
                return -1;
            }
        }
    }

    public double Deposito(double saldo, double deposito)
    {
        return saldo + deposito;
    }
}
