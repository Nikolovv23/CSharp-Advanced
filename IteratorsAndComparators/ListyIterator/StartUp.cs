
// Create a generic class ListyIterator. The collection, which it will iterate through, should be received by the constructor. You should store the elements in a List.
// The class should have three main functions:
// •	Move - should move an internal index position to the next index in the list. The method should return true, if it had successfully moved the index and false,
// if there is no next index.
// •	HasNext - should return true, if there is a next index and false, if the index is already at the last element of the list.
// •	Print - should print the element at the current internal index.Calling Print on a collection without elements should throw an appropriate
// exception with the message "Invalid Operation!". 
// By default, the internal index should be pointing to the 0th index of the List. Your program should support the following commands:


//                 Command                        Return Type	                                                           Description
//      1.       Create {e1 e2 …}	                 void                     Creates a ListyIterator from the specified collection.  In case of a Create command without
//                                                                              any elements, you should create a ListyIterator with an empty collection.
//      2.           Move	                        boolean	                  This command should move the internal index to the next index.
//      3.           Print                           void	                  This command should print the element at the current internal index.
//      4.          HasNext	                        boolean                   Returns whether the collection has the next element.
//      5.            END	                         void	                  Stops the input.


// Your program should catch any exceptions thrown because of the described validations - calling Print on an empty collection - and print their messages instead.
// Input
// •	Input will come from the console as lines of commands. 
// •	The first line will always be the Create command in the input. 
// •	The last command received will always be the END command.
// Output
// •	For every command from the input (except for the END and Create commands), print the result of that command on the console, each on a new line.
// •	In the case of Move or HasNext commands, print the return value of the methods.
// •	In the case of a Print command, you don't have to do anything additional as the method itself should already print on the console.
// Constraints
// •	There will always be only one Create command and it will always be the first command passed.
// •	The number of commands received will be between [1…100].
// •	The last command will always be the only END command.

// Examples -
//  Input: 
// Create Steve George
// HasNext
// Print
// Move
// Print
// END
//  Output:
// True
// Steve
// True
// George


namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .ToArray();
            ListyIterator<string> listy = new ListyIterator<string>(input.Skip(1).ToList());

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Print":
                        try
                        {
                            listy.Print();
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Invalid Operation!");
                        }
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "PrintAll":
                        foreach (var element in listy)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
