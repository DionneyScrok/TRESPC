using System;
using System.Collections.Generic;
using System.Globalization;
namespace Trabalho_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean continua = true;
            List <Cadastro> cadastros = new List<Cadastro>();
            do
            {
                Console.WriteLine("(1) - INCLUIR!");
                Console.WriteLine("(2) - ALTERAR!");
                Console.WriteLine("(3) - EXCLUIR!");
                Console.WriteLine("(4) - LISTAR!");
                Console.WriteLine("(5) - PESQUISAR!");
                Console.WriteLine("(6) - SAIR!");
                string opcao = Console.ReadLine();
                
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("(INCLUIR) - Adicione os dados para incluir na lista.");
                        Console.WriteLine("ID: ");
                        string id = Console.ReadLine();
                        Console.WriteLine("Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Telefone: ");
                        string telefone = Console.ReadLine();
                        cadastros.Add(new Cadastro(id, nome, telefone));
                        break;
                    case "2":
                        Console.WriteLine("(ALTERAR) - Deseja alterar por (id), (nome) ou (telefone)? Informe: ");
                        string opcao2 = Console.ReadLine();
                        switch (opcao2)
                        {
                            case "id":
                                Console.WriteLine("Informe o ID:");
                                string alterando = Console.ReadLine();
                                Cadastro pesquisar = cadastros.Find(x => x.Id.Equals(alterando));
                                if (alterando != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar.Id}");
                                    Console.WriteLine($"Nome: {pesquisar.Nome}");
                                    Console.WriteLine($"Telefone: {pesquisar.Telefone}");
                                    Console.WriteLine("Informe o novo id:");                                   
                                    pesquisar.Id = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar.Nome = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar.Telefone = Console.ReadLine();
                                    Console.WriteLine("Cadastro alterado com sucesso!");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                 break;
                            case "nome":
                                Console.WriteLine("Informe o Nome:");
                                string alterando1 = Console.ReadLine();
                                Cadastro pesquisar1 = cadastros.Find(x => x.Nome.Equals(alterando1));
                                if (alterando1 != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar1.Id}");
                                    Console.WriteLine($"Nome: {pesquisar1.Nome}");
                                    Console.WriteLine($"Telefone: {pesquisar1.Telefone}");
                                    Console.WriteLine("Informe o novo id:");
                                    pesquisar1.Id = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar1.Nome = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar1.Telefone = Console.ReadLine();
                                    Console.WriteLine("Cadastro alterado com sucesso!");

                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                break;
                            case "telefone":
                                Console.WriteLine("Informe o ID:");
                                string alterando2 = Console.ReadLine();
                                Cadastro pesquisar2 = cadastros.Find(x => x.Telefone.Equals(alterando2));

                                if (alterando2 != null)
                                {
                                    Console.WriteLine($"ID: {pesquisar2.Id}");
                                    Console.WriteLine($"Nome: {pesquisar2.Nome}");
                                    Console.WriteLine($"Telefone: {pesquisar2.Telefone}"); //COLOCAR PARA ALTERAR NAS CASES ID, TELEFONE E NOME;
                                    Console.WriteLine("Deseja alterar (id = 1), (nome = 2) ou (telefone = 3)?");
                                    Console.WriteLine("Informe o novo id:");
                                    pesquisar2.Id = Console.ReadLine();
                                    Console.WriteLine("Informe o novo nome:");
                                    pesquisar2.Nome = Console.ReadLine();
                                    Console.WriteLine("Informe o novo telefone:");
                                    pesquisar2.Telefone = Console.ReadLine();
                                    Console.WriteLine("Cadastro alterado com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro com essa informação!!!");
                                }
                                break;
                        }
                break;
                    case "3":
                        Console.WriteLine("(EXCLUIR)");
                        Console.WriteLine("Deseja excluir por (id), (nome) ou (telefone). Informe:");
                        string opcao3 = Console.ReadLine();
                        switch (opcao3)
                        {
                            case "id":
                                Console.WriteLine("Informe o ID: ");
                                string excID = Console.ReadLine();
                                Cadastro excluID = cadastros.Find(x => x.Id.Equals(excID));
                                if (excID != null) { 
                                Console.WriteLine($"ID: {excluID.Id}");
                                Console.WriteLine($"Nome: {excluID.Nome}");
                                Console.WriteLine($"Telefone: {excluID.Telefone}");
                                Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                string yesORno = Console.ReadLine();
                                switch (yesORno)
                                {
                                    case "s":
                                            cadastros.Remove(excluID);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");                                     
                                        break;
                                        case "n":
                                            
                                            break;
                                        default:
                                            Console.WriteLine("Opção Invalida");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                            case "nome":
                                Console.WriteLine("Informe o NOME: ");
                                string excNOME = Console.ReadLine();
                                Cadastro excluNome = cadastros.Find(x => x.Id.Equals(excNOME));
                                if (excNOME != null)
                                {
                                    Console.WriteLine($"ID: {excluNome.Id}");
                                    Console.WriteLine($"Nome: {excluNome.Nome}");
                                    Console.WriteLine($"Telefone: {excluNome.Telefone}");
                                    Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                    string yesORno = Console.ReadLine();
                                    switch (yesORno)
                                    {
                                        case "s":
                                            cadastros.Remove(excluNome);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");
                                            break;
                                        case "n":

                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                            case "telefone":
                                Console.WriteLine("Informe o ID: ");
                                string excTEL = Console.ReadLine();
                                Cadastro excluTel = cadastros.Find(x => x.Id.Equals(excTEL));
                                if (excTEL != null)
                                {
                                    Console.WriteLine($"ID: {excluTel.Id}");
                                    Console.WriteLine($"Nome: {excluTel.Nome}");
                                    Console.WriteLine($"Telefone: {excluTel.Telefone}");
                                    Console.WriteLine("Deseja excluir este cadastro? Digite (s) para sim e (n) para não.");
                                    string yesORno = Console.ReadLine();
                                    switch (yesORno)
                                    {
                                        case "s":
                                            cadastros.Remove(excluTel);
                                            Console.WriteLine("Cadastro removido com sucesso!!!");
                                            break;
                                        case "n":

                                            break;
                                        default:
                                            Console.WriteLine("Opção Invalida");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Nenhum registro encontrado.");
                                }
                                break;
                        }
                        break;
                    case"4":
                        Console.WriteLine("(LISTAR)");
                        foreach(Cadastro listar in cadastros)
                        {
                            Console.WriteLine($"ID: {listar.Id}");
                            Console.WriteLine($"Nome: {listar.Nome}");
                            Console.WriteLine($"Telefone: {listar.Telefone}");
                            Console.WriteLine("====================");
                        }
                        break;
                    case "5":
                        Console.WriteLine("(Pesquisar)");
                        Console.WriteLine("Deseja pesquisar por (id), (nome) ou (telefone)???");
                        string pesqza = Console.ReadLine();
                        switch (pesqza)
                        {
                            case "id":
                                Console.WriteLine("Digite o id: ");
                                string pesqID = Console.ReadLine();
                                Cadastro pesquiseID = cadastros.Find(x => x.Id.Equals(pesqID));
                                Console.WriteLine($"ID: {pesquiseID.Id}");
                                Console.WriteLine($"Nome: {pesquiseID.Nome}");
                                Console.WriteLine($"Telefone: {pesquiseID.Telefone}");
                                break;
                            case "nome":
                                Console.WriteLine("Digite o nome: ");
                                string pesqNome = Console.ReadLine();
                                Cadastro pesquiseNome = cadastros.Find(x => x.Id.Equals(pesqNome));
                                Console.WriteLine($"ID: {pesquiseNome.Id}");
                                Console.WriteLine($"Nome: {pesquiseNome.Nome}");
                                Console.WriteLine($"Telefone: {pesquiseNome.Telefone}");
                                break;
                            case "telefone":
                                Console.WriteLine("Digite o telefone: ");
                                string pesqTEL = Console.ReadLine();
                                Cadastro pesquiseTel = cadastros.Find(x => x.Id.Equals(pesqTEL));
                                Console.WriteLine($"ID: {pesquiseTel.Id}");
                                Console.WriteLine($"Nome: {pesquiseTel.Nome}");
                                Console.WriteLine($"Telefone: {pesquiseTel.Telefone}");
                                break;
                            default:
                                Console.WriteLine("Opção Invalida");
                                break;

                        }
                        break;
                    case "6":
                        Console.WriteLine("SAIR");
                        Environment.Exit(6);
                        continua = false;

                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;

                }
            } while (continua);

        }
    }
}
