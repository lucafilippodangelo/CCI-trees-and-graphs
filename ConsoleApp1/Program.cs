using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            //Write class methods to add, delete, modify, and print people that have manager-worker relationships
            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            aTestEntity aTestObjOne = new aTestEntity();
            aTestEntity aTestObjTwo = new aTestEntity() { aFirstField = "ldTwo" };

            IEnumerable<aTestEntity> aListOfATestEntity = new List<aTestEntity>() { aTestObjOne, aTestObjTwo };

            foreach (aTestEntity anItem in aListOfATestEntity)
            {
                System.Console.WriteLine(anItem.aFirstField + " " + anItem.playWithEditorMethod());
            }

            //seed some data for nested entity
            aTestEntityNested aNestedOne = new aTestEntityNested() { id = 1, aFirstField = "aNestedOne" };
            aTestEntityNested aNestedTwo = new aTestEntityNested() { id = 1, aFirstField = "aNestedTwo" };
            aTestEntityNested aNestedThree = new aTestEntityNested() { id = 1, aFirstField = "aNestedThree" };

            //seed external entity
            aTestEntity anExternalOne = new aTestEntity()
            {
                id = 1,
                aFirstField = "anExternalOne_withNested",
                nestedList = new List<aTestEntityNested>() { aNestedOne, aNestedTwo }
            };
            aTestEntity anExternalTwo = new aTestEntity()
            {
                id = 2,
                aFirstField = "anExternalTwo_withNested",
                nestedList = new List<aTestEntityNested>() { aNestedTwo, aNestedThree }
            };
            aTestEntity anExternalThree = new aTestEntity()
            {
                id = 2,
                aFirstField = "anExternalThree_noNested"
            };

            //create a list of external entities
            List<aTestEntity> anExternalList = new List<aTestEntity>() { anExternalOne, anExternalTwo, anExternalThree };

            print(anExternalList);

            void print(List<aTestEntity> teList)
            {
                var validListToPrint2 = teList
                        .Where(anItem => anItem.nestedList != null)
                        .Select(anItem => new { tesiId = anItem.id });

                var validListToPrint = teList.Where(anItem => anItem.nestedList != null);

                foreach (aTestEntity item in validListToPrint)
                {
                    Console.WriteLine(item.aFirstField);
                    item.nestedList.ForEach(print => Console.WriteLine(print.aFirstField));

                    //teList.Remove(item); //TEST remove
                    //teList.RemoveAll(d => d.aFirstField.Contains("Two"));  //TEST remove all

                    item.id = 4;
                }
            }

            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Make sure a player is not in more than team.... that  entails to lists and Maps manipulation mostly.
            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            //seed external entity
            aTestEntity aPlayerOne = new aTestEntity() { id = 1, cost = 10 };
            aTestEntity aPlayerTwo = new aTestEntity() { id = 2 };
            aTestEntity aPlayerThree = new aTestEntity() { id = 3 };

            List<aTestEntity> teamOne = new List<aTestEntity> { aPlayerOne, aPlayerTwo, aPlayerThree };
            List<aTestEntity> teamtwo = new List<aTestEntity> { aPlayerOne, aPlayerTwo };
            List<aTestEntity> teamThree = new List<aTestEntity> { aPlayerOne };
            List<aTestEntity> teamFour = new List<aTestEntity> { aPlayerThree };

            List<List<aTestEntity>> listOfTeams = new List<List<aTestEntity>> { teamOne, teamtwo, teamThree };
            List<List<aTestEntity>> listOfTeamsUnique = new List<List<aTestEntity>> { teamThree, teamFour };

            ensure(listOfTeams); //will return
            ensure(listOfTeamsUnique); //will pass

            //input "aPlayerThree" is the only valid
            //given in input a list of players and a list of teams, ensure each player is not in more than one team 



            void ensure(List<List<aTestEntity>> _listOfTeams)
            {
                Dictionary<int, bool> playerCheck = new Dictionary<int, bool>();

                foreach (List<aTestEntity> team in _listOfTeams)
                {
                    foreach (aTestEntity player in team)
                    {
                        if (playerCheck.ContainsKey(player.id))
                             return; 
                        else
                            playerCheck.Add(player.id, true);
                    }
                }
            }




            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // parse and match stuff across multiple json documents. Implement logic to validate a lineup before a game. 
            // LD potential validations
            // - sum of salaries less than draft limit (salary limit has to be an input)
            // - all the position are added (input list of the positions)
            //   - a distinct of the positions of all the available players need to be done 
            // - a player is valid (a player list is in input)
            //DRAFTKINGS - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            //seed external entity
            aTestEntity aPlayerFour = new aTestEntity() { id = 1, cost = 10,  aPosition = new position() {  code = (int)positionList.top }  };
            aTestEntity aPlayerFive = new aTestEntity() { id = 2, cost = 25 , aPosition = new position() { code = (int)positionList.middle } };
            aTestEntity aPlayerSix = new aTestEntity() { id = 3, cost = 3, aPosition = new position() { code = (int)positionList.bottom } };

            List<aTestEntity> aLineup = new List<aTestEntity> { aPlayerFour, aPlayerFive };
            List<aTestEntity> aFullListOfPlayers = new List<aTestEntity> { aPlayerFour, aPlayerFive, aPlayerSix };

            validateLineup(50, aLineup, aFullListOfPlayers);

            void validateLineup(int salaryTotal, List<aTestEntity> aLineup, List<aTestEntity> aFullListOfPlayers)
            {
                //check salary total
                var t1 = aLineup.Sum(e => e.cost);

                //check all items in "aLineup" are contained in "aFullListOfPlayers"
                // - 1 - scan the lineup and insert in a dictionary, set value to false
                // - 2 - then scan "aFullListOfPlayers" if key is there turn to true
                // - 3 - at the end if all the keys are true -> pass
                // -----------------------------------------------------------------
                // - 1 - 
                Dictionary<int, bool> lineupCheck = new Dictionary<int, bool>();

                foreach (aTestEntity player in aLineup)
                {

                        if (lineupCheck.ContainsKey(player.id))
                            return;
                        else
                            lineupCheck.Add(player.id, false);
                }
                // - 2 - 
                foreach (aTestEntity player in aFullListOfPlayers)
                {
                    if (lineupCheck.ContainsKey(player.id))
                        lineupCheck[player.id] = true;
                }
                // - 3 -
                if (lineupCheck.Where(s => s.Value == false).Any())
                {
                    // one of them is not valid
                    var test = "";
                }
                else {
                    // all of them are
                    var test = "";
                }

                
                //check all the position allowed and cardinality are valid
                //trivial

            }

        }

        public class aTestEntity
        {
            public int id { get; set; }
            public string aFirstField { get; set; } = "ldOne";
            public string playWithEditorMethod() => aFirstField + " chained";
            public int cost { get; set; }
            public position aPosition { get; set; }
            public List<aTestEntityNested>? nestedList { get; set; }
        }

        public class aTestEntityNested
        {
            public int id { get; set; }
            public string aFirstField { get; set; } = "ldOne";
            public string playWithEditorMethod() => aFirstField + " chained";
        }

        public class position
        {
            public int code { get; set; }
        }

        public enum positionList
        {
            top = 1,
            middle = 2,
            bottom = 3
        }

    }



}
