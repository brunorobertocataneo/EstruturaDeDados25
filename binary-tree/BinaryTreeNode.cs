using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace binary_tree
{
    public class BinaryTreeNode<T> : TreeNode<T> // Herda de TreeNode<T>
    {
        // public BinaryTreeNode() => Children = new List<TreeNode<T>>() { null, null }; // Inicializa a lista com dois elementos nulos

        public BinaryTreeNode()
        {
            Children = new List<TreeNode<T>>();
            Children.Add(null!); // Filho esquerdo
            Children.Add(null!); // Filho direito   
        }

        public BinaryTreeNode<T> Left
        {
            get { return (BinaryTreeNode<T>)Children[0]; }
            set { Children[0] = value; }
        }

        public BinaryTreeNode<T> Right
        {
            get { return (BinaryTreeNode<T>)Children[1]; }
            set { Children[1] = value; }
        }
        


       }
}