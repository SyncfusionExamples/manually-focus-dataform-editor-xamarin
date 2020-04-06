# How to programmatically set focus to editor in Xamarin.Forms DataForm (SfDataForm)

You can set the focus programmatically to the editor in Xamarin.Forms [SfDataForm](https://help.syncfusion.com/xamarin/dataform/getting-started?) by customizing the existing editor.

Refer to the [online user guide documentation](https://help.syncfusion.com/xamarin/sfdataform/editors?) for creating new custom editor in DataForm.

You can refer the following article.

https://www.syncfusion.com/kb/11311/how-to-programmatically-set-focus-to-editor-in-xamarin-forms-dataform-sfdataform

**C#**

Set focus to view on loading in OnInitializeView method using [Focus](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.focus?view=xamarin-forms) method.

``` c#
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
```
**C#**

Set focus to the view automatically at run time by getting the particular editor using [EditorView](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfDataForm.XForms~Syncfusion.XForms.DataForm.DataFormItem~EditorView.html?).

``` c#
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
```
