function eventArgsCreator(event) {
    return {
        type: event.type,
        value: event.detail.value
    };
}

export function afterWebAssemblyStarted(blazor) {

    console.info("Registering custom event handlers");

    blazor.registerCustomEventType('icBlurEvent', {
        browserEventName: 'icBlur',
        createEventArgs: eventArgsCreator
    });

    blazor.registerCustomEventType('icChangeEvent', {
        browserEventName: 'icChange',
        createEventArgs: eventArgsCreator
    });

    blazor.registerCustomEventType('icFocusEvent', {
        browserEventName: 'icFocus',
        createEventArgs: eventArgsCreator
    });

    blazor.registerCustomEventType('icInputEvent', {
        browserEventName: 'icInput',
        createEventArgs: eventArgsCreator
    });
}
