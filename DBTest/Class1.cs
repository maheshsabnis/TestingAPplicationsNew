using NUnit.Framework;
using System;
using Moq;
 
using DBApp;
using DBApp.Models;

namespace DBTest
{
	[TestFixture]
	public class DbTestClass
	{
		[Test]
		public void GetCategoryTest()
		{
			int catRowId = 1;
			Mock<IService> mock = new Mock<IService>();
			mock.Setup(c=>c.GetCategory(It.IsAny<int>())).Returns(true);

			//Dal dal = new Dal();
			//var res = dal.GetCategory(catRowId);
			//Assert.IsTrue(catRowId);
			BizApp biz = new BizApp(mock.Object);
			var res = biz.IsRecordExists(1);
			Assert.That(res, Is.EqualTo(true));
		}


	}
}
