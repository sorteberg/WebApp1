using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MvcApplication.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_WhenIEatBanana_WillNotFail()
        {
            Assert.Fail("DENNE TESTEN ER GAMMEL OG DÅRLIG");
        }

        [Test]
        public void Index_WhenStuffIsGoingOn_WillReturnStuff()
        {
            Assert.IsTrue(31 > 1);
        }
    }
}
