using UnityEngine;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Zad5 : MonoBehaviour
{
    public GameObject cubePrefab;
    public int ilosc = 10;   
    private List<Vector2> uzywane = new List<Vector2>();

    async void Start()
    {
        for (int i = 0; i < ilosc; i++)
        {
            Vector2 pos2D;
            do
            {
                float x = Mathf.Round(Random.Range(-5f, 5f));
                float z = Mathf.Round(Random.Range(-5f, 5f));
                pos2D = new Vector2(x, z);
            }
            while (uzywane.Contains(pos2D));

            uzywane.Add(pos2D);

            Vector3 spawnPos = new Vector3(pos2D.x, 0.5f, pos2D.y);
            Instantiate(cubePrefab, spawnPos, Quaternion.identity);

            await Task.Delay(1000);
        }
    }
}
