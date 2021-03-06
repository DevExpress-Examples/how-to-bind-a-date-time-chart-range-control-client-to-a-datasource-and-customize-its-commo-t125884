<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DateTimeChartRangeClient/Form1.cs) (VB: [Form1.vb](./VB/DateTimeChartRangeClient/Form1.vb))
<!-- default file list end -->
#  How to bind a date-time chart range control client to a datasource and customize its common settings


<p>This example demonstrates how to set up a range control with the date-time chart client to display a chart with date-time data in the range control's background. <br /><br />In order to provide data to a chart date-time range control client, you need to access the <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsChartRangeControlClientDataProvidertopic">ChartRangeControlClientDataProvider</a><strong> </strong>object using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsChartRangeControlClientBase_DataProvidertopic">ChartRangeControlClientBase.DataProvider</a> property and assign a data source to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsChartRangeControlClientDataProvider_DataSourcetopic">ChartRangeControlClientDataProvider.DataSource</a> <strong> </strong>property. Then specify the required data fields via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsChartRangeControlClientDataProvider_ArgumentDataMembertopic">ChartRangeControlClientDataProvider.ArgumentDataMember</a>, <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsChartRangeControlClientDataProvider_ValueDataMembertopic">ChartRangeControlClientDataProvider.ValueDataMember</a><strong>,</strong> and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsChartRangeControlClientDataProvider_SeriesDataMembertopic">ChartRangeControlClientDataProvider.SeriesDataMember</a> (optional) properties. <br /><br />In the current example, a date-time chart client is bound to a simple data table containing three columns ("Argument", "Value", and "Series"). <br /><br />In addition, this example shows how to customize chart client common settings (e.g., change the date-time range, customize template view and grid options).</p>

<br/>


