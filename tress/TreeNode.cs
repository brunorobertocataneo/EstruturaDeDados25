using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tress
{
    // <T> -> o T é a especificação de um tipo genérico (Generics)
    public class TreeNode<T>
    {
        public T Data { get; set; } // Valor armazenado no nó

        public TreeNode<T> Parent { get; set; } // Referência ao nó pai

        public List<TreeNode<T>> Children { get; set; } = new List<TreeNode<T>>(); // Lista de nós filhos

        // Método que retorna a altura do nó na árvore
        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
}
