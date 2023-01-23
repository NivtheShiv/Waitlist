public class LinkedList<T>
{
    internal class Node
    {
        // Auto implemented properties
        public T Value { get; }
        public Node? Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    // Field
    private Node? head;
    public LinkedList() {}

    public void Append(T value)
    {
        // Construct a Node based off of the value
        Node node = new Node(value);
        // EZ Case: The head is null (The list is empty!)
        if (this.head == null)
        {
            this.head = node;
            return;
        }
        // Find the end of the lsit
        Node curr = head;
        while (curr.Next != null) // While node has someone behind
        {
            // Go to next node
            curr = curr.Next;
        }
        // The curr we are looking at does not have someone behind them
        // Put node behind curr
        curr.Next = node;
    }
    public void Prepend(T value)
    {
        Node node = new Node(value);

        // List is empty - add element as head;
        if (this.head == null)
        {
            this.head = node;
            return;
        }

        // Prepend the element
        Node oldHead = this.head;
        this.head = node;
        this.head.Next = oldHead;
    }


    public T? LookAtFirst()
    {
        // List is empty - nothing to look at
        if (this.head == null)
        {
            return default(T);
        }

        // Simply return the first elemet
        return this.head.Value;
    }

    public T? RemoveFirst()
    {
        // Nothing to remove
        if (this.head == null)
        {
            return default(T);
        }

        // Save first element's value
        T val = this.head.Value;
        // Remove first element
        this.head = this.head.Next;
        // Return the value
        return val;
    }

    public bool IsEmpty()
    {
        return this.head == null;
    }

    public T? LookFor(T e)
    {
        T? found = default(T);
        // Loop Through List
        Node? curr = this.head;
        while (curr != null)
        {
            if (curr.Value!.Equals(e))
            {
                found = curr.Value;
            }
            // Go to next element in the list
            curr = curr.Next;
        }
        return found;
    }

    public override string ToString()
    {
        string listRepr = "";
        Node? curr = head;

        if (curr == null)
        {
            return "EMPTY";
        }

        while (curr.Next != null)
        {
            listRepr += curr.Value + " -> ";
            curr = curr.Next;
        }
        listRepr += curr.Value;
        // listRepr += "NULL";
        return  "( " + listRepr + " )";
    }




}