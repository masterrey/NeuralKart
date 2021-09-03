using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KartGame.KartSystems
{
    public class IAInput : BaseInput
    {
       
        public Neurons accel, brake, right, left;
        bool accelb, brakeb;
        public override InputData GenerateInput()
        {
            if (accel.state > 0)
            {
                accelb = true;
            }
            else
            {
                accelb = false;
            }

            if (brake.state > 0)
            {
                brakeb = true;
            }
            else
            {
                brakeb = false;
            }
           
            return new InputData
            {
               
                Accelerate = accelb,
                Brake = brakeb,
                TurnInput = right.state + (-left.state)
        };
        }
    }
}
