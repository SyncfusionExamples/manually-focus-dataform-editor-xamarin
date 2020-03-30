using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        Button setFocus;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.RegisterEditor("Text", new DataFormTextEditorExt(dataForm));
            setFocus = bindable.FindByName<Button>("button");
            setFocus.Clicked += OnSetFocus;
        }
        private void OnSetFocus(object sender, EventArgs e)
        {
            var dataFormItem = dataForm.ItemManager.DataFormItems["Name"];
            if (dataFormItem != null)
            {
                if (dataFormItem.TextInputLayout != null)
                    dataFormItem.TextInputLayout?.InputView?.Focus();
                else
                    dataFormItem.EditorView.Focus();
            }
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            setFocus.Clicked -= OnSetFocus;
        }
    }
}
