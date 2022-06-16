using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Nivel de Dificultad")]
public class NivelDeDificultad : ScriptableObject
{
    public int cantEnemigos;
    public Vector3[] spawnPoints;
    public GameObject[] prefabs;
}
