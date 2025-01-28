using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset= new Vector3(20, 3, 9);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        // 固定摄像机的旋转角度，不随玩家旋转
        transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}
