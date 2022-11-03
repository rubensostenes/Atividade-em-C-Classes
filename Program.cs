using System;
class Program
{
    public static void Main(string[] args)
    {   
        bool saida = false;
        Console.Clear();


        Governador CandidatoGoverno1 = new Governador();
        CandidatoGoverno1.nome = "ANDERSON FERREIRA";
        CandidatoGoverno1.partido = "PL";
        CandidatoGoverno1.numero = 22;
        CandidatoGoverno1.votos = new Votos();
        CandidatoGoverno1.votos.cidade = "JABOATÃO DOS GUARARAPES";
        
        Governador CandidatoGoverno2 = new Governador();
        CandidatoGoverno2.nome = "MARÍLIA ARRAES";
        CandidatoGoverno2.partido = "SOLIDARIERADE";
        CandidatoGoverno2.numero = 77;
        CandidatoGoverno2.votos = new Votos();
        CandidatoGoverno2.votos.cidade = "RECIFE";

        Governador CandidatoGoverno3 = new Governador();
        CandidatoGoverno3.nome = "MIGUEL COELHO";
        CandidatoGoverno3.partido = "UNIÃO";
        CandidatoGoverno3.numero = 44;
        CandidatoGoverno3.votos = new Votos();
        CandidatoGoverno3.votos.cidade = "PETROLINA";
        


        presidente CandidatoPresidente1 = new presidente();
        CandidatoPresidente1.nome = "JAIR BOLSONARO";
        CandidatoPresidente1.partido = "PL";
        CandidatoPresidente1.numero = 22;
        CandidatoPresidente1.votos = new Votos();
        CandidatoPresidente1.votos.cidade = "DISTRITO FEDERAL";
        
        presidente CandidatoPresidente2 = new presidente();
        CandidatoPresidente2.nome = "LULA";
        CandidatoPresidente2.partido = "PT";
        CandidatoPresidente2.numero = 13;
        CandidatoPresidente2.votos = new Votos();
        CandidatoPresidente2.votos.cidade = "SERGIPE";
        
        presidente CandidatoPresidente3 = new presidente();
        CandidatoPresidente3.nome = "CIRO";
        CandidatoPresidente3.partido = "PDT";
        CandidatoPresidente3.numero = 12;
        CandidatoPresidente3.votos = new Votos();
        CandidatoPresidente3.votos.cidade = "CEARÁ";
        


        prefeito CandidatoPrefeito1 = new prefeito();
        CandidatoPrefeito1.nome = "WOLVERINE";
        CandidatoPrefeito1.partido = "PL";
        CandidatoPrefeito1.numero = 11;
        CandidatoPrefeito1.votos = new Votos();
        CandidatoPrefeito1.votos.cidade = "ACRE";
        
        prefeito CandidatoPrefeito2 = new prefeito();
        CandidatoPrefeito2.nome = "JOSIVALDO";
        CandidatoPrefeito2.partido = "PT";
        CandidatoPrefeito2.numero = 69;
        CandidatoPrefeito2.votos = new Votos();
        CandidatoPrefeito2.votos.cidade = "MARANHÃO";
        
        prefeito CandidatoPrefeito3 = new prefeito();
        CandidatoPrefeito3.nome = "LUAN";
        CandidatoPrefeito3.partido = "PDT";
        CandidatoPrefeito3.numero = 00;
        CandidatoPrefeito3.votos = new Votos();
        CandidatoPrefeito3.votos.cidade = "PERNAMBUCO";

    

        senador CandidatoSenador1 = new senador();
        CandidatoSenador1.nome = "MARQUINHOS";
        CandidatoSenador1.partido = "PL";
        CandidatoSenador1.numero = 321;
        CandidatoSenador1.votos = new Votos();
        CandidatoSenador1.votos.cidade = "AMAZONAS";
        
        senador CandidatoSenador2 = new senador();
        CandidatoSenador2.nome = "CARLINHOS";
        CandidatoSenador2.partido = "PT";
        CandidatoSenador2.numero = 964;
        CandidatoSenador2.votos = new Votos();
        CandidatoSenador2.votos.cidade = "BAHIA";
        
        senador CandidatoSenador3 = new senador();
        CandidatoSenador3.nome = "CABEÇA";
        CandidatoSenador3.partido = "PDT";
        CandidatoSenador3.numero = 765;
        CandidatoSenador3.votos = new Votos();
        CandidatoSenador3.votos.cidade = "CEARÁ";



        vereador CandidatoVereador1 = new vereador();
        CandidatoVereador1.nome = "PATRICIO PALOSO";
        CandidatoVereador1.partido = "PL";
        CandidatoVereador1.numero = 23345;
        CandidatoVereador1.votos = new Votos();
        CandidatoVereador1.votos.cidade = "DISTRITO FEDERAL";
        
        vereador CandidatoVereador2 = new vereador();
        CandidatoVereador2.nome = "BILADEN";
        CandidatoVereador2.partido = "PT";
        CandidatoVereador2.numero = 13223;
        CandidatoVereador2.votos = new Votos();
        CandidatoVereador2.votos.cidade = "SERGIPE";
        
        vereador CandidatoVereador3 = new vereador();
        CandidatoVereador3.nome = "PAULO BOSTA";
        CandidatoVereador3.partido = "PDT";
        CandidatoVereador3.numero = 12933;
        CandidatoVereador3.votos = new Votos();
        CandidatoVereador3.votos.cidade = "CEARÁ";


        
        deputado CandidatoDeputado1 = new deputado();
        CandidatoDeputado1.nome = "ALISSON DO GERA";
        CandidatoDeputado1.partido = "PL";
        CandidatoDeputado1.numero = 22323;
        CandidatoDeputado1.votos = new Votos();
        CandidatoDeputado1.votos.cidade = "DISTRITO FEDERAL";
        
        deputado CandidatoDeputado2 = new deputado();
        CandidatoDeputado2.nome = "PEDRO BROXA";
        CandidatoDeputado2.partido = "PT";
        CandidatoDeputado2.numero = 22213;
        CandidatoDeputado2.votos = new Votos();
        CandidatoDeputado2.votos.cidade = "SERGIPE";
        
        deputado CandidatoDeputado3 = new deputado();
        CandidatoDeputado3.nome = "CARLINHOS DA IGREJA";
        CandidatoDeputado3.partido = "PDT";
        CandidatoDeputado3.numero = 12321;
        CandidatoDeputado3.votos = new Votos();
        CandidatoDeputado3.votos.cidade = "CEARÁ";
        
        
        while(!saida){
            
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("        Qual voce quer ver primeiro? ");
            Console.WriteLine("              g - governo");
            Console.WriteLine("              p - presidente");
            Console.WriteLine("              n - senador");
            Console.WriteLine("              v - vereador");
            Console.WriteLine("              d - deputado");
            Console.WriteLine("              r - prefeito");
            Console.WriteLine("              s - sair");
            Console.WriteLine("-----------------------------------------------");
            Console.Write("                Opcao: "); 

            switch(Console.ReadLine())
            {    
                case "g":
                    Console.Clear();
                    CandidatoGoverno1.DisputaEleitoralGovernador(CandidatoGoverno2, CandidatoGoverno3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoGoverno1.IntencaoVoto(CandidatoGoverno2, CandidatoGoverno3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();     
                break;
            
                case "p":
                    Console.Clear();
                    CandidatoPresidente1.DisputaEleitoralPresidente(CandidatoPresidente2, CandidatoPresidente3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoPresidente1.IntencaoVoto(CandidatoPresidente2, CandidatoPresidente3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();
                break;

                case "n":
                    Console.Clear();
                    CandidatoSenador1.DisputaEleitoralSenador(CandidatoSenador2, CandidatoSenador3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoSenador1.IntencaoVoto(CandidatoSenador2, CandidatoSenador3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();
                break;

                case "v":
                    Console.Clear();
                    CandidatoVereador1.DisputaEleitoralVereador(CandidatoVereador2, CandidatoVereador3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoVereador1.IntencaoVoto(CandidatoVereador2, CandidatoVereador3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();
                break;

                case "d":
                    Console.Clear();
                    CandidatoDeputado1.DisputaEleitoralDeputado(CandidatoDeputado2, CandidatoDeputado3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoDeputado1.IntencaoVoto(CandidatoDeputado2, CandidatoDeputado3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();
                break;
                
                case "r":
                    Console.Clear();
                    CandidatoPrefeito1.DisputaEleitoralPrefeito(CandidatoPrefeito2, CandidatoPrefeito3);

                    Console.WriteLine("Antes das votações os dados eram de: ");

                    CandidatoPrefeito1.IntencaoVoto(CandidatoPrefeito2, CandidatoPrefeito3);
                    Console.Write("Aperte Enter para voltar a tela de Menu...");
                    Console.ReadKey();
                    Console.Clear();
                break;

                case "s":
                    Console.Clear();
                    Console.WriteLine("Tchau, nessas eleições vote conciente!!!\n");
                    saida = true;
                break;

                default:
                    Console.Clear();
                    Console.Write("\nNão exite mano, faz de novo ou cai fora.\n");
                break;
            }
        }
    }
}