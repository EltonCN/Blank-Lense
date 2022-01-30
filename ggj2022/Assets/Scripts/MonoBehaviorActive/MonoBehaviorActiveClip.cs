using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class MonoBehaviorActiveClip : PlayableAsset, ITimelineClipAsset
{
    public MonoBehaviorActiveBehaviour template = new MonoBehaviorActiveBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<MonoBehaviorActiveBehaviour>.Create (graph, template);
        return playable;
    }
}
