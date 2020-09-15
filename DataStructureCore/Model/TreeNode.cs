namespace DataStructureCore.Model
{
    public class TreeNode
    {
        public  int Value { get; set; }
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