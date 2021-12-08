using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IS_EnemyMove : MonoBehaviour
{
[SerializeField]
private float speed;
[SerializeField]
//private Vector3[] positions;
public Transform[] ways;
//public bool facingleft;
 //float horizontal;
   
private int index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //horizontal = Input.GetAxisRaw("Horizontal");
    Vector2 localScale = transform.localScale;
        transform.position = Vector2.MoveTowards(transform.position,ways[index].position, Time.deltaTime * speed);
    
        if (transform.position == ways[index].position)
        { 
            if(index == ways.Length -1)
            {
                index=0;
            }
        else
        {
            index++;
        }
     if(index == 0)
        {   
            localScale.x *= -1;
         }
         else
         {   
            localScale.x *= -1;
         }
         transform.localScale = localScale;
        }
    }


}
