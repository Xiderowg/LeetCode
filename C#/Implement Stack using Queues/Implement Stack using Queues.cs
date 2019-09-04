public class MyStack {
    private Queue<int> queueHead, queueTail;

    /** Initialize your data structure here. */
    public MyStack () {
        queueHead = new Queue<int> ();
        queueTail = new Queue<int> ();
    }

    /** Push element x onto stack. */
    public void Push (int x) {
        queueHead.Enqueue (x);
    }

    /** Removes the element on top of the stack and returns that element. */
    public int Pop () {
        while (queueHead.Count > 1) {
            queueTail.Enqueue (queueHead.Dequeue ());
        }
        int val = queueHead.Dequeue ();
        var tmp = queueHead;
        queueHead = queueTail;
        queueTail = tmp;
        return val;
    }

    /** Get the top element. */
    public int Top () {
        while (queueHead.Count > 1) {
            queueTail.Enqueue (queueHead.Dequeue ());
        }
        int val = queueHead.Dequeue ();
        queueTail.Enqueue (val);
        var tmp = queueHead;
        queueHead = queueTail;
        queueTail = tmp;
        return val;
    }

    /** Returns whether the stack is empty. */
    public bool Empty () {
        return queueHead.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */