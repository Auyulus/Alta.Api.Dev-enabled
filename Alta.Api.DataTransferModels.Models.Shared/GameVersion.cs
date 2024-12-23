using System;
using Newtonsoft.Json;

namespace Alta.Api.DataTransferModels.Models.Shared;

public class GameVersion : IEquatable<GameVersion>
{
	[JsonProperty("title")]
	public int Title { get; set; } = 1;

	[JsonProperty("stream")]
	public string Stream { get; set; }

	[JsonProperty("season")]
	public int Season { get; set; }

	[JsonProperty("major")]
	public int Major { get; set; }

	[JsonProperty("minor")]
	public int Minor { get; set; }

	[JsonProperty("changeSet")]
	public int ChangeSet { get; set; }

	[JsonConstructor]
	public GameVersion()
	{
	}

	public GameVersion(string stream, int title, int season, int major, int minor, int changeSet)
	{
		Title = title;
		Stream = stream;
		Season = season;
		Major = major;
		Minor = minor;
		ChangeSet = changeSet;
	}

	public GameVersion(string stream, int season, int major, int minor, int changeSet)
	{
		Title = 1;
		Stream = stream;
		Season = season;
		Major = major;
		Minor = minor;
		ChangeSet = changeSet;
	}

	public override string ToString()
	{
		if (Stream == null)
		{
			string text2 = (Stream = "main");
		}
		return $"{Stream}-{Title}.{Season}.{Major}.{Minor}.{ChangeSet}";
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is GameVersion gameVersion))
		{
			return false;
		}
		if (gameVersion.Stream != Stream || gameVersion.Season != Season || gameVersion.Major != Major || gameVersion.Minor != Minor || gameVersion.ChangeSet != ChangeSet)
		{
			return false;
		}
		return true;
	}

	public static bool operator ==(GameVersion a, GameVersion b)
	{
		if ((object)a == b)
		{
			return true;
		}
		return a?.Equals(b) ?? false;
	}

	public static bool operator !=(GameVersion a, GameVersion b)
	{
		return !(a == b);
	}

	public bool Equals(GameVersion other)
	{
		if ((object)other == null)
		{
			return false;
		}
		if ((object)this == other)
		{
			return true;
		}
		if (Stream == other.Stream && Season == other.Season && Major == other.Major && Minor == other.Minor)
		{
			return ChangeSet == other.ChangeSet;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((((((Stream != null) ? Stream.GetHashCode() : 0) * 397) ^ Season) * 397) ^ Major) * 397) ^ Minor) * 397) ^ ChangeSet;
	}
}
