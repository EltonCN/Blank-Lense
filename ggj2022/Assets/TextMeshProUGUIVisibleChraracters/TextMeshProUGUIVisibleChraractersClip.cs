using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class TextMeshProUGUIVisibleChraractersClip : PlayableAsset, ITimelineClipAsset
{
    public TextMeshProUGUIVisibleChraractersBehaviour template = new TextMeshProUGUIVisibleChraractersBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<TextMeshProUGUIVisibleChraractersBehaviour>.Create (graph, template);
        return playable;
    }
}
