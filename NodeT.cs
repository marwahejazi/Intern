using System;
namespace AsalIntern2
{
    public class NodeTree
    {
        public int Data;
        public NodeTree left, right;
        public int key;
        //true?
        public NodeTree()
        {
            int item;
            item = key;
            left = right = null;
        } }
        public class NodeT
        {
            NodeTree Root;
            public NodeTree InsertToTree(NodeTree root, int value)
            {
                if (root == null)
                {
                    root = new NodeTree();
                    root.Data = value;
                }
                else if (value < root.Data)
                {
                    root.left = InsertToTree(root.left, value);
                }
                else
                {
                    root.right = InsertToTree(root.right, value);
                }
                return root;
            }
            //Traversal tree
           public void PrintPostorder(NodeTree node)
            {
                if (node == null)
                    return;
                PrintPostorder(node.left);
                PrintPostorder(node.right);
                //(in driver)Console.Write(node.Data + " ");
            }
            public void PrintInorder(NodeTree node)
            {
                if (node == null)
                    return;
                PrintInorder(node.left);
                //(in driver)Console.Write(node.Data + " ");
                PrintInorder(node.right);
            }
           public void PrintPreorder(NodeTree node)
            {
                if (node == null)
                    return;
              //(in driver) Console.Write(node.Data + " ");
                PrintPreorder(node.left);
                PrintPreorder(node.right);
            }
           public static bool Search(NodeTree node, int a)
            {
                if (node == null)
                    return false;
                if (node.Data == a)
                    return true;
                bool result1 = Search(node.right, a);
                bool result2 = Search(node.left, a);
                return result1 || result2;
            }
            //Delete with a specific key.
            public void DeleteKey(int key)
            {
                Root = DeleteRec(Root, key);
            }
            NodeTree DeleteRec(NodeTree root, int key)
            {
                if (root == null)
                    return root;
                if (key < root.key)
                    root.left = DeleteRec(root.left, key);
                else if (key > root.key)
                    root.right = DeleteRec(root.right, key);
                else
                {
                    if (root.left == null)
                        return root.right;
                    else if (root.right == null)
                        return root.left;
                    root.key = MinValue(root.right);
                    root.right = DeleteRec(root.right, root.key);
                }
                return root;
            }
            int MinValue(NodeTree root)
            {
                int minv = root.key;
                while (root.left != null)
                {
                    minv = root.left.key;
                    root = root.left;
                }
                return minv;
            }
        }
    }

