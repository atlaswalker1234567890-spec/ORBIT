using System;
using UnityEngine;

namespace Orbit.Workspace
{
    [Serializable]
    public sealed class MonitorLayout
    {
        public string displayName = "Display";
        public Vector2 sizeMeters = new Vector2(1.2f, 0.7f);
        public Vector3 localPosition = new Vector3(0f, 1.5f, 1.5f);
        public Vector3 localEulerAngles = Vector3.zero;
        [Range(0.5f, 3f)] public float scale = 1f;
    }
}
