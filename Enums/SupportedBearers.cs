using FiftyOneDegrees.Business.Attributes;

namespace FiftyOneDegrees.Enums
{
    public enum SupportedBearers
    {
		// The device supports 1xRTT (also known as CDMA2000)
		[FiftyOneKey("1xRTT")]
		v1xrtt,

		// The device supports the 3GPP standard
		[FiftyOneKey("3GPP")]
		v3gpp,

		[FiftyOneKey("Bluetooth")]
		vbluetooth,

		// The device supports Code Division Multiple Access
		[FiftyOneKey("CDMA")]
		vcdma,

		[FiftyOneKey("CDMA2000")]
		vcdma2000,

		// The device supports Circuit Switched Data
		[FiftyOneKey("CSD")]
		vcsd,

		[FiftyOneKey("DC-HSDPA")]
		vdc_hsdpa,

		[FiftyOneKey("DC-HSPA+")]
		vdc_hspa_,

		[FiftyOneKey("DC-HSUPA")]
		vdc_hsupa,

		// The device can connect to the internet via a desktop.
		[FiftyOneKey("Desktop Passthrough")]
		vdesktop_passthrough,

		// The device can use EDGE technology (also known as EGPRS).
		[FiftyOneKey("EDGE")]
		vedge,

		[FiftyOneKey("Ethernet")]
		vethernet,

		// The device supports the Evolution-Data Optimized Only standard
		[FiftyOneKey("EVDO")]
		vevdo,

		[FiftyOneKey("FDD-LTE")]
		vfdd_lte,

		// The device supports the General Packet Radio Service
		[FiftyOneKey("GPRS")]
		vgprs,

		// The device supports the Global System for Mobile Communications standard
		[FiftyOneKey("GSM")]
		vgsm,

		// The device supports High-Speed Circuit-Switched Data
		[FiftyOneKey("HSCSD")]
		vhscsd,

		// The device supports High-Speed Downlink Packet Access
		[FiftyOneKey("HSDPA")]
		vhsdpa,

		[FiftyOneKey("HSDPA+")]
		vhsdpa_,

		// The device supports High-Speed Packet Access
		[FiftyOneKey("HSPA")]
		vhspa,

		// The device supports High-Speed Pack Access (also known as Evolved HSPA)
		[FiftyOneKey("HSPA+")]
		vhspa_,

		// The device supports High-Speed Uplink Packet Access
		[FiftyOneKey("HSUPA")]
		vhsupa,

		[FiftyOneKey("HSUPA+")]
		vhsupa_,

		// The device supports Intergrated Digital Enhanced Network
		[FiftyOneKey("iDEN")]
		viden,

		// Part of the 4G standard.
		[FiftyOneKey("LTE")]
		vlte,

		[FiftyOneKey("LTE-A")]
		vlte_a,

		[FiftyOneKey("LTE-U5G")]
		vlte_u5g,

		// The device doesn't support any bearers.
		[FiftyOneKey("NoneSupported")]
		vnonesupported,

		// The device supports Short Message Service
		[FiftyOneKey("SMS")]
		vsms,

		[FiftyOneKey("TD-CDMA")]
		vtd_cdma,

		[FiftyOneKey("TD-LTE")]
		vtd_lte,

		[FiftyOneKey("TD-SCDMA")]
		vtd_scdma,

		// The device supports Universal Mobile Telecommunications System
		[FiftyOneKey("UMTS")]
		vumts,

		// The device manufacturer or vendor does not provide information on what bearers the device supports.
		[FiftyOneKey("Unknown")]
		vunknown,

		// The device supports USB communication
		[FiftyOneKey("USB")]
		vusb,

		// The device supports Unstructured Supplementary Service Data
		[FiftyOneKey("USSD")]
		vussd,

		[FiftyOneKey("VoLTE")]
		vvolte,

		// The device supports Wideband Code Division Multiple Access. Similar to CDMA, developed by DoCoMo.
		[FiftyOneKey("WCDMA")]
		vwcdma,

		// The device supports WiFi
		[FiftyOneKey("WiFi")]
		vwifi,

		[FiftyOneKey("WiMAX")]
		vwimax,


    }
}
