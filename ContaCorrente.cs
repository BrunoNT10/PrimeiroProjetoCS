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

    public bool Sacar (double valorSaque)
    {
        if(this.saldo >= valorSaque)
        {
            this.saldo -= valorSaque;
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool Adicionar (double valorAdicionado)
    {
        this.saldo += valorAdicionado;
        return true;
    }
}