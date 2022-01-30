using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class LeanLocalizedTextMeshProUGUIClip : PlayableAsset, ITimelineClipAsset
{
    public LeanLocalizedTextMeshProUGUIBehaviour template = new LeanLocalizedTextMeshProUGUIBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<LeanLocalizedTextMeshProUGUIBehaviour>.Create (graph, template);
        return playable;
    }
}
