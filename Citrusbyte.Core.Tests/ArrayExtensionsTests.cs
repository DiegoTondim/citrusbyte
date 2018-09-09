using Xunit;

namespace Citrusbyte.Core.Tests
{
    public class ArrayExtensionsTests
    {
        [Fact]
        public void Should_Transform_Array_With_One_Item_Not_Flattened()
        {
            var array = new object[] { 1, 2, new object[] { 4 }, 5 };
            var arrayFlattened = array.ToFlattened();
            Assert.Equal(4, arrayFlattened.Length);
        }

        [Fact]
        public void Should_Transform_Array_With_One_Item_With_Three_Items_Not_Flattened()
        {
            var array = new object[] { 1, 2, new object[] { 3, 4, 5 }, 6 };
            var arrayFlattened = array.ToFlattened();
            Assert.Equal(6, arrayFlattened.Length);
        }

        [Fact]
        public void Should_Transform_Array_Without_Item_Nested()
        {
            var array = new object[] { 1, 2, 3, 4 };
            var arrayFlattened = array.ToFlattened();
            Assert.Equal(4, arrayFlattened.Length);
        }
    }
}
