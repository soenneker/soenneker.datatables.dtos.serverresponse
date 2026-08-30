[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.serverresponse.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serverresponse/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serverresponse/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serverresponse/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.serverresponse.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serverresponse/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serverresponse/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serverresponse/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.ServerResponse

`DataTableServerResponse` produces the JSON envelope expected by DataTables when `serverSide` processing is enabled.

## Installation

```bash
dotnet add package Soenneker.DataTables.Dtos.ServerResponse
```

## Successful response

```csharp
using Microsoft.AspNetCore.Mvc;
using Soenneker.DataTables.Dtos.ServerResponse;

public IActionResult GetCustomers(int draw)
{
    CustomerRow[] page = GetCurrentPage();

    return Ok(DataTableServerResponse.Success(
        draw: draw,
        recordsTotal: 12_430,
        recordsFiltered: 87,
        data: page));
}
```

The serialized response uses DataTables' required property names:

```json
{
  "draw": 3,
  "recordsTotal": 12430,
  "recordsFiltered": 87,
  "data": []
}
```

`recordsTotal` is the count before search filters. `recordsFiltered` is the count after filtering but before paging. `data` contains only the requested page.

Always echo the parsed integer `draw` from the request; do not copy an untrusted raw string into a response.

## Failed response

```csharp
return Ok(DataTableServerResponse.Fail(request.Draw, "Unable to load customers."));
```

Keep `Error` suitable for display and log internal exception details separately. The optional `ContinuationToken` is a package extension for storage systems that page by cursor; DataTables itself does not manage that token automatically.
