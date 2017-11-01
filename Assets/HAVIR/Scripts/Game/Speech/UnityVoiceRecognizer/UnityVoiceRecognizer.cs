using Assets.HAVIR.Scripts.Game.Main.GraphModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class UnitySpeechRecognizer : IVoiceRecognizer
{

    #region Private parameters

    private DictationRecognizer _dictationRecognizer;
    private Dictionary<Guid, KeywordRecognizer> _recognizerDictionary;
    private List<string> _keywords;
    #endregion


    public UnitySpeechRecognizer()
    {
        _recognizerDictionary = new Dictionary<Guid, KeywordRecognizer>();
        _dictationRecognizer = new DictationRecognizer();
        _keywords = new List<string>();
    }

    #region IVoiceRecognizer implementation

    public Guid AddKeywordRecognition(Question sourceNode, Answer arista, bool startInmmediately = false)
    {
        var id = Guid.NewGuid();
        var newKeywords = arista.Choices.Except(_keywords).ToList();
        if (newKeywords.Any() == false)
            return Guid.Empty;
        var recognizer = new KeywordRecognizer(newKeywords.ToArray());
        recognizer.OnPhraseRecognized += OnPhraseRecognizedHandler;
        if (startInmmediately)
            recognizer.Start();
        _keywords.AddRange(newKeywords);
        _recognizerDictionary.Add(id, recognizer);
        return id;
    }

    public void InitRecognizer(bool dictation, bool keywordRecognation)
    {
        if (dictation)
            _dictationRecognizer.Start();
        foreach (var recognizer in _recognizerDictionary)
        {
            recognizer.Value.Start();
        }
    }

    public void RemoveKeywordRecognition(Guid id)
    {
        KeywordRecognizer recognizer;
        if (_recognizerDictionary.TryGetValue(id, out recognizer))
        {
            recognizer.Stop();
            recognizer.Dispose();
            _recognizerDictionary.Remove(id);
        }
    }

    public void StopKeywordRecognition(Guid id)
    {
        KeywordRecognizer recognizer;
        if (_recognizerDictionary.TryGetValue(id, out recognizer))
        {
            recognizer.Stop();
        }
    }

    /// <summary>
    /// Manejador de enventos del reconocedor de palabras clave.
    /// Ejecuta las acciones dependiendo lo reconocido.
    /// </summary>
    /// <param name="args"></param>
    private void OnPhraseRecognizedHandler(PhraseRecognizedEventArgs args)
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendFormat("Recognizer - {0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tRecognizer - Timestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tRecognizer - Duration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        //if (_sourceNode.IsRunning == false)
        //    return;
        //if (_arista.Choices.Any(x => x.Equals(args.text)))
        //{
        //    _arista.Target.GraphAction.Invoke(args.text);
        //}
    }


    public void Dispose()
    {
        foreach (var recognizer in _recognizerDictionary)
        {
            recognizer.Value.Dispose();
        }
    }
    #endregion
}
