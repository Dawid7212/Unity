using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomCubesGenerator : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public int objectCount = 10;
    public float delay = 3.0f;
    int objectCounter = 0;
    public float wysokosc = 0f;
    public GameObject block;
    public Material[] materialy;

    void Start()
    {
        Renderer platformRenderer = GetComponent<Renderer>();
        Bounds platformBounds = platformRenderer.bounds;
        float minX = platformBounds.min.x;
        float maxX = platformBounds.max.x;
        float minZ = platformBounds.min.z;
        float maxZ = platformBounds.max.z;
        
        for(int i = 0; i < objectCount; i++)
        {
            float randomX = UnityEngine.Random.Range(minX, maxX);
            float randomZ = UnityEngine.Random.Range(minZ, maxZ);
            float posY = platformBounds.max.y + wysokosc+0.5f;
    
            this.positions.Add(new Vector3(randomX, posY, randomZ));
        }
        
        foreach(Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {
        
    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        
        foreach(Vector3 pos in positions)
        {
            GameObject instantiatedObject = Instantiate(
                this.block, 
                this.positions.ElementAt(this.objectCounter++), 
                Quaternion.identity
            );
            
            if (materialy != null && materialy.Length > 0)
            {
                Renderer objectRenderer = instantiatedObject.GetComponent<Renderer>();
                
                if (objectRenderer != null)
                {
                    int randomIndex = UnityEngine.Random.Range(0, materialy.Length);
                    objectRenderer.material = materialy[randomIndex];
                }
            }
            
            yield return new WaitForSeconds(this.delay);
        }
        
        StopCoroutine(GenerujObiekt());
    }
}
