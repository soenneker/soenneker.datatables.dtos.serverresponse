[![](https://img.shields.io/nuget/v/soenneker.datatables.dtos.serverresponse.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serverresponse/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serverresponse/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serverresponse/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.dtos.serverresponse.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.dtos.serverresponse/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.dtos.serverresponse/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.dtos.serverresponse/actions/workflows/codeql.yml)

# Soenneker.DataTables.Dtos.ServerResponse

Represents a server response for DataTables server-side processing.

## Install

```bash
dotnet add package Soenneker.DataTables.Dtos.ServerResponse
```

## What you get

- `DataTableServerResponse` — Represents a server response for DataTables server-side processing.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DataTableServerResponse.Draw` | Gets or sets the draw counter that DataTables is expecting back from the server. | Gets or sets the draw counter that DataTables is expecting back from the server. |
| `DataTableServerResponse.TotalRecords` | Gets or sets the total number of records before filtering. | Gets or sets the total number of records before filtering. |
| `DataTableServerResponse.TotalFilteredRecords` | Gets or sets the total number of records after filtering. | Gets or sets the total number of records after filtering. |
| `DataTableServerResponse.Data` | Gets or sets the data to be displayed in the table. | Gets or sets the data to be displayed in the table. |
| `DataTableServerResponse.Error` | Gets or sets an optional error message to be displayed by DataTables. | Gets or sets an optional error message to be displayed by DataTables. |
| `DataTableServerResponse.ContinuationToken` | If applicable, a storage continuation token that the client must send back on the next request. Typically `null` when the current page is the last page. Optional. | If applicable, a storage continuation token that the client must send back on the next request. Typically `null` when the current page is the last page. Optional. |
| `DataTableServerResponse.Success(draw, recordsTotal, recordsFiltered, data, continuationToken)` | Creates a success response for DataTables server-side processing. | A configured DataTablesServerResponse. |
| `DataTableServerResponse.Fail(draw, errorMessage)` | Creates an error response for DataTables server-side processing. | A configured DataTablesServerResponse with the error message. |
