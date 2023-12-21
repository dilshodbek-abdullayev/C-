// LeetCode 232

/*
public class MyQueue
{
    private readonly Stack<int> _stack1;
    private readonly Stack<int> _stack2;

    public MyQueue()
    {
        _stack1 = new Stack<int>();
        _stack2 = new Stack<int>();

    }

    public void Push(int x)
    {
        _stack1.Push(x);
    }

    public int Pop()
    {
        Prepare(); 
        return _stack1.Pop();
    }

    public int Peek()
    {
        Prepare ();
        return _stack1.Peek();
    }

    public bool Empty()
    {
        return ( _stack1.Count == 0 ) && (_stack2.Count == 0);
    }
    private void Prepare()
    {
        if(_stack2.Count > 0)
        {
            return;
        }
        while(_stack1.Count > 0)
        {
            _stack2.Push(_stack1.Pop());
        }
    }
}
*/

// LeetCode 225

/*public class MyStack
{
    private Queue<int> q;
    public MyStack() 
    { 
    
        q = new Queue<int>();
    }
    public void Push(int x)
    {
        q.Enqueue(x);
        for(int i = 0; i < q.Count-1; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }
    public int Pop()
    {
        return q.Dequeue();
    }
    public int Top()
    {
        return q.Peek(); 
    }
    public bool Empty()
    {
        return q.Count == 0;
    }
}*/

// LeetCode 1381
public class CustomStack
{
    int[] stack;
    int i;
    public CustomStack(int maxSize)
    {
        stack = new int[maxSize];
        i = -1;
    }

    public void Push(int x)
    {
        if (i < stack.Length - 1)
        {
            i++;
            stack[i] = x;
        }
    }

    public int Pop()
    {
        if (i > -1)
            return stack[i--];
        else return -1;
    }

    public void Increment(int k, int val)
    {
        int j = 0;
        while (j < k && j < stack.Length)
        {
            stack[j] += val;
            j++;
        }
    }
}

