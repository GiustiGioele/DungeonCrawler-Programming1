using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Camera Camera;
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }


    void Update()
    {
        this.transform.position = offset + player.transform.position;
    }
}
