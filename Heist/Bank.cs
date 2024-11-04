
// Knocking over banks isn't going to be easy. Alarms... Vaults... Security Guards.... 
//First things first. Let's create a Bank class to represent the security we're up against. 
//Give the Bank class the following properties:
public class Bank{
    public int CashOnHand { get; set; }
    public int AlarmScore{ get; set; }
    public int VaultScore{ get; set; }
    public int SecurityGuardScore{ get; set; }

    //If all the scores are less than or equal to 0, this should be false. 
    //If any of the scores are above 0, this should be true
    //public bool IsSecure(){
        // int combined=CashOnHand+AlarmScore+VaultScore+SecurityGuardScore;
        // if (CashOnHand<=0 && AlarmScore<=0 && VaultScore<=0 && SecurityGuardScore<=0 ){
        // return false;
        // }else{
        //     return true;
        // }

        //A computed boolean property called IsSecure. If all the scores are less than or equal to 0, this should be false. If any of the scores are above 0, this should be true
         // returns true if any of the scores (AlarmScore, VaultScore, or SecurityGuardScore) are above 0, and false otherwise
            public bool IsSecure{
            get
            {
                return AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0;
            }
            }
       


//Sarah's:
// public bool IsSecure
//     {
//         get
//         {
//             if (AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
//             {
//                 return true;
//             }
//             else
//             {
//                 return false;
//             }
//         }
//     }
//     // Let's do a little recon next. Print out a Recon Report to the user. This should tell the user what the bank's most secure system is, and what its least secure system is (don't print the actual integer scores--just the name, i.e. Most Secure: Alarm Least Secure: Vault
    public void Report()
    {
        Dictionary<string, int> values = new Dictionary<string, int>
        {
            //alt:
        // values.Add("Alarm", AlarmScore);
        // values.Add("Vault", VaultScore);
        // values.Add("Guards", SecurityGuardScore);
            { "Alarm", AlarmScore },
            { "Vault", VaultScore },
            { "Guards", SecurityGuardScore }
        };

        // var Scores = from score in values orderby score.Value ascending select score;
        var scores = values.OrderBy(x => x.Value);
        List<KeyValuePair<string, int>> keyValuePairs = scores.ToList();

        Console.WriteLine($"Most Secure: {keyValuePairs[2].Key}");
        Console.WriteLine($"Least Secure:{keyValuePairs[0].Key}");

        //alt:
        //  var scores = values.OrderBy(x => x.Value).ToList();

        //             Console.WriteLine($"Most Secure: {scores[2].Key}");
        //             Console.WriteLine($"Least Secure: {scores[0].Key}");
    }





    }





 // // Determine the most and least secure systems
            // int highestValue = newBank.AlarmScore;
            // string highest = "AlarmScore";
            // int lowestValue = newBank.AlarmScore;
            // string lowest = "AlarmScore";

            // // Compare values to find the most and least secure systems
            // if (newBank.VaultScore > highestValue)
            // {
            //     highestValue = newBank.VaultScore;
            //     highest = "VaultScore";
            // }
            // if (newBank.SecurityGuardScore > highestValue)
            // {
            //     highestValue = newBank.SecurityGuardScore;
            //     highest = "SecurityGuardScore";
            // }
            // if (newBank.VaultScore < lowestValue)
            // {
            //     lowestValue = newBank.VaultScore;
            //     lowest = "VaultScore";
            // }
            // if (newBank.SecurityGuardScore < lowestValue)
            // {
            //     lowestValue = newBank.SecurityGuardScore;
            //     lowest = "SecurityGuardScore";
            // }

            // // Print the recon report
            // Console.WriteLine("Recon Report:");
            // Console.WriteLine($"The bank's most secure system is: {highest}");
            // Console.WriteLine($"Least secure system is: {lowest}");
