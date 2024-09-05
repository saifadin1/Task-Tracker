while (true)
{
    string command = Console.ReadLine();
    string[] commands = command.Split(' ');
    if(commands.Length == 1 && commands[0] == "exit")
    {
        break;
    }
    if (commands.Length == 2 && commands[0] == "add")
    {
        string description = commands[1];
        Task task = new Task(Status.todo.ToString(), description);
        Data.AddTask(task);
    }
    if(commands.Length == 1 && commands[0] == "list"){
        Data.ListTasks();
    }
}   