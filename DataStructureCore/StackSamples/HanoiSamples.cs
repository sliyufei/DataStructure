using System;
namespace DataStructureCore.StackSamples
{
    public class HanoiSamples
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">N个圆盘</param>
        /// <param name="t1">从哪个柱子移动</param>
        /// <param name="t2">借助的柱子</param>
        /// <param name="t3">移动到哪个柱子</param>
        public void Hanoi(int n, string t1, string t2, string t3)
        {
            if (n == 1)
            {
                Console.WriteLine($"圆盘从{t1}移动到{t3}");
                return;
            }

            Hanoi(n - 1, t1, t3, t2);
            Console.WriteLine($"圆盘从{t1}移动到{t3}");
            Hanoi(n - 1, t2, t1, t3);
        }

    }
}
