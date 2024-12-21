namespace LinkList
{ 
 class Program
{


    class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }

    }

    class LinkedList
    {
        int count = 0;
        public LinkedListNode? head;
        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public void AddNodeToFront(int data)
        {

            LinkedListNode? node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;

        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }

    }

    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddNodeToFront(1);
        list.AddNodeToFront(2);
        list.AddNodeToFront(3);
        list.PrintList();
    }



}

}