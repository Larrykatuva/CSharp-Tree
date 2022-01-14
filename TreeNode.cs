using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class TreeNode<T>
    {
        private bool hasParent;
        private T value;
        private List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert a null value");
            }
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public int ChildrenCount
        {
            get
            {
                return this.children.Count;
            }
        }

        public void AddChild(TreeNode<T> node)
        {
            if(node == null)
            {
                throw new ArgumentNullException(
                    "Cannot insert a null value");
            }
            if (node.hasParent)
            {
                throw new ArgumentException("TreeNode has a parent");
            }
            node.hasParent = true;
            this.children.Add(node);
        }

        public TreeNode<T> GetChild(int index)
        {
            return this.children[index];
        }
    }
}
