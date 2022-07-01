public class ContaCorrente
{
    // CRIAÇÃO DOS MÉTODOS DA CLASSE 'CONTA CORRENTE'
    public string titular;
    public int agencia;
    public int numero;
    public double saldo;

    public ContaCorrente(string Titular, int agencia, int Numero, double saldo)
    {
        this.titular = Titular;
        this.agencia = agencia;
        this.numero = Numero;
        this.saldo = saldo;
    }

    public string Sacar (double valor)
    {
        if(this.saldo < valor)
        {
            return "Saldo insuficiente";
        }
        else
        {
            this.saldo -= valor;
            return "Saque efetuado!";
        }
    }
}