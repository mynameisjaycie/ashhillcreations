using Microsoft.AspNetCore.Components;

namespace AshHillCreations.UI.Components;

public abstract class AshHillCreationsComponentBase : ComponentBase
{
    [Inject] protected NavigationManager NavigationManager { get; private set; } = null!;
}