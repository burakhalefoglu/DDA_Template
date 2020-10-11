using UnityEngine;
using System.Collections;

// Note: this is not an editor script.
public class TargetSpawner : MonoBehaviour
{
  
    public GameObject SpawnObject;

    public void BuildObject()
    {
        GameObject obj= Instantiate(SpawnObject, new Vector3(0, 0, 0), Quaternion.identity);
        obj.transform.SetParent(this.gameObject.transform, false);


    }


}