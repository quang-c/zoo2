using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Hippo : Herbivore
    {
        [SerializeField]
        private GameObject balloon;
        [SerializeField]
        private Text text;

        private void Start()
        {
            name = "elsa";
        }
        public override void SayHello()
        {
            balloon.SetActive(true);
            text.text = "splash";
        }

        public override void EatLeaves()
        {
            balloon.SetActive(true);
            text.text = "munch munch leaves nom";
        }
    }
    
}
