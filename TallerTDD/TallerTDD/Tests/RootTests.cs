using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TallerBT.BT;

namespace TallerTDD.Tests
{
    [TestFixture]
    public class RootTests
    {
        [Test]
        public void Root_CanOnlyHaveOneChild()
        {
            Root root = new Root();
            Node child1 = new WaitTask(1.0f);
            Node child2 = new WaitTask(2.0f);

            root.SetChild(child1);
            Assert.Throws<InvalidOperationException>(() => root.SetChild(child2));
        }

        [Test]
        public void Root_CannotHaveAnotherRootAsChild()
        {
            Root root = new Root();
            Root anotherRoot = new Root();
            Assert.Throws<InvalidOperationException>(() => root.SetChild(anotherRoot));
        }
    }

}
