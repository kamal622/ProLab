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

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Patient
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ProLab.Data.Patient", GetType(Patient).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT Mobile FROM Patients Where Mobile=@Mobile.
        '''</summary>
        Friend Shared ReadOnly Property CheckMobile() As String
            Get
                Return ResourceManager.GetString("CheckMobile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to DELETE FROM Patients WHERE Id=@Id.
        '''</summary>
        Friend Shared ReadOnly Property DeletePatientById() As String
            Get
                Return ResourceManager.GetString("DeletePatientById", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT * FROM City.
        '''</summary>
        Friend Shared ReadOnly Property GetAllCityById() As String
            Get
                Return ResourceManager.GetString("GetAllCityById", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT * FROM Patients.
        '''</summary>
        Friend Shared ReadOnly Property GetAllPatientDetails() As String
            Get
                Return ResourceManager.GetString("GetAllPatientDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT * FROM Patients WHERE Id=@Id.
        '''</summary>
        Friend Shared ReadOnly Property GetPatientById() As String
            Get
                Return ResourceManager.GetString("GetPatientById", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT * FROM Patients WHERE Mobile=@Mobile.
        '''</summary>
        Friend Shared ReadOnly Property GetPatientByMobile() As String
            Get
                Return ResourceManager.GetString("GetPatientByMobile", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT * FROM Patients WHERE FirstName=@FirstName.
        '''</summary>
        Friend Shared ReadOnly Property GetPatientByName() As String
            Get
                Return ResourceManager.GetString("GetPatientByName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to INSERT INTO Patients(FirstName,Lastname,Mobile,LandLine,Email,Address1,Address2,CityId,Age,Gender,DOB,Occupation,Zipcode,CountryId,StateId,CreateDate,CreateBy)  VALUES(@FirstName,@Lastname,@Mobile,@LandLine,@Email,@Address1,@Address2,@CityId,@Age,@Gender,@DOB,@Occupation,@Zipcode,@CountryId,@StateId,@CreateDate,@CreateBy).
        '''</summary>
        Friend Shared ReadOnly Property SavePatientDetails() As String
            Get
                Return ResourceManager.GetString("SavePatientDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to UPDATE Patients SET FirstName=@FirstName,Lastname=@Lastname,Mobile=@Mobile,LandLine=@LandLine,Email=@Email,Address1=@Address1,Address2=@Address2,CityId=@CityId,Age=@Age,Gender=@Gender,DOB=@DOB,Occupation=@Occupation,Zipcode=@Zipcode,CountryId=@CountryId,StateId=@StateId , UpdateDate = @UpdateDate, UpdateBy = @UpdateBy WHERE Id=@Id.
        '''</summary>
        Friend Shared ReadOnly Property UpdatePatientDetails() As String
            Get
                Return ResourceManager.GetString("UpdatePatientDetails", resourceCulture)
            End Get
        End Property
    End Class
End Namespace