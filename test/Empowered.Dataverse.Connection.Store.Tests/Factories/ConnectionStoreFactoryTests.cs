namespace Empowered.Dataverse.Connection.Store.Factories;

public class ConnectionStoreFactoryTests
{
    [Fact(Skip = "has problems with file access")]
    public void ShouldGetConnectionStoreFromFactory()
    {
        ConnectionStoreFactory.Get().Should().NotBeNull().And.BeOfType<ConnectionStore>();
    }
}
