using FiftyOne.Foundation.Mobile.Detection.Factories;
using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.IO;
using System.Xml;
using System.Linq;

namespace FiftyOneDegreesVisitorGroupGenerator
{
  class Program
  {
    /// <summary>
    /// Uses the first arguement as the 51Degrees data file to generate 
    /// the Epi visitor group criteris from the meta data. If not provided the 
    /// default data file path is used.
    /// Uses the second arguement for the output project location. If not
    /// provided the default package file path is used.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // Path to the 51Degrees device data file used to build the package.
        // This is the first parameter of the command.
        var dataFile = args.Length > 0 && File.Exists(args[0]) ?
            args[0] : Constants.DEFAULT_51DEGREES_PATH;

        // Get the path the the Visitor Group Criteria folder.
        var projectFolder = args.Length > 1 && Directory.Exists(args[1]) ?
            args[1] : Constants.DEFAULT_PROJECT_FOLDER;

        // Open the data set to get the data from.
        var dataSet = StreamFactory.Create(dataFile);

        // Create an XML stream to be used to output the language resource
        // information to.
        var lang = Lang.CreateXml(Path.Combine(
            projectFolder, 
            Constants.LANG_FOLDER, 
            Constants.PROJECT_NAME + "_EN.xml"));

        // Create an XML stream to be used to output the language resource
        // information to.
        var upgrade = Upgrade.CreateXml(Path.Combine(
            projectFolder,
            Constants.LANG_FOLDER,
            Constants.PROJECT_NAME + "Upgrade_EN.xml"));

        // Loop through the lookup properties.
        foreach (var property in Constants.LookupProperties.Select(i =>
            dataSet.Properties[i]).Where(i => i != null))
        {
            Lang.Write(lang, property);
            Enum.Write(
                Path.Combine(projectFolder, Constants.ENUMS_FOLDER), 
                property);
            CriterionModel.Write(
                Path.Combine(projectFolder, Constants.CRITERION_MODELS_FOLDER),
                property);
        }

        // Loop through the normal properties.
        foreach (var property in Constants.TopProperties.Select(i =>
            dataSet.Properties[i]).Where(i => i != null))
        {
            GenerateProperty(projectFolder, upgrade, property);
        }

        // Loop through the numeric properties.
        foreach (var property in Constants.TopProperties.Select(i =>
            dataSet.Properties[i]).Where(i => i 
                != null && 
                (i.ValueType == typeof(double) || i.ValueType == typeof(int))))
        {
            GenerateProperty(projectFolder, upgrade, property, "Range");
        }

        // Close the language XML file.
        Lang.Close(lang);
        Upgrade.Close(upgrade);
    }

        private static void GenerateProperty(string projectFolder, XmlWriter upgrade, Property property, string suffix = "")
        {
            Criterion.Write(
                Path.Combine(projectFolder, Constants.CRITERION_FOLDER),
                property,
                suffix);
            View.Write(
                Path.Combine(projectFolder, Constants.VIEWS_FOLDER),
                property,
                suffix);
            CriterionModel.Write(
                Path.Combine(projectFolder, Constants.CRITERION_MODELS_FOLDER),
                property,
                suffix);
            Upgrade.Write(upgrade, property, suffix);
        }
    }
}
