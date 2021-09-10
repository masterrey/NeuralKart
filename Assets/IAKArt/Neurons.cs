using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neurons : MonoBehaviour
{
    //public Neurons[] inputNeurons;
    public Neurons[] outputNeurons;
    public float state;
    public float[] weight;
    public float threshold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < outputNeurons.Length; i++)
        {

                outputNeurons[i].state = 0;

        }
        for (int i=0;i<outputNeurons.Length;i++)
        {
            if(weight[i]> threshold)
            {
                if (outputNeurons[i].state > 0)
                {
                    outputNeurons[i].state += state;
                }
                outputNeurons[i].state = state;
            }
            else
            {
                outputNeurons[i].state = 0;
            }

        }
    }
}
