using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour
{
    LineRenderer line;
    public Transform startPoint;
    public Transform EndPoint;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    public IEnumerator LineTrigger()
    {
        yield return new WaitForSeconds(0.5f);
        line.SetPosition(0, startPoint.position);
        line.SetPosition(1, EndPoint.position);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(LineTrigger());
            Debug.Log("startPoint:" + startPoint);
            Debug.Log("EndPoint:" + EndPoint);
            Debug.Log("Trigger Exit");
        }
    }
}
