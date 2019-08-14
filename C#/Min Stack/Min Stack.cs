public class Node {
    public int Value { get; set; }
    public Node Next { get; set; }
    public Node (int val) {
        Value = val;
        Next = null;
    }
}

public class MinStack {
    public Node StackTop { get; private set; }

    /** initialize your data structure here. */
    public MinStack () {

    }

    public void Push (int x) {
        Node newNode = new Node (x);
        newNode.Next = StackTop;
        StackTop = newNode;
    }

    public void Pop () {
        if (StackTop != null)
            StackTop = StackTop.Next;
    }

    public int Top () {
        return StackTop.Value;
    }

    public int GetMin () {
        if (StackTop == null) throw new Exception ("No Value");
        int minimal = StackTop.Value;
        Node ptr = StackTop.Next;
        while (ptr != null) {
            if (ptr.Value < minimal) minimal = ptr.Value;
            ptr = ptr.Next;
        }
        return minimal;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */