using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    /// <summary>
    /// Contains static and constant values used to build the Epi
    /// package from the 51Degrees device data.
    /// </summary>
    internal class Constants
    {
        /// <summary>
        /// Name of the project used to create the visitor group extension.
        /// </summary>
        internal const string PROJECT_NAME = "FiftyOneDegrees";

        /// <summary>
        /// Path to the data file to use to generate the conditions.
        /// </summary>
        internal const string DEFAULT_51DEGREES_PATH = @"\\srv20\data\V3Exports\51Degrees-EnterpriseV3_2.dat";

        /// <summary>
        /// Path the the FiftyOneDegrees project where files 
        /// will be added or modified.
        /// </summary>
        internal const string DEFAULT_PROJECT_FOLDER = "../../../";

        /// <summary>
        /// The path to the language folder used to contain the XML documentation
        /// mapping enums / names to output text.
        /// </summary>
        internal const string LANG_FOLDER = "EmbeddedLangFiles";

        /// <summary>
        /// The folder for the enums.
        /// </summary>
        internal const string ENUMS_FOLDER = "Enums";

        /// <summary>
        /// The folder for the model classes.
        /// </summary>
        internal const string CRITERION_MODELS_FOLDER = "Models";

        /// <summary>
        /// The folder for the criterion classes.
        /// </summary>
        internal const string CRITERION_FOLDER = "Criterion";

        /// <summary>
        /// The folder for the visitor group views.
        /// </summary>
        internal const string VIEWS_FOLDER = "Views/Shared/EditorTemplates";

        /// <summary>
        /// The suffix to add to the property name to indicate value conditions.
        /// </summary>
        internal const string VALUE_CONDITION = "valuecondition";

        /// <summary>
        /// Properties in this list will have unique conditions. Others will appear
        /// as drop down lists.
        /// </summary>
        internal static readonly string[] TopProperties = new String[] {
            "IsMobile",
            "IsTablet",
            "IsSmartphone",
            "DeviceType",
            "LayoutEngine",
            "HasTouchScreen",
            "ScreenInchesDiagonal",
            "ScreenInchesDiagonalRounded",
            "ScreenPixelsWidth",
            "HardwareVendor",
            "BrowserVendor",
            "BrowserVersion",
            "BrowserName",
            "PlatformVendor",
            "PlatformVersion",
            "PlatformName",
            "PriceBand",
            "SupportedBearers",
            "SupportsPhoneCalls"
        };

        /// <summary>
        /// Properties in this list will appear with lookup options where
        /// values are choosen from a list.
        /// </summary>
        internal static readonly string[] LookupProperties = new String[] {
            "DeviceType",
            "LayoutEngine",
            "PriceBand",
            "ScreenInchesDiagonalRounded",
            "SupportedBearers"
        };

        internal const string UpgradeButton = "Upgrade Required";

        /// <summary>
        /// The text to use when linking to 51Degrees for an upgrade. 
        /// </summary>
        internal const string UpgradeMessage = "Enable {1} with enhanced ({0}) 51Degrees device data by replacing the App_Data/51Degrees.dat file.";

        /// <summary>
        /// The URL to use when linking to 51Degrees for an upgrade. 
        /// </summary>
        internal const string UpgradeUrl = "https://51degrees.com/EPi?utm_source=EPi&utm_medium=extension&utm_content=configuration-{0}&utm_campaign=EPi&AffiliateId=X";

        internal static readonly string[] ValueConditionsEnum = new String[] {
            "Is",
            "Is Not"
        };


        internal static readonly string[] ValueConditionsRange = new String[] {
            "Between",
            "Is Not Between"
        };

        internal static readonly string[] ValueConditionsString = new String[] {
            "Contains",
            "Does Not Contain",
            "Does Not Equal",
            "Ends With",
            "Equals",
            "Starts With"
        };

        internal static readonly string[] ValueConditionsBoolean = new String[] {
            "True",
            "False"
        };

        internal static readonly string[] ValueConditionsNumeric = new String[] {
            "Less Than",
            "Less Than Or Equal To",
            "Greater Than",
            "Greater Than Or Equal To",
            "Equal To",
            "Not Equal To"
        };

        internal static readonly string[] ValueConditionsVersion = new String[] {
            "Less Than",
            "Less Than Or Equal To",
            "Greater Than",
            "Greater Than Or Equal To",
            "Equal To",
            "Not Equal To"
        };

        internal static readonly string[] ValueConditionsGroup = new String[] {
            "Less Than",
            "Less Than Or Equal To",
            "Greater Than",
            "Greater Than Or Equal To",
            "Equal To",
            "Not Equal To"
        };

        internal static string NumericRangeValidationMessage = "Value for {0} must be between {1} and {2}";
    }
}
