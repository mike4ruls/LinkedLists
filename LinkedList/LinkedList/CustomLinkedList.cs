// Name: Michael Ray
// Professor Cascioli
// GDAPS2
// Class: Custom Link List
// They my list works is it doesn't go by 0, so it starts at 1 with list
// mainly because i hate the way 0 is the first indexer in programming.
// It can get confusing sometimes. 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CustomLinkedList
    {
        Random rgen = new Random();
        CustomLinkedNode head;
        CustomLinkedNode tail;
        int count;

        public CustomLinkedList()
        {
            //head = null;
            count = 0;
        }

        /// <summary>
        /// Will add a node to the list
        /// </summary>
        /// <param name="data">the data to be stored in the node</param>
        public void Add(string data)
        {
            // CustomLinkedNode current; OLD CODE

            // If there is no nodes in the list
            if (count == 0)
            {
                head = new CustomLinkedNode(); // creating a new node and setting it as a head node
                tail = head; // tail equals head sinces it's the only node in the list
                head.Data = data; // Storing the data
                //head.Next = null;
            }
            // if there is only 1 node in the list
            else if(count == 1)
            {
                head.Next = new CustomLinkedNode(); // Creating a new new node and linking it to the head
                head.Next.Data = data; // storing data into the new node
                head.Next.Previous = head; // linking the new node back to the head
                tail = head.Next; // changing the tail to the new end of the list

                //head.Next = null; OLD CODE

            }
            else
            {

                tail.Next = new CustomLinkedNode(); // Creating a new new node and linking it to the tail
                tail.Next.Data = data; // storing the data
                tail.Next.Previous = tail; // linking the previous node
                tail = tail.Next; // setting the new tail

                /* OLD CODE
                current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new CustomLinkedNode();
                current.Next.Data = data;
                //current.Next = null;
                */
            }

            count += 1; // incrementing the count of nodes in the list
        }

        /// <summary>
        /// This will find a node in the list and return it's data
        /// </summary>
        /// <param name="index">the index of the node wanted</param>
        /// <returns></returns>
        public string GetData(int index)
        {
            if(index <= 0 || index > count)
            {
                throw new Exception("The number you entered is invalid");
            }
            else
            {
                CustomLinkedNode returnNode = head;
                for (int i = 1; i < index; i++)
                {
                    if (index == 1)
                    {
                        break;
                    }
                    returnNode = returnNode.Next;
                }
                return returnNode.Data;
            }        

        }

        /// <summary>
        /// Insert a node in between 2 nodes
        /// </summary>
        /// <param name="data">the data to store into the new node</param>
        /// <param name="index">where you want to insert the new node into</param>
        public void Insert(string data, int index)
        {
            index += 1;
            CustomLinkedNode newNode = new CustomLinkedNode();
            newNode.Data = data;
            if(index <= 0)
            {
               
            }
            else if (index == 1)
            {
                newNode.Next = head;
                newNode.Next.Previous = newNode;
                head = newNode;
                count += 1;
            }
            else if(index > count)
            {
                Add(data);
            }
            else
            {
                CustomLinkedNode current = head;
                index -= 1;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                newNode.Next.Previous = newNode;
                newNode.Previous = current;
                current.Next = newNode;

                count += 1;

            }
            
            
        }

        /// <summary>
        /// Deleting a node
        /// </summary>
        /// <param name="index"> the node you want to delete</param>
        /// <returns></returns>
        public string RemoveAt(int index)
        {
            CustomLinkedNode delNode = null;
            if (index < 1 || index > Count)
            {
                return "There is no names to take out";
            }
            else if(index == 1 && count == 1)
            {
                head = null;
                tail = head;
                count = 0;
                return "";
            }
            else if(index == 1)
            {
                delNode = head;
                head = head.Next;
                head.Previous = null;
                if(count == 1)
                {
                    tail = head;
                }
                count -= 1;

                return delNode.Data;
            }
            else if (index == 2 && count == 2)
            {
                delNode = tail;
                tail = head;
                count -= 1;

                return delNode.Data;
            }
            else if(index == count)
            {
                index -= 1;
                CustomLinkedNode current = head;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                delNode = tail;
                current.Next = null;
                tail = current;

                count -= 1;
                return delNode.Data;
            }
            else
            {
                index -= 1;
                CustomLinkedNode current = head;
                for(int i = 1; i< index; i++)
                {
                    current = current.Next;
                }
                delNode = current.Next;
                current.Next = current.Next.Next;
                current.Next.Previous = current;

                count -= 1;
                return delNode.Data;

            }
        }

        /// <summary>
        /// Printing out the list backwards
        /// </summary>
        public void PrintReversed()
        {
            if (count == 0)
            {
               
            }
            else if (count == 1)
            {
                CustomLinkedNode current = tail;
                int numCount = count;
                Console.WriteLine(numCount + ") " + current.Data);
            }
            else
            {
                CustomLinkedNode current = tail;
                int numCount = count;
                Console.WriteLine(numCount + ") " + current.Data);
                while (current.Previous != null)
                {
                    numCount -= 1;
                    current = current.Previous;
                    Console.WriteLine(numCount + ") " + current.Data);
                }
            }
            
        }

        /// <summary>
        /// Clearing the list of nodes
        /// </summary>
        public void Clear()
        {
            head = null;
            tail = head;
            count = 0;
        }

        /// <summary>
        /// Scrambling up the list
        /// </summary>
        public void Scramble()
        {
            if(count == 0 || count == 1)
            {

            }
            else
            {
                int ranNum = rgen.Next(1, count + 1);
                string name = RemoveAt(ranNum);

                int ranIndex = rgen.Next(0, count);
                Insert(name, ranIndex);
            }
            
        }

        /// <summary>
        /// Returns the number of nodes in the list
        /// </summary>
        public int Count
        {
            get { return count; }
        }

    }
}
