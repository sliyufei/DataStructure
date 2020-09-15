namespace DataStructureCore.Model
{
    public class TreeNode
    {
        public readonly int Value;
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int value)
        {
            this.Value = value;
            this.LeftNode = null;
            this.RightNode = null;
        }

    }
}