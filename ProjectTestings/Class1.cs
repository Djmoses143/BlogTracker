using NUnit.Framework;
using NUnit.Framework.Legacy;
using Project_ClassLibrary_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTestings
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void checkEmployeeExistWithNunit()
        {
            var obj = new EmpInfoRepository();
            var res = obj.GetEmpInfo("moses@email.com");
            Assert.That(res, Is.Not.Null);
        }
        [Test]
        public void checkEmployeeCreateWithNunit()
        {
            EmpInfo emp = new EmpInfo
            {
                Name = "ABC",
                EmailId = "Asan@gmail.com",
                PassCode = 234231,
                DateOfJoining = DateTime.Now,
            };
            var obj = new BlogDbContext();
            EmpInfo res = obj.EmpInfo.Add(emp);
            obj.SaveChanges();
            ClassicAssert.AreEqual(emp.Name, res.Name);
            ClassicAssert.AreEqual(emp.EmailId, res.EmailId);
        }
    }
}
