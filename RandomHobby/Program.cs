// See https://aka.ms/new-console-template for more information

RandHobby();

void RandHobby(){
        
    string[] hobbies = { "Gaming", "Skiing", "Coding", "Fishing", "Football",};
    Random ran = new Random();
    int randomHob = ran.Next(0, hobbies.Length);
    

    void Run()
    {
    
        Console.WriteLine("Give someone a new hobby!");
        string inputNames = Console.ReadLine();
        if (randomHob == 0)
        {
          Console.WriteLine($"{inputNames}'s new hobby is now {hobbies[randomHob]}!");
        }
        else if(randomHob == 2)
        {
           Console.WriteLine($"{inputNames}'s new hobby is now {hobbies[randomHob]}!");
        }
        else if(randomHob == 3)
        {
          Console.WriteLine($"{inputNames}'s new hobby is now {hobbies[randomHob]}!");
         }
        else if(randomHob == 4)
        {
          Console.WriteLine($"{inputNames}'s new hobby is now {hobbies[randomHob]}!");
        }
        else if(randomHob == 5)
        {
                Console.WriteLine($"{inputNames}'s new hobby is now {hobbies[randomHob]}!");
        }    
    }

    Run();
    
} 



