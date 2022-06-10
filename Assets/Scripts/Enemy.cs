using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] [Range(1f, 25f)] private float speed = 8f;
    private Player myPlayer;
   

    void Awake()
    {
        myPlayer = FindObjectOfType<Player>();
    }
   

    void Update()
    {
        float step = speed * Time.deltaTime;

        // move sprite towards the target location
        transform.position = Vector2.MoveTowards(transform.position, myPlayer.transform.position, step);
    }
    
}
