// //Phase One
// // Print the message "Plan Your Heist!".
// // Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
// // Prompt the user to enter a team member's name and save that name.
// // Prompt the user to enter a team member's skill level and save that skill level with the name.
// // Prompt the user to enter a team member's courage factor and save that courage factor with the name.
// // Display the team member's information.
// //Phase Two
// // Create a way to store several team members.
// // Collect several team members' information.
// // Stop collecting team members when a blank name is entered.
// // Display a message containing the number of members of the team.
// // Display each team member's information.
// //Phase Three
// // Stop displaying each team member's information.
// // Store a value for the bank's difficulty level. Set this value to 100.
// // Sum the skill levels of the team. Save that number.
// // Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
// // Phase Four
// // Create a random number between -10 and 10 for the heist's luck value.
// // Add this number to the bank's difficulty level.
// // Before displaying the success or failure message, display a report that shows.
// // The team's combined skill level
// // The bank's difficulty level
// //Phase Five
// // Run the scenario multiple times.
// // After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// // Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
// // Phase Six
// // At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// // At the end of the program, display a report showing the number of successful runs and the number of failed runs.
// using System.Reflection.Metadata.Ecma335;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;

// namespace Heist
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Plan Your Heist!");
//             Console.WriteLine("--------------------------------");
//             Console.WriteLine("Enter the difficulty level of the bank you are robbing:");
//             int difficulty = Int32.Parse(Console.ReadLine());

//             List<CrewMember> HeistTeam = new List<CrewMember>();

//             Console.WriteLine("Who is in your crew?");
//             while(true)
//             {
//             Console.WriteLine("Name");
//             string name = Console.ReadLine();
//             if(name == "")
//             {
//                 break;
//             }

//             Console.WriteLine("Skill Level");
//             int skillLevel = Int32.Parse(Console.ReadLine());
//             Console.WriteLine("Courage Factor");
//             float courageFactor = float.Parse(Console.ReadLine());
//                 CrewMember newMember = new CrewMember()
//                 {
//                     Name = name,
//                     SkillLevel = skillLevel,
//                     CourageFactor = courageFactor
//                 };
//             HeistTeam.Add(newMember);
//             }
//             int totalSkillLevel = HeistTeam.Sum(x => x.SkillLevel);
//             Console.WriteLine("How many times would you like to play?");
//             int plays = Int32.Parse(Console.ReadLine());
//             int wins = 0;
//             int losses = 0;
//             for(int i = 0; i < plays; i++)
//             {
//             int luckValue = new Random().Next(-10, 10);
//             int bankLevel = difficulty + luckValue;
//             Console.WriteLine($"Team's combined skill level: {totalSkillLevel}");
//             Console.WriteLine($"Bank difficulty level: {bankLevel}");
//             if(totalSkillLevel >= bankLevel)
//             {
//                 Console.WriteLine("Great success! Hairbrushes for everyone!");
//                 wins++;
//             }
//             else 
//             {
//                 Console.WriteLine("Failure");
//                 losses++;
//             }
//             }
//             Console.WriteLine($"Wins: {wins} Losses: {losses}");

//             // Console.WriteLine($"Team Members: {HeistTeam.Count}");
//             // Console.WriteLine($"Your crew member is: Name:{name} Skill Level:{skillLevel} Courage Factor:{courageFactor}");

//         }}}

























// using System.Net.Mail;

// namespace Heist{
//     class Program {
//         static void Main(string[] args){
//         //all the options for crew members"rolodex"
//         List<IRobber>rolodex=new List<IRobber>
//         { 
//                         new Hacker { Name = "Hacker1", SkillLevel = 50, PercentCut = 20 },
//                         new Hacker { Name = "Hacker2", SkillLevel = 40, PercentCut = 25 },
//                         new Muscle { Name = "Muscle1", SkillLevel = 60, PercentCut = 15 },
//                         new Muscle { Name = "Muscle2", SkillLevel = 50, PercentCut = 20 },
//                         new LockPicker { Name = "LockSpecialist1", SkillLevel = 70, PercentCut = 10 }
//         };

//         // When the program starts, print out the number of current operatives in the rolodex. 
//         Console.WriteLine($"number of current operatives in the rolodex: {rolodex.Count()}");


  
//         while (true)
//         {
//         //Then prompt the user to enter the name of a new possible crew member. 
//         Console.WriteLine("New member name (or press Enter to finish):");
//         string newCrewMemberName=Console.ReadLine();
//         // Continue the above action and allow the user to enter as many crew members as they like to the rolodex 
//         //until they enter a blank name before continuing.
//         if (string.IsNullOrWhiteSpace(newCrewMemberName)) break;

//         //Once the user has entered a name, print out a list of possible specialties:
//         // Hacker (Disables alarms)/ Muscle (Disarms guards)/ Lock Specialist (cracks vault)
//         // Console.WriteLine("Specialty ?");
//         // Console.WriteLine("Hacker (Disables alarms");
//         // Console.WriteLine("Muscle (Disarms guards");
//         // Console.WriteLine("Lock Specialist (cracks vault)");
//         // string specialty= Console.ReadLine();

//         // Need to use number for selection for switch case
//         Console.WriteLine("1. Hacker (Disables alarms");
//         Console.WriteLine("2. Muscle (Disarms guards");
//         Console.WriteLine("3. Lock Specialist (cracks vault)");
//         int specialty= int.Parse(Console.ReadLine());

//         Console.WriteLine(" Skill level (1-100)?");
//         int skillLevel= int.Parse(Console.ReadLine());

//         Console.WriteLine(" % cut?");
//         int cut= int.Parse(Console.ReadLine());


//         // Instantiate the appropriate class for that crew member (based on their specialty) and add to the rolodex.
//                         IRobber newMember;
//                         switch (specialty)
//                         {
//                             case 1:
//                                 newMember = new Hacker
//                                 {
//                                     Name = newCrewMemberName,
//                                     SkillLevel = skillLevel,
//                                     PercentCut = cut,
//                                     Specialty= "Hacker" //otherwise use GetType() on crew list
//                                 };
//                                 break;
//                             case 2:
//                                 newMember = new Muscle
//                                 {
//                                     Name = newCrewMemberName,
//                                     SkillLevel = skillLevel,
//                                     PercentCut = cut,
//                                     Specialty= "Muscle"
//                                 };
//                                 break;
//                             case 3:
//                                 newMember = new LockPicker
//                                 {
//                                     Name = newCrewMemberName,
//                                     SkillLevel = skillLevel,
//                                     PercentCut = cut,
//                                     Specialty= "Lock Picker"
//                                 };
//                                 break;
//                             default:
//                                 continue;
//                         }
//                         rolodex.Add(newMember);
//                     }

//         // Once the user is finished with their rolodex, it's time to begin a new heist
//         // The program should create a new bank object and randomly assign values for these properties:
//         // AlarmScore (between 0 and 100)
//         // VaultScore (between 0 and 100)
//         // SecurityGuardScore (between 0 and 100)
//         // CashOnHand (between 50,000 and 1 million)
//         // Let's do a little recon next. Print out a Recon Report to the user. 
//         //This should tell the user what the bank's most secure system is, and what its least secure system is 
//         //(don't print the actual integer scores--just the name, i.e. 
//         //Most Secure: Alarm Least Secure: Vault

//         //Why is this here? "Top-level statements must precede namespace and type declarations"
//         //keep all within static void Main (string[] args)
//         Bank newBank= new Bank(){
//             AlarmScore=new Random().Next(0,101), //"between 0 and 100" (0, 101)?
//             VaultScore=new Random().Next(0,101),
//             SecurityGuardScore=new Random().Next(0,101),
//             CashOnHand=new Random().Next(50000,1000001),
//         };

//         //display scores to see randomly assigned values:
//         Console.WriteLine($"AlarmScore: {newBank.AlarmScore}");
//         Console.WriteLine($"VaultScore: {newBank.VaultScore}");
//         Console.WriteLine($"SecurityGuardScore: {newBank.SecurityGuardScore}");

//         //set Alarm as highest
//         int highestValue=newBank.AlarmScore;
//         string highest="AlarmScore";
//         //set Alarm as lowest
//         int lowestValue=newBank.AlarmScore;
//         string lowest="AlarmScore";
//         //check
//         if (newBank.AlarmScore<newBank.VaultScore){
//             highestValue=newBank.VaultScore;
//             highest="VaultScore";
//         }
//         if (newBank.VaultScore<newBank.SecurityGuardScore){
//             highestValue=newBank.SecurityGuardScore;
//             highest="SecurityGuardScore";
//         }
//         if (newBank.AlarmScore>newBank.VaultScore){
//             lowestValue=newBank.VaultScore;
//             lowest="VaultScore";
//         }
//         if (newBank.VaultScore>newBank.SecurityGuardScore){
//             lowestValue=newBank.SecurityGuardScore;
//             lowest="SecurityGuardScore";
//         }

//         //Alt:
//          // // Determine and print the most and least secure systems
//             // int highestValue = Math.Max(newBank.AlarmScore, Math.Max(newBank.VaultScore, newBank.SecurityGuardScore));
//             // int lowestValue = Math.Min(newBank.AlarmScore, Math.Min(newBank.VaultScore, newBank.SecurityGuardScore));
//             // string highest = newBank.AlarmScore == highestValue ? "Alarm" : (newBank.VaultScore == highestValue ? "Vault" : "Security Guard");
//             // string lowest = newBank.AlarmScore == lowestValue ? "Alarm" : (newBank.VaultScore == lowestValue ? "Vault" : "Security Guard");

//         Console.WriteLine("Recon Report:");
//         Console.WriteLine($" The bank's most secure system is: {highest} Least Secure: {lowest}");

        
//         // Create a new List<IRobber> and store it in a variable called crew.
//         // Prompt the user to enter the index of the operative they'd like to include in the heist. 
//         // Once the user selects an operative, add them to the crew list.
//         // Allow the user to select as many crew members as they'd like from the rolodex. 
//         // Continue to print out the report after each crew member is selected, 
//         //but the report should not include operatives that have already been added to the crew, 
//         //or operatives that require a percentage cut that can't be offered.
//         // Once the user enters a blank value for a crew member, we're ready to begin the heist. 

//         List<IRobber> crew = new List<IRobber> ();
//         int availableCut=100;

//         while(true){
//         // //build the perfect crew:
//                 //so not a duplicate and still have available cut left:
//         // Continue to print out the UPDATED rolodex report after each crew member is selected, 
//         //THAT MEANS MINUS operatives added to crew list already
//         //so that user can see what remains and choose more opratives:
//         int index1 = 0; // Initialize an index to track position in the rolodex

//         // Iterate through each robber in the rolodex
//         foreach (IRobber robber in rolodex)
//         {
//             // Check if the robber is not already in the crew and if their cut is affordable
//             if (!crew.Contains(robber) && robber.PercentCut <= availableCut)
//             {
//                 // Print the current robber index and info
//                 Console.WriteLine($"{index1}: {robber.Name} - {robber.Specialty} - Skill Level: {robber.SkillLevel} - Cut: {robber.PercentCut}%");
//             }
//             index1++; 
//         }
       
//         Console.WriteLine("What's the index for the operative to add to heist team?");
//         string chosenIndexInput = Console.ReadLine();
//         // Break if the user enters a blank value
//         if (string.IsNullOrWhiteSpace(chosenIndexInput)) break;
//         int chosenIndex = int.Parse(chosenIndexInput);


//         if(crew.Contains(rolodex[chosenIndex])){
//         Console.WriteLine("operative is already on team");
//         }
//         if(rolodex[chosenIndex].PercentCut>availableCut){
//             Console.WriteLine("cant afford it");
//         }
//         else{
//             crew.Add(rolodex[chosenIndex]);
//             availableCut-=rolodex[chosenIndex].PercentCut;

//         }
// }


//         // Each crew member performs their skill on the bank
//         foreach (IRobber robber in crew){
//             robber.PerformSkill(newBank); //-----------Note: (newBank)!!!!
//         }

       
//         //Afterwards, evaluate if the bank is secure. If not, the heist was a success! 
//          //If the bank does still have positive values for any of its security properties, the heist was a failure.
//             if(newBank.IsSecure==true){ //or:   if (newBank.IsSecure){}
//                 Console.WriteLine("Heist failed");
//             }else{
//                 // If the heist was a success, print out a report of each members' take, along with how much money is left for yourself.
//                 Console.WriteLine("Success!!!");
                
//                 // Calculate the user's share of the total cash 
//                 // availableCut is percent remainder after all the other team members percent cut has been taken to account
//                     int myCut=newBank.CashOnHand* availableCut/100;
//                  Console.WriteLine($"My cut: {myCut}");

//                 // We compute the user's share based on the proportion of the `availableCut` relative to 100%
//                  foreach(IRobber robber in crew){
//                 Console.WriteLine($"Member's cut: newBank.CashOnHand*{robber.PercentCut}/100");
//                  }
                 
//                 } 

//             }
//         }
//  }
        

































namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<IRobber> rolodex = new List<IRobber>(): Initializes a new list named rolodex to store IRobber objects.
            // new Hacker/LockPick/Muscle { ... }: Adds new instances of Hacker, LockPick, and Muscle to the rolodex list, pre-populating it with initial values.
            // List of available crew members ("rolodex"):
            List<IRobber> rolodex = new List<IRobber>
            { 
                new Hacker { Name = "Hacker1", SkillLevel = 50, PercentCut = 20 },
                new Hacker { Name = "Hacker2", SkillLevel = 40, PercentCut = 25 },
                new Muscle { Name = "Muscle1", SkillLevel = 60, PercentCut = 15 },
                new Muscle { Name = "Muscle2", SkillLevel = 50, PercentCut = 20 },
                new LockPicker { Name = "LockSpecialist1", SkillLevel = 70, PercentCut = 10 }
            };

            // Print the number of current operatives in the rolodex
            Console.WriteLine($"Number of current operatives in the rolodex: {rolodex.Count()}");

            while (true)
            {
                // Prompt the user to enter a new possible crew member's name
                Console.WriteLine("New member name (or press Enter to finish):");
                string newCrewMemberName = Console.ReadLine();

                // Exit the loop if a blank name is entered
                if (string.IsNullOrWhiteSpace(newCrewMemberName)) break;

                // Prompt the user to select a specialty for the new crew member
                Console.WriteLine("1. Hacker (Disables alarms)");
                Console.WriteLine("2. Muscle (Disarms guards)");
                Console.WriteLine("3. Lock Specialist (Cracks vault)");
                int specialty = int.Parse(Console.ReadLine());

                // Prompt the user for the new crew member's skill level and percentage cut
                Console.WriteLine("Skill level (1-100)?");
                int skillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("% cut?");
                int cut = int.Parse(Console.ReadLine());

                // Instantiate the appropriate class based on the chosen specialty
                IRobber newMember;
                switch (specialty)
                {
                    case 1:
                        newMember = new Hacker
                        {
                            Name = newCrewMemberName,
                            SkillLevel = skillLevel,
                            PercentCut = cut,
                            // Specialty = "Hacker" //WRONG: SET IN HACKER.CS
                        };
                        break;
                    case 2:
                        newMember = new Muscle
                        {
                            Name = newCrewMemberName,
                            SkillLevel = skillLevel,
                            PercentCut = cut,
                            // Specialty = "Muscle"
                        };
                        break;
                    case 3:
                        newMember = new LockPicker
                        {
                            Name = newCrewMemberName,
                            SkillLevel = skillLevel,
                            PercentCut = cut,
                            // Specialty = "Lock Picker"
                        };
                        break;
                    default:
                        continue;
                }
                rolodex.Add(newMember);
            }

            // Create a new bank object with random security and cash values
            Bank newBank = new Bank
            {
                AlarmScore = new Random().Next(0, 100),
                VaultScore = new Random().Next(0, 100),
                SecurityGuardScore = new Random().Next(0, 100),
                CashOnHand = new Random().Next(50000, 1000000),
            };

            // Display the randomly assigned values for security scores
            Console.WriteLine($"AlarmScore: {newBank.AlarmScore}");
            Console.WriteLine($"VaultScore: {newBank.VaultScore}");
            Console.WriteLine($"SecurityGuardScore: {newBank.SecurityGuardScore}");

            //Calls the Report method (Bank.cs) on the newBank object to display the bank’s security details.
            newBank.Report();


            // Create a new crew list and initialize available cut percentage
            List<IRobber> crew = new List<IRobber>();
            int availableCut = 100;

            //infinite loop to allow the user to add new members to the crew.
            while (true)
            {
                // Display available crew members that can be added to the team
                //index= operative indexes to choose from
                int index = 0;
                foreach (IRobber robber in rolodex)
                {
                    if (!crew.Contains(robber) && robber.PercentCut <= availableCut)
                    {
                        Console.WriteLine($"{index}: {robber.Name} - {robber.Specialty} - Skill Level: {robber.SkillLevel} - Cut: {robber.PercentCut}%");
                    }
                    index++;
                }

                // Prompt the user to select an operative to add to the crew
                Console.WriteLine("What's the index for the operative to add to the heist team?");
                string chosenIndexInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(chosenIndexInput)) break;

                int chosenIndex = int.Parse(chosenIndexInput);

                // Check if the operative is already on the team or if the cut is unaffordable
                if (crew.Contains(rolodex[chosenIndex]))
                {
                    Console.WriteLine("Operative is already on the team");
                }
                else if (rolodex[chosenIndex].PercentCut > availableCut)
                {
                    Console.WriteLine("Can't afford it");
                }
                else
                {
                    crew.Add(rolodex[chosenIndex]);
                    availableCut -= rolodex[chosenIndex].PercentCut;
                }
            }

            // Each crew member performs their skill on the bank
            foreach (IRobber robber in crew)
            {
                robber.PerformSkill(newBank);
            }

            // Check if the heist was successful
            if (newBank.IsSecure)
            {
                Console.WriteLine("Heist failed");
            }
            else
            {
                // If the heist was a success, calculate and display each member's cut and the user's share
                Console.WriteLine("Success!!!");

                // Calculate the user's share of the total cash
                int myCut = newBank.CashOnHand * availableCut / 100;
                Console.WriteLine($"My cut: ${myCut}");

                // Display each crew member's cut
                foreach (IRobber robber in crew)
                {
                    int memberCut = newBank.CashOnHand * robber.PercentCut / 100;
                    Console.WriteLine($"{robber.Name}'s cut: {memberCut}");
                }
            }
        }
    }
}
