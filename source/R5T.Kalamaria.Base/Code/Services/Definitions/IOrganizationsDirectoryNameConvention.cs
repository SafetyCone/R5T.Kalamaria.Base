using System;using R5T.T0064;


namespace R5T.Kalamaria
{[ServiceDefinitionMarker]
    public interface IOrganizationsDirectoryNameConvention:IServiceDefinition
    {
        string GetOrganizationsDirectoryName();
    }
}
