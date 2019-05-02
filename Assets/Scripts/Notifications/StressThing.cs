using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StressGame.PlayerControlling;


namespace StressGame.Notifications
{
    public abstract class StressThing : MonoBehaviour
    {
        
        [SerializeField] private float amountOfStress;
        
        public IStressBehaviour stressBehaviour {get; set;}

        public void UpdateStressLvl()
        {
            stressBehaviour.UpdateStressLvl(amountOfStress);
        }
    }

}