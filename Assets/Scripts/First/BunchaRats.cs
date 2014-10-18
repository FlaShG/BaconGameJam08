using UnityEngine;
using System.Collections;

public class BunchaRats : MonoBehaviour
{
    public BunchaRats next;
    public float speed = 4;

    public void MoveTo(Vector3 position)
    {
        if(next)
        {
            next.MoveTo(transform.position);
        }

        transform.position = Vector3.MoveTowards(transform.position, position, speed * Time.deltaTime);
        CheckTriggerPoints();
    }

    private Vector3 lastGridPosition;
    private void CheckTriggerPoints()
    {
        var gridPosition = transform.position;
        gridPosition.x = Mathf.Round(gridPosition.x);
        gridPosition.z = Mathf.Round(gridPosition.z);

        if(gridPosition != lastGridPosition)
        {
            RaycastHit hit;
            if(Physics.Raycast(gridPosition + Vector3.up * 10, Vector3.down, out hit, 10))
            {
                hit.collider.SendMessage("EnterSwarm", this, SendMessageOptions.DontRequireReceiver);
            }
        }

        lastGridPosition = gridPosition;
    }

    public void AddBunch()
    {

    }
}
