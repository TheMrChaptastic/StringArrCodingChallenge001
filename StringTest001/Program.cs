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
Assert.AreEqual(returnedTest,new string[]{ "Chappy", "Chandler", "Chelsy" });

test = new string[] { "alex", "Alec", "Serena", "Eva", "ayla", "Dylan", "Nyle", "kristina", "Denise", "Cruz", "TrueCoders" };
returnedTest = UserInputFunction(test, 'a');
Assert.AreEqual(returnedTest, new string[] { "alex", "Alec", "ayla"});

test = new string[] { "Robin", "Rashad", "jAmEs", "Hannah", "rUby", "riLey", "Michael", "Martin", "rIcKiE" };
returnedTest = UserInputFunction(test, 'r');
Assert.AreEqual(returnedTest, new string[] { "Robin", "Rashad", "rUby", "riLey", "rIcKiE" });


Console.WriteLine("Testing Completed! Success!");
//Dont edit above this

string[] UserInputFunction(string[] names, char sLetter)
{
    //Code goes here

    return new string[0];
}
