﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property firstName() As String
            Get
                Return CType(Me("firstName"),String)
            End Get
            Set
                Me("firstName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property middleName() As String
            Get
                Return CType(Me("middleName"),String)
            End Get
            Set
                Me("middleName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property lastName() As String
            Get
                Return CType(Me("lastName"),String)
            End Get
            Set
                Me("lastName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property sex() As String
            Get
                Return CType(Me("sex"),String)
            End Get
            Set
                Me("sex") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property idCard() As Integer
            Get
                Return CType(Me("idCard"),Integer)
            End Get
            Set
                Me("idCard") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property postalAddress() As Long
            Get
                Return CType(Me("postalAddress"),Long)
            End Get
            Set
                Me("postalAddress") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property postalCode() As Long
            Get
                Return CType(Me("postalCode"),Long)
            End Get
            Set
                Me("postalCode") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property town() As String
            Get
                Return CType(Me("town"),String)
            End Get
            Set
                Me("town") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property country() As String
            Get
                Return CType(Me("country"),String)
            End Get
            Set
                Me("country") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property email() As String
            Get
                Return CType(Me("email"),String)
            End Get
            Set
                Me("email") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property phoneNumber() As Long
            Get
                Return CType(Me("phoneNumber"),Long)
            End Get
            Set
                Me("phoneNumber") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property bankDetails() As String
            Get
                Return CType(Me("bankDetails"),String)
            End Get
            Set
                Me("bankDetails") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property branchName() As String
            Get
                Return CType(Me("branchName"),String)
            End Get
            Set
                Me("branchName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property avatar() As String
            Get
                Return CType(Me("avatar"),String)
            End Get
            Set
                Me("avatar") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property employment() As String
            Get
                Return CType(Me("employment"),String)
            End Get
            Set
                Me("employment") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property companyOfWork() As String
            Get
                Return CType(Me("companyOfWork"),String)
            End Get
            Set
                Me("companyOfWork") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property accountType() As String
            Get
                Return CType(Me("accountType"),String)
            End Get
            Set
                Me("accountType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property generatedAccountNumber() As Long
            Get
                Return CType(Me("generatedAccountNumber"),Long)
            End Get
            Set
                Me("generatedAccountNumber") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property kraPin() As String
            Get
                Return CType(Me("kraPin"), String)
            End Get
            Set(value As String)
                Me("kraPin") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property password() As String
            Get
                Return CType(Me("password"), String)
            End Get
            Set(value As String)
                Me("password") = value
            End Set
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString), _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\KenyaCommercialBank." & _
            "mdb")> _
        Public ReadOnly Property KenyaCommercialBankConnectionString() As String
            Get
                Return CType(Me("KenyaCommercialBankConnectionString"), String)
            End Get
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property moneyInBank() As Long
            Get
                Return CType(Me("moneyInBank"), Long)
            End Get
            Set(value As Long)
                Me("moneyInBank") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property netSalary() As Double
            Get
                Return CType(Me("netSalary"), Double)
            End Get
            Set(value As Double)
                Me("netSalary") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property grossSalary() As Double
            Get
                Return CType(Me("grossSalary"), Double)
            End Get
            Set(value As Double)
                Me("grossSalary") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property allowance() As Double
            Get
                Return CType(Me("allowance"), Double)
            End Get
            Set(value As Double)
                Me("allowance") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property tax() As Double
            Get
                Return CType(Me("tax"), Double)
            End Get
            Set(value As Double)
                Me("tax") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property employeeSalary() As String
            Get
                Return CType(Me("employeeSalary"), String)
            End Get
            Set(value As String)
                Me("employeeSalary") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("0")> _
        Public Property Setting() As Double
            Get
                Return CType(Me("Setting"), Double)
            End Get
            Set(value As Double)
                Me("Setting") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property house() As String
            Get
                Return CType(Me("house"), String)
            End Get
            Set(value As String)
                Me("house") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property travel() As String
            Get
                Return CType(Me("travel"), String)
            End Get
            Set(value As String)
                Me("travel") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property medical() As String
            Get
                Return CType(Me("medical"), String)
            End Get
            Set(value As String)
                Me("medical") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property total() As String
            Get
                Return CType(Me("total"), String)
            End Get
            Set(value As String)
                Me("total") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property nhif() As String
            Get
                Return CType(Me("nhif"), String)
            End Get
            Set(value As String)
                Me("nhif") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property nssf() As String
            Get
                Return CType(Me("nssf"), String)
            End Get
            Set(value As String)
                Me("nssf") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(), _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
         Global.System.Configuration.DefaultSettingValueAttribute("")> _
        Public Property nice() As String
            Get
                Return CType(Me("nice"), String)
            End Get
            Set(value As String)
                Me("nice") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.kcb.My.MySettings
            Get
                Return Global.kcb.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
