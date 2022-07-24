namespace VShop.IdentityServer.SeedDataBase;

public interface IDataBaseSeedInitializer
{
    void InitalizeSeedRoles();
    void InitializeSeedUsers();
}