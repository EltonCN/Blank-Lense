using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class ImageColorClip : PlayableAsset, ITimelineClipAsset
{
    public ImageColorBehaviour template = new ImageColorBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<ImageColorBehaviour>.Create (graph, template);
        return playable;
    }
}
