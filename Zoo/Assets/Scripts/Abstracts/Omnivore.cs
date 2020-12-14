using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    abstract class Omnivore : Animal
    {
        public override void Eat(bool vrijMiBo)
        {
            // if bool is true, the animal will eat meat
            if (vrijMiBo) EatMeat();
            else EatLeaves();
        }
        
        //omnivores eat both leaves and meat
        public abstract void EatLeaves();
        public abstract void EatMeat();
    }
}
