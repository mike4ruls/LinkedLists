// Name: Michael Ray
// Professor Cascioli
// GDAPS2
// Class: Custom Linked Node
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CustomLinkedNode
    {
        string data;
        CustomLinkedNode next;
        CustomLinkedNode previous;

        public CustomLinkedNode()
        {
            
        }

        // Holding the data
         public string Data
        {
            get { return data; }
            set { data = value; }
        }

        // Holding the link to the next node
        public CustomLinkedNode Next
        {
            get { return next; }
            set { next = value; }
        }

        // Holding the link to the previous node in the list
        public CustomLinkedNode Previous
        {
            get { return previous; }
            set { previous = value; }
        }

    }
}
