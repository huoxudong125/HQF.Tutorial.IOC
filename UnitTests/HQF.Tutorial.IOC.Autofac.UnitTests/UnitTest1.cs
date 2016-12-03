using Autofac;
using HQF.Tutorial.IOC.Common.Interface;
using HQF.Tutorial.IOC.Common.Models;
using Xunit;
using Xunit.Abstractions;

namespace HQF.Tutorial.IOC.Autofac.UnitTests
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper _outputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void TestMethod1()
        {
            var container = DependencyInjection.Register();
            var itemService = container.Resolve<IItemService>();

            var itemEntity = new ItemEntity { Name = "Item7", Quiantity = 10 };

            var result = itemService.Add(itemEntity);

            _outputHelper.WriteLine("old :{0} ,new :{1}", itemEntity.Name, result.Name);
        }
    }
}