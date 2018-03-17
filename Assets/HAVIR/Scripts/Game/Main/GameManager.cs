using Assets.HAVIR.Scripts.Game.Main;
using Assets.HAVIR.Scripts.Game.Main.GraphModel;
using Crosstales.RTVoice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class GameManager : MonoBehaviour, IDisposable
{
    SpeechRegonizerManager _speechManager;
    VoiceManager _voiceManager;
    private List<Question> _graph;
    Dictionary<string, System.Action> keywords = new Dictionary<string, Action>();
    private KeywordRecognizer keywordRecognizer;

    void Start()
    {
        _InitVoice();
        _InitRecognizer(true, true);

    }
    private void OnPhraseRecognizedHandler(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("Recognizer - {0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tRecognizer - Timestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tRecognizer - Duration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());

        Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }

    private void Facebook()
    {
        //WindowsVoice.clearSpeechQueue();
        VoiceManager.Instance.AddToSpeechQueue("Estamos abriendo facebook");
        //Application.OpenURL("https://www.facebook.com/");
    }

    private void PrintAction()
    {
        Debug.Log("hola");
    }
    private void _InitVoice()
    {
        _voiceManager = VoiceManager.Instance;
    }

    void OnDestroy()
    {
        this.Dispose();
    }

    private void _InitRecognizer(bool dictation, bool keywordRecognation)
    {
        _speechManager = SpeechRegonizerManager.Instance;
        if (keywordRecognation == true)
        {
            _LoadGraphToRecognizerManager();
        }
        _speechManager.InitRecognizer(dictation, keywordRecognation);

    }

    private void _LoadGraphToRecognizerManager()
    {
        _graph = GraphMapper.GetGraphNodes();
        _speechManager.SetStartNode(_graph.Where(x => x.Type == NodeType.Start).FirstOrDefault());
        foreach (var node in _graph)
        {
            foreach (var arista in node.Answer)
            {
                arista.Target = _graph.FirstOrDefault(x => x.Id.Equals(arista.TargetId));
                arista.Target.Parent = node;
                if (node.Type == NodeType.Decision)
                    _speechManager.AddKeywordRecognition(node, arista);
            }
        }
    }

    public void Dispose()
    {
        _voiceManager.Dispose();
        _speechManager.Dispose();
    }
}