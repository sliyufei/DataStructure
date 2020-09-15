namespace DataStructureCore.Model
{
    public class ThreadTreeNode
    {
        public readonly int Value;
        public ThreadTreeNode LeftNode { get; set; }
        public ThreadTreeNode RightNode { get; set; }
        
        public int LeftTag { get; set; }
        
        public int RightTag { get; set; }

        public ThreadTreeNode(int value)
        {
            this.Value = value;
            this.LeftNode = null;
            this.RightNode = null;

            this.LeftTag = 0;
            this.RightTag = 0;
        }
    }
}