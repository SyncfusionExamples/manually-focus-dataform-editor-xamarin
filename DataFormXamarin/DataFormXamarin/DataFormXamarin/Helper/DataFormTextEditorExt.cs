using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DataFormXamarin
{
    public class DataFormTextEditorExt : DataFormTextEditor
    {
        public DataFormTextEditorExt(SfDataForm dataForm) : base(dataForm)
        {
        }
        protected override void OnInitializeView(DataFormItem dataFormItem, Entry view)
        {
            base.OnInitializeView(dataFormItem, view);
            if (dataFormItem.Name == "Name")
            {
                view.Focus();
            }
        }
    }
}
