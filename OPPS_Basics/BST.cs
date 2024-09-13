namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.data = data;
            left = null;
            right = null;
        }
    }

    class BinarySearchTree
    {
        // Method to build the tree
        public Node BuildTree(Node root)
        {
            Console.WriteLine("Enter the data (-1 to stop):");
            int data = int.Parse(Console.ReadLine());

            if (data == -1)
            {
                return null; // No node to add
            }

            root = new Node(data);

            Console.WriteLine("Enter data for the left node of " + data);
            root.left = BuildTree(root.left);

            Console.WriteLine("Enter data for the right node of " + data);
            root.right = BuildTree(root.right);

            return root;
        }

        // Method to perform in-order traversal
        public void InOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }

            InOrderTraversal(root.left);
            Console.Write(root.data + " ");
            InOrderTraversal(root.right);
        }

        // Method to perform Pre-order traversal
        public void PreOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.data + " ");
            PreOrderTraversal(root.left);
            PreOrderTraversal(root.right);
        }

        // Method to perform post-order traversal
        public void PostOrderTraversal(Node root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderTraversal(root.left);
            PostOrderTraversal(root.right);
            Console.Write(root.data + " ");

        }

        // Method to perform Level-order traversal
        public void LevelOrderTraversal(Node root)
        {


            // Create a queue and enqueue the root node`
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                // Dequeue a node from the front of the queue
                Node currentNode = queue.Dequeue();

                // Print the data of the dequeued node
                Console.Write(currentNode.data + " ");

                // Enqueue the left child
                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                // Enqueue the right child
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        // Method to mirror the tree
        public void mirror(Node root)
        {
            //code here
            if (root == null)
            {
                return;
            }

            Node temp = root.left;
            root.left = root.right;
            root.right = temp;

            mirror(root.left);
            mirror(root.right);

        }
    }

    class Program
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Node root = null;

            root = bst.BuildTree(root);  // Build the tree

            Console.WriteLine("In-order traversal of the BST:");
            bst.InOrderTraversal(root);  // Perform in-order traversal
            Console.WriteLine("\nLevel-order traversal of the BST");
            bst.LevelOrderTraversal(root);
            Console.WriteLine("\nPre-order traversal of the BST:");
            bst.PreOrderTraversal(root);
            Console.WriteLine("\nPost-order traversal of the BST:");
            bst.PostOrderTraversal(root);
            Console.WriteLine("\nMirror of the tree:");
            bst.mirror(root);


        }
    }
}