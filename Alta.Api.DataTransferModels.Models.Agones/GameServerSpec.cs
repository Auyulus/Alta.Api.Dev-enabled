using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Agones;

public class GameServerSpec
{
	public class GameServerTemplate
	{
		public class GameServerTemplateSpec
		{
			public class ContainerConfig
			{
				[JsonProperty("name")]
				public string Name { get; set; }

				[JsonProperty("image")]
				public string Image { get; set; }
			}

			[JsonProperty("containers")]
			public ContainerConfig[] Containers { get; set; } = new ContainerConfig[1]
			{
				new ContainerConfig()
			};
		}

		[JsonProperty("spec")]
		public GameServerTemplateSpec Spec { get; set; } = new GameServerTemplateSpec();
	}

	[JsonProperty("ports")]
	public List<SpecPortConfig> Ports { get; set; }

	[JsonProperty("template")]
	public GameServerTemplate Template { get; set; } = new GameServerTemplate();
}
