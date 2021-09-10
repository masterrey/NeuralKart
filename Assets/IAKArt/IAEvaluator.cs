using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEvaluator : MonoBehaviour
{
    public GameObject[] karts;
    public GameObject kartPrefab;
    public GameObject[] trackStarts;
    IASelfCounter[] counters;
    DNAGenerator[] gens;
    // Start is called before the first frame update
    void Start()
    {
        gens = new DNAGenerator[trackStarts.Length];
        karts = new GameObject[trackStarts.Length];
        counters = new IASelfCounter[trackStarts.Length];
        for (int i=0;i< trackStarts.Length; i++)
        {
            karts[i] = Instantiate(kartPrefab, trackStarts[i].transform.position, trackStarts[i].transform.rotation);
            karts[i].name = karts[i].name + i.ToString();
            gens[i] = karts[i].GetComponentInChildren<DNAGenerator>();
            gens[i].RandomStart();
            counters[i]= karts[i].GetComponentInChildren<IASelfCounter>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Array.Sort(counters,(obj1,  obj2) => obj2.waypassed.CompareTo(obj1.waypassed));

            print(counters[0].gameObject.transform.parent.gameObject.name);

            float[] bestdna = counters[0].dna.GetDNA();

            for (int i=0;i< trackStarts.Length; i++)
            {
                // gens[i].SetDNA(bestdna,2);
                gens[i].SetDNA(counters[0].dna.GetDNA(), counters[1].dna.GetDNA(), 10);
                karts[i].transform.position = trackStarts[i].transform.position;
                karts[i].transform.rotation = trackStarts[i].transform.rotation;
                counters[i].waypassed = 0;
            }
        }
    }
}
