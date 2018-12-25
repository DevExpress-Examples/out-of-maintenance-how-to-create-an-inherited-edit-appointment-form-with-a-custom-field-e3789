using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SchedulerInheritedAppointmentForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            schedulerControl1.ActiveViewType = SchedulerViewType.Timeline;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.TimelineView.ResourcesPerPage = 3;

            schedulerControl1.InitNewAppointment += new AppointmentEventHandler(schedulerControl1_InitNewAppointment);
        }

        void schedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e) {
            e.Appointment.CustomFields["Field1"] = 20; // this custom field contains a price
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'carsDBDataSet.Cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carsDBDataSet.Cars);
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

            this.carSchedulingTableAdapter.Adapter.RowUpdated +=
                new System.Data.OleDb.OleDbRowUpdatedEventHandler(Adapter_RowUpdated);

            if (schedulerDataStorage1.Appointments.Count > 0)
                schedulerControl1.Start = schedulerDataStorage1.Appointments[0].Start;
        }

        private void AppointmentsModified(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e) {
            this.carSchedulingTableAdapter.Update(this.carsDBDataSet);
            this.carsDBDataSet.AcceptChanges();
        }

        void Adapter_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e) {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert) {
                int id = 0;
                using (OleDbCommand cmd = new OleDbCommand("SELECT @@IDENTITY", this.carSchedulingTableAdapter.Connection)) {
                    id = (int)cmd.ExecuteScalar();
                }
                e.Row["ID"] = id;
            }
        }

        private void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            Appointment apt = e.Appointment;

            // Required to open the recurrence form via context menu.
            bool openRecurrenceForm = apt.IsRecurring && (schedulerDataStorage1 as ISchedulerStorage).Appointments.IsNewAppointment(apt);

            CustomAppointmentForm customForm = new CustomAppointmentForm(schedulerControl1, apt, openRecurrenceForm);

            customForm.LookAndFeel.ParentLookAndFeel = schedulerControl1.LookAndFeel;

            e.DialogResult = customForm.ShowDialog();
            schedulerControl1.Refresh();
            e.Handled = true;
        }
    }
}