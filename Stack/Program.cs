using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack("TestObject");

            Console.WriteLine($"{stack.Name} created.");

 //           stack.Push(null);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("\nPushed 1, 2 and 3 to the stack.");

            Console.WriteLine("\n");
            Console.WriteLine($"Removing {stack.Pop()} from the stack.");
            Console.WriteLine($"Removing {stack.Pop()} from the stack.");
            Console.WriteLine($"Removing {stack.Pop()} from the stack.");

            stack.Clear();

            Console.ReadKey();

//            stack.Pop();


        }

        public class Stack
        {
            public string Name { get;}
            private readonly List<object> _stack = new List<object>();

            public Stack(string name)
            {
                Name = name;
            }

            public void Push(object obj)
            {
                if (obj == null) throw new ArgumentNullException(nameof(obj));
                _stack.Add(obj);
            }

            public object Pop()
            { 
                if (_stack.Count == 0) throw new IndexOutOfRangeException($"The stack '{Name}' is empty.");
                var topStack = _stack[_stack.Count-1];
                _stack.Remove(_stack[_stack.Count-1]);
                return topStack;
            }

            public void Clear()
            {
                _stack.Clear();
                Console.WriteLine($"\nStack cleared. There are {_stack.Count} elements in the object '{Name}'.\n");
            }
        }
    }
}
