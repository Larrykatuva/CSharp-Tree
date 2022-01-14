using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T node)
        {
            if(node == null)
            {
                throw new ArgumentNullException("Cannot insert null node value");
            }
            this.root = new TreeNode<T>(node);
        }

        public Tree(T value, params Tree<T>[] children): this(value) { 
            foreach(Tree<T> child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        public void PrintDFS(TreeNode<T> node, string spaces)
        {
            if(this.root == null)
            {
                return;
            }
            Console.WriteLine(spaces + node.Value);
            TreeNode<T> child = null;
            for(int i = 0; i < node.ChildrenCount; i ++)
            {
                child = node.GetChild(i);
                this.PrintDFS(child, spaces + "  ");
            }
        }

        public void PrintBFS(TreeNode<T> node, string spaces)
        {
            if(this.root == null)
            {
                return;
            }
            Console.WriteLine(spaces + node.Value);
            TreeNode<T> child = null;
            for(int i = 0; i < node.ChildrenCount; i++)
            {

            }
        }
        public void TraverseDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }

    }
}
