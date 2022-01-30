using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class PlayableDirectorSpeed : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    PlayableDirector director;
    // Start is called before the first frame update
    void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.playableGraph.GetRootPlayable(0).SetSpeed(speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
