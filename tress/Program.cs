using System;
using System.Collections.Generic;
using tress; // namespace onde estão Tree e TreeNode

// Declaração de variável tree do tipo Tree
// Onde Tree<int> agora é de inteiros
Tree<int> tree = new Tree<int>();

// Root é o nó raiz da árvore
// instanciado com seu tipo TreeNode
// onde TreeNode<int> por sua vez é de inteiros
tree.Root = new TreeNode<int>
{
    Data = 100
};

tree.Root.Children = new List<TreeNode<int>>
{
    new TreeNode<int> { Data = 50, Parent = tree.Root },
    new TreeNode<int> { Data = 1, Parent = tree.Root },
    new TreeNode<int> { Data = 150, Parent = tree.Root }
};

// Adicionando um filho ao nó "150"
tree.Root.Children[2].Children = new List<TreeNode<int>>
{
    new TreeNode<int> { Data = 30, Parent = tree.Root.Children[2] }
};

// Saída no console para verificar
Console.WriteLine("Raiz: " + tree.Root.Data);
foreach (var child in tree.Root.Children)
{
    Console.WriteLine("Filho: " + child.Data + " (Pai: " + child.Parent.Data + ")");
    foreach (var grandChild in child.Children)
    {
        Console.WriteLine("   Neto: " + grandChild.Data + " (Pai: " + grandChild.Parent.Data + ")");
    }
}
