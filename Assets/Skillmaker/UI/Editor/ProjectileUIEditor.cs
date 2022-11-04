using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Skillmaker.VFX;
using UnityEngine.UIElements;
using UnityEditor.UIElements;

[CustomEditor(typeof(SkillmakerProjectileVFXScript))]
public class ProjectileUIEditor : Editor
{
    [HideInInspector]
    public VisualTreeAsset _UIDocument;
    public override VisualElement CreateInspectorGUI()
    {
        var window = _UIDocument.CloneTree();
        window.Q<ObjectField>().objectType = typeof(Skillmaker.VFX.VFXElement);
        return window;
    }

}
