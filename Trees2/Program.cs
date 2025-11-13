using System.ComponentModel;
using Trees2;

Tree<Person> company = new Tree<Person>();
company.Root = new TreeNode<Person>()
{
    Data = new Person(100, "Marcin Jamro", "CEO"),
    Parent = null
};
company.Root.Children = new List<TreeNode<Person>>()
{
    new TreeNode<Person> () {
        Data = new Person(1, "Jhon Smith", "Head of DEvelopment" ),
        Parent = company.Root
    },
    new TreeNode<Person>() {
        DataErrorsChangedEventArgs = new Person()
    }
};