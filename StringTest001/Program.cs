using NUnit.Framework;
//This uses .Net 6 so looks like Javascript top down rather than the .Net 5 Framework but supposed to be good has System and all that still as default just not shown
Console.WriteLine("Testing Begins!");
/* Description: 
    Tests throw string arrays of various sizes and target starting letter to UserInputFunction for user to return a string array with required starting letter.

    Specifics:
    Starting Letter will always be lowercase, Names will be Uppercase, Lowercase, Capitalized and Random Casing("HeLLo").
    Return it in its original casing!!
    All string in test will be only characters no spacings ' ' or symbols '!'

    WARNING!!! This is made poorly in the same project folder so deleting anything outside of the UserInputFunction will break everything most likely.
    If you launch and get Exception Unhandled or Console doesnt say finished then you have an error or didnt pass the tests. Look for the Red 'X' circle
    Read the AssertionException line to see what was wrong. It gives TONS of information like required String[] size and where Values differed.
    To try again or close test use Red Square near where the green play button was on top line.
    
    Use Console.WriteLine() in your section to see progress in console for testing
    If you run the console program and it passes all checks it will give a "Testing Completed! Success!" Line below the "Testing Beings!". Good Luck!
*/
//Dont edit below this(go to line 38 for your code section)
string[] test = new string[] { "Chappy", "Chandler", "Chelsy", "David", "Bailey", "Xavier", "Marcus", "Galdino", "Jose", "Bill" };
string[] returnedTest = UserInputFunction(test, 'c');
Assert.AreEqual(new string[] { "Chappy", "Chandler", "Chelsy" }, returnedTest);
Console.WriteLine("Test 1 Passed!");

test = new string[] { "alex", "Alec", "Serena", "Eva", "ayla", "Dylan", "Nyle", "kristina", "Denise", "Cruz", "TrueCoders" };
returnedTest = UserInputFunction(test, 'a');
Assert.AreEqual(new string[] { "alex", "Alec", "ayla" }, returnedTest);
Console.WriteLine("Test 2 Passed!");

test = new string[] { "Robin", "Rashad", "jAmEs", "Hannah", "rUby", "riLey", "Michael", "Martin", "rIcKiE" };
returnedTest = UserInputFunction(test, 'r');
Assert.AreEqual( new string[] { "Robin", "Rashad", "rUby", "riLey", "rIcKiE" } , returnedTest);
Console.WriteLine("Test 3 Passed!");

test = randomTestString();
string[] testC = cTestString(test);
char c = cChar(test);
returnedTest = UserInputFunction(test, c);
Assert.AreEqual(testC, returnedTest);
Console.WriteLine("Randomized Test Passed!");

Console.WriteLine("Testing Completed! Success!");
//Dont edit above this

string[] UserInputFunction(string[] names, char sLetter)
{
    //[] Code goes here [] *******************************************************************

    return new string[0];
}


//Dont edit below this
string[] randomTestString()
{
    var rand = new Random();
    int r = rand.Next(0, 5);

    switch(r){
        case 0:
            return new string[] { "theo", "Victor", "Tim", "Anita", "Zack", "Gary", "lewis", "craig", "Luke"};  // 'l'
        case 1:
            return new string[] { "Shane", "Muhammad", "rICk", "tanya", "sarah", "rock", "jeff", "saUl", "sEbAsTiAn", "shaun", "ozan", "AdAm", "rock" };    // 's'
        case 2:
            return new string[] { "Jared", "mercy", "Jamie", "Ebo", "jeremy", "jared", "jOe", "june", "sai", "Finley" };  // 'j'
        case 3:
            return new string[] { "dan", "daniel", "racheal", "travis", "FitnessGram PACER" };    // 'd'
        case 4:
            return new string[] { "rOseAnne", "Norm", "Chris", "Emerald", "Greg", "McDonald", "Rip" }; // 'g'
        case 5:
            return new string[] { "sArAh", "Rashad", "Im Out of Names", "door", "Slick", "Norman" }; // 's'
    }

    return new string[0];
}

char cChar(string[] names)
{
    if (names[0] == "theo")
    {
        return 'l';
    }
    else if (names[0] == "Shane" || names[0] == "sArAh")
    {
        return 's';
    }
    else if (names[0] == "Jared")
    {
        return 'j';
    }
    else if (names[0] == "dan")
    {
        return 'd';
    }
    else if (names[0] == "rOseAnne")
    {
        return 'g';
    }

    return ' ';
}

string[] cTestString(string[] names)
{
    if (names[0] == "theo")
    {
        return new string[] { "lewis", "Luke" }; // 'l'
    }
    else if (names[0] == "Shane")
    {
        return new string[] { "Shane", "sarah", "saUl", "sEbAsTiAn", "shaun" };    // 's'
    }
    else if (names[0] == "Jared")
    {
        return new string[] { "Jared", "Jamie", "jeremy", "jared", "jOe", "june" };  // 'j'
    }
    else if (names[0] == "dan")
    {
        return new string[] { "dan", "daniel" };    // 'd'
    }
    else if (names[0] == "rOseAnne")
    {
        return new string[] { "Greg" }; // 'g'
    }
    else if (names[0] == "sArAh")
    {
        return new string[] { "sArAh", "Slick" }; // 's'
    }

    return new string[0];
}
//Dont edit above this
