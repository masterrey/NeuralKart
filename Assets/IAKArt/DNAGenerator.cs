using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNAGenerator : MonoBehaviour
{
    public Neurons[] neurons;
    public int totalSize;
    

    // Start is called before the first frame update
    public void RandomStart()
    {
        for(int i=0;i<neurons.Length;i++)
        {
            for(int j=0;j<neurons[i].weight.Length;j++)
            {
                neurons[i].weight[j] = Random.Range(0.0f, 1.0f);
                totalSize++;
            }
        }
    }

    public float[] GetDNA()
    {
        float[] saida = new float[totalSize];
        int index = 0;
        for (int i = 0; i < neurons.Length; i++)
        {
            for (int j = 0; j < neurons[i].weight.Length; j++)
            {
                
                saida[index] = neurons[i].weight[j];
                index++;
            }
        }
        return saida;
    }

    public void SetDNA(float[] entrada)
    {
        
        int index = 0;
        for (int i = 0; i < neurons.Length; i++)
        {
            for (int j = 0; j < neurons[i].weight.Length; j++)
            {

                neurons[i].weight[j] = entrada[index];
                index++;
            }
        }
       
    }
    public void SetDNA(float[] entrada,int mutation)
    {

        int index = 0;
        for (int i = 0; i < neurons.Length; i++)
        {
            for (int j = 0; j < neurons[i].weight.Length; j++)
            {
                if (Random.Range(0, 100) < mutation)
                {
                    neurons[i].weight[j] = Random.Range(0.0f, 1.0f);
                }
                else
                {
                    neurons[i].weight[j] = entrada[index];
                   
                }

                index++;
            }
        }

    }
    public void SetDNA(float[] entrada, float[] entrada2, int mutation)
    {

        int index = 0;
        for (int i = 0; i < neurons.Length; i++)
        {
            for (int j = 0; j < neurons[i].weight.Length; j++)
            {
                if (Random.Range(0, 100) < mutation)
                {
                    neurons[i].weight[j] = Random.Range(0.0f, 1.0f);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        neurons[i].weight[j] = entrada[index];
                    }
                    else
                    {
                        neurons[i].weight[j] = entrada2[index];
                    }

                }

                index++;
            }
        }

    }


}
