using System.Reflection;

namespace MsTestDeploymentFolder;

[TestClass]
public class DeploymentDirectoryTests
{
    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    public void ContentFileIsInDeploymentFolder()
    {
        var path = Path.Combine(this.TestContext.DeploymentDirectory, "sample.json");
        Assert.IsTrue(File.Exists(path));
    }

    [TestMethod]
    public void ContentFileIsInExecutingAssemplyLocation()
    {
        var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "sample.json");
        Assert.IsTrue(File.Exists(path));
    }
}