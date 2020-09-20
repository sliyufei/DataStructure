using DataStructureCore.Model;
using DataStructureCore.Sort;
using Xunit;

namespace DataStructureTests.SortTests
{
    public class InsertSortTests
    {
        [Fact]
        public void SortTest()
        {
            var arr = new int[] {3, 6, 7, 4, 9};
            var insertSort = new InsertSort();
            insertSort.Sort(arr, SortDirection.Desc);

        }
    }
}