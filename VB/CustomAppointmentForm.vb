Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.XtraScheduler

Namespace SchedulerInheritedAppointmentForm
	Public Class CustomAppointmentForm
		Inherits AppointmentForm
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents tbPrice As DevExpress.XtraEditors.TextEdit

		Public Sub New()
			InitializeComponent()

			chkAllDay.Visible = False
		End Sub

		Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
			MyBase.New(control, apt, openRecurrenceForm)
			InitializeComponent()

			chkAllDay.Visible = False

			UpdateForm()
		End Sub

		Protected Overrides Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
			Return New CustomAppointmentFormController(control, apt)
		End Function

		Protected Friend Shadows ReadOnly Property Controller() As CustomAppointmentFormController
			Get
				Return CType(MyBase.Controller, CustomAppointmentFormController)
			End Get
		End Property

		Protected Overrides Sub UpdateForm()
			MyBase.UpdateForm()

			If Me.tbPrice IsNot Nothing Then
				Me.tbPrice.Text = Controller.Price.ToString()
			End If
		End Sub

		Private Sub tbPrice_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbPrice.EditValueChanged
			Dim result As Decimal = 0D

			Decimal.TryParse(Me.tbPrice.Text, result)

			Controller.Price = result
		End Sub

		#Region "Designer-generated code"
		Private Sub InitializeComponent()
			Me.tbPrice = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.progressPanel.SuspendLayout()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tbPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' lblLabel
			' 
			Me.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' chkAllDay
			' 
			' 
			' edtStartDate
			' 
			Me.edtStartDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtEndDate
			' 
			Me.edtEndDate.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtStartTime
			' 
			Me.edtStartTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtEndTime
			' 
			Me.edtEndTime.EditValue = New System.DateTime(2005, 3, 31, 0, 0, 0, 0)
			' 
			' edtLabel
			' 
			' 
			' edtShowTimeAs
			' 
			' 
			' tbSubject
			' 
			' 
			' edtResource
			' 
			' 
			' edtResources
			' 
			' 
			' 
			' 
			Me.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = True
			Me.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.edtResources.ResourcesCheckedListBoxControl.Location = New System.Drawing.Point(0, 0)
			Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
			Me.edtResources.ResourcesCheckedListBoxControl.Size = New System.Drawing.Size(200, 100)
			Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0
			' 
			' chkReminder
			' 
			' 
			' tbDescription
			' 
			Me.tbDescription.Size = New System.Drawing.Size(496, 135)
			' 
			' cbReminder
			' 
			' 
			' tbLocation
			' 
			' 
			' tbProgress
			' 
			Me.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = True
			Me.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			' 
			' lblPercentComplete
			' 
			Me.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' lblPercentCompleteValue
			' 
			Me.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent
			' 
			' tbPrice
			' 
			Me.tbPrice.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.tbPrice.Location = New System.Drawing.Point(96, 317)
			Me.tbPrice.Name = "tbPrice"
			Me.tbPrice.Size = New System.Drawing.Size(120, 20)
			Me.tbPrice.TabIndex = 24
'			Me.tbPrice.EditValueChanged += New System.EventHandler(Me.tbPrice_EditValueChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.labelControl1.Location = New System.Drawing.Point(16, 320)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(27, 13)
			Me.labelControl1.TabIndex = 25
			Me.labelControl1.Text = "&Price:"
			' 
			' CustomAppointmentForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(528, 382)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.tbPrice)
			Me.Name = "CustomAppointmentForm"
			Me.Controls.SetChildIndex(Me.progressPanel, 0)
			Me.Controls.SetChildIndex(Me.tbPrice, 0)
			Me.Controls.SetChildIndex(Me.labelControl1, 0)
			Me.Controls.SetChildIndex(Me.edtShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.edtEndTime, 0)
			Me.Controls.SetChildIndex(Me.edtEndDate, 0)
			Me.Controls.SetChildIndex(Me.btnRecurrence, 0)
			Me.Controls.SetChildIndex(Me.btnDelete, 0)
			Me.Controls.SetChildIndex(Me.btnCancel, 0)
			Me.Controls.SetChildIndex(Me.lblShowTimeAs, 0)
			Me.Controls.SetChildIndex(Me.lblEndTime, 0)
			Me.Controls.SetChildIndex(Me.tbLocation, 0)
			Me.Controls.SetChildIndex(Me.lblSubject, 0)
			Me.Controls.SetChildIndex(Me.lblLocation, 0)
			Me.Controls.SetChildIndex(Me.tbSubject, 0)
			Me.Controls.SetChildIndex(Me.lblStartTime, 0)
			Me.Controls.SetChildIndex(Me.btnOk, 0)
			Me.Controls.SetChildIndex(Me.edtStartDate, 0)
			Me.Controls.SetChildIndex(Me.edtStartTime, 0)
			Me.Controls.SetChildIndex(Me.tbDescription, 0)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			CType(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.progressPanel.ResumeLayout(False)
			Me.progressPanel.PerformLayout()
			CType(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tbPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region ' Designer-generated code
	End Class
End Namespace