using System;
using NUnit.Framework;

namespace MvcApplication.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_WhenIEatBanana_WillNotFail()
        {
            const string who = "I";
            Func<string, string, bool> eat = (subject, objectt) => subject == "I" && objectt == "banana";
            const string what = "banana";

            Assert.IsTrue(eat(who, what));
        }

        [Test]
        public void Index_WhenStuffIsGoingOn_WillReturnStuff()
        {
            Assert.IsTrue(31 > 1);
        }
    }
}
