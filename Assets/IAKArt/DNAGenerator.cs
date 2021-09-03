using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNAGenerator : MonoBehaviour
{
    public Neurons[] neurons;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i<neurons.Length;i++)
        {
            for(int j=0;j<neurons[i].weight.Length;j++)
            {
                neurons[i].weight[j] = Random.Range(0, 10);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
