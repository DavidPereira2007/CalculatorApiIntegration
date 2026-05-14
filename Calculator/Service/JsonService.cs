using System;
using System.Text.Json;

namespace HandlerJson
{
    public static class JsonService
    {
        public static void Save<T>(string path, T dados) // salva os dados em um arquivo json
        {
            
            string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, json);
        }

        public static T? Read<T>(string path) // Lê um arquivo Json  (Transforma um arquivo json em um objeto C# de acordo com o tipo passado)
        {
            if (!File.Exists(path))
                return default;

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }


        public static string GetDocumentsPath(string fileName, string Pastename, bool Docs) // Retorna o path com o diretorio que for escolhido
        {
            string pasta;
            if (Docs == true)
            {
                pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Se True o diretorio será nos documentos do computador
            }
            else
            {
                pasta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData); // Se False o diretorio será no appData do computador
            }
            

            string appFolder = Path.Combine(pasta, Pastename);

            Directory.CreateDirectory(appFolder);

            return Path.Combine(appFolder, fileName);
        }

        /*
        Outro ponto importante JSON válido precisa ter uma raiz única ou seja não é possivel salvar por exemplo duas classes
        de forma separada no json, pra isso você precisa incorporar tudo em um só exemplo:
        para salvar a classe player e a classe inventario:
        você precisa criar elas separadamente e criar uma classe mãe que vai ter tudo
        public class SaveData // Criei a class SaveData que vai guardar as classes Player e Inventario e o que mais eu precisar de dados
        {
            public Player Player { get; set; }
            public Inventario Inventario { get; set; }
        }

        Usa assim:
        var save = new SaveData
        {
            Player = new Player { Nome = "David", Nivel = 10 },
            Inventario = new Inventario { Itens = new List<string> { "Espada" } }
        };

        JsonService.Salvar(path, save);

        Ler depois:
        var save = JsonService.Ler<SaveData>(path);

        Console.WriteLine(save.Player.Nome);

        
        */

        /*
        Exemplo simples

        string path = @"C:\Projetos\DevTecs\Tecnologias\NumerosSave.json"; // Caminho
        List<int> Numeros = new List<int> {1, 2, 3, 4, 5, 6, 7}; // Vamos usar como exemplo uma lista mas aqui pode ser classe, dicionarios, vetores, etc...

        JsonService.Salvar(path, Numeros); -- usando o JsonService para salvar, mandei a path e a lista Numeros

        var Resultado = JsonService.Ler<List<int>>(path); -- Lendo e armazenando na variavel Resultado
        // Tendo uma variavel com o arquivo lido (Ou seja convertido em um objeto) agora podemos modificar ele como quisermos
        // Ou seja podemos adicionar mais dados (de acordo com o tipo dele), imprimir e usar como quiser
        // Um exemplo de modificação
        List<int> Numeros2 = new List<int> {8, 9, 10, 11, 12, 13}; // Aqui criei uma nova lista para o exemplo

        if (Resultado != null) // Importante checkar se o resultado não veio igual a null
        {
            Resultado.AddRange(Numeros2); // Adicionei lista Numeros2 ao Resultando usando o Método AddRange
        }

        JsonService.Salvar(path, Resultado); // salvei o arquivo todo de novo

        // è importante sempre olhar com atenção quando for salvar já que você vai sobrescrever todos os dados então tenha certeza que os dados vão persistir
        // seja os que não foram modificados ou os que foram adicionados

        // siga sempre essa lógica
        // - Ler
        // - Modificar
        // - salvar
        
        
        */

    }
}
