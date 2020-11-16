using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab5
{
    class Stack
    {
        List<int> stack = new List<int>();
        public void AddItem(int elem) { stack.Add(elem); }
        public void DeleteItem() { stack.RemoveAt(0); }
        public int ShowTheNumberOfItems() { return stack.Count; }
        public int ShowMinItem() { return stack.Min(); }
        public int ShowMaxItem() { return stack.Max(); }
        public bool FindAnItem(int elem) { return stack.Contains(elem); }
        public void PrintAllItems() { foreach (var elem in stack) Console.WriteLine(elem); }
        public void ClearAll() { stack.Clear(); }

        public int this[int index]
        {
            get => stack[index];
        }
    }
}
