using Solution.Model;

namespace Solution.Answers
{
    public class MergeTwoSortedLists
    {
        public static void Run()
        {
            ListNode l1 = new ListNode { val = 1, next = new ListNode { val = 2, next = new ListNode { val = 4 } } };
            ListNode l2 = new ListNode { val = 1, next = new ListNode { val = 3, next = new ListNode { val = 4 } } };

            var response = Solution(l1, l2);
        }

        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode head = list1;
            if (list1.val > list2.val)
            {
                head = list2;
                list2 = list2.next;
            }
            else
            {
                list1 = list1.next;
            }

            ListNode curr = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    curr.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    list2 = list2.next;
                }
                curr = curr.next;
            }
            if (list1 == null)
                curr.next = list2;
            else
                curr.next = list1;

            return head;
        }
    }
}
