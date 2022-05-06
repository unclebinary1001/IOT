using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //Debug.Log(animator);

    }

    // Update is called once per frame
    void Update()
    {
        int isWalkingHash = Animator.StringToHash("IsWalking");
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        bool isWalking = animator.GetBool(isWalkingHash);
        if (!isWalking && (forwardPressed|| backwardPressed))
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !(forwardPressed|| backwardPressed))
        {
            animator.SetBool(isWalkingHash, false);
        }
    }
}
