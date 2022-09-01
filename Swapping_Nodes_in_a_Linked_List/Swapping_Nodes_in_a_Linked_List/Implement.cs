﻿namespace Swapping_Nodes_in_a_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Implement
    {
        public int Puzzle(ListNode node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return 1 + Puzzle(node.next);
            }
        }
        public ListNode SwapNodes(ListNode head, int k)
        {
            int length = Puzzle(head);
            int nodeLastK = length - k;
            int counter = nodeLastK;
            int counter2 = 0;

            var tempLastK = head;
            var tempFirstK = head;

            if (head.next == null)
            {
               return head;
            }
            else
            {

                while (counter > 0)
                {
                    tempLastK = tempLastK.next;
                    counter--;
                }

                while (counter2 <= k)
                {
                    tempFirstK = tempFirstK.next;
                    counter2++;
                }

                var temp = tempFirstK.val;
                tempFirstK.val = tempLastK.val;
                tempLastK.val = temp;
            }
            return head;
        }
    }
}

