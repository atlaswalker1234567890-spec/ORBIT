using UnityEngine;

namespace Orbit.Core
{
    /// <summary>
    /// Minimal scene entry point for ORBIT.
    /// Keep startup wiring here; feature systems should remain independently testable.
    /// </summary>
    public sealed class OrbitAppBootstrap : MonoBehaviour
    {
        [SerializeField] private Workspace.WorkspaceController workspace;

        private void Awake()
        {
            if (workspace == null)
            {
                workspace = FindFirstObjectByType<Workspace.WorkspaceController>();
            }

            if (workspace == null)
            {
                Debug.LogWarning("ORBIT: No WorkspaceController found in the active scene.");
            }
        }
    }
}
