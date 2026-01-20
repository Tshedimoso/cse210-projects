 public class Resume
    {
        // Resposibilities: Keep track of the persons name and a list of their jobs. 
        // Behaviors: Display the Resume, which shows the name first, followed by displaying each one of their jobs.
      public string _name;
      public List<Job> _jobs = new List<Job>();

      public void DisplayJobDetails()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
           job.DisplayJobDetails();
        }
        
    
    
    }

    }