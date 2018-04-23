Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.UI

Namespace SchedulerInheritedAppointmentForm
	Public Class CustomAppointmentFormController
		Inherits AppointmentFormController
		Public Property Price() As Decimal
			Get
				Dim val As Object = EditedAppointmentCopy.CustomFields("Field1")

				If val Is Nothing OrElse val Is DBNull.Value Then
					Return 0
				Else
					Return Convert.ToDecimal(val)
				End If
			End Get
			Set(ByVal value As Decimal)
				EditedAppointmentCopy.CustomFields("Field1") = value
			End Set
		End Property

		Private Property SourcePrice() As Decimal
			Get
				Return CDec(SourceAppointment.CustomFields("Field1"))
			End Get
			Set(ByVal value As Decimal)
				SourceAppointment.CustomFields("Field1") = value
			End Set
		End Property

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
			MyBase.New(control, apt)
		End Sub

		Public Overrides Function IsAppointmentChanged() As Boolean
			If MyBase.IsAppointmentChanged() Then
				Return True
			End If
			Return SourcePrice <> Price
		End Function

		Protected Overrides Sub ApplyCustomFieldsValues()
			SourcePrice = Price
		End Sub
	End Class
End Namespace
