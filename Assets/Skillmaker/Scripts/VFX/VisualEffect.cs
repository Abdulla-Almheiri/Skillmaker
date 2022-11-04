using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skillmaker.VFX
{
    //[CreateAssetMenu(fileName ="New visual effect", menuName ="Skillmaker/Visual Effects/Visual Effect")]
    public class VisualEffect : MonoBehaviour
    {
        public Color MainColor;
        public Texture2D MainTexture;

        private Material _material;

        public void Generate()
        {
            if(_material == null)
            {
                _material = GetComponent<MeshRenderer>().material;
            }

            _material.SetTexture("_Texture2D", MainTexture);
        }


        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.T))
            {
                Generate();
            }
        }
    }
}