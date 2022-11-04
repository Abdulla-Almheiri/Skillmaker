using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Skillmaker.VFX
{
    [CustomPropertyDrawer(typeof(VFXElement))]
    public class VFXElementEditor : PropertyDrawer
    {
        public VisualTreeAsset _UIDocument;
        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            _UIDocument = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Skillmaker/UI/VFXElementEditorUI.uxml");
            var window = _UIDocument.CloneTree();
            return window;
        }
    }
}