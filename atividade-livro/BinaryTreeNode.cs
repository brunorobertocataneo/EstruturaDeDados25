public class BinaryTreeNode<T> : TreeNode<T>
{
    public BinaryTreeNode<T> Left
    {
        get
        {
            if (Children != null && Children.Count > 0)
                return (BinaryTreeNode<T>)Children[0];
            return null;
        }
    }

    public BinaryTreeNode<T> Right
    {
        get
        {
            if (Children != null && Children.Count > 1)
                return (BinaryTreeNode<T>)Children[1];
            return null;
        }
    }
}
