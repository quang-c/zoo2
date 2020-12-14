using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    abstract class Carnivore : Animal
    {
        public override void Eat(bool vrijMiBo)
        {
            EatMeat();
        }

        // carnivores only eat meat
        public abstract void EatMeat();
    }
}
