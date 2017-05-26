using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour {

    private List<GameObject> aiSeals;
    public Transform[] spawnLocations;
    public GameObject[] seals;

    public Transform target;

	// Use this for initialization
	void Start () {

        aiSeals = new List<GameObject>();
       
	}

    float timer;
    float timeElapsed;
    public float delay = 3f;
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            spawnSeals();
            timer = 0;
        }

        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 5f)
        {
            AdjustForMelt(1.015f);
            delay = delay * .8f;
            timeElapsed = 0;
        }
    }

    public float yOffset = 40f;
    public float strength = 600f;
    void spawnSeals()
    {
        int rand = Random.Range(0,2);
        int randor = Random.Range(0,seals.Length);
        GameObject g = Instantiate(seals[randor], spawnLocations[rand].position, Quaternion.Euler(0, 0, 0)) as GameObject;
        Rigidbody2D rb = g.GetComponent<Rigidbody2D>();

        rb.AddForce((new Vector3(target.position.x, target.position.y + yOffset, target.position.z) - g.transform.position).normalized * strength);
            
    }

    public void AdjustForMelt(float scale)
    {
        yOffset *=  scale;
        strength *= scale;
    }
}
