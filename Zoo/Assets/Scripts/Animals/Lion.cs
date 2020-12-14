using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Lion : Carnivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "henk";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "roooaoaaaaar";
        }

        public override void EatMeat()
        {
            balloon.SetActive(true);
            text.text = "nomnomnom thx mate I love the meat";
        }
    }
}
