using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemies : MonoBehaviour
{  
    public NivelDeDificultad nivelDeDificultad;
        
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < nivelDeDificultad.cantEnemigos; i++)
        {
            GameObject o = nivelDeDificultad.prefabs[Random.Range(0, nivelDeDificultad.prefabs.Length)];
            Vector3 spawnPoint = nivelDeDificultad.spawnPoints[Random.Range(0, nivelDeDificultad.spawnPoints.Length)];

            Instantiate(o, spawnPoint, new Quaternion());
        }
    }
}
