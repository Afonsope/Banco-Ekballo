## Codigo feio pelo Afonsope

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Switch pricipal */
            int escolha;

            /* Para sar de variavel nas case no qual da para usar ou switch ou if */
            int n1, n2, n3, n4, n5, n6, n7, n8, n9;

            /* Para acessar a conta do banco e ves seus dados */
            String cont1, senha1, senha2;

            /* Switch case 1 */
            int case1;
            string login1, DIG1;
            int snv;

            /* Switch case 2*/
            int consult2, extr1;
            string dt1;

            /* Switch case 5 */
            double preco1, media1, media2, media3, media4, media5, media6;
            int parc1;

            /* Switch case 6 */
            int cart1;

            /* Switch case 8 */
            int invest1, bank1, bank2;

            /* Agradecimento */
            string agradecimento;
            agradecimento = "Obrigado por escolher o banco Ekballo!";

            /* Switch case 9 */
            int confirm1, block1;
            string pix1, valor1;

            /* usar nos |0. sair */
            string Sair_da_pagina;
            Sair_da_pagina = "Entendido, obrigado por escolher o banco Ekballo! Saindo...";

            /* usar nos default 8 */
            string default1;
            default1 = "Comando não entendido, saindo...";

            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|Escolha a opção desejada:|");
            Console.WriteLine("+-------------------------+");
            Console.WriteLine("|1. Atendimento           |");
            Console.WriteLine("|2. Saldo                 |");
            Console.WriteLine("|3. Pagamento             |");
            Console.WriteLine("|4. Boleto                |");
            Console.WriteLine("|5. Empréstimo            |");
            Console.WriteLine("|6. Cartão                |");
            Console.WriteLine("|7. Desbloqueio           |");
            Console.WriteLine("|8. Fatura                |");
            Console.WriteLine("|9. PIX                   |");
            Console.Write("|0. ");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Write("Sair");

            Console.ResetColor();

            Console.WriteLine("                  |");
            Console.WriteLine("+-------------------------+");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Opção selecionada: Atendimento");
                        Console.ReadLine();

                        Console.ResetColor();

                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|Escolha a opção desejada:  |");
                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|1. Suporte                 |");
                        Console.WriteLine("|2. Consulta de informações |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("                    |");
                        Console.WriteLine("+---------------------------+");
                        n1 = int.Parse(Console.ReadLine());

                        switch (n1)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Suporte");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+----------------------------------+");
                                    Console.WriteLine("|Qual seria o seu problema?        |");
                                    Console.WriteLine("+----------------------------------+");
                                    Console.WriteLine("|1. Dificuldade ao acessar a conta |");
                                    Console.WriteLine("|2. Troca de senha                 |");
                                    Console.WriteLine("|3. Dificudade no pagamento        |");
                                    Console.WriteLine("|4. Acerto de saldo negativo       |");
                                    Console.Write("|0. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Sair");
                                    Console.ResetColor();

                                    Console.WriteLine("                           |");
                                    Console.WriteLine("+----------------------------------+");

                                    case1 = int.Parse(Console.ReadLine());

                                    switch (case1)
                                    {
                                        case 1:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Dificuldade ao acessar a conta");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Digite seu CPF, telefone ou e-mail:");
                                                login1 = Console.ReadLine();

                                                Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();
                                                Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Conta acessada!");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                                Console.ReadLine();

                                                Console.WriteLine("+----------------------------+");
                                                Console.WriteLine("|Dados da conta:             |");
                                                Console.WriteLine("+----------------------------+");
                                                Console.WriteLine($"|CPF: {login1}");
                                                Console.WriteLine("|Saldo: R$5.600,89");
                                                Console.WriteLine("|Entrada no banco 18/09/2015");
                                                Console.WriteLine("+----------------------------+");
                                                Console.Read();
                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Troca de senha");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|Lembra da sua atual senha? |");
                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|1. Sim                     |");
                                                Console.WriteLine("|2. Não                     |");
                                                Console.Write("|0. ");

                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Sair");
                                                Console.ResetColor();

                                                Console.WriteLine("                    |");
                                                Console.WriteLine("+---------------------------+");
                                                snv = int.Parse(Console.ReadLine());

                                                switch (snv)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Digite seu CPF, telefone ou e-mail:");
                                                            login1 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.Write("Senha atual:");
                                                            senha1 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            senha2 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            senha2 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();

                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 2:
                                                        {
                                                            Console.WriteLine("Digite seu CPF, telefone ou e-mail:");
                                                            login1 = Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.WriteLine("Confira o codigo de verificação enviado ao seu numero e E-mail cadastrados.");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("VERIFICADO.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            senha2 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            senha2 = Console.ReadLine();

                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 0:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{Sair_da_pagina}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{default1}");
                                                            Console.Read();

                                                            break;
                                                        }
                                                }
                                                break;

                                            }

                                        case 3:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Dificuldade no pagamento");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.Write("Insira o codigo da conta a pagar:");
                                                Console.ReadLine();

                                                Console.Write("Digite a forma de pagamento:");
                                                Console.ReadLine();

                                                Console.WriteLine("Vá a loterica mais perto de você e mostre esse codigo: 1234567890_");
                                                Console.WriteLine("Caso for no PIX, inserir o codigo na chave PIX");
                                                Console.Read();

                                                break;
                                            }

                                        case 4:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Acerto de saldo negativo");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o codigo da conta:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Parabéns conta acessada!");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                                Console.ReadLine();
                                                Console.WriteLine("+----------------------------+");
                                                Console.WriteLine("|Dados da conta:             |");
                                                Console.WriteLine("+----------------------------+");
                                                Console.WriteLine($"|Usuário: {cont1} DIG: {DIG1}");
                                                Console.WriteLine($"|CPF: 000000000/00          |");
                                                Console.WriteLine($"|Telefone: (00) 00000-0000  |");
                                                Console.WriteLine($"|E-mail: 00000@gmail.com    |");
                                                Console.WriteLine("|Saldo: R$ - 4.654,23        |");
                                                Console.WriteLine("|Entrada no banco 18/09/2015 |");
                                                Console.WriteLine("+----------------------------+");
                                                Console.ReadLine();

                                                Console.WriteLine("Codigo para pagar: 01234567890_");
                                                Console.WriteLine("Vá a loterica mais perto de você e mostre o codigo");
                                                Console.WriteLine("Caso for no PIX, inserir o codigo na chave PIX");
                                                Console.Read();

                                                break;
                                            }

                                        case 0:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor= ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Consulta de informações");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Parabéns conta acessada!");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                    Console.ReadLine();
                                    Console.WriteLine("+----------------------------+");
                                    Console.WriteLine("|Dados da conta:             |");
                                    Console.WriteLine("+----------------------------+");
                                    Console.WriteLine($"|Usuário: {cont1} DIG: {DIG1}");
                                    Console.WriteLine("|CPF: 000000000/00           |");
                                    Console.WriteLine("|Telefone: (00) 00000-0000   |");
                                    Console.WriteLine("|E-mail: 00000@gmail.com     |");
                                    Console.WriteLine("Saldo: R$5.600,89            |");
                                    Console.WriteLine("Limite: R$45.000,00          |");
                                    Console.WriteLine("|Entrada no banco 18/09/2015 |");
                                    Console.WriteLine("+----------------------------+");
                                    Console.Read();
                                }

                                break;

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }

                        break;
                    }

                case 2:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Saldo");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+------------------+");
                        Console.WriteLine("|O que deseja ver? |");
                        Console.WriteLine("+------------------+");
                        Console.WriteLine("|1. Consulta       |");
                        Console.WriteLine("|2. Limite         |");
                        Console.WriteLine("|3. Extrato        |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("           |");
                        Console.WriteLine("+------------------+");
                        n2 = int.Parse(Console.ReadLine());

                        switch (n2)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Consulta");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+--------------------------------+");
                                    Console.WriteLine("|Deseja ver todos os seus dados? |");
                                    Console.WriteLine("+--------------------------------+");
                                    Console.WriteLine("|1. Sim                          |");
                                    Console.Write("|2. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Não e sair");
                                    Console.ResetColor();

                                    Console.WriteLine("                   |");
                                    Console.WriteLine("+--------------------------------+");
                                    consult2 = int.Parse(Console.ReadLine());

                                    if ( consult2 == 1 )
                                    {
                                        Console.WriteLine("Identificação...");
                                        Console.ReadLine();

                                        Console.WriteLine("Digite o codigo da conta:");
                                        cont1 = Console.ReadLine();

                                        Console.WriteLine("Digite o digito verificador:");
                                        DIG1 = Console.ReadLine();

                                        Console.WriteLine("Digite sua senha:");
                                        senha1 = Console.ReadLine();

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("Parabéns conta acessada!");
                                        Console.ResetColor();
                                        Console.ReadLine();

                                        Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                        Console.ReadLine();

                                        Console.WriteLine("+-----------------------------------+");
                                        Console.WriteLine("Dados da conta:                     |");
                                        Console.WriteLine("+-----------------------------------+");
                                        Console.WriteLine($"|Usuário: {cont1} DIG: {DIG1}");
                                        Console.WriteLine($"|CPF: 000000000/00                |");
                                        Console.WriteLine($"|Telefone: (00) 00000-0000        |");
                                        Console.WriteLine($"|E-mail: 00000@gmail.com          |");
                                        Console.WriteLine("|Saldo: R$5.600,89                  |");
                                        Console.WriteLine("|Quantia ja extraida: R$30.678,89   |");
                                        Console.WriteLine("|Maior quantia retirada: R$5.000,00 |");
                                        Console.WriteLine("|Maior rendimento: 33%              |");
                                        Console.WriteLine("|Entrada no banco 18/09/2015        |");
                                        Console.WriteLine("+-----------------------------------+");
                                        Console.Read();
                                    }

                                    else
                                    {
                                        Console.ReadLine();

                                        Console.WriteLine($"{Sair_da_pagina}");
                                        Console.Read();

                                    }

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Limite");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Parabéns conta acessada!");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                    Console.ReadLine();
                                    Console.WriteLine("+----------------------------+");
                                    Console.WriteLine("|Dados da conta:             |");
                                    Console.WriteLine("+----------------------------+");
                                    Console.WriteLine("|CPF: 000000000/00           |");
                                    Console.WriteLine("|Telefone: (00) 00000-0000   |");
                                    Console.WriteLine("|E-mail: 00000@gmail.com     |");
                                    Console.WriteLine("|Saldo: R$5.600,89           |");
                                    Console.WriteLine("|Limite: R$45.000,00         |");
                                    Console.WriteLine("|Entrada no banco 18/09/2015 |");
                                    Console.WriteLine("+----------------------------+");
                                    Console.Read();

                                    break;
                                }

                            case 3:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Extrato");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Parabéns conta acessada!");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+-------------------------------+");
                                    Console.WriteLine("|Extrato de 2024:               |");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|01/01/2024 03:46   ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("+R$1.000,00 ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|01/01/2024 12:32   ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("+R$20,00    ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|03/01/2024 11:59   ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("-R$119,00   ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|04/01/2024 17:17   ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("-R$32,50    ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|04/01/2024 20:46   ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("+R$40,00    ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|05/01/2024 10:11   ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("-R$19,87    ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.Write("|06/01/2024 22:25   ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("-R$20,00    ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.WriteLine("|Ver mais?                      |");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.WriteLine("|1. Sim                         |");
                                    Console.Write("|0. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Não e sair");
                                    Console.ResetColor();

                                    Console.WriteLine("                  |");
                                    Console.WriteLine("+-------------------------------+");
                                    extr1 = int.Parse(Console.ReadLine());

                                    switch (extr1)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("+--------------------------------+");
                                                Console.WriteLine("|Extrato de 2024:                |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("| 01/01/2024 03:46   ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("+R$1.000,00 ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Carlos Ricardo                  |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|01/01/2024 12:32   ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("+R$20,00     ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Pedro de Alcantra               |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|03/01/2024 11:59   ");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("-R$119,00    ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Nicolli Figueredo               |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|04/01/2024 17:17   ");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("-R$32,50     ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Talita Soares                   |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|04/01/2024 20:46   ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.Write("+R$40,00     ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|José Antonio                    |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|05/01/2024 10:11   ");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("-R$19,87     ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Giovanna Gonzales               |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Write("|06/01/2024 22:25   ");
                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("-R$20,00     ");
                                                Console.ResetColor();
                                                Console.WriteLine("|");
                                                Console.WriteLine("|Zoe do Santos                   |");
                                                Console.WriteLine("+--------------------------------+");
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }

                        }

                        break;
                    }

                case 3:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Pagamento");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|Escolha uma forma de pagamento |");
                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("|1. Dinheiro                    |");
                        Console.WriteLine("|2. Cartão de crédito           |");
                        Console.WriteLine("|3. cartão de débito            |");
                        Console.WriteLine("|4. PIX                         |");
                        Console.WriteLine("|5. Cheque                      |");
                        Console.WriteLine("|6. Carnê                       |");
                        Console.WriteLine("|7. Agendar pagamento           |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("                        |");
                        Console.WriteLine("+-------------------------------+");
                        n3 = int.Parse(Console.ReadLine());

                        switch (n3)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Dinheiro");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Vá a loterica mais proxima e pague");
                                    Console.Read();

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Cartão de crédito");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor séra cobrado no seu cartão");
                                    Console.Read();

                                    break;
                                }

                            case 3:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Cartão de débito");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor será cobrado no seu cartão");
                                    Console.Read();

                                    break;
                                }

                            case 4:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: PIX");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Use o codigo a seguir para pagar");
                                    Console.WriteLine("1234567890_");
                                    Console.Read();

                                    break;
                                }

                            case 5:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Chaque");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor será retirado da sua conta");
                                    Console.Read();

                                    break;
                                }

                            case 6:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Carnê");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Vá a loterica mais proxima e pague");
                                    Console.Read();

                                    break;
                                }

                            case 7:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Agendar pagamento");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$30,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor se não for pago será cobrado em juros");
                                    Console.WriteLine("Qual dia vc deseja pagar: ");
                                    dt1 = Console.ReadLine();
                                    Console.WriteLine($"Sua conta será paga em {dt1}");
                                    Console.Read();

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }

                        break;
                    }

                case 4:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Boleto");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+-------------------------+");
                        Console.WriteLine("|Escolha a opção desejada:|");
                        Console.WriteLine("+-------------------------+");
                        Console.WriteLine("|1. Gerar boleto          |");
                        Console.WriteLine("|2. Visualizar boleto     |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("                  |");

                        Console.WriteLine("+-------------------------+");
                        n4 = int.Parse(Console.ReadLine());

                        switch (n4)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Gerar boleto");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();


                                    Console.WriteLine("+--------------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                                   |");
                                    Console.WriteLine("|                                                                    |");
                                    Console.WriteLine("|Total a pagar: R$15,90                                              |");
                                    Console.WriteLine("|Expira em 31/02/2024                                                |");
                                    Console.WriteLine("+--------------------------------------------------------------------+");
                                    Console.WriteLine("Use o codigo a seguir para pagar");
                                    Console.WriteLine("1234567890_");
                                    Console.Read();

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Visualizar boleto");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();


                                    Console.WriteLine("+--------------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                                   |");
                                    Console.WriteLine("|                                                                    |");
                                    Console.WriteLine("|Total a pagar: R$15,90                                              |");
                                    Console.WriteLine("|Expira em 31/02/2024                                                |");
                                    Console.WriteLine("+--------------------------------------------------------------------+");
                                    Console.Read();

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }

                        break;
                    }

                case 5:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Empréstimo");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|Escolha a opção desejada:  |");
                        Console.WriteLine("+---------------------------+");
                        Console.WriteLine("|1. Simular empréstimo      |");
                        Console.WriteLine("|2. Solicitar empréstimo    |");
                        Console.Write("|0. ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair                    ");
                        Console.ResetColor();
                        Console.WriteLine("|");
                        Console.WriteLine("+---------------------------+");
                        n5 = int.Parse(Console.ReadLine());

                        switch (n5)
                            {
                             case 1:
                                 {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Simular empréstimo");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.Write("Qual o valor que gostaria: R$");
                                    preco1 = double.Parse(Console.ReadLine());

                                    Console.WriteLine("+------------------------------------------------+");
                                    Console.WriteLine("|Quantas vezes gostaria de Parcelar o pagamneto? |");
                                    Console.WriteLine("+------------------------------------------------+");
                                    Console.WriteLine("|1. 12x                                          |");
                                    Console.WriteLine("|2. 24x                                          |");
                                    Console.WriteLine("|3. 36x                                          |");
                                    Console.WriteLine("|4. 48x                                          |");
                                    Console.WriteLine("|5. 60x                                          |");
                                    Console.WriteLine("|6. 72x                                          |");
                                    Console.WriteLine("+------------------------------------------------+");
                                    parc1 = int.Parse(Console.ReadLine());

                                    switch (parc1)
                                    {
                                        case 1:
                                            {
                                                media1 = preco1 / 12;
                                                Console.Write("Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media1}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                media2 = preco1 / 24;
                                                Console.Write("Você pagara 24 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media2}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 3:
                                            {
                                                media3 = preco1 / 36;
                                                Console.Write("Você pagara 36 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media3}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }
                                            
                                        case 4:
                                            {
                                                media4 = preco1 / 48;
                                                Console.Write("Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media4}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 5:
                                            {
                                                media5 = preco1 / 60;
                                                Console.Write($"Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media5}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 6:
                                            {
                                                media6 = preco1 / 72;
                                                Console.Write($"Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media6}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }
                                        
                                    break;
                                }

                             case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Solicitar empréstimo");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Parabéns conta acessada!");
                                    Console.ResetColor();

                                    Console.WriteLine("Bem- vindo ao Ekballo, seu banco mais confiavel!");
                                    Console.ReadLine();

                                    Console.Write("Qual o valor que gostaria: R$");
                                    preco1 = double.Parse(Console.ReadLine());

                                    Console.WriteLine("+------------------------------------------------+");
                                    Console.WriteLine("|Quantas vezes gostaria de Parcelar o pagamneto? |");
                                    Console.WriteLine("+------------------------------------------------+");
                                    Console.WriteLine("|1. 12x                                          |");
                                    Console.WriteLine("|2. 24x                                          |");
                                    Console.WriteLine("|3. 36x                                          |");
                                    Console.WriteLine("|4. 48x                                          |");
                                    Console.WriteLine("|5. 60x                                          |");
                                    Console.WriteLine("|6. 72x                                          |");
                                    Console.WriteLine("+------------------------------------------------+");
                                    parc1 = int.Parse(Console.ReadLine());

                                    switch (parc1)
                                    {
                                        case 1:
                                            {
                                                media1 = preco1 / 12;
                                                Console.Write("Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media1}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                media2 = preco1 / 24;
                                                Console.Write("Você pagara 24 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media2}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 3:
                                            {
                                                media3 = preco1 / 36;
                                                Console.Write("Você pagara 36 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media3}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 4:
                                            {
                                                media4 = preco1 / 48;
                                                Console.Write("Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media4}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 5:
                                            {
                                                media5 = preco1 / 60;
                                                Console.Write($"Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media5}");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 6:
                                            {
                                                media6 = preco1 / 72;
                                                Console.Write($"Você pagara 12 meses de ");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"R${media6}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                             case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                             default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }

                        break;
                    }

                case 6:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Cartão");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+---------------------+");
                        Console.WriteLine("|Qual é o seu cartão? |");
                        Console.WriteLine("+---------------------+");
                        Console.WriteLine("|1. Cartão de crédito |");
                        Console.WriteLine("|2. Cartão de débito  |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair              ");
                        Console.ResetColor();

                        Console.WriteLine("|");
                        Console.WriteLine("+---------------------+");
                        n6 = int.Parse(Console.ReadLine());

                        switch ( n6 )
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Cartão de crédito");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|Escolha a opção desejada: |");
                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|1. Bloquear cartão        |");
                                    Console.WriteLine("|2. Desbloquear cartão     |");
                                    Console.WriteLine("|3. Alterar senha          |");
                                    Console.WriteLine("|4. Limite                 |");
                                    Console.Write("|0. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Sair                   ");
                                    Console.ResetColor();

                                    Console.WriteLine("|");
                                    Console.WriteLine("+--------------------------+");
                                    cart1 = int.Parse(Console.ReadLine());

                                    switch (cart1)
                                    {
                                        case 1:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Bloquear cartão");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Cartão bloqueado com sucesso.");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Desbloquear cartão");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Cartão desbloqueado com sucesso.");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 3:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Alterar senha");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|Lembra da sua atual senha? |");
                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|1. Sim                     |");
                                                Console.WriteLine("|2. Não                     |");
                                                Console.Write("|0. ");

                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Sair                    ");
                                                Console.ResetColor();

                                                Console.WriteLine("|");
                                                Console.WriteLine("+---------------------------+");
                                                snv = int.Parse(Console.ReadLine());

                                                switch (snv)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Digite o número do cartão:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.Write("Senha atual:");
                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 2:
                                                        {
                                                            Console.WriteLine("Digite o número do cartão:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.WriteLine("Confira o codigo de verificação enviado ao seu numero e E-mail cadastrados.");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("VERIFICADO.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 0:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{Sair_da_pagina}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{default1}");
                                                            Console.Read();

                                                            break;
                                                        }
                                                }

                                                break;
                                            }

                                        case 4:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Limite");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Parabéns conta acessada!");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+-----------------------------------------------+");
                                                Console.WriteLine($"|Cartão: {cont1} DIG: {DIG1}");
                                                Console.WriteLine("|Limite: R$5.000,00                             |");
                                                Console.WriteLine("|Gasto esse mês: R$3.876,35                     |");
                                                Console.WriteLine("|Pode ser gasto ainda: 1.123,65                 |");
                                                Console.WriteLine("+-----------------------------------------------+");
                                                Console.Read();

                                                break;
                                            }

                                        case 0:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("Opção selecionada: Cartão de crédito");
                                    Console.ReadLine();

                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|Escolha a opção desejada: |");
                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|1. Bloquear cartão        |");
                                    Console.WriteLine("2. Desbloquear cartão      |");
                                    Console.WriteLine("3. Alterar senha           |");
                                    Console.WriteLine("4. Consultar saldo         |");
                                    Console.Write("|0. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Sair                   ");
                                    Console.ResetColor();

                                    Console.WriteLine("|");
                                    Console.WriteLine("+--------------------------+");
                                    cart1 = int.Parse(Console.ReadLine());

                                    switch (cart1)
                                    {
                                        case 1:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Bloquear cartão");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Cartão bloqueado com sucesso.");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Desbloquear cartão");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Cartão desbloqueado com sucesso.");
                                                Console.ResetColor();
                                                Console.Read();

                                                break;
                                            }

                                        case 3:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Alterar senha");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|Lembra da sua atual senha? |");
                                                Console.WriteLine("+---------------------------+");
                                                Console.WriteLine("|1. Sim                     |");
                                                Console.WriteLine("|2. Não                     |");
                                                Console.Write("|0. ");

                                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                                Console.Write("Sair                    ");
                                                Console.ResetColor();

                                                Console.WriteLine("|");
                                                Console.WriteLine("+---------------------------+");
                                                snv = int.Parse(Console.ReadLine());

                                                switch (snv)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Digite o número do cartão:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.Write("Senha atual:");
                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 2:
                                                        {
                                                            Console.WriteLine("Digite o número do cartão:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Conta encontrada.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.WriteLine("Confira o codigo de verificação enviado ao seu numero e E-mail cadastrados.");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("VERIFICADO.");
                                                            Console.ResetColor();
                                                            Console.ReadLine();

                                                            Console.Write("Nova senha:");
                                                            Console.ReadLine();

                                                            Console.Write("Repita a senha nova:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Senha Trocada com sucesso!");
                                                            Console.ResetColor();
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 0:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{Sair_da_pagina}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{default1}");
                                                            Console.Read();

                                                            break;
                                                        }
                                                }

                                                break;
                                            }

                                        case 4:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Consultar saldo");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("Identificação...");
                                                Console.ReadLine();

                                                Console.WriteLine("Digite o numero do seu cartão:");
                                                cont1 = Console.ReadLine();

                                                Console.WriteLine("Digite o digito verificador:");
                                                DIG1 = Console.ReadLine();

                                                Console.WriteLine("Digite sua senha:");
                                                senha1 = Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Parabéns conta acessada!");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.WriteLine($"Cartão: {cont1} DIG: {DIG1}");
                                                Console.WriteLine("|Saldo: R$1.723,65                           |");
                                                Console.WriteLine("|Gasto esse mês: R$3.876,35                  |");
                                                Console.WriteLine("+--------------------------------------------+");
                                                Console.Read();

                                                break;
                                            }

                                        case 0:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }

                                    }

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }


                        break;
                    }

                case 7:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Desbloqueio");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("Identificação...");
                        Console.ReadLine();

                        Console.WriteLine("Digite o codigo da conta:");
                        cont1 = Console.ReadLine();

                        Console.WriteLine("Digite o digito verificador:");
                        DIG1 = Console.ReadLine();

                        Console.WriteLine("Digite sua senha:");
                        senha1 = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Parabéns conta acessada!");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+------------------------------------------------------------+");
                        Console.WriteLine("|Para desbloquear a conta precisa pagar a divida de R$650,00 |");
                        Console.WriteLine("+------------------------------------------------------------+");
                        Console.ReadLine();

                        Console.WriteLine("+-------------------------------+");
                        Console.WriteLine("Como deseja Pagar?              |");
                        Console.WriteLine("Escolha uma forma de pagamento: |");
                        Console.WriteLine("+------------------------------+");
                        Console.WriteLine("|1. Dinheiro                    |");
                        Console.WriteLine("|2. Cartão de crédito           |");
                        Console.WriteLine("|3. cartão de débito            |");
                        Console.WriteLine("|4. PIX                         |");
                        Console.WriteLine("|5. Cheque                      |");
                        Console.WriteLine("|6. Carnê                       |");
                        Console.WriteLine("|7. Agendar pagamento           |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("                        |");
                        Console.WriteLine("+------------------------------+");
                        n7 = int.Parse(Console.ReadLine());

                        switch (n7)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Dinheiro");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Vá a loterica mais proxima e pague");
                                    Console.Read();

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Cartão de crédito");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor séra cobrado no seu cartão");
                                    Console.Read();

                                    break;
                                }

                            case 3:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Cartão de débito");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor será cobrado no seu cartão");
                                    Console.Read();

                                    break;
                                }

                            case 4:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: PIX");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Use o codigo a seguir para pagar");
                                    Console.WriteLine("1234567890_");
                                    Console.Read();

                                    break;
                                }

                            case 5:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Chaque");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor será retirado da sua conta");
                                    Console.Read();

                                    break;
                                }

                            case 6:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Carnê");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Vá a loterica mais proxima e pague");
                                    Console.Read();

                                    break;
                                }

                            case 7:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Agendar pagamento");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("Identificação...");
                                    Console.ReadLine();

                                    Console.WriteLine("Digite o codigo da conta:");
                                    cont1 = Console.ReadLine();

                                    Console.WriteLine("Digite o digito verificador:");
                                    DIG1 = Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine($"|Usuario: {cont1}  DIG: {DIG1} CPF: 000000000/00");
                                    Console.WriteLine("|receptor: Ekballo                                            |");
                                    Console.WriteLine("|                                                             |");
                                    Console.WriteLine("|Total a pagar: R$650,00                                       |");
                                    Console.WriteLine("|Expira em 31/02/2024                                         |");
                                    Console.WriteLine("+-------------------------------------------------------------+");
                                    Console.WriteLine("Esse valor se não for pago será cobrado em juros");
                                    Console.WriteLine("Qual dia vc deseja pagar: ");
                                    dt1 = Console.ReadLine();
                                    Console.WriteLine($"Sua conta será paga em {dt1}");
                                    Console.Read();

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }


                        break;
                    }

                case 8:
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Opção selecionada: Fatura");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("Identificação...");
                        Console.ReadLine();

                        Console.WriteLine("Digite o codigo da conta:");
                        cont1 = Console.ReadLine();

                        Console.WriteLine("Digite o digito verificador:");
                        DIG1 = Console.ReadLine();

                        Console.WriteLine("Digite sua senha:");
                        senha1 = Console.ReadLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Parabéns conta acessada!");
                        Console.ResetColor();
                        Console.ReadLine();

                        Console.WriteLine("+-------------------+");
                        Console.WriteLine("|O que deseja ver?  |");
                        Console.WriteLine("+-------------------+");
                        Console.WriteLine("|1. Ganhos pessoais |");
                        Console.WriteLine("|2. Plano com banco |");
                        Console.Write("|0. ");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair");
                        Console.ResetColor();

                        Console.WriteLine("            |");
                        Console.WriteLine("+-------------------+");
                        n8 = int.Parse(Console.ReadLine());

                        switch (n8)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Ganhos pessoais");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+---------------------+");
                                    Console.WriteLine("|O que deseja ver?    |");
                                    Console.WriteLine("+---------------------+");
                                    Console.WriteLine("|1. Ver investimentos |");
                                    Console.WriteLine("|2. Investir          |");
                                    Console.Write("|0. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Sair");
                                    Console.ResetColor();

                                    Console.WriteLine("              |");
                                    Console.WriteLine("+---------------------+");
                                    invest1 = int.Parse(Console.ReadLine());

                                    switch (invest1)
                                    {
                                        case 1:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Ver investimentos");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+---------------------+-----------------------+----------------------|--------------------------|-------------------------------|---------------------------------------------------|");
                                                Console.WriteLine("| Ativo               | Tipo de Investimento  | Valor Investido (R$) | Percentual do Portfólio  | Potencial de Retorno Esperado | Observações                                       |");
                                                Console.WriteLine("+---------------------+-----------------------+----------------------|--------------------------|-------------------------------|---------------------------------------------------|");
                                                Console.WriteLine("| Empresa A (Ações)   | Ações                 | 50,000               | 25%                      | 15% ao ano                    | Líder no setor de tecnologia; Dividendos estáveis |");
                                                Console.WriteLine("| StartUp B           | Private Equity        | 30,000               | 15%                      | 30% ao ano                    | Inovação em IA; Estágio inicial                   |");
                                                Console.WriteLine("| Energia Limpa Fundo | Fundo de Investimento | 40,000               | 20%                      | 10% ao ano                    | Diversificação em energias renováveis             |");
                                                Console.WriteLine("| Empresa C (Ações)   | Ações                 | 35,000               | 17.5%                    | 12% ao ano                    | Setor de saúde; Potencial de crescimento          |");
                                                Console.WriteLine("| StartUp D           | Venture Capital       | 25,000               | 12.5%                    | 25% ao ano                    | E-commerce; Estratégia de crescimento sólido      |");
                                                Console.WriteLine("+---------------------+-----------------------+----------------------|--------------------------|-------------------------------|---------------------------------------------------|");
                                                Console.WriteLine("| Total Investido     |                       | 180,000              | 100%                     | -                             | -                                                 |");
                                                Console.WriteLine("+---------------------+-----------------------+----------------------|--------------------------|-------------------------------|---------------------------------------------------|");
                                                Console.ReadLine();

                                                Console.WriteLine($"{agradecimento}");
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Opção selecionada: Investir");
                                                Console.ResetColor();
                                                Console.ReadLine();

                                                Console.WriteLine("+------------+---------------------+-----------------------+------------+---------------------+------------------+-------------------+");
                                                Console.WriteLine("| Data       | Ativo               | Tipo de Investimento  | Quantidade | Preço Unitário (R$) | Valor Total (R$) | Corretora         |");
                                                Console.WriteLine("+------------+---------------------+-----------------------+------------+---------------------+------------------+-------------------+");
                                                Console.WriteLine("| 2024-01-15 | Empresa A (Ações)   | Ações                 | 100        | 50.00               | 5,000            | ABC Investimentos |");
                                                Console.WriteLine("| 2024-02-01 | StartUp B           | Private Equity        | 10         | 3,000.00            | 30,000           | XYZ Investimentos |");
                                                Console.WriteLine("| 2024-03-10 | Energia Limpa Fundo | Fundo de Investimento | 50         | 800.00              | 40,000           | DEF Investimentos |");
                                                Console.WriteLine("| 2024-04-05 | Empresa C (Ações)   | Ações                 | 75         | 46.67               | 3,500            | ABC Investimentos |");
                                                Console.WriteLine("| 2024-05-20 | StartUp D           | Venture Capital       | 20         | 1,250.00            | 25,000           | XYZ Investimentos |");
                                                Console.WriteLine("+------------+---------------------+-----------------------+------------+---------------------+------------------+-------------------+");
                                                Console.ReadLine();

                                                Console.WriteLine("Caso queira comprar um desses investimentos entre em www.Ekballo.com.br");
                                                Console.Read();

                                                break;
                                            }

                                        case 0:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Plano com banco");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+");
                                    Console.WriteLine("|Seu plano: Empresarial                                                                                                                                                          |");
                                    Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                    Console.WriteLine("| Plano              | Descrição                                            | Taxa Mensal (R$) | Cartão de Crédito | Benefícios Adicionais                                       |");
                                    Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                    Console.WriteLine("| Básico             | Serviços essenciais para o dia a dia                 | 5,00             | Não               | - Acesso a caixas eletrônicos sem taxa                      |");
                                    Console.WriteLine("| Standard           | Pacote intermediário com benefícios adicionais       | 10,00            | Sim               | - Programa de pontos no cartão de crédito                   |");
                                    Console.WriteLine("| Gold               | Benefícios premium e atendimento personalizado       | 20,00            | Sim               | - Seguro de viagem, atendimento VIP                         |");
                                    Console.WriteLine("| Empresarial        | Soluções financeiras para empresas                   | 30,00            | Sim               | - Gerenciamento de contas empresariais, análise de crédito  |");
                                    Console.WriteLine("| Universitário      | Ofertas exclusivas para estudantes                   | 2,50             | Sim               | - Isenção de tarifas durante a graduação                    |");
                                    Console.WriteLine("| Internacional      | Para clientes que realizam transações internacionais | 15,00            | Sim               | - Saques em moeda estrangeira sem taxas, assistência global |");
                                    Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                    Console.WriteLine();
                                    Console.WriteLine("+-----------------------+");
                                    Console.WriteLine("|Deseja trocar de plano?|");
                                    Console.WriteLine("+-----------------------+");
                                    Console.WriteLine("|1. Sim                 |");
                                    Console.Write("|2. ");

                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Não e sair");
                                    Console.ResetColor();

                                    Console.WriteLine("          |");
                                    Console.WriteLine("+-----------------------+");
                                    bank1 = int.Parse(Console.ReadLine());

                                    switch (bank1)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                                Console.WriteLine("|Qual você deseja?                                                                                                                                                               |");
                                                Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                                Console.WriteLine("| Plano              | Descrição                                            | Taxa Mensal (R$) | Cartão de Crédito | Benefícios Adicionais                                       |");
                                                Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                                Console.WriteLine("| 1. Básico          | Serviços essenciais para o dia a dia                 | 5,00             | Não               | - Acesso a caixas eletrônicos sem taxa                      |");
                                                Console.WriteLine("| 2. Standard        | Pacote intermediário com benefícios adicionais       | 10,00            | Sim               | - Programa de pontos no cartão de crédito                   |");
                                                Console.WriteLine("| 3. Gold            | Benefícios premium e atendimento personalizado       | 20,00            | Sim               | - Seguro de viagem, atendimento VIP                         |");
                                                Console.WriteLine("| 4. Empresarial     | Soluções financeiras para empresas                   | 30,00            | Sim               | - Gerenciamento de contas empresariais, análise de crédito  |");
                                                Console.WriteLine("| 5. Universitário   | Ofertas exclusivas para estudantes                   | 2,50             | Sim               | - Isenção de tarifas durante a graduação                    |");
                                                Console.WriteLine("| 6. Internacional   | Para clientes que realizam transações internacionais | 15,00            | Sim               | - Saques em moeda estrangeira sem taxas, assistência global |");
                                                Console.WriteLine("+--------------------+------------------------------------------------------+------------------+-------------------+-------------------------------------------------------------+");
                                                Console.WriteLine();
                                                bank2 = int.Parse(Console.ReadLine());

                                                switch (bank2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 2:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 3:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 4:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 5:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    case 6:
                                                        {
                                                            Console.WriteLine("Confirme sua senha:");
                                                            Console.ReadLine();

                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("Confirmado");
                                                            Console.ResetColor();
                                                            Console.WriteLine($"{agradecimento}");
                                                            Console.Read();

                                                            break;
                                                        }

                                                    default:
                                                        {
                                                            Console.ReadLine();

                                                            Console.WriteLine($"{default1}");
                                                            Console.Read();

                                                            break;
                                                        }
                                                }

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }


                        break;
                    }

                case 9:
                    {
                        

                        Console.WriteLine("Identificação...");
                        Console.ReadLine();

                        Console.WriteLine("Digite o codigo da conta:");
                        cont1 = Console.ReadLine();

                        Console.ReadLine();

                        Console.WriteLine("Digite o digito verificador:");
                        DIG1 = Console.ReadLine();

                        Console.ReadLine();

                        Console.WriteLine("Digite sua senha:");
                        senha1 = Console.ReadLine();

                        Console.ReadLine();

                        Console.WriteLine("+-------------------------+");
                        Console.WriteLine("|Escolha a opção desejada:|");
                        Console.WriteLine("+-------------------------+");
                        Console.WriteLine("|1. Transferência         |");
                        Console.WriteLine("|2. Histórico             |");
                        Console.WriteLine("|3. Bloqueio              |");
                        Console.Write("|0. ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Sair                  ");
                        Console.ResetColor();
                        Console.WriteLine("|");
                        Console.WriteLine("+-------------------------+");
                        n9 = int.Parse(Console.ReadLine());

                        switch (n9)
                        {
                            case 1:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Transferência");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.Write("Insira a chave-PIX que deseja enviar o PIX:");
                                    pix1 = Console.ReadLine();

                                    Console.ReadLine();

                                    Console.Write("Qual o valor que deseja fazer o PIX: R$");
                                    valor1 = Console.ReadLine();

                                    Console.ReadLine();

                                    Console.WriteLine("Digite sua senha:");
                                    senha1 = Console.ReadLine();

                                    Console.ReadLine();

                                    Console.WriteLine("+-------------------------------+");
                                    Console.WriteLine("|Deseja confirmar Trânsferencia?|");
                                    Console.WriteLine("+-------------------------------+");
                                    Console.WriteLine("|1. Sim                         |");
                                    Console.WriteLine("|2. ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Não e sair                  ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    Console.WriteLine("+-------------------------------+");
                                    confirm1 = int.Parse(Console.ReadLine());

                                    switch (confirm1)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("+---------------------+");
                                                Console.WriteLine("|PIX Efetuado         |");
                                                Console.WriteLine("+---------------------+");
                                                Console.WriteLine($"|Você: {cont1}-{DIG1}");
                                                Console.WriteLine($"|Destinatário {pix1}");
                                                Console.WriteLine("+---------------------+");
                                                Console.WriteLine($"|Valor R${valor1}");
                                                Console.WriteLine("+---------------------+");
                                                Console.Read();


                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{Sair_da_pagina}");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 2:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Histórico");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.ReadLine();

                                    Console.WriteLine("+------------------------------------------------------------+");
                                    Console.WriteLine("|PIX Histórico                                               |");
                                    Console.WriteLine("+---------------------+------------+---------------+---------+");
                                    Console.WriteLine("| Data e Hora         | Remetente  | Destinatário  |  Valor  |");
                                    Console.WriteLine("+---------------------+------------+---------------+---------+");
                                    Console.WriteLine("| 2022-01-09 15:30:00 | João       | Maria         | R$100,00|");
                                    Console.WriteLine("| 2022-01-10 08:45:00 | Carlos     | Ana           | R$75,00 |");
                                    Console.WriteLine("| 2022-01-12 14:20:00 | Camila     | Pedro         | R$120,50|");
                                    Console.WriteLine("| 2022-02-05 18:00:00 | Maria      | João          | R$50,00 |");
                                    Console.WriteLine("| 2022-02-10 10:30:00 | Ana        | Carlos        | R$90,00 |");
                                    Console.WriteLine("| 2022-03-03 16:15:00 | Pedro      | Camila        | R$30,00 |");
                                    Console.WriteLine("| 2022-03-18 12:45:00 | João       | Maria         | R$80,00 |");
                                    Console.WriteLine("| 2022-04-02 09:00:00 | Carlos     | Ana           | R$110,00|");
                                    Console.WriteLine("| 2022-04-15 20:30:00 | Camila     | Pedro         | R$65,50 |");
                                    Console.WriteLine("| 2022-05-01 17:45:00 | Maria      | João          | R$40,00 |");
                                    Console.WriteLine("+---------------------+------------+---------------+---------+");
                                    Console.Read();

                                    break;
                                }

                            case 3:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Opção selecionada: Bloqueio");
                                    Console.ResetColor();
                                    Console.ReadLine();

                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|Deseja bloquear seu PIX?: |");
                                    Console.WriteLine("+--------------------------+");
                                    Console.WriteLine("|1. Sim                    |");
                                    Console.Write("|2. ");
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Write("Não e sair             ");
                                    Console.ResetColor();
                                    Console.WriteLine("|");
                                    block1 = int.Parse(Console.ReadLine());

                                    switch (block1)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Confirme sua senha:");
                                                Console.ReadLine();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Confirmado");
                                                Console.ResetColor();
                                                Console.WriteLine("Obrigado por escolher o banco Ekballo!");
                                                Console.Read();

                                                break;
                                            }

                                        case 2:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine("Saindo, obrigado por escolher o banco Ekballo!");
                                                Console.Read();

                                                break;
                                            }

                                        default:
                                            {
                                                Console.ReadLine();

                                                Console.WriteLine($"{default1}");
                                                Console.Read();

                                                break;
                                            }
                                    }

                                    break;
                                }

                            case 0:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{Sair_da_pagina}");
                                    Console.Read();

                                    break;
                                }

                            default:
                                {
                                    Console.ReadLine();

                                    Console.WriteLine($"{default1}");
                                    Console.Read();

                                    break;
                                }
                        }


                        break;
                    }

                case 0:
                    {
                        Console.ReadLine();

                        Console.WriteLine($"{Sair_da_pagina}");
                        Console.Read();

                        break;
                    }

                default:
                    {
                        Console.ReadLine();

                        Console.WriteLine($"{default1}");
                        Console.Read();

                        break;
                    }
            }
        }
    }
}
