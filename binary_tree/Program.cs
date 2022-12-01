using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Binary tree
//DU - 1) Count jako vlastnost ktera se bude pocitat
//	   2) Genericky binary tree

var newtree = new BinaryTree();
newtree.Insert(5);
newtree.Insert(1);
newtree.Insert(7);
newtree.Insert(2);
newtree.Insert(4);
Console.WriteLine(newtree.ToString());

public class BinaryTree
{
	Node root;
    string output = "";
    public BinaryTree()
	{
        root = null;
	}

	public void Insert(int input)
	{
		
		if (root == null)
		{
            root = new Node(input);
			return;
		}
		InsertRecursively(root, input);

    }

	void InsertRecursively(Node root, int newnode)
	{
		if (newnode <= root.value)
		{
			if (root.left == null)
			{
				root.left = new Node(newnode);
			}
			else
			{
                InsertRecursively(root.left, newnode);
            }
        }
		else
		{
            
            if (root.right == null)
            {
                root.right = new Node(newnode);
            }
			else
			{
                InsertRecursively(root.right, newnode);
            }
            
            
        }
	}

	public bool Delete(int input)
	{
		if (root == null)
		{
			Console.WriteLine("No elems");
		}
		return DeleteRecursively(root, input);
	}

	bool DeleteRecursively(Node root, int input)
	{
		if (root.value == input)
		{
			// 1) nemame zadneho naslednika, u predchudce zmenime na null
			// 2) mam jednoho naslednika, u predchudce nahradim sebe naslednikem
			// 3) mam oba nasledniky, upredchudce nahradim sebe jednim naslednikem a podstrom druheho naslednika, zaradim do prvniho naslednika
		}
		else if (input <= root.value)
		{
			if (root.left != null)
			{
				return DeleteRecursively(root.left, input);
			}
			return false;
		}
        else
        {
            if (root.right != null)
            {
                return DeleteRecursively(root.right, input);
            }
            return false;
        }
    }



	public override string ToString()
	{
		
		if (root != null)
		{
			PrintRecursively(root);
		}
		return output;
	}


	void PrintRecursively(Node root)
	{
		if (root.left != null)
		{
			PrintRecursively(root.left);
			
		}
		output = output + ", " + root.value;

		if (root.right != null)
		{
			PrintRecursively(root.right);
			
		}

    }
}

public class Node
{
	public int value;
    public Node left;
	public Node right;

	public Node(int val)
	{
		value = val;
		left = right = null;
		
	}
}