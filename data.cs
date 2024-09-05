public static class Data
{
    public readonly static string path = @"D:\C#_Projects\TaskTracker\Tasks.json";
    public static void AddTask(Task task)
    {
        if (!File.Exists(path))
        {
            File.Create(path).Dispose();
            Console.WriteLine("File not found");
        }
        if(new FileInfo(path).Length == 0)
        {
            File.WriteAllText(path, "[]");
        }
        var text = File.ReadAllText(path);
        JArray json = JArray.Parse(text);
        int id = json.Count + 1;
        task.id = id;
        JObject taskObject = JObject.FromObject(task);
        json.Add(taskObject);
        File.WriteAllText(path, json.ToString());
        Console.WriteLine($"Task added successfully (ID: {task.id})");
    }
    public static void ListTasks()
    {
        var text = File.ReadAllText(path);
        JArray json = JArray.Parse(text);
        if(json.Count == 0)
        {
            Console.WriteLine("No tasks Added yet");
            return;
        }
        foreach (var task in json)
        {
            Console.WriteLine($"ID: {task["id"]}");
            Console.WriteLine($"Status: {task["status"]}");
            Console.WriteLine($"Description: {task["description"]}");
            Console.WriteLine($"Created At: {task["createdAt"]}");
            Console.WriteLine($"Updated At: {task["updatedAt"]}");
            Console.WriteLine();
        }
    }
}