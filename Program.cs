using Model;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");

    // Create
    // Console.WriteLine("Indsæt et nyt task");
    // db.Add(new TodoTask("En opgave der skal løses", false , "Søren"));
    // db.SaveChanges();

    // Opret en bruger
    var user = new User { Name = "Nicolai Edens" };
    db.Add(user);
    db.SaveChanges();

    // Create a task for the user

    Console.WriteLine("Indsæt et nyt task");
    db.Add(new TodoTask("En opgave der skal løses", "Søren", false, user));
    db.SaveChanges();


    // Read
    Console.WriteLine("Find det sidste task");
    var lastTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    Console.WriteLine($"Text: {lastTask.Text}");
    /*
    // Update
    Console.WriteLine("Opdater sidste task");
    lastTask.Text = "Opgave er opdateret";
    lastTask.Done = true;
    db.SaveChanges();

    // Verify Update
    var updatedTask = db.Tasks
        .OrderBy(b => b.TodoTaskId)
        .Last();
    */

    /* Delete
    Console.WriteLine("Slet det sidste task");

    // Find the last task again (just for demonstration purposes)
    var taskToDelete = db.Tasks
        .OrderByDescending(b => b.TodoTaskId)
        .First();

    // Delete the task
    db.Remove(taskToDelete);

    // Save changes to the database
    db.SaveChanges();
    */

}