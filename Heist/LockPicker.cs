// hackers to take care of the alarms; lock pick specialists to crack the vaults, and some good old fashion muscle to handle the security guards. 
//Create three classes: Hacker, Muscle, and LockSpecialist. They should all implement the IRobber interface. 
//Each implementation for PerformSkill should do three things:
// Take the Bank parameter and decrement its appropriate security score by the SkillLevel. 
//i.e. A Hacker with a skill level of 50 should decrement the bank's AlarmScore by 50.
// Print to the console the name of the robber and what action they are performing. 
//i.e. "Mr. Pink is hacking the alarm system. Decreased security 50 points"
// If the appropriate security score has be reduced to 0 or below, print a message to the console, i.e. "Mr Pink has disabled the alarm system!"

public class LockPicker:IRobber{
    public string Name{get; set;}
    public int SkillLevel{get; set;}
    public int PercentCut{get; set;}
    public string? Specialty{get; set;}= "LockPicker"; //Sarah's: public string Job {get;} = "Lock Pick";

    public void PerformSkill(Bank bank){
        //Sarah's:
        // bank.VaultScore = bank.VaultScore - SkillLevel;
        // Console.WriteLine($"{Name} is picking the vault lock. Decreased vault {SkillLevel} points");
        // if(bank.AlarmScore <= 0)
        // {
        //     Console.WriteLine($"{Name} has opened the vault door!");
        // }
        string skill="crack the vaults";
        Console.WriteLine($"{Name} is {skill}. Decreased security by {SkillLevel}.");
        bank.VaultScore -= SkillLevel; //rmbr Vault for lock picker!
        if(!bank.IsSecure){
            Console.WriteLine($"{Name} has disabled the vault system");
        }    
    }
}