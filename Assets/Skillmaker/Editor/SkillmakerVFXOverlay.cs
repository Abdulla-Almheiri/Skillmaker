using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;
using UnityEditor.Overlays;
using UnityEngine.UIElements;
using UnityEditor;
using Skillmaker;

namespace Skillmaker.Tools
{
    [Overlay(typeof(SceneView), "Skillmaker", true)]
    public class SkillmakerVFXOverlay : Overlay, ITransientOverlay
    {
        public bool visible
        {
            get
            {
                return Selection.activeGameObject != null && Selection.activeGameObject.GetComponent<Skillmaker.VFX.SkillmakerProjectileVFXScript>() != null;
            }
        }
        
        public override VisualElement CreatePanelContent()
        {
            var root = new VisualElement();
            var titleLabel = new Label(text: "Skillmaker");
            //root.Add(titleLabel);
            var sliderElement = new Slider("Intensity", end: 100f, start: 0f);

            root.Add(sliderElement);

            root.style.width = new StyleLength(new Length(300f, LengthUnit.Pixel));
            sliderElement.style.flexGrow = 1;

            sliderElement.RegisterValueChangedCallback(evt =>
            {
                Selection.activeGameObject.GetComponent<Skillmaker.VFX.SkillmakerProjectileVFXScript>().Intensity = evt.newValue;
            });

            return root;
        }
    }
}