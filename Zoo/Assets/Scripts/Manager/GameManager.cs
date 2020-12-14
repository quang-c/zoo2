using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{

    public class GameManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] 
        private List<GameObject> spawnedAnimals;
        [SerializeField] 
        private GameObject[] availableAnimals;
        [SerializeField] 
        private GameObject gameCanvas;
        [SerializeField] 
        private Button leavesButton, meatButton, helloButton, trickButton;
        [SerializeField] 
        private InputField userInput;

        private string input;

        void Start()
        {
            Spawn();

            //button events
            meatButton.onClick.AddListener(EatSomeMeat);
            leavesButton.onClick.AddListener(EatSomeLeaves);
            helloButton.onClick.AddListener(SayHi);
            trickButton.onClick.AddListener(DoTricky);
        }

        void Update()
        {
            input = userInput.text;
            if (Input.GetKeyDown(KeyCode.Return))
            {
                CheckName();
                userInput.text = "";
                userInput.ActivateInputField();
                userInput.Select();
            }
        }

        /// <summary>
        /// method to spawn the animals and put them in a list
        /// </summary>
        public void Spawn()
        {
            spawnedAnimals = new List<GameObject>();

            foreach (var animal in availableAnimals)
            {
                GameObject spawnedAnimal = Instantiate(animal);
                spawnedAnimals.Add(spawnedAnimal);
                // transform the clones to the gameCanvas
                spawnedAnimal.transform.SetParent(gameCanvas.transform, false);
            }
        }

        /// <summary>
        /// method to handle animals eating meat
        /// </summary>
        private void EatSomeMeat()
        {
            foreach (var animal in spawnedAnimals)
            {
                // look through the list for carnivores and omnivores
                Carnivore carnivore = animal.GetComponent<Carnivore>();
                Omnivore omnivore = animal.GetComponent<Omnivore>();
                // if the animal(s) exist(s), invoke Eat
                if (carnivore != null) carnivore.Eat(true);
                if (omnivore != null) omnivore.Eat(true);
            }
        }

        /// <summary>
        /// method to handle animals eating leaves
        /// </summary>
        private void EatSomeLeaves()
        {
            foreach (var animal in spawnedAnimals)
            {
                Herbivore herbivore = animal.GetComponent<Herbivore>();
                Omnivore omnivore = animal.GetComponent<Omnivore>();
                if (herbivore != null) herbivore.Eat(false);
                if (omnivore != null)  omnivore.Eat(false);
            }
        }

        /// <summary>
        /// to let all the animals say hello
        /// </summary>
        private void SayHi()
        {
            foreach (var animal in spawnedAnimals)
            {
                Animal animals = animal.GetComponent<Animal>();

                if (animals != null) animals.SayHello();
            }

        }

        /// <summary>
        /// to let certain animals do a trick
        /// </summary>
        private void DoTricky()
        {
            foreach (var trickyAnim in spawnedAnimals)
            {
                Animal trickyAnimal = trickyAnim.GetComponent<Animal>();

                if (trickyAnimal != null) trickyAnimal.PerformTrick();
            }
        }

        /// <summary>
        /// method to check the userinput with the animal names
        /// </summary>
        private void CheckName()
        {
            foreach (var anml in spawnedAnimals)
            {
                Animal animal = anml.GetComponent<Animal>();

                if (input == animal.name) animal.SayHello();
            }
        }
    }
}
