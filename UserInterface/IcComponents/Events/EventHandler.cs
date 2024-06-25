using Microsoft.AspNetCore.Components;

namespace UserInterface.IcComponents.Events;

/// <summary>
/// These must map to the registered event handlers in UserInterface.lib.module.js
/// For more information see <see href="https://learn.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-8.0#custom-event-arguments"/>
/// </summary>
[EventHandler("onicBlurEvent", typeof(IcValueEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("onicChangeEvent", typeof(IcValueEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("onicFocusEvent", typeof(IcValueEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
[EventHandler("onicInputEvent", typeof(IcValueEventArgs), enableStopPropagation: true, enablePreventDefault: true)]
public class EventHandler { }

public class IcValueEventArgs : EventArgs
{
    public string? Type { get; set; }
    public string? Value { get; set; }
}
