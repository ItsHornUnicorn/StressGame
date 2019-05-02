using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StressGame.PlayerControlling
{
    public class Player : MonoBehaviour
    {
        private float stressPercentage = 0;

        public void UpdateStress(float stressToPlus)
        {
            stressPercentage += stressToPlus;
            print(stressPercentage);
        }

    }
}
