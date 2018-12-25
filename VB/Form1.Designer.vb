Namespace SchedulerInheritedAppointmentForm
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carsDBDataSet_Renamed = New SchedulerInheritedAppointmentForm.CarsDBDataSet()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carSchedulingTableAdapter = New SchedulerInheritedAppointmentForm.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
			Me.carsTableAdapter = New SchedulerInheritedAppointmentForm.CarsDBDataSetTableAdapters.CarsTableAdapter()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(0, 0)
			Me.schedulerControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.OptionsView.ResourceHeaders.Height = 100
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageAlign = DevExpress.XtraScheduler.HeaderImageAlign.Top
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(100, 100)
			Me.schedulerControl1.OptionsView.ResourceHeaders.ImageSizeMode = DevExpress.XtraScheduler.HeaderImageSizeMode.ZoomImage
			Me.schedulerControl1.Size = New System.Drawing.Size(897, 482)
			Me.schedulerControl1.Start = New Date(2008, 10, 24, 0, 0, 0, 0)
			Me.schedulerControl1.DataStorage = Me.schedulerDataStorage1
			Me.schedulerControl1.TabIndex = 0
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.schedulerControl1.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.schedulerControl1_EditAppointmentFormShowing);
			' 
			' schedulerDataStorage1
			' 
			Me.schedulerDataStorage1.Appointments.CustomFieldMappings.Add(New DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Field1", "Price"))
			Me.schedulerDataStorage1.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerDataStorage1.Appointments.Mappings.Description = "Description"
			Me.schedulerDataStorage1.Appointments.Mappings.End = "EndTime"
			Me.schedulerDataStorage1.Appointments.Mappings.Label = "Label"
			Me.schedulerDataStorage1.Appointments.Mappings.Location = "Location"
			Me.schedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerDataStorage1.Appointments.Mappings.ResourceId = "CarId"
			Me.schedulerDataStorage1.Appointments.Mappings.Start = "StartTime"
			Me.schedulerDataStorage1.Appointments.Mappings.Status = "Status"
			Me.schedulerDataStorage1.Appointments.Mappings.Subject = "Subject"
			Me.schedulerDataStorage1.Appointments.Mappings.Type = "EventType"
			Me.schedulerDataStorage1.Resources.DataSource = Me.carsBindingSource
			Me.schedulerDataStorage1.Resources.Mappings.Caption = "Model"
			Me.schedulerDataStorage1.Resources.Mappings.Id = "ID"
			Me.schedulerDataStorage1.Resources.Mappings.Image = "Picture"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.schedulerDataStorage1.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.AppointmentsModified);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.schedulerDataStorage1.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.AppointmentsModified);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.schedulerDataStorage1.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.AppointmentsModified);
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet_Renamed
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet_Renamed.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet_Renamed.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.carsDBDataSet_Renamed
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(897, 482)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "How to create an inherited edit appointment form with a custom field"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
'INSTANT VB NOTE: The variable carsDBDataSet was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private carsDBDataSet_Renamed As CarsDBDataSet
		Private WithEvents schedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As SchedulerInheritedAppointmentForm.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As SchedulerInheritedAppointmentForm.CarsDBDataSetTableAdapters.CarsTableAdapter
	End Class
End Namespace

