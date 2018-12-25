Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler

Namespace SchedulerInheritedAppointmentForm
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()

			schedulerControl1.ActiveViewType = SchedulerViewType.Timeline
			schedulerControl1.GroupType = SchedulerGroupType.Resource
			schedulerControl1.TimelineView.ResourcesPerPage = 3

			AddHandler schedulerControl1.InitNewAppointment, AddressOf schedulerControl1_InitNewAppointment
		End Sub

		Private Sub schedulerControl1_InitNewAppointment(ByVal sender As Object, ByVal e As AppointmentEventArgs)
			e.Appointment.CustomFields("Field1") = 20 ' this custom field contains a price
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
			Me.carsTableAdapter.Fill(Me.carsDBDataSet_Renamed.Cars)
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet_Renamed.CarScheduling)

			AddHandler carSchedulingTableAdapter.Adapter.RowUpdated, AddressOf Adapter_RowUpdated

			If schedulerDataStorage1.Appointments.Count > 0 Then
				schedulerControl1.Start = schedulerDataStorage1.Appointments(0).Start
			End If
		End Sub

		Private Sub AppointmentsModified(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.PersistentObjectsEventArgs) Handles schedulerDataStorage1.AppointmentsChanged, schedulerDataStorage1.AppointmentsInserted, schedulerDataStorage1.AppointmentsDeleted
			Me.carSchedulingTableAdapter.Update(Me.carsDBDataSet_Renamed)
			Me.carsDBDataSet_Renamed.AcceptChanges()
		End Sub

		Private Sub Adapter_RowUpdated(ByVal sender As Object, ByVal e As System.Data.OleDb.OleDbRowUpdatedEventArgs)
			If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
				Dim id As Integer = 0
				Using cmd As New OleDbCommand("SELECT @@IDENTITY", Me.carSchedulingTableAdapter.Connection)
					id = DirectCast(cmd.ExecuteScalar(), Integer)
				End Using
				e.Row("ID") = id
			End If
		End Sub

		Private Sub schedulerControl1_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl1.EditAppointmentFormShowing
			Dim apt As Appointment = e.Appointment

			' Required to open the recurrence form via context menu.
			Dim openRecurrenceForm As Boolean = apt.IsRecurring AndAlso (TryCast(schedulerDataStorage1, ISchedulerStorage)).Appointments.IsNewAppointment(apt)

			Dim customForm As New CustomAppointmentForm(schedulerControl1, apt, openRecurrenceForm)

			customForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel

			e.DialogResult = customForm.ShowDialog()
			schedulerControl1.Refresh()
			e.Handled = True
		End Sub
	End Class
End Namespace