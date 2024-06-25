using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System.Linq.Expressions;
using UserInterface.IcComponents.Events;

namespace UserInterface.IcComponents.IcTextField;

public class IcTextFieldBuildRenderTree : ComponentBase
{
    [Parameter, EditorRequired]
    public virtual string? Value { get; set; }

    [Parameter]
    public virtual EventCallback<string?> ValueChanged { get; set; }

    [Parameter]
    public virtual Expression<Func<string?>>? ValueExpression { get; set; }

    private string? CurrentValue
    {
        get => Value;
        set
        {
            var hasChanged = !EqualityComparer<string>.Default.Equals(value, Value);
            if (hasChanged)
            {
                Value = value;
                _ = ValueChanged.InvokeAsync(Value);
            }
        }
    }

    protected override void BuildRenderTree(RenderTreeBuilder __builder)
    {
        __builder.OpenElement(0, "ic-text-field");
        __builder.AddMultipleAttributes(1,
            [
                new("label", "What is your favourit coffee?"),
                new("placeholder", "please enter..."),
                new("helper-text", "such as Arabic, Robusta or Liberica")
            ]);
        __builder.AddAttribute(2, "value", BindConverter.FormatValue(CurrentValue));
        __builder.AddAttribute(3, "onicChangeEvent", EventCallback.Factory.Create<IcValueEventArgs>(
            this,
            e =>
            {
                CurrentValue = e.Value;
            }));
        __builder.AddAttribute(4, "onicBlurEvent", EventCallback.Factory.Create<IcValueEventArgs>(
            this,
            e =>
            {
                var temp = e;
                _ = e;
            }));
        __builder.AddAttribute(5, "onicInputEvent", EventCallback.Factory.Create<IcValueEventArgs>(
            this,
            e =>
            {
                var temp = e;
                _ = e;
            }));
        __builder.AddAttribute(6, "onicFocusEvent", EventCallback.Factory.Create<IcValueEventArgs>(
            this,
            e =>
            {
                var temp = e;
                _ = e;
            }));
        __builder.SetUpdatesAttributeName("value");
        __builder.CloseElement();
    }
}
