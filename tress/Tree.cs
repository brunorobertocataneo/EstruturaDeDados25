using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tress
{
    // Classe genérica que representa a Árvore
    public class Tree<T>
    {
        public TreeNode<T> Root { get; set; }
    }
}
