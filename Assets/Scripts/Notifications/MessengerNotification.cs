using UnityEngine;

namespace StressGame.Notifications
{
    public class MessengerNotification : StressThing
    {
    
        private void Awake() 
        {
           stressBehaviour = new IPlusStressBehaviour(); 
        }

        private void Start() 
        {
            UpdateStressLvl();    
        }

                
    }  
}
