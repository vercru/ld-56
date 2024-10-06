using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    private float Clock { get; set; }
    public float WalkingSpeed = 1.0f;
    public Transform PlayerTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Clock += Time.deltaTime;
        transform.position += transform.forward * WalkingSpeed * Time.deltaTime;
        Debug.Log(transform.forward);

        if (Clock > 5)
        {
            Clock -= 5;
            Debug.Log("Click");

            transform.LookAt(PlayerTransform);
            // transform.rotation = Quaternion.Euler(0, transform.rotation.y, 0);

            // var vector = new Vector2(transform.position.x, transform.position.z);
            //
            // var playerVector = new Vector2(PlayerTransform.position.x, PlayerTransform.position.z);
            // var turnValue = Mathf.Acos(vector.magnitude / playerVector.magnitude) * Mathf.Rad2Deg;
            // Debug.Log("Current stats: " + vector.magnitude + " " + playerVector.magnitude + " " + turnValue);
            // transform.Rotate(0, turnValue + 180, 0);
        }
    }
}
