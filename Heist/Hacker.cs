// hackers to take care of the alarms; lock pick specialists to crack the vaults, and some good old fashion muscle to handle the security guards. 
//Create three classes: Hacker, Muscle, and LockSpecialist. They should all implement the IRobber interface. 


public class Hacker:IRobber{
    public string Name{get; set;}
    public int SkillLevel{get; set;}
    public int PercentCut{get; set;}

    public string? Specialty{get; set;}= "Hacker";


    //Each implementation for PerformSkill should do three things:
    // Take the Bank parameter and decrement its appropriate security score by the SkillLevel. 
    //i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
    // Print to the console the name of the robber and what action they are performing. 
    //i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
    // If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"



//PerformSkill should do three things:

// Take the Bank parameter and decrement its appropriate security score by the SkillLevel. i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
// Print to the console the name of the robber and what action they are performing. i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
// If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"
    public void PerformSkill(Bank bank){
            //Sarah's:
// bank.AlarmScore = bank.AlarmScore - SkillLevel;
//         Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points");
//         if(bank.AlarmScore <= 0)
//         {
//             Console.WriteLine($"{Name} has disabled the alarm system!");
//         }

            // Take the Bank parameter and decrement its appropriate security score by the SkillLevel:
        //int newAlarmScore=banks.AlarmScore-SkillLevel;
        //or:  bank.AlarmScore -= SkillLevel;
        string skill="take care of the alarms";
        Console.WriteLine($"{Name} is {skill}. Decreased security by {SkillLevel}.");
        bank.AlarmScore -= SkillLevel; //hacker disable alarm!
        if(!bank.IsSecure){
            Console.WriteLine($"{Name} has disabled the alarm system");
        }
    }
}