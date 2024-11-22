using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCScript : MonoBehaviour
{
    public NavMeshAgent nma;

    public GameObject arrivedHomeTextObject;
    public GameObject clickToBeginTextObject;

    float amountRotated = 0;

    Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;

        StartCoroutine(ChairBehavior());
    }

    // This function was used to "get myself into trouble" and show an example when
    // coroutines can be helpful
    void UpdatePartOneOfExample()
    {
        // 1. Find nearest chair
        GameObject nearestChair = getNearestChair();

        // 2. Walk to nearest chair using a navmesh
        if (nearestChair != null) {
            nma.SetDestination(nearestChair.transform.position);

            // 3. Do a spin when arrived
            float distToChair = Vector3.Distance(transform.position, nearestChair.transform.position);
            if (distToChair < 0.3f) {
                float amountToRotate = 40 * Time.deltaTime;
                transform.Rotate(0, amountToRotate, 0);
                amountRotated += amountToRotate;
                if (amountRotated > 360) {
                    // We finished rotating!
                    // 4. Go back to where I started
                    nma.SetDestination(startPosition);
                }
            }
        }
    }

    IEnumerator ChairBehavior()
    {
        // 0. Click to begin behavior
        while(!Input.GetMouseButtonDown(0)) {
            yield return null;
        }
        clickToBeginTextObject.SetActive(false);

        // 1. Find nearest chair
        GameObject nearestChair = getNearestChair();

        // 2. Walk to nearest chair using a navmesh
        if (nearestChair != null) {
            nma.SetDestination(nearestChair.transform.position);
            float distToChair = Vector3.Distance(transform.position, nearestChair.transform.position);
            while (distToChair < 0.3f) {
                yield return null; // Hey, I'm done with this function right now. Check in RIGHT HERE after you finish this update cycle
                distToChair = Vector3.Distance(transform.position, nearestChair.transform.position);
            }
            
            // 3. Do a spin when arrived
            while (amountRotated < 360) {
                float amountToRotate = 90 * Time.deltaTime;
                transform.Rotate(0, amountToRotate, 0);
                amountRotated += amountToRotate;

                yield return null;
            }

            // We finished rotating!
            // 4. Go back to where I started
            nma.SetDestination(startPosition);

            float distToStartPosition = Vector3.Distance(transform.position, startPosition);
            while (distToStartPosition > 0.3f) {
                yield return null; // Hey, I'm done with this function right now. Check in RIGHT HERE after you finish this update cycle
                distToStartPosition = Vector3.Distance(transform.position, startPosition);
            }

            // 5. Put up a message
            arrivedHomeTextObject.SetActive(true);

            yield return new WaitForSeconds(1);

            arrivedHomeTextObject.SetActive(false);
        }
    }

    GameObject getNearestChair()
    {
        GameObject[] chairs = GameObject.FindGameObjectsWithTag("chair");

        GameObject closest = null;
        float distanceToClosest = 999999999999;

        for (int i = 0; i < chairs.Length; i++) {
            float dist = Vector3.Distance(transform.position, chairs[i].transform.position);
            if (dist < distanceToClosest) {
                closest = chairs[i];
                distanceToClosest = dist;
            }
        }

        return closest;
    }
}
