// Create your custom stack. You are aware of Stack's structure. There is a collection to store the elements and two functions (not from the functional programming) -
// to push an element and to pop it. Keep in mind that the first element, which is popped is the last in the collection. 
// The Push method adds an element at the top of the collection and the Pop method returns the top element and removes it.
// Push and Pop will be the only commands and they will come in the following format:
// "Push {element1}, {element2}, … {elementN}
//  Pop
// … "
// Write your custom implementation of Stack<T> and implement IEnumerable<T> interface. Your implementation of the GetEnumerator() method 
// should follow the rules of the Abstract Data Type – Stack (return the elements in reverse order of adding them to the stack).
// Input
// •	The input will come from the console as lines of commands. 
// •	Push and Pop will be the only possible commands, followed by integers for the Push command and no other input for the Pop command. 
// Output
// •	When you receive END, the input is over. Foreach the stack twice and print all elements each on the new line.
// Constraints
// •	The elements in the push command will be valid integers between [2 - 31…231 - 1].
// •	The commands will always be valid (always be either Push, Pop, or END).
// •	If the Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: "No elements".

//   Input:
// Push 1, 2, 3, 4
// Pop
// Pop
// END
//  Output:
// 2
// 1
// 2
// 1



namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           // ListyIteratorSetup();
           CustomStack<string> stack = new CustomStack<string>();
            string input;
            string[] delims = { ", ", " "};
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input
                    .Split(delims, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("No elements");
                    }

                }
                else // command = "Push"
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(command[i]);
                    }
                }
            }

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }

        private static void ListyIteratorSetup()
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
