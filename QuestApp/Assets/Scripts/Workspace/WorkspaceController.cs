using System.Collections.Generic;
using UnityEngine;

namespace Orbit.Workspace
{
    /// <summary>
    /// Creates and tracks virtual monitor panels.
    /// Interaction, persistence, and display streaming are intentionally separate follow-up systems.
    /// </summary>
    public sealed class WorkspaceController : MonoBehaviour
    {
        [SerializeField] private Transform workspaceRoot;
        [SerializeField] private VirtualMonitor monitorPrefab;
        [SerializeField] private float defaultDistance = 1.5f;

        private readonly List<VirtualMonitor> monitors = new List<VirtualMonitor>();

        public IReadOnlyList<VirtualMonitor> Monitors => monitors;

        private void Awake()
        {
            if (workspaceRoot == null) workspaceRoot = transform;
        }

        public VirtualMonitor AddMonitor()
        {
            if (monitorPrefab == null)
            {
                Debug.LogError("ORBIT: Assign a VirtualMonitor prefab before adding displays.");
                return null;
            }

            int index = monitors.Count;
            float horizontalOffset = (index - 0.5f) * 1.25f;

            var layout = new MonitorLayout
            {
                displayName = $"Display {index + 1}",
                localPosition = new Vector3(horizontalOffset, 1.5f, defaultDistance),
                localEulerAngles = Vector3.zero
            };

            VirtualMonitor monitor = Instantiate(monitorPrefab, workspaceRoot);
            monitor.ApplyLayout(layout);
            monitors.Add(monitor);
            return monitor;
        }

        public void RemoveMonitor(VirtualMonitor monitor)
        {
            if (monitor == null) return;

            monitors.Remove(monitor);
            Destroy(monitor.gameObject);
        }

        public void ClearWorkspace()
        {
            for (int i = monitors.Count - 1; i >= 0; i--)
            {
                if (monitors[i] != null) Destroy(monitors[i].gameObject);
            }

            monitors.Clear();
        }
    }
}
