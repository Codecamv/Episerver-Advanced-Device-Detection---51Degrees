using FiftyOneDegrees.Business.Attributes;

namespace FiftyOneDegrees.Enums
{
    public enum LayoutEngine
    {
		// The browser uses the Blink Engine - Launched with Google Chrome 28
		[FiftyOneKey("Blink")]
		vblink,

		[FiftyOneKey("EdgeHTML")]
		vedgehtml,

		// The browser uses the Gecko engine - nearly always Firefox and Fennec browsers.
		[FiftyOneKey("Gecko")]
		vgecko,

		// Forerunner to Webkit, Webkit UAs usually contain 'KHTML' but they are seperate projects Most commonly used by the Konqueror browser.
		[FiftyOneKey("KHTML")]
		vkhtml,

		// Used on Poloaris v6
		[FiftyOneKey("Lumi")]
		vlumi,

		// Used on v4 and v5 BlackberryOS (not to be confused with Windows Phone OS 7.5).
		[FiftyOneKey("Mango")]
		vmango,

		// Used by Motorola based devices with Mobile Linux platform, browser name is Unknown
		[FiftyOneKey("MotoWebkit")]
		vmotowebkit,

		// The browser uses the Netfront engine - used by the Access Netfront browser.
		[FiftyOneKey("Netfront")]
		vnetfront,

		// The browser uses the NetSurf Engine. Most commonly used by NetSurf.
		[FiftyOneKey("NetSurf")]
		vnetsurf,

		// The browser uses the Presto engine - nearly always used by Opera made browsers.
		[FiftyOneKey("Presto")]
		vpresto,

		// The browser uses the Rapid 9 Engine. Commonly used by YRC Weblink.
		[FiftyOneKey("Rapid 9")]
		vrapid_9,

		// The browser uses the Trident engine - nearly always IE and other Microsoft made browsers.
		[FiftyOneKey("Trident")]
		vtrident,

		// The browser uses the U2 Engine. Most commonly used by UCBrowser on feature phones.
		[FiftyOneKey("U2")]
		vu2,

		// The browser uses the U3 Engine. Most commonly used by UCBrowser on smart phones.
		[FiftyOneKey("U3")]
		vu3,

		// The browser has not been tested against this property.  
		[FiftyOneKey("Unknown")]
		vunknown,

		// The browser uses the w3m Engine.
		[FiftyOneKey("w3m")]
		vw3m,

		// The browser uses the Webkit engine - usually Apple and Google (Android) browsers.
		[FiftyOneKey("Webkit")]
		vwebkit,


    }
}
