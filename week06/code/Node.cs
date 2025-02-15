using System.Reflection.Metadata.Ecma335;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data) {return;}


        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (Left.Data == value)
                return;
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (Right.Data == value)
                return;
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == Data) {return true;}
        else if (value < Data)
        {
            if (Left == null)
            {
                return false;
            }
            else
            {
                return Left.Contains(value);
            }
        }
        else
        {
            if (Right == null)
            {
                return false;
            }
            else
            {
                return Right.Contains(value);
            }
        }
    }

    public int GetHeight()
    {
        int l = 0;
        int r = 0;

        if (Left != null)
        {
            l = Left.GetHeight();
        }

        if (Right != null)
        {
            r = Right.GetHeight();
        }

        if (l >= r)
        {
            return l+1;
        }
        else
        {
            return r+1;
        }
    }
}