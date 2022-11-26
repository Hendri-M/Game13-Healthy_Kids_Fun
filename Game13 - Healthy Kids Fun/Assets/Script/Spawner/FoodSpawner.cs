using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;
    // [SerializeField] GameObject[] post;
    [SerializeField] GameObject post;

    // Start is called before the first frame update
    void Start()
    {
        int spawn = Random.Range(0, prefabs.Length);
        // int pos = Random.Range(0, post.Length);

        GameObject newImage = Instantiate(prefabs[spawn], transform.position, Quaternion.identity);
        newImage.transform.SetParent(post.transform, true);
        // newImage.transform.SetParent(post[pos].transform, true);
    }

}
