using FiftyOneDegrees.Business.Attributes;

namespace FiftyOneDegrees.Enums
{
    public enum PriceBand
    {
		[FiftyOneKey("0.00 - 49.99")]
		v0_00___49_99,

		[FiftyOneKey("100.00 - 149.99")]
		v100_00___149_99,

		[FiftyOneKey("1000.00 - 1099.99")]
		v1000_00___1099_99,

		[FiftyOneKey("1100.00 - 1199.99")]
		v1100_00___1199_99,

		[FiftyOneKey("11200.00 - 11299.99")]
		v11200_00___11299_99,

		[FiftyOneKey("1200.00 - 1299.99")]
		v1200_00___1299_99,

		[FiftyOneKey("1300.00 - 1399.99")]
		v1300_00___1399_99,

		[FiftyOneKey("1400.00 - 1499.99")]
		v1400_00___1499_99,

		[FiftyOneKey("150.00 - 199.99")]
		v150_00___199_99,

		[FiftyOneKey("1500.00 - 1599.99")]
		v1500_00___1599_99,

		[FiftyOneKey("1600.00 - 1699.99")]
		v1600_00___1699_99,

		[FiftyOneKey("1700.00 - 1799.99")]
		v1700_00___1799_99,

		[FiftyOneKey("1900.00 - 1999.99")]
		v1900_00___1999_99,

		[FiftyOneKey("200.00 - 249.99")]
		v200_00___249_99,

		[FiftyOneKey("2000.00 - 2099.99")]
		v2000_00___2099_99,

		[FiftyOneKey("2100.00 - 2199.99")]
		v2100_00___2199_99,

		[FiftyOneKey("2200.00 - 2299.99")]
		v2200_00___2299_99,

		[FiftyOneKey("2300.00 - 2399.99")]
		v2300_00___2399_99,

		[FiftyOneKey("2400.00 - 2499.99")]
		v2400_00___2499_99,

		[FiftyOneKey("250.00 - 299.99")]
		v250_00___299_99,

		[FiftyOneKey("2500.00 - 2999.99")]
		v2500_00___2999_99,

		[FiftyOneKey("300.00 - 349.99")]
		v300_00___349_99,

		[FiftyOneKey("3000.00 - 3099.99")]
		v3000_00___3099_99,

		[FiftyOneKey("3200.00 - 3299.99")]
		v3200_00___3299_99,

		[FiftyOneKey("3300.00 - 3399.00")]
		v3300_00___3399_00,

		[FiftyOneKey("3400.00 - 3499.99")]
		v3400_00___3499_99,

		[FiftyOneKey("350.00 - 399.99")]
		v350_00___399_99,

		[FiftyOneKey("3700.00 - 3799.99")]
		v3700_00___3799_99,

		[FiftyOneKey("3800.00 - 3899.99")]
		v3800_00___3899_99,

		[FiftyOneKey("3900.00 - 3999.99")]
		v3900_00___3999_99,

		[FiftyOneKey("400.00 - 449.99")]
		v400_00___449_99,

		[FiftyOneKey("450.00 - 499.99")]
		v450_00___499_99,

		[FiftyOneKey("4500.00 ? 4999.99")]
		v4500_00___4999_99,

		[FiftyOneKey("50.00 - 99.99")]
		v50_00___99_99,

		[FiftyOneKey("500.00 - 599.99")]
		v500_00___599_99,

		[FiftyOneKey("5000.00 - 5499.99")]
		v5000_00___5499_99,

		[FiftyOneKey("600.00 - 699.99")]
		v600_00___699_99,

		[FiftyOneKey("6000.00 - 6499.99")]
		v6000_00___6499_99,

		[FiftyOneKey("6800.00 - 6899.99")]
		v6800_00___6899_99,

		[FiftyOneKey("700.00 - 799.99")]
		v700_00___799_99,

		[FiftyOneKey("800.00 - 899.99")]
		v800_00___899_99,

		[FiftyOneKey("900.00 - 999.99")]
		v900_00___999_99,

		// The device manufacturer or vendor of the device does not specify the price at the launch day.
		[FiftyOneKey("Unknown")]
		vunknown,


    }
}
