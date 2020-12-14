using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Tiger : Carnivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "wally";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "rraaarww";
        }

        public override void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "my meat! nom!";
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
