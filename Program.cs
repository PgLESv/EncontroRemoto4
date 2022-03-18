using System;

namespace ENCONTROREMOTO4
{
    class Program
    {
        static void Main(string[] args)
        {
        /*   Endereco end = new Endereco();

            end.logradouro = "Rua Y";
            end.numero = 120;
            end.complemento = "Próximo ao Mercado";
            end.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFisica();

            novapf.endereco = end;
            novapf.cpf = "12345678999";
            novapf.dataNascimento = new DateTime(1999, 01, 10);
            novapf.nome = "Pedro";

            PessoaFisica pf = new PessoaFisica();
            // pf.ValidarDataNascimento(pf.dataNascimento);

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            // Console.WriteLine(idadeValida);

            if (idadeValida == true)
            {
                Console.WriteLine($"Cadastro Aprovado");
            }
            else
            {
                Console.WriteLine($"Cadastro Não Aprovado");
            }

            // Console.WriteLine(pf.ValidarDataNascimento(novapf.dataNascimento));

            // Console.WriteLine(novapf.endereco.logradouro);
            // Console.WriteLine(novapf.endereco.numero);
            // Console.WriteLine(novapf.endereco.complemento);
            // Console.WriteLine(novapf.endereco.enderecoComercial);

            // Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}");

            // Console.WriteLine("Rua: " + novapf.endereco.logradouro + ", " + novapf.endereco.numero);
            */
                        
            PessoaJuridica pj = new PessoaJuridica();

            PessoaJuridica novapj = new PessoaJuridica();

            Endereco end = new Endereco();

            end.logradouro = "Rua Y";
            end.numero = 120;
            end.complemento = "Próximo ao Mercado";
            end.enderecoComercial = false;

            novapj.endereco = end;
            novapj.cnpj = "01234567890123";
            novapj.razaoSocial = "Pessoa Jurídica";

            if (pj.ValidarCNPJ(novapj.cnpj))
            {
                Console.WriteLine("CNPJ Válido");
            }
            else
            {
                Console.WriteLine("CNPJ Inválido");
            }
        }
    }
}