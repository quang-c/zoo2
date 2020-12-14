using System;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Zebra : Herbivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "marty";
        }

        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "zebra zebra";
        }

        public override void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munchoin leaves zank yee bra";
        }
    }
}
