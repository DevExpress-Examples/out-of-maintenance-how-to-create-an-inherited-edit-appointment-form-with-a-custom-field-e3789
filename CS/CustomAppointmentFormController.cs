using System;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace SchedulerInheritedAppointmentForm {
    public class CustomAppointmentFormController : AppointmentFormController {
        public decimal Price {
            get {
                object val = EditedAppointmentCopy.CustomFields["Field1"];

                if (val == null || val == DBNull.Value)
                    return 0;
                else
                    return Convert.ToDecimal(val);
            }
            set {
                EditedAppointmentCopy.CustomFields["Field1"] = value;
            }
        }

        private decimal SourcePrice {
            get { return (decimal)SourceAppointment.CustomFields["Field1"]; }
            set { SourceAppointment.CustomFields["Field1"] = value; }
        }

        public CustomAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt) {
        }

        public override bool IsAppointmentChanged() {
            if (base.IsAppointmentChanged())
                return true;
            return SourcePrice != Price;
        }

        protected override void ApplyCustomFieldsValues() {
            SourcePrice = Price;
        }
    }
}
