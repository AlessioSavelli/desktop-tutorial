﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Il codice è stato generato da uno strumento.
'     Versione runtime:4.0.30319.42000
'
'     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
'     il codice viene rigenerato.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
    'tramite uno strumento quale ResGen o Visual Studio.
    'Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
    'con l'opzione /str oppure ricompilare il progetto VS.
    '''<summary>
    '''  Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("AllarminoIDE.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
        '''  ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property add() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("add", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property balance() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("balance", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property bearSSL() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bearSSL", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property carica() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("carica", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property carica1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("carica1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property carica3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("carica3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property carica4() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("carica4", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property confAvanzato() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("confAvanzato", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property confBasic() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("confBasic", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property fwupdate() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("fwupdate", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property IDEPortable() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("IDEPortable", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a [Assembly Info]
        '''--------------------
        '''Versioni FW. di allarmino disponibili :
        '''	-1.0V
        '''	-1.1V
        '''Compatibilita&apos; Hardware solo con ESP32 DevKit
        '''
        '''[GitHubLink]https://github.com/AlessioSavelli/Allarmino.
        '''</summary>
        Friend ReadOnly Property info() As String
            Get
                Return ResourceManager.GetString("info", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property information() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("information", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una stringa localizzata simile a Licenza MIT
        '''Copyright (c) 2022 Alessio Savelli FuturaGroup
        '''
        '''Con la presente si concede, a chiunque ottenga una copia di questo software e dei file di documentazione associati (il &quot;Software&quot;), l&apos;autorizzazione a usare gratuitamente il Software senza alcuna limitazione, compresi i diritti di usare, copiare, modificare, unire, pubblicare, distribuire, cedere in sottolicenza e/o vendere copie del Software, nonché di permettere ai soggetti cui il Software è fornito di fare altrettanto, alle seguenti condizion [stringa troncata]&quot;;.
        '''</summary>
        Friend ReadOnly Property LICENZA() As String
            Get
                Return ResourceManager.GetString("LICENZA", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Loading() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Loading", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property logoinfo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("logoinfo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property openfolder() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("openfolder", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property refresh() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("refresh", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Byte[].
        '''</summary>
        Friend ReadOnly Property Resource() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Resource", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property scroll_down() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("scroll_down", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property settingsCompilatore() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("settingsCompilatore", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property settingsCompilatore1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("settingsCompilatore1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property SMTP_LIST() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("SMTP_LIST", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property telegram() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("telegram", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property test_email2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("test_email2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property test_emaill() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("test_emaill", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Cerca una risorsa localizzata di tipo System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property trust_Tls() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("trust_Tls", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
