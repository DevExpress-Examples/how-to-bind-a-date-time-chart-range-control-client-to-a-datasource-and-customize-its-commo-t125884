﻿// Developer Express Code Central Example:
// How to bind a date-time chart range control client to a datasource and customize its common settings
// 
// This example demonstrates how to set up a range control with the date-time chart
// client to display a chart with date-time data in the range control's background.
// In order to provide data to a chart date-time range control client, you need to
// access the ChartRangeControlClientDataProvider object using the
// ChartRangeControlClientBase.DataProvider property and assign a data source to
// the ChartRangeControlClientDataProvider.DataSource property. Then specify the
// required data fields via the
// ChartRangeControlClientDataProvider.ArgumentDataMember,
// ChartRangeControlClientDataProvider.ValueDataMember, and
// ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
// the current example, a date-time chart client is bound to a simple data table
// containing three columns ("Argument", "Value", and "Series"). In addition, this
// example shows how to customize chart client common settings (e.g., change the
// date-time range, customize template view and grid options).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T125884

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DateTimeChartRangeClient.Properties {


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if ((resourceMan == null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DateTimeChartRangeClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
    }
}
