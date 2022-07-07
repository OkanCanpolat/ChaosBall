using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private bool isSolved = false;

    //if correct ball enter the trigger area destroy the ball and disable the goal's light
    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            GetComponent<Light>().enabled = false;
            Destroy(collidedWith);
        }
    }

    public bool _isSolved
    {
        get
        {
            return isSolved;
        }
    }

    

}
