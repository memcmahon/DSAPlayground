using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSAPlayground
{
    public class OrderedListTest
    {
        [Fact]
        public void IsCreated()
        {
            var orderedList = new OrderedList<string>();
        }
    }
}
