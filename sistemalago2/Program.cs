using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistemalago2;

namespace InSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<tarefassalvas> tasks = new List<tarefassalvas>();

            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Adicionar nova tarefa");
                Console.WriteLine("2 - Marcar tarefa como concluída");
                Console.WriteLine("3 - Listar tarefas pendentes");
                Console.WriteLine("4 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("------! Adicionar nova tarefa selecionado! ------");

                        Console.WriteLine("Tarefa Nova: ");
                        string Tarefa = Console.ReadLine();

                        Console.WriteLine("O que fazer: ");
                        string Conteudo = Console.ReadLine();

                        Console.WriteLine("Por que fazer: ");
                        string Pfazer = Console.ReadLine();

                        tarefassalvas novaTarefa = new tarefassalvas
                        {
                            Id = tasks.Count + 1,
                            Title = Tarefa,
                            Content = Conteudo,
                            Pfazer = Pfazer,
                            IsCompleted = false
                        };

                        tasks.Add(novaTarefa);

                        Console.Clear();

                        Console.WriteLine("Tarefa salva:\n");
                        Console.WriteLine($"Título: {novaTarefa.Title}");
                        Console.WriteLine($"Conteúdo: {novaTarefa.Content}");
                        Console.WriteLine($"Por que fazer: {novaTarefa.Pfazer}");
                        break;

                    case 2:
                        Console.WriteLine("Digite o ID da tarefa que deseja marcar como concluída:");
                        int taskIdToComplete = int.Parse(Console.ReadLine());

                        tarefassalvas taskToComplete = tasks.Find(task => task.Id == taskIdToComplete);
                        if (taskToComplete != null)
                        {
                            taskToComplete.IsCompleted = true;
                            Console.WriteLine($"Tarefa '{taskToComplete.Title}' marcada como concluída.");
                        }
                        else
                        {
                            Console.WriteLine("Tarefa não encontrada.");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Tarefas pendentes:\n");
                        foreach (var tarefa in tasks)
                        {
                            if (!tarefa.IsCompleted)
                            {
                                Console.WriteLine($"ID: {tarefa.Id}");
                                Console.WriteLine($"Título: {tarefa.Title}");
                                Console.WriteLine($"Conteúdo: {tarefa.Content}");
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
