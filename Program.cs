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
    if(commands.Length == 2 && commands[0] == "mark-in-progress")
    {
        int id = Convert.ToInt32(commands[1]);
        Data.MarkTaskInProgress(id);
    }
    if(commands.Length == 2 && commands[0] == "mark-done")
    {
        int id = Convert.ToInt32(commands[1]);
        Data.MarkTaskDone(id);
    }
}   