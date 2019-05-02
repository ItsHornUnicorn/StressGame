using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using StressGame.Notifications;

namespace StressGame.Controllers
{
    public class StressThingsController : MonoBehaviour
    {
        [SerializeField] private List<StressThing> stressThings;
        private float timeToStressThing = 10f;

        private void Awake() 
        {
           print(stressThings.Count);
        }

        private void Update() 
        {
            timeToStressThing -= Time.deltaTime;
            if (timeToStressThing <= 0)
            {
                Instantiate(stressThings[Random.Range(0, stressThings.Count)]);
                timeToStressThing = Random.Range(0f, 20f);
            }    
        }

    }
}

