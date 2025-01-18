namespace Content.Server._NF.Atmos.Components;

[RegisterComponent]
public sealed partial class DockablePipeComponent : Component
{
    /// <summary>
    /// The name of the node that is available to dock.
    /// </summary>
    [DataField]
    public string DockNodeName;

    /// <summary>
    /// The name of the internal node
    /// </summary>
    [DataField]
    public string InternalNodeName;
}
