using UnityEngine;

namespace ALExporter
{
    public interface IStateToggleButton
    {
        GUIContent Content { get; }
        void OnClick();
    }
}