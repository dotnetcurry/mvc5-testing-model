using Moq;
using MVC5_Testing_1.ModelAccess;
using NUnit.Framework;

namespace MVCModelTest
{
    [TestFixture]
    public class CheckDepartmentTest
    {
        [Test]
        public void CheckDepartmentExist()
        {
            var obj = new DepartmentAccess();

            var Res = obj.CheckDeptExist(10);

            Assert.That(Res, Is.True);
        }

        [Test]
        public void CheckDepartmentExistWithMoq()
        {
            //Create Fake Object
            var fakeObject = new Mock<IDepartmentAccess>();
            //Set the Mock Configuration
            //The CheckDeptExist() method is call is set with the Integer parameter type
            //The Configuration also defines the Return type from the method  
            fakeObject.Setup(x => x.CheckDeptExist(It.IsAny<int>())).Returns(true);
            //Call the methid
            var Res = fakeObject.Object.CheckDeptExist(10);

            Assert.That(Res,Is.True);
        }
    }
}
