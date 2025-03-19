using System.ComponentModel.DataAnnotations;

namespace AlloyDemo;

public class Globals
{
    public const string LoginPath = "/util/login";

    /// <summary>
    /// Group names for content types and properties
    /// </summary>
    [GroupDefinitions]
    public static class GroupNames
    {
        [Display(Name = "Default", Order = 10)]
        public const string Default = "Default";

        [Display(Name = SystemTabNames.Content, Order = 20)]
        public const string Content = SystemTabNames.Content;

        [Display(Name = "Contact", Order = 30)]
        public const string Contact = "Contact";

        [Display(Name = "Metadata", Order = 40)]
        public const string MetaData = "Metadata";

        [Display(Name = "News", Order = 50)]
        public const string News = "News";

        [Display(Name = "Products", Order = 60)]
        public const string Products = "Products";

        [Display(Name = SystemTabNames.Settings, Order = 70)]
        public const string Settings = SystemTabNames.Settings;

        [Display(Name = "SiteSettings", Order = 80)]
        public const string SiteSettings = "SiteSettings";

        [Display(Name = "Specialized", Order = 90)]
        public const string Specialized = "Specialized";
    }

    /// <summary>
    /// Tags to use for the main widths used in the Bootstrap HTML framework
    /// </summary>
    public static class ContentAreaTags
    {
        public const string FullWidth = "w-full";
        public const string WideWidth = "w-11/12";
        public const string HalfWidth = "w-1/2 max-w-[50%]";
        public const string NarrowWidth = "w-1/3 max-w-sm";
        public const string NoRenderer = "hidden";
    }

    /// <summary>
    /// Names used for UIHint attributes to map specific rendering controls to page properties
    /// </summary>
    public static class SiteUIHints
    {
        public const string Contact = "contact";
        public const string Strings = "StringList";
        public const string StringsCollection = "StringsCollection";
    }

    /// <summary>
    /// Virtual path to folder with static graphics, such as "/gfx/"
    /// </summary>
    public const string StaticGraphicsFolderPath = "/gfx/";
}
