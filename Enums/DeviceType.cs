using FiftyOneDegrees.Business.Attributes;

namespace FiftyOneDegrees.Enums
{
    public enum DeviceType
    {
		// The device is primarily a games console
		[FiftyOneKey("Console")]
		vconsole,

		// The device is a desktop computer.
		[FiftyOneKey("Desktop")]
		vdesktop,

		// The device is an e-reader.
		[FiftyOneKey("EReader")]
		vereader,

		// The device is a media hub or set top box that requires an external display(s).
		[FiftyOneKey("MediaHub")]
		vmediahub,

		// The device is a mobile
		[FiftyOneKey("Mobile")]
		vmobile,

		// The device is mobile with a screen size less than 2.5 inches.
		[FiftyOneKey("SmallScreen")]
		vsmallscreen,

		// The device is a mobile phone (not a tablet) with a screen size greater than or equal to 2.5 inches and runs a modern OS (Android, iOS, Windows Phone, BlackBerry etc)
		[FiftyOneKey("SmartPhone")]
		vsmartphone,

		// The device is a computerised wristwatch that enables access to the Internet.
		[FiftyOneKey("SmartWatch")]
		vsmartwatch,

		// The device is a tablet
		[FiftyOneKey("Tablet")]
		vtablet,

		// The device is a smart TV.
		[FiftyOneKey("Tv")]
		vtv,


    }
}
