Console.OutputEncoding = System.Text.Encoding.UTF8;

var manager = new TaskManager();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("===== TaskFlow =====");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Concluir tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            AddTask();
            break;
        case "2":
            ListTasks();
            break;
        case "3":
            CompleteTask();
            break;
        case "0":
            running = false;
            Console.WriteLine("Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

void AddTask()
{
    Console.Write("Título da tarefa: ");
    var title = Console.ReadLine() ?? string.Empty;

    try
    {
        var task = manager.AddTask(title);
        Console.WriteLine($"Tarefa \"{task.Title}\" adicionada!");
    }
    catch (ArgumentException)
    {
        Console.WriteLine("Erro: o título não pode ser vazio.");
    }
}

void ListTasks()
{
    if (manager.Tasks.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada.");
        return;
    }

    int number = 1;
    foreach (var task in manager.Tasks)
    {
        var status = task.IsCompleted ? "[X]" : "[ ]";
        Console.WriteLine($"{number} - {status} {task.Title}");
        number++;
    }
}

void CompleteTask()
{
    ListTasks();
    if (manager.Tasks.Count == 0)
    {
        return;
    }

    Console.Write("Número da tarefa a concluir: ");
    if (int.TryParse(Console.ReadLine(), out int number)
        && number >= 1 && number <= manager.Tasks.Count)
    {
        var task = manager.Tasks.ElementAt(number - 1);
        manager.CompleteTask(task.Id);
        Console.WriteLine($"Tarefa \"{task.Title}\" concluída!");
    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}
