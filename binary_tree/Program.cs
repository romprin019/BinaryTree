// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//create a new tree
var tree = new BinaryTree();

public class BinaryTree
{
    public Node Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Add(int value)
    {
        var node = new Node(value);
        if (Root == null)
        {
            Root = node;
        }
        else
        {
            Root.Add(node);
        }
    }

    public void Print()
    {
        Root.Print();
    }
}

public class Node
{
    
    public int Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        Value = value;
    }

    public void Add(Node node)
    {
        if (node.Value < Value)
        {
            if (Left == null)
            {
                Left = node;
            }
            else
            {
                Left.Add(node);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = node;
            }
            else
            {
                Right.Add(node);
            }
        }
    }

    public void Print()
    {
        if (Left != null)
        {
            Left.Print();
        }
        Console.WriteLine(Value);
        if (Right != null)
        {
            Right.Print();
        }
    }
}

