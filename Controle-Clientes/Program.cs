
using Controle_Clientes;

Console.WriteLine ("informar nome:");
string nome = Console.ReadLine();

Console.WriteLine ("informar endereco:");
string endereco = Console.ReadLine();

Console.WriteLine ("Pessoa Fisica (f) ou Pessoa Juridica (j)?" );
string tipo = Console.ReadLine();

if(tipo == "f") {
    
    PessoaFisica pf = new PessoaFisica() {
        nome = nome,
        endereco = endereco,
    };
    Console.WriteLine("informar o cpf:");
    pf.cpf = Console.ReadLine();

    Console.WriteLine("informar o rg:");
    pf.rg = Console.ReadLine();

    Console.WriteLine("informar o valor de compra:");
    float valor = float.Parse(Console.ReadLine());

    pf.Pagar_Imposto(valor);

    Console.WriteLine("----------PessoaFisica Fisica ----------");
    Console.WriteLine("Nome: " + pf.nome);
    Console.WriteLine("Endereco: " + pf.endereco);
    Console.WriteLine("CPF: " + pf.cpf);
    Console.WriteLine("RG: " + pf.rg);
    Console.WriteLine("Valor de compra: " + pf.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pf.valorImposto);
    Console.WriteLine("Total a pagar:" + pf.total.ToString("C"));
    
    
}

else if(tipo == "j"){

    PessoaJuridica pj = new PessoaJuridica() {
            nome = nome,
            endereco = endereco,
        };

    Console.WriteLine("Informar CNPJ: " + pj.cnpj);
    pj.cnpj = Console.ReadLine();

    Console.WriteLine("Informar IE: ");
    pj.ie = Console.ReadLine();

    Console.WriteLine("informar o valor de compra:");
    float valor = float.Parse(Console.ReadLine());

    pj.Pagar_Imposto(valor);

     Console.WriteLine("----------PessoaFisica Juridica ----------");
    Console.WriteLine("Nome: " + pj.nome);
    Console.WriteLine("Endereco: " + pj.endereco);
    Console.WriteLine("CNPJ: " + pj.cnpj);
    Console.WriteLine("IE: " + pj.ie);
    Console.WriteLine("Valor de compra: " + pj.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pj.valorImposto);
    Console.WriteLine("Total a pagar:" + pj.total.ToString("C"));




}