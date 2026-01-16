using DSA.Arrays.Traversing;

namespace DSA.Arrays.Tests
{
    public class TraversingTests
    {
        [Fact]
        public void ForwardTraversal_Should_Run_Without_Error()
        {
            int[] arr = {1,2,3,4 };
            ForwardTraversal.Traverse(arr);
            Assert.True(true);
        }
    }
}
