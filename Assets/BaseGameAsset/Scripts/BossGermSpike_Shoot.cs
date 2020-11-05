using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGermSpike_Shoot : MonoBehaviour
{
    public GameObject GermSpike;
    float timer = 0;
    float GermSpikeCount;
    float GermSpikeTransformX;
    float GermSpikeTransformY;
    float GermSpikeTransformZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 3 == 0)
            SpawnGermSpike();
    }

    void SpawnGermSpike()
    {
        timer += Time.deltaTime;
        if (timer > 1 && GermSpikeCount<10)
        {
            GermSpikeCount++;
            timer = 0;

                GermSpikeTransformX = Random.Range(this.transform.position.x - 10, this.transform.position.x + 10);
                GermSpikeTransformY = Random.Range(this.transform.position.y - 10, this.transform.position.y + 10);
                GermSpikeTransformZ = Random.Range(this.transform.position.z - 10, this.transform.position.z + 10);
               Vector3 position = new Vector3(GermSpikeTransformX, GermSpikeTransformY, GermSpikeTransformZ);
                Instantiate(GermSpike, position, this.transform.rotation);
            
        }
        if (GermSpikeCount == 10)
        {
            GermSpikeCount = 0;
            timer = -4;

        }

    }




}
