using System;
using System.Dynamic;

namespace ArrayBasedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Here we are creating an array based stack. Please enter the capacity of the stack we are creating.");

                //uses user input to set capacity of the stack.
                int userCapacityInput = Convert.ToInt32(Console.ReadLine());

                //creates a new instance of the stack.
                ArrayStack stack = new ArrayStack(userCapacityInput);

                for(int i = userCapacityInput; i > 0; i--)
                {
                    Console.WriteLine("Now enter in an integer you would like to add to the stack. There are " + i + " numbers left to add.");

                    //gets user input for the push method.
                    int userPushInput = Convert.ToInt32(Console.ReadLine());

                    stack.push(userPushInput);
                }

                Console.WriteLine("Now hit enter to view the top element on the stack.");
                Console.ReadLine();
                stack.peek();

                Console.WriteLine("Now remove the value by hitting enter once again.");
                Console.ReadLine();
                stack.pop();

                Console.WriteLine("One more time, hit enter to see that the value is now gone.");
                Console.ReadLine();
                stack.peek();

                Console.WriteLine("This concludes the example of an array based stack");
                Console.ReadLine();
                Environment.Exit(0);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }

    class ArrayStack
    {
        //number of current integers in stack
        int size;

        //maximum number of integers allowed
        int capacity;

        //array that stores the values
        int[] stack;

        public ArrayStack(int Capacity)
        {
            size = -1;

            if(Capacity >= 1)
            {
                capacity = Capacity;
                stack = new int[capacity];
            }
            else
            {
                Console.WriteLine("Error: The stack must be greater than 0.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void push(int data)
        {
            if(size < capacity)
            {
                size++;
                stack[size] = data;
            }
            else
            {
                Console.WriteLine("Error: Stack Overflow. The maximum stack capacity has been reached.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void pop()
        {
            if(stack[size] != -1)
            {
                Console.WriteLine(stack[size] + " has been removed from the stack.");
                size--;
            }
            else
            {
                Console.WriteLine("Error: Stack Underflow. There are no more values in the stack to remove.");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        public void peek()
        {
            Console.WriteLine(stack[size] + " is at the top of the stack.");
        }
    }
}
