using System;
public class deputado
{
    public string? nome;
    public string? partido;
    public int numero;
    public Votos? votos;

    public void DisputaEleitoralDeputado(deputado A, deputado B)
    {
        this.votos.QuantidadeVotos = new Random().Next(0,100);
        A.votos.QuantidadeVotos = new  Random().Next(0,100);
        B.votos.QuantidadeVotos = new  Random().Next(0,100);

        if((this.votos.QuantidadeVotos > B.votos.QuantidadeVotos) && (this.votos.QuantidadeVotos > A.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {this.votos.QuantidadeVotos}% dos votos o candidato {this.nome} do partido {this.partido} ganhou para Deputado Estadual.");
            Console.WriteLine($"O Candidado {A.nome} do partido {A.partido} ficou com {A.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {B.nome} do partido {B.partido} ficou com {B.votos.QuantidadeVotos}% na sua cidade.\n");
        }
        
        if((A.votos.QuantidadeVotos > B.votos.QuantidadeVotos) && (A.votos.QuantidadeVotos > this.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {A.votos.QuantidadeVotos}% dos votos o candidato {A.nome} do partido {A.partido} ganhou para Deputado Estadual.");
            Console.WriteLine($"O Candidado {this.nome} do partido {this.partido} ficou com {this.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {B.nome} do partido {B.partido} ficou com {B.votos.QuantidadeVotos}% na sua cidade.\n");
        }
        if((B.votos.QuantidadeVotos > A.votos.QuantidadeVotos) && (B.votos.QuantidadeVotos > this.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {B.votos.QuantidadeVotos}% dos votos o candidato {B.nome} do partido {B.partido} ganhou para Deputado Estadual.");
            Console.WriteLine($"O Candidado {A.nome} do partido {A.partido} ficou com {A.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {this.nome} do partido {this.partido} ficou com {this.votos.QuantidadeVotos}% na sua cidade.\n");
        }
    }

    public void IntencaoVoto(deputado A, deputado B)
    {
        this.votos.QuantidadeVotos = new Random().Next(0,100);
        A.votos.QuantidadeVotos = new  Random().Next(0,100);
        B.votos.QuantidadeVotos = new  Random().Next(0,100);

        if((this.votos.QuantidadeVotos > B.votos.QuantidadeVotos) && (this.votos.QuantidadeVotos > A.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {this.votos.QuantidadeVotos}% de intenção de votos o candidato {this.nome} do partido {this.partido} está em disparada para Deputado Estadual.");
            Console.WriteLine($"O Candidado {A.nome} do partido {A.partido} estava com {A.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {B.nome} do partido {B.partido} estava com {B.votos.QuantidadeVotos}% na sua cidade.\n");
        }
        
        if((A.votos.QuantidadeVotos > B.votos.QuantidadeVotos) && (A.votos.QuantidadeVotos > this.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {A.votos.QuantidadeVotos}% de intenção de votos o candidato {A.nome} do partido {A.partido} está em disparada para Deputado Estadual.");
            Console.WriteLine($"O Candidado {this.nome} do partido {this.partido} estava com {this.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {B.nome} do partido {B.partido} estava com {B.votos.QuantidadeVotos}% na sua cidade.\n");
        }
        if((B.votos.QuantidadeVotos > A.votos.QuantidadeVotos) && (B.votos.QuantidadeVotos > this.votos.QuantidadeVotos)){
        
            Console.WriteLine($"\nCom {B.votos.QuantidadeVotos}% de intenção de votos o candidato {B.nome} do partido {B.partido} está em disparada para Deputado Estadual.");
            Console.WriteLine($"O Candidado {A.nome} do partido {A.partido} estava com {A.votos.QuantidadeVotos}% na sua cidade.");
            Console.WriteLine($"O Candidado {this.nome} do partido {this.partido} estava com {this.votos.QuantidadeVotos}% na sua cidade.\n");
        }
    }
}