using System.Collections.Generic;
using System.Linq;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class Region
{
	public static readonly Region UsEast1 = new Region("USEast1", "US East (Virginia)");

	public static readonly Region CnNorth1 = new Region("CNNorth1", "China (Beijing)");

	public static readonly Region ApSoutheast2 = new Region("APSoutheast2", "Asia Pacific (Sydney)");

	public static readonly Region EuCentral1 = new Region("EUCentral1", "EU Central (Frankfurt)");

	public static readonly Region UsWest1 = new Region("USWest1", "US West (N. California)");

	public static readonly Region UsEast2 = new Region("USEast2", "US East (Ohio)");

	public static readonly Region ApNortheast1 = new Region("APNortheast1", "Asia Pacific (Tokyo)");

	private static HashSet<Region> allRegions;

	public static IEnumerable<Region> AllRegions
	{
		get
		{
			if (allRegions == null)
			{
				allRegions = new HashSet<Region> { UsEast1, CnNorth1, ApSoutheast2, EuCentral1, UsWest1, UsEast2, ApNortheast1 };
			}
			return allRegions;
		}
	}

	public string FriendlyName { get; }

	public string ShortName { get; }

	public Region(string friendlyName, string shortName)
	{
		FriendlyName = friendlyName;
		ShortName = shortName;
	}

	public static Region Parse(string name)
	{
		return AllRegions.FirstOrDefault((Region item) => item.ShortName == name);
	}
}
