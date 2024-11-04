public class Muscle:IRobber{
    public string Name{get; set;}
    public int SkillLevel{get; set;}
    public int PercentCut{get; set;}
    public string? Specialty{get; set;}= "Muscle";

    public void PerformSkill(Bank bank){
        //Sarah's:
        //  bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
        // Console.WriteLine($"{Name} is punching the security guards. Decreased security guard {SkillLevel} points");
        // if(bank.AlarmScore <= 0)
        // {
        //     Console.WriteLine($"{Name} has punched all the security guards!");
        // }
        string skill="handle the security guards";
        Console.WriteLine($"{Name} is {skill}. Decreased security by {SkillLevel}.");
        bank.SecurityGuardScore -= SkillLevel;//rmbr SecuritGuardScore for muscle!
        if(!bank.IsSecure){
            Console.WriteLine($"{Name} has disabled the security guards");
        }
    }
}