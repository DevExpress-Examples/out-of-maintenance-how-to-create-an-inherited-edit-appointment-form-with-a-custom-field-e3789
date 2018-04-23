# How to create an inherited edit appointment form with a custom field


<p>This example illustrates how to implement an inherited appointment form. This approach is much simpler that the one illustrated in the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument2288"><u>How to: Create a Custom EditAppointment Form with Custom Fields</u></a> help article because it allows you to reuse the built-in <strong>DevExpress.XtraScheduler.UI.AppointmentForm</strong> functionality instead of creating a similar form from scratch. At the same time, it does not mean that you cannot disable standard features of an inherited form. For instance, "All Day" check box in this example is disabled.</p><p>The most interesting part of this example is the custom field editing functionality. It is implemented in the following manner:</p><p>1) The corresponding editor is added on the form. This is the <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsTextEdittopic"><u>TextEdit</u></a> with the tbPrice name.<br />
2) A custom AppointmentFormController class with a custom field logic is implemented. Its instance is created in the overridden <strong>AppointmentForm.CreateController()</strong> method. Note that in the aforementioned help article it is created directly in the form's constructor. <br />
3) When the editor's value is changed, we need to pass it to the controller. It is done in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsBaseEdit_EditValueChangedtopic"><u>BaseEdit.EditValueChanged Event</u></a> handler of the tbPrice.<br />
4) To pass data in the reverse direction (i.e. from the controller to the editor), we override the <strong>AppointmentForm.UpdateForm()</strong> method.</p>

<br/>


