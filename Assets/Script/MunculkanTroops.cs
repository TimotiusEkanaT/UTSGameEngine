using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanTroops : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekTroops;

    // Start is called before the first frame update
    void Start()  {
        
    }

    // Update is called once per frame
    void Update() {
        timer += Time.deltaTime;
        if(timer > jeda)
        {
            int random = Random.Range(0, obyekTroops.Length);
            Instantiate(obyekTroops[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
