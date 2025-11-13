using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace binary_tree
{
    public class TreeNode<T> // Elemento genérico, possso escolher o tipo de dado
    {
        public T? data { get; set; }
        public TreeNode<T>? Parent { get; set; }
        public List<TreeNode<T>> Children { get; set; } = []; // Todos esses são atributos

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;

            while (current.Parent != null!)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}