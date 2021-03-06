﻿' Developer Express Code Central Example:
' How to bind a date-time chart range control client to a datasource and customize its common settings
' 
' This example demonstrates how to set up a range control with the date-time chart
' client to display a chart with date-time data in the range control's background.
' In order to provide data to a chart date-time range control client, you need to
' access the ChartRangeControlClientDataProvider object using the
' ChartRangeControlClientBase.DataProvider property and assign a data source to
' the ChartRangeControlClientDataProvider.DataSource property. Then specify the
' required data fields via the
' ChartRangeControlClientDataProvider.ArgumentDataMember,
' ChartRangeControlClientDataProvider.ValueDataMember, and
' ChartRangeControlClientDataProvider.SeriesDataMember (optional) properties. In
' the current example, a date-time chart client is bound to a simple data table
' containing three columns ("Argument", "Value", and "Series"). In addition, this
' example shows how to customize chart client common settings (e.g., change the
' date-time range, customize template view and grid options).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T125884

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")> _
    Friend NotInheritable Partial Class Settings
        Inherits System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As Settings = (CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

        Public Shared ReadOnly Property [Default]() As Settings
            Get
                Return defaultInstance
            End Get
        End Property
    End Class
End Namespace
