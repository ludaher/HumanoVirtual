using Assets.HAVIR.Scripts.Game.Main;
using Assets.HAVIR.Scripts.Game.Main.GraphModel;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Speech;

public class SpeechRegonizerManager : IDisposable
{
    private IVoiceRecognizer _recognizer;
    private static SpeechRegonizerManager _manager;
    private Question _startQuestion;

    public static SpeechRegonizerManager Instance
    {
        get
        {
            if (_manager == null)
                _manager = new SpeechRegonizerManager();
                return _manager;
        }
    }

    public SpeechRegonizerManager()
    {
        _recognizer = new UnitySpeechRecognizer();
    }

    public void Dispose()
    {
        _recognizer.Dispose();
        _recognizer = null;
        _manager = null;
    }

    #region IVoiceRecognizer actions

    public Guid AddKeywordRecognition(Question sourceNode, Answer arista, bool startInmmediately = false)
    {
        return _recognizer.AddKeywordRecognition(sourceNode, arista, startInmmediately);
    }

    public void InitRecognizer(bool dictation, bool keywordRecognation)
    {
        _recognizer.InitRecognizer(dictation, keywordRecognation);
        //_startQuestion.Execute();
    }

    internal void SetStartNode(Question question)
    {
        _startQuestion = question;
    }

    public void RemoveKeywordRecognition(Guid id)
    {
        _recognizer.RemoveKeywordRecognition(id);
    }

    public void StopKeywordRecognition(Guid id)
    {
        _recognizer.StopKeywordRecognition(id);
    }

    #endregion
}
