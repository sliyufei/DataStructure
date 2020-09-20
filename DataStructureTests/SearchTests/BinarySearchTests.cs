using DataStructureCore.Search;
using Xunit;

namespace DataStructureTests.SearchTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void Search()
        {
            var array = new int[] {1, 2, 4, 6, 7, 11};
            var binarySearch = new BinarySearch();
            var index = binarySearch.Search(array, 0, 6, 10);
        }

        [Fact]
        public void Search2()
        {
            var array = new int[] { 1, 2, 4, 6, 7, 11 };
            var binarySearch = new BinarySearch();
            var index = binarySearch.Search2(array, 4);
        }
    }
}