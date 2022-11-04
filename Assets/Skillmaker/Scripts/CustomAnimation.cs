using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skillmaker.Animation
{
    public class CustomAnimation : MonoBehaviour
    {

        public AnimationCurve AnimationCurve;
        public float AnimationDuration = 5f;
        public bool Looping = false;
        public bool Preview = false;

        private float _currentTime = 0f;

        private void UpdateTime()
        {

        }

        void Start()
        {

        }

        public void Animate(float time)
        {
            if(time >= AnimationDuration)
            {
                return;
            }
            StartCoroutine(AnimateCO());

        }

        IEnumerator AnimateCO()
        {
            Debug.Log("COroutine iteration. Current Time is :  " + _currentTime);
            while (true)
            {
                _currentTime += Time.deltaTime;
                var xPos = AnimationCurve.Evaluate(_currentTime / AnimationDuration);
                transform.Translate(new Vector3(xPos, 0, 0));
                if (_currentTime / AnimationDuration >= 1f)
                {
                    _currentTime = 0f;
                    yield break;
                }
                yield return new WaitForEndOfFrame();
            }
            

        }


        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Animate(0f);
            }
        }

        private void Play()
        {

        }

        private void Pause()
        {
            
        }

        private void Stop()
        {

        }

        private void Reset()
        {
            
        }
    }
}
