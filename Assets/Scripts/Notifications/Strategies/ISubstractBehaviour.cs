using UnityEngine;
using StressGame.PlayerControlling;


namespace StressGame.Notifications
{
    public class ISubstractBehavoiur : IStressBehaviour
    {
        public void UpdateStressLvl(float value)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().UpdateStress(-value);

        }
    }
}

