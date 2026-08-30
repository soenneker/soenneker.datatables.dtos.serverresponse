using System.Text.Json;
using Soenneker.Tests.Unit;

namespace Soenneker.DataTables.Dtos.ServerResponse.Tests;

public sealed class DataTableServerResponseTests : UnitTest
{
    [Test]
    public void Success_uses_DataTables_record_count_property_names()
    {
        DataTableServerResponse response = DataTableServerResponse.Success(3, 100, 25, Array.Empty<object>());
        using JsonDocument document = JsonDocument.Parse(JsonSerializer.Serialize(response));

        document.RootElement.GetProperty("recordsTotal");
        document.RootElement.GetProperty("recordsFiltered");
    }
}
