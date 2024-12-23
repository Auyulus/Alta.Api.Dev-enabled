using System;

namespace Alta.Api.DataTransferModels.Models.Responses;

public class MigrationDetailsResponse
{
	public bool HasMigrated { get; set; }

	public int ServerId { get; set; }

	public DateTime MigrationDateTime { get; set; }
}
