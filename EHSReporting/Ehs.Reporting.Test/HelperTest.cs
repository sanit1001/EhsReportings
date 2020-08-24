using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ehs.Reporting.MR.Helpers;
using Xunit;

namespace Ehs.Reporting.Test
{
    public class HelperTest
    {
        [Fact]
        public void BatchHelperTest()
        {
            var list = Enumerable.Range(1,10000).ToArray();

            var batchCount = list.Batch(500).Count();
            
            Assert.Equal(20, batchCount);
            Assert.Equal(500, list.Batch(500).ToList()[0].Last());
            Assert.Equal(501, list.Batch(500).ToList()[1].First());
            Assert.Equal(1000, list.Batch(500).ToList()[1].Last());
            Assert.Equal(1001, list.Batch(500).ToList()[2].First());

        }
    }
}
