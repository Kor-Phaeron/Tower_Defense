using UnityEngine;

public class Enemy: MonoBehaviour
{
    public float speed = 10f;
    public Transform target;
    private int wavepointIndex = 0;

    void Start ()
    {
        Debug.Log(Waypoints.points[0].name + " this is from start");
        target = Waypoints.points[0];
    }

    void Update ()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }

}