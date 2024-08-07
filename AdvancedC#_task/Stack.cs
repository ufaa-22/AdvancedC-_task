using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    public class StackOverflowException : Exception
    {
        public StackOverflowException(string message) : base(message)
        {
        }
    }

    public class StackUnderflowException : Exception
    {
        public StackUnderflowException(string message) : base(message)
        {
        }
    }
    internal class Stack :IStack
    {
        private int[] elements;
        private int top;
        private int max;

        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top == max - 1)
            {
                throw new StackOverflowException("Stack overflow");
            }
            else
            {
                elements[++top] = item;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack underflow");
            }
            else
            {
                return elements[top--];
            }
        }

    }
}
