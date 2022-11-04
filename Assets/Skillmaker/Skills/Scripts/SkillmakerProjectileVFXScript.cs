using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skillmaker.VFX
{
    public class SkillmakerProjectileVFXScript : MonoBehaviour
    {
        //[HideInInspector]
        public EffectType _effectType;
        public float Intensity = 0.5f;
        public VFXElement _VFXElement;
        public Material _material;
        public List<VFXElement> _listOfElements;
        private void Start()
        {
            Debug.Log(typeof(Skillmaker.VFX.VFXElement).AssemblyQualifiedName);
        }

        private void OnEnable()
        {
            var rend = gameObject.AddComponent<MeshRenderer>();
            rend.material = _material;
        }

    }

    public enum EffectType
    {
        Projectile,
        Nova
    }
}