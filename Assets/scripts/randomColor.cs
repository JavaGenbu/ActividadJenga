using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class randomColor : MonoBehaviour
{
    // Start is called before the first frame update
    
    System.Random random = new System.Random(); 
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
        int num = random.Next(1,4);
        StartCoroutine("Esperar");
        if (num == 1){
            Debug.Log("Siguiente Color Rojo)");
            StartCoroutine("Esperar");
        }else if(num==2){
            Debug.Log("Siguiente Color Verde)");
            StartCoroutine("Esperar");
        }else{
            Debug.Log("Siguiente Color Azul)");
            StartCoroutine("Esperar");
        }
        
        

    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(2f);
    }
}
