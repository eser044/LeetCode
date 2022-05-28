using Solution.Model;

namespace Solution.Answers
{
    public class AddTwoNumbers
    {
        public static void Run()
        {
            ListNode l1 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9 } } } } } } };
            ListNode l2 = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9, next = new ListNode { val = 9 } } } };

            //ListNode l1 = new ListNode { val = 2, next = new ListNode { val = 4, next = new ListNode { val = 3 } } };
            //ListNode l2 = new ListNode { val = 5, next = new ListNode { val = 6, next = new ListNode { val = 4 } } };

            var response = Solution(l1, l2);
        }
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode result = head;

            int carry = 0;
            int sum = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                sum = 0;

                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }

                sum += carry;
                carry = sum / 10;

                result.next = new ListNode(sum % 10);
                result = result.next;
            }
            return head.next;
        }
    }
}
