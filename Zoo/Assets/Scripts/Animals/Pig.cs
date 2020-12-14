using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Pig : Omnivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "dora";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "oink oink";
        }

        public override void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "healthy time";
        }

        public override void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "nomnomnom oink YES MEAT";
        }

        public override void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        IEnumerator DoTrick()
        {
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
