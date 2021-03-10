//https://www.youtube.com/watch?v=0AO7OwNzd2Y

//3/10/21

using System;

class LinkedListNode //Appears like this is the node 
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
    int count;
    LinkedListNode head;

    public LinkedList ()
    {
        head = null;
        count = 0;
    }

    public void AddNodeToFront(int data)
    {
        LinkedListNode node = new LinkedListNode(data); //linked list is empty. Adding a node. First, create it. 
        node.next = head; //Next set the next node equal to head. Which in this case is null. The first node will have a next value of null. 
        head = node; //Then set head eqaul tot the current node. Each node added becomes the head. 
        count++; //increment count of the linked list  
    }

    public void PrintList()
    {
        LinkedListNode runner = head;
        while(runner != null){
           Console.WriteLine(runner.data);
           runner = runner.next;
        }
    }

    public LinkedListNode RemoveDuplicatesFromLinkedList(LinkedListNode linkedList) { 
		LinkedListNode currentNode = linkedList;
		while(currentNode != null){
			LinkedListNode nextDistinctNode = currentNode.next;
		while(nextDistinctNode != null && nextDistinctNode.data == currentNode.data){
			nextDistinctNode = nextDistinctNode.next;
		}
			currentNode.next = nextDistinctNode;
			currentNode = nextDistinctNode;
		}
		
		return linkedList;
	}

    /*
    Remove the first element in the array 
    Remove the last 
    */
}