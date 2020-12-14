using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    abstract class Herbivore : Animal
    {
        public override void Eat(bool vrijMibo)
        {
            EatLeaves();
        }

        // herbivores only eat leaves
        public abstract void EatLeaves();
    }
}
