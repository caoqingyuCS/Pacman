using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveplayerPos : MonoBehaviour
{
    public List<float> playery_pos;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
         InvokeRepeating("Player_Y", 0f, 0.25f);
    }

    // Update is called once per frame
    void Player_Y()
    {
        float pY = player.transform.position.y;
        playery_pos.Add(pY);
    }
}
