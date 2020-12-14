using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    abstract class Animal : MonoBehaviour
    {
        //each animal has a name
        public string name { get; set; }
        // each animal says hello
        public abstract void SayHello();
        // each animal eats
        public abstract void Eat(bool vrijMiBo);
        // some animals can perform a trick
        public virtual void PerformTrick()
        {
            Debug.Log("Im performing a trick...");
        }
    }
}
