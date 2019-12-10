using System;
using log4net;
using System.Collections.Generic;
namespace AsalIntern2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var infoLogger = LogManager.GetLogger("InfoLogger");
            var yourLogger = LogManager.GetLogger("Your_Logger_Name");

            // app start
            infoLogger.Info("App started");

            // in the app
            yourLogger.Warn("Bad things happened");

            LinkedList list = new LinkedList();//intiallize of linked list
            NodeT tree = new NodeT();//intialliaze of tree.
            bool continu = true;
            int num;
            while (continu)
            {
                Console.WriteLine("         --**Menu**--");
                Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
                Console.WriteLine("Please Choose DataStructure");
                Console.WriteLine("1.Linked List");
                Console.WriteLine("2.Tree");
                Console.WriteLine("3.Exit");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        LMenu(list);
                        break;
                    case 2:
                        TMenu(tree);
                        break;
                    case 3:
                        continu = false;
                        break;
                }

            }
        }
        public static LinkedList LMenu(LinkedList list)
        {
            while (true)
            {
                int num1;
                Console.Clear();
                Console.WriteLine("              --** Linked List **--");
                Console.WriteLine(" ------------------------------------------------");
                Console.WriteLine("   Choose an option:");
                Console.WriteLine("1) Insert new node.");
                Console.WriteLine("2) Delete specific node.");
                Console.WriteLine("3) Search.");
                Console.WriteLine("4) Reverse.");
                Console.WriteLine("5) Sort.");
                Console.Write("\r\n Select here : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                switch (num1)
                {
                    case 1://insert new node
                        int data, counter;//for a number of data to insert
                        Console.WriteLine("how many item do you want to insert?");
                        counter = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the data");
                        for (int i = 0; i < counter; i++)
                        {
                            data = Convert.ToInt32(Console.ReadLine());
                            Node NewNode = new Node(data);
                            NewNode.data = data;
                            list.InsertToList(list,NewNode);
                       }
                        
                        list.printAllNode();
                        break;
                    case 2:
                       int key = Convert.ToInt32(Console.ReadLine());
                        list.Delete(key);
                        list.printAllNode();
                        break;
                    case 3:
                        int x = Convert.ToInt32(Console.ReadLine());
                        Node node=new Node(x);
                        list.Search(node, x);

                        break;
                    case 4:

                        list.Reverse(list);
                        break;
                }
                return list;
            }
        }
            public static NodeT TMenu(NodeT tree)
            {
            while (true) { 
                int num2;
                Console.Clear();
                Console.WriteLine("              --** Tree **--");
                Console.WriteLine(" ------------------------------------------------");
                Console.WriteLine("  Choose an option: ");
                Console.WriteLine("1) Insert new node . " + " ");
                Console.WriteLine("2) Traversal==>Postorder Inorder Preorder.");
                Console.WriteLine("3) Delete.");
                Console.Write("\r\n Select here : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                switch (num2)
                {
                    case 1:
                        int v;
                        NodeTree root = new NodeTree();
                        Console.Write("how many do you want to insert?  ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < a; i++)
                        {
                            v = Convert.ToInt32(Console.ReadLine());

                            tree.InsertToTree(root, v);
                            tree.PrintInorder(root);
                        }
                        break;  
                }
                return tree;
            }
        }    
    }
}

