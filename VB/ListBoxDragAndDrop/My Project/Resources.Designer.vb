' Developer Express Code Central Example:
' How to do drag and drop items from one ListBoxEdit to another
' 
' This example shows how to implement the drag-and-drop functionality for
' ListBoxEdit.
' 
' First of all, you need to set the AllowDrop
' (http://documentation.devexpress.dev/#WPF/DevExpressXpfCoreDXFrameworkContentElement_AllowDroptopic)
' property to true, in order to let your editor to accept dropping. Next, you'll
' need implement four event handlers for the editor to manage the drag-and-drop
' process:
' 
' 1. MouseLeftButtonDown event handler. Within this handler, it is
' necessary to find out if the click occurred on a certain item. If so, the
' isDragStarted flag is set to True, to allow all the following processing.
' 
' 2.
' PreviewMouseMove event handler. If the isDragStarted flag is set to True, it
' then defines a dragged item and the dragging source object. Then, the
' DragDrop.DoDragDrop() method that initiates a drag-and-drop operation is
' invoked.
' 
' 3. DragOver event handler. Defines the behavior of a drag-and-drop
' operation: if the event's source object can accept a dragged object, the
' e.Effects property is set to the appropriate DragDropEffect value. Otherwise, it
' is set to the DragDropEffects.None value.
' 
' 4. Drop event handler. Handles
' accepting the dragged item by dragging the destination object. Note, that it is
' necessary to create a clone of the copying item to avoid collisions. Do not add
' a dragged item to the items collection itself, until you are sure that this is
' appropriate for your task.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3122

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.225
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Namespace My


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Friend Class Resources

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If (resourceMan Is Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property
	End Class
End Namespace