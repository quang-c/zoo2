using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Kangaroo : Herbivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "didi";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "Me is kangaroooo!";
        }

        public override void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munch nom I love leaves";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, i, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}