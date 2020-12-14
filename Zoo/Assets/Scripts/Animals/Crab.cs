using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Crab : Carnivore
    {
        [SerializeField] 
        private GameObject balloon;
        [SerializeField] 
        private Text text;

        private void Start()
        {
            name = "jon";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "sorry I'm busy raving";
        }

        public override void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "c r u n c h MEAT ";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, i, i);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}

