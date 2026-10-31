using UnityEngine;

namespace Orbit.Workspace
{
    /// <summary>
    /// Data and transform behaviour for one virtual display panel.
    /// Rendering a remote/local desktop texture will be added by a later display provider.
    /// </summary>
    public sealed class VirtualMonitor : MonoBehaviour
    {
        [SerializeField] private string displayName = "Display";
        [SerializeField] private Vector2 sizeMeters = new Vector2(1.2f, 0.7f);

        public string DisplayName => displayName;
        public Vector2 SizeMeters => sizeMeters;

        public void ApplyLayout(MonitorLayout layout)
        {
            if (layout == null) return;

            displayName = layout.displayName;
            sizeMeters = layout.sizeMeters;
            transform.localPosition = layout.localPosition;
            transform.localEulerAngles = layout.localEulerAngles;
            transform.localScale = Vector3.one * layout.scale;
            name = $"ORBIT Monitor - {displayName}";
        }
    }
}
