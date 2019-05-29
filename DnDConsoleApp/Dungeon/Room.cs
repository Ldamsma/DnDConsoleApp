using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

class Room
{
	private enum Size {
		[Description("small")]
		Small,
		[Description("medium size")]
		Medium,
		[Description("large")]
		Large
	}

	private enum Cleanliness {
		[Description("clean")]
		Clean,
		[Description("dirty")]
		Dirty
	}

	private enum Dressing {
		[Description("chairs in the corner")]
		Chairs,
		[Description("a bed")]
		Bed,
		[Description("nothing of note")]
		Empty
	}

	private String roomDescription = string.Empty;
	private Size size;
	private Cleanliness cleanliness;
	private Dressing dressing;

	internal BaseItem item = null;

	public Enums.RoomType RoomType = Enums.RoomType.Undifined;
	public bool Visited = false;

	public Room(Enums.RoomType roomType) {
		this.RoomType = roomType;
		GenerateRoom();
		GenerateItem();
	}

	// Bestaat uit een grootte, opgeruimd / smerig, en heeft aankleding.
	// Daarnaast kan een kamer baddies bevatten, items of een doorgang zijn.
	private void GenerateRoom() {
		Random r = new Random();
		int rInt = r.Next(0, 100);
		double sizeChance = r.NextDouble() * 100;

		if (sizeChance >= 85) {
			this.size = Size.Large;
		} else if (sizeChance >= 60) {
			this.size = Size.Medium;
		} else  {
			this.size = Size.Small;
		}

		double cleanliness = r.NextDouble() * 100;

		if (cleanliness >= 70) {
			this.cleanliness = Cleanliness.Clean;
		} else {
			this.cleanliness = Cleanliness.Dirty;
		}

		double dressing = r.NextDouble() * 100;

		if (dressing >= 80) {
			this.dressing = Dressing.Bed;
		}else if (dressing >= 60) {
			this.dressing = Dressing.Chairs;
		}else {
			this.dressing = Dressing.Empty;
		}
	}

	private void GenerateItem() {
		if (!Visited) {
			Random r = new Random();
			int rInt = r.Next(0, 100);
			double dropChance = r.NextDouble() * 100;

			if (dropChance >= 80) {
				this.item = new Equipment();
			}else if (dropChance >= 60) {
				this.item = new Consumable();
			}
		}
	}

	public String GetDescription() {
		if (string.IsNullOrEmpty(this.roomDescription)) {
			this.roomDescription = $"You enter a {GetEnumDescription(this.size)} {GetEnumDescription(this.cleanliness)} room, containing {GetEnumDescription(this.dressing)}.";
			if (this.item != null) {
				this.roomDescription = this.roomDescription + $" In the corner of the room you see a {this.item.Description}!";
			}
		}
		this.Visited = true;
		return this.roomDescription;
	}

	private string GetEnumDescription(Enum value) {
		FieldInfo fi = value.GetType().GetField(value.ToString());

		DescriptionAttribute[] attributes =
			(DescriptionAttribute[])fi.GetCustomAttributes(
			typeof(DescriptionAttribute),
			false);

		if (attributes != null &&
			attributes.Length > 0)
			return attributes[0].Description;
		else
			return value.ToString();
	}
}
